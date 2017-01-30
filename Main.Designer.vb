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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InstellingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gcodepathtextbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.filesizelabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Post-Postproces"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstellingenToolStripMenuItem, Me.OverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InstellingenToolStripMenuItem
        '
        Me.InstellingenToolStripMenuItem.Name = "InstellingenToolStripMenuItem"
        Me.InstellingenToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.InstellingenToolStripMenuItem.Text = "Instellingen"
        '
        'OverToolStripMenuItem
        '
        Me.OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        Me.OverToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.OverToolStripMenuItem.Text = "Over"
        '
        'gcodepathtextbox
        '
        Me.gcodepathtextbox.Location = New System.Drawing.Point(75, 88)
        Me.gcodepathtextbox.Name = "gcodepathtextbox"
        Me.gcodepathtextbox.Size = New System.Drawing.Size(293, 20)
        Me.gcodepathtextbox.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(374, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Bladeren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'filesizelabel
        '
        Me.filesizelabel.AutoSize = True
        Me.filesizelabel.Location = New System.Drawing.Point(12, 307)
        Me.filesizelabel.Name = "filesizelabel"
        Me.filesizelabel.Size = New System.Drawing.Size(138, 13)
        Me.filesizelabel.TabIndex = 4
        Me.filesizelabel.Text = "Geen bestand geselecteerd"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "1. Open het Gcode-bestand afkomstig van Cura 15.04:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2. Post-postproces en sla het bestand opnieuw op:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 264)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(501, 27)
        Me.ProgressBar1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 329)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.filesizelabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.gcodepathtextbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(544, 368)
        Me.MinimumSize = New System.Drawing.Size(544, 368)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KT8 DUAL+  Post-Postprocessor v1.2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InstellingenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gcodepathtextbox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents filesizelabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
