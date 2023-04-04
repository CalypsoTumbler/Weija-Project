Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Repairs
    Public Property check1 As String
    Dim Con As New SqlConnection(My.Settings.AssetDbConnectionString)

    Private Sub DisplayFaults()
        Try
            Con.Open()
            Dim Sql = "select * from FaultTbl Order By DateReported Desc"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(Sql, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            FaultsDGV.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
            Con.Close()
        End Try
    End Sub
    Private Sub Repairs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayFaults()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Dim Key = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim atLeastOneChecked As Boolean = False

        For Each cb As CheckBox In AssetStatusGroupBox.Controls
            If cb.Checked Then
                atLeastOneChecked = True
                Exit For
            End If
        Next

        ' If Not atLeastOneChecked Then
        'MsgBox("Update asset status", vbExclamation, "Error")
        ' None of the checkboxes are checked
        ' Handle the error or display a message to the user
        'End If

        If Not atLeastOneChecked Then
                MsgBox("Update asset status", vbExclamation, "Error")
            Else
                Try
                    Con.Open()
                    Dim query = "Update FaultTbl set AssetStatus = '" & check1 & "', RepairRemarks = '" & RRemarksTxt.Text & "', DateRepaired = '" & RepairDateDTP.Value.Date & "' where Id = " & Key & ""
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, Con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Fault repair information recorded successfully", vbInformation, "Success")
                    Con.Close()
                    DisplayFaults()

                Catch ex As Exception
                    MsgBox(ex.Message, vbInformation)
            Con.Close()
        End Try
        ' None of the checkboxes are checked
        'Handle the error Or display a message to the user
        End If

    End Sub

    Private Sub FaultsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FaultsDGV.CellContentClick

    End Sub
    Public Property A As String
    Public Property B As String
    Public Property C As String
    Public Property D As String
    Public Property F As String
    Public Property G As String
    Public Property H As String
    Public Property I As String
    Public Property J As String
    Public Property K As String
    Private Sub FaultsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FaultsDGV.CellMouseClick
        Try

            Dim row As DataGridViewRow = FaultsDGV.Rows(e.RowIndex)
            ' B = row.Cells(0).Value.ToString
            C = row.Cells(1).Value.ToString
            D = row.Cells(2).Value.ToString
            F = row.Cells(3).Value.ToString
            G = row.Cells(4).Value.ToString
            H = row.Cells(5).Value.ToString
            I = row.Cells(6).Value.ToString
            J = row.Cells(7).Value.ToString
            K = row.Cells(8).Value.ToString
            RRemarksTxt.Text = I + " - " + J
            If RRemarksTxt.Text = B Then
                Key = 0
            Else
                Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If

        Catch ex As Exception
            MsgBox("Selection error")
        End Try
    End Sub

    Private Sub ResolvedCHB_CheckedChanged(sender As Object, e As EventArgs) Handles ResolvedCHB.CheckedChanged
        If ResolvedCHB.CheckState = CheckState.Checked Then
            PendingCHB.CheckState = CheckState.Unchecked
            DamagedCHB.CheckState = CheckState.Unchecked
            check1 = "Resolved"
        End If
    End Sub

    Private Sub PendingCHB_CheckedChanged(sender As Object, e As EventArgs) Handles PendingCHB.CheckedChanged
        If PendingCHB.CheckState = CheckState.Checked Then
            ResolvedCHB.CheckState = CheckState.Unchecked
            DamagedCHB.CheckState = CheckState.Unchecked
            check1 = "Pending"
        End If
    End Sub

    Private Sub DamagedCHB_CheckedChanged(sender As Object, e As EventArgs) Handles DamagedCHB.CheckedChanged
        If DamagedCHB.CheckState = CheckState.Checked Then
            ResolvedCHB.CheckState = CheckState.Unchecked
            PendingCHB.CheckState = CheckState.Unchecked
            check1 = "Damaged"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim myDate As DateTime = DateTime.Parse(H)
        If RRemarksTxt.Text = "" Or RepairDateDTP.Value.Date.ToString() = "" Then
            MsgBox("Select the asset", vbExclamation, "Error")
        Else
            Try
                Con.Open()
                Dim report As New PrintFault

                Dim RQuery As String
                RQuery = "Select ComplainantName, ComplainantDepartment, DateReported, AssetName, AssetTag, ReportedIssue, AssignedTo, AssetStatus, RepairRemarks, DateRepaired From FaultTbl where ComplainantName = '" & C & "' And DateReported = '" & H & "'"
                Dim Rcmd As New SqlCommand(RQuery, Con)
                Dim rsd As New SqlDataAdapter(Rcmd)
                'Dim ds1 As New DataSet
                Dim rdt As New DataTable
                rsd.Fill(rdt)



                With report.ReportViewer1.LocalReport
                    .DataSources.Clear()
                    .ReportPath = "FaultReport.rdlc"
                    .DataSources.Add(New ReportDataSource("DataSet1", rdt))
                End With


                report.ReportViewer1.RefreshReport()
                report.Show()


                Con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation, "Error")
            End Try
        End If
    End Sub

    Private Sub RRemarksTxt_TextChanged(sender As Object, e As EventArgs) Handles RRemarksTxt.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Fault.Show()
    End Sub

    Private Sub Repairs_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        DisplayFaults()
    End Sub
End Class