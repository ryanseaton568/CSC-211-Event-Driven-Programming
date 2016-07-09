Option Strict On
Public Class frmStateSalesTaxCalculatorVisible
    Private Sub subReset()
        txtSales.Text = "0.00"
        nudTaxRate.Value = 8.25D
        txtTaxDue.Text = "$0.00"
        btnCalculate.Visible = False
        btnReset.Visible = False
        txtSales.Focus()
        txtSales.SelectAll()
    End Sub

    Private Sub frmStateSalesTaxCalculatorVisible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReset()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        If txtSales.Focused Then
            btnCalculate.Visible = True
            btnReset.Visible = True
        End If
    End Sub

    Private Sub txtSales_LostFocus(sender As Object, e As EventArgs) Handles txtSales.LostFocus
        txtSales.Text = Format(txtSales.Text, "Standard")
    End Sub

    Private Sub nudTaxRate_ValueChanged(sender As Object, e As EventArgs) Handles nudTaxRate.ValueChanged
        btnCalculate.Visible = True
        btnReset.Visible = True
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtTaxDue.Text = Format(CDec("0" & txtSales.Text) * nudTaxRate.Value / 100, "Currency")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub
End Class
