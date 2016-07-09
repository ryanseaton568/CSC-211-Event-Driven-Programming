Option Strict On
Imports System.IO
Public Class frmElection
    Dim gstrCandidate(9, 5) As String
    Dim gintVoteCount(9, 5) As Integer
    Dim gintAbstained(5), gintVoted(5) As Integer
    Private Function funFindCandidate(ByVal bvstrCandidate As String, ByVal bvintOffice As Integer) As Integer
        Dim intRow As Integer
        For intRow = 0 To 9
            If gstrCandidate(intRow, bvintOffice) = bvstrCandidate Then
                Return intRow
            ElseIf gstrCandidate(intRow, bvintOffice) = "" Then
                gstrCandidate(intRow, bvintOffice) = bvstrCandidate
                Return intRow
            End If
        Next intRow
        ' The End Function will generate a warning because it's possible that this function might never return a value.
        ' Can you see why the If statement might not return a value?
    End Function
    Private Sub subReadFileLoadArrays()
        Dim fsrVotes = New StreamReader("Election.csv")
        Dim strVote(5) As String
        Dim intRow, intColumn As Integer
        Do Until fsrVotes.EndOfStream
            strVote = Split(fsrVotes.ReadLine, ",")
            For intColumn = 0 To 5
                If strVote(intColumn) <> "" Then
                    intRow = funFindCandidate(strVote(intColumn), intColumn)
                    gintVoteCount(intRow, intColumn) += 1
                    gintVoted(intColumn) += 1
                Else
                    gintAbstained(intColumn) += 1
                End If
            Next intColumn
        Loop
        fsrVotes.Close()
    End Sub
    Private Sub subDisplay(ByVal bvDisplayAll As Boolean)
        Dim intRow, intColumn, intBase(5) As Integer
        Dim blnContinue As Boolean
        Dim strVotes As String
        Console.WriteLine()
        If bvDisplayAll Then
            Console.WriteLine(StrDup(70, "-"))
            For intColumn = 0 To 5
                Console.Write("{0,4} - {1,3} ", gintAbstained(intColumn), gintVoted(intColumn))
                intBase(intColumn) = 1
            Next intColumn
            Console.WriteLine()
        Else
            For intColumn = 0 To 5
                intBase(intColumn) = gintVoteCount(0, intColumn)
            Next intColumn
        End If
        Console.WriteLine(StrDup(70, "-"))
        blnContinue = True
        intRow = 0
        Do While blnContinue
            blnContinue = False
            strVotes = ""
            For intColumn = 0 To 5
                If gintVoteCount(intRow, intColumn) >= intBase(intColumn) Then
                    strVotes += String.Format("{0,4} - {1,3} ",
                   gstrCandidate(intRow, intColumn), gintVoteCount(intRow, intColumn))
                    blnContinue = True
                Else
                    strVotes += StrDup(12, " ")
                End If
            Next intColumn
            If blnContinue Then
                Console.WriteLine(strVotes)
                intRow += 1
            End If
        Loop
        Console.WriteLine(StrDup(70, "="))
    End Sub
    Private Sub subSwapCandidateName(ByVal bvintUpperRow As Integer, ByVal bvintLowerRow As Integer, ByVal bvintColumn As Integer)
        Dim strCandidateTemp As String
        strCandidateTemp = gstrCandidate(bvintUpperRow, bvintColumn)
        gstrCandidate(bvintUpperRow, bvintColumn) = gstrCandidate(bvintLowerRow, bvintColumn)
        gstrCandidate(bvintLowerRow, bvintColumn) = strCandidateTemp
    End Sub
    Private Sub subSortArrays()
        Dim intUpperRow, intLowerRow, intColumn, intCountTemp As Integer
        For intUpperRow = 0 To 9 - 1
            For intLowerRow = intUpperRow + 1 To 9
                For intColumn = 0 To 5
                    If gintVoteCount(intUpperRow, intColumn) < gintVoteCount(intLowerRow, intColumn) Then
                        intCountTemp = gintVoteCount(intUpperRow, intColumn)
                        gintVoteCount(intUpperRow, intColumn) = gintVoteCount(intLowerRow, intColumn)
                        gintVoteCount(intLowerRow, intColumn) = intCountTemp
                        subSwapCandidateName(intUpperRow, intLowerRow, intColumn)
                    ElseIf gintVoteCount(intUpperRow, intColumn) = gintVoteCount(intLowerRow, intColumn) Then
                        If gstrCandidate(intUpperRow, intColumn) > gstrCandidate(intLowerRow, intColumn) Then
                            subSwapCandidateName(intUpperRow, intLowerRow, intColumn)
                        End If
                    End If
                Next intColumn
            Next intLowerRow
        Next intUpperRow
    End Sub
    Private Sub frmElection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReadFileLoadArrays()
        Console.WriteLine("{0,41}", "Before Sort")
        subDisplay(True)
        subSortArrays()
        Console.WriteLine()
        Console.WriteLine("{0,41}", "After Sort")
    End Sub
    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        subDisplay(True)
    End Sub
    Private Sub btnDisplayWinners_Click(sender As Object, e As EventArgs) Handles btnDisplayWinners.Click
        subDisplay(False)
    End Sub
End Class