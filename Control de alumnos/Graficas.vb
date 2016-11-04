Public Class Graficas
    Dim gph As Integer = 1
    'funcion 1-------------------------+++++++++++++++++++++++++++++++++++++++++++++++++++
    Function cargarDatos()
        Dim controlUnidades As Integer = 0
        Dim vecUnidades(10) As Decimal
        Dim salida As String = ""
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
                    CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(Numero_de_subTextBox.Text), Nombre_de_la_unidadTextBox.Text, Materias.Text)
                    If CalificacionTextBox.Text <> "" Then
                        cal_temp = (Val(CalificacionTextBox.Text) * Val(PorcentajeTextBox1.Text)) / 100
                        vector(controlVector) = cal_temp.ToString
                        controlVector += 1
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
        salida = RFINAL.ToString
        Return salida
    End Function


    Function enlistar(ByVal path As String)
        If Grupos.Text <> "" Or Materias.Text <> "" Then
            Dim lista = 0
            Chart1.Series(0).Points.Clear()
            Dim html As New HtmlHandler
            html.createHtml()
            html.setTag("Reporte de aprobados y reprobados")
            html.setTag("Grupo: " + Grupos.Text)
            html.setTag("Materia: " + Materias.Text)
            html.initTable()
            AlumnosBindingSource.Position = 0
            While (lista < AlumnosBindingSource.Count)
                Dim data As String = cargarDatos()
                html.setTableRaw(NombreTextBox.Text, data)
                Chart1.Series(0).Points.AddXY(NombreTextBox.Text, Val(data))
                AlumnosBindingSource.MoveNext()
                lista += 1
            End While
            html.endTable()
            html.finishHtml()
            html.saveHtml(path)
            Try
                WebBrowser1.Navigate("file:///" + Application.StartupPath + "/temp/reporte.html")
            Catch ex3 As Exception
                MsgBox("Error de IO favor de reiniciar el sistema para corregir el problema")
            End Try
        End If

        Return 0
    End Function
    Private Sub Graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
            Me.MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, Grupos.Text)
            Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, Grupos.Text)
            'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Calificaciones' table. You can move, or remove it, as needed.
            Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
            'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Sub_unidad' table. You can move, or remove it, as needed.
            Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)
            'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Unidades' table. You can move, or remove it, as needed.
            Me.UnidadesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Unidades)


            Me.MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, Grupos.Text)
            Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, Grupos.Text)
            Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)
            enlistar("")
        Catch ex As Exception

            Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
            Me.MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, Grupos.Text)
            Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, Grupos.Text)
            'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Calificaciones' table. You can move, or remove it, as needed.
            Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
            'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Sub_unidad' table. You can move, or remove it, as needed.
            Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)
            'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Unidades' table. You can move, or remove it, as needed.
            Me.UnidadesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Unidades)




            Me.MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, Grupos.Text)
            Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, Grupos.Text)
            Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)
            enlistar("")
        End Try

    End Sub

    Private Sub Grupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grupos.SelectedIndexChanged
        Try
            Me.MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, Grupos.Text)
            Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, Grupos.Text)
            Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)

        Catch ex As Exception
            Me.MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, Grupos.Text)
            Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, Grupos.Text)
            Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)

        End Try
        enlistar("")
    End Sub



    Private Sub Materias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Materias.SelectedIndexChanged
        Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)
        enlistar("")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Grupos.Text = "" Or Materias.Text = "" Then
            MsgBox("No se puede exportar un reporte en blanco")
        Else
            Dim folder As New FolderBrowserDialog
            If folder.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)
                enlistar(folder.SelectedPath + "\" + Grupos.Text + " Reporte aprobados y reprobados.html")

            End If

        End If



    End Sub

    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        If gph = 1 Then
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.InitialDirectory = "C:\"
            SaveFileDialog1.FileName = "Reporte grupal"
            SaveFileDialog1.Filter = " IMAGENES PNG *.png | .png"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim ruta = SaveFileDialog1.FileName
                Chart1.SaveImage(ruta, System.Drawing.Imaging.ImageFormat.Png)
            End If
        ElseIf gph = 2 Then
            If Grupos.Text = "" Or Materias.Text = "" Then
                MsgBox("No se puede exportar un reporte en blanco")
            Else
                Dim folder As New FolderBrowserDialog
                If folder.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)
                    enlistar(folder.SelectedPath + "\" + Grupos.Text + " Reporte aprobados y reprobados.html")

                End If

            End If

        End If


    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Me.UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, Materias.Text)
        enlistar("")
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.InitialDirectory = "C:\"
        SaveFileDialog1.FileName = "Reporte grupal"
        SaveFileDialog1.Filter = " Imagen PNG *.png | .png"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ruta = SaveFileDialog1.FileName
            Chart1.SaveImage(ruta, System.Drawing.Imaging.ImageFormat.Png)
        End If
    End Sub



    Private Sub TabPage2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        gph = 2

    End Sub

    Private Sub TabPage1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        gph = 1
    End Sub
End Class