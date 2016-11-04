Public Class Calif
    Function reducir()
        Me.AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, ListBox1.GetItemText(ListBox1.Text))

        Me.AlumnosBindingSource.Position = 0

        Dim n = 0
        ListaAlumnos.Items.Clear()

        While (n < Me.AlumnosBindingSource.Count)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, SuperControl.Text,
                                              Val(ComboBox4.Text), ComboBox3.Text, ComboBox2.Text)
            If OtherSuperControl.Text = "" Then
                ListaAlumnos.Items.Add(NombreTextBox.Text)
                Me.AlumnosBindingSource.Position += 1
            Else
                Me.AlumnosBindingSource.Position += 1
            End If
            n += 1
        End While
        n = 0
        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
        Try
            Dim s As String = ListaAlumnos.Items(0).ToString
            ListaAlumnos.Text = s
            AlumnosTableAdapter.getMatr(Me.Control_de_calificaciones_dbDataSet.Alumnos, ListaAlumnos.Text, ListBox1.GetItemText(ListBox1.Text))
        Catch ex As Exception

        End Try

        If ListaAlumnos.Text = "" Then
            MatriculaTextBox.Text = ""

        End If
        Return 0
    End Function
    



    Private Sub Calif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
        Me.AlumnosTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Alumnos)
        Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)



        '/*------------------------ FILTRAR CORRESPONDIENTEMENTE AL CARGAR EL FORMULARIO-----------------------------*/
        Try
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ListBox1.GetItemText(ListBox1.Text))
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox3.Text)

        Catch ex As Exception
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ListBox1.GetItemText(ListBox1.Text))
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox3.Text)

        End Try

        reducir()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ListBox1.GetItemText(ListBox1.Text))
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox3.Text)

        Catch ex As Exception
            MateriasTableAdapter.filtrarMateriasPorGrupo(Control_de_calificaciones_dbDataSet.Materias, ListBox1.GetItemText(ListBox1.Text))
            UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
            Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox3.Text)

        End Try

        reducir()

    End Sub



    Private Sub ComboBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged
        UnidadesTableAdapter.filtrarPorMateria(Control_de_calificaciones_dbDataSet.Unidades, ComboBox2.Text)
    End Sub

    Private Sub ComboBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.TextChanged
        Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox3.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListaAlumnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaAlumnos.SelectedIndexChanged
        AlumnosTableAdapter.getMatr(Me.Control_de_calificaciones_dbDataSet.Alumnos, ListaAlumnos.Text, ListBox1.GetItemText(ListBox1.Text))
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        reducir()
    End Sub

    Private Sub CalificacionesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CalificacionesDataGridView.CellContentClick

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        reducir()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        reducir()
        Sub_unidadTableAdapter.filtrarSubUnidades(Control_de_calificaciones_dbDataSet.Sub_unidad, ComboBox3.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState Then
            Me.Size = New Size(704, 561)
        Else
            Me.Size = New Size(704, 275)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TextBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "" And ListaAlumnos.Text <> "" Then
                If TextBox1.Text = "100" Then
                    If MsgBox("El alumno sera registrado con calificacion del 100%. ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        CalificacionesTableAdapter.InsertQuery(ComboBox3.Text, Val(ComboBox4.Text), MatriculaTextBox.Text, Val(TextBox1.Text), ComboBox2.Text, ListBox1.GetItemText(ListBox1.Text))
                        Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
                        TextBox1.Text = ""

                        reducir()



                    End If
                Else
                    CalificacionesTableAdapter.InsertQuery(ComboBox3.Text, Val(ComboBox4.Text), MatriculaTextBox.Text, Val(TextBox1.Text), ComboBox2.Text, ListBox1.GetItemText(ListBox1.Text))
                    Me.CalificacionesTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Calificaciones)
                    TextBox1.Text = ""

                    reducir()
                End If

            Else
                MsgBox("no puede calificar si hay campos en blanco")
            End If
        Else







            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Or Len(TextBox1.Text) = 3 And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If Val(TextBox1.Text) >= 100 Then
                TextBox1.Text = "100"
            End If
            Try
                Dim pp As String = TextBox1.Text + e.KeyChar.ToString
                If Val(pp) > 100 Then
                    TextBox1.Text = "100"
                    e.Handled = True

                End If
            Catch ex As Exception

            End Try

            If Val(TextBox1.Text) < 0 Then

                TextBox1.Text = "0"
            End If



        End If








    End Sub


    Private Sub RevisarCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevisarCalificacionesToolStripMenuItem.Click
        Revicion.Show()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AbrirMenuPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirMenuPrincipalToolStripMenuItem.Click
        Form1.Show()
        Form1.Focus()

    End Sub

    Private Sub ModificarCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCalificacionesToolStripMenuItem.Click
        EditarCalificaciones.Show()
        Me.Enabled = False

    End Sub
End Class