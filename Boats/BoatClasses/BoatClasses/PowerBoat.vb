Option Strict On

Public Class PowerBoat
    Inherits Boat

    Private mintNumberEngines As Integer
    Private mstrFuelType As String

    Public Sub New(ByVal bvstrMake As String, ByVal bvintModel As Integer, ByVal bvintNumberEngines As Integer, ByVal bvstrFuelType As String)
        MyBase.New(bvstrMake, bvintModel)
        subSetNumberEngines(bvintNumberEngines)
        prpFuelType = bvstrFuelType
    End Sub

    Public Function funGetNumberEngines() As Integer
        Return mintNumberEngines
    End Function

    Public Sub subSetNumberEngines(ByVal bvintNumberEngines As Integer)
        mintNumberEngines = bvintNumberEngines
    End Sub

    Public Property prpFuelType As String
        Get
            Return mstrFuelType
        End Get
        Set(bvstrFuelType As String)
            If bvstrFuelType = "diesel" Then
                bvstrFuelType = "diesel"
            End If
            mstrFuelType = bvstrFuelType
        End Set
    End Property

    Public Overrides Function funReturnClassAttributes() As String
        Return MyBase.funReturnClassAttributes() & ", " & funGetNumberEngines() & ", " & prpFuelType
    End Function
End Class
