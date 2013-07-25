Imports System.IO
Imports System.Xml

Public Class GameDetailIO

    Private playerFileLoc As String
    Private gameFileLoc As String
    Private playerShareFileLoc As String
    Private combatFileLoc As String
    Private travelFileLoc As String
    Private partyFileLoc As String


    Public Sub setPlayerFileLoc()
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open Your Player File"
        'fd.InitialDirectory = "C:\"
        fd.InitialDirectory = "C:\Users\aburian\Documents\Personal\EDK GAME"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            playerFileLoc = fd.FileName
        Else
            End
        End If

    End Sub

    Public Sub setGameFileLoc()
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open Your Game File"
        'fd.InitialDirectory = "C:\"
        fd.InitialDirectory = "C:\Users\aburian\Documents\Personal\EDK GAME"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            gameFileLoc = fd.FileName
        Else
            End
        End If

    End Sub

    Public Sub setPartyFileLoc()
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each valNode In gameNode
            If valNode.Name = "partyshare" Then
                partyFileLoc = valNode.InnerText
            End If
        Next
    End Sub

    Public Sub setTravelFileLoc()
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each valNode In gameNode
            If valNode.Name = "travelshare" Then
                travelFileLoc = valNode.InnerText
            End If
        Next
    End Sub

    Public Sub setcombatFileLoc()
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each valNode In gameNode
            If valNode.Name = "combatshare" Then
                combatFileLoc = valNode.InnerText
            End If
        Next
    End Sub

    Public Function getPlayerName() As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "name" Then
                Return ValNode.InnerText
            End If
        Next
        Return "Missing No"
    End Function

    Public Function getPlayerTitle() As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "title" Then
                Return ValNode.InnerText
            End If
        Next
        Return ""
    End Function

    Public Function getPlayerType() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "type" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerHP() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "hp" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerMaxHP() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "maxhp" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerXP() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "xp" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerMaxPower() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "maxpower" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerPower() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "power" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerLevel() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "level" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerEndurance() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "endurance" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerDexterity() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "dexterity" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerStrength() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "strength" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerSpeed() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "speed" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function getPlayerIntelligence() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "intelligence" Then
                Return Integer.Parse(ValNode.InnerText)
            End If
        Next
        Return "0"
    End Function

    Public Function playerIsHost() As Boolean
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            If ValNode.Name = "host" Then
                Return (ValNode.InnerText = "true")
            End If
        Next
        Return False
    End Function

    Public Function getGameDestination() As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim catNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each catNode In gameNode
            If catNode.Name = "travel" Then
                For Each valNode In catNode
                    If valNode.Name = "destination" Then
                        Return valNode.InnerText
                    End If
                Next
            End If
        Next
        Return "0"
    End Function

    Public Function getGameFrom() As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim catNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each catNode In gameNode
            If catNode.Name = "travel" Then
                For Each valNode In catNode
                    If valNode.Name = "from" Then
                        Return valNode.InnerText
                    End If
                Next
            End If
        Next
        Return "0"
    End Function

    Public Function getGameDistance() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim catNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each catNode In gameNode
            If catNode.Name = "travel" Then
                For Each valNode In catNode
                    If valNode.Name = "distance" Then
                        Return Integer.Parse(valNode.InnerText)
                    End If
                Next
            End If
        Next
        Return "0"
    End Function

    Public Function getGameName() As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each valNode In gameNode
            If valNode.Name = "name" Then
                Return valNode.InnerText
            End If
        Next
        Return "Unnamed Game"
    End Function

    Public Function isGameover() As Boolean
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each valNode In gameNode
            If valNode.Name = "gameover" Then
                Return (valNode.InnerText = "true")
            End If
        Next
        Return False
    End Function

    Public Function getShare() As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(gameFileLoc)

        Dim gameNode As XmlNode
        Dim valNode As XmlNode

        gameNode = tmpXmlDocument.DocumentElement
        For Each valNode In gameNode
            If valNode.Name = "share" Then
                Return valNode.InnerText
            End If
        Next
        Return ""
    End Function

    Public Sub savePlayer(character As Player)
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(playerFileLoc)

        Dim playerNode As XmlNode
        Dim ValNode As XmlNode

        playerNode = tmpXmlDocument.DocumentElement
        For Each ValNode In playerNode
            Select Case ValNode.Name
                Case "level"
                    ValNode.InnerText = character.level
                Case "hp"
                    ValNode.InnerText = character.hp
                Case "maxhp"
                    ValNode.InnerText = character.maxhp
                Case "endurance"
                    ValNode.InnerText = character.edurance
                Case "dexterity"
                    ValNode.InnerText = character.dexterity
                Case "speed"
                    ValNode.InnerText = character.speed
                Case "intelligence"
                    ValNode.InnerText = character.intelligence
            End Select
        Next
    End Sub

    Public Function readCombat(index As Integer) As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(combatFileLoc)

        Dim sessionNode As XmlNode
        Dim eventNode As XmlNode

        sessionNode = tmpXmlDocument.DocumentElement
        For Each eventNode In sessionNode
            If eventNode.Name = index.ToString Then
                Return eventNode.InnerText
            End If
        Next
        Return "err"
    End Function

    Public Function getLastCombatIndex() As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(combatFileLoc)

        Return Integer.Parse(tmpXmlDocument.LastChild.Name)
    End Function

    Public Sub writeCombat()
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        Dim addNode As XmlNode
        tmpXmlDocument.Load(combatFileLoc)
        Dim lastIndex As Integer = Integer.Parse(tmpXmlDocument.LastChild.Name)



    End Sub

    Public Function getPartyMemberName(index As Integer) As String
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(partyFileLoc)

        Dim partyNode As XmlNode
        Dim playerNode As XmlNode
        Dim valNode As XmlNode

        partyNode = tmpXmlDocument.DocumentElement
        For Each playerNode In partyNode
            If playerNode.Name = ("player" & index) Then
                For Each valNode In playerNode
                    If valNode.Name = "name" Then
                        Return valNode.InnerText
                    End If
                Next
            End If
        Next
        Return ""
    End Function

    Public Function getPartyMemberLevel(index As Integer) As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(partyFileLoc)

        Dim partyNode As XmlNode
        Dim playerNode As XmlNode
        Dim valNode As XmlNode

        partyNode = tmpXmlDocument.DocumentElement
        For Each playerNode In partyNode
            If playerNode.Name = ("player" & index) Then
                For Each valNode In playerNode
                    If valNode.Name = "level" Then
                        Return Integer.Parse(valNode.InnerText)
                    End If
                Next
            End If
        Next
        Return ""
    End Function

    Public Function getPartyMemberHP(index As Integer) As Integer
        Dim tmpXmlDocument As XmlDocument = New XmlDocument()
        tmpXmlDocument.Load(partyFileLoc)

        Dim partyNode As XmlNode
        Dim playerNode As XmlNode
        Dim valNode As XmlNode

        partyNode = tmpXmlDocument.DocumentElement
        For Each playerNode In partyNode
            If playerNode.Name = ("player" & index) Then
                For Each valNode In playerNode
                    If valNode.Name = "hppercent" Then
                        Return Integer.Parse(valNode.InnerText)
                    End If
                Next
            End If
        Next
        Return ""
    End Function
End Class

'combat file loc not yet set