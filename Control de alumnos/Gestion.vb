Public Class Gestion
    Dim ayuda As Integer = 1

    Function stopModes()
        Button13.Visible = False
        BotonBorrarAlumnos.Visible = True
        MatriculaTextBox.Enabled = False
        ComboBox7.Visible = False
        ComboBox4.Visible = True
        nombreControl.Visible = False
        Button14.Visible = False
        Button12.Enabled = True
        Label11.Visible = False
        ListBox1.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        GRUPER.Enabled = True
        Label12.Text = "Matricula"
        Button11.Enabled = True


        Button18.Visible = False
        Button19.Visible = False
        Button8ESLIMINAR.Visible = True
        Button16.Enabled = True
        MateriasDataGridView.Enabled = True
        ComboBox6.Enabled = True
        TextBox9.Enabled = True
        MateriaTextBox.Enabled = False



        Nro_de_grupoTextBox.ReadOnly = True
        Button4.Visible = False
        Button5.Visible = False
        Button2.Enabled = True
        Nro_de_grupoTextBox.Text = GruposOldText
        GruposOldText = ""
        ListBox2.Enabled = True
        Return 0
    End Function
    Function IsLetra(ByVal n As System.Windows.Forms.KeyPressEventArgs)
        Dim regreso As Boolean
        If n.KeyChar.ToString = "A" Or n.KeyChar.ToString = "a" Or n.KeyChar.ToString = "B" Or n.KeyChar.ToString = "b" Or n.KeyChar.ToString = "C" Or n.KeyChar.ToString = "c" Or n.KeyChar.ToString = "D" Or n.KeyChar.ToString = "d" Or n.KeyChar.ToString = "E" Or n.KeyChar.ToString = "e" Or n.KeyChar.ToString = "F" Or n.KeyChar.ToString = "f" Or n.KeyChar.ToString = "G" Or n.KeyChar.ToString = "g" Or n.KeyChar.ToString = "H" Or n.KeyChar.ToString = "h" Or n.KeyChar.ToString = "I" Or n.KeyChar.ToString = "i" Or n.KeyChar.ToString = "J" Or n.KeyChar.ToString = "j" Or n.KeyChar.ToString = "K" Or n.KeyChar.ToString = "k" Or n.KeyChar.ToString = "L" Or n.KeyChar.ToString = "l" Or n.KeyChar.ToString = "M" Or n.KeyChar.ToString = "m" Or n.KeyChar.ToString = "N" Or n.KeyChar.ToString = "n" Or n.KeyChar.ToString = "O" Or n.KeyChar.ToString = "o" Or n.KeyChar.ToString = "p" Or n.KeyChar.ToString = "P" Or n.KeyChar.ToString = "Q" Or n.KeyChar.ToString = "q" Or n.KeyChar.ToString = "R" Or n.KeyChar.ToString = "r" Or n.KeyChar.ToString = "S" Or n.KeyChar.ToString = "s" Or n.KeyChar.ToString = "T" Or n.KeyChar.ToString = "t" Or n.KeyChar.ToString = "U" Or n.KeyChar.ToString = "u" Or n.KeyChar.ToString = "V" Or n.KeyChar.ToString = "v" Or n.KeyChar.ToString = "W" Or n.KeyChar.ToString = "w" Or n.KeyChar.ToString = "X" Or n.KeyChar.ToString = "x" Or n.KeyChar.ToString = "y" Or n.KeyChar.ToString = "Y" Or n.KeyChar.ToString = "Z" Or n.KeyChar.ToString = "z" Or n.KeyChar.ToString = "Ñ" Or n.KeyChar.ToString = "ñ" Or n.KeyChar.ToString = ChrW(Keys.Back) Then

            regreso = True


        End If
        Return regreso
    End Function
    Dim oldMatricula As String = ""
    Dim oldMateria As String = ""
    Dim GruposOldText As String = ""
    Private Sub GrupoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GrupoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Control_de_calificaciones_dbDataSet)
        GroupBox2.Visible = False
        GroupBox3.Visible = False

        GroupBox1.Visible = True



    End Sub

    Private Sub Gestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UnidadesTotal.DataBindings.Add(New Binding("Text", Me.Control_de_calificaciones_dbDataSet, "Unidades.Data"))

        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Calificaciones' table. You can move, or remove it, as needed.
        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Sub_unidad' table. You can move, or remove it, as needed.
        Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)
        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet1.Alumnos' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Unidades' table. You can move, or remove it, as needed.
        Me.UnidadesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Unidades)
        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Materias' table. You can move, or remove it, as needed.
        Me.MateriasTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Materias)
        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Alumnos)
        'TODO: This line of code loads data into the 'Control_de_calificaciones_dbDataSet.Grupo' table. You can move, or remove it, as needed.
        Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)





        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        ComboBox7.Visible = False


        MenuGrupos.Focus()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text <> "" Then
                GrupoTableAdapter.InsertQuery(TextBox1.Text)

                Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
                Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

                TextBox1.Text = ""
            End If

        Catch ex As Exception
            MsgBox("No repetir grupos")
            TextBox1.Text = ""

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (Nro_de_grupoTextBox.Text <> "") Then
            Nro_de_grupoTextBox.ReadOnly = False
            Button4.Visible = True
            Button5.Visible = True
            GruposOldText = Nro_de_grupoTextBox.Text
            ListBox2.Enabled = False
            Button2.Enabled = False
        End If



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Nro_de_grupoTextBox.Text = "" Or Nro_de_grupoTextBox.Text = " " Then
            MsgBox("No puede no tener valor este campo, verifique...")
        Else

            Nro_de_grupoTextBox.ReadOnly = True
            Button4.Visible = False
            Button5.Visible = False
            Button2.Enabled = True

            Try
                Me.GrupoTableAdapter.UpdateQuery(Nro_de_grupoTextBox.Text, GruposOldText)
                Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
                Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)
                ListBox2.Enabled = True


                AlumnosTableAdapter.ActualizaGrupo_1(Nro_de_grupoTextBox1.Text, GruposOldText)
                CalificacionesTableAdapter.ActualizaGrupo_2(Nro_de_grupoTextBox1.Text, GruposOldText)
                MateriasTableAdapter.ActualizaGrupo_3(Nro_de_grupoTextBox1.Text, GruposOldText)
                UnidadesTableAdapter.ActualizaGrupo_5(Nro_de_grupoTextBox1.Text, GruposOldText)
                Sub_unidadTableAdapter.ActualizaGrupo_4(Nro_de_grupoTextBox1.Text, GruposOldText)

                Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
                Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)
                Me.UnidadesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Unidades)
                Me.MateriasTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Materias)

            Catch ex As Exception
                ' MsgBox(ex.ToString)
                MsgBox("Grupo existente, verifique")
                Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
                ListBox2.Enabled = True
            End Try
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ayuda = 1

        Nro_de_grupoTextBox.ReadOnly = True
        Button4.Visible = False
        Button5.Visible = False
        Button2.Enabled = True
        Nro_de_grupoTextBox.Text = GruposOldText
        GruposOldText = ""
        ListBox2.Enabled = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuGrupos.Click
        stopModes()
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox3.Visible = False
        GroupBox4.Visible = False

        MenuMaterias.ForeColor = Color.Black
        LabelDeUnidades.ForeColor = Color.Black
        MenuAlumnosAdmin.ForeColor = Color.Black

        MenuGrupos.ForeColor = Color.White
        Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox2.Visible = True

        GroupBox3.Visible = False

        GroupBox4.Visible = False
        GroupBox1.Visible = False

    End Sub


    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuAlumnosAdmin.Click
        ayuda = 2

        GroupBox2.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = True
        GroupBox4.Visible = False

        MenuMaterias.ForeColor = Color.Black
        LabelDeUnidades.ForeColor = Color.Black
        MenuAlumnosAdmin.ForeColor = Color.White

        MenuGrupos.ForeColor = Color.Black
        Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuMaterias.Click
        stopModes()
        ayuda = 3
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = True
        MenuMaterias.ForeColor = Color.White
        LabelDeUnidades.ForeColor = Color.Black
        MenuAlumnosAdmin.ForeColor = Color.Black

        MenuGrupos.ForeColor = Color.Black

        Try
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

        Catch ex As Exception
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If GRUPER.Text <> "" Then
            If TextBox7.Text <> "" And TextBox6.Text <> "" And GRUPER.Text <> "" Then
                If AlumnosTableAdapter.CheckNombre(Control_de_calificaciones_dbDataSet.Alumnos, TextBox6.Text) Then
                    MsgBox("Un alumno con este mismo nombre ya existe. Favor de verificar")
                Else
                    Try
                        AlumnosTableAdapter.InsertQuery(GRUPER.Text, TextBox7.Text, TextBox6.Text)
                        Me.AlumnosTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Alumnos)
                        TextBox6.Text = ""
                        TextBox7.Text = ""
                        Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

                    Catch ex As Exception
                        MsgBox("No repita matriculas")

                    End Try
                End If



            End If





        Else
            MsgBox("No puede capturar al alumno si no se ha registrado o seleccionado algun grupo")
        End If



    End Sub
    '--/* Se prepara el menu "alumnos" para modificar un registro */-- 
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If ComboBox4.Text <> "" Then


            'Rutinas para que podamos escribir un nuevo nombre del alumno
            Try
                ComboBox7.Text = GRUPER.Text
                nombreControl.Text = ComboBox4.Text
                nombreControl.Visible = True
                oldMatricula = MatriculaTextBox.Text
                ListBox1.Enabled = False

                Label12.Text = "Nueva Matricula"
                Label11.Visible = True

                'Se activa la casilla de matricula
                MatriculaTextBox.Enabled = True

                'Se inabilitan todos los botones del menu para que no se realizen cambios de ningun tipo mientras se esta editando el registro
                TextBox6.Enabled = False
                TextBox7.Enabled = False

                Button12.Enabled = False
                ComboBox4.Visible = False
                Button11.Enabled = False
                GRUPER.Enabled = False

                Button13.Visible = True
                Button14.Visible = True
                ComboBox7.Visible = True
                BotonBorrarAlumnos.Visible = False

                'ComboBox7.Text = GrupoTextBox.Text

            Catch errorsillo As Exception
                MsgBox(errorsillo.ToString)
            End Try
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        Button13.Visible = False
        BotonBorrarAlumnos.Visible = True
        MatriculaTextBox.Enabled = False
        ComboBox7.Visible = False
        ComboBox4.Visible = True
        nombreControl.Visible = False
        Button14.Visible = False
        Button12.Enabled = True
        Label11.Visible = False
        ListBox1.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        GRUPER.Enabled = True
        Label12.Text = "Matricula"
        Button11.Enabled = True
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        BotonBorrarAlumnos.Visible = True
        ListBox1.Enabled = True


        Button13.Visible = False
        Button14.Visible = False
        ComboBox4.Visible = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        Label12.Text = "Matricula"

        nombreControl.Visible = False
        Label11.Visible = False
        GRUPER.Enabled = True
        Button11.Enabled = True
        ComboBox7.Visible = False
        MatriculaTextBox.Enabled = False
        Button12.Enabled = True

        Try
            AlumnosTableAdapter.ACTUALIZAR(ComboBox7.Text, MatriculaTextBox.Text, nombreControl.Text, oldMatricula)
            oldMatricula = ""
            Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

        Catch ex As Exception
            MsgBox("Esa matricula ya esta registrada en otro alumno. Favor de verificar")
            Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

        End Try
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If (Nro_de_grupoTextBox1.Text <> "") Then
            If (MsgBox("Grupo: " + Nro_de_grupoTextBox1.Text + vbCrLf + "Advertencia!, Si elimina un grupo automaticamente se eliminaran el total de registros de alumnos, calificaciones y materias que estan relacionados con este." + vbCrLf + "¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Try
                    GrupoTableAdapter.eliminarPorGrupo_3(Nro_de_grupoTextBox1.Text)
                    AlumnosTableAdapter.eliminarPorGrupo_1(Nro_de_grupoTextBox1.Text)
                    CalificacionesTableAdapter.eliminarPorGrupo_2(Nro_de_grupoTextBox1.Text)
                    MateriasTableAdapter.eliminarPorGrupo_4(Nro_de_grupoTextBox1.Text)


                    Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
                    Me.Sub_unidadTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Sub_unidad)
                    Me.UnidadesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Unidades)
                    Me.MateriasTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Materias)
                    Me.AlumnosTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Alumnos)
                    Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)


                Catch ex As Exception
                    MsgBox("Error al eliminar en alguna de las tablas. Reinicie el sistema e intentelo de nuevo" + vbCrLf + "Detalles: " + ex.ToString)

                End Try

            End If
        End If


    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim mat As String

        If TextBox9.Text <> "" And TextBox9.Text <> " " Then
            mat = TextBox9.Text
            If MsgBox("Confirme que la materia '" + mat + "' esta correcta. ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


                Try
                    MateriasTableAdapter.InsertQuery(ComboBox6.Text, mat, ComboBox6.Text + "-" + mat)

                    TextBox9.Text = ""
                    Try
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)
                        UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)


                    Catch ex As Exception
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)
                        UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)

                    End Try

                Catch ex As Exception

                    MsgBox("No se permite repetir materias en un mismo grupo")




                End Try
            End If
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim unidTotal As Decimal
        If Val(TextBox3.Text) > 0 And ComboBox2.Text <> "" And ComboBox2.Text <> " " And ComboBox3.Text <> "" And ComboBox3.Text <> "0" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox3.Text <> "0" Then

            Try
                Me.UnidadesTableAdapter.SumarUnidades(Me.Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
                unidTotal = Val(UnidadesTotal.Text) + TextBox3.Text

            Catch ex As Exception
                Me.UnidadesTableAdapter.SumarUnidades(Me.Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
                unidTotal = Val(UnidadesTotal.Text) + TextBox3.Text
            End Try
            If unidTotal <= 100 Then

                If TextBox3.Text = "100" Then
                    If MsgBox("Esta a punto de agregar una sola unidad que llena el 100% de la materia. Esto puede ser un error. Porfavor verifique y cambie el valor de la unidad o de no ser ningun error porfavor presione el boton 'SI' de esta ventana.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then




                        Try
                            UnidadesTableAdapter.InsertQuery(ComboBox2.Text, TextBox2.Text, TextBox3.Text, "", ComboBox3.Text, ComboBox2.Text + " " + ComboBox3.Text, "Unidad " + ComboBox3.Text + " - " + TextBox2.Text + " (" + ComboBox2.Text + ")")
                            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
                            TextBox2.Text = ""
                            TextBox3.Text = ""
                            If Val(ComboBox3.Text) < 4 Then
                                ComboBox3.Text = (Val(ComboBox3.Text) + 1).ToString
                            End If
                        Catch ex As Exception
                            Dim ActualUnidad As Integer = Me.UnidadesBindingSource.Count

                            MsgBox("Esa unidad ya ha sido registrada." + vbCrLf + "Actualmente ha registrado " + ActualUnidad.ToString + " unidades en esta materia. Favor de verificar")
                            ComboBox3.Text = (ActualUnidad + 1).ToString
                        End Try
                    End If
                Else
                    Try
                        UnidadesTableAdapter.InsertQuery(ComboBox2.Text, TextBox2.Text, TextBox3.Text, "", ComboBox3.Text, ComboBox2.Text + " " + ComboBox3.Text, "Unidad " + ComboBox3.Text + " - " + TextBox2.Text + " (" + ComboBox2.Text + ")")
                        UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        If Val(ComboBox3.Text) < 4 Then
                            ComboBox3.Text = (Val(ComboBox3.Text) + 1).ToString
                        End If
                    Catch ex As Exception
                        Dim ActualUnidad As Integer = Me.UnidadesBindingSource.Count

                        MsgBox("Esa unidad ya ha sido registrada." + vbCrLf + "Actualmente ha registrado " + ActualUnidad.ToString + " unidades en esta materia. Favor de verificar")
                        ComboBox3.Text = (ActualUnidad + 1).ToString
                    End Try
                End If
            Else
                MsgBox("No puede registrar esta unidad ya que el valor sobrepasaria el 100% de la materia." + vbCrLf + "El total registrado actualmente de las unidades de esta materia es: " + UnidadesTotal.Text + "%." + vbCrLf + "Si permitimos agregar esta unidad con ese valor el total seria: " + unidTotal.ToString + "% lo cual produciria errores.")
                UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            End If
        End If


    End Sub



    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim subUnTotal As Decimal
        If ComboBox2.Text <> "" And ComboBox1.Text <> "" And ComboSubs.Text <> "" And TextBox5.Text <> "" And TextBox5.Text <> "0" And Val(TextBox5.Text) > 0 Then
            Try
                Sub_unidadTableAdapter.SumarSubUnidades(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
                subUnTotal = Val(DataTextBox.Text)
            Catch ex As Exception
                Sub_unidadTableAdapter.SumarSubUnidades(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
                subUnTotal = Val(DataTextBox.Text)
            End Try

            If (subUnTotal + Val(TextBox5.Text)) <= 100 Then
                If TextBox5.Text = "100" Then
                    If MsgBox("Esta a punto de agregar una sola subunidad que llena el 100% de la unidad. Esto puede ser un error. Porfavor verifique y cambie el valor de la subunidad o de no ser ningun error porfavor presione el boton 'SI' de esta ventana.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then



                        Try
                            Sub_unidadTableAdapter.InsertQuery(ComboBox1.Text, ComboSubs.Text, TextBox5.Text, "", ComboBox2.Text, ComboBox1.Text + " " + ComboSubs.Text)
                            Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)

                            TextBox5.Text = ""
                            If Val(ComboSubs.Text) < 4 Then
                                ComboSubs.Text = (Val(ComboSubs.Text) + 1).ToString
                            End If
                        Catch ex As Exception
                            MsgBox("Esa sub unidad ya fue registrada")
                            ComboSubs.Text = (Sub_unidadBindingSource.Count + 1).ToString

                        End Try

                    End If
                Else
                    Try
                        Sub_unidadTableAdapter.InsertQuery(ComboBox1.Text, ComboSubs.Text, TextBox5.Text, "", ComboBox2.Text, ComboBox1.Text + " " + ComboSubs.Text)
                        Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)

                        TextBox5.Text = ""
                        If Val(ComboSubs.Text) < 4 Then
                            ComboSubs.Text = (Val(ComboSubs.Text) + 1).ToString
                        End If
                    Catch ex As Exception
                        MsgBox("Esa sub unidad ya fue registrada")
                        ComboSubs.Text = (Sub_unidadBindingSource.Count + 1).ToString

                    End Try
                End If
            Else
                MsgBox("No puede registrar esta subunidad ya que el valor sobrepasaria el 100% de la unidad." + vbCrLf + "El total registrado actualmente de las subunidades de esta materia es: " + DataTextBox.Text + "%." + vbCrLf + "Si permitimos agregar esta subunidad con ese valor el total seria: " + (subUnTotal + Val(TextBox5.Text)).ToString + "% lo cual produciria errores.")
                Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)

            End If


        End If


    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRUPER.SelectedIndexChanged
        Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

    End Sub

   

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar <> ChrW(Keys.Enter) Then


            If e.KeyChar <> ChrW(Keys.Back) And Not IsNumeric(e.KeyChar) Or Len(TextBox1.Text) >= 3 And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If

        Else
            Try
                If TextBox1.Text <> "" Then
                    GrupoTableAdapter.InsertQuery(TextBox1.Text)

                    Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
                    Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

                    TextBox1.Text = ""
                End If

            Catch ex As Exception
                MsgBox("No repetir grupos")
                TextBox1.Text = ""

            End Try
        End If
    End Sub



    Private Sub Nro_de_grupoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nro_de_grupoTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> ChrW(Keys.Back) Or Len(Nro_de_grupoTextBox.Text) >= 3 And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not IsLetra(e) And e.KeyChar.ToString <> " " And e.KeyChar.ToString <> "ñ" And e.KeyChar.ToString <> "á" And e.KeyChar.ToString <> "é" And e.KeyChar.ToString <> "í" And e.KeyChar.ToString <> "ó" And e.KeyChar.ToString <> "ú" And e.KeyChar.ToString <> "´" Then
            e.Handled = True

        End If
    End Sub





    Private Sub nombreControl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombreControl.KeyPress
        If Not IsLetra(e) And e.KeyChar.ToString <> " " And e.KeyChar.ToString <> "ñ" And e.KeyChar.ToString <> "á" And e.KeyChar.ToString <> "é" And e.KeyChar.ToString <> "í" And e.KeyChar.ToString <> "ó" And e.KeyChar.ToString <> "ú" And e.KeyChar.ToString <> "´" Then
            e.Handled = True

        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) = True Or Len(ComboSubs.Text) > 0 Or e.KeyChar.ToString = "0" Then
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If



        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Or Len(TextBox5.Text) > 2 And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If Val(TextBox5.Text) >= 100 Then
            TextBox5.Text = "100"
        End If
        Try
            Dim pp As String = TextBox5.Text + e.KeyChar.ToString
            If Val(pp) > 100 Then
                TextBox5.Text = "100"
                e.Handled = True

            End If
        Catch ex As Exception

        End Try

        If Val(TextBox5.Text) < 0 Then

            TextBox5.Text = "0"
        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Or Len(TextBox3.Text) > 2 And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If Val(TextBox3.Text) >= 100 Then
            TextBox3.Text = "100"
        End If
        Try
            Dim pp As String = TextBox3.Text + e.KeyChar.ToString
            If Val(pp) > 100 Then
                TextBox3.Text = "100"
                e.Handled = True

            End If
        Catch ex As Exception

        End Try

        If Val(TextBox3.Text) < 0 Then

            TextBox3.Text = "0"
        End If

    End Sub



    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
        Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
        ComboBox3.Text = UnidadesBindingSource.Count + 1
        ComboSubs.Text = Sub_unidadBindingSource.Count + 1

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

        Catch ex As Exception
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

        End Try

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState Then
            GroupBox2.Size = New Size(957, 671)
            Me.Size = New Size(886, 730)
        Else
            GroupBox2.Size = New Size(596, 317)
            Me.Size = New Size(957, 446)
        End If
    End Sub



    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        'Len(TextBox7.Text.ToString) > 11 And
        If Not IsNumeric(e.KeyChar) Or Len(TextBox7.Text.ToString) > 11 Then
            If e.KeyChar.ToString = "-" Or e.KeyChar = ChrW(Keys.Back) Then

            Else
                e.Handled = True
            End If


        End If
    End Sub

    Private Sub MatriculaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MatriculaTextBox.KeyPress
        'Len(TextBox7.Text.ToString) > 11 And
        If Not IsNumeric(e.KeyChar) Or Len(TextBox7.Text.ToString) > 11 Then
            If e.KeyChar.ToString = "-" Or e.KeyChar = ChrW(Keys.Back) Then

            Else
                e.Handled = True
            End If


        End If
    End Sub




    Private Sub ListBox2_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        'Esto controla el error del datagridView de los GRUPOS NO ELIMINAR ESTE EVENTO DE ERROR - TAMPOCO ESTE COMENTARIO...
    End Sub

    Private Sub TextBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Enter
        If GRUPER.Text = "" Then
            MsgBox("Atencion! primero debe agregar grupos para poder capturar la lista de alumnos")
        End If
    End Sub

    Private Sub TextBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.Enter
        If GRUPER.Text = "" Then
            MsgBox("Atencion! primero debe agregar grupos para poder capturar la lista de alumnos")
        End If
    End Sub

    Private Sub TextBox7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        If AlumnosTableAdapter.CheckMatricula(Control_de_calificaciones_dbDataSet.Alumnos, TextBox7.Text) Then
            MsgBox("Esta matricula ya ha sido capturada anteriormente")
            TextBox7.Text = ""
            Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

        Else
            Me.AlumnosTableAdapter.SOLOALUMNOS(Me.Control_de_calificaciones_dbDataSet.Alumnos, GRUPER.Text)

        End If

    End Sub


    Private Sub BotonBorrarAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonBorrarAlumnos.Click
        If MsgBox("Si elimina el alumno se borraran con el los registros de sus calificaciones." + vbCrLf + "¿Desea continuar?", vbYesNo) = MsgBoxResult.Yes Then
            AlumnosTableAdapter.EliminarAlumno(MatriculaTextBox.Text)
            CalificacionesTableAdapter.EliminarAlimnoCalificaciones(MatriculaTextBox.Text)
            AlumnosTableAdapter.Fill(Control_de_calificaciones_dbDataSet.Alumnos)
            CalificacionesTableAdapter.Fill(Control_de_calificaciones_dbDataSet.Calificaciones)

        End If
    End Sub





    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUnidades.Click
        stopModes()
        ayuda = 4
        GroupBox2.Visible = True

        GroupBox3.Visible = False

        GroupBox4.Visible = False
        GroupBox1.Visible = False
        MenuMaterias.ForeColor = Color.Black
        LabelDeUnidades.ForeColor = Color.White
        MenuAlumnosAdmin.ForeColor = Color.Black

        MenuGrupos.ForeColor = Color.Black
        Try
            Me.MateriasTableAdapter.AgruparRepeticiones(Control_de_calificaciones_dbDataSet.Materias)
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
        Catch ex As Exception
            Me.MateriasTableAdapter.AgruparRepeticiones(Control_de_calificaciones_dbDataSet.Materias)
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
        End Try

        ComboBox3.Text = UnidadesBindingSource.Count + 1
        ComboSubs.Text = Sub_unidadBindingSource.Count + 1
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelDeUnidades.Click
        ayuda = 4
        GroupBox2.Visible = True

        GroupBox3.Visible = False

        GroupBox4.Visible = False
        GroupBox1.Visible = False
        MenuMaterias.ForeColor = Color.Black
        LabelDeUnidades.ForeColor = Color.White
        MenuAlumnosAdmin.ForeColor = Color.Black

        MenuGrupos.ForeColor = Color.Black
        Try
            Me.MateriasTableAdapter.AgruparRepeticiones(Control_de_calificaciones_dbDataSet.Materias)
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
        Catch ex As Exception
            Me.MateriasTableAdapter.AgruparRepeticiones(Control_de_calificaciones_dbDataSet.Materias)
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)
        End Try
      
        ComboBox3.Text = UnidadesBindingSource.Count + 1
        ComboSubs.Text = Sub_unidadBindingSource.Count + 1
    End Sub

    Private Sub ComboSubs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboSubs.KeyPress
        If IsNumeric(e.KeyChar) = False And e.KeyChar <> ChrW(Keys.Back) Or Len(ComboBox3.Text) > 1 And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True

        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If IsNumeric(e.KeyChar) = False And e.KeyChar <> ChrW(Keys.Back) Or Len(ComboBox3.Text) > 1 And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True

        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox1.Text)

        ComboSubs.Text = Sub_unidadBindingSource.Count + 1

    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

   

    Private Sub CerrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub EliminarTodosLosDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarTodosLosDatosToolStripMenuItem.Click
        If MsgBox("ATENCION! Esta a punto de borrar en su totalidad los registros de calificaciones. Esta es una accion ireversible. ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Form1.Show()
            Form1.borrar_todo()
            Form1.Focus()
        End If
    End Sub

    Private Sub MostrarMenuPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarMenuPrincipalToolStripMenuItem.Click
        Form1.Show()
        Form1.Focus()

    End Sub


    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If MateriaTextBox.Text <> "" Then


            oldMateria = MateriaTextBox.Text
            Button8ESLIMINAR.Visible = False
            Button18.Visible = True
            Button19.Visible = True
            Button16.Enabled = False
            MateriasDataGridView.Enabled = False
            ComboBox6.Enabled = False
            TextBox9.Enabled = False

            MateriaTextBox.Enabled = True
        End If

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If MateriaTextBox.Text <> "" And MateriaTextBox.Text <> " " Then
            If MsgBox("Si existen registros como calificaciones o unidades capturadas a esta materia se elminaran. ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Try
                    MateriasTableAdapter.UpdateMateria(MateriaTextBox.Text, ComboBox6.Text + "-" + MateriaTextBox.Text, oldMateria, ComboBox6.Text)
                    Try
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    Catch ex As Exception
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    End Try

                Catch ex As Exception
                    Try
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    Catch ex2 As Exception
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    End Try
                    MsgBox("No puede repetir materias dentro de un mismo grupo.")
                    Button18.Visible = False
                    Button19.Visible = False
                    Button8ESLIMINAR.Visible = True
                    Button16.Enabled = True
                    ComboBox6.Enabled = True
                    MateriasDataGridView.Enabled = True
                    MateriaTextBox.Enabled = False
                    TextBox9.Enabled = True
                End Try
                Try

                    CalificacionesTableAdapter.UpdateMateriaErrase(MateriaTextBox.Text)
                Catch ex As Exception
                    MsgBox("Error de unidades o calificaciones." + ex.ToString)
                    Button18.Visible = False
                    Button19.Visible = False
                    Button8ESLIMINAR.Visible = True
                    Button16.Enabled = True
                    ComboBox6.Enabled = True
                    MateriasDataGridView.Enabled = True
                    MateriaTextBox.Enabled = False
                    TextBox9.Enabled = True
                End Try

                Button18.Visible = False
                Button19.Visible = False
                Button8ESLIMINAR.Visible = True
                Button16.Enabled = True
                ComboBox6.Enabled = True
                MateriasDataGridView.Enabled = True
                MateriaTextBox.Enabled = False
                TextBox9.Enabled = True
            Else
                Button18.Visible = False
                Button19.Visible = False
                Button8ESLIMINAR.Visible = True
                Button16.Enabled = True
                MateriasDataGridView.Enabled = True
                ComboBox6.Enabled = True
                MateriaTextBox.Enabled = False
                TextBox9.Enabled = True
                Try
                    MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                Catch ex As Exception
                    MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                End Try
            End If
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button18.Visible = False
        Button19.Visible = False
        Button8ESLIMINAR.Visible = True
        Button16.Enabled = True
        MateriasDataGridView.Enabled = True
        ComboBox6.Enabled = True
        TextBox9.Enabled = True
        MateriaTextBox.Enabled = False
        Try
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

        Catch ex2 As Exception
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

        End Try
    End Sub

    Private Sub Button8ESLIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8ESLIMINAR.Click

        If MateriaTextBox.Text <> "" Then
            If MsgBox("¿Esta seguro de eliminar esta materia y todas las calificaciones con ella?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


                Try
                    MateriasTableAdapter.DeleteFromMaterias(ComboBox6.Text, MateriaTextBox.Text)

                    CalificacionesTableAdapter.UpdateMateriaErrase(MateriaTextBox.Text)
                    Try
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    Catch ex As Exception
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    End Try
                Catch ex As Exception
                    MsgBox("Ocurrio un error al eliminar")
                    Try
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    Catch ex2 As Exception
                        MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ComboBox6.Text)

                    End Try
                End Try
            End If
        End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

   
End Class