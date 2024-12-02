<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lbl_ISBN = New Label()
        lbl_Titre = New Label()
        lbl_Auteur = New Label()
        Btn_ajouter = New Button()
        Btn_afficher = New Button()
        Txt_ISBN = New TextBox()
        Txt_Titre = New TextBox()
        Txt_Auteur = New TextBox()
        SuspendLayout()
        ' 
        ' lbl_ISBN
        ' 
        lbl_ISBN.AutoSize = True
        lbl_ISBN.Font = New Font("Elephant", 10.1999989F)
        lbl_ISBN.ForeColor = Color.Sienna
        lbl_ISBN.Location = New Point(107, 83)
        lbl_ISBN.Name = "lbl_ISBN"
        lbl_ISBN.Size = New Size(66, 22)
        lbl_ISBN.TabIndex = 0
        lbl_ISBN.Text = "ISBN:"
        ' 
        ' lbl_Titre
        ' 
        lbl_Titre.AutoSize = True
        lbl_Titre.Font = New Font("Elephant", 10.1999989F)
        lbl_Titre.ForeColor = Color.Sienna
        lbl_Titre.Location = New Point(107, 161)
        lbl_Titre.Name = "lbl_Titre"
        lbl_Titre.Size = New Size(60, 22)
        lbl_Titre.TabIndex = 1
        lbl_Titre.Text = "Titre:"
        ' 
        ' lbl_Auteur
        ' 
        lbl_Auteur.AutoSize = True
        lbl_Auteur.Font = New Font("Elephant", 10.1999989F)
        lbl_Auteur.ForeColor = Color.Sienna
        lbl_Auteur.Location = New Point(107, 225)
        lbl_Auteur.Name = "lbl_Auteur"
        lbl_Auteur.Size = New Size(75, 22)
        lbl_Auteur.TabIndex = 2
        lbl_Auteur.Text = "Auteur:"
        ' 
        ' Btn_ajouter
        ' 
        Btn_ajouter.Font = New Font("Arial", 12F)
        Btn_ajouter.ForeColor = Color.RosyBrown
        Btn_ajouter.Location = New Point(159, 329)
        Btn_ajouter.Name = "Btn_ajouter"
        Btn_ajouter.Size = New Size(94, 56)
        Btn_ajouter.TabIndex = 3
        Btn_ajouter.Text = "Ajouter"
        Btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Btn_afficher
        ' 
        Btn_afficher.Font = New Font("Arial", 12F)
        Btn_afficher.ForeColor = Color.RosyBrown
        Btn_afficher.Location = New Point(376, 329)
        Btn_afficher.Name = "Btn_afficher"
        Btn_afficher.Size = New Size(99, 56)
        Btn_afficher.TabIndex = 4
        Btn_afficher.Text = "Afficher"
        Btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' Txt_ISBN
        ' 
        Txt_ISBN.Location = New Point(248, 83)
        Txt_ISBN.Name = "Txt_ISBN"
        Txt_ISBN.Size = New Size(165, 27)
        Txt_ISBN.TabIndex = 5
        ' 
        ' Txt_Titre
        ' 
        Txt_Titre.Location = New Point(248, 154)
        Txt_Titre.Name = "Txt_Titre"
        Txt_Titre.Size = New Size(165, 27)
        Txt_Titre.TabIndex = 6
        ' 
        ' Txt_Auteur
        ' 
        Txt_Auteur.Location = New Point(248, 218)
        Txt_Auteur.Name = "Txt_Auteur"
        Txt_Auteur.Size = New Size(165, 27)
        Txt_Auteur.TabIndex = 7
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Txt_Auteur)
        Controls.Add(Txt_Titre)
        Controls.Add(Txt_ISBN)
        Controls.Add(Btn_afficher)
        Controls.Add(Btn_ajouter)
        Controls.Add(lbl_Auteur)
        Controls.Add(lbl_Titre)
        Controls.Add(lbl_ISBN)
        Name = "form1"
        Text = "livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_ISBN As Label
    Friend WithEvents lbl_Titre As Label
    Friend WithEvents lbl_Auteur As Label
    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Btn_afficher As Button
    Friend WithEvents Txt_ISBN As TextBox
    Friend WithEvents Txt_Titre As TextBox
    Friend WithEvents Txt_Auteur As TextBox

End Class
