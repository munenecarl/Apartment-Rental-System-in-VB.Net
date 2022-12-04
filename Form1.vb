Public Class Form1
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles CbnBookAHouse.Click
        Form2.Show()
        Me.Hide()


    End Sub


    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuTextBox5_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Cbn_Vacate_a_House_Click(sender As Object, e As EventArgs) Handles Cbn_Vacate_a_House.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Cbn_Laundry_Details_Click(sender As Object, e As EventArgs) Handles Cbn_Laundry_Details.Click
        Form5.Show()
        Me.Hide()
    End Sub

End Class
