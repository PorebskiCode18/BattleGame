<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblEnemyDM = New System.Windows.Forms.Label()
        Me.lblEnemyParryChance = New System.Windows.Forms.Label()
        Me.lblEnemyOffense = New System.Windows.Forms.Label()
        Me.lblEnemyDefense = New System.Windows.Forms.Label()
        Me.lblEnemyHP = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHeroDM = New System.Windows.Forms.Label()
        Me.lblHeroParryChance = New System.Windows.Forms.Label()
        Me.lblHeroOffense = New System.Windows.Forms.Label()
        Me.lblHeroDefense = New System.Windows.Forms.Label()
        Me.lblHeroHP = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBattle = New System.Windows.Forms.Button()
        Me.lblHeroName = New System.Windows.Forms.Label()
        Me.lblEnemyName = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeroDamage = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEnemyDamage = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnemyDM
        '
        Me.lblEnemyDM.BackColor = System.Drawing.Color.LightSalmon
        Me.lblEnemyDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyDM.Location = New System.Drawing.Point(652, 311)
        Me.lblEnemyDM.Name = "lblEnemyDM"
        Me.lblEnemyDM.Size = New System.Drawing.Size(88, 27)
        Me.lblEnemyDM.TabIndex = 31
        Me.lblEnemyDM.Text = "x1.00"
        '
        'lblEnemyParryChance
        '
        Me.lblEnemyParryChance.BackColor = System.Drawing.Color.LightSalmon
        Me.lblEnemyParryChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyParryChance.Location = New System.Drawing.Point(637, 282)
        Me.lblEnemyParryChance.Name = "lblEnemyParryChance"
        Me.lblEnemyParryChance.Size = New System.Drawing.Size(88, 27)
        Me.lblEnemyParryChance.TabIndex = 30
        Me.lblEnemyParryChance.Text = "0%"
        '
        'lblEnemyOffense
        '
        Me.lblEnemyOffense.BackColor = System.Drawing.Color.LightSalmon
        Me.lblEnemyOffense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyOffense.Location = New System.Drawing.Point(585, 249)
        Me.lblEnemyOffense.Name = "lblEnemyOffense"
        Me.lblEnemyOffense.Size = New System.Drawing.Size(88, 27)
        Me.lblEnemyOffense.TabIndex = 29
        Me.lblEnemyOffense.Text = "0"
        '
        'lblEnemyDefense
        '
        Me.lblEnemyDefense.BackColor = System.Drawing.Color.LightSalmon
        Me.lblEnemyDefense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyDefense.Location = New System.Drawing.Point(585, 218)
        Me.lblEnemyDefense.Name = "lblEnemyDefense"
        Me.lblEnemyDefense.Size = New System.Drawing.Size(88, 27)
        Me.lblEnemyDefense.TabIndex = 28
        Me.lblEnemyDefense.Text = "0"
        '
        'lblEnemyHP
        '
        Me.lblEnemyHP.BackColor = System.Drawing.Color.LightSalmon
        Me.lblEnemyHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyHP.Location = New System.Drawing.Point(535, 187)
        Me.lblEnemyHP.Name = "lblEnemyHP"
        Me.lblEnemyHP.Size = New System.Drawing.Size(88, 27)
        Me.lblEnemyHP.TabIndex = 27
        Me.lblEnemyHP.Text = "0"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightSalmon
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(491, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 31)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Damage Multiplier:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSalmon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(491, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 31)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Parry Chance:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightSalmon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(491, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 31)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Offense:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSalmon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(491, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 31)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Defense:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSalmon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(491, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "HP:"
        '
        'lblHeroDM
        '
        Me.lblHeroDM.BackColor = System.Drawing.Color.LightSalmon
        Me.lblHeroDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroDM.Location = New System.Drawing.Point(250, 311)
        Me.lblHeroDM.Name = "lblHeroDM"
        Me.lblHeroDM.Size = New System.Drawing.Size(88, 27)
        Me.lblHeroDM.TabIndex = 41
        Me.lblHeroDM.Text = "x1.00"
        '
        'lblHeroParryChance
        '
        Me.lblHeroParryChance.BackColor = System.Drawing.Color.LightSalmon
        Me.lblHeroParryChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroParryChance.Location = New System.Drawing.Point(235, 281)
        Me.lblHeroParryChance.Name = "lblHeroParryChance"
        Me.lblHeroParryChance.Size = New System.Drawing.Size(88, 27)
        Me.lblHeroParryChance.TabIndex = 40
        Me.lblHeroParryChance.Text = "5%"
        '
        'lblHeroOffense
        '
        Me.lblHeroOffense.BackColor = System.Drawing.Color.LightSalmon
        Me.lblHeroOffense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroOffense.Location = New System.Drawing.Point(183, 249)
        Me.lblHeroOffense.Name = "lblHeroOffense"
        Me.lblHeroOffense.Size = New System.Drawing.Size(88, 27)
        Me.lblHeroOffense.TabIndex = 39
        Me.lblHeroOffense.Text = "100"
        '
        'lblHeroDefense
        '
        Me.lblHeroDefense.BackColor = System.Drawing.Color.LightSalmon
        Me.lblHeroDefense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroDefense.Location = New System.Drawing.Point(183, 218)
        Me.lblHeroDefense.Name = "lblHeroDefense"
        Me.lblHeroDefense.Size = New System.Drawing.Size(88, 27)
        Me.lblHeroDefense.TabIndex = 38
        Me.lblHeroDefense.Text = "100"
        '
        'lblHeroHP
        '
        Me.lblHeroHP.BackColor = System.Drawing.Color.LightSalmon
        Me.lblHeroHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroHP.Location = New System.Drawing.Point(133, 187)
        Me.lblHeroHP.Name = "lblHeroHP"
        Me.lblHeroHP.Size = New System.Drawing.Size(88, 27)
        Me.lblHeroHP.TabIndex = 37
        Me.lblHeroHP.Text = "100"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.LightSalmon
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(89, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(234, 31)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Damage Multiplier:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.LightSalmon
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(89, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 31)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Parry Chance:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightSalmon
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(89, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 31)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Offense:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSalmon
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(89, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 31)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Defense:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightSalmon
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(89, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 31)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "HP:"
        '
        'btnBattle
        '
        Me.btnBattle.Location = New System.Drawing.Point(301, 361)
        Me.btnBattle.Name = "btnBattle"
        Me.btnBattle.Size = New System.Drawing.Size(177, 43)
        Me.btnBattle.TabIndex = 42
        Me.btnBattle.Text = "Battle"
        Me.btnBattle.UseVisualStyleBackColor = True
        '
        'lblHeroName
        '
        Me.lblHeroName.AutoSize = True
        Me.lblHeroName.Font = New System.Drawing.Font("Script MT Bold", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroName.Location = New System.Drawing.Point(87, 123)
        Me.lblHeroName.Name = "lblHeroName"
        Me.lblHeroName.Size = New System.Drawing.Size(163, 38)
        Me.lblHeroName.TabIndex = 43
        Me.lblHeroName.Text = "HeroName"
        '
        'lblEnemyName
        '
        Me.lblEnemyName.AutoSize = True
        Me.lblEnemyName.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyName.Location = New System.Drawing.Point(489, 124)
        Me.lblEnemyName.Name = "lblEnemyName"
        Me.lblEnemyName.Size = New System.Drawing.Size(181, 38)
        Me.lblEnemyName.TabIndex = 44
        Me.lblEnemyName.Text = "EnemyName"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(330, 218)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 57)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "V.S."
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSalmon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Damage Done:"
        '
        'lblHeroDamage
        '
        Me.lblHeroDamage.BackColor = System.Drawing.Color.LightSalmon
        Me.lblHeroDamage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroDamage.Location = New System.Drawing.Point(182, 373)
        Me.lblHeroDamage.Name = "lblHeroDamage"
        Me.lblHeroDamage.Size = New System.Drawing.Size(52, 31)
        Me.lblHeroDamage.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSalmon
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 31)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Damage Done:"
        '
        'lblEnemyDamage
        '
        Me.lblEnemyDamage.BackColor = System.Drawing.Color.LightSalmon
        Me.lblEnemyDamage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyDamage.Location = New System.Drawing.Point(651, 373)
        Me.lblEnemyDamage.Name = "lblEnemyDamage"
        Me.lblEnemyDamage.Size = New System.Drawing.Size(52, 31)
        Me.lblEnemyDamage.TabIndex = 51
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(69, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(230, 40)
        Me.ProgressBar1.TabIndex = 52
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(462, 49)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(230, 40)
        Me.ProgressBar2.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 35)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Return Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Battle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblEnemyDamage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHeroDamage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblEnemyName)
        Me.Controls.Add(Me.lblHeroName)
        Me.Controls.Add(Me.btnBattle)
        Me.Controls.Add(Me.lblHeroDM)
        Me.Controls.Add(Me.lblHeroParryChance)
        Me.Controls.Add(Me.lblHeroOffense)
        Me.Controls.Add(Me.lblHeroDefense)
        Me.Controls.Add(Me.lblHeroHP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblEnemyDM)
        Me.Controls.Add(Me.lblEnemyParryChance)
        Me.Controls.Add(Me.lblEnemyOffense)
        Me.Controls.Add(Me.lblEnemyDefense)
        Me.Controls.Add(Me.lblEnemyHP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Battle"
        Me.Text = "Battle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnemyDM As Label
    Friend WithEvents lblEnemyParryChance As Label
    Friend WithEvents lblEnemyOffense As Label
    Friend WithEvents lblEnemyDefense As Label
    Friend WithEvents lblEnemyHP As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHeroDM As Label
    Friend WithEvents lblHeroParryChance As Label
    Friend WithEvents lblHeroOffense As Label
    Friend WithEvents lblHeroDefense As Label
    Friend WithEvents lblHeroHP As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBattle As Button
    Friend WithEvents lblHeroName As Label
    Friend WithEvents lblEnemyName As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeroDamage As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEnemyDamage As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Button1 As Button
End Class
