Public Class EditarCalificaciones

    Private Sub EditarCalificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        Catch ex As Exception
            Me.GrupoTableAdapter.Fill(Me.Control_de_calificaciones_dbDataSet.Grupo)
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        End Try
    End Sub

    Private Sub grupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grupo.SelectedIndexChanged
        Try
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        Catch ex As Exception
            AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
            MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        End Try
    End Sub

   

    Private Sub materia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles materia.SelectedIndexChanged

        Try
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        Catch ex As Exception
            UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        End Try
        
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newcal As Decimal
        Dim r As String
        r = InputBox("Escriba la nueva calificacion:", "Nueva calificacion")
        If IsNumeric(r) Then
            newcal = Val(r)
            If MsgBox("¿Esta seguro de registrar al alumno " + alumno.Text + " con la calificacion de " + newcal.ToString + "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    CalificacionesTableAdapter.ArreglarCalif(newcal, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)
                    AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
                    MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
                    UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
                    Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
                    CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

                Catch ex As Exception
                    CalificacionesTableAdapter.ArreglarCalif(newcal, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)
                    AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
                    MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
                    UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
                    Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
                    CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

                End Try
                      Else
                Try
                    AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
                    MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
                    UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
                    Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
                    CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

                Catch ex As Exception
                    AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
                    MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
                    UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
                    Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
                    CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

                End Try
            End If
        Else

            MsgBox("Solo puede ingresar datos numericos en la caja de texto emergente", MsgBoxStyle.Critical)
            Try
                AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
                MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
                UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
                Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
                CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

            Catch ex As Exception
                AlumnosTableAdapter.FiltrarGrupo(Me.Control_de_calificaciones_dbDataSet.Alumnos, grupo.Text)
                MateriasTableAdapter.filtrarMateriasPorGrupo(Me.Control_de_calificaciones_dbDataSet.Materias, grupo.Text)
                UnidadesTableAdapter.filtrarPorMateria(Me.Control_de_calificaciones_dbDataSet.Unidades, materia.Text)
                Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
                CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

            End Try
        End If
           

           



    End Sub



    Private Sub subunid_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subunid.SelectedIndexChanged
        Try
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        Catch ex As Exception
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        End Try
       
    End Sub

   

   


  
    Private Sub MatriculaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriculaTextBox.TextChanged
        Try
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)
        Catch ex As Exception
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        End Try
    End Sub

    Private Sub EditarCalificaciones_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Calif.Enabled = True
    End Sub

    Private Sub FullNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullNameTextBox.TextChanged
        Try
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        Catch ex As Exception
            Sub_unidadTableAdapter.FiltrarPorUnidad(Me.Control_de_calificaciones_dbDataSet.Sub_unidad, FullNameTextBox.Text)
            CalificacionesTableAdapter.getUSe(Me.Control_de_calificaciones_dbDataSet.Calificaciones, MatriculaTextBox.Text, Val(subunid.Text), FullNameTextBox.Text, materia.Text)

        End Try

    End Sub
End Class