Public Class Party
    Public player1 As PartyMember = New PartyMember()
    Public player2 As PartyMember = New PartyMember()
    Public player3 As PartyMember = New PartyMember()
    Public player4 As PartyMember = New PartyMember()
    Public player5 As PartyMember = New PartyMember()
    Private details As GameDetailIO

    Class PartyMember
        Public name As String
        Public level As Integer
        Public hppercent As Double
    End Class

    Sub New(detail As GameDetailIO)
        details = detail
        player1.name = detail.getPartyMemberName(1)
        player1.level = detail.getPartyMemberLevel(1)
        player1.hppercent = detail.getPartyMemberHP(1)

        player2.name = detail.getPartyMemberName(2)
        player2.level = detail.getPartyMemberLevel(2)
        player2.hppercent = detail.getPartyMemberHP(2)

        player3.name = detail.getPartyMemberName(3)
        player3.level = detail.getPartyMemberLevel(3)
        player3.hppercent = detail.getPartyMemberHP(3)

        player4.name = detail.getPartyMemberName(4)
        player4.level = detail.getPartyMemberLevel(4)
        player4.hppercent = detail.getPartyMemberHP(4)

        player5.name = detail.getPartyMemberName(5)
        player5.level = detail.getPartyMemberLevel(5)
        player5.hppercent = detail.getPartyMemberHP(5)
    End Sub

    Public Sub updatePlayer1()
        player1.name = details.getPartyMemberName(1)
        player1.level = details.getPartyMemberLevel(1)
        player1.hppercent = details.getPartyMemberHP(1)
    End Sub

    Public Sub updatePlayer2()
        player2.name = details.getPartyMemberName(2)
        player2.level = details.getPartyMemberLevel(2)
        player2.hppercent = details.getPartyMemberHP(2)
    End Sub

    Public Sub updatePlayer3()
        player3.name = details.getPartyMemberName(3)
        player3.level = details.getPartyMemberLevel(3)
        player3.hppercent = details.getPartyMemberHP(3)
    End Sub

    Public Sub updatePlayer4()
        player4.name = details.getPartyMemberName(4)
        player4.level = details.getPartyMemberLevel(4)
        player4.hppercent = details.getPartyMemberHP(4)
    End Sub

    Public Sub updatePlayer5()
        player5.name = details.getPartyMemberName(5)
        player5.level = details.getPartyMemberLevel(5)
        player5.hppercent = details.getPartyMemberHP(5)
    End Sub
End Class
