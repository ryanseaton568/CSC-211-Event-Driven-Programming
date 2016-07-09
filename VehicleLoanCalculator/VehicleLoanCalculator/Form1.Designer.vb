<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAnnualRate = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.radUsed = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of Vehicle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount of Down Payment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Months:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Annual Interest Rate:"
        '
        'lblAnnualRate
        '
        Me.lblAnnualRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualRate.Location = New System.Drawing.Point(473, 72)
        Me.lblAnnualRate.Name = "lblAnnualRate"
        Me.lblAnnualRate.Size = New System.Drawing.Size(68, 22)
        Me.lblAnnualRate.TabIndex = 4
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(151, 23)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 5
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(151, 49)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtDownPayment.TabIndex = 6
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(151, 75)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtMonths.TabIndex = 7
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Checked = True
        Me.radNew.Location = New System.Drawing.Point(26, 32)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(47, 17)
        Me.radNew.TabIndex = 11
        Me.radNew.TabStop = True
        Me.radNew.Text = "New"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'radUsed
        '
        Me.radUsed.AutoSize = True
        Me.radUsed.Location = New System.Drawing.Point(26, 61)
        Me.radUsed.Name = "radUsed"
        Me.radUsed.Size = New System.Drawing.Size(50, 17)
        Me.radUsed.TabIndex = 12
        Me.radUsed.Text = "Used"
        Me.radUsed.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(137, 328)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(262, 328)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(385, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMonths)
        Me.GroupBox1.Controls.Add(Me.txtDownPayment)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 108)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle && Loan Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUsed)
        Me.GroupBox2.Controls.Add(Me.radNew)
        Me.GroupBox2.Location = New System.Drawing.Point(303, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 108)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New or Used?"
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 137)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(556, 23)
        Me.lblMessage.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstOutput)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 158)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interest and Principal Payments"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(6, 16)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(544, 134)
        Me.lstOutput.TabIndex = 0
        '
        'frmLoanCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(580, 363)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAnnualRate)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmLoanCalculator"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAnnualRate As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents radNew As RadioButton
    Friend WithEvents radUsed As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstOutput As ListBox
End Class
