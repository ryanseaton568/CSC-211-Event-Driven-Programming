Public Class GeneralStudent
    ' Member variables for last name, first name,
    ' and ID number
    Private strLastName As String
    Private strFirstName As String
    Private strIdNum As String

    ' Memeber variables for hours completed
    Private dblMathHours As Double
    Private dblCommHours As Double
    Private dblHumHours As Double
    Private dblElectHours As Double
    Protected dblTotalHours As Double

    ' Constructor to initialize member variables
    Public Sub New()
        strLastName = ("Unknown")
        strFirstName = ("Unknown")
        strIdNum = ("Unknown")
        dblMathHours = 0.0
        dblCommHours = 0.0
        dblHumHours = 0.0
        dblElectHours = 0.0
        dblTotalHours = 0.0
    End Sub

    ' The UpdateHours procedure updates the hours completed.
    Public Overridable Sub UpdateHours()
        dblTotalHours = dblMathHours + dblCommHours + dblHumHours + dblElectHours
    End Sub

    ' Last Name property
    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property

    ' First Name property
    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property

    ' IdNumber property
    Public Property IdNumber() As String
        Get
            Return strIdNum
        End Get
        Set(ByVal value As String)
            strIdNum = value
        End Set
    End Property

    ' MathHours Property
    Public Property MathHours() As Double
        Get
            Return dblMathHours
        End Get
        Set(ByVal value As Double)
            dblMathHours = value
            UpdateHours()
        End Set
    End Property

    ' CommunicationsHours property
    Public Property CommunicationHours() As Double
        Get
            Return dblCommHours
        End Get
        Set(ByVal value As Double)
            dblCommHours = value
            UpdateHours()
        End Set
    End Property

    ' HumanitiesHours property
    Public Property HumanitiesHours() As Double
        Get
            Return dblHumHours
        End Get
        Set(ByVal value As Double)
            dblHumHours = value
            UpdateHours()
        End Set
    End Property

    ' ElectiveHours property
    Public Property ElectiveHours() As Double
        Get
            Return dblElectHours
        End Get
        Set(ByVal value As Double)
            dblElectHours = value
            UpdateHours()
        End Set
    End Property

    ' HoursCompleted property (read-only)
    Public ReadOnly Property HoursCompleted() As Double
        Get
            Return dblTotalHours
        End Get
    End Property

    ' Overridden ToString method
    Public Overrides Function ToString() As String
        Dim str As String
        str = "Name: " & strLastName & ", " &
            strFirstName & " Completed Hours: " &
            dblTotalHours.ToString()
        Return str
    End Function
End Class
