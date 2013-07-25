Public MustInherit Class Skill

    Protected required_level As Integer
    Protected name As String
    Protected description As String
    Private character As Player

    Protected MustOverride Sub use()

    Protected Sub New()

    End Sub
    Protected Function checkLevel() As Boolean
        Return (character.level >= required_level)
    End Function

    Protected Function getName() As String
        Return name
    End Function

    Protected Function getDescription() As String
        Return description
    End Function

End Class


Public Class SkillA : Inherits Skill

    Sub New()
        name = "SkillA"
    End Sub
    Protected Overrides Sub use()

    End Sub
End Class
Public Class SkillB : Inherits Skill
    Sub New()
        name = "SkillB"
    End Sub
    Protected Overrides Sub use()

    End Sub
End Class
Public Class SkillC : Inherits Skill
    Sub New()
        name = "SkillC"
    End Sub
    Protected Overrides Sub use()

    End Sub
End Class

Public Class Debug : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
Public Class Compile : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
Public Class Defrag : Inherits Skill
    Protected Overrides Sub use()

    End Sub
End Class

Public Class SkillD : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
Public Class SkillE : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
Public Class SkillF : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class


Public Class SkillG : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
Public Class SkillH : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
Public Class SkillI : Inherits Skill

    Protected Overrides Sub use()

    End Sub
End Class
