Option Explicit On
Imports System.IO
Imports System.Net.Sockets

Public Class mainForm

    ' Initialization of TCP Client
    Dim Client As TcpClient

    ' Initilization of cache directory
    Public passDirectory As String
    Public passName As String
    Public passIp As String
    Public passPort As Integer

    ' Initialization of image slide cache
    Dim images(5) As Bitmap
    Dim pos As Integer = 0

    ' Initialization of score cache
    Dim stand1 As Integer = 0
    Dim stand2 As Integer = 0
    Dim stand3 As Integer = 0
    Dim stand4 As Integer = 0
    Dim stand5 As Integer = 0

    Dim voteConfirm As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialization of vote ready confirmation


        ' Images Initialization
        images(0) = ADETGS4_Voting_Sys.My.Resources.bg_img1
        images(1) = ADETGS4_Voting_Sys.My.Resources.bg_img2
        images(2) = ADETGS4_Voting_Sys.My.Resources.bg_img3
        images(3) = ADETGS4_Voting_Sys.My.Resources.bg_img4
        images(4) = ADETGS4_Voting_Sys.My.Resources.bg_img5

        ' PictureBox Initiliazation
        pictureVote.SizeMode = PictureBoxSizeMode.StretchImage

        ' Form Initialization
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Button Initilization
        voteBtn.Hide()
        prevBtn.Hide()
        nextBtn.Hide()

    End Sub

    Private Sub strtBtn_Click(sender As Object, e As EventArgs) Handles strtBtn.Click

        If passDirectory = "" And passName = "" Then

            MessageBox.Show("Neither output directory or output filename has not been set. Please set it at Settings page!")

        Else

            ' Button Initialization
            strtBtn.Hide()
            voteBtn.Show()
            prevBtn.Show()
            nextBtn.Show()

            voteConfirm = voteConfirm + 1


            ' MessageBox.Show(passDirectory.ToString)

            MessageBox.Show("Kamu akan mem-vote stand favorit kamu! Gunakan tombol kiri dan kanan untuk menentukan pilihanmu! Klik Vote jika sudah!")

            pictureVote.Image = My.Resources.bg_img1

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Initialize setting form
        settingForm.Show()

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click

        pos = pos + 1

        If pos < images.Length - 1 Then

            pictureVote.Image = images(pos)

        Else

            pos = images.Length

        End If

    End Sub

    Private Sub prevBtn_Click(sender As Object, e As EventArgs) Handles prevBtn.Click

        pos = pos - 1

        If pos >= 0 Then

            pictureVote.Image = images(pos)

        Else

            pos = 0

        End If

    End Sub

    Private Sub voteBtn_Click(sender As Object, e As EventArgs) Handles voteBtn.Click

        If pos = 0 Then

            stand1 = stand1 + 1

        ElseIf pos = 1 Then

            stand2 = stand2 + 1

        ElseIf pos = 2 Then

            stand3 = stand3 + 1

        ElseIf pos = 3 Then

            stand4 = stand4 + 1

        ElseIf pos = 4 Then

            stand5 = stand5 + 1

        Else

            MessageBox.Show("Gagal memasukkan vote!")
        End If

        updateReport()

    End Sub

    Private Sub updateReport()

        Dim FILE_NAME As String = passDirectory + "\" + passName + ".txt"

        If System.IO.File.Exists(FILE_NAME) = False Then

            ' Create file if doesn't exist.
            System.IO.File.Create(FILE_NAME).Dispose()

            ' Select file to edit on StreamWriter Lib.
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            ' Process file.
            objWriter.WriteLine("Stand 1 = " + stand1.ToString, vbNewLine)
            objWriter.WriteLine("Stand 2 = " + stand2.ToString, vbNewLine)
            objWriter.WriteLine("Stand 3 = " + stand3.ToString, vbNewLine)
            objWriter.WriteLine("Stand 4 = " + stand4.ToString, vbNewLine)
            objWriter.WriteLine("Stand 5 = " + stand5.ToString, vbNewLine)

            ' Completion.
            objWriter.Close()
            MessageBox.Show("Terimakasih sudeh mem-vote stand ADETGS!")

            If passIp = "" Or passIp = "" Then

                MessageBox.Show("Program will operate as Offline Mode!")

            Else

                ' Initialize IP and Port
                Client = New TcpClient(passIp, passPort)

                ' Send score to MASTER
                Dim Writer As New StreamWriter(Client.GetStream())
                Writer.Write("</>" & " SCORE: " + stand1.ToString + " " + stand2.ToString + " " + stand3.ToString + " " + stand4.ToString + " " + stand5.ToString & "<\>")
                Writer.Flush()

            End If

            nextBtn.Hide()
            prevBtn.Hide()
            voteBtn.Hide()
            strtBtn.Show()

            pictureVote.Image = My.Resources.bg_img_res

        Else

            ' Select file to edit on StreamWriter Lib.
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            ' Process file.
            objWriter.WriteLine("Stand 1 = " + stand1.ToString, vbNewLine)
            objWriter.WriteLine("Stand 2 = " + stand2.ToString, vbNewLine)
            objWriter.WriteLine("Stand 3 = " + stand3.ToString, vbNewLine)
            objWriter.WriteLine("Stand 4 = " + stand4.ToString, vbNewLine)
            objWriter.WriteLine("Stand 5 = " + stand5.ToString, vbNewLine)

            ' Completion.
            objWriter.Close()
            MessageBox.Show("Terimakasih sudeh mem-vote stand ADETGS!")

            If passIp = "" Or passIp = "" Then

                MessageBox.Show("Program will operate as Offline Mode!")

            Else

                ' Initialize IP and Port
                Client = New TcpClient(passIp, passPort)

                ' Send score to MASTER
                Dim Writer As New StreamWriter(Client.GetStream())
                Writer.Write("</>" & " SCORE: " + stand1.ToString + " " + stand2.ToString + " " + stand3.ToString + " " + stand4.ToString + " " + stand5.ToString & "<\>")
                Writer.Flush()

            End If

            nextBtn.Hide()
            prevBtn.Hide()
            voteBtn.Hide()
            strtBtn.Show()

            pictureVote.Image = My.Resources.bg_img_res

        End If
    End Sub

    Private Sub mainForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim bHandled As Boolean = False

        Select Case e.KeyCode

            Case Keys.Right
                MessageBox.Show("Key Right was pressed!")
                e.Handled = True

            Case Keys.Left
                MessageBox.Show("Key Left was pressed!")
                e.Handled = True
        End Select

    End Sub
End Class
