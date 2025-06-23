Public Class intro
    Private WithEvents loginForm As login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginForm = New login()
        AddHandler loginForm.FormClosed, AddressOf LoginForm_Closed
        loginForm.Show()
    End Sub

    Private Sub LoginForm_Closed(sender As Object, e As FormClosedEventArgs)
        Me.Show()
    End Sub
End Class
