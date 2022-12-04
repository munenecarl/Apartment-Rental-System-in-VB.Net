Imports MySql.Data.MySqlClient

Public Class Form2
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
        sqlcomm.CommandText = "SELECT * FROM apartment_rental_system.unbooked_house"
        sqlrd = sqlcomm.ExecuteReader()
        sqlData.Load(sqlrd)
        sqlrd.Close()
        sqlconn.Close()
        BunifuDataGridView1.DataSource = sqlData
    End Sub

    Private Sub UnbookedItems()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Dim READER As MySqlDataReader

        Try
            sqlconn.Open()
            Dim Query_For_Unbooked_House As String
            Query_For_Unbooked_House = "select * from apartment_rental_system.unbooked_house"
            sqlcomm1 = New MySqlCommand(Query_For_Unbooked_House, sqlconn)
            READER = sqlcomm1.ExecuteReader
            While READER.Read
                Dim unbooked_houses = READER.GetString("house_id")
                ComboBox1.Items.Add(unbooked_houses)
            End While

            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try

    End Sub

    Private Sub EnterTenantData()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Try
            sqlconn.Open()
            sqlQuery = "insert into apartment_rental_system.tenant_table(tenant_id,first_name,last_name,phone_no,date_admitted, house_no ) value('" & BunifuTextBox1.Text & "','" & BunifuTextBox2.Text _
                & "','" & BunifuTextBox3.Text & "','" & BunifuTextBox4.Text & "','" & MaskedTextBox1.Text & "','" & ComboBox1.SelectedItem & "')"
            sqlcomm = New MySqlCommand(sqlQuery, sqlconn)
            sqlrd = sqlcomm.ExecuteReader
            sqlconn.Close()
            MsgBox("Data captured")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Trial", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlconn.Dispose()
        End Try
        UpdateTable()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
        UnbookedItems()
        ' MsgBox(BunifuDatePicker1.ToString)
    End Sub

    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellContentClick

    End Sub


    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        EnterTenantData()
        sqlconn.ConnectionString = "server =" + server + ";" + "username =" + username + ";" _
            + "password =" + password + ";" + "database =" + database_name
        Dim READER As MySqlDataReader

        Try
            sqlconn.Open()
            Dim Query_For_Unbooked_House As String
            Query_For_Unbooked_House = "DELETE FROM apartment_rental_system.unbooked_house WHERE house_id = '" & ComboBox1.SelectedItem.ToString & "'"
            sqlcomm1 = New MySqlCommand(Query_For_Unbooked_House, sqlconn)
            READER = sqlcomm1.ExecuteReader
            ComboBox1.Items.Clear()


            'While READER.Read
            'Dim unbooked_houses = READER.GetString("house_id")
            'ComboBox1.Items.Add(unbooked_houses)
            'End While

            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try
        BunifuTextBox1.Text = ""
        BunifuTextBox2.Text = ""
        BunifuTextBox3.Text = ""
        BunifuTextBox4.Text = ""
        MaskedTextBox1.Text = ""
        ComboBox1.Text = ""
        UnbookedItems()

        'ComboBox1.SelectedText = "Select House"
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class