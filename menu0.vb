Imports System.Data.SqlClient

Public Class menu0
    Public connectionString As String = "Data Source=IDEAPADSLIM3\SQLEXPRESS01;Initial Catalog=rjflipflops;Integrated Security=True"
    Public connection As SqlConnection = New SqlConnection(connectionString)
    Public command As SqlCommand
    Public dataAdapter As SqlDataAdapter
    Public dataReader As SqlDataReader
    Public dataTable As New DataTable
    Dim query As String

    Dim quantity1 As Integer = 0
    Dim quantity2 As Integer = 0
    Dim quantity3 As Integer = 0
    Dim price1 As Decimal = 349
    Dim price2 As Decimal = 396
    Dim price3 As Decimal = 385

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim size As Object = ComboBox1.SelectedItem
        Dim color As Object = ComboBox2.SelectedItem
        Dim color_id As Integer

        If size Is Nothing Or color Is Nothing Then
            MessageBox.Show("Please select a size and color.")
            Return
        End If

        If quantity1 <= 0 Then
            MessageBox.Show("Please add items to the cart before proceeding.")
            Return
        End If

        If color = "Black" Then
            color_id = 1
        ElseIf color = "Rasta" Then
            color_id = 8
        ElseIf color = "Blue" Then
            color_id = 2
        End If

        Try
            connection.Open()
            query = "INSERT INTO cart (customer_id, product_id, size_id, color_id, quantity, price) VALUES 
                     (@customerId, 1, @size, @color, @quantity1, @price1);"
            command = New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@customerId", login.customerId)
            command.Parameters.AddWithValue("@size", size)
            command.Parameters.AddWithValue("@color", color_id)
            command.Parameters.AddWithValue("@quantity1", quantity1)
            command.Parameters.AddWithValue("@price1", (price1 * quantity1))
            command.ExecuteNonQuery()
            MessageBox.Show("Items added to cart successfully!")
        Catch ex As Exception
            MessageBox.Show("Error adding items to cart: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        mycart.cartLoad()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        mycart.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        intro.Show()
    End Sub

    Private Sub menu0_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class