<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDaily4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbGame = New System.Windows.Forms.ComboBox()
        Me.btnDisplayCounts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbGame
        '
        Me.cmbGame.FormattingEnabled = True
        Me.cmbGame.Items.AddRange(New Object() {"Daily4Morning.csv", "Daily4Day.csv", "Daily4Evening.csv", "Daily4Night.csv"})
        Me.cmbGame.Location = New System.Drawing.Point(83, 23)
        Me.cmbGame.Name = "cmbGame"
        Me.cmbGame.Size = New System.Drawing.Size(121, 21)
        Me.cmbGame.TabIndex = 0
        '
        'btnDisplayCounts
        '
        Me.btnDisplayCounts.Location = New System.Drawing.Point(103, 64)
        Me.btnDisplayCounts.Name = "btnDisplayCounts"
        Me.btnDisplayCounts.Size = New System.Drawing.Size(80, 43)
        Me.btnDisplayCounts.TabIndex = 1
        Me.btnDisplayCounts.Text = "Display Counts"
        Me.btnDisplayCounts.UseVisualStyleBackColor = True
        '
        'frmDaily4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 132)
        Me.Controls.Add(Me.btnDisplayCounts)
        Me.Controls.Add(Me.cmbGame)
        Me.Name = "frmDaily4"
        Me.Text = "Daily 4 - Joseph Seaton"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbGame As ComboBox
    Friend WithEvents btnDisplayCounts As Button
End Class
