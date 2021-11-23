Public Class frm1layer
    Private Sub btnCheck1_Click(sender As Object, e As EventArgs) Handles btnCheck1.Click
        If txtAns1.Text = "26" Then
            If txtAns2.Text = "-8" Then
                lblResult.Text = "둘다 정답입니다."
            Else
                lblResult.Text = "2번 문제가 틀렸어요."
            End If
        ElseIf txtAns2.Text = "-8" Then

            If txtAns1.Text = "26" Then
                lblResult.Text = "둘다 정답입니다."
            Else
                lblResult.Text = "1번 문제가 틀렸어요."
            End If
        Else
            lblResult.Text = "둘다 틀렸어요."
        End If
    End Sub

    Private Sub btnCancel1_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        txtAns1.Text = ""
        txtAns2.Text = ""
        lblResult.Text = "정답확인"
        btnCheck1.Enabled = False
        txtAns1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSchool.Show()
        Me.Hide()
    End Sub

    Private Sub btnDan_Click(sender As Object, e As EventArgs) Handles btnDan.Click
        Dim Cnt, Dan As Integer
        Dim Result As String

        Cnt = 1
        Dan = CInt(txtDan.Text)

        Do While Cnt <= 9
            Result = Result & Dan & "*" & Cnt & "=" & Dan * Cnt & vbCrLf
            Cnt = Cnt + 1
        Loop
        lblResult2.Text = Result
    End Sub

    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        lblResult2.Text = ""
        txtDan.Text = ""
        btnDan.Enabled = False
        txtDan.Focus()
    End Sub

    Private Sub txtAns1_TextChanged(sender As Object, e As EventArgs) Handles txtAns1.TextChanged
        btnCheck1.Enabled = True
    End Sub

    Private Sub txtAns2_TextChanged(sender As Object, e As EventArgs) Handles txtAns2.TextChanged
        btnCheck1.Enabled = True
    End Sub

    Private Sub txtDan_TextChanged(sender As Object, e As EventArgs) Handles txtDan.TextChanged
        btnDan.Enabled = True
    End Sub

    Private Sub lblResult_TextChanged(sender As Object, e As EventArgs) Handles lblResult.TextChanged

    End Sub
End Class