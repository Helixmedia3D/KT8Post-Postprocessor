<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class handleiding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(handleiding))
        Me.WebBrowserHANDLEIDING = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowserHANDLEIDING
        '
        Me.WebBrowserHANDLEIDING.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserHANDLEIDING.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserHANDLEIDING.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserHANDLEIDING.Name = "WebBrowserHANDLEIDING"
        Me.WebBrowserHANDLEIDING.Size = New System.Drawing.Size(624, 761)
        Me.WebBrowserHANDLEIDING.TabIndex = 0
        Me.WebBrowserHANDLEIDING.Url = New System.Uri("https://drive.google.com/file/d/0B50UYnGibGrvUlB5d21MRWc0OTQ/view", System.UriKind.Absolute)
        '
        'handleiding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 761)
        Me.Controls.Add(Me.WebBrowserHANDLEIDING)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "handleiding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Handleiding"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserHANDLEIDING As WebBrowser
End Class
