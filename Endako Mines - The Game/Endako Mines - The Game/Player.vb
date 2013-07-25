Public Class Player
    Public name As String
    Public title As String
    Public level As Integer
    Public type As Integer

    Private skills(4) As Skill

    Public xp As Integer

    Public edurance As Integer
    Public dexterity As Integer
    Public strength As Integer
    Public speed As Integer
    Public intelligence As Integer

    Public hp As Integer
    Public maxhp As Integer

    Public power As Integer
    Public maxPower As Integer


    Private isHost As Boolean


    Sub New(detail As GameDetailIO)
        level = detail.getPlayerLevel
        type = detail.getPlayerType
        xp = detail.getPlayerXP
        hp = detail.getPlayerHP
        maxhp = detail.getPlayerMaxHP
        name = detail.getPlayerName
        title = detail.getPlayerTitle
        edurance = detail.getPlayerEndurance
        dexterity = detail.getPlayerDexterity
        strength = detail.getPlayerStrength
        speed = detail.getPlayerSpeed
        intelligence = detail.getPlayerIntelligence
        isHost = detail.playerIsHost
        power = detail.getPlayerPower
        maxPower = detail.getPlayerMaxPower


        Select Case type
            Case 1

            Case 2
                skills(0) = New Debug()
                skills(1) = New Compile()
                skills(2) = New Defrag()
        End Select



    End Sub
    
    Public Function isDead() As Boolean
        Return (hp <= 0)
    End Function
    Public Function xpToNextLevel() As Integer
        Select Case level
            Case 1
                Return 100
            Case 2
                Return 300
            Case 3
                Return 900
            Case 4
                Return 2700
            Case 5
                Return 6000
            Case Else
                Return 0
        End Select
    End Function
End Class
