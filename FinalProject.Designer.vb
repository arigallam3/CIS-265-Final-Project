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
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Graded Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Possible Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Your Points:"
        '
        'txtGradedItem
        '
        Me.txtGradedItem.Location = New System.Drawing.Point(195, 239)
        Me.txtGradedItem.Name = "txtGradedItem"
        Me.txtGradedItem.Size = New System.Drawing.Size(178, 22)
        Me.txtGradedItem.TabIndex = 3
        '
        'txtPossiblePoints
        '
        Me.txtPossiblePoints.Location = New System.Drawing.Point(195, 302)
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
        Me.Label4.Location = New System.Drawing.Point(117, 174)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 688)
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
End Class
