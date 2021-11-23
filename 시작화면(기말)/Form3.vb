Public Class frmShop
    Private Sum As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnN1_Click(sender As Object, e As EventArgs) Handles btnN1.Click
        Dim coroket As String
        coroket = "코로켓"
        lstbox.Items.Add("[" & coroket & "]")
        Static coroket1 As Integer
        coroket1 = 2000
        Sum = Sum + coroket1
        lblresult.Text = Sum.ToString & "원"
    End Sub

    Private Sub btnN2_Click(sender As Object, e As EventArgs) Handles btnN2.Click
        Dim sosegi As String
        sosegi = "소세지빵"
        lstbox.Items.Add("[" & sosegi & "]")
        Static sosegi1 As Integer
        sosegi1 = 1500
        Sum = Sum + sosegi1
        lblresult.Text = Sum.ToString & "원"
    End Sub

    Private Sub btnN3_Click(sender As Object, e As EventArgs) Handles btnN3.Click
        Dim pizza As String
        pizza = "피자빵"
        lstbox.Items.Add("[" & pizza & "]")
        Static pizza1 As Integer
        pizza1 = 3000
        Sum = Sum + pizza1
        lblresult.Text = Sum.ToString & "원"
    End Sub

    Private Sub btnN4_Click(sender As Object, e As EventArgs) Handles btnN4.Click
        Dim tansan As String
        tansan = "탄산음료"
        lstbox.Items.Add("[" & tansan & "]")
        Static tansan1 As Integer
        tansan1 = 1000
        Sum = Sum + tansan1
        lblresult.Text = Sum.ToString & "원"
    End Sub

    Private Sub btnN5_Click(sender As Object, e As EventArgs) Handles btnN5.Click
        Dim eon As String
        eon = "이온음료"
        lstbox.Items.Add("[" & eon & "]")
        Static eon1 As Integer
        eon1 = 800
        Sum = Sum + eon1
        lblresult.Text = Sum.ToString & "원"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmSchool.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim ans As Integer
        ans = MsgBox("계산하실금액 : " & Sum & "원", vbYes, "계산대")
        If vbYes Then
            lblresult.Text = ""
            lstBox.Items.Clear()
            Sum = 0
        End If
    End Sub

    Private Sub btnJunja_Click(sender As Object, e As EventArgs) Handles btnJunja.Click
        frmJunja.Show()
        Me.Hide()
    End Sub
End Class