Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.Reporting.WinForms

Public Class DeliveryForm
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Public Function MyInputBox(ByVal Prompt As String) As String
        Dim frmInput As New Form
        frmInput.Size = New Size(300, 110)
        frmInput.StartPosition = FormStartPosition.CenterScreen
        frmInput.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Dim btn As New Button()
        btn.Text = "OK"
        frmInput.Controls.Add(btn)
        frmInput.MaximizeBox = False
        frmInput.MinimizeBox = False
        btn.Location = New Point(100, 40)
        btn.Width = 80
        AddHandler btn.Click, AddressOf inputclose
        Dim txtbox As New TextBox
        txtbox.Width = 200
        frmInput.Controls.Add(txtbox)
        txtbox.Location = New Point(13, 10)
        frmInput.Text = "Enter Approval Code"
        txtbox.PasswordChar = "*"
        ' txtbox.UseSystemPasswordChar = True 'you can have this for system password, up to you
        frmInput.ShowDialog()
        Return txtbox.Text

        Code = txtbox.Text
    End Function

    Dim Con As New SqlConnection(My.Settings.AssetDbConnectionString)
    Public Property Code As String
    Public Property ApprovedBy As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If DNameTxt.Text = "" Or DContactTxt.Text = "" Or ANameTxt.Text = "" Or ASerialTxt.Text = "" Or RName.Text = "" Or RDepartment.SelectedItem = "" Or RRoomNumber.Text = "" Or RContactTxt.Text = "" Then
                MsgBox("Missing Information", vbExclamation, "Error")
            Else
                Con.Open()
                Dim query0 = "select * from DeliveryOderTbl where AssetSerial = '" & ASerialTxt.Text & "'And ReceiverName = '" & RName.Text & "'And DateRecorded = '" & Today.Date & "'"
                Dim cmd0 = New SqlCommand(query0, Con)
                Dim da0 = New SqlDataAdapter(cmd0)
                Dim ds0 = New DataSet()
                da0.Fill(ds0)
                Dim a As Integer
                a = ds0.Tables(0).Rows.Count


                If a > 0 Then
                    MsgBox("Asset already recorded", vbExclamation, "Error")
                    Con.Close()
                Else

                    Dim Approval As String = MyInputBox("Please enter approval code")


                    Dim query = "select * from Approval where ApprovalCode = '" & Approval & "'"
                    Dim cmd = New SqlCommand(query, Con)
                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    Dim b As Integer
                    b = ds.Tables(0).Rows.Count

                    If b = 0 Then
                        MsgBox("Code not recognised", vbExclamation, "Error")
                        Con.Close()

                    Else
                        Dim Query2 = "select ApprovedBy from Approval where ApprovalCode = '" & Approval & "'"
                        Dim cmd2 As SqlCommand
                        cmd2 = New SqlCommand(Query2, Con)
                        Dim dt As DataTable
                        dt = New DataTable
                        Dim sqa As SqlDataAdapter
                        sqa = New SqlDataAdapter(cmd2)
                        sqa.Fill(dt)



                        'Insert ApprovedBY.Value etc as Global variables 
                        For Each dr As DataRow In dt.Rows
                            ApprovedBy = dr(0).ToString()

                        Next

                        Dim Query1 As String
                        Query1 = "insert into DeliveryOderTbl (DeliverName, DeliverContact, AssetName, AssetSerial, ReceiverName, ReceiverDepartment, ReceiverRoomNumber, ReceiverContact, ApprovedBy, DateRecorded) values (@DName, @DContact, @AName, @ASerial, @RName, @RDepartment, @RRoomNumber, @RContact, @ApprovedBy, @DateRecorded)"
                        Dim cmd1 As SqlCommand
                        cmd1 = New SqlCommand(Query1, Con)
                        cmd1.Parameters.AddWithValue("@DName", DNameTxt.Text)
                        cmd1.Parameters.AddWithValue("@DContact", DContactTxt.Text)
                        cmd1.Parameters.AddWithValue("@AName", ANameTxt.Text)
                        cmd1.Parameters.AddWithValue("@ASerial", ASerialTxt.Text)
                        cmd1.Parameters.AddWithValue("@RName", RName.Text)
                        cmd1.Parameters.AddWithValue("@RDepartment", RDepartment.SelectedItem.ToString())
                        cmd1.Parameters.AddWithValue("@RRoomNumber", RRoomNumber.Text)
                        cmd1.Parameters.AddWithValue("@RContact", RContactTxt.Text)
                        cmd1.Parameters.AddWithValue("@ApprovedBy", ApprovedBy)
                        cmd1.Parameters.AddWithValue("@DateRecorded", value:=Today)
                        cmd1.ExecuteNonQuery()

                        MsgBox("Asset recorded successfully", vbInformation, "Success")
                    End If
                    Con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try













    End Sub
    'Popup for approval code

    Sub inputclose(ByVal s As Object, ByVal e As EventArgs)
        DirectCast(DirectCast(s, Control).Parent, Form).Close()
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RContactTxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles RContactTxt.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        RContactTxt.Text = digitsOnly.Replace(RContactTxt.Text, "")
    End Sub

    Private Sub DContactTxt_TextChanged(sender As Object, e As EventArgs) Handles DContactTxt.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        RContactTxt.Text = digitsOnly.Replace(RContactTxt.Text, "")
    End Sub

    Private Sub DContactTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DContactTxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If DNameTxt.Text = "" Or DContactTxt.Text = "" Or ANameTxt.Text = "" Or ASerialTxt.Text = "" Or RName.Text = "" Or RDepartment.SelectedItem = "" Or RRoomNumber.Text = "" Or RContactTxt.Text = "" Then
                MsgBox("Missing Information", vbExclamation, "Error")
            Else
                Con.Open()
                Dim report As New DeliveryReport

                Dim RQuery As String
                RQuery = "Select DeliverName, AssetName, AssetSerial, ReceiverName, ReceiverDepartment, ReceiverRoomNumber, ApprovedBy, DateRecorded From DeliveryOderTbl where ReceiverName = '" & RName.Text & "' And DateRecorded = '" & Today.Date & "'"
                Dim Rcmd As New SqlCommand(RQuery, Con)
                Dim rsd As New SqlDataAdapter(Rcmd)
                'Dim ds1 As New DataSet
                Dim rdt As New DataTable
                rsd.Fill(rdt)



                With report.ReportViewer1.LocalReport
                    .DataSources.Clear()
                    .ReportPath = "DeliveryReport.rdlc"
                    .DataSources.Add(New ReportDataSource("DataSet1", rdt))
                End With


                report.ReportViewer1.RefreshReport()
                report.Show()


                Con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DNameTxt.Text = ""
        DContactTxt.Text = ""
        ANameTxt.Text = ""
        ASerialTxt.Text = ""
        RName.Text = ""
        RDepartment.SelectedItem = Nothing
        RRoomNumber.Text = ""
        RContactTxt.Text = ""
        Me.Hide()
        Main.Show()
    End Sub
End Class