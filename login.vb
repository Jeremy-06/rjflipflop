Imports System.Data.SqlClient

Public Class login
    Public connectionString As String = "Data Source=IDEAPADSLIM3\SQLEXPRESS01;Initial Catalog=rjflipflops;Integrated Security=True"
    Public connection As SqlConnection = New SqlConnection(connectionString)
    Public command As SqlCommand
    Public dataAdapter As SqlDataAdapter
    Public dataReader As SqlDataReader
    Public dataTable As New DataTable
    Dim query As String

    Public customerId As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        query = "SELECT c.customer_id FROM users u 
                 INNER JOIN customers c ON u.user_id = c.user_id 
                 WHERE u.username = @username AND u.password = @password"
        Try
            connection.Open()
            command = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            Dim customerIdObj As Object = command.ExecuteScalar()
            If customerIdObj IsNot Nothing AndAlso Not IsDBNull(customerIdObj) Then
                customerId = Convert.ToInt32(customerIdObj)
                MessageBox.Show("Login successful! Customer ID: " & customerId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Proceed to next form or main application, pass customerId as needed
                Me.Hide()
                intro.Button2.Enabled = False
                intro.Button3.Enabled = False
                intro.TextBox1.Text = username
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

    End Sub
End Class