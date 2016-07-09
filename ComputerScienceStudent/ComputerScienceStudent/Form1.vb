Public Class frmComputerScienceStudent
    ' The GetData procedure assigns values from the form
    ' to a CsStudent object's properties.
    Private Sub GetData(ByVal objCsStudent As CsStudent)
        Try
            ' Get name and ID number
            objCsStudent.LastName = txtLastName.Text
            objCsStudent.FirstName = txtFirstName.Text
            objCsStudent.IdNumber = txtIdNumber.Text

            ' Get housr
            objCsStudent.MathHours = CDbl(txtMath.Text)
            objCsStudent.CommunicationHours = CDbl(txtComm.Text)
            objCsStudent.HumanitiesHours = CDbl(txtHum.Text)
            objCsStudent.ElectiveHours = CDbl(txtElect.Text)
            objCsStudent.CompSciHours = CDbl(txtCompSci.Text)
        Catch ex As Exception
            ' Error message
            MessageBox.Show("Enter valid numeric values for all hours.")
        End Try
    End Sub

    'The ClearForm procuedure clears the form.
    Private Sub ClearForm()
        ' Clear the text boxes.
        txtLastName.Clear()
        txtFirstName.Clear()
        txtIdNumber.Clear()
        txtMath.Clear()
        txtComm.Clear()
        txtHum.Clear()
        txtElect.Clear()
        txtCompSci.Clear()

        ' Set the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Create an instance of the CsStudent class.
        Dim objCsStudent As New CsStudent

        ' Get data from the form.
        GetData(objCsStudent)

        ' Add the CsStudent object to the collection.
        AddStudent(objCsStudent)

        ' Clear the form.
        ClearForm()

        ' Display a confirmation message
        MessageBox.Show("Student record added successfully")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Create an instance of the DisplayForm form.
        Dim frmDisplay As New DisplayForm

        ' Display the form
        frmDisplay.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
