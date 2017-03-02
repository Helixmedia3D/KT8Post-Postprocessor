Imports System.ComponentModel

Public Class instellingen
    Private Sub instellingen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub

    Private Sub instellingen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.T0
        TextBox2.Text = My.Settings.T1
        TextBox3.Text = My.Settings.STARTTOOL
        speed1730.Text = My.Settings.SPEED1730
        speede3d.Text = My.Settings.SPEEDE3D
        ComboBox1.Text = My.Settings.CHAMBERTEMP
        TextBoxDwell.Text = My.Settings.OPWARMDWELLSEC
        Label6.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.T0 = TextBox1.Text
        My.Settings.T1 = TextBox2.Text
        My.Settings.STARTTOOL = TextBox3.Text
        My.Settings.SPEED1730 = speed1730.Text
        My.Settings.SPEEDE3D = speede3d.Text
        My.Settings.CHAMBERTEMP = ComboBox1.Text
        My.Settings.OPWARMDWELLSEC = TextBoxDwell.Text

        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub speed1730_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles speed1730.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub speede3d_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles speede3d.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxDwell_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDwell.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = 0 Then Label6.Text = "0"
        If ComboBox1.Text = 27 Then Label6.Text = "20"
        If ComboBox1.Text = 33 Then Label6.Text = "35"
        If ComboBox1.Text = 40 Then Label6.Text = "45"
        If ComboBox1.Text = 46 Then Label6.Text = "90"
        If ComboBox1.Text = 53 Then Label6.Text = "120"
        If ComboBox1.Text = 60 Then Label6.Text = "140"
        If ComboBox1.Text = 66 Then Label6.Text = "170"

        If ComboBox1.Text = 72 Then MsgBox("De gekozen temperatuur is zeer hoog! Bij onjuist gebruik kan dit de printer permanent beschadigen! Weet u zeker dat u deze temperatuur wilt gebruiken?")
        If ComboBox1.Text = 72 Then Label6.Text = "210"

        If ComboBox1.Text = 79 Then MsgBox("De gekozen temperatuur is zeer hoog! Bij onjuist gebruik kan dit de printer permanent beschadigen! Weet u zeker dat u deze temperatuur wilt gebruiken?")
        If ComboBox1.Text = 79 Then Label6.Text = "230"

        If ComboBox1.Text = 85 Then MsgBox("De gekozen temperatuur is zeer hoog! Bij onjuist gebruik kan dit de printer permanent beschadigen! Weet u zeker dat u deze temperatuur wilt gebruiken?")
        If ComboBox1.Text = 85 Then Label6.Text = "250"
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class