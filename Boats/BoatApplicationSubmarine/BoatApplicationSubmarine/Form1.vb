Option Strict On
Imports BoatClasses

Public Class frmSubApp


    ' Joseph Seaton



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSubmarine = New Submarine("GE", 2015, "Plow", 5)
        Console.WriteLine(objSubmarine.funReturnClassAttributes)
    End Sub
End Class
