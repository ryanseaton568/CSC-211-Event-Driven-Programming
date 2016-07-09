<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorldHungerDonutShop
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
        Me.txtTendered = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbFood = New System.Windows.Forms.GroupBox()
        Me.radDonuts = New System.Windows.Forms.RadioButton()
        Me.radBagels = New System.Windows.Forms.RadioButton()
        Me.radSandwiches = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkCoffee = New System.Windows.Forms.CheckBox()
        Me.nudFoodQuantity = New System.Windows.Forms.NumericUpDown()
        Me.gbFood.SuspendLayout()
        CType(Me.nudFoodQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTendered
        '
        Me.txtTendered.Location = New System.Drawing.Point(198, 202)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Size = New System.Drawing.Size(101, 20)
        Me.txtTendered.TabIndex = 3
        Me.txtTendered.Text = "$0.00"
        Me.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(54, 202)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "$0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Location = New System.Drawing.Point(142, 250)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.ReadOnly = True
        Me.txtChangeDue.Size = New System.Drawing.Size(121, 20)
        Me.txtChangeDue.TabIndex = 3
        Me.txtChangeDue.TabStop = False
        Me.txtChangeDue.Text = "$0.00"
        Me.txtChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(74, 29)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tendered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Change Due:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        '
        'gbFood
        '
        Me.gbFood.Controls.Add(Me.radDonuts)
        Me.gbFood.Controls.Add(Me.radBagels)
        Me.gbFood.Controls.Add(Me.radSandwiches)
        Me.gbFood.Location = New System.Drawing.Point(198, 29)
        Me.gbFood.Name = "gbFood"
        Me.gbFood.Size = New System.Drawing.Size(101, 128)
        Me.gbFood.TabIndex = 2
        Me.gbFood.TabStop = False
        Me.gbFood.Text = "Food"
        '
        'radDonuts
        '
        Me.radDonuts.AutoSize = True
        Me.radDonuts.Location = New System.Drawing.Point(6, 19)
        Me.radDonuts.Name = "radDonuts"
        Me.radDonuts.Size = New System.Drawing.Size(59, 17)
        Me.radDonuts.TabIndex = 12
        Me.radDonuts.TabStop = True
        Me.radDonuts.Text = "Donuts"
        Me.radDonuts.UseVisualStyleBackColor = True
        '
        'radBagels
        '
        Me.radBagels.AutoSize = True
        Me.radBagels.Location = New System.Drawing.Point(6, 54)
        Me.radBagels.Name = "radBagels"
        Me.radBagels.Size = New System.Drawing.Size(57, 17)
        Me.radBagels.TabIndex = 13
        Me.radBagels.TabStop = True
        Me.radBagels.Text = "Bagels"
        Me.radBagels.UseVisualStyleBackColor = True
        '
        'radSandwiches
        '
        Me.radSandwiches.AutoSize = True
        Me.radSandwiches.Location = New System.Drawing.Point(5, 90)
        Me.radSandwiches.Name = "radSandwiches"
        Me.radSandwiches.Size = New System.Drawing.Size(83, 17)
        Me.radSandwiches.TabIndex = 14
        Me.radSandwiches.TabStop = True
        Me.radSandwiches.Text = "Sandwiches"
        Me.radSandwiches.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(41, 296)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(211, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkCoffee
        '
        Me.chkCoffee.AutoSize = True
        Me.chkCoffee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCoffee.Location = New System.Drawing.Point(54, 120)
        Me.chkCoffee.Name = "chkCoffee"
        Me.chkCoffee.Size = New System.Drawing.Size(57, 17)
        Me.chkCoffee.TabIndex = 1
        Me.chkCoffee.Text = "Coffee"
        Me.chkCoffee.UseVisualStyleBackColor = True
        '
        'nudFoodQuantity
        '
        Me.nudFoodQuantity.Location = New System.Drawing.Point(34, 45)
        Me.nudFoodQuantity.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudFoodQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFoodQuantity.Name = "nudFoodQuantity"
        Me.nudFoodQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudFoodQuantity.TabIndex = 0
        Me.nudFoodQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmWorldHungerDonutShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 343)
        Me.Controls.Add(Me.nudFoodQuantity)
        Me.Controls.Add(Me.chkCoffee)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbFood)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtChangeDue)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTendered)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmWorldHungerDonutShop"
        Me.ShowIcon = False
        Me.Text = "World Hunger Donut Shop"
        Me.gbFood.ResumeLayout(False)
        Me.gbFood.PerformLayout()
        CType(Me.nudFoodQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTendered As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtChangeDue As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbFood As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radDonuts As RadioButton
    Friend WithEvents radBagels As RadioButton
    Friend WithEvents radSandwiches As RadioButton
    Friend WithEvents chkCoffee As CheckBox
    Friend WithEvents nudFoodQuantity As NumericUpDown
End Class
