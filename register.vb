Imports System.Data.SqlClient

Public Class register
    Public connectionString As String = "Data Source=IDEAPADSLIM3\SQLEXPRESS01;Initial Catalog=rjflipflops;Integrated Security=True"
    Public connection As SqlConnection = New SqlConnection(connectionString)
    Public command As SqlCommand
    Public dataAdapter As SqlDataAdapter
    Public dataReader As SqlDataReader
    Public dataTable As New DataTable
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String = TextBox1.Text.Trim()
        Dim lastName As String = TextBox2.Text.Trim()
        Dim email As String = TextBox3.Text.Trim()
        Dim phone As String = TextBox4.Text.Trim()
        Dim address As String = TextBox5.Text.Trim()
        Dim username As String = TextBox6.Text.Trim()
        Dim password As String = TextBox7.Text.Trim()

        Try
            connection.Open()
            query = "INSERT INTO users (username, password) 
                     VALUES (@username, @password);
                     SELECT SCOPE_IDENTITY();"
            command = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            Dim userId As Object = command.ExecuteScalar()
            If userId IsNot Nothing AndAlso Not IsDBNull(userId) Then
                Dim newUserId As Integer = Convert.ToInt32(userId)
                query = "INSERT INTO customers (user_id, first_name, last_name, email, phone, address) 
                         VALUES (@userId, @firstName, @lastName, @Email, @Phone, @Address);"
                command = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", newUserId)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Phone", phone)
                command.Parameters.AddWithValue("@Address", address)
                command.ExecuteNonQuery()
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Me.Close()
    End Sub
End Class