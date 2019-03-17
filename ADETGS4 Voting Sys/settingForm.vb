Public Class settingForm

    ' Initialize directory & file name
    Public directoryFile As String
    Public nameFile As String
    Public ipAddress As String
    Public portAdress As Integer

    ' Initialize directory template
    Dim FILE As String = directoryFile + nameFile + ".txt"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles clrBtn.Click

        ' Clear the TextBox and varString
        dirBox.Text = ""
        directoryFile = ""

    End Sub

    Private Sub updtBtn_Click(sender As Object, e As EventArgs) Handles updtBtn.Click

        ' Parsing variable to mainForm
        directoryFile = dirBox.Text
        mainForm.passDirectory = dirBox.Text

        ' Confirmation dialog
        ' MessageBox.Show(directoryFile)
        ''MessageBox.Show("Directory has been set!")

    End Sub

    Private Sub rclrBtn_Click(sender As Object, e As EventArgs) Handles rclrBtn.Click

        repoBox.Text = ""
        nameFile = ""

    End Sub

    Private Sub rupdtBtn_Click(sender As Object, e As EventArgs) Handles rupdtBtn.Click

        nameFile = repoBox.Text
        mainForm.passName = repoBox.Text

        ' Confirmation dialog
        ' MessageBox.Show(nameFile)
        ' MessageBox.Show("File name has been set!")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles extAppBtn.Click

        Application.Exit()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles opnBtn.Click

        Dim FILE As String = directoryFile + nameFile + ".txt"

        ' MessageBox.Show(FILE)

        If System.IO.File.Exists(FILE) = True Then

            Process.Start(FILE)

        Else

            System.IO.File.Create(FILE).Dispose()
            Process.Start(FILE)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles rrClrBtn.Click

        If System.IO.File.Exists(FILE) = False Then

            ' Create file if doesn't exist.
            System.IO.File.Create(FILE).Dispose()

            ' Select file to edit on StreamWriter Lib.
            Dim objWriter As New System.IO.StreamWriter(FILE)

            ' Process file.
            objWriter.Write("")

            ' Completion.
            objWriter.Close()
            MessageBox.Show("Report has been cleared!")

        Else

            ' Select file to edit on StreamWriter Lib.
            Dim objWriter As New System.IO.StreamWriter(FILE)

            ' Process file.
            objWriter.Write("")

            ' Completion.
            objWriter.Close()
            MessageBox.Show("Report has been cleared!")

        End If

    End Sub

    Private Sub extBtn_Click(sender As Object, e As EventArgs) Handles extBtn.Click

        Me.Hide()

    End Sub

    Private Sub ipBtn_Click(sender As Object, e As EventArgs) Handles ipBtn.Click

        portAdress = portBox.Text
        ipAddress = ipBox.Text

        If portAdress.ToString.Contains("0") And ipAddress.Contains(".") Then

            mainForm.passPort = portAdress
            mainForm.passIp = ipBox.Text

        Else

            MessageBox.Show("Gagal memasukkan config TCP!")

        End If

    End Sub

    Private Sub settingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' TextBox Initialization
        ipBox.Text = "tidak usah diisi jika menggunakan mode client."

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles brwsBtn.Click

        Dim folderDlg As New FolderBrowserDialog

        folderDlg.ShowNewFolderButton = True

        If (folderDlg.ShowDialog() = DialogResult.OK) Then

            dirBox.Text = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder

        End If

    End Sub
End Class