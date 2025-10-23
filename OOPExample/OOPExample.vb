Imports System.ComponentModel

Public Class OOPExample
    Dim testDeck As New Deck 'put this in GameLogic Class
    Private Sub OOPExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OOPExample_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Dim ah As New Card("a", "h")
        'Dim cardName As String = "_AS"
        'Dim cardImage As Image = My.Resources.ResourceManager.GetObject(cardName)
        'Dim currentCard As New Card

        'testDeck.DealCard()

        Dim g As Graphics = Me.CreateGraphics

        g.DrawImage(testDeck.DealCard.frontImage, 10, 10)
        'g.DrawImage(testDeck.DealCard.frontImage, 50, 50)
        'g.DrawImage(testDeck.DealCard.frontImage, 100, 100)
        'g.DrawImage(testDeck.DealCard.frontImage, 150, 150)
        'g.DrawImage(ah.frontImage, 100, 100)

        g.Dispose()
    End Sub
End Class
