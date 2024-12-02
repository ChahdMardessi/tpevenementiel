Public Class form1
    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click
        Dim l As livre
        l.ISBN = Txt_ISBN.Text
        l.Titre = Txt_Titre.Text
        l.Auteur = Txt_Auteur.Text

        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succes")
        Else
            MessageBox.Show("Le tableau bibliotheque est saturé ")
        End If
    End Sub
End Class
