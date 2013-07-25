Imports System.IO
Imports System.Xml


Public Class GameForm
    Dim game As Main

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        game = New Main()


    End Sub
    Sub go() Handles LoadBtn.Click
        game.Play()
    End Sub

End Class




