Option Strict On
Public Class frmWorldHungerDonutShop

    Dim gdecTotal, gdecTendered, gdecFood, gdecCoffee As Decimal
    Private Sub subCalculateTotal()
        txtTotal.Text = Format(nudFoodQuantity.Value * (gdecFood + gdecCoffee), "C")
        subCalculateChangeDue()
    End Sub
    Private Sub subCalculateChangeDue()
        'txtChangeDue.Text = Format(txtTotal.Text - gdecTendered, "C")
        txtChangeDue.Text = Format((nudFoodQuantity.Value * (gdecFood + gdecCoffee)) - gdecTendered, "C")
    End Sub
    Private Sub nudFoodQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudFoodQuantity.ValueChanged
        If nudFoodQuantity.Focused Then
            subCalculateChangeDue()
            subCalculateTotal()
        End If
    End Sub

    Private Sub chkCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoffee.CheckedChanged
        If chkCoffee.Checked Then
            gdecCoffee = 4D
        Else
            gdecCoffee = 0D
        End If
        subCalculateChangeDue()
        subCalculateTotal()
    End Sub

    Private Sub radDonuts_CheckedChanged(sender As Object, e As EventArgs) Handles radDonuts.CheckedChanged
        If radDonuts.Checked Then
            gdecFood = 1D
            subCalculateTotal()
            subCalculateChangeDue()
        End If
    End Sub

    Private Sub radBagels_CheckedChanged(sender As Object, e As EventArgs) Handles radBagels.CheckedChanged
        If radBagels.Checked Then
            gdecFood = 2D
            subCalculateTotal()
            subCalculateChangeDue()
        End If
    End Sub

    Private Sub radSandwiches_CheckedChanged(sender As Object, e As EventArgs) Handles radSandwiches.CheckedChanged
        If radSandwiches.Checked Then
            gdecFood = 3D
            subCalculateTotal()
            subCalculateChangeDue()
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        If txtTendered.Focused Then
            gdecTendered = CDec(txtTendered.Text)
            subCalculateChangeDue()
        End If
    End Sub

    Private Sub txtChangeDue_TextChanged(sender As Object, e As EventArgs) Handles txtChangeDue.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets the controls
        nudFoodQuantity.Value = 1
        chkCoffee.Checked = False
        radDonuts.Checked = True
        radDonuts.TabStop = True
        txtTendered.Text = "$0.00"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
