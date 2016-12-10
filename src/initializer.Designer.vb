<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class initializer
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.MonitorGame = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(196, 35)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonitorGame
        '
        Me.MonitorGame.Interval = 5000
        '
        'initializer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 35)
        Me.Controls.Add(Me.lblStatus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "initializer"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initializing..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents MonitorGame As System.Windows.Forms.Timer

End Class
