Public Class Form2
    Dim heroDescr As Integer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            lblDescription.Text = "Warlocks are magical warriors that studied the Lightbringer (a large moon like extraterrestial being that brought the Light Force to earth as a gift to mankind). From studying the Lightbringer, Warlock's were able to transfer some of it's magical abilities to themselves and used these abilities in the great war."
        ElseIf ListBox1.SelectedIndex = 1 Then
            lblDescription.Text = "Bounty hunters are sly and sneeky hunters that used there cloaking abilities abilities given by the Lightbringer (a large moon like extraterrestial being that brought the Light Force to earth as a gift to mankind) as a way to earn money by hunting down targets. These hunters were used in the great war to sneak into the aliens bases to get information to use in battle."
        ElseIf ListBox1.SelectedIndex = 2 Then
            lblDescription.Text = "Titans are great warriors that fought in the great war to help turn the tides of the battle. They used there great strength and endurance given by the Lightbringer(a large moon like extraterrestial being that brought the Light Force to earth as a gift to mankind) as key factors in battle. They were able to hold off the enemies for enough time for humans to create a weapon to repel them in a last hope to win the battle.  "
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Form3.Show()
        type = ListBox1.SelectedItem
        HeroName = InputBox("Before we start, what is your name?")
    End Sub
End Class