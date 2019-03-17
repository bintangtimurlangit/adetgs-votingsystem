Public NotInheritable Class splashScreen

    Dim act As Integer = 0

    Private Sub timerSplash_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick

        act = act + 25

        If act = 2500 Then

            timerSplash.Stop()
            Me.Hide()
            mainForm.Show()

        End If

    End Sub
End Class
