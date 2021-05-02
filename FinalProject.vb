Imports System.IO

Public Class frmMain

    Dim table As New DataTable("Table")
    Dim index As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("Graded Item", Type.GetType("System.String"))
        table.Columns.Add("Possible Points", Type.GetType("System.Int32"))
        table.Columns.Add("Your Points", Type.GetType("System.Int32"))


        dgvOutput.DataSource = table



    End Sub


    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        table.Rows.Add(txtId.Text, txtGradedItem.Text, txtPossiblePoints.Text, txtYourPoints.Text)
        dgvOutput.DataSource = table

        Dim textToAppend As String

        textToAppend = txtId.Text + "," + txtGradedItem.Text + "," + txtPossiblePoints.Text + "," + txtYourPoints.Text + vbCrLf

        Try
            File.AppendAllText("grade1.txt", textToAppend)
            txtId.Clear()
            txtGradedItem.Clear()
            txtPossiblePoints.Clear()
            txtYourPoints.Clear()
        Catch ex As Exception
            MsgBox("Append Failed")
        End Try


    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim newDataRow As DataGridViewRow
        newDataRow = dgvOutput.Rows(index)
        newDataRow.Cells(0).Value = txtId.Text
        newDataRow.Cells(1).Value = txtGradedItem.Text
        newDataRow.Cells(2).Value = txtPossiblePoints.Text
        newDataRow.Cells(3).Value = txtYourPoints.Text


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

        dgvOutput.Rows.RemoveAt(index)

    End Sub

    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click

        Dim lines() As String
        Dim vals() As String

        lines = File.ReadAllLines("C:\Home\Student\Gallamoza\Final Project\bin\Debug\grade1.txt")

        For i As Integer = 0 To lines.Length - 1 Step +1

            vals = lines(i).ToString().Split(",")
            Dim row(vals.Length - 1) As String

            For j As Integer = 0 To vals.Length - 1 Step +1

                row(j) = vals(j).Trim()

            Next j

            table.Rows.Add(row)

        Next i

    End Sub
End Class
