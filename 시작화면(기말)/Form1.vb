Public Class frmStart
    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        frmSchool.Show()
        Me.Hide()
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Dim ans As Integer
        ans = MsgBox("종료하시겠습니까?", vbYesNo + vbQuestion, "나가기")
        If ans = vbYes Then
            End
        End If
    End Sub
End Class
