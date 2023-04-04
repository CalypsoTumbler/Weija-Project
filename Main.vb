Public Class Main
    'A custom inputbox function to accept receiver code
    Private Function MyInputBox1(ByVal Prompt As String) As String
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
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        DeliveryForm.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        DeliveryForm.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DeliveryForm.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Fault.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Fault.Show()

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        Dim password As String = MyInputBox1("Enter Password")

        If password = "Admin" Then
            Dim admn As New Admin
            Me.Hide()
            admn.Show()
        Else
            MsgBox("Wrong password", vbExclamation, "Error")
        End If
    End Sub
End Class