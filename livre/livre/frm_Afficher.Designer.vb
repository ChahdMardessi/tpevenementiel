<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Afficher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Btn_affiche = New Button()
        lst_ISBN = New ListBox()
        lst_Titre = New ListBox()
        lst_Auteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(328, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(561, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' Btn_affiche
        ' 
        Btn_affiche.Location = New Point(328, 388)
        Btn_affiche.Name = "Btn_affiche"
        Btn_affiche.Size = New Size(94, 29)
        Btn_affiche.TabIndex = 3
        Btn_affiche.Text = "Button1"
        Btn_affiche.UseVisualStyleBackColor = True
        ' 
        ' lst_ISBN
        ' 
        lst_ISBN.FormattingEnabled = True
        lst_ISBN.Items.AddRange(New Object() {"lst_ISBN"})
        lst_ISBN.Location = New Point(45, 157)
        lst_ISBN.Name = "lst_ISBN"
        lst_ISBN.Size = New Size(150, 104)
        lst_ISBN.TabIndex = 4
        ' 
        ' lst_Titre
        ' 
        lst_Titre.FormattingEnabled = True
        lst_Titre.Items.AddRange(New Object() {"lst_Titre"})
        lst_Titre.Location = New Point(290, 157)
        lst_Titre.Name = "lst_Titre"
        lst_Titre.Size = New Size(150, 104)
        lst_Titre.TabIndex = 5
        ' 
        ' lst_Auteur
        ' 
        lst_Auteur.FormattingEnabled = True
        lst_Auteur.Items.AddRange(New Object() {"lst_Auteur"})
        lst_Auteur.Location = New Point(534, 157)
        lst_Auteur.Name = "lst_Auteur"
        lst_Auteur.Size = New Size(150, 104)
        lst_Auteur.TabIndex = 6
        ' 
        ' frm_Afficher
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lst_Auteur)
        Controls.Add(lst_Titre)
        Controls.Add(lst_ISBN)
        Controls.Add(Btn_affiche)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_Afficher"
        Text = "liste des livres"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_affiche As Button
    Friend WithEvents lst_ISBN As ListBox
    Friend WithEvents lst_Titre As ListBox
    Friend WithEvents lst_Auteur As ListBox
End Class
