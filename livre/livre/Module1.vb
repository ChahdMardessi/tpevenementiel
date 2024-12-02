Module gestion_livre
    Public Structure livre
        Dim ISBN As Integer
        Dim Titre As String
        Dim Auteur As String
    End Structure

    Public bibliotheque(100) As livre
    Dim Nb As Integer = 0


    Function AjouterLivre(l As livre) As Boolean
        If Nb < bibliotheque.Length Then
            bibliotheque(Nb) = l
            Nb += 1
            Return True
        Else
            Return False
        End If
    End Function










End Module
