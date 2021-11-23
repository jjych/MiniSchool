<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJunja
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
        Me.comList = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.trcBar = New System.Windows.Forms.TrackBar()
        Me.pgBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.trcBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comList
        '
        Me.comList.FormattingEnabled = True
        Me.comList.Location = New System.Drawing.Point(49, 76)
        Me.comList.Name = "comList"
        Me.comList.Size = New System.Drawing.Size(121, 20)
        Me.comList.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comList)
        Me.GroupBox1.Controls.Add(Me.pgBar)
        Me.GroupBox1.Location = New System.Drawing.Point(101, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 171)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "전자레인지"
        '
        'btnFire
        '
        Me.btnFire.Location = New System.Drawing.Point(62, 262)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(101, 45)
        Me.btnFire.TabIndex = 2
        Me.btnFire.Text = "데우기"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(255, 262)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 45)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "뒤로가기"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'trcBar
        '
        Me.trcBar.Location = New System.Drawing.Point(107, 211)
        Me.trcBar.Name = "trcBar"
        Me.trcBar.Size = New System.Drawing.Size(206, 45)
        Me.trcBar.TabIndex = 5
        '
        'pgBar
        '
        Me.pgBar.Location = New System.Drawing.Point(6, 129)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(206, 23)
        Me.pgBar.TabIndex = 4
        '
        'frmJunja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 319)
        Me.Controls.Add(Me.trcBar)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmJunja"
        Me.Text = "전자레인지"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.trcBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comList As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFire As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pgBar As ProgressBar
    Friend WithEvents trcBar As TrackBar
End Class
