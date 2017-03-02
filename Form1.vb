Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuStrip1.BringToFront()

        'If HaveInternetConnection() = False Then
        'If MsgBox("Er kan geen verbinding met het internet worden gemaakt, of uw firewall/virusscanner blokkeert deze applicatie. De applicatie zal nu sluiten." & vbCrLf, vbOKOnly) = vbOK Then
        'Application.Exit()
        'End If
        'End If

        instellingen.Show()
        instellingen.Hide()

        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")
        If My.Computer.FileSystem.FileExists(filePath) Then
            My.Computer.FileSystem.DeleteFile(filePath) 'verwijderen die shit
        End If

        'If My.Settings.isFirstRun = True Then
        'MsgBox("Deze applicatie stuurt anonieme gebruikersinformatie naar de ontwikkelaar om het programma te verbeteren." & vbCrLf & "Door te klikken op OK gaat u hiermee akkoord.", MsgBoxStyle.SystemModal And MsgBoxStyle.MsgBoxSetForeground)
        'My.Settings.isFirstRun = False
        'My.Settings.Save()
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Gcode files (*.gcode)|*.gcode|All files (*.*)|*.*"
        dialog.FilterIndex = 1
        dialog.RestoreDirectory = True
        If DialogResult.OK = dialog.ShowDialog Then
            gcodepathtextbox.Text = dialog.FileName
        End If

        'bestandsgrote gcode en naam neergooien
        If gcodepathtextbox.Text = "" Then
            'nope
        Else
            Dim infoReader As System.IO.FileInfo
            infoReader = My.Computer.FileSystem.GetFileInfo(gcodepathtextbox.Text)
            filesizelabel.Text = GetFileName(gcodepathtextbox.Text) & " | " & infoReader.Length & " bytes."
        End If
    End Sub

    Public Function Getzondershiz(ByVal filepath As String) As String

        Dim slashindex As Integer = filepath.LastIndexOf(";")
        Dim dotindex As Integer = filepath.LastIndexOf("")

        Getzondershiz = filepath.Substring(slashindex + 1, dotindex - slashindex)
    End Function

    'filenaam met 'gcode'
    Public Function GetFileName(ByVal filepath As String) As String

        Dim slashindex As Integer = filepath.LastIndexOf("\")
        Dim dotindex As Integer = filepath.LastIndexOf("")

        GetFileName = filepath.Substring(slashindex + 1, dotindex - slashindex)
    End Function

    'filenaam zonder 'gcode'
    Public Function GetFileNamezondergcode(ByVal filepath As String) As String

        Dim slashindex As Integer = filepath.LastIndexOf("\")
        Dim dotindex As Integer = filepath.LastIndexOf(".")

        GetFileNamezondergcode = filepath.Substring(slashindex + 1, dotindex - slashindex - 1)
    End Function

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        overversie.Text = "v" & Label10.Text
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub InstellingenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstellingenToolStripMenuItem.Click
        instellingen.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)
        If gcodepathtextbox.Text = "" Then
            MsgBox("Selecteer eerst een bestand!")
        Else

            Using reader As New IO.StreamReader(gcodepathtextbox.Text)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()

                    If line.Contains("Gesliced") Then
                        datumgesliced.Text = line
                    End If
                    If line.Contains("Laaghoogte") Then
                        laaghoogte.Text = line
                    End If
                    If line.Contains("Walls") Then
                        walls.Text = line
                    End If
                    If line.Contains("Fill") Then
                        fill.Text = line
                    End If
                    If line.Contains("Printtijd") Then
                        printtijd.Text = line
                    End If
                    If line.Contains("meter") Then
                        meter.Text = line
                    End If
                    If line.Contains("gram") Then
                        gram.Text = line
                    End If
                End While
            End Using

            datumgesliced.Text = Replace(datumgesliced.Text, ";", "")
            laaghoogte.Text = Replace(laaghoogte.Text, ";", "")
            walls.Text = Replace(walls.Text, ";", "")
            fill.Text = Replace(fill.Text, ";", "")
            printtijd.Text = Replace(printtijd.Text, ";", "")
            meter.Text = Replace(meter.Text, ";", "")
            gram.Text = Replace(gram.Text, ";", "")

            TabControl1.SelectedTab = TabPage2

        End If

        'kijken voor updates
        If WebBrowser1.Document IsNot Nothing Then
            Dim element = WebBrowser1.Document.GetElementById("versie")
            If element IsNot Nothing Then
                versielabel.Text = (element.InnerHtml)
            End If
        Else
            versielabel.Text = "0"
        End If

        If versielabel.Text > Label10.Text Then
            Select Case MsgBox("Er is een nieuwe, verbeterde versie van dit programma beschikbaar. Wilt u nu updaten?", MsgBoxStyle.YesNo, "Er is een update beschikbaar!")
                Case MsgBoxResult.Yes
                    System.Diagnostics.Process.Start("https://github.com/Helixmedia3D/KT8Post-Postprocessor/tree/master/Precompiled")
                    Application.Exit()
                Case MsgBoxResult.No
                    'MessageBox.Show("...")
            End Select
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        instellingen.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If gcodepathtextbox.Text = "" Then
            MsgBox("Selecteer eerst een bestand!")
        Else
            TabControl1.SelectedTab = TabPage4

            Dim myStreamReaderL1 As System.IO.StreamReader
            ' Dim myStream As System.IO.StreamWriter
            Dim myStr As String
            myStreamReaderL1 = System.IO.File.OpenText(gcodepathtextbox.Text)

            myStr = myStreamReaderL1.ReadToEnd()
            myStreamReaderL1.Close()


            myStr = myStr.Replace("T1
;afterTn",
    instellingen.TextBox2.Text)


            myStr = myStr.Replace("T0
;afterTn",
    instellingen.TextBox1.Text)

            myStr = myStr.Replace(";SPEED1730", "M42 P59 S" & (instellingen.speed1730.Text * 2.55))
            myStr = myStr.Replace(";SPEEDE3D", "M42 P64 S" & (instellingen.speede3d.Text * 2.55))

            myStr = myStr.Replace(";CHAMBERTEMP", "M42 P5 S" & (instellingen.Label6.Text))

            If instellingen.Label6.Text = 0 Then
                myStr = myStr.Replace(";OPWARMDWELL", "G4 P10")
            Else
                myStr = myStr.Replace(";OPWARMDWELL", "G4 S" & instellingen.TextBoxDwell.Text)
            End If

            myStr = myStr.Replace(";STARTTOOL", instellingen.TextBox1.Text)


            Dim filePath As String
            filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")
            Dim sw As New System.IO.StreamWriter(filePath, True)
            sw.WriteLine(myStr)
            sw.Close()

            Timer1.Enabled = True
            Timer1.Interval = 3000

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'annuleren knop lame shit'
        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")
        If My.Computer.FileSystem.FileExists(filePath) Then
            My.Computer.FileSystem.DeleteFile(filePath) 'verwijderen die shit
        End If

        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False
        TabControl1.SelectedTab = TabPage3

        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")

        Dim myStreamReaderL1 As System.IO.StreamReader
        myStreamReaderL1 = System.IO.File.OpenText(filePath)
        TextBoxS1.Text = myStreamReaderL1.ReadToEnd()

        myStreamReaderL1.Close()

        Using reader As New IO.StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()

                If line.Contains("Printtijd") Then
                    printtijd2.Text = line
                End If
                If line.Contains("meter") Then
                    meter2.Text = line
                End If
                If line.Contains("gram") Then
                    gram2.Text = line
                End If
                If line.Contains("M109 T0") Then
                    t0.Text = line
                End If
                If line.Contains("M109 T1") Then
                    t1.Text = line
                End If
                If line.Contains("M140 S") Then
                    bed.Text = line
                End If
            End While
        End Using

        printtijd2.Text = Replace(printtijd2.Text, ";", "")
        meter2.Text = Replace(meter2.Text, ";", "")
        gram2.Text = Replace(gram2.Text, ";", "")

        t0.Text = Replace(t0.Text, "M109 T0 S", "Temperatuur T0: ")
        t0.Text = Replace(t0.Text, ".00000", ".")
        t1.Text = Replace(t1.Text, "M109 T1 S", "Temperatuur T1: ")
        t1.Text = Replace(t1.Text, ".00000", ".")
        bed.Text = Replace(bed.Text, "M140 S", "Temperatuur bed: ")
        bed.Text = Replace(bed.Text, ".00000", ".")
        chamber.Text = "Temperatuur kamer: " & instellingen.ComboBox1.Text & ".0"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")


        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Gcode files (*.gcode)|*.gcode|All files (*.*)|*.*"
        sfd.FileName = GetFileNamezondergcode(gcodepathtextbox.Text) & " POST-POSTED"
        sfd.FilterIndex = 1
        sfd.RestoreDirectory = True
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim FileName As String = sfd.FileName
            Dim sw As New System.IO.StreamWriter(FileName, False)
            sw.WriteLine(TextBoxS1.Text)
            sw.Close()
        End If

        If My.Computer.FileSystem.FileExists(filePath) Then
            My.Computer.FileSystem.DeleteFile(filePath) 'verwijderen die shit
        End If

        MsgBox("Klaar! Zet (indien nog niet gedaan) het nieuwe bestand nu op de SD-kaart van de KT8 DUAL+")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'herstart
        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")
        If My.Computer.FileSystem.FileExists(filePath) Then
            My.Computer.FileSystem.DeleteFile(filePath) 'verwijderen die shit
        End If

        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        handleiding.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'annuleren knop lame shit'
        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "KT8tijdelijk.txt")
        If My.Computer.FileSystem.FileExists(filePath) Then
            My.Computer.FileSystem.DeleteFile(filePath) 'verwijderen die shit
        End If

        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Button1.PerformClick()
    End Sub

    Public Function HaveInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try
    End Function

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/Helixmedia3D/KT8Post-Postprocessor")
    End Sub

    Private Sub BestandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestandToolStripMenuItem.Click

        WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)

        If WebBrowser1.Document IsNot Nothing Then
            Dim element = WebBrowser1.Document.GetElementById("versie")
            If element IsNot Nothing Then
                versielabel.Text = (element.InnerHtml)
            End If
        Else
            versielabel.Text = "0"
        End If

        TabControl1.SelectedTab = TabPage5
        If versielabel.Text = "0" Then Label11.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub HandleidingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HandleidingToolStripMenuItem.Click
        handleiding.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

End Class
