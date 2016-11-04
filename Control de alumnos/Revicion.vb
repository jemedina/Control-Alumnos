Imports System.IO

Public Class Revicion
    Dim REPORT As String = ""
    Dim SUBS As String = ""
    Dim jumpLine As String = vbCrLf
    Dim vecUnidades(10) As Decimal
    Dim controlUnidades As Integer = 0




    Function cargarDatos()
        Dim salida As String = ""
        REPORT = ""
        SUBS = ""
        'se carga el nombre del alumno de la lista principal
        nombreLabel.Text = ListBox1.GetItemText(ListBox1.Text)
        'Se carga la materia desde el combobox de la materia
        materiaLabel.Text = MATERIER.Text

        Try
            Dim vector(100) As String
            Dim controlVector As Integer = 0
            Dim t = 0
            Dim p = 0
            Dim y = 0
            Dim cal_temp As Decimal = 0
            UnidadesBindingSource.MoveFirst()
            While t < UnidadesBindingSource.Count


                Sub_unidadTableAdapter.filtrarSubUnidades(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, Nombre_de_la_unidadTextBox.Text)
                While y < Sub_unidadBindingSource.Count
                    CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(Numero_de_subTextBox.Text), Nombre_de_la_unidadTextBox.Text, MATERIER.Text)
                    If CalificacionTextBox.Text <> "" Then
                        cal_temp = (Val(CalificacionTextBox.Text) * Val(PorcentajeTextBox1.Text)) / 100
                        vector(controlVector) = cal_temp.ToString
                        controlVector += 1
                        SUBS += "<tr><td>Subunidad: " + (t + 1).ToString + "." + Numero_de_subTextBox.Text + "</td><td>" + "Valor: " + PorcentajeTextBox1.Text + "%</td><td>" + "Calificacion parcial: " + CalificacionTextBox.Text + "</td><td>" + "Califciacion total: " + cal_temp.ToString + "</td></tr>"
                    End If

                    Sub_unidadBindingSource.MoveNext()
                    y += 1
                End While
                vector(controlVector) = "**"
                controlVector += 1
                y = 0
                Dim R As String = vector(p)
                Dim N As Decimal = 0

                While R <> "**"
                    R = vector(p)
                    N += Val(R)
                    p += 1
                End While
                Dim ct = (N * Val(PorcentajeTextBox.Text)) / 100
                vecUnidades(controlUnidades) = ct
                controlUnidades += 1
                REPORT += "<tr><td>Unidad: " + Numero_de_la_unidadTextBox.Text + "</td><td>" + "Valor: " + PorcentajeTextBox.Text + "%" + "</td><td>" + "Calificacion parcial: " + N.ToString + "</td><td>" + "Calificacion total: " + ct.ToString + "</td></tr>"
                UnidadesBindingSource.MoveNext()
                t += 1
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim b = 0
        Dim RFINAL As Decimal
        While b < controlUnidades
            RFINAL += vecUnidades(b)
            b += 1
        End While
        avanceLabel.Text = RFINAL.ToString
        If SUBS <> "" Then
            SUBS = "<table><tr><td>SUBUNIDADES: </td></tr>" + SUBS + "</table>"
        End If
        If REPORT <> "" Then
            REPORT = "<table><tr><td>UNIDADES: </td></tr>" + REPORT + "</table>"
        End If
        controlUnidades = 0
        If nombreLabel.Text = "" Then
            salida = "<h2>Seleccione algún alumno de la lista</h3>"
        ElseIf avanceLabel.Text = "0" Then
            salida = "<h2>El alumno tiene todas sus sub unidades y unidades en 0</h3>"
        Else
            salida = SUBS + "<br><br>" + REPORT
        End If
        Return salida
    End Function


    Function generarHTML(ByRef cont As String)
        Dim html As String
        html = "<!DOCTYPE html><html><head><meta charset='UTF-8'/><title>Reporte calificacion</title><style type='text/css'>table, tr, td{border: solid 1px black;}td{text-align: center;}</style></head><body>"
        html += cont
        html += "</body></html>"
        Return html
    End Function

    Function cargarRegistro()
        Try
            Dim escritor As StreamWriter
            escritor = New StreamWriter(Application.StartupPath + "/temp/salida.html")
            escritor.Write(generarHTML(cargarDatos()))
            escritor.Close()
        Catch ex As Exception
            MkDir("temp")
            Try
                Dim escritor As StreamWriter
                escritor = New StreamWriter(Application.StartupPath + "/temp/salida.html")
                escritor.Write(generarHTML(cargarDatos()))
                escritor.Close()
            Catch ex2 As Exception
                MsgBox("Error de IO (Entrada - Salida)" + vbCrLf + ex2.ToString)
            End Try
        End Try
        'Carga para el navegador
        Try
            WebBrowser1.Navigate("file:///" + Application.StartupPath + "/temp/salida.html")
        Catch ex3 As Exception
            MsgBox("Error de IO favor de reiniciar el sistema para corregir el problema")
        End Try
        Return 0
    End Function




    Private Sub Revicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Sub_unidad' table. You can move, or remove it, as needed.
        Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Se cargan los datos para las tablas que se usaran
        Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
        'se termina la carga general de tablas >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Try
            'Aqui se llena la lista de alumnos que pertenecen al grupo seleccionado en el primer combobox
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, ComboBox1.Text)

            'Se cargan las materias que pertenecen al grupo en el primer combobox
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, ComboBox1.Text)

            'Se cargan las unidades de la materia seleccionada
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, MATERIER.Text)

            'Se ejecuta la funcion que llena el cuaro de datos al cargar los modulos y el formulario...
            cargarRegistro()
        Catch ex As Exception
            'Aqui se llena la lista de alumnos que pertenecen al grupo seleccionado en el primer combobox
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, ComboBox1.Text)

            'Se cargan las materias que pertenecen al grupo en el primer combobox
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, ComboBox1.Text)

            'Se cargan las unidades de la materia seleccionada
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, MATERIER.Text)

            'Se ejecuta la funcion que llena el cuaro de datos al cargar los modulos y el formulario...
            cargarRegistro()
        End Try

       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        '<<<<<< En caso de que se cambie el combobox de los grupos se vuelve a filtrar la lista de alumnos y de materias
        Try
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, ComboBox1.Text)
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, ComboBox1.Text)
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, MATERIER.Text)

        Catch ex As Exception
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, ComboBox1.Text)
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, ComboBox1.Text)
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, MATERIER.Text)

        End Try
       
        cargarRegistro()
        'ademas se ejecuta la funcion de llenar el cuadro. Aqui termina el filtrado. >>>>>>>>>>


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        cargarRegistro()

    End Sub

    Private Sub MATERIER_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATERIER.SelectedIndexChanged
        UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, MATERIER.Text)
        cargarRegistro()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.UnidadesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Unidades)
        Me.MateriasTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Materias)
        Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
        Me.AlumnosTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Alumnos)
        Me.Close()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Se cargan los datos para las tablas que se usaran
        Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
        'se termina la carga general de tablas >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        'Aqui se llena la lista de alumnos que pertenecen al grupo seleccionado en el primer combobox
        AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, ComboBox1.Text)

        'Se cargan las materias que pertenecen al grupo en el primer combobox
        MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, ComboBox1.Text)

        'Se cargan las unidades de la materia seleccionada
        UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, MATERIER.Text)

        'Se ejecuta la funcion que llena el cuaro de datos al cargar los modulos y el formulario...
        cargarRegistro()
    End Sub



    Private Sub IrACapturaDeCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrACapturaDeCalificacionesToolStripMenuItem.Click
        Calif.Show()

    End Sub

    Private Sub IrAConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrAConfiguracionToolStripMenuItem.Click
        Gestion.Show()

    End Sub

    Private Sub IrAGraficasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrAGraficasToolStripMenuItem.Click
        Graficas.Show()

    End Sub
End Class