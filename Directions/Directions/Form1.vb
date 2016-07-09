Option Strict On
Public Class frmDirections
    Private Sub btnDisplayDirections_Click(sender As Object, e As EventArgs) Handles btnDisplayDirections.Click
        ' Make the directions visible.
        lblDirections.Visible = Not lblDirections.Visible

        If lblDirections.Visible Then
            btnDisplayDirections.Text = "Hide Directions"
        Else
            btnDisplayDirections.Text = "Display Directions"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
