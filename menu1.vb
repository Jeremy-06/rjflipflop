Public Class menu1
    Dim quantity4 As Integer = 0
    Dim quantity5 As Integer = 0
    Dim quantity6 As Integer = 0
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        menu0.Show()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()
        menu2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quantity4 += 1
        TextBox1.Text = quantity4.ToString()
        If quantity4 > 0 Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        quantity4 -= 1
        TextBox1.Text = quantity4.ToString()
        If quantity4 <= 0 Then
            quantity4 = 0
            TextBox1.Text = "0"
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        quantity5 += 1
        TextBox2.Text = quantity5.ToString()
        If quantity5 > 0 Then
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        quantity5 -= 1
        TextBox2.Text = quantity5.ToString()
        If quantity5 <= 0 Then
            quantity5 = 0
            TextBox2.Text = "0"
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        quantity6 += 1
        TextBox3.Text = quantity6.ToString()
        If quantity6 > 0 Then
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        quantity6 -= 1
        TextBox3.Text = quantity6.ToString()
        If quantity6 <= 0 Then
            quantity6 = 0
            TextBox3.Text = "0"
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        intro.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        mycart.Show()
    End Sub
End Class
