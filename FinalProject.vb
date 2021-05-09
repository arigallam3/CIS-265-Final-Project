Imports System.IO

Public Class frmMain

    Dim table As New DataTable("Table")
    Dim index As Integer

    Dim table2 As New DataTable("Table2")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'this adds columns
        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("Graded Item", Type.GetType("System.String"))
        table.Columns.Add("Possible Points", Type.GetType("System.Int32"))
        table.Columns.Add("Your Points", Type.GetType("System.Int32"))

        dgvOutput.DataSource = table

    End Sub


    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        cmdImport.Enabled = False

        'this creates a row
        table.Rows.Add(txtId.Text, txtGradedItem.Text, txtPossiblePoints.Text, txtYourPoints.Text)
        dgvOutput.DataSource = table

        Dim stextToAppend As String

        stextToAppend = Environment.NewLine & txtId.Text & "," & txtGradedItem.Text & "," & txtPossiblePoints.Text & "," & txtYourPoints.Text

        Dim strText As String

        'open and saves file content
        strText = dlgOpenFile.FileName

        Try
            File.AppendAllText(strText, stextToAppend)
            txtId.Clear()
            txtGradedItem.Clear()
            txtPossiblePoints.Clear()
            txtYourPoints.Clear()
        Catch ex As Exception
            MsgBox("Append Failed")
        End Try

        lblPossiblePoints.Text = "Total Possible Points: "
        lblTotalYourPoints.Text = "Total of Your Points: "

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        cmdImport.Enabled = False

        Dim newDataRow As DataGridViewRow
        newDataRow = dgvOutput.Rows(index)
        newDataRow.Cells(0).Value = txtId.Text
        newDataRow.Cells(1).Value = txtGradedItem.Text
        newDataRow.Cells(2).Value = txtPossiblePoints.Text
        newDataRow.Cells(3).Value = txtYourPoints.Text

        lblPossiblePoints.Text = "Total Possible Points: "
        lblTotalYourPoints.Text = "Total of Your Points: "

    End Sub

    Private Sub dgvOutput_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutput.CellClick

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvOutput.Rows(index)
        txtId.Text = selectedRow.Cells(0).Value.ToString()
        txtGradedItem.Text = selectedRow.Cells(1).Value.ToString()
        txtPossiblePoints.Text = selectedRow.Cells(2).Value.ToString()
        txtYourPoints.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        cmdImport.Enabled = False
        dgvOutput.Rows.RemoveAt(index)

        txtId.Text = Nothing
        txtGradedItem.Text = Nothing
        txtPossiblePoints.Text = Nothing
        txtYourPoints.Text = Nothing

        lblPossiblePoints.Text = "Total Possible Points: "
        lblTotalYourPoints.Text = "Total of Your Points: "

    End Sub

    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click

        Dim slines() As String
        Dim svals() As String

        Dim strText As String
        dlgOpenFile.Filter = "Text File|*.txt"
        'dlgOpenFile.InitialDirectory = "C:\Home\Student\Gallamoza\Grades"
        dlgOpenFile.Title = "Open Text Files"
        dlgOpenFile.ShowDialog()

        strText = dlgOpenFile.FileName


        slines = File.ReadAllLines(strText)

        For i As Integer = 0 To slines.Length - 1 Step +1

            svals = slines(i).ToString().Split(",")
            Dim srow(svals.Length - 1) As String

            For j As Integer = 0 To svals.Length - 1 Step +1

                srow(j) = svals(j).Trim()

            Next j

            table.Rows.Add(srow)

        Next i

        'Total Possible Points and Total of Your Points 

        Dim dTotalPossiblePoints As Double
        For Each r As DataGridViewRow In dgvOutput.Rows
            dTotalPossiblePoints += r.Cells(2).Value
        Next

        lblPossiblePoints.Text = lblPossiblePoints.Text & " " & dTotalPossiblePoints & vbCrLf

        Dim dTotalYourPoints As Double
        For Each r As DataGridViewRow In dgvOutput.Rows
            dTotalYourPoints += r.Cells(3).Value
        Next

        lblTotalYourPoints.Text = lblTotalYourPoints.Text & " " & dTotalYourPoints

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtId.Text = Nothing
        txtGradedItem.Text = Nothing
        txtPossiblePoints.Text = Nothing
        txtYourPoints.Text = Nothing

        dgvGrade.Visible = False
        lblPossiblePoints.Text = "Total Possible Points: "
        lblTotalYourPoints.Text = "Total of Your Points: "

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdUpdateTotal_Click(sender As Object, e As EventArgs) Handles cmdUpdateTotal.Click

        'Total Possible Points and Total of Your Points 

        Dim dTotalPossiblePoints As Double
        For Each r As DataGridViewRow In dgvOutput.Rows
            dTotalPossiblePoints += r.Cells(2).Value
        Next

        lblPossiblePoints.Text = lblPossiblePoints.Text & " " & dTotalPossiblePoints & vbCrLf

        Dim dTotalYourPoints As Double
        For Each r As DataGridViewRow In dgvOutput.Rows
            dTotalYourPoints += r.Cells(3).Value
        Next

        lblTotalYourPoints.Text = lblTotalYourPoints.Text & " " & dTotalYourPoints
    End Sub

    Private Sub cmdLetterGrade_Click(sender As Object, e As EventArgs) Handles cmdLetterGrade.Click

        dgvGrade.Visible = True


        table2.Columns.Add("Grade", Type.GetType("System.String"))
        table2.Columns.Add("Percentage", Type.GetType("System.Int32"))
        table2.Columns.Add(">=", Type.GetType("System.Double"))
        table2.Columns.Add("<", Type.GetType("System.Double"))

        dgvGrade.DataSource = table2



        Dim dTotalPossiblePoints As Double
        For Each r As DataGridViewRow In dgvOutput.Rows
            dTotalPossiblePoints += r.Cells(2).Value
        Next

        table2.Rows.Add("A", 95, ((95 * dTotalPossiblePoints) / 100), 0)
        table2.Rows.Add("A-", 90, ((90 * dTotalPossiblePoints) / 100), ((95 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("B+", 87, ((87 * dTotalPossiblePoints) / 100), ((90 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("B", 83, ((83 * dTotalPossiblePoints) / 100), ((87 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("B-", 80, ((80 * dTotalPossiblePoints) / 100), ((83 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("C+", 75, ((75 * dTotalPossiblePoints) / 100), ((80 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("C", 70, ((70 * dTotalPossiblePoints) / 100), ((75 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("D+", 67, ((67 * dTotalPossiblePoints) / 100), ((70 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("D", 63, ((63 * dTotalPossiblePoints) / 100), ((67 * dTotalPossiblePoints) / 100))
        table2.Rows.Add("D-", 60, ((60 * dTotalPossiblePoints) / 100), ((63 * dTotalPossiblePoints) / 100))

    End Sub
End Class
