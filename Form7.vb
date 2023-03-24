Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form7

    Dim sqlconn As New MySqlConnection
    Dim sqlcomm As New MySqlCommand
    Dim sqlrd As MySqlDataReader
    Dim sqlData As DataTable = New DataTable
    Dim sqlad As MySqlDataAdapter
    Dim sqlQuery As String
    Dim sqlcomm1 As New MySqlCommand

    Dim server As String = servername
    Dim username As String = username
    Dim password As String = password
    Dim database_name As String = "apartment_rental_system"

    Private Sub EnterCleanerData()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Try
            sqlconn.Open()
            sqlQuery = "insert into apartment_rental_system.cleaner_table(cleaner_id,first_name,last_name,work_day) value('" & BunifuTextBox1.Text & "','" & BunifuTextBox2.Text _
                & "','" & BunifuTextBox3.Text & "','" & BunifuTextBox4.Text & "')"
            sqlcomm = New MySqlCommand(sqlQuery, sqlconn)
            sqlrd = sqlcomm.ExecuteReader
            sqlconn.Close()
            MsgBox("Data captured")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Trial", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlconn.Dispose()
        End Try
        BunifuTextBox1.Text = ""
        BunifuTextBox2.Text = ""
        BunifuTextBox3.Text = ""
        BunifuTextBox4.Text = ""
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
          Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        EnterCleanerData()
    End Sub
End Class
