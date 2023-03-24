Imports Bunifu.UI.WinForms
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Form5
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
    Private Sub HouseItems()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Dim READER As MySqlDataReader

        Try
            sqlconn.Open()
            Dim Query_For_House_Item As String
            Query_For_House_Item = "select * from apartment_rental_system.house_table"
            sqlcomm1 = New MySqlCommand(Query_For_House_Item, sqlconn)
            READER = sqlcomm1.ExecuteReader
            While READER.Read
                Dim houses_item = READER.GetString("house_id")
                ComboBox1.Items.Add(houses_item)
            End While

            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try

    End Sub

    Private Sub Cleaner_Details()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Dim READER As MySqlDataReader
        sqlconn.Open()
        Dim Query_For_Cleaner_Detail As String
        Query_For_Cleaner_Detail = "select * from apartment_rental_system.cleaner_table"
        sqlcomm1 = New MySqlCommand(Query_For_Cleaner_Detail, sqlconn)
        READER = sqlcomm1.ExecuteReader
        While READER.Read
            Dim Cleaner_Id = READER.GetString("cleaner_id")
            ComboBox2.Items.Add(Cleaner_Id)
        End While
        sqlconn.Close()
        sqlconn.Dispose()

    End Sub
    Private Sub Cleaner_Update_For_First_Name()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Dim READER As MySqlDataReader
        sqlconn.Open()
        'For getting the cleaner's name and trying to get into the first name combobox
        Dim Query_For_Cleaner_Name As String
        Dim Selected_Id As String
        Selected_Id = ComboBox2.SelectedItem.ToString()
        MsgBox(Selected_Id)
        Query_For_Cleaner_Name = "select * from apartment_rental_system.house_table where house_id = '" & Selected_Id & "'"
        sqlcomm1 = New MySqlCommand(Query_For_Cleaner_Name, sqlconn)
        READER = sqlcomm1.ExecuteReader
        While READER.Read
            Dim Cleaner_Name = READER.GetString("first_name")
            'ComboBox2.Items.Add(Cleaner_Name)
            ComboBox2.Items.Add(Cleaner_Name)
        End While
    End Sub

    Private Sub UpdateTable()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        sqlconn.Open()
        sqlcomm.Connection = sqlconn
        sqlcomm.CommandText = "SELECT * FROM apartment_rental_system.cleaner_table"
        sqlrd = sqlcomm.ExecuteReader()
        sqlData.Load(sqlrd)
        sqlrd.Close()
        sqlconn.Close()
        BunifuDataGridView1.DataSource = sqlData
    End Sub

    Private Sub EnterCleanerData()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Try
            sqlconn.Open()
            sqlQuery = "insert into apartment_rental_system.cleaner_booking_table(cleaner_id,cleaner_first_name,house_no,cleaning_day) value('" & ComboBox2.SelectedItem & "','" & BunifuTextBox1.Text _
            & "','" & ComboBox1.SelectedItem & "','" & MaskedTextBox1.Text & "')"
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
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        MaskedTextBox1.Text = ""
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
        HouseItems()
        Cleaner_Details()
    End Sub
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        'Dim Com As New MySqlCommand("delete from table apartment_rental_system.tenant_table where tenant_id = @id", sqlconn)
        'Com.Parameters.AddWithValue("id", BunifuDataGridView1.SelectedRows(i).Cells(0).Value.ToString())
        Try
            For i As Integer = 0 To BunifuDataGridView1.SelectedRows.Count - 1
                Dim Selected_House_Id As String
                Selected_House_Id = BunifuDataGridView1.SelectedRows.Item(i).Cells(3).Value.ToString()
                'MsgBox(Selected_House_Id)
                Dim READER2 As MySqlDataReader
                Dim Query_For_Cleaner_id As String
                sqlconn.Open()
                MsgBox(BunifuDataGridView1.SelectedRows(i).Cells(0).Value.ToString())
                Query_For_Cleaner_id = "DELETE FROM apartment_rental_system.cleaner_table WHERE cleaner_id = '" & BunifuDataGridView1.SelectedRows(i).Cells(0).Value.ToString() & "'"
                sqlcomm1 = New MySqlCommand(Query_For_Cleaner_id, sqlconn)
                READER2 = sqlcomm1.ExecuteReader
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
        MessageBox.Show("Cleaner details deleted successfully")
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        EnterCleanerData()
    End Sub
End Class
