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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.btnBrowseDir = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnBrowseBackup = New System.Windows.Forms.Button()
        Me.txtBackup = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkPadder = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Helper = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 351)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Steam 3 ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(137, 149)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(123, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label3.Location = New System.Drawing.Point(38, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Steam Installation Directory"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(33, 216)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ReadOnly = True
        Me.txtDir.Size = New System.Drawing.Size(223, 20)
        Me.txtDir.TabIndex = 7
        Me.txtDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBrowseDir
        '
        Me.btnBrowseDir.Location = New System.Drawing.Point(262, 214)
        Me.btnBrowseDir.Name = "btnBrowseDir"
        Me.btnBrowseDir.Size = New System.Drawing.Size(27, 22)
        Me.btnBrowseDir.TabIndex = 9
        Me.btnBrowseDir.Text = "..."
        Me.btnBrowseDir.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(7, 366)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(308, 34)
        Me.btnFinish.TabIndex = 10
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnBrowseBackup
        '
        Me.btnBrowseBackup.Location = New System.Drawing.Point(262, 297)
        Me.btnBrowseBackup.Name = "btnBrowseBackup"
        Me.btnBrowseBackup.Size = New System.Drawing.Size(27, 22)
        Me.btnBrowseBackup.TabIndex = 13
        Me.btnBrowseBackup.Text = "..."
        Me.btnBrowseBackup.UseVisualStyleBackColor = True
        '
        'txtBackup
        '
        Me.txtBackup.Location = New System.Drawing.Point(33, 299)
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.ReadOnly = True
        Me.txtBackup.Size = New System.Drawing.Size(223, 20)
        Me.txtBackup.TabIndex = 12
        Me.txtBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Custom Backup Location"
        '
        'chkPadder
        '
        Me.chkPadder.AutoSize = True
        Me.chkPadder.Location = New System.Drawing.Point(53, 403)
        Me.chkPadder.Name = "chkPadder"
        Me.chkPadder.Size = New System.Drawing.Size(215, 17)
        Me.chkPadder.TabIndex = 14
        Me.chkPadder.Text = "Enable form loading before game launch"
        Me.chkPadder.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 12)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "?"
        Me.Helper.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(322, 422)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkPadder)
        Me.Controls.Add(Me.btnBrowseBackup)
        Me.Controls.Add(Me.txtBackup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnBrowseDir)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "First-time Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseDir As System.Windows.Forms.Button
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents btnBrowseBackup As System.Windows.Forms.Button
    Friend WithEvents txtBackup As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkPadder As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Helper As System.Windows.Forms.ToolTip
End Class
