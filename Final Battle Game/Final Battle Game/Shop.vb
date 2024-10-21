Public Class Shop
    Dim WeaponCost As Integer
    Dim ArmorCost As Integer
    Dim TrainingCost As Integer

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type = "Warlock" Then
            ListBox1.Items.Add("Leather Gloves")
            ListBox1.Items.Add("Silver Gloves")
            ListBox1.Items.Add("Gold Gloves")
            ListBox1.Items.Add("Emerald Gloves")
            ListBox1.Items.Add("Diamond Gloves")
            ListBox2.Items.Add("Leather Robes")
            ListBox2.Items.Add("Silver-laced Robes")
            ListBox2.Items.Add("Gold-laced Robes")
            ListBox2.Items.Add("Emerald-laced Robes")
            ListBox2.Items.Add("Diamond-laced Robes")
        ElseIf type = "Bounty Hunter" Then
            ListBox1.Items.Add("Slingshot")
            ListBox1.Items.Add("Wooden Bullet Sniper")
            ListBox1.Items.Add("Metal Bullet Sniper")
            ListBox1.Items.Add("Fire Bullet Sniper")
            ListBox1.Items.Add("Diamond Bullet Sniper")
            ListBox2.Items.Add("Leather Armor")
            ListBox2.Items.Add("Leather/Metal Patched Armor")
            ListBox2.Items.Add("Metal Armor")
            ListBox2.Items.Add("Full Body Metal Armor")
            ListBox2.Items.Add("Force Shield Armor")
        ElseIf type = "Titan" Then
            ListBox1.Items.Add("Wooden Dagger")
            ListBox1.Items.Add("Wooden Sword")
            ListBox1.Items.Add("Metal Dagger")
            ListBox1.Items.Add("Metal Sword")
            ListBox1.Items.Add("Excalibur Sword")
            ListBox2.Items.Add("Leather Armor")
            ListBox2.Items.Add("Leather/Metal Patched Armor")
            ListBox2.Items.Add("Metal Armor")
            ListBox2.Items.Add("Full Body Metal Armor")
            ListBox2.Items.Add("Force Shield Armor")
        End If
        ListBox3.Items.Add("Offense Training")
        ListBox3.Items.Add("Defense Training")
        ListBox3.Items.Add("Parry Training")
        ListBox3.Items.Add("HP Training")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            lblWeaponCost.Text = "200 coins"
            WeaponCost = 200
            lblOffenseIncrease.Text = "+200"
            OffenseInc = 200
        ElseIf ListBox1.SelectedIndex = 1 Then
            lblWeaponCost.Text = "500 coins"
            WeaponCost = 500
            lblOffenseIncrease.Text = "+400"
            OffenseInc = 400
        ElseIf ListBox1.SelectedIndex = 2 Then
            lblWeaponCost.Text = "800 coins"
            WeaponCost = 800
            lblOffenseIncrease.Text = "+600"
            OffenseInc = 600
        ElseIf ListBox1.SelectedIndex = 3 Then
            lblWeaponCost.Text = "1200 coins"
            WeaponCost = 1200
            lblOffenseIncrease.Text = "+800"
            OffenseInc = 800
        ElseIf ListBox1.SelectedIndex = 4 Then
            lblWeaponCost.Text = "2000 coins"
            WeaponCost = 2000
            lblOffenseIncrease.Text = "+1000"
            OffenseInc = 1000
        End If
        If ListBox2.SelectedIndex = 0 Then
            lblArmorCost.Text = "200 coins"
            ArmorCost = 200
            lblDefenseInc.Text = "+200"
            DefenseInc = 200
        ElseIf ListBox2.SelectedIndex = 1 Then
            lblArmorCost.Text = "500 coins"
            ArmorCost = 500
            lblDefenseInc.Text = "+400"
            OffenseInc = 400
        ElseIf ListBox2.SelectedIndex = 2 Then
            lblArmorCost.Text = "800 coins"
            ArmorCost = 800
            lblDefenseInc.Text = "+600"
            OffenseInc = 600
        ElseIf ListBox2.SelectedIndex = 3 Then
            lblArmorCost.Text = "1200 coins"
            ArmorCost = 1200
            lblDefenseInc.Text = "+800"
            OffenseInc = 800
        ElseIf ListBox2.SelectedIndex = 4 Then
            lblArmorCost.Text = "2000 coins"
            ArmorCost = 2000
            lblDefenseInc.Text = "+1000"
            OffenseInc = 1000
        End If
        If ListBox3.SelectedIndex = 0 Then
            lblTrainingCost.Text = "700 coins"
            TrainingCost = 700
            lblTrainingInc.Text = "+100"
            OffenseInc = 100
        ElseIf ListBox3.SelectedIndex = 1 Then
            lblTrainingCost.Text = "700 coins"
            TrainingCost = 700
            lblTrainingInc.Text = "+100"
            DefenseInc = 100
        ElseIf ListBox3.SelectedIndex = 2 Then
            lblTrainingCost.Text = "500 coins"
            TrainingCost = 500
            lblTrainingInc.Text = "+.05%"
            ParryInc = 0.05
        ElseIf ListBox3.SelectedIndex = 3 Then
            lblTrainingCost.Text = "500 coins"
            TrainingCost = 500
            lblTrainingInc.Text = "+50"
            HPInc = 50
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If coins >= WeaponCost Then
            coins = coins - WeaponCost
            hero.Offense = hero.Offense + OffenseInc
        Else
            MsgBox("Not enough coins")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If coins >= ArmorCost Then
            coins = coins - ArmorCost
            hero.Defense = hero.Defense + DefenseInc
        Else
            MsgBox("Not enough coins")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If coins >= TrainingCost Then
            coins = coins - TrainingCost
            If ListBox3.SelectedIndex = 0 Then
                hero.Offense = hero.Offense + OffenseInc
            ElseIf ListBox3.SelectedIndex = 1 Then
                hero.Defense = hero.Defense + DefenseInc
            ElseIf ListBox3.SelectedIndex = 2 Then
                hero.ParryChance = hero.ParryChance + ParryInc
            ElseIf ListBox3.SelectedIndex = 3 Then
                hero.HP = hero.HP + HPInc
            End If
        Else
            MsgBox("Not enough coins")
        End If
    End Sub
End Class