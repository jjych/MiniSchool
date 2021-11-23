<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1layer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAns1 = New System.Windows.Forms.TextBox()
        Me.txtAns2 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.TextBox()
        Me.btnCancel1 = New System.Windows.Forms.Button()
        Me.btnCheck1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDan = New System.Windows.Forms.TextBox()
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.btnDan = New System.Windows.Forms.Button()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAns1)
        Me.GroupBox1.Controls.Add(Me.txtAns2)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.btnCancel1)
        Me.GroupBox1.Controls.Add(Me.btnCheck1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 252)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "사칙연산"
        '
        'txtAns1
        '
        Me.txtAns1.Location = New System.Drawing.Point(137, 48)
        Me.txtAns1.MaxLength = 10
        Me.txtAns1.Name = "txtAns1"
        Me.txtAns1.Size = New System.Drawing.Size(123, 26)
        Me.txtAns1.TabIndex = 5
        '
        'txtAns2
        '
        Me.txtAns2.Location = New System.Drawing.Point(137, 85)
        Me.txtAns2.Name = "txtAns2"
        Me.txtAns2.Size = New System.Drawing.Size(123, 26)
        Me.txtAns2.TabIndex = 6
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblResult.Location = New System.Drawing.Point(59, 207)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(168, 26)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "정답확인"
        '
        'btnCancel1
        '
        Me.btnCancel1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCancel1.Location = New System.Drawing.Point(172, 159)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(79, 31)
        Me.btnCancel1.TabIndex = 3
        Me.btnCancel1.Text = "다시풀기"
        Me.btnCancel1.UseVisualStyleBackColor = True
        '
        'btnCheck1
        '
        Me.btnCheck1.Enabled = False
        Me.btnCheck1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCheck1.Location = New System.Drawing.Point(40, 159)
        Me.btnCheck1.Name = "btnCheck1"
        Me.btnCheck1.Size = New System.Drawing.Size(79, 31)
        Me.btnCheck1.TabIndex = 2
        Me.btnCheck1.Text = "제출"
        Me.btnCheck1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2. 80/5-4*6 ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. 8+9*4/2  ="
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExit.Location = New System.Drawing.Point(530, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "나가기"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDan)
        Me.GroupBox2.Controls.Add(Me.btnCancel2)
        Me.GroupBox2.Controls.Add(Me.btnDan)
        Me.GroupBox2.Controls.Add(Me.lblResult2)
        Me.GroupBox2.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(329, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 295)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "구구단을외우자"
        '
        'txtDan
        '
        Me.txtDan.Location = New System.Drawing.Point(52, 207)
        Me.txtDan.Name = "txtDan"
        Me.txtDan.Size = New System.Drawing.Size(75, 26)
        Me.txtDan.TabIndex = 5
        '
        'btnCancel2
        '
        Me.btnCancel2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCancel2.Location = New System.Drawing.Point(153, 250)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel2.TabIndex = 8
        Me.btnCancel2.Text = "지우기"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'btnDan
        '
        Me.btnDan.Enabled = False
        Me.btnDan.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDan.Location = New System.Drawing.Point(153, 207)
        Me.btnDan.Name = "btnDan"
        Me.btnDan.Size = New System.Drawing.Size(75, 26)
        Me.btnDan.TabIndex = 7
        Me.btnDan.Text = "단 보기"
        Me.btnDan.UseVisualStyleBackColor = True
        '
        'lblResult2
        '
        Me.lblResult2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult2.Location = New System.Drawing.Point(52, 22)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(176, 168)
        Me.lblResult2.TabIndex = 6
        '
        'frm1layer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 382)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm1layer"
        Me.Text = "수학교실(1층)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAns1 As TextBox
    Friend WithEvents txtAns2 As TextBox
    Friend WithEvents lblResult As TextBox
    Friend WithEvents btnCancel1 As Button
    Friend WithEvents btnCheck1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDan As TextBox
    Friend WithEvents btnCancel2 As Button
    Friend WithEvents btnDan As Button
    Friend WithEvents lblResult2 As Label
End Class
