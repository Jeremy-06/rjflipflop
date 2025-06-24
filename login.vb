Imports System.Data.SqlClient

Public Class login
    Public connectionString As String = "Data Source=IDEAPADSLIM3\SQLEXPRESS01;Initial Catalog=walkwalkSlippers;Integrated Security=True"
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
        query = "SELECT customer_id FROM users WHERE username = @username AND password = @password"
        Try
            connection.Open()
            command = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            Dim customerIdObj As Object = command.ExecuteScalar()
            If customerIdObj IsNot Nothing AndAlso Not IsDBNull(customerIdObj) Then
                customerId = Convert.ToInt32(customerIdObj)
                MessageBox.Show("Login successful! Customer ID: " & customerId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' You can now use customerId as needed in your application
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
        Me.Hide()
        intro.Show()
    End Sub
End Class