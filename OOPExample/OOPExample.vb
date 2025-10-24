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

        Dim g As Graphics = Me.CreateGraphics
        Dim offset% = 50

        For row = 1 To 4
            For column = 1 To 13
                g.DrawImage(testDeck.DealCard.frontImage, column * offset, row * offset)
                Me.Text = testDeck.CardsLeft
            Next
        Next

        g.Dispose()
    End Sub

    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        Me.testDeck.Shuffle()
    End Sub
End Class
