<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGradedItem = New System.Windows.Forms.TextBox()
        Me.txtPossiblePoints = New System.Windows.Forms.TextBox()
        Me.txtYourPoints = New System.Windows.Forms.TextBox()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblPossiblePoints = New System.Windows.Forms.Label()
        Me.lblTotalYourPoints = New System.Windows.Forms.Label()
        Me.cmdUpdateTotal = New System.Windows.Forms.Button()
        Me.cmdLetterGrade = New System.Windows.Forms.Button()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.dgvGrade = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Graded Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Possible Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Your Points:"
        '
        'txtGradedItem
        '
        Me.txtGradedItem.Location = New System.Drawing.Point(195, 230)
        Me.txtGradedItem.Name = "txtGradedItem"
        Me.txtGradedItem.Size = New System.Drawing.Size(178, 22)
        Me.txtGradedItem.TabIndex = 3
        '
        'txtPossiblePoints
        '
        Me.txtPossiblePoints.Location = New System.Drawing.Point(195, 293)
        Me.txtPossiblePoints.Name = "txtPossiblePoints"
        Me.txtPossiblePoints.Size = New System.Drawing.Size(178, 22)
        Me.txtPossiblePoints.TabIndex = 4
        '
        'txtYourPoints
        '
        Me.txtYourPoints.Location = New System.Drawing.Point(195, 360)
        Me.txtYourPoints.Name = "txtYourPoints"
        Me.txtYourPoints.Size = New System.Drawing.Size(178, 22)
        Me.txtYourPoints.TabIndex = 5
        '
        'dgvOutput
        '
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(495, 153)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersWidth = 51
        Me.dgvOutput.RowTemplate.Height = 24
        Me.dgvOutput.Size = New System.Drawing.Size(621, 427)
        Me.dgvOutput.TabIndex = 6
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(539, 67)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(119, 53)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(721, 67)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(119, 53)
        Me.cmdUpdate.TabIndex = 8
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(893, 67)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(119, 53)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Id:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(195, 174)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(178, 22)
        Me.txtId.TabIndex = 11
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(120, 46)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(91, 57)
        Me.cmdImport.TabIndex = 12
        Me.cmdImport.Text = "Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(133, 632)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 55)
        Me.cmdClear.TabIndex = 13
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(269, 632)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 55)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblPossiblePoints
        '
        Me.lblPossiblePoints.AutoSize = True
        Me.lblPossiblePoints.Location = New System.Drawing.Point(504, 607)
        Me.lblPossiblePoints.Name = "lblPossiblePoints"
        Me.lblPossiblePoints.Size = New System.Drawing.Size(144, 17)
        Me.lblPossiblePoints.TabIndex = 15
        Me.lblPossiblePoints.Text = "Total Possible Points:"
        '
        'lblTotalYourPoints
        '
        Me.lblTotalYourPoints.AutoSize = True
        Me.lblTotalYourPoints.Location = New System.Drawing.Point(504, 645)
        Me.lblTotalYourPoints.Name = "lblTotalYourPoints"
        Me.lblTotalYourPoints.Size = New System.Drawing.Size(137, 17)
        Me.lblTotalYourPoints.TabIndex = 16
        Me.lblTotalYourPoints.Text = "Total of Your Points:"
        '
        'cmdUpdateTotal
        '
        Me.cmdUpdateTotal.Location = New System.Drawing.Point(507, 681)
        Me.cmdUpdateTotal.Name = "cmdUpdateTotal"
        Me.cmdUpdateTotal.Size = New System.Drawing.Size(294, 36)
        Me.cmdUpdateTotal.TabIndex = 17
        Me.cmdUpdateTotal.Text = "Update Total Amount of Points"
        Me.cmdUpdateTotal.UseVisualStyleBackColor = True
        '
        'cmdLetterGrade
        '
        Me.cmdLetterGrade.Location = New System.Drawing.Point(822, 681)
        Me.cmdLetterGrade.Name = "cmdLetterGrade"
        Me.cmdLetterGrade.Size = New System.Drawing.Size(294, 36)
        Me.cmdLetterGrade.TabIndex = 18
        Me.cmdLetterGrade.Text = "Determine what grade you have"
        Me.cmdLetterGrade.UseVisualStyleBackColor = True
        '
        'dgvGrade
        '
        Me.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrade.Location = New System.Drawing.Point(495, 806)
        Me.dgvGrade.Name = "dgvGrade"
        Me.dgvGrade.RowHeadersWidth = 51
        Me.dgvGrade.RowTemplate.Height = 24
        Me.dgvGrade.Size = New System.Drawing.Size(621, 362)
        Me.dgvGrade.TabIndex = 19
        Me.dgvGrade.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 1299)
        Me.Controls.Add(Me.dgvGrade)
        Me.Controls.Add(Me.cmdLetterGrade)
        Me.Controls.Add(Me.cmdUpdateTotal)
        Me.Controls.Add(Me.lblTotalYourPoints)
        Me.Controls.Add(Me.lblPossiblePoints)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.txtYourPoints)
        Me.Controls.Add(Me.txtPossiblePoints)
        Me.Controls.Add(Me.txtGradedItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Final Project CIS 265"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGradedItem As TextBox
    Friend WithEvents txtPossiblePoints As TextBox
    Friend WithEvents txtYourPoints As TextBox
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents cmdImport As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblPossiblePoints As Label
    Friend WithEvents lblTotalYourPoints As Label
    Friend WithEvents cmdUpdateTotal As Button
    Friend WithEvents cmdLetterGrade As Button
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents dgvGrade As DataGridView
End Class
