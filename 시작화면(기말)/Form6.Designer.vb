<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2layer
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAns1 = New System.Windows.Forms.TextBox()
        Me.lblMunje = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.TextBox()
        Me.txtAns4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAns3 = New System.Windows.Forms.TextBox()
        Me.txtAns2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAns = New System.Windows.Forms.Button()
        Me.WebView = New System.Windows.Forms.WebBrowser()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExit.Location = New System.Drawing.Point(525, 340)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 30)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "나가기"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAns1
        '
        Me.txtAns1.Location = New System.Drawing.Point(21, 50)
        Me.txtAns1.Name = "txtAns1"
        Me.txtAns1.Size = New System.Drawing.Size(287, 26)
        Me.txtAns1.TabIndex = 1
        '
        'lblMunje
        '
        Me.lblMunje.AutoSize = True
        Me.lblMunje.Location = New System.Drawing.Point(6, 31)
        Me.lblMunje.Name = "lblMunje"
        Me.lblMunje.Size = New System.Drawing.Size(0, 16)
        Me.lblMunje.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCheck)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.txtAns4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAns3)
        Me.GroupBox1.Controls.Add(Me.txtAns2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAns)
        Me.GroupBox1.Controls.Add(Me.txtAns1)
        Me.GroupBox1.Controls.Add(Me.lblMunje)
        Me.GroupBox1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 344)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "받아쓰기"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClear.Location = New System.Drawing.Point(130, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 30)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "다시하기"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(21, 293)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(70, 30)
        Me.btnCheck.TabIndex = 19
        Me.btnCheck.Text = "확인"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblResult.Location = New System.Drawing.Point(126, 297)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(168, 26)
        Me.lblResult.TabIndex = 18
        Me.lblResult.Text = "점수확인"
        '
        'txtAns4
        '
        Me.txtAns4.Location = New System.Drawing.Point(21, 201)
        Me.txtAns4.Name = "txtAns4"
        Me.txtAns4.Size = New System.Drawing.Size(287, 26)
        Me.txtAns4.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "4. 우리모두 열심히 합시다."
        '
        'txtAns3
        '
        Me.txtAns3.Location = New System.Drawing.Point(21, 146)
        Me.txtAns3.Name = "txtAns3"
        Me.txtAns3.Size = New System.Drawing.Size(287, 26)
        Me.txtAns3.TabIndex = 15
        '
        'txtAns2
        '
        Me.txtAns2.Location = New System.Drawing.Point(21, 98)
        Me.txtAns2.Name = "txtAns2"
        Me.txtAns2.Size = New System.Drawing.Size(287, 26)
        Me.txtAns2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "3. 비주얼베이직은 매우 재밌습니다."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "2. 글씨를 따라 써봅시다."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "1. 안녕하세요 여기는 국어교실 입니다."
        '
        'btnAns
        '
        Me.btnAns.Enabled = False
        Me.btnAns.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAns.Location = New System.Drawing.Point(21, 245)
        Me.btnAns.Name = "btnAns"
        Me.btnAns.Size = New System.Drawing.Size(70, 30)
        Me.btnAns.TabIndex = 10
        Me.btnAns.Text = "제출"
        Me.btnAns.UseVisualStyleBackColor = True
        '
        'WebView
        '
        Me.WebView.Location = New System.Drawing.Point(334, 53)
        Me.WebView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebView.Name = "WebView"
        Me.WebView.Size = New System.Drawing.Size(278, 281)
        Me.WebView.TabIndex = 21
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(334, 26)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(267, 21)
        Me.txtUrl.TabIndex = 22
        Me.txtUrl.Text = "http://dic.naver.com/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("굴림", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "국어사전"
        '
        'frm2layer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 382)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.WebView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frm2layer"
        Me.Text = "국어교실(2층)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents txtAns1 As TextBox
    Friend WithEvents lblMunje As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAns As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAns3 As TextBox
    Friend WithEvents txtAns2 As TextBox
    Friend WithEvents txtAns4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResult As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents WebView As WebBrowser
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents Label5 As Label
End Class
