Public Class frmJunja

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        If pgBar.Value >= 100 Then
            Select Case comList.SelectedIndex
                Case 0
                    Dim strName As String
                    strName = "전자레인지"
                    MessageBox.Show("코로켓이 다 데워졌습니다.", strName)
                    pgBar.Value = 0
                    trcBar.Value = 0
                Case 1
                    Dim strName As String
                    strName = "전자레인지"
                    MessageBox.Show("소세지빵이 다 데워졌습니다.", strName)
                    pgBar.Value = 0
                    trcBar.Value = 0
                Case 2
                    Dim strName As String
                    strName = "전자레인지"
                    MessageBox.Show("피자빵이 다 데워졌습니다.", strName)
                    pgBar.Value = 0
                    trcBar.Value = 0
            End Select
        Else
            Select Case comList.SelectedIndex
                Case 0
                    Dim strName As String
                    strName = "전자레인지"
                    MessageBox.Show("코로켓이 다 데워지지않았습니다.", strName)
                Case 1
                    Dim strName As String
                    strName = "전자레인지"
                    MessageBox.Show("소세지빵이 다 데워지지않았습니다.", strName)
                Case 2
                    Dim strName As String
                    strName = "전자레인지"
                    MessageBox.Show("피자빵이 다 데워지지않았습니다.", strName)
            End Select
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmShop.Show()
        Me.Hide()
    End Sub

    Private Sub comList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comList.SelectedIndexChanged

    End Sub

    Private Sub frmJunja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comList.Items.Add("코로켓")
        comList.Items.Add("소세지빵")
        comList.Items.Add("피자빵")
    End Sub

    Private Sub trcBar_Scroll(sender As Object, e As EventArgs) Handles trcBar.Scroll
        pgBar.Value = trcBar.Value * 10
    End Sub
End Class