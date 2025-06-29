Public Class menu3
    Dim quantity10 As Integer = 0
    Dim quantity11 As Integer = 0
    Dim quantity12 As Integer = 0
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        menu2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quantity10 += 1
        TextBox1.Text = quantity10.ToString()
        If quantity10 > 0 Then
            Button2.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        quantity10 -= 1
        TextBox1.Text = quantity10.ToString()
        If quantity10 <= 0 Then
            quantity10 = 0
            TextBox1.Text = "0"
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        quantity11 += 1
        TextBox2.Text = quantity11.ToString()
        If quantity11 > 0 Then
            Button4.Enabled = True
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        quantity11 -= 1
        TextBox2.Text = quantity11.ToString()
        If quantity11 <= 0 Then
            quantity11 = 0
            TextBox2.Text = "0"
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        quantity12 += 1
        TextBox3.Text = quantity12.ToString()
        If quantity12 > 0 Then
            Button6.Enabled = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        quantity12 -= 1
        TextBox3.Text = quantity12.ToString()
        If quantity12 <= 0 Then
            quantity12 = 0
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