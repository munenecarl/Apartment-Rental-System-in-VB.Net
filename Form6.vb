Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Bunifu.UI.WinForms
Imports MySql.Data.MySqlClient

Public Class Form6

    Dim sqlconn As New MySqlConnection
    Dim sqlcomm As New MySqlCommand
    Dim sqlrd As MySqlDataReader
    Dim sqlData As DataTable = New DataTable
    Dim sqlad As MySqlDataAdapter
    Dim sqlQuery As String
    Dim sqlcomm1 As New MySqlCommand

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "@26678462caM"
    Dim database_name As String = "apartment_rental_system"

    Private Sub Login()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        sqlconn.Open()
        sqlcomm.Connection = sqlconn
        sqlcomm.CommandText = "SELECT * FROM apartment_rental_system.caretaker_table where caretaker_id = '" & BunifuTextBox1.Text & "' and password = '" _
            & BunifuTextBox2.Text & "'"
        sqlrd = sqlcomm.ExecuteReader()
        sqlData.Load(sqlrd)
        If (sqlData.Rows.Count > 0) Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Failed login")
        End If
        sqlrd.Close()
        sqlconn.Close()
    End Sub





    Private Sub SignUp()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name

        sqlconn.Open()
        sqlQuery = "insert into apartment_rental_system.caretaker_table(caretaker_id, password, first_name, last_name ) value('" & BunifuTextBox3.Text.Trim & "','" & BunifuTextBox4.Text.Trim _
                & "','" & BunifuTextBox5.Text.Trim & "','" & BunifuTextBox6.Text.Trim & "')"
        sqlcomm = New MySqlCommand(sqlQuery, sqlconn)
        sqlrd = sqlcomm.ExecuteReader
        sqlconn.Close()
        MsgBox("Data captured")
        sqlconn.Dispose()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Login()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Panel1.Visible = False
        Panel2.Visible = True

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        SignUp()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuTextBox2_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox2.TextChanged

    End Sub

    Private Sub BunifuTextBox2_LostFocus(sender As Object, e As EventArgs) Handles BunifuTextBox2.LostFocus

    End Sub

    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox1.TextChanged

    End Sub


End Class