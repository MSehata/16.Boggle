Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnReshuffle_Click(sender As Object, e As EventArgs) Handles btnReshuffle.Click
        Dim i, n As Integer

        For i = 1 To 25
            n = Int(26 * Rnd()) + 65

            Dim FoundControls As Control() = Me.Controls.Find("Label" & i, True) 'Find the label with the name "Label#" - where # is the current Index
            If FoundControls.Count > 0 Then
                FoundControls(0).Text = Chr(n) 'Change its text
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub
End Class
