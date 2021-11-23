<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchool
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
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btn3layer = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.btn2layer = New System.Windows.Forms.Button()
        Me.btnPlayGround = New System.Windows.Forms.Button()
        Me.btn1layer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOut
        '
        Me.btnOut.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnOut.Location = New System.Drawing.Point(544, 219)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(84, 45)
        Me.btnOut.TabIndex = 0
        Me.btnOut.Text = "교문"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'btn3layer
        '
        Me.btn3layer.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn3layer.Location = New System.Drawing.Point(70, 29)
        Me.btn3layer.Name = "btn3layer"
        Me.btn3layer.Size = New System.Drawing.Size(85, 49)
        Me.btn3layer.TabIndex = 1
        Me.btn3layer.Text = "3층"
        Me.btn3layer.UseVisualStyleBackColor = True
        '
        'btnShop
        '
        Me.btnShop.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnShop.Location = New System.Drawing.Point(393, 42)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(85, 49)
        Me.btnShop.TabIndex = 2
        Me.btnShop.Text = "매점"
        Me.btnShop.UseVisualStyleBackColor = True
        '
        'btn2layer
        '
        Me.btn2layer.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn2layer.Location = New System.Drawing.Point(70, 124)
        Me.btn2layer.Name = "btn2layer"
        Me.btn2layer.Size = New System.Drawing.Size(85, 49)
        Me.btn2layer.TabIndex = 4
        Me.btn2layer.Text = "2층"
        Me.btn2layer.UseVisualStyleBackColor = True
        '
        'btnPlayGround
        '
        Me.btnPlayGround.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnPlayGround.Location = New System.Drawing.Point(221, 146)
        Me.btnPlayGround.Name = "btnPlayGround"
        Me.btnPlayGround.Size = New System.Drawing.Size(257, 122)
        Me.btnPlayGround.TabIndex = 5
        Me.btnPlayGround.Text = "운동장"
        Me.btnPlayGround.UseVisualStyleBackColor = True
        '
        'btn1layer
        '
        Me.btn1layer.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn1layer.Location = New System.Drawing.Point(70, 219)
        Me.btn1layer.Name = "btn1layer"
        Me.btn1layer.Size = New System.Drawing.Size(85, 49)
        Me.btn1layer.TabIndex = 6
        Me.btn1layer.Text = "1층"
        Me.btn1layer.UseVisualStyleBackColor = True
        '
        'frmSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 302)
        Me.Controls.Add(Me.btn1layer)
        Me.Controls.Add(Me.btnPlayGround)
        Me.Controls.Add(Me.btn2layer)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.btn3layer)
        Me.Controls.Add(Me.btnOut)
        Me.Name = "frmSchool"
        Me.Text = "학교"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOut As Button
    Friend WithEvents btn3layer As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents btn2layer As Button
    Friend WithEvents btnPlayGround As Button
    Friend WithEvents btn1layer As Button
End Class
