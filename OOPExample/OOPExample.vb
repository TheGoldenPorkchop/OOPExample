Imports System.ComponentModel

Public Class OOPExample
    Private Sub OOPExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OOPExample_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim ah As New Card("a", "h")
        'Dim cardName As String = "_AS"
        'Dim cardImage As Image = My.Resources.ResourceManager.GetObject(cardName)
        Dim g As Graphics = Me.CreateGraphics

        g.DrawImage(ah.backImage, 10, 10)
        g.DrawImage(ah.frontImage, 100, 100)

        g.Dispose()
    End Sub
End Class
