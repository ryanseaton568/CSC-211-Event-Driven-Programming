Option Strict On

Public Class Boat

    Private mstrMake As String
    Private mintModel As Integer

    Public Sub New(ByVal bvstrMake As String, ByVal bvintModel As Integer)
        subSetMake(bvstrMake)
        prpModel = bvintModel
    End Sub

    Public Function funGetMake() As String
        Return mstrMake
    End Function

    Public Sub subSetMake(ByVal bvstrMake As String)
        mstrMake = bvstrMake
    End Sub

    Public Property prpModel As Integer
        Get
            Return mintModel
        End Get
        Set(ByVal bvintModel As Integer)
            mintModel = bvintModel
        End Set
    End Property

    Public Overridable Function funReturnClassAttributes() As String
        Return (funGetMake() & ", " & prpModel)
    End Function

End Class
