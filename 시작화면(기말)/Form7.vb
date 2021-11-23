Public Class frm3layer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSchool.Show()
        Me.Hide()
    End Sub

    Private Sub txtAns1_TextChanged(sender As Object, e As EventArgs) Handles txtAns1.TextChanged
        If Me.txtAns1.Text = "made" Then
            Me.lblResult.Text = "정답입니다."
        ElseIf Me.txtAns1.Text = "make" Then
            Me.lblResult.Text = "틀렸습니다."
        End If
    End Sub

    Private Sub txtAns2_TextChanged(sender As Object, e As EventArgs) Handles txtAns2.TextChanged
        If Me.txtAns2.Text = "was" Then
            Me.lblResult2.Text = "정답입니다."
        ElseIf Me.txtAns2.Text = "is" Then
            Me.lblResult2.Text = "틀렸습니다."
        End If
    End Sub

    Private Sub txtAns3_TextChanged(sender As Object, e As EventArgs) Handles txtAns3.TextChanged
        If Me.txtAns3.Text = "was" Then
            Me.lblResult3.Text = "정답입니다."
        ElseIf Me.txtAns3.Text = "were" Then
            Me.lblResult3.Text = "틀렸습니다."
        End If
    End Sub

    Private Sub txtAns4_TextChanged(sender As Object, e As EventArgs) Handles txtAns4.TextChanged
        If Me.txtAns4.Text = "saw" Then
            Me.lblResult4.Text = "정답입니다."
        ElseIf Me.txtAns4.Text = "see" Then
            Me.lblResult4.Text = "틀렸습니다."
        End If
    End Sub

    Private Sub btnCancel1_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        txtAns1.Text = ""
        txtAns2.Text = ""
        txtAns3.Text = ""
        txtAns4.Text = ""
        lblResult.Text = "정답확인"
        lblResult2.Text = "정답확인"
        lblResult3.Text = "정답확인"
        lblResult4.Text = "정답확인"
        txtAns1.Focus()
    End Sub

    Private Sub btnChange1_Click(sender As Object, e As EventArgs) Handles btnChange1.Click
        With ColorDialog1
            .FullOpen = True
            .Color = lblChange1.ForeColor
        End With
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            lblChange1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnChange2_Click(sender As Object, e As EventArgs) Handles btnChange2.Click
        With ColorDialog1
            .FullOpen = True
            .Color = lblChange2.ForeColor
        End With
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            lblChange2.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnChange3_Click(sender As Object, e As EventArgs) Handles btnChange3.Click
        With ColorDialog1
            .FullOpen = True
            .Color = lblChange3.ForeColor
        End With
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            lblChange3.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        lblChange1.ForeColor = Color.Black
        lblChange2.ForeColor = Color.Black
        lblChange3.ForeColor = Color.Black
    End Sub

    Private Sub btnInput1_Click(sender As Object, e As EventArgs) Handles btnInput1.Click
        If txtInput1.Text = "노력" Then
            lblOutput1.Text = "정답"
        Else
            lblOutput1.Text = "오답"
        End If
    End Sub

    Private Sub btnInput2_Click(sender As Object, e As EventArgs) Handles btnInput2.Click
        If txtInput2.Text = "호흡기" Then
            lblOutput2.Text = "정답"
        Else
            lblOutput2.Text = "오답"
        End If
    End Sub

    Private Sub btnInput3_Click(sender As Object, e As EventArgs) Handles btnInput3.Click
        If txtInput3.Text = "보상하다" Then
            lblOutput3.Text = "정답"
        Else
            lblOutput3.Text = "오답"
        End If
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        txtInput1.Text = "노력"
        txtInput2.Text = "호흡기"
        txtInput3.Text = "보상하다"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtInput1.Text = ""
        txtInput2.Text = ""
        txtInput3.Text = ""
        lblOutput1.Text = ""
        lblOutput2.Text = ""
        lblOutput3.Text = ""
    End Sub
End Class