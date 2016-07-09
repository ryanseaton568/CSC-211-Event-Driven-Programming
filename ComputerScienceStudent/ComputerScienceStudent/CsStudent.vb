Public Class CsStudent
    Inherits GeneralStudent

    ' Member variable for CS hours completed
    Private dblCompSciHours As Double

    ' Constuctor
    Public Sub New()
        dblCompSciHours = 0.0
    End Sub

    ' Overridden UpdateHours method
    Public Overrides Sub UpdateHours()
        MyBase.UpdateHours()
        MyBase.UpdateHours()
        dblTotalHours += dblCompSciHours
    End Sub

    ' CompSciHours property
    Public Property CompSciHours() As Double
        Get
            Return dblCompSciHours
        End Get
        Set(ByVal value As Double)
            dblCompSciHours = value
            UpdateHours()
        End Set
    End Property
End Class
