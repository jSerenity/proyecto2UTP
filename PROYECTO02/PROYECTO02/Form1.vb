Public Class Form1
    Private Sub PresentaciònToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciònToolStripMenuItem.Click
        Dim pres As New presentation
        pres.ShowDialog()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Dim pres As New estudiantes
        pres.ShowDialog()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesorToolStripMenuItem.Click
        Dim pres As New Profesores
        pres.ShowDialog()
    End Sub
End Class
