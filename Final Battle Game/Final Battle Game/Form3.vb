Public Class Form3

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Me.Hide()
        Shop.Show()
    End Sub

    Private Sub btnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
        Me.Hide()
        Battle.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTopHP.Text = hero.HP
        lblTopDefense.Text = hero.Defense
        lblTopOffense.Text = hero.Offense
        lblParryChance.Text = hero.ParryChance
        lblMult.Text = hero.DamageMult
        Label12.Text = coins
        lblEnemiesLeft.Text = 11 - EnemiesDefeated
        If firstTimeDone = False Then
            hero.HP = 50
            hero.Defense = 50
            hero.Offense = 50
            hero.ParryChance = 0.05
            hero.DamageMult = 1.0
            OffenseInc = 0
            firstTimeDone = True
        End If
    End Sub
End Class