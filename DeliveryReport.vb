Public Class DeliveryReport
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub DeliveryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DeliveryOderTbl' table. You can move, or remove it, as needed.
        Me.DeliveryOderTblTableAdapter.Fill(Me.DataSet1.DeliveryOderTbl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class