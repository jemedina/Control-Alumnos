Imports System.IO
Public Class Form1


    Function borrar_todo()
        Calif.Close()
        Gestion.Close()
        Graficas.Close()
        Revicion.Close()

        Try
            File.Delete(Application.StartupPath + "/backup/control de calificaciones db.accdb")


        Catch ex As Exception

        End Try
        File.Copy(Application.StartupPath + "/control de calificaciones db.accdb", Application.StartupPath + "/backup/control de calificaciones db.accdb")
        File.Delete(Application.StartupPath + "/control de calificaciones db.accdb")
        File.Copy(Application.StartupPath + "/backup_db/control de calificaciones db.accdb", Application.StartupPath + "/control de calificaciones db.accdb")
        Return 0
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Gestion.Show()
        Gestion.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Calif.Show()
        Calif.Focus()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Revicion.Show()
        Revicion.Focus()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Graficas.Show()
        Graficas.Focus()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
