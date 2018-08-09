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
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DefineButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SectonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssignToSelectedButton
        '
        Me.AssignToSelectedButton.Location = New System.Drawing.Point(420, 773)
        Me.AssignToSelectedButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AssignToSelectedButton.Name = "AssignToSelectedButton"
        Me.AssignToSelectedButton.Size = New System.Drawing.Size(322, 40)
        Me.AssignToSelectedButton.TabIndex = 5
        Me.AssignToSelectedButton.Text = "Assign To Selected Beams"
        Me.AssignToSelectedButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 637)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(290, 29)
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
        Me.SectonDataGridView.Location = New System.Drawing.Point(22, 69)
        Me.SectonDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SectonDataGridView.MultiSelect = False
        Me.SectonDataGridView.Name = "SectonDataGridView"
        Me.SectonDataGridView.ReadOnly = True
        Me.SectonDataGridView.RowHeadersVisible = False
        Me.SectonDataGridView.RowTemplate.Height = 33
        Me.SectonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SectonDataGridView.Size = New System.Drawing.Size(720, 560)
        Me.SectonDataGridView.TabIndex = 3
        '
        'BumpButton
        '
        Me.BumpButton.Location = New System.Drawing.Point(28, 835)
        Me.BumpButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BumpButton.Name = "BumpButton"
        Me.BumpButton.Size = New System.Drawing.Size(250, 40)
        Me.BumpButton.TabIndex = 11
        Me.BumpButton.Text = "Bump Sections"
        Me.BumpButton.UseVisualStyleBackColor = True
        '
        'CopyNodeNumButton
        '
        Me.CopyNodeNumButton.Location = New System.Drawing.Point(30, 883)
        Me.CopyNodeNumButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CopyNodeNumButton.Name = "CopyNodeNumButton"
        Me.CopyNodeNumButton.Size = New System.Drawing.Size(320, 40)
        Me.CopyNodeNumButton.TabIndex = 12
        Me.CopyNodeNumButton.Text = "Copy Node Numbers As Table"
        Me.CopyNodeNumButton.UseVisualStyleBackColor = True
        '
        'CopyBeamNumButton
        '
        Me.CopyBeamNumButton.Location = New System.Drawing.Point(28, 931)
        Me.CopyBeamNumButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CopyBeamNumButton.Name = "CopyBeamNumButton"
        Me.CopyBeamNumButton.Size = New System.Drawing.Size(320, 40)
        Me.CopyBeamNumButton.TabIndex = 13
        Me.CopyBeamNumButton.Text = "Copy Beam Numbers As Table"
        Me.CopyBeamNumButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(548, 671)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(194, 40)
        Me.DeleteButton.TabIndex = 14
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(342, 671)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(194, 40)
        Me.EditButton.TabIndex = 15
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(342, 723)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(194, 40)
        Me.AddButton.TabIndex = 16
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DefineButton
        '
        Me.DefineButton.Location = New System.Drawing.Point(548, 723)
        Me.DefineButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DefineButton.Name = "DefineButton"
        Me.DefineButton.Size = New System.Drawing.Size(194, 40)
        Me.DefineButton.TabIndex = 17
        Me.DefineButton.Text = "Define"
        Me.DefineButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(575, 31)
        Me.TextBox1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staad File : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(778, 992)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DefineButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.CopyBeamNumButton)
        Me.Controls.Add(Me.CopyNodeNumButton)
        Me.Controls.Add(Me.BumpButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AssignToSelectedButton)
        Me.Controls.Add(Me.SectonDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents DefineButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
