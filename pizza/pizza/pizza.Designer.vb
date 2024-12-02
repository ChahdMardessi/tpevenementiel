<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
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
        lst_demande = New ComboBox()
        hk_champignion = New CheckBox()
        hk_olives = New CheckBox()
        hk_poissons = New CheckBox()
        hk_fromages = New CheckBox()
        rd_fine = New RadioButton()
        rd_classique = New RadioButton()
        rd_epaise = New RadioButton()
        btn = New Button()
        SuspendLayout()
        ' 
        ' lst_demande
        ' 
        lst_demande.BackColor = SystemColors.HighlightText
        lst_demande.FormattingEnabled = True
        lst_demande.Items.AddRange(New Object() {"petite ", "grande", "moyenne "})
        lst_demande.Location = New Point(312, 15)
        lst_demande.Margin = New Padding(4)
        lst_demande.Name = "lst_demande"
        lst_demande.Size = New Size(188, 33)
        lst_demande.TabIndex = 0
        ' 
        ' hk_champignion
        ' 
        hk_champignion.AutoSize = True
        hk_champignion.Font = New Font("Arial Rounded MT Bold", 12F)
        hk_champignion.ForeColor = Color.Purple
        hk_champignion.Location = New Point(91, 171)
        hk_champignion.Margin = New Padding(4)
        hk_champignion.Name = "hk_champignion"
        hk_champignion.Size = New Size(158, 27)
        hk_champignion.TabIndex = 1
        hk_champignion.Text = "champignion"
        hk_champignion.UseVisualStyleBackColor = True
        ' 
        ' hk_olives
        ' 
        hk_olives.AutoSize = True
        hk_olives.Font = New Font("Arial Rounded MT Bold", 12F)
        hk_olives.ForeColor = Color.Purple
        hk_olives.Location = New Point(91, 256)
        hk_olives.Margin = New Padding(4)
        hk_olives.Name = "hk_olives"
        hk_olives.Size = New Size(88, 27)
        hk_olives.TabIndex = 2
        hk_olives.Text = "olives"
        hk_olives.UseVisualStyleBackColor = True
        ' 
        ' hk_poissons
        ' 
        hk_poissons.AutoSize = True
        hk_poissons.Font = New Font("Arial Rounded MT Bold", 12F)
        hk_poissons.ForeColor = Color.Purple
        hk_poissons.Location = New Point(91, 336)
        hk_poissons.Margin = New Padding(4)
        hk_poissons.Name = "hk_poissons"
        hk_poissons.Size = New Size(124, 27)
        hk_poissons.TabIndex = 3
        hk_poissons.Text = "poissons "
        hk_poissons.UseVisualStyleBackColor = True
        ' 
        ' hk_fromages
        ' 
        hk_fromages.AutoSize = True
        hk_fromages.Font = New Font("Arial Rounded MT Bold", 12F)
        hk_fromages.ForeColor = Color.Purple
        hk_fromages.Location = New Point(91, 419)
        hk_fromages.Margin = New Padding(4)
        hk_fromages.Name = "hk_fromages"
        hk_fromages.Size = New Size(295, 27)
        hk_fromages.TabIndex = 4
        hk_fromages.Text = "formages supplementaires"
        hk_fromages.UseVisualStyleBackColor = True
        ' 
        ' rd_fine
        ' 
        rd_fine.AutoSize = True
        rd_fine.Font = New Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic)
        rd_fine.ForeColor = Color.IndianRed
        rd_fine.Location = New Point(91, 91)
        rd_fine.Margin = New Padding(4)
        rd_fine.Name = "rd_fine"
        rd_fine.Size = New Size(150, 33)
        rd_fine.TabIndex = 5
        rd_fine.TabStop = True
        rd_fine.Text = "croute fine"
        rd_fine.UseVisualStyleBackColor = True
        ' 
        ' rd_classique
        ' 
        rd_classique.AutoSize = True
        rd_classique.Font = New Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic)
        rd_classique.ForeColor = Color.IndianRed
        rd_classique.Location = New Point(341, 91)
        rd_classique.Margin = New Padding(4)
        rd_classique.Name = "rd_classique"
        rd_classique.Size = New Size(217, 33)
        rd_classique.TabIndex = 6
        rd_classique.TabStop = True
        rd_classique.Text = "croute classique "
        rd_classique.UseVisualStyleBackColor = True
        ' 
        ' rd_epaise
        ' 
        rd_epaise.AutoSize = True
        rd_epaise.Font = New Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic)
        rd_epaise.ForeColor = Color.IndianRed
        rd_epaise.Location = New Point(644, 91)
        rd_epaise.Margin = New Padding(4)
        rd_epaise.Name = "rd_epaise"
        rd_epaise.Size = New Size(180, 33)
        rd_epaise.TabIndex = 7
        rd_epaise.TabStop = True
        rd_epaise.Text = "croute epaise"
        rd_epaise.UseVisualStyleBackColor = True
        ' 
        ' btn
        ' 
        btn.Font = New Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn.ForeColor = Color.MediumVioletRed
        btn.Location = New Point(324, 486)
        btn.Margin = New Padding(4)
        btn.Name = "btn"
        btn.Size = New Size(245, 36)
        btn.TabIndex = 8
        btn.Text = "afficher la commande "
        btn.UseVisualStyleBackColor = True
        ' 
        ' pizza
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(885, 562)
        Controls.Add(btn)
        Controls.Add(rd_epaise)
        Controls.Add(rd_classique)
        Controls.Add(rd_fine)
        Controls.Add(hk_fromages)
        Controls.Add(hk_poissons)
        Controls.Add(hk_olives)
        Controls.Add(hk_champignion)
        Controls.Add(lst_demande)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        ForeColor = Color.Purple
        Margin = New Padding(4)
        Name = "pizza"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_demande As ComboBox
    Friend WithEvents hk_champignion As CheckBox
    Friend WithEvents hk_olives As CheckBox
    Friend WithEvents hk_poissons As CheckBox
    Friend WithEvents hk_fromages As CheckBox
    Friend WithEvents rd_fine As RadioButton
    Friend WithEvents rd_classique As RadioButton
    Friend WithEvents rd_epaise As RadioButton
    Friend WithEvents btn As Button

End Class
