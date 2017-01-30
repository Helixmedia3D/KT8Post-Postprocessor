Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If gcodepathtextbox.Text = "" Then
            MsgBox("Selecteer eerst een bestand!")
        Else

            Dim myStreamReaderL1 As System.IO.StreamReader
            Dim myStr As String
            myStreamReaderL1 = System.IO.File.OpenText(gcodepathtextbox.Text)
            myStr = myStreamReaderL1.ReadToEnd() 'yolo
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

            ProgressBar1.Increment(58)
            Dim sfd As New SaveFileDialog() 
            sfd.Filter = "Gcode files (*.gcode)|*.gcode|All files (*.*)|*.*"
            sfd.FileName = GetFileNamezondergcode(gcodepathtextbox.Text) & " POST-POSTED"
            sfd.FilterIndex = 1
            sfd.RestoreDirectory = True
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim FileName As String = sfd.FileName 
                Dim sw As New System.IO.StreamWriter(FileName, False) 
                sw.WriteLine(myStr) 
                sw.Close() 
            End If
            ProgressBar1.Increment(100)
            Button1.Text = "KLAAR!"
            Button1.Enabled = False
            MsgBox("Klaar! Zet het nieuwe bestand nu op de SD-kaart van de KT8 DUAL+")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        instellingen.Show()
        instellingen.Hide()
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
        MsgBox("Kunststoftechniek KT8 - 2017" & vbCrLf & "Gemaakt voor de KT8 DUAL+ om de kosten voor Simplify3D te drukken.
")
    End Sub

    Private Sub InstellingenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstellingenToolStripMenuItem.Click
        instellingen.Show()
    End Sub
End Class
