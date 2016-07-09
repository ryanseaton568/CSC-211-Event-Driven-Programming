<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStateSalesTaxCalculatorVisible
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtTaxDue = New System.Windows.Forms.TextBox()
        Me.nudTaxRate = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tax Due:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(142, 50)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 3
        Me.txtSales.Text = "0.00"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxDue
        '
        Me.txtTaxDue.Location = New System.Drawing.Point(142, 102)
        Me.txtTaxDue.Name = "txtTaxDue"
        Me.txtTaxDue.ReadOnly = True
        Me.txtTaxDue.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxDue.TabIndex = 4
        Me.txtTaxDue.Text = "$0.00"
        Me.txtTaxDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudTaxRate
        '
        Me.nudTaxRate.DecimalPlaces = 2
        Me.nudTaxRate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nudTaxRate.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudTaxRate.Location = New System.Drawing.Point(142, 76)
        Me.nudTaxRate.Name = "nudTaxRate"
        Me.nudTaxRate.ReadOnly = True
        Me.nudTaxRate.Size = New System.Drawing.Size(120, 20)
        Me.nudTaxRate.TabIndex = 5
        Me.nudTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTaxRate.Value = New Decimal(New Integer() {825, 0, 0, 131072})
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(49, 217)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        Me.btnCalculate.Visible = False
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(142, 217)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'frmStateSalesTaxCalculatorVisible
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.nudTaxRate)
        Me.Controls.Add(Me.txtTaxDue)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStateSalesTaxCalculatorVisible"
        Me.ShowIcon = False
        Me.Text = "State Sales Tax Calculator Visiblew"
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtTaxDue As TextBox
    Friend WithEvents nudTaxRate As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
End Class
