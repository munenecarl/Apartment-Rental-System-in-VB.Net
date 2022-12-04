Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Bunifu.UI.WinForms
Imports MySql.Data.MySqlClient
Public Class Form3
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

    Private Sub UpdateTable()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        sqlconn.Open()
        sqlcomm.Connection = sqlconn
        sqlcomm.CommandText = "SELECT * FROM apartment_rental_system.tenant_table"
        sqlrd = sqlcomm.ExecuteReader()
        sqlData.Load(sqlrd)
        sqlrd.Close()
        sqlconn.Close()
        BunifuDataGridView1.DataSource = sqlData
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        'Dim Com As New MySqlCommand("delete from table apartment_rental_system.tenant_table where tenant_id = @id", sqlconn)
        'Com.Parameters.AddWithValue("id", BunifuDataGridView1.SelectedRows(i).Cells(0).Value.ToString())
        Try
            For i As Integer = 0 To BunifuDataGridView1.SelectedRows.Count - 1
                Dim Selected_House_Id As String
                Selected_House_Id = BunifuDataGridView1.SelectedRows.Item(i).Cells(3).Value.ToString()
                'MsgBox(Selected_House_Id)
                Dim READER As MySqlDataReader
                Dim READER2 As MySqlDataReader
                Dim Query_For_Unbooked_House As String
                sqlconn.Open()
                'MsgBox(BunifuDataGridView1.SelectedRows(i).Cells(0).Value.ToString())
                Query_For_Unbooked_House = "DELETE FROM apartment_rental_system.tenant_table WHERE tenant_id = '" & BunifuDataGridView1.SelectedRows(i).Cells(0).Value.ToString() & "'"
                sqlcomm1 = New MySqlCommand(Query_For_Unbooked_House, sqlconn)
                READER2 = sqlcomm1.ExecuteReader
                sqlconn.Close()
                sqlconn.Open()
                Dim Insert_Into_Unbooked_House As String
                'MsgBox(Selected_House_Id)
                Insert_Into_Unbooked_House = "INSERT INTO apartment_rental_system.unbooked_house SELECT * FROM apartment_rental_system.house_table WHERE house_id = '" & Selected_House_Id & "'"
                sqlcomm = New MySqlCommand(Insert_Into_Unbooked_House, sqlconn)
                READER = sqlcomm.ExecuteReader
                sqlconn.Close()

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
        ' BunifuDataGridView1.DataSource = Nothing
        ' BunifuDataGridView1.Rows.Clear()
        'BunifuDataGridView1.Refresh()
        sqlData.Clear()
        BunifuDataGridView1.DataSource = sqlData
        BunifuDataGridView1.DataSource = Nothing
        UpdateTable()
        MessageBox.Show("Tenant details deleted successfully")

    End Sub
End Class