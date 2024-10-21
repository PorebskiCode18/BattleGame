Public Class Battle
    Dim enemyNames(11) As String
    Dim enemyDefeated As Boolean
    Dim rnum As New Random
    Dim Pnum As Integer
    Dim DMnum As Double
    Dim currentHeroHP As Integer
    Dim currentEnemyHP As Integer
    Dim loseHeroHP As Integer
    Dim loseEnemyHP As Integer
    Dim Enemyparry As Boolean
    Dim Heroparry As Boolean
    Dim EnemyDM As Double
    Dim heroDM As Double
    Dim totalLoseHP As Integer

    Private Sub Battle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeroHP.Text = hero.HP
        lblHeroDefense.Text = hero.Defense
        lblHeroOffense.Text = hero.Offense
        lblHeroParryChance.Text = hero.ParryChance
        lblHeroDM.Text = "x" & hero.DamageMult
        enemyDefeated = False
        Enemyparry = False
        Heroparry = False
        EnemyDM = 1
        heroDM = 1

        enemyNames = {"Fallen Warrior", "Vex Warrior", "Hive Warrior", "Cabal Warrior", "Fallen Captain", "Vex Captain", "Hive Captain", "Cabal Captain", "Oryx 'Fallen King'", "Savathun 'Hive Queen'", "Eye of a Thousand Souls"}
        setStats()
        ProgressBar1.Maximum = hero.HP
        ProgressBar2.Maximum = enemy(enemyNum).HP
        ProgressBar1.Value = hero.HP
        ProgressBar2.Value = enemy(enemyNum).HP
        lblEnemyName.Text = enemyNames(enemyNum)
        lblHeroName.Text = HeroName
        Button1.Hide()
    End Sub

    Private Sub btnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
        Timer1.Start()
    End Sub
    Public Sub setStats()
        currentHeroHP = hero.HP
        enemy(0).HP = rnum.Next(50, 101)
        enemy(1).HP = rnum.Next(100, 151)
        enemy(2).HP = rnum.Next(150, 201)
        enemy(3).HP = rnum.Next(200, 251)
        enemy(4).HP = rnum.Next(350, 401)
        enemy(5).HP = rnum.Next(400, 451)
        enemy(6).HP = rnum.Next(450, 501)
        enemy(7).HP = rnum.Next(500, 551)
        enemy(8).HP = rnum.Next(700, 801)
        enemy(9).HP = rnum.Next(800, 901)
        enemy(10).HP = rnum.Next(900, 1001)
        enemy(0).Defense = rnum.Next(50, 101)
        enemy(1).Defense = rnum.Next(150, 201)
        enemy(2).Defense = rnum.Next(250, 301)
        enemy(3).Defense = rnum.Next(350, 401)
        enemy(4).Defense = rnum.Next(500, 551)
        enemy(5).Defense = rnum.Next(550, 601)
        enemy(6).Defense = rnum.Next(600, 651)
        enemy(7).Defense = rnum.Next(650, 701)
        enemy(8).Defense = rnum.Next(900, 1001)
        enemy(9).Defense = rnum.Next(1000, 1201)
        enemy(10).Defense = rnum.Next(1300, 1501)
        enemy(0).Offense = rnum.Next(50, 101)
        enemy(1).Offense = rnum.Next(100, 151)
        enemy(2).Offense = rnum.Next(150, 201)
        enemy(3).Offense = rnum.Next(200, 251)
        enemy(4).Offense = rnum.Next(350, 401)
        enemy(5).Offense = rnum.Next(400, 451)
        enemy(6).Offense = rnum.Next(450, 501)
        enemy(7).Offense = rnum.Next(500, 551)
        enemy(8).Offense = rnum.Next(700, 801)
        enemy(9).Offense = rnum.Next(800, 901)
        enemy(10).Offense = rnum.Next(900, 1001)
        enemy(0).ParryChance = 0.05
        enemy(1).ParryChance = 0.07
        enemy(2).ParryChance = 0.08
        enemy(3).ParryChance = 0.09
        enemy(4).ParryChance = 0.15
        enemy(5).ParryChance = 0.18
        enemy(6).ParryChance = 0.2
        enemy(7).ParryChance = 0.22
        enemy(8).ParryChance = 0.3
        enemy(9).ParryChance = 0.4
        enemy(10).ParryChance = 0.5
        currentEnemyHP = enemy(enemyNum).HP
        enemy(enemyNum).DamageMult = 1.0
        lblEnemyHP.Text = enemy(enemyNum).HP
        lblEnemyDefense.Text = enemy(enemyNum).Defense
        lblEnemyOffense.Text = enemy(enemyNum).Offense
        lblEnemyParryChance.Text = enemy(enemyNum).ParryChance
        lblEnemyDM.Text = "x" & enemy(enemyNum).DamageMult
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loseHeroHP = 0
        loseEnemyHP = 0
        Pnum = rnum.Next(0, 101)
        If Pnum <= enemy(enemyNum).ParryChance * 100 Then
            Enemyparry = True

        End If
        Pnum = rnum.Next(0, 101)
        If Pnum <= hero.ParryChance * 100 Then
            Heroparry = True

        End If
        If Enemyparry = False Then
            loseEnemyHP = (hero.Offense * (hero.Offense / (enemy(enemyNum).Defense * 30))) * heroDM
            lblHeroDamage.Text = loseEnemyHP
            totalLoseHP = totalLoseHP + loseEnemyHP
        Else
            Enemyparry = False
        End If
        If Heroparry = False Then
            loseHeroHP = (enemy(enemyNum).Offense * (enemy(enemyNum).Offense / (hero.Defense * 30))) * EnemyDM
            lblEnemyDamage.Text = loseHeroHP

        Else
            Heroparry = False
        End If

        DMnum = rnum.Next(1, 3.01)
        If loseEnemyHP > loseHeroHP Then
            EnemyDM = (EnemyDM + loseEnemyHP / 100) * DMnum
        End If
        If loseHeroHP >= loseEnemyHP Then
            heroDM = (heroDM + loseHeroHP / 100) * DMnum
        End If
        lblEnemyDM.Text = "x" & EnemyDM
        lblHeroDM.Text = "x" & heroDM
        currentHeroHP = currentHeroHP - loseHeroHP
        currentEnemyHP = currentEnemyHP - loseEnemyHP
        lblHeroHP.Text = currentHeroHP
        lblEnemyHP.Text = currentEnemyHP
        If currentHeroHP <= 0 Then
            Timer1.Stop()
            currentHeroHP = 0
            lblHeroHP.Text = 0
            coins = coins + totalLoseHP
            MsgBox(coins)
            Button1.Show()
        End If
        If currentEnemyHP <= 0 Then
            Timer1.Stop()
            currentEnemyHP = 0
            lblEnemyHP.Text = 0
            enemyDefeated = True
            If currentHeroHP > 0 Then
                coins = coins + totalLoseHP
            End If
            Button1.Show()
            EnemiesDefeated = EnemiesDefeated + 1
        End If
        ProgressBar1.Value = currentHeroHP
        ProgressBar2.Value = currentEnemyHP
        If enemyDefeated = True Then
            enemyNum = enemyNum + 1
            enemyDefeated = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class