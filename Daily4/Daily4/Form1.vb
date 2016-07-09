Option Strict On
Imports System.IO
Public Class frmDaily4
    Dim gintCounts(,), gintSums() As Integer

    Private Sub cmbGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGame.SelectedIndexChanged
        ReDim gintCounts(9, 3), gintSums(36)
        Dim fsrDaily4 = New StreamReader(cmbGame.Text)
        Dim strDailyFour(8) As String
        Dim intColumn As Integer
        Do Until fsrDaily4.EndOfStream
            strDailyFour = Split(fsrDaily4.ReadLine, (","))
            For intColumn = 4 To 7
                gintCounts(CInt(strDailyFour(intColumn)), intColumn - 4) += 1
            Next intColumn
            gintSums(CInt(strDailyFour(8))) += 1
        Loop
        fsrDaily4.Close()
    End Sub

    Private Sub btnDisplayCounts_Click(sender As Object, e As EventArgs) Handles btnDisplayCounts.Click
        Dim intRow, intColumn As Integer
        Console.WriteLine(StrDup(31, "-"))
        Console.WriteLine(cmbGame.Text)
        Console.WriteLine(StrDup(31, "-"))
        For intRow = 0 To 9
            Console.Write("{0,3} - ", intRow)
            For intColumn = 0 To 3
                Console.Write("{0,5}", gintCounts(intRow, intColumn))
            Next intColumn
            Console.WriteLine("{0,5}", gintSums(intRow))
        Next intRow
        For intRow = 10 To 36
            Console.WriteLine("{0,3}{1,2}{2,26}", intRow, "-", gintSums(intRow))
        Next
    End Sub
End Class