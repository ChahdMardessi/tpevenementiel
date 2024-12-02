<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcalculatrice
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
        lbl_A = New Label()
        lbl_B = New Label()
        lbl_result = New Label()
        lbl_ress = New Label()
        txt_A = New TextBox()
        txt_B = New TextBox()
        btn_plus = New Button()
        btn_minus = New Button()
        btn_mult = New Button()
        btn_div = New Button()
        btn_equal = New Button()
        btn_res = New Button()
        lbl_res = New Label()
        SuspendLayout()
        ' 
        ' lbl_A
        ' 
        lbl_A.AutoSize = True
        lbl_A.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_A.ForeColor = SystemColors.Highlight
        lbl_A.Location = New Point(66, 60)
        lbl_A.Name = "lbl_A"
        lbl_A.Size = New Size(38, 34)
        lbl_A.TabIndex = 0
        lbl_A.Text = "A"
        ' 
        ' lbl_B
        ' 
        lbl_B.AutoSize = True
        lbl_B.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_B.ForeColor = SystemColors.Highlight
        lbl_B.Location = New Point(66, 151)
        lbl_B.Name = "lbl_B"
        lbl_B.Size = New Size(34, 34)
        lbl_B.TabIndex = 1
        lbl_B.Text = "B"
        ' 
        ' lbl_result
        ' 
        lbl_result.AutoSize = True
        lbl_result.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_result.ForeColor = SystemColors.ControlDarkDark
        lbl_result.Location = New Point(79, 388)
        lbl_result.Name = "lbl_result"
        lbl_result.Size = New Size(169, 34)
        lbl_result.TabIndex = 2
        lbl_result.Text = "resultat "
        ' 
        ' lbl_ress
        ' 
        lbl_ress.AutoSize = True
        lbl_ress.Font = New Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_ress.ForeColor = SystemColors.Highlight
        lbl_ress.Location = New Point(564, 388)
        lbl_ress.Name = "lbl_ress"
        lbl_ress.Size = New Size(0, 34)
        lbl_ress.TabIndex = 3
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(170, 60)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(125, 27)
        txt_A.TabIndex = 4
        ' 
        ' txt_B
        ' 
        txt_B.Location = New Point(170, 151)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(125, 27)
        txt_B.TabIndex = 5
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = SystemColors.ActiveCaption
        btn_plus.Location = New Point(79, 206)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(82, 56)
        btn_plus.TabIndex = 7
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_minus
        ' 
        btn_minus.BackColor = SystemColors.ActiveCaption
        btn_minus.Location = New Point(337, 206)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(85, 53)
        btn_minus.TabIndex = 8
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = False
        ' 
        ' btn_mult
        ' 
        btn_mult.BackColor = SystemColors.ActiveCaption
        btn_mult.Location = New Point(629, 206)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(85, 53)
        btn_mult.TabIndex = 9
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = False
        ' 
        ' btn_div
        ' 
        btn_div.BackColor = SystemColors.ActiveCaption
        btn_div.Location = New Point(81, 287)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(80, 56)
        btn_div.TabIndex = 10
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = False
        ' 
        ' btn_equal
        ' 
        btn_equal.BackColor = SystemColors.ActiveCaption
        btn_equal.Location = New Point(337, 287)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(85, 56)
        btn_equal.TabIndex = 11
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = False
        ' 
        ' btn_res
        ' 
        btn_res.BackColor = SystemColors.ActiveCaption
        btn_res.Location = New Point(629, 287)
        btn_res.Name = "btn_res"
        btn_res.Size = New Size(85, 53)
        btn_res.TabIndex = 12
        btn_res.Text = "reset"
        btn_res.UseVisualStyleBackColor = False
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Location = New Point(311, 388)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(15, 20)
        lbl_res.TabIndex = 13
        lbl_res.Text = ".."
        ' 
        ' frmcalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_res)
        Controls.Add(btn_res)
        Controls.Add(btn_equal)
        Controls.Add(btn_div)
        Controls.Add(btn_mult)
        Controls.Add(btn_minus)
        Controls.Add(btn_plus)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(lbl_ress)
        Controls.Add(lbl_result)
        Controls.Add(lbl_B)
        Controls.Add(lbl_A)
        Name = "frmcalculatrice"
        Text = "frmcalculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_A As Label
    Friend WithEvents lbl_B As Label
    Friend WithEvents lbl_result As Label
    Friend WithEvents lbl_ress As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_res As Button
    Friend WithEvents lbl_res As Label

End Class
