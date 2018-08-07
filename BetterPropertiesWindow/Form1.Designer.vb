<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AssignToSelectedButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SectonDataGridView = New System.Windows.Forms.DataGridView()
        Me.BumpButton = New System.Windows.Forms.Button()
        Me.CopyNodeNumButton = New System.Windows.Forms.Button()
        Me.CopyBeamNumButton = New System.Windows.Forms.Button()
        CType(Me.SectonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssignToSelectedButton
        '
        Me.AssignToSelectedButton.Location = New System.Drawing.Point(207, 306)
        Me.AssignToSelectedButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AssignToSelectedButton.Name = "AssignToSelectedButton"
        Me.AssignToSelectedButton.Size = New System.Drawing.Size(161, 28)
        Me.AssignToSelectedButton.TabIndex = 5
        Me.AssignToSelectedButton.Text = "Assign To Selected Beams"
        Me.AssignToSelectedButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(21, 306)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Highlight Selected Beams"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SectonDataGridView
        '
        Me.SectonDataGridView.AllowUserToAddRows = False
        Me.SectonDataGridView.AllowUserToDeleteRows = False
        Me.SectonDataGridView.AllowUserToResizeRows = False
        Me.SectonDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SectonDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.SectonDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SectonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectonDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SectonDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.SectonDataGridView.Name = "SectonDataGridView"
        Me.SectonDataGridView.RowHeadersVisible = False
        Me.SectonDataGridView.RowTemplate.Height = 33
        Me.SectonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SectonDataGridView.Size = New System.Drawing.Size(362, 291)
        Me.SectonDataGridView.TabIndex = 3
        '
        'BumpButton
        '
        Me.BumpButton.Location = New System.Drawing.Point(225, 421)
        Me.BumpButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BumpButton.Name = "BumpButton"
        Me.BumpButton.Size = New System.Drawing.Size(125, 28)
        Me.BumpButton.TabIndex = 11
        Me.BumpButton.Text = "Bump Sections"
        Me.BumpButton.UseVisualStyleBackColor = True
        '
        'CopyNodeNumButton
        '
        Me.CopyNodeNumButton.Location = New System.Drawing.Point(8, 376)
        Me.CopyNodeNumButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CopyNodeNumButton.Name = "CopyNodeNumButton"
        Me.CopyNodeNumButton.Size = New System.Drawing.Size(158, 22)
        Me.CopyNodeNumButton.TabIndex = 12
        Me.CopyNodeNumButton.Text = "Copy Node Numbers As Table"
        Me.CopyNodeNumButton.UseVisualStyleBackColor = True
        '
        'CopyBeamNumButton
        '
        Me.CopyBeamNumButton.Location = New System.Drawing.Point(8, 408)
        Me.CopyBeamNumButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CopyBeamNumButton.Name = "CopyBeamNumButton"
        Me.CopyBeamNumButton.Size = New System.Drawing.Size(158, 22)
        Me.CopyBeamNumButton.TabIndex = 13
        Me.CopyBeamNumButton.Text = "Copy Beam Numbers As Table"
        Me.CopyBeamNumButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 480)
        Me.Controls.Add(Me.CopyBeamNumButton)
        Me.Controls.Add(Me.CopyNodeNumButton)
        Me.Controls.Add(Me.BumpButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AssignToSelectedButton)
        Me.Controls.Add(Me.SectonDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Awesome Staad Helper"
        CType(Me.SectonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AssignToSelectedButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents SectonDataGridView As DataGridView
    Friend WithEvents BumpButton As Button
    Friend WithEvents CopyNodeNumButton As Button
    Friend WithEvents CopyBeamNumButton As Button
End Class
