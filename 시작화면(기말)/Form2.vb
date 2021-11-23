Public Class frmSchool
    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Dim ans As Integer
        ans = MsgBox("하교할까?", vbYesNo + vbQuestion, "교문")
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        frmShop.Show()
        Me.Hide()
    End Sub

    Private Sub btn1layer_Click(sender As Object, e As EventArgs) Handles btn1layer.Click
        frm1layer.Show()
        Me.Hide()
    End Sub

    Private Sub btn2layer_Click(sender As Object, e As EventArgs) Handles btn2layer.Click
        frm2layer.Show()
        Me.Hide()
    End Sub

    Private Sub btn3layer_Click(sender As Object, e As EventArgs) Handles btn3layer.Click
        frm3layer.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlayGround_Click(sender As Object, e As EventArgs) Handles btnPlayGround.Click
        frmBackGround.Show()
        Me.Hide()
    End Sub
End Class