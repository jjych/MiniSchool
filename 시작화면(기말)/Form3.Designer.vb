<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShop
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnN3 = New System.Windows.Forms.Button()
        Me.btnN2 = New System.Windows.Forms.Button()
        Me.btnN1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnN4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnN5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnJunja = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(547, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 31)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "나가기"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(591, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "계산"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(465, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 12)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "계산하실금액"
        '
        'lblresult
        '
        Me.lblresult.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblresult.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblresult.Location = New System.Drawing.Point(437, 311)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(132, 40)
        Me.lblresult.TabIndex = 21
        '
        'btnN3
        '
        Me.btnN3.Location = New System.Drawing.Point(321, 54)
        Me.btnN3.Name = "btnN3"
        Me.btnN3.Size = New System.Drawing.Size(69, 60)
        Me.btnN3.TabIndex = 20
        Me.btnN3.Text = "피자빵"
        Me.btnN3.UseVisualStyleBackColor = True
        '
        'btnN2
        '
        Me.btnN2.Location = New System.Drawing.Point(203, 54)
        Me.btnN2.Name = "btnN2"
        Me.btnN2.Size = New System.Drawing.Size(69, 60)
        Me.btnN2.TabIndex = 19
        Me.btnN2.Text = "소세지빵"
        Me.btnN2.UseVisualStyleBackColor = True
        '
        'btnN1
        '
        Me.btnN1.Location = New System.Drawing.Point(79, 54)
        Me.btnN1.Name = "btnN1"
        Me.btnN1.Size = New System.Drawing.Size(75, 60)
        Me.btnN1.TabIndex = 18
        Me.btnN1.Text = "코로켓"
        Me.btnN1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "3000원"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "1500원"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "2000원"
        '
        'btnN4
        '
        Me.btnN4.Location = New System.Drawing.Point(439, 54)
        Me.btnN4.Name = "btnN4"
        Me.btnN4.Size = New System.Drawing.Size(69, 60)
        Me.btnN4.TabIndex = 27
        Me.btnN4.Text = "탄산음료"
        Me.btnN4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(454, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "1000원"
        '
        'btnN5
        '
        Me.btnN5.Location = New System.Drawing.Point(547, 54)
        Me.btnN5.Name = "btnN5"
        Me.btnN5.Size = New System.Drawing.Size(69, 60)
        Me.btnN5.TabIndex = 29
        Me.btnN5.Text = "이온음료"
        Me.btnN5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(565, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "800원"
        '
        'btnJunja
        '
        Me.btnJunja.Location = New System.Drawing.Point(421, 165)
        Me.btnJunja.Name = "btnJunja"
        Me.btnJunja.Size = New System.Drawing.Size(148, 74)
        Me.btnJunja.TabIndex = 30
        Me.btnJunja.Text = "전자레인지"
        Me.btnJunja.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 12
        Me.lstBox.Location = New System.Drawing.Point(79, 151)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(193, 280)
        Me.lstBox.TabIndex = 31
        '
        'frmShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 470)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.btnJunja)
        Me.Controls.Add(Me.btnN5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnN4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnN3)
        Me.Controls.Add(Me.btnN2)
        Me.Controls.Add(Me.btnN1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmShop"
        Me.Text = "매점"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblresult As Label
    Friend WithEvents btnN3 As Button
    Friend WithEvents btnN2 As Button
    Friend WithEvents btnN1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnN4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnN5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnJunja As Button
    Friend WithEvents lstBox As ListBox
End Class
