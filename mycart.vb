Imports System.Data.SqlClient

Public Class mycart
    Public connectionString As String = "Data Source=IDEAPADSLIM3\SQLEXPRESS01;Initial Catalog=walkwalkSlippers;Integrated Security=True"
    Public connection As SqlConnection = New SqlConnection(connectionString)
    Public command As SqlCommand
    Public dataAdapter As SqlDataAdapter
    Public dataReader As SqlDataReader
    Public dataTable As New DataTable
    Dim query As String

    Private Sub mycart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            cartLoad()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub cartLoad()
        Try
            query = "SELECT 
                     p.product_name AS ITEMS,
                     s.size_label AS SIZES,
                     co.color_name AS COLORS,
                     c.quantity AS QUANTITY,
                     c.price AS PRICE
                    FROM cart c
                    JOIN products p ON c.product_id = p.product_id
                    JOIN sizes s ON c.size_id = s.size_id
                    JOIN color co ON c.color_id = co.color_id
                    WHERE c.customer_id = @customerId;"
            command = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@customerId", login.customerId)
            dataAdapter = New SqlDataAdapter(command)
            dataTable.Clear()
            dataAdapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error loading cart: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

End Class