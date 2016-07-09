Option Strict On
Imports System.IO
Imports BoatClasses

Public Class frmBoatApplication

    Dim gobjBoat(10) As Boat
    Dim gobjPowerBoat(10) As PowerBoat
    Dim gobjSailBoat(10) As SailBoat

    Dim gintBoat As Integer = -1
    Dim gintPowerBoat As Integer = -1
    Dim gintSailBoat As Integer = -1

    Private Sub subReadFileAndLoadArray()
        Dim fsrBoats = New StreamReader("Boats.csv")
        Dim strRecord(4) As String

        Do Until fsrBoats.EndOfStream
            strRecord = Split(fsrBoats.ReadLine, ",")

            Select Case strRecord(0)
                Case "b"
                    gintBoat += 1
                    gobjBoat(gintBoat) = New Boat(strRecord(1), CInt(strRecord(2)))
                Case "p"
                    gintPowerBoat += 1
                    gobjPowerBoat(gintPowerBoat) = New PowerBoat(strRecord(1), CInt(strRecord(2)), CInt(strRecord(3)), strRecord(4))
                Case "s"
                    gintSailBoat += 1
                    gobjSailBoat(gintSailBoat) = New SailBoat(strRecord(1), CInt(strRecord(2)), CInt(strRecord(3)), strRecord(4))
            End Select
        Loop
    End Sub

    Private Sub subPrintArray()
        Dim intRow As Integer

        Console.WriteLine()
        Console.WriteLine("Boat")
        Console.WriteLine(StrDup(Len("Boat"), "-"))

        For intRow = 0 To gintBoat
            Console.WriteLine(gobjBoat(intRow).funReturnClassAttributes)
        Next intRow

        Console.WriteLine()
        Console.WriteLine("PowerBoat")
        Console.WriteLine(StrDup(Len("PowerBoat"), "-"))

        For intRow = 0 To gintPowerBoat
            Console.WriteLine(gobjPowerBoat(intRow).funReturnClassAttributes)
        Next intRow

        Console.WriteLine()
        Console.WriteLine("SailBoat")
        Console.WriteLine(StrDup(Len("SailBoat"), "-"))

        For intRow = 0 To gintSailBoat
            Console.WriteLine(gobjSailBoat(intRow).funReturnClassAttributes)
        Next intRow
    End Sub

    Private Sub frmBoatApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReadFileAndLoadArray()
    End Sub

    Private Sub btnPrintBoats_Click(sender As Object, e As EventArgs) Handles btnPrintBoats.Click
        subPrintArray()
    End Sub
End Class
