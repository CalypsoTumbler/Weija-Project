Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Digests

Public Class AdminReceivers
    Dim Con As New SqlConnection(My.Settings.AssetDbConnectionString)
    Private Sub DisplayUsers()
        Try
            Con.Open()
            Dim Sql = "select * from ReceiverTbl"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(Sql, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            UsersDGV.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
            Con.Close()
        End Try
    End Sub
    Dim Key = 0
    Private Sub Clear()
        Nametxt.Text = ""
        Phonetxt.Text = ""
        Codetxt.Text = ""
        Key = 0
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Nametxt.Text = "" Or Phonetxt.Text = "" Or Codetxt.Text = "" Then
            MsgBox("Missing Information", vbExclamation, "Error")



        Else
            'Dim pass = Codetxt.Text

            Dim input As String = Codetxt.Text ' Input string to compute SHA-3-256 hash for
            ' Dim input As String = "Hello, world!" ' Input string to compute SHA-3-256 hash for
            Dim sha3 As IDigest = New Sha3Digest(256) ' Create SHA-3-256 instance

            ' Convert input string to byte array
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)

            ' Compute SHA-3-256 hash as byte array
            Dim hashBytes As Byte() = New Byte(sha3.GetDigestSize() - 1) {}
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length)
            sha3.DoFinal(hashBytes, 0)

            ' Convert byte array to hexadecimal string
            Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()

            ' Display SHA-3-256 hash
            'Console.WriteLine("SHA-3-256 Hash: " & hashString)

            ' Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
            'Dim bytes() As Byte = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(pass))
            'Dim password As String

            'For Each i As Byte In bytes
            'password &= i.ToString("x2")
            'Next

            'Codetxt.Text = password
            Try
                Con.Open()
                Dim query As String = "SELECT * FROM ReceiverTbl WHERE ReceiverName = @Nametxt AND ReceiverCode = @hashString"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@Nametxt", Nametxt.Text)
                cmd.Parameters.AddWithValue("@hashString", hashString)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim ds As DataSet = New DataSet()
                da.Fill(ds)
                Dim a As Integer = 0
                a = ds.Tables(0).Rows.Count

                If a <> 0 Then
                    MsgBox("Receiver already saved", vbExclamation, "Error")
                    Clear()
                    Con.Close()
                Else
                    query = "INSERT INTO ReceiverTbl(ReceiverName, ReceiverCode, PhoneNumber) VALUES(@Nametxt, @hashString, @Phonetxt)"
                    Dim cmd1 As SqlCommand = New SqlCommand(query, Con)
                    cmd1.Parameters.AddWithValue("@Nametxt", Nametxt.Text)
                    cmd1.Parameters.AddWithValue("@hashString", hashString)
                    cmd1.Parameters.AddWithValue("@Phonetxt", Phonetxt.Text)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Receiver added successfully", vbInformation, "Success")
                    Con.Close()
                    DisplayUsers()
                    Clear()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbInformation)
                Con.Close()

            End Try
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub AdminReceivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUsers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Nametxt.Text = "" Or Phonetxt.Text = "" Or Codetxt.Text = "" Then
            MsgBox("Missing Information", vbExclamation, "Error")



        Else
            Dim input As String = Codetxt.Text ' Input string to compute SHA-3-256 hash for
            ' Dim input As String = "Hello, world!" ' Input string to compute SHA-3-256 hash for
            Dim sha3 As IDigest = New Sha3Digest(256) ' Create SHA-3-256 instance

            ' Convert input string to byte array
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)

            ' Compute SHA-3-256 hash as byte array
            Dim hashBytes As Byte() = New Byte(sha3.GetDigestSize() - 1) {}
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length)
            sha3.DoFinal(hashBytes, 0)

            ' Convert byte array to hexadecimal string
            Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()

            Try
                Con.Open()
                Dim query = "Update ReceiverTbl set ReceiverName = '" & Nametxt.Text & "', ReceiverCode = '" & hashString & "', PhoneNumber = '" & Phonetxt.Text & "' where Id = " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Receiver Information Edited", vbInformation, "Success")
                Con.Close()
                DisplayUsers()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message, vbInformation)
                Con.Close()
            End Try
        End If
    End Sub

    Private Sub UsersDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UsersDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = UsersDGV.Rows(e.RowIndex)
            Nametxt.Text = row.Cells(1).Value.ToString
            Codetxt.Text = row.Cells(2).Value.ToString
            Phonetxt.Text = row.Cells(3).Value.ToString
            If Nametxt.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If

        Catch ex As Exception
            MsgBox("Selection error", vbExclamation, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Key = 0 Then
                MsgBox("Missing Information", vbExclamation, "Error")
            Else
                Con.Open()
                Dim query = "delete from ReceiverTbl where Id = " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Receiver deleted", vbInformation, "Success")
                Con.Close()
                DisplayUsers()
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
            Con.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub Phonetxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phonetxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Phonetxt_TextChanged(sender As Object, e As EventArgs) Handles Phonetxt.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        Phonetxt.Text = digitsOnly.Replace(Phonetxt.Text, "")
    End Sub
End Class