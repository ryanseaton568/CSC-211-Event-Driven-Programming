Option Strict On
Public Class Submarine
    Inherits Boat

    Private mstrAnchorType As String
    Private mintNumberScreenDoors As Integer

    Public Sub New(ByVal bvstrMake As String, ByVal bvintModel As Integer,
                   ByVal bvstrAnchorType As String, ByVal bvintNumberScreenDoors As Integer)
        MyBase.New(bvstrMake, bvintModel)
        subSetNumberScreenDoors(bvintNumberScreenDoors)
        prpAnchorType = bvstrAnchorType
    End Sub

    Public Function funGetNumberScreenDoors() As Integer
        Return mintNumberScreenDoors
    End Function

    Public Sub subSetNumberScreenDoors(ByVal bvstrNumberScreenDoors As Integer)
        mintNumberScreenDoors = bvstrNumberScreenDoors
    End Sub

    Public Property prpAnchorType As String
        Get
            Return mstrAnchorType
        End Get
        Set(ByVal bvstrAnchorType As String)
            mstrAnchorType = bvstrAnchorType
        End Set
    End Property

    Public Overrides Function funReturnClassAttributes() As String
        Return MyBase.funReturnClassAttributes() & ", " & prpAnchorType & ", " & funGetNumberScreenDoors()
    End Function
End Class
