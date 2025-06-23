Public Class menu0
    Dim quantity1 As Integer = 0
    Dim quantity2 As Integer = 0
    Dim quantity3 As Integer = 0

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()
        menu1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quantity1 += 1
        TextBox1.Text = quantity1.ToString()
        If quantity1 > 0 Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        quantity1 -= 1
        TextBox1.Text = quantity1.ToString()
        If quantity1 <= 0 Then
            quantity1 = 0
            TextBox1.Text = "0"
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        quantity2 += 1
        TextBox2.Text = quantity2.ToString()
        If quantity2 > 0 Then
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        quantity2 -= 1
        TextBox2.Text = quantity2.ToString()
        If quantity2 <= 0 Then
            quantity2 = 0
            TextBox2.Text = "0"
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        quantity3 += 1
        TextBox3.Text = quantity3.ToString()
        If quantity3 > 0 Then
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        quantity3 -= 1
        TextBox3.Text = quantity3.ToString()
        If quantity3 <= 0 Then
            quantity3 = 0
            TextBox3.Text = "0"
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
    End Sub
End Class