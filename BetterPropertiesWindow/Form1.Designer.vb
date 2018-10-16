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
        Me.SectionDataGridView = New System.Windows.Forms.DataGridView()
        Me.BumpButton = New System.Windows.Forms.Button()
        Me.CopyNodeNumButton = New System.Windows.Forms.Button()
        Me.CopyBeamNumButton = New System.Windows.Forms.Button()
        Me.TextBoxFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFilter = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.SectionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssignToSelectedButton
        '
        Me.AssignToSelectedButton.Location = New System.Drawing.Point(131, 434)
        Me.AssignToSelectedButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AssignToSelectedButton.Name = "AssignToSelectedButton"
        Me.AssignToSelectedButton.Size = New System.Drawing.Size(148, 21)
        Me.AssignToSelectedButton.TabIndex = 5
        Me.AssignToSelectedButton.Text = "Assign To Selected Beams"
        Me.AssignToSelectedButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 413)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Highlight Selected Beams"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SectionDataGridView
        '
        Me.SectionDataGridView.AllowUserToDeleteRows = False
        Me.SectionDataGridView.AllowUserToResizeRows = False
        Me.SectionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SectionDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.SectionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.SectionDataGridView.Location = New System.Drawing.Point(11, 33)
        Me.SectionDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.SectionDataGridView.Name = "SectionDataGridView"
        Me.SectionDataGridView.RowHeadersVisible = False
        Me.SectionDataGridView.RowTemplate.Height = 33
        Me.SectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SectionDataGridView.Size = New System.Drawing.Size(293, 376)
        Me.SectionDataGridView.TabIndex = 3
        '
        'BumpButton
        '
        Me.BumpButton.Location = New System.Drawing.Point(14, 434)
        Me.BumpButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BumpButton.Name = "BumpButton"
        Me.BumpButton.Size = New System.Drawing.Size(91, 21)
        Me.BumpButton.TabIndex = 11
        Me.BumpButton.Text = "Bump Sections"
        Me.BumpButton.UseVisualStyleBackColor = True
        '
        'CopyNodeNumButton
        '
        Me.CopyNodeNumButton.Location = New System.Drawing.Point(15, 459)
        Me.CopyNodeNumButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CopyNodeNumButton.Name = "CopyNodeNumButton"
        Me.CopyNodeNumButton.Size = New System.Drawing.Size(126, 21)
        Me.CopyNodeNumButton.TabIndex = 12
        Me.CopyNodeNumButton.Text = "Copy Node # As Table"
        Me.CopyNodeNumButton.UseVisualStyleBackColor = True
        '
        'CopyBeamNumButton
        '
        Me.CopyBeamNumButton.Location = New System.Drawing.Point(15, 484)
        Me.CopyBeamNumButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CopyBeamNumButton.Name = "CopyBeamNumButton"
        Me.CopyBeamNumButton.Size = New System.Drawing.Size(126, 21)
        Me.CopyBeamNumButton.TabIndex = 13
        Me.CopyBeamNumButton.Text = "Copy Beam # As Table"
        Me.CopyBeamNumButton.UseVisualStyleBackColor = True
        '
        'TextBoxFileName
        '
        Me.TextBoxFileName.Location = New System.Drawing.Point(84, 8)
        Me.TextBoxFileName.Name = "TextBoxFileName"
        Me.TextBoxFileName.Size = New System.Drawing.Size(220, 20)
        Me.TextBoxFileName.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staad File : "
        '
        'TextBoxFilter
        '
        Me.TextBoxFilter.Location = New System.Drawing.Point(147, 485)
        Me.TextBoxFilter.Name = "TextBoxFilter"
        Me.TextBoxFilter.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxFilter.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 20)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(312, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFileName)
        Me.Controls.Add(Me.CopyBeamNumButton)
        Me.Controls.Add(Me.CopyNodeNumButton)
        Me.Controls.Add(Me.BumpButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AssignToSelectedButton)
        Me.Controls.Add(Me.SectionDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Awesome Staad Helper"
        CType(Me.SectionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SectionDataGridView As DataGridView
    Friend WithEvents BumpButton As Button
    Friend WithEvents CopyNodeNumButton As Button
    Friend WithEvents CopyBeamNumButton As Button
    Friend WithEvents TextBoxFileName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFilter As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet
End Class
