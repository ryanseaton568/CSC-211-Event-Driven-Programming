<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElection
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
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.btnDisplayWinners = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.Location = New System.Drawing.Point(99, 50)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(81, 62)
        Me.btnDisplayAll.TabIndex = 0
        Me.btnDisplayAll.Text = "Display All"
        Me.btnDisplayAll.UseVisualStyleBackColor = True
        '
        'btnDisplayWinners
        '
        Me.btnDisplayWinners.Location = New System.Drawing.Point(99, 141)
        Me.btnDisplayWinners.Name = "btnDisplayWinners"
        Me.btnDisplayWinners.Size = New System.Drawing.Size(81, 62)
        Me.btnDisplayWinners.TabIndex = 1
        Me.btnDisplayWinners.Text = "Display Winners"
        Me.btnDisplayWinners.UseVisualStyleBackColor = True
        '
        'frmElection
        '
        Me.AcceptButton = Me.btnDisplayAll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDisplayWinners)
        Me.Controls.Add(Me.btnDisplayAll)
        Me.Name = "frmElection"
        Me.ShowIcon = False
        Me.Text = "Election"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnDisplayWinners As Button
End Class
