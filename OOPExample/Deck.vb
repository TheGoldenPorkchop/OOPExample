Public Class Deck
    Private _deck As New Stack(Of Card)

    Sub test()
        Dim ah As New Card("a", "h")
        Dim asp As New Card("a", "s")
        Dim ac As New Card("a", "c")
        Dim ad As New Card("a", "d")
        Me._deck.Push(ah) 'Push Adds a card to the stack
        Me._deck.Push(asp)
        Me._deck.Push(ac)
        Me._deck.Push(ad)
    End Sub

    Sub Shuffle()

    End Sub

    ''' <summary>
    ''' Deals one card from the top of the card Stack
    ''' </summary>
    ''' <returns>Card</returns>
    Function DealCard() As Card
        Return _deck.Pop 'Pop will remove a card from the stack
    End Function

    ''' <summary>
    ''' Returns the number of cards you have left
    ''' </summary>
    ''' <returns>Integer</returns>
    Function CardsLeft() As Integer
        Return _deck.Count
    End Function

    Sub New()
        test()
    End Sub

End Class