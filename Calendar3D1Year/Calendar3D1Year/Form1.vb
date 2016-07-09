Option Strict On
Public Class frmCalendar3D1Year

    Dim gintYear As Integer
    Dim gintCalendar(11, 5, 6) As Integer

    Private Sub subLoadCalendar()
        Dim intFirstDayOfMonth As Integer
        Dim intMonthIndex, intWeekIndex, intDayIndex As Integer
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intDay As Integer

        ' gintYear must be converted here so that the same year gets printed out in subDisplayCalendars
        gintYear = CInt(txtYear.Text)

        intFirstDayOfMonth = CInt(Int((gintYear - 1901) * 365.25 + 2.0)) Mod 7

        If gintYear Mod 4 = 0 Then
            intDaysInMonth(1) = 29
        End If

        For intMonthIndex = 0 To 11
            intDay = 0

            For intWeekIndex = 0 To 5
                For intDayIndex = 0 To 6

                    If intWeekIndex = 0 Then
                        If intDayIndex = intFirstDayOfMonth Then
                            intDay = 1
                        End If
                    End If

                    gintCalendar(intMonthIndex, intWeekIndex, intDayIndex) = intDay

                    If intDay > 0 Then
                        intDay += 1
                        If intDay > intDaysInMonth(intMonthIndex) Then
                            intDay = 0
                        End If
                    End If

                Next intDayIndex
            Next intWeekIndex

            intFirstDayOfMonth = (intFirstDayOfMonth + intDaysInMonth(intMonthIndex)) Mod 7
        Next intMonthIndex

    End Sub

    Private Sub subDisplayCalendars()
        Dim intMonthIndex, intWeekIndex, intDayIndex As Integer
        Dim strMonth() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Dim strWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}

        Console.WriteLine()
        Console.WriteLine(StrDup(28, "-"))
        Console.WriteLine()
        Console.WriteLine("{0,16}", gintYear)

        For intMonthIndex = cmbStartMonth.SelectedIndex To cmbEndMonth.SelectedIndex
            Console.WriteLine()
            Console.WriteLine("{0,16}", strMonth(intMonthIndex))
            Console.WriteLine()

            For intDayIndex = 0 To 6
                Console.Write("{0,4}", strWeek(intDayIndex))
            Next intDayIndex
            Console.WriteLine()

            For intWeekIndex = 0 To 5
                For intDayIndex = 0 To 6

                    Console.Write("{0,4:#}", gintCalendar(intMonthIndex, intWeekIndex, intDayIndex))

                Next intDayIndex

                Console.WriteLine()

            Next intWeekIndex
        Next intMonthIndex

    End Sub

    Private Sub txtYear_GotFocus(sender As Object, e As System.EventArgs) Handles txtYear.GotFocus
        txtYear.SelectAll()
    End Sub

    Private Sub btnLoadYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadYear.Click
        subLoadCalendar()
        cmbStartMonth.Focus()
    End Sub

    Private Sub btnDisplayCalendars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayCalendars.Click
        subDisplayCalendars()
        cmbStartMonth.Focus()
    End Sub
End Class