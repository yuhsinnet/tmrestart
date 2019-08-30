<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PC1_Rest_Button = New System.Windows.Forms.Button()
        Me.PC2_Rest_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PC1_IP = New System.Windows.Forms.TextBox()
        Me.PC1_PORT = New System.Windows.Forms.TextBox()
        Me.PC2_IP = New System.Windows.Forms.TextBox()
        Me.PC2_PORT = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PC1_Rest_Button
        '
        Me.PC1_Rest_Button.AutoSize = True
        Me.PC1_Rest_Button.Font = New System.Drawing.Font("新細明體", 36.0!)
        Me.PC1_Rest_Button.Location = New System.Drawing.Point(106, 88)
        Me.PC1_Rest_Button.Name = "PC1_Rest_Button"
        Me.PC1_Rest_Button.Size = New System.Drawing.Size(178, 58)
        Me.PC1_Rest_Button.TabIndex = 0
        Me.PC1_Rest_Button.Text = "主機一"
        Me.PC1_Rest_Button.UseVisualStyleBackColor = True
        '
        'PC2_Rest_Button
        '
        Me.PC2_Rest_Button.AutoSize = True
        Me.PC2_Rest_Button.Font = New System.Drawing.Font("新細明體", 36.0!)
        Me.PC2_Rest_Button.Location = New System.Drawing.Point(106, 152)
        Me.PC2_Rest_Button.Name = "PC2_Rest_Button"
        Me.PC2_Rest_Button.Size = New System.Drawing.Size(178, 58)
        Me.PC2_Rest_Button.TabIndex = 1
        Me.PC2_Rest_Button.Text = "主機二"
        Me.PC2_Rest_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(114, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "天明重開器"
        '
        'PC1_IP
        '
        Me.PC1_IP.Location = New System.Drawing.Point(290, 88)
        Me.PC1_IP.Name = "PC1_IP"
        Me.PC1_IP.Size = New System.Drawing.Size(100, 22)
        Me.PC1_IP.TabIndex = 3
        Me.PC1_IP.Text = "tm.cjee.tw"
        '
        'PC1_PORT
        '
        Me.PC1_PORT.Location = New System.Drawing.Point(290, 116)
        Me.PC1_PORT.Name = "PC1_PORT"
        Me.PC1_PORT.Size = New System.Drawing.Size(100, 22)
        Me.PC1_PORT.TabIndex = 4
        Me.PC1_PORT.Text = "15101"
        '
        'PC2_IP
        '
        Me.PC2_IP.Location = New System.Drawing.Point(290, 152)
        Me.PC2_IP.Name = "PC2_IP"
        Me.PC2_IP.Size = New System.Drawing.Size(100, 22)
        Me.PC2_IP.TabIndex = 5
        Me.PC2_IP.Text = "tm.cjee.tw"
        '
        'PC2_PORT
        '
        Me.PC2_PORT.Location = New System.Drawing.Point(290, 180)
        Me.PC2_PORT.Name = "PC2_PORT"
        Me.PC2_PORT.Size = New System.Drawing.Size(100, 22)
        Me.PC2_PORT.TabIndex = 6
        Me.PC2_PORT.Text = "15101"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 258)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 22)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "15101"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 311)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PC2_PORT)
        Me.Controls.Add(Me.PC2_IP)
        Me.Controls.Add(Me.PC1_PORT)
        Me.Controls.Add(Me.PC1_IP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PC2_Rest_Button)
        Me.Controls.Add(Me.PC1_Rest_Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PC1_Rest_Button As Button
    Friend WithEvents PC2_Rest_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PC1_IP As TextBox
    Friend WithEvents PC1_PORT As TextBox
    Friend WithEvents PC2_IP As TextBox
    Friend WithEvents PC2_PORT As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
