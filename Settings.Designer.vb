<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnSetID = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSetDir = New System.Windows.Forms.Button()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.btnBrowseDir = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 260)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Steam 3 ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(112, 149)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(117, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSetID
        '
        Me.btnSetID.Enabled = False
        Me.btnSetID.Location = New System.Drawing.Point(235, 147)
        Me.btnSetID.Name = "btnSetID"
        Me.btnSetID.Size = New System.Drawing.Size(44, 22)
        Me.btnSetID.TabIndex = 3
        Me.btnSetID.Text = "Set"
        Me.btnSetID.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(193, 61)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(42, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "this site"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Steam Installation Directory"
        '
        'btnSetDir
        '
        Me.btnSetDir.Enabled = False
        Me.btnSetDir.Location = New System.Drawing.Point(270, 214)
        Me.btnSetDir.Name = "btnSetDir"
        Me.btnSetDir.Size = New System.Drawing.Size(44, 22)
        Me.btnSetDir.TabIndex = 8
        Me.btnSetDir.Text = "Set"
        Me.btnSetDir.UseVisualStyleBackColor = True
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(8, 216)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ReadOnly = True
        Me.txtDir.Size = New System.Drawing.Size(223, 20)
        Me.txtDir.TabIndex = 7
        Me.txtDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBrowseDir
        '
        Me.btnBrowseDir.Location = New System.Drawing.Point(237, 214)
        Me.btnBrowseDir.Name = "btnBrowseDir"
        Me.btnBrowseDir.Size = New System.Drawing.Size(27, 22)
        Me.btnBrowseDir.TabIndex = 9
        Me.btnBrowseDir.Text = "..."
        Me.btnBrowseDir.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(7, 279)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(308, 23)
        Me.btnFinish.TabIndex = 10
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 306)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnBrowseDir)
        Me.Controls.Add(Me.btnSetDir)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnSetID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First-time Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnSetID As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSetDir As System.Windows.Forms.Button
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseDir As System.Windows.Forms.Button
    Friend WithEvents btnFinish As System.Windows.Forms.Button
End Class
