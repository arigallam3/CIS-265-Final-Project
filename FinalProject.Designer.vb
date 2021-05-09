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
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.mnuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdResources = New System.Windows.Forms.Button()
        Me.webViewResources = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuBar.SuspendLayout()
        CType(Me.webViewResources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Graded Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Possible Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Your Points:"
        '
        'txtGradedItem
        '
        Me.txtGradedItem.Location = New System.Drawing.Point(247, 245)
        Me.txtGradedItem.Name = "txtGradedItem"
        Me.txtGradedItem.Size = New System.Drawing.Size(178, 22)
        Me.txtGradedItem.TabIndex = 3
        '
        'txtPossiblePoints
        '
        Me.txtPossiblePoints.Location = New System.Drawing.Point(247, 308)
        Me.txtPossiblePoints.Name = "txtPossiblePoints"
        Me.txtPossiblePoints.Size = New System.Drawing.Size(178, 22)
        Me.txtPossiblePoints.TabIndex = 4
        '
        'txtYourPoints
        '
        Me.txtYourPoints.Location = New System.Drawing.Point(247, 375)
        Me.txtYourPoints.Name = "txtYourPoints"
        Me.txtYourPoints.Size = New System.Drawing.Size(178, 22)
        Me.txtYourPoints.TabIndex = 5
        '
        'dgvOutput
        '
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(616, 146)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersWidth = 51
        Me.dgvOutput.RowTemplate.Height = 24
        Me.dgvOutput.Size = New System.Drawing.Size(603, 427)
        Me.dgvOutput.TabIndex = 6
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(692, 64)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(119, 53)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(874, 64)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(119, 53)
        Me.cmdUpdate.TabIndex = 7
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(1046, 64)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(119, 53)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Id:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(247, 189)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(178, 22)
        Me.txtId.TabIndex = 2
        '
        'cmdImport
        '
        Me.cmdImport.Location = New System.Drawing.Point(48, 64)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(91, 57)
        Me.cmdImport.TabIndex = 1
        Me.cmdImport.Text = "Import"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(185, 475)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 55)
        Me.cmdClear.TabIndex = 11
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(321, 475)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 55)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblPossiblePoints
        '
        Me.lblPossiblePoints.AutoSize = True
        Me.lblPossiblePoints.Location = New System.Drawing.Point(625, 601)
        Me.lblPossiblePoints.Name = "lblPossiblePoints"
        Me.lblPossiblePoints.Size = New System.Drawing.Size(144, 17)
        Me.lblPossiblePoints.TabIndex = 15
        Me.lblPossiblePoints.Text = "Total Possible Points:"
        '
        'lblTotalYourPoints
        '
        Me.lblTotalYourPoints.AutoSize = True
        Me.lblTotalYourPoints.Location = New System.Drawing.Point(625, 639)
        Me.lblTotalYourPoints.Name = "lblTotalYourPoints"
        Me.lblTotalYourPoints.Size = New System.Drawing.Size(137, 17)
        Me.lblTotalYourPoints.TabIndex = 16
        Me.lblTotalYourPoints.Text = "Total of Your Points:"
        '
        'cmdUpdateTotal
        '
        Me.cmdUpdateTotal.Location = New System.Drawing.Point(628, 675)
        Me.cmdUpdateTotal.Name = "cmdUpdateTotal"
        Me.cmdUpdateTotal.Size = New System.Drawing.Size(294, 36)
        Me.cmdUpdateTotal.TabIndex = 9
        Me.cmdUpdateTotal.Text = "Update Total Amount of Points"
        Me.cmdUpdateTotal.UseVisualStyleBackColor = True
        '
        'cmdLetterGrade
        '
        Me.cmdLetterGrade.Location = New System.Drawing.Point(943, 675)
        Me.cmdLetterGrade.Name = "cmdLetterGrade"
        Me.cmdLetterGrade.Size = New System.Drawing.Size(276, 36)
        Me.cmdLetterGrade.TabIndex = 10
        Me.cmdLetterGrade.Text = "Determine what grade you have"
        Me.cmdLetterGrade.UseVisualStyleBackColor = True
        '
        'dgvGrade
        '
        Me.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrade.Location = New System.Drawing.Point(616, 758)
        Me.dgvGrade.Name = "dgvGrade"
        Me.dgvGrade.RowHeadersWidth = 51
        Me.dgvGrade.RowTemplate.Height = 24
        Me.dgvGrade.Size = New System.Drawing.Size(603, 362)
        Me.dgvGrade.TabIndex = 19
        Me.dgvGrade.Visible = False
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(160, 99)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(265, 22)
        Me.txtFileName.TabIndex = 20
        Me.txtFileName.Visible = False
        '
        'mnuBar
        '
        Me.mnuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuBar.Name = "mnuBar"
        Me.mnuBar.Size = New System.Drawing.Size(1329, 28)
        Me.mnuBar.TabIndex = 21
        Me.mnuBar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'cmdResources
        '
        Me.cmdResources.Location = New System.Drawing.Point(185, 668)
        Me.cmdResources.Name = "cmdResources"
        Me.cmdResources.Size = New System.Drawing.Size(137, 43)
        Me.cmdResources.TabIndex = 22
        Me.cmdResources.Text = "Helpful Resources"
        Me.cmdResources.UseVisualStyleBackColor = True
        Me.cmdResources.Visible = False
        '
        'webViewResources
        '
        Me.webViewResources.CreationProperties = Nothing
        Me.webViewResources.DefaultBackgroundColor = System.Drawing.Color.White
        Me.webViewResources.Location = New System.Drawing.Point(34, 758)
        Me.webViewResources.Name = "webViewResources"
        Me.webViewResources.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.webViewResources.Size = New System.Drawing.Size(520, 413)
        Me.webViewResources.TabIndex = 23
        Me.webViewResources.Visible = False
        Me.webViewResources.ZoomFactor = 1.0R
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 1299)
        Me.Controls.Add(Me.webViewResources)
        Me.Controls.Add(Me.cmdResources)
        Me.Controls.Add(Me.txtFileName)
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
        Me.Controls.Add(Me.mnuBar)
        Me.MainMenuStrip = Me.mnuBar
        Me.Name = "frmMain"
        Me.Text = "Final Project CIS 265"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuBar.ResumeLayout(False)
        Me.mnuBar.PerformLayout()
        CType(Me.webViewResources, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents mnuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdResources As Button
    Friend WithEvents webViewResources As Microsoft.Web.WebView2.WinForms.WebView2
End Class
