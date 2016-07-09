Public Class DisplayForm
    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Declare an object variable that can reference
        ' a CsStudent object.
        Dim objCsStudent As CsStudent

        'Get each object in the collection and add its 
        ' data to the list box.
        For Each objCsStudent In csStudentCollection
            lstStudents.Items.Add(objCsStudent.ToString())
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class