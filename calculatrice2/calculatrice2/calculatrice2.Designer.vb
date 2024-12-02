<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculatrice2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Txt_afficher = New TextBox()
        btn_0 = New Button()
        btn_1 = New Button()
        btn_2 = New Button()
        btn_3 = New Button()
        btn_4 = New Button()
        btn_5 = New Button()
        btn_6 = New Button()
        btn_7 = New Button()
        btn_8 = New Button()
        btn_9 = New Button()
        btn_c = New Button()
        btn_equal = New Button()
        btn_plus = New Button()
        btn_minus = New Button()
        btn_mult = New Button()
        btn_div = New Button()
        SuspendLayout()
        ' 
        ' Txt_afficher
        ' 
        Txt_afficher.Location = New Point(230, 12)
        Txt_afficher.Name = "Txt_afficher"
        Txt_afficher.Size = New Size(253, 27)
        Txt_afficher.TabIndex = 0
        ' 
        ' btn_0
        ' 
        btn_0.BackColor = Color.PaleVioletRed
        btn_0.Font = New Font("Segoe Script", 10.8F)
        btn_0.ForeColor = Color.Black
        btn_0.Location = New Point(52, 89)
        btn_0.Name = "btn_0"
        btn_0.Size = New Size(82, 59)
        btn_0.TabIndex = 1
        btn_0.Text = "0"
        btn_0.UseVisualStyleBackColor = False
        ' 
        ' btn_1
        ' 
        btn_1.BackColor = Color.PaleVioletRed
        btn_1.Font = New Font("Segoe Script", 10.8F)
        btn_1.ForeColor = Color.Black
        btn_1.Location = New Point(230, 89)
        btn_1.Name = "btn_1"
        btn_1.Size = New Size(82, 59)
        btn_1.TabIndex = 2
        btn_1.Text = "1"
        btn_1.UseVisualStyleBackColor = False
        ' 
        ' btn_2
        ' 
        btn_2.BackColor = Color.PaleVioletRed
        btn_2.Font = New Font("Segoe Script", 10.8F)
        btn_2.ForeColor = Color.Black
        btn_2.Location = New Point(401, 89)
        btn_2.Name = "btn_2"
        btn_2.Size = New Size(82, 59)
        btn_2.TabIndex = 3
        btn_2.Text = "2"
        btn_2.UseVisualStyleBackColor = False
        ' 
        ' btn_3
        ' 
        btn_3.BackColor = Color.PaleVioletRed
        btn_3.Font = New Font("Segoe Script", 10.8F)
        btn_3.ForeColor = Color.Black
        btn_3.Location = New Point(611, 89)
        btn_3.Name = "btn_3"
        btn_3.Size = New Size(82, 59)
        btn_3.TabIndex = 4
        btn_3.Text = "3"
        btn_3.UseVisualStyleBackColor = False
        ' 
        ' btn_4
        ' 
        btn_4.BackColor = Color.PaleVioletRed
        btn_4.Font = New Font("Segoe Script", 10.8F)
        btn_4.ForeColor = Color.Black
        btn_4.Location = New Point(52, 187)
        btn_4.Name = "btn_4"
        btn_4.Size = New Size(82, 59)
        btn_4.TabIndex = 5
        btn_4.Text = "4"
        btn_4.UseVisualStyleBackColor = False
        ' 
        ' btn_5
        ' 
        btn_5.BackColor = Color.PaleVioletRed
        btn_5.Font = New Font("Segoe Script", 10.8F)
        btn_5.ForeColor = Color.Black
        btn_5.Location = New Point(230, 187)
        btn_5.Name = "btn_5"
        btn_5.Size = New Size(82, 59)
        btn_5.TabIndex = 6
        btn_5.Text = "5"
        btn_5.UseVisualStyleBackColor = False
        ' 
        ' btn_6
        ' 
        btn_6.BackColor = Color.PaleVioletRed
        btn_6.Font = New Font("Segoe Script", 10.8F)
        btn_6.ForeColor = Color.Black
        btn_6.Location = New Point(401, 187)
        btn_6.Name = "btn_6"
        btn_6.Size = New Size(82, 59)
        btn_6.TabIndex = 7
        btn_6.Text = "6"
        btn_6.UseVisualStyleBackColor = False
        ' 
        ' btn_7
        ' 
        btn_7.BackColor = Color.PaleVioletRed
        btn_7.Font = New Font("Segoe Script", 10.8F)
        btn_7.ForeColor = Color.Black
        btn_7.Location = New Point(611, 187)
        btn_7.Name = "btn_7"
        btn_7.Size = New Size(82, 59)
        btn_7.TabIndex = 8
        btn_7.Text = "7"
        btn_7.UseVisualStyleBackColor = False
        ' 
        ' btn_8
        ' 
        btn_8.BackColor = Color.PaleVioletRed
        btn_8.Font = New Font("Segoe Script", 10.8F)
        btn_8.ForeColor = Color.Black
        btn_8.Location = New Point(52, 282)
        btn_8.Name = "btn_8"
        btn_8.Size = New Size(82, 59)
        btn_8.TabIndex = 9
        btn_8.Text = "8"
        btn_8.UseVisualStyleBackColor = False
        ' 
        ' btn_9
        ' 
        btn_9.BackColor = Color.PaleVioletRed
        btn_9.Font = New Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_9.ForeColor = Color.Black
        btn_9.Location = New Point(230, 282)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(82, 59)
        btn_9.TabIndex = 10
        btn_9.Text = "9"
        btn_9.UseVisualStyleBackColor = False
        ' 
        ' btn_c
        ' 
        btn_c.BackColor = Color.DeepPink
        btn_c.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_c.ForeColor = Color.Black
        btn_c.Location = New Point(401, 282)
        btn_c.Name = "btn_c"
        btn_c.Size = New Size(82, 59)
        btn_c.TabIndex = 11
        btn_c.Text = "c"
        btn_c.UseVisualStyleBackColor = False
        ' 
        ' btn_equal
        ' 
        btn_equal.BackColor = Color.Orchid
        btn_equal.Font = New Font("Impact", 18F)
        btn_equal.ForeColor = Color.DarkGreen
        btn_equal.Location = New Point(611, 282)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(82, 59)
        btn_equal.TabIndex = 12
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = False
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = Color.Orchid
        btn_plus.Font = New Font("Impact", 18F)
        btn_plus.ForeColor = Color.DarkGreen
        btn_plus.Location = New Point(52, 366)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(82, 59)
        btn_plus.TabIndex = 13
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_minus
        ' 
        btn_minus.BackColor = Color.Orchid
        btn_minus.Font = New Font("Impact", 18F)
        btn_minus.ForeColor = Color.DarkGreen
        btn_minus.Location = New Point(230, 366)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(82, 59)
        btn_minus.TabIndex = 14
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = False
        ' 
        ' btn_mult
        ' 
        btn_mult.BackColor = Color.Orchid
        btn_mult.Font = New Font("Impact", 18F)
        btn_mult.ForeColor = Color.DarkGreen
        btn_mult.Location = New Point(401, 366)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(82, 59)
        btn_mult.TabIndex = 15
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = False
        ' 
        ' btn_div
        ' 
        btn_div.BackColor = Color.Orchid
        btn_div.Font = New Font("Impact", 18F)
        btn_div.ForeColor = Color.DarkGreen
        btn_div.Location = New Point(611, 366)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(82, 59)
        btn_div.TabIndex = 16
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = False
        ' 
        ' calculatrice2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Purple
        ClientSize = New Size(800, 450)
        Controls.Add(btn_div)
        Controls.Add(btn_mult)
        Controls.Add(btn_minus)
        Controls.Add(btn_plus)
        Controls.Add(btn_equal)
        Controls.Add(btn_c)
        Controls.Add(btn_9)
        Controls.Add(btn_8)
        Controls.Add(btn_7)
        Controls.Add(btn_6)
        Controls.Add(btn_5)
        Controls.Add(btn_4)
        Controls.Add(btn_3)
        Controls.Add(btn_2)
        Controls.Add(btn_1)
        Controls.Add(btn_0)
        Controls.Add(Txt_afficher)
        ForeColor = Color.Black
        Name = "calculatrice2"
        Text = "calculatrice2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_c As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents Txt_afficher As TextBox

End Class
