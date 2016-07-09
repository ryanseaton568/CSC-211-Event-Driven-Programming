﻿Option Strict On
Public Class frmHealthClubMembershipFeeCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBaseFee As Decimal
        Dim decTotalFee As Decimal
        Dim intMonths As Integer
        Dim blnInputOK As Boolean = True

        ' Constants for base fees.
        Const decADULT_FEE As Decimal = 40D
        Const decCHILD_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D

        ' Constants for additional fees.
        Const decYOGA_FEE As Decimal = 10D
        Const decKARATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

        ' Validate and convert the number of months.
        lblStatus.Text = String.Empty
        If Integer.TryParse(txtMonths.Text, intMonths) = False Then
            lblStatus.Text = "Months must be an integer."
            blnInputOK = False
        End If

        ' Validate the number of months.
        If intMonths < 1 Or intMonths > 24 Then
            lblStatus.Text = "Months must be in the range 1 -24."
            blnInputOK = False
        End If

        If blnInputOK = True Then
            ' Determine the base monthly fee.
            If radAdult.Checked = True Then
                decBaseFee = decADULT_FEE
            ElseIf radChild.Checked = True Then
                decBaseFee = decCHILD_FEE
            ElseIf radStudent.Checked = True Then
                decBaseFee = decSTUDENT_FEE
            ElseIf radSenior.Checked = True Then
                decBaseFee = decSENIOR_FEE
            End If

            ' Check for additional services
            If chkYoga.Checked = True Then
                decBaseFee += decYOGA_FEE
            End If

            If chkKarate.Checked = True Then
                decBaseFee += decKARATE_FEE
            End If

            If chkTrainer.Checked = True Then
                decBaseFee += decTRAINER_FEE
            End If

            ' Calculate the total fee.
            decTotalFee = decBaseFee * intMonths

            ' Display the fees.
            lblMonthlyFee.Text = decBaseFee.ToString("c")
            lblTotalFee.Text = decTotalFee.ToString("c")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the Adult radio button.
        radAdult.Checked = True

        ' Clear the check boxes.
        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False

        ' Clear the number of months.
        txtMonths.Clear()

        ' Clear the fee labels.
        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Give txtMonths the focus.
        txtMonths.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the  form.
        Me.Close()
    End Sub

End Class