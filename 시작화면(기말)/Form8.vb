Public Class frmBackGround
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSchool.Show()
        Me.Hide()
    End Sub

    Private Sub btnOnemore_Click(sender As Object, e As EventArgs) Handles btnOnemore.Click
        lblResult.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                lblResult.Text = "1등 - [백동수]" & vbCrLf & "2등 - [임꺽정]" & vbCrLf & "3등 - [일지매]" & vbCrLf & "4등 - [홍길동]"
            Case 1
                lblResult.Text = "1등 - [임꺽정]" & vbCrLf & "2등 - [일지매]" & vbCrLf & "3등 - [백동수]" & vbCrLf & "4등 - [홍길동]"
            Case 2
                lblResult.Text = "1등 - [홍길동]" & vbCrLf & "2등 - [임꺽정]" & vbCrLf & "3등 - [일지매]" & vbCrLf & "4등 - [백동수]"
            Case 3
                MessageBox.Show("너무힘들어요!!", "학생들의외침")
        End Select

    End Sub

    Private Sub frmBackGround_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("50")
        ComboBox1.Items.Add("100")
        ComboBox1.Items.Add("300")
        ComboBox1.Items.Add("500")
    End Sub
End Class