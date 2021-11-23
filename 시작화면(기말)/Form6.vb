Public Class frm2layer
    Private Structure badas
        Dim strFirst As String
        Dim strSecond As String
        Dim strThird As String
        Dim strForth As String
    End Structure
    Private std(4) As badas

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSchool.Show()
        Me.Hide()
    End Sub

    Private Sub btnAns_Click(sender As Object, e As EventArgs) Handles btnAns.Click
        Static intI As Integer
        std(intI).strFirst = txtAns1.Text
        std(intI).strSecond = txtAns2.Text
        std(intI).strThird = txtAns3.Text
        std(intI).strForth = txtAns4.Text
        intI = intI + 1
        txtAns1.Text = ""
        txtAns2.Text = ""
        txtAns3.Text = ""
        txtAns4.Text = ""
        btnAns.Enabled = False
        txtAns1.Focus()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Static Cnt As Integer
        Static intI As Integer
        Cnt = 0
        If std(intI).strFirst = "안녕하세요 여기는 국어교실 입니다." Then
            Cnt = Cnt + 25
            If std(intI).strSecond = "글씨를 따라 써봅시다." Then
                Cnt = Cnt + 25
                If std(intI).strThird = "비주얼베이직은 매우 재밌습니다." Then
                    Cnt = Cnt + 25
                    If std(intI).strForth = "우리모두 열심히 합시다." Then
                        Cnt = Cnt + 25
                    End If
                End If
            End If
        ElseIf std(intI).strSecond = "글씨를 따라 써봅시다." Then
            Cnt = Cnt + 25
            If std(intI).strThird = "비주얼베이직은 매우 재밌습니다." Then
                Cnt = Cnt + 25
                If std(intI).strForth = "우리모두 열심히 합시다." Then
                    Cnt = Cnt + 25
                End If
            End If
        ElseIf std(intI).strThird = "비주얼베이직은 매우 재밌습니다." Then
            Cnt = Cnt + 25
            If std(intI).strForth = "우리모두 열심히 합시다." Then
                Cnt = Cnt + 25
            End If
        ElseIf std(intI).strForth = "우리모두 열심히 합시다." Then
            Cnt = Cnt + 25
        End If
        lblResult.Text = Cnt & "점"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Static intI As Integer
        std(intI).strFirst = ""
        std(intI).strSecond = ""
        std(intI).strThird = ""
        std(intI).strForth = ""
        lblResult.Text = "점수확인"
    End Sub

    Private Sub txtAns1_TextChanged(sender As Object, e As EventArgs) Handles txtAns1.TextChanged
        btnAns.Enabled = True
    End Sub

    Private Sub txtAns4_TextChanged(sender As Object, e As EventArgs) Handles txtAns4.TextChanged
        btnAns.Enabled = True
    End Sub

    Private Sub txtAns2_TextChanged(sender As Object, e As EventArgs) Handles txtAns2.TextChanged
        btnAns.Enabled = True
    End Sub

    Private Sub txtAns3_TextChanged(sender As Object, e As EventArgs) Handles txtAns3.TextChanged
        btnAns.Enabled = True
    End Sub

    Private Sub txtUrl_TextChanged(sender As Object, e As EventArgs) Handles txtUrl.TextChanged

    End Sub

    Private Sub txtUrl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUrl.KeyPress
        If Me.txtUrl.Text <> "" And e.KeyChar = Chr(13) Then
            Me.WebView.Navigate(Me.txtUrl.Text)
        End If
    End Sub
End Class