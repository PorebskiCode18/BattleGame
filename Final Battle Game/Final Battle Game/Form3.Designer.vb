<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnBattle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTopHP = New System.Windows.Forms.Label()
        Me.lblTopDefense = New System.Windows.Forms.Label()
        Me.lblTopOffense = New System.Windows.Forms.Label()
        Me.lblParryChance = New System.Windows.Forms.Label()
        Me.lblMult = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEnemiesLeft = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBattle
        '
        Me.btnBattle.Location = New System.Drawing.Point(626, 387)
        Me.btnBattle.Name = "btnBattle"
        Me.btnBattle.Size = New System.Drawing.Size(162, 51)
        Me.btnBattle.TabIndex = 0
        Me.btnBattle.Text = "Begin next battle"
        Me.btnBattle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label4.Location = New System.Drawing.Point(302, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 79)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fate"
        '
        'btnShop
        '
        Me.btnShop.Location = New System.Drawing.Point(12, 388)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(165, 50)
        Me.btnShop.TabIndex = 5
        Me.btnShop.Text = "Click to go to shop"
        Me.btnShop.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "HP:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(452, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 258)
        Me.Label3.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PowderBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 265)
        Me.Label5.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.PowderBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(470, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Defense:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.PowderBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(470, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Offense:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.PowderBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(470, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Parry Chance:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.PowderBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(550, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 31)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Current Stats"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.PowderBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(470, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 31)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Damage Multiplier:"
        '
        'lblTopHP
        '
        Me.lblTopHP.BackColor = System.Drawing.Color.PowderBlue
        Me.lblTopHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopHP.Location = New System.Drawing.Point(514, 158)
        Me.lblTopHP.Name = "lblTopHP"
        Me.lblTopHP.Size = New System.Drawing.Size(88, 27)
        Me.lblTopHP.TabIndex = 17
        Me.lblTopHP.Text = "100"
        '
        'lblTopDefense
        '
        Me.lblTopDefense.BackColor = System.Drawing.Color.PowderBlue
        Me.lblTopDefense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopDefense.Location = New System.Drawing.Point(564, 189)
        Me.lblTopDefense.Name = "lblTopDefense"
        Me.lblTopDefense.Size = New System.Drawing.Size(88, 27)
        Me.lblTopDefense.TabIndex = 18
        Me.lblTopDefense.Text = "100"
        '
        'lblTopOffense
        '
        Me.lblTopOffense.BackColor = System.Drawing.Color.PowderBlue
        Me.lblTopOffense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopOffense.Location = New System.Drawing.Point(564, 220)
        Me.lblTopOffense.Name = "lblTopOffense"
        Me.lblTopOffense.Size = New System.Drawing.Size(88, 27)
        Me.lblTopOffense.TabIndex = 19
        Me.lblTopOffense.Text = "100"
        '
        'lblParryChance
        '
        Me.lblParryChance.BackColor = System.Drawing.Color.PowderBlue
        Me.lblParryChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParryChance.Location = New System.Drawing.Point(616, 252)
        Me.lblParryChance.Name = "lblParryChance"
        Me.lblParryChance.Size = New System.Drawing.Size(88, 27)
        Me.lblParryChance.TabIndex = 20
        Me.lblParryChance.Text = "5%"
        '
        'lblMult
        '
        Me.lblMult.BackColor = System.Drawing.Color.PowderBlue
        Me.lblMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMult.Location = New System.Drawing.Point(631, 282)
        Me.lblMult.Name = "lblMult"
        Me.lblMult.Size = New System.Drawing.Size(88, 27)
        Me.lblMult.TabIndex = 21
        Me.lblMult.Text = "x1.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(366, 390)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 33)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Coins:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(468, 391)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 33)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enemies Left:"
        '
        'lblEnemiesLeft
        '
        Me.lblEnemiesLeft.AutoSize = True
        Me.lblEnemiesLeft.BackColor = System.Drawing.Color.PowderBlue
        Me.lblEnemiesLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemiesLeft.Location = New System.Drawing.Point(25, 164)
        Me.lblEnemiesLeft.Name = "lblEnemiesLeft"
        Me.lblEnemiesLeft.Size = New System.Drawing.Size(36, 25)
        Me.lblEnemiesLeft.TabIndex = 25
        Me.lblEnemiesLeft.Text = "11"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEnemiesLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblMult)
        Me.Controls.Add(Me.lblParryChance)
        Me.Controls.Add(Me.lblTopOffense)
        Me.Controls.Add(Me.lblTopDefense)
        Me.Controls.Add(Me.lblTopHP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBattle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBattle As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShop As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTopHP As Label
    Friend WithEvents lblTopDefense As Label
    Friend WithEvents lblTopOffense As Label
    Friend WithEvents lblParryChance As Label
    Friend WithEvents lblMult As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEnemiesLeft As Label
End Class
