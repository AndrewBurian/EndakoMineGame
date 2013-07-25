Imports Endako_Mines___The_Game.GameDetailIO
Imports Endako_Mines___The_Game.GameForm


Class Main


    Private GameInfo As GameDetailIO = New GameDetailIO()
    Private Character As Player
    Private Location As Locations = New Locations()
    Private PlayerCount As Integer
    Private watcher As System.IO.FileSystemWatcher
    Private GameParty As Party


    Private Sub refreshCharacterLabels()
        GameForm.NameLbl.Text = Character.name & " " & Character.title & " (" & Character.level & ")"
        GameForm.HPbar.Maximum = Character.maxhp
        GameForm.HPbar.Value = Character.hp
        GameForm.EnduranceLbl.Text = Character.edurance
        GameForm.DexterityLbl.Text = Character.dexterity
        GameForm.StrengthLbl.Text = Character.strength
        GameForm.SpeedLbl.Text = Character.speed
        GameForm.IntelligenceLbl.Text = Character.intelligence
        GameForm.StatusLbl.Text = "normal"

        GameForm.XPbar.Value = Character.xp
        GameForm.XPbar.Maximum = Character.xpToNextLevel

        GameForm.PowerBar.Value = Character.power
        GameForm.PowerBar.Maximum = Character.maxPower


    End Sub

    Private Sub refreshParty()
        Dim player1diff = GameInfo.getPartyMemberHP(1) - GameParty.player1.hppercent
        Select Case player1diff
            Case Is < 0
                combatDialogue(Color.Green, GameParty.player1.name & " restored " & player1diff & " HP")
                GameParty.updatePlayer1()
            Case Is > 0
                combatDialogue(Color.Red, GameParty.player1.name & " took " & player1diff & " damage")
                GameParty.updatePlayer1()
        End Select

        Dim player2diff = GameInfo.getPartyMemberHP(2) - GameParty.player2.hppercent
        Select Case player2diff
            Case Is < 0
                combatDialogue(Color.Green, GameParty.player2.name & " restored " & player2diff & " HP")
                GameParty.updatePlayer2()
            Case Is > 0
                combatDialogue(Color.Red, GameParty.player2.name & " took " & player2diff & " damage")
                GameParty.updatePlayer2()
        End Select

        Dim player3diff = GameInfo.getPartyMemberHP(3) - GameParty.player3.hppercent
        Select Case player3diff
            Case Is < 0
                combatDialogue(Color.Green, GameParty.player3.name & " restored " & player3diff & " HP")
                GameParty.updatePlayer3()
            Case Is > 0
                combatDialogue(Color.Red, GameParty.player3.name & " took " & player3diff & " damage")
                GameParty.updatePlayer3()
        End Select

        Dim player4diff = GameInfo.getPartyMemberHP(4) - GameParty.player4.hppercent
        Select Case player4diff
            Case Is < 0
                combatDialogue(Color.Green, GameParty.player4.name & " restored " & player4diff & " HP")
                GameParty.updatePlayer4()
            Case Is > 0
                combatDialogue(Color.Red, GameParty.player4.name & " took " & player4diff & " damage")
                GameParty.updatePlayer4()
        End Select

        Dim player5diff = GameInfo.getPartyMemberHP(5) - GameParty.player5.hppercent
        Select Case player5diff
            Case Is < 0
                combatDialogue(Color.Green, GameParty.player5.name & " restored " & player5diff & " HP")
                GameParty.updatePlayer5()
            Case Is > 0
                combatDialogue(Color.Red, GameParty.player5.name & " took " & player5diff & " damage")
                GameParty.updatePlayer5()
        End Select

    End Sub

    Private Sub refreshGameLabels()
        'get their current destination
        GameForm.DestLbl.Text = GameInfo.getGameDestination

        'get their distance to the destination
        GameForm.TravelBar.Value = GameInfo.getGameDistance

        'set the travel bar to the right max
        GameForm.TravelBar.Maximum = Location.getDistanceTo(GameInfo.getGameDestination, GameInfo.getGameFrom)
    End Sub

    Private Sub refreshAll(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs)
        'MsgBox(e.Name)
        'MsgBox(e.FullPath)

    End Sub


    Private Sub save()
        GameInfo.savePlayer(Character)
    End Sub

    Private Sub combatDialogue(col As Color, txt As String)
        GameForm.CombatTxtBox.SelectionColor = col
        GameForm.CombatTxtBox.SelectedText = txt & vbNewLine
    End Sub
    Private Sub travelDialogue(col As Color, txt As String)
        GameForm.TravelTxtBox.SelectionColor = col
        GameForm.TravelTxtBox.SelectedText = txt & vbNewLine
    End Sub
    Private Sub gameDialogue(txt As String)
        combatDialogue(Color.Orange, txt)
        travelDialogue(Color.Orange, txt)
    End Sub

    Private Sub setupForm()

        GameForm.Text = GameInfo.getGameName

        'get the characters picture
        Select Case Character.type
            Case 1
                GameForm.PictureBox1.Image = Endako_Mines___The_Game.My.Resources.Resources.war
            Case 2
                GameForm.PictureBox1.Image = Endako_Mines___The_Game.My.Resources.Resources.wiz
            Case 3
                GameForm.PictureBox1.Image = Endako_Mines___The_Game.My.Resources.Resources.rgr
            Case 4
                GameForm.PictureBox1.Image = Endako_Mines___The_Game.My.Resources.Resources.clk
        End Select



    End Sub

    Sub Play()
        GameForm.LoadBtn.Enabled = False

        GameInfo.setPlayerFileLoc()
        GameInfo.setGameFileLoc()
        GameInfo.setcombatFileLoc()
        GameInfo.setPartyFileLoc()
        GameInfo.setTravelFileLoc()

        Character = New Player(GameInfo)
        setupForm()

        refreshCharacterLabels()
        refreshGameLabels()

        watcher = New IO.FileSystemWatcher(GameInfo.getShare)
        watcher.EnableRaisingEvents = True
        AddHandler watcher.Changed, AddressOf refreshAll

        'GameParty = New Party(GameInfo)

        gameDialogue("You have joined the game!")

    End Sub
End Class
