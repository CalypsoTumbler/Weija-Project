Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Reporting.WinForms
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Digests

Public Class DeliveryForm
    Dim Con As New SqlConnection(My.Settings.AssetDbConnectionString)
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
    Private Function MyInputBox(ByVal Prompt As String) As String
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

        Dim txtbox As New TextBox
        txtbox.Width = 200
        frmInput.Controls.Add(txtbox)
        txtbox.Location = New Point(13, 10)
        txtbox.PasswordChar = "*"
        frmInput.ActiveControl = txtbox ' Set focus to text box to accept input

        ' Add event handler for KeyDown event of text box
        AddHandler txtbox.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                       If e.KeyCode = Keys.Enter Then
                                           frmInput.DialogResult = DialogResult.OK ' Set dialog result to OK when Enter is pressed
                                       End If
                                   End Sub

        frmInput.AcceptButton = btn ' Set OK button as the default accept button
        frmInput.CancelButton = btn ' Set OK button as the default cancel button
        frmInput.Text = Prompt
        frmInput.ShowDialog()

        Return txtbox.Text
    End Function

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

                    Dim sha3 As IDigest = New Sha3Digest(256) ' Create SHA-3-256 instance

                    ' Convert input string to byte array
                    Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(Approval)

                    ' Compute SHA-3-256 hash as byte array
                    Dim hashBytes As Byte() = New Byte(sha3.GetDigestSize() - 1) {}
                    sha3.BlockUpdate(inputBytes, 0, inputBytes.Length)
                    sha3.DoFinal(hashBytes, 0)

                    ' Convert byte array to hexadecimal string
                    Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
                    Console.WriteLine(hashString)


                    Dim query = "SELECT * FROM Approval WHERE ApprovalCode = @ApprovalCode"
                    Dim cmd = New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@ApprovalCode", hashString)
                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    'Console.WriteLine(ds)

                    'For Each table As DataTable In ds.Tables
                    'Console.WriteLine("Table: " & table.TableName)
                    'For Each row As DataRow In table.Rows
                    'For Each column As DataColumn In table.Columns
                    'Console.Write(column.ColumnName & ": " & row(column).ToString() & "")
                    'Next
                    'Console.WriteLine()
                    'Next
                    'Console.WriteLine()
                    'Next
                    Dim b As Integer
                    b = ds.Tables(0).Rows.Count
                    'Console.WriteLine(b)

                    If b <= 0 Then
                        MsgBox("Code not recognised", vbExclamation, "Error")
                        Con.Close()

                    Else
                        Dim Query2 = "select ApprovedBy from Approval where ApprovalCode = @ApprovalCode"
                        Dim cmd2 = New SqlCommand(Query2, Con)
                        cmd2.Parameters.AddWithValue("@ApprovalCode", hashString)
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
                        Query1 = "INSERT INTO DeliveryOderTbl (DeliverName, DeliverContact, AssetName, AssetSerial, ReceiverName, ReceiverDepartment, ReceiverRoomNumber, ReceiverContact, ApprovedBy, DateRecorded) VALUES (@DName, @DContact, @AName, @ASerial, @RName, @RDepartment, @RRoomNumber, @RContact, @ApprovedBy, @DateRecorded)"
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
                        cmd1.Parameters.AddWithValue("@DateRecorded", Today)
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