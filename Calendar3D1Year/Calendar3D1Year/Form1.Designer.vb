<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar3D1Year
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
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnLoadYear = New System.Windows.Forms.Button()
        Me.btnDisplayCalendars = New System.Windows.Forms.Button()
        Me.cmbStartMonth = New System.Windows.Forms.ComboBox()
        Me.cmbEndMonth = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Year:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Start Month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "End Month:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(106, 12)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(75, 20)
        Me.txtYear.TabIndex = 0
        '
        'btnLoadYear
        '
        Me.btnLoadYear.Location = New System.Drawing.Point(106, 50)
        Me.btnLoadYear.Name = "btnLoadYear"
        Me.btnLoadYear.Size = New System.Drawing.Size(75, 52)
        Me.btnLoadYear.TabIndex = 6
        Me.btnLoadYear.TabStop = False
        Me.btnLoadYear.Text = "Load Calendar"
        Me.btnLoadYear.UseVisualStyleBackColor = True
        '
        'btnDisplayCalendars
        '
        Me.btnDisplayCalendars.Location = New System.Drawing.Point(106, 197)
        Me.btnDisplayCalendars.Name = "btnDisplayCalendars"
        Me.btnDisplayCalendars.Size = New System.Drawing.Size(75, 53)
        Me.btnDisplayCalendars.TabIndex = 3
        Me.btnDisplayCalendars.Text = "Display Month(s)"
        Me.btnDisplayCalendars.UseVisualStyleBackColor = True
        '
        'cmbStartMonth
        '
        Me.cmbStartMonth.FormattingEnabled = True
        Me.cmbStartMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Nov", "Dec"})
        Me.cmbStartMonth.Location = New System.Drawing.Point(106, 122)
        Me.cmbStartMonth.Name = "cmbStartMonth"
        Me.cmbStartMonth.Size = New System.Drawing.Size(75, 21)
        Me.cmbStartMonth.TabIndex = 1
        '
        'cmbEndMonth
        '
        Me.cmbEndMonth.FormattingEnabled = True
        Me.cmbEndMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Nov", "Dec"})
        Me.cmbEndMonth.Location = New System.Drawing.Point(106, 156)
        Me.cmbEndMonth.Name = "cmbEndMonth"
        Me.cmbEndMonth.Size = New System.Drawing.Size(75, 21)
        Me.cmbEndMonth.TabIndex = 2
        '
        'frmCalendar3D1Year
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmbEndMonth)
        Me.Controls.Add(Me.cmbStartMonth)
        Me.Controls.Add(Me.btnDisplayCalendars)
        Me.Controls.Add(Me.btnLoadYear)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalendar3D1Year"
        Me.ShowIcon = False
        Me.Text = "Calendar3D1Year"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnLoadYear As Button
    Friend WithEvents btnDisplayCalendars As Button
    Friend WithEvents cmbStartMonth As ComboBox
    Friend WithEvents cmbEndMonth As ComboBox
End Class
