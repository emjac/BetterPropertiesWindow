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
        Me.DataGridViewSection = New System.Windows.Forms.DataGridView()
        Me.BumpButton = New System.Windows.Forms.Button()
        Me.CopyNodeNumButton = New System.Windows.Forms.Button()
        Me.CopyBeamNumButton = New System.Windows.Forms.Button()
        Me.TextBoxFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFilter = New System.Windows.Forms.TextBox()
        Me.DataSetStaadProperties = New System.Data.DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.TextBoxAdd = New System.Windows.Forms.TextBox()
        Me.LabelAdd = New System.Windows.Forms.Label()
        Me.DataSetAISCProperties = New System.Data.DataSet()
        CType(Me.DataGridViewSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetStaadProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAISCProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssignToSelectedButton
        '
        resources.ApplyResources(Me.AssignToSelectedButton, "AssignToSelectedButton")
        Me.AssignToSelectedButton.Name = "AssignToSelectedButton"
        Me.AssignToSelectedButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridViewSection
        '
        Me.DataGridViewSection.AllowUserToAddRows = False
        Me.DataGridViewSection.AllowUserToDeleteRows = False
        Me.DataGridViewSection.AllowUserToResizeRows = False
        Me.DataGridViewSection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewSection.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewSection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.DataGridViewSection, "DataGridViewSection")
        Me.DataGridViewSection.MultiSelect = False
        Me.DataGridViewSection.Name = "DataGridViewSection"
        Me.DataGridViewSection.ReadOnly = True
        Me.DataGridViewSection.RowHeadersVisible = False
        Me.DataGridViewSection.RowTemplate.Height = 33
        Me.DataGridViewSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'BumpButton
        '
        resources.ApplyResources(Me.BumpButton, "BumpButton")
        Me.BumpButton.Name = "BumpButton"
        Me.BumpButton.UseVisualStyleBackColor = True
        '
        'CopyNodeNumButton
        '
        resources.ApplyResources(Me.CopyNodeNumButton, "CopyNodeNumButton")
        Me.CopyNodeNumButton.Name = "CopyNodeNumButton"
        Me.CopyNodeNumButton.UseVisualStyleBackColor = True
        '
        'CopyBeamNumButton
        '
        resources.ApplyResources(Me.CopyBeamNumButton, "CopyBeamNumButton")
        Me.CopyBeamNumButton.Name = "CopyBeamNumButton"
        Me.CopyBeamNumButton.UseVisualStyleBackColor = True
        '
        'TextBoxFileName
        '
        resources.ApplyResources(Me.TextBoxFileName, "TextBoxFileName")
        Me.TextBoxFileName.Name = "TextBoxFileName"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TextBoxFilter
        '
        resources.ApplyResources(Me.TextBoxFilter, "TextBoxFilter")
        Me.TextBoxFilter.Name = "TextBoxFilter"
        '
        'DataSetStaadProperties
        '
        Me.DataSetStaadProperties.DataSetName = "NewDataSet"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'DeleteButton
        '
        resources.ApplyResources(Me.DeleteButton, "DeleteButton")
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        resources.ApplyResources(Me.ButtonAdd, "ButtonAdd")
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'TextBoxAdd
        '
        resources.ApplyResources(Me.TextBoxAdd, "TextBoxAdd")
        Me.TextBoxAdd.Name = "TextBoxAdd"
        '
        'LabelAdd
        '
        resources.ApplyResources(Me.LabelAdd, "LabelAdd")
        Me.LabelAdd.Name = "LabelAdd"
        '
        'DataSetAISCProperties
        '
        Me.DataSetAISCProperties.DataSetName = "NewDataSet"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelAdd)
        Me.Controls.Add(Me.TextBoxAdd)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFileName)
        Me.Controls.Add(Me.CopyBeamNumButton)
        Me.Controls.Add(Me.CopyNodeNumButton)
        Me.Controls.Add(Me.BumpButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AssignToSelectedButton)
        Me.Controls.Add(Me.DataGridViewSection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        CType(Me.DataGridViewSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetStaadProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAISCProperties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewSection As DataGridView
    Friend WithEvents BumpButton As Button
    Friend WithEvents CopyNodeNumButton As Button
    Friend WithEvents CopyBeamNumButton As Button
    Friend WithEvents TextBoxFileName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFilter As TextBox
    Friend WithEvents DataSetStaadProperties As DataSet
    Friend WithEvents Label2 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxAdd As TextBox
    Friend WithEvents LabelAdd As Label
    Friend WithEvents DataSetAISCProperties As DataSet
End Class
