<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBagelHouse
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.radRegCoffee = New System.Windows.Forms.RadioButton()
        Me.radRegCappuccino = New System.Windows.Forms.RadioButton()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.lblSubtotal = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWhite)
        Me.GroupBox1.Controls.Add(Me.radWheat)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Bagel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radNoCoffee)
        Me.GroupBox2.Controls.Add(Me.radRegCoffee)
        Me.GroupBox2.Controls.Add(Me.radRegCappuccino)
        Me.GroupBox2.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 144)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Want Coffee with That?"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox3.Controls.Add(Me.chkButter)
        Me.GroupBox3.Controls.Add(Me.chkBlueberry)
        Me.GroupBox3.Controls.Add(Me.chkRaspberry)
        Me.GroupBox3.Controls.Add(Me.chkPeach)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pick Your Toppings"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Location = New System.Drawing.Point(253, 235)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Location = New System.Drawing.Point(6, 31)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(89, 17)
        Me.radWhite.TabIndex = 1
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White ($1.25)"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(6, 54)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(127, 17)
        Me.radWheat.TabIndex = 2
        Me.radWheat.TabStop = True
        Me.radWheat.Text = "Whole Wheat ($1.50)"
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(22, 31)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(51, 17)
        Me.radNoCoffee.TabIndex = 3
        Me.radNoCoffee.TabStop = True
        Me.radNoCoffee.Text = "None"
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'radRegCoffee
        '
        Me.radRegCoffee.AutoSize = True
        Me.radRegCoffee.Location = New System.Drawing.Point(22, 54)
        Me.radRegCoffee.Name = "radRegCoffee"
        Me.radRegCoffee.Size = New System.Drawing.Size(129, 17)
        Me.radRegCoffee.TabIndex = 4
        Me.radRegCoffee.TabStop = True
        Me.radRegCoffee.Text = "Regular Cofee ($1.25)"
        Me.radRegCoffee.UseVisualStyleBackColor = True
        '
        'radRegCappuccino
        '
        Me.radRegCappuccino.AutoSize = True
        Me.radRegCappuccino.Location = New System.Drawing.Point(22, 77)
        Me.radRegCappuccino.Name = "radRegCappuccino"
        Me.radRegCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radRegCappuccino.TabIndex = 5
        Me.radRegCappuccino.TabStop = True
        Me.radRegCappuccino.Text = "Cappuccino ($2.00)"
        Me.radRegCappuccino.UseVisualStyleBackColor = True
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(22, 100)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(114, 17)
        Me.radCafeAuLait.TabIndex = 6
        Me.radCafeAuLait.TabStop = True
        Me.radCafeAuLait.Text = "Cafe au lait ($1.75)"
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(6, 27)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(125, 17)
        Me.chkCreamCheese.TabIndex = 7
        Me.chkCreamCheese.Text = "Cream Cheese ($.50)"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(6, 50)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(84, 17)
        Me.chkButter.TabIndex = 8
        Me.chkButter.Text = "Butter ($.25)"
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(6, 73)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(122, 17)
        Me.chkBlueberry.TabIndex = 9
        Me.chkBlueberry.Text = "Blueberry Jam ($.75)"
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(6, 96)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(126, 17)
        Me.chkRaspberry.TabIndex = 10
        Me.chkRaspberry.Text = "Raspberry Jam ($.75)"
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(6, 119)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(110, 17)
        Me.chkPeach.TabIndex = 11
        Me.chkPeach.Text = "Peach Jelly ($.75)"
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Location = New System.Drawing.Point(95, 17)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.ReadOnly = True
        Me.lblSubtotal.Size = New System.Drawing.Size(72, 20)
        Me.lblSubtotal.TabIndex = 12
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(95, 43)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.ReadOnly = True
        Me.lblTax.Size = New System.Drawing.Size(72, 20)
        Me.lblTax.TabIndex = 13
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(95, 69)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.ReadOnly = True
        Me.lblTotal.Size = New System.Drawing.Size(72, 20)
        Me.lblTotal.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(28, 341)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(130, 23)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "&Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(181, 341)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(130, 23)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(331, 341)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Brandi's Bagel House"
        '
        'frmBagelHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 371)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBagelHouse"
        Me.Text = "Bagel and Coffee Price Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents radWheat As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radNoCoffee As RadioButton
    Friend WithEvents radRegCoffee As RadioButton
    Friend WithEvents radRegCappuccino As RadioButton
    Friend WithEvents radCafeAuLait As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents chkButter As CheckBox
    Friend WithEvents chkBlueberry As CheckBox
    Friend WithEvents chkRaspberry As CheckBox
    Friend WithEvents chkPeach As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubtotal As TextBox
    Friend WithEvents lblTax As TextBox
    Friend WithEvents lblTotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
End Class
