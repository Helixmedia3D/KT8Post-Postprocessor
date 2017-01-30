<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class instellingen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instellingen))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.speede3d = New System.Windows.Forms.TextBox()
        Me.speed1730 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDwell = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 237)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(423, 152)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(28, 433)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(423, 152)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 731)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Opslaan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(388, 731)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Annuleren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Toolswitch naar T0  (1730 Hotend)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Toolswitch naar T1  (E3D Hotend)"
        '
        'speede3d
        '
        Me.speede3d.Location = New System.Drawing.Point(167, 632)
        Me.speede3d.Name = "speede3d"
        Me.speede3d.Size = New System.Drawing.Size(100, 20)
        Me.speede3d.TabIndex = 8
        Me.ToolTip3.SetToolTip(Me.speede3d, "Snelheid (in procenten) van de ventilator die het werkstuk koelt.")
        '
        'speed1730
        '
        Me.speed1730.Location = New System.Drawing.Point(167, 606)
        Me.speed1730.Name = "speed1730"
        Me.speed1730.Size = New System.Drawing.Size(100, 20)
        Me.speed1730.TabIndex = 9
        Me.ToolTip3.SetToolTip(Me.speed1730, "Snelheid (in procenten) van de ventilator die het werkstuk koelt.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 606)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fanspeed 1730 [%]"
        Me.ToolTip3.SetToolTip(Me.Label3, "Snelheid (in procenten) van de ventilator die het werkstuk koelt.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 633)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fanspeed E3D [%]"
        Me.ToolTip3.SetToolTip(Me.Label4, "Snelheid (in procenten) van de ventilator die het werkstuk koelt.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 659)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Verwarmde kamer temperatuur [C]"
        Me.ToolTip2.SetToolTip(Me.Label5, "Hoge temperaturen kunnen de machine permanent beschadigen bij onjuist gebruik!")
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "27", "33", "40", "46", "53", "60", "66", "72", "79", "85"})
        Me.ComboBox1.Location = New System.Drawing.Point(252, 658)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ToolTip2.SetToolTip(Me.ComboBox1, "Hoge temperaturen kunnen de machine permanent beschadigen bij onjuist gebruik!")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 666)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Start Tool Gcode T0 / T1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(28, 40)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(423, 152)
        Me.TextBox3.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 685)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Opwarmen chamber dwell [sec]"
        Me.ToolTip1.SetToolTip(Me.Label8, "Pauzeert de machine voor een X aantal seconden totdat de machine is opgewarmd.")
        '
        'TextBoxDwell
        '
        Me.TextBoxDwell.Location = New System.Drawing.Point(252, 685)
        Me.TextBoxDwell.Name = "TextBoxDwell"
        Me.TextBoxDwell.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDwell.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.TextBoxDwell, "Pauzeert de machine voor een X aantal seconden totdat de machine is opgewarmd.")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "dwell (G4)"
        '
        'ToolTip2
        '
        Me.ToolTip2.AutomaticDelay = 200
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.ToolTip2.ToolTipTitle = "Verwarmde kamer temperatuur"
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip3.ToolTipTitle = "Part cooling fan snelheid"
        '
        'instellingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 769)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxDwell)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.speed1730)
        Me.Controls.Add(Me.speede3d)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(496, 808)
        Me.MinimumSize = New System.Drawing.Size(496, 808)
        Me.Name = "instellingen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instellingen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents speede3d As TextBox
    Friend WithEvents speed1730 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDwell As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
End Class
