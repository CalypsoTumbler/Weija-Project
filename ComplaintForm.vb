Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Digests

Public Class ComplaintForm
    Dim Con As New SqlConnection(My.Settings.AssetDbConnectionString)
    Public Property check As String
    Public Property ReceivedBy As String

    'A method for the "Ok" button in custom inputbox
    Private Sub inputclose(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim form As Form = DirectCast(button.Parent, Form)
        form.DialogResult = DialogResult.OK
        form.Close()
    End Sub

    'A custom inputbox function to accept receiver code
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


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim atLeastOneChecked As Boolean = False

        For Each cb As CheckBox In AssetStatusGroupBox.Controls
            If cb.Checked Then
                atLeastOneChecked = True
                Exit For
            End If
        Next

        'If Not atLeastOneChecked Then
        ' MsgBox("Select asset status", vbExclamation, "Error")
        ' None of the checkboxes are checked
        ' Handle the error or display a message to the user
        ' End If
        Try
            If CNametxt.Text = "" Or CContact.Text = "" Or ANametxt.Text = "" Or ATagtxt.Text = "" Or RIssuetxt.Text = "" Or PLevelCbx.SelectedItem = Nothing Or Not atLeastOneChecked Or CDepartmentCbx.SelectedItem = Nothing Then
                MsgBox("Missing Information", vbExclamation, "Error")
            Else
                Con.Open()
                Dim query0 = "select * from FaultTbl where AssetName = '" & ANametxt.Text & "'And AssetTag = '" & ATagtxt.Text & "'And ComplainantName = '" & CNametxt.Text & "' And ReportedIssue = '" & RIssuetxt.Text & "'"
                Dim cmd0 = New SqlCommand(query0, Con)
                Dim da0 = New SqlDataAdapter(cmd0)
                Dim ds0 = New DataSet()
                da0.Fill(ds0)
                Dim a As Integer
                a = ds0.Tables(0).Rows.Count


                If a > 0 Then
                    MsgBox("Complaint already recorded", vbExclamation, "Error")
                    Con.Close()
                Else
                    Dim Receiver As String = MyInputBox("Enter receiver code")

                    Dim sha3 As IDigest = New Sha3Digest(256) ' Create SHA-3-256 instance

                    ' Convert input string to byte array
                    Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(Receiver)

                    ' Compute SHA-3-256 hash as byte array
                    Dim hashBytes As Byte() = New Byte(sha3.GetDigestSize() - 1) {}
                    sha3.BlockUpdate(inputBytes, 0, inputBytes.Length)
                    sha3.DoFinal(hashBytes, 0)

                    ' Convert byte array to hexadecimal string
                    Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()


                    Dim query = "select * from ReceiverTbl where ReceiverCode = @ReceiverCode"
                    Dim cmd = New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@ReceiverCode", hashString)
                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    Dim b As Integer
                    b = ds.Tables(0).Rows.Count

                    If b <= 0 Then
                        MsgBox("Code not recognised", vbExclamation, "Error")
                        Con.Close()

                    Else
                        Dim Query2 = "select ReceiverName from ReceiverTbl where ReceiverCode = @ReceiverCode"
                        Dim cmd2 As SqlCommand
                        cmd2 = New SqlCommand(Query2, Con)
                        cmd2.Parameters.AddWithValue("@ReceiverCode", hashString)
                        Dim dt As DataTable
                        dt = New DataTable
                        Dim sqa As SqlDataAdapter
                        sqa = New SqlDataAdapter(cmd2)
                        sqa.Fill(dt)




                        For Each dr As DataRow In dt.Rows
                            ReceivedBy = dr(0).ToString()

                        Next

                        Dim Query1 As String
                        Query1 = "insert into FaultTbl (ComplainantName, ComplainantDepartment, ComplainantRN, ComplainantContact, DateReported, AssetName, AssetTag, ReportedIssue, AssignedTo, AssetStatus, PriorityLevel, ReceivedBy) values (@CName, @CDepartment, @CRN, @CContact, @DateReported, @AName, @ATag, @RIssue, @AssignedTo, @AssetStatus, @PLevel, @ReceivedBy)"
                        Dim cmd1 As SqlCommand
                        cmd1 = New SqlCommand(Query1, Con)
                        cmd1.Parameters.AddWithValue("@CName", CNametxt.Text)
                        cmd1.Parameters.AddWithValue("@CDepartment", CDepartmentCbx.SelectedItem.ToString())
                        cmd1.Parameters.AddWithValue("@CRN", CRNtxt.Text)
                        cmd1.Parameters.AddWithValue("@CContact", CContact.Text)
                        cmd1.Parameters.AddWithValue("@DateReported", Today.Date)
                        cmd1.Parameters.AddWithValue("@AName", ANametxt.Text)
                        cmd1.Parameters.AddWithValue("@ATag", ATagtxt.Text)
                        cmd1.Parameters.AddWithValue("@RIssue", RIssuetxt.Text)
                        cmd1.Parameters.AddWithValue("@AssignedTo", AssignTotxt.Text)
                        cmd1.Parameters.AddWithValue("@AssetStatus", check)
                        cmd1.Parameters.AddWithValue("@PLevel", PLevelCbx.SelectedItem.ToString())
                        cmd1.Parameters.AddWithValue("@ReceivedBy", ReceivedBy)
                        cmd1.ExecuteNonQuery()

                        MsgBox("Complaint recorded successfully", vbInformation, "Success")
                        Con.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub ResolvedCHB_CheckedChanged(sender As Object, e As EventArgs) Handles ResolvedCHB.CheckedChanged
        If ResolvedCHB.CheckState = CheckState.Checked Then
            PendingCHB.CheckState = CheckState.Unchecked
            DamagedCHB.CheckState = CheckState.Unchecked
            check = "Resolved"
        End If
    End Sub

    Private Sub PendingCHB_CheckedChanged(sender As Object, e As EventArgs) Handles PendingCHB.CheckedChanged
        If PendingCHB.CheckState = CheckState.Checked Then
            ResolvedCHB.CheckState = CheckState.Unchecked
            DamagedCHB.CheckState = CheckState.Unchecked
            check = "Pending"
        End If
    End Sub

    Private Sub DamagedCHB_CheckedChanged(sender As Object, e As EventArgs) Handles DamagedCHB.CheckedChanged
        If DamagedCHB.CheckState = CheckState.Checked Then
            ResolvedCHB.CheckState = CheckState.Unchecked
            PendingCHB.CheckState = CheckState.Unchecked
            check = "Damaged"
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CNametxt.Text = ""
        CDepartmentCbx.SelectedItem = Nothing
        CRNtxt.Text = ""
        CContact.Text = ""
        ANametxt.Text = ""
        ATagtxt.Text = ""
        RIssuetxt.Text = ""
        AssignTotxt.Text = ""
        PLevelCbx.SelectedItem = Nothing
        ResolvedCHB.CheckState = CheckState.Unchecked
        PendingCHB.CheckState = CheckState.Unchecked
        DamagedCHB.CheckState = CheckState.Unchecked
        Me.Hide()
        Fault.Show()
    End Sub

    Private Sub CContact_TextChanged(sender As Object, e As EventArgs) Handles CContact.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        CContact.Text = digitsOnly.Replace(CContact.Text, "")
    End Sub

    Private Sub CContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComplaintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class