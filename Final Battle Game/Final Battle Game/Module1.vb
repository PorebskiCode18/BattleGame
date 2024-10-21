Module Module1
    Public Structure battleStats

        Public HP As Integer
        Public Defense As Integer
        Public Offense As Integer
        Public ParryChance As Double
        Public DamageMult As Double
    End Structure
    Public hero As battleStats
    Public enemy(10) As battleStats
    Public enemyNum As Integer
    Public coins As Integer
    Public type As String
    Public HeroName As String
    Public firstTimeDone As Boolean
    Public OffenseInc As Integer
    Public DefenseInc As Integer
    Public ParryInc As Integer
    Public HPInc As Integer
    Public EnemiesDefeated As Integer
End Module
