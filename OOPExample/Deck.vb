Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

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
        Dim Counter%
        Dim _suit$, _rank$
        Dim tracker As New List(Of String)

        Do Until Me.CardsLeft >= 52
            _suit = GetSuit(GetRandomInRange(4))
            _rank = GetRank(GetRandomInRange(13))

            If Not (tracker.Contains(_rank & _suit)) Then
                Dim newCard As New Card(_rank, _suit)
                Me._deck.Push(newCard)
                tracker.Add(_rank & _suit)
                Counter += 1
            End If
        Loop
    End Sub


    ''' <summary>
    ''' Determins suit string from integer range 1-4. <br></br>
    ''' 1 = Diamond <br></br>
    ''' 2 = Club <br></br>
    ''' 3 = Heart <br></br>
    ''' 4 = Spade <br></br>
    ''' All others invalid will return x
    ''' </summary>
    ''' <param name="suit"></param>
    ''' <returns>String</returns>
    Private Function GetSuit(suit As Integer) As String
        Dim _suit As String
        Select Case suit
            Case 1
                _suit = "d"
            Case 2
                _suit = "c"
            Case 3
                _suit = "h"
            Case 4
                _suit = "s"
            Case Else
                _suit = "x"
        End Select
        Return _suit
    End Function

    ''' <summary>
    ''' Determines rank string from integer range 1-13.<br></br>
    ''' 1 = A <br></br>
    ''' 2-10 = 2-10 <br></br>
    ''' 11 = J <br></br>
    ''' 12 = Q <br></br>
    ''' 13 = K <br></br>
    ''' All others invalid will return x
    ''' </summary>
    ''' <param name="rank"></param>
    ''' <returns>String</returns>
    Private Function GetRank(rank As Integer) As String
        Dim _rank As String
        Select Case rank
            Case 1
                _rank = "a"
            Case 2 To 10
                _rank = CStr(rank)
            Case 11
                _rank = "j"
            Case 12
                _rank = "q"
            Case 13
                _rank = "k"
            Case Else
                _rank = "x"
        End Select
        Return _rank
    End Function

    Private Function GetRandomInRange(max As Integer, Optional min As Integer = 1)
        Randomize()
        Return System.Math.Floor(Rnd() * max) + min
    End Function

    Sub CardsInOrder()
        Dim _suit$, _rank$

        For suit = 1 To 4
            Select Case suit
                Case 1
                    _suit = "d"
                Case 2
                    _suit = "c"
                Case 3
                    _suit = "h"
                Case 4
                    _suit = "s"
            End Select

            For Rank = 1 To 13
                Select Case Rank
                    Case 1
                        _rank = "a"
                    Case 2 To 10
                        _rank = CStr(Rank)
                    Case 11
                        _rank = "j"
                    Case 12
                        _rank = "q"
                    Case 13
                        _rank = "k"
                End Select

                Dim newCard As New Card(_rank, _suit)

                If Not Me._deck.Contains(newCard) Then
                    Me._deck.Push(newCard)
                End If

            Next
        Next


    End Sub

    ''' <summary>
    ''' Deals one card from the top of the card Stack
    ''' </summary>
    ''' <returns>Card</returns>
    Function DealCard() As Card
        Try
            Return _deck.Pop 'Pop will remove a card from the stack
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Returns the number of cards you have left
    ''' </summary>
    ''' <returns>Integer</returns>
    Function CardsLeft() As Integer
        Return _deck.Count
    End Function

    Sub New()
        Shuffle()
    End Sub

End Class