Module CompSciStudentModule
    ' Collection for computer science students
    Public csStudentCollection As New Collection

    ' The AddStudent procudure adds a CsStudent object
    ' to the collection and uses the IdNumber property
    ' as the key.

    Public Sub AddStudent(ByVal objCsStudent As CsStudent)
        Try
            csStudentCollection.Add(objCsStudent, objCsStudent.IdNumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
