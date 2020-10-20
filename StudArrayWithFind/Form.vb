Public Class Form
    'set up a record or "class" for a student
    Class Student
        Public firstName As String
        Public lastName As String
        Public DOB As Date
        Public gender As Char
        Public avMk As Single
    End Class
    Dim students(9) As Student
    Dim studentCount As Integer = 0

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New Student
        Next
        LoadTestRecords()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstName = txtFirstName.Text
        students(studentCount).lastName = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = txtGender.Text
        students(studentCount).avMk = txtAvMk.Text
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        txtGender.Text = ""
        txtAvMk.Text = ""
        UpdateList()
    End Sub

    Private Sub LoadTestRecords()
        students(0).firstName = "Johnny"
        students(0).lastName = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "m"
        students(0).avMk = 78.2
        students(1).firstName = "Jennifer"
        students(1).lastName = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "f"
        students(1).avMk = 88.2
        students(2).firstName = "George"
        students(2).lastName = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "m"
        students(2).avMk = 68.2
        students(3).firstName = "Scarlett"
        students(3).lastName = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "f"
        students(3).avMk = 72.2
        students(4).firstName = "Big"
        students(4).lastName = "Chungus"
        students(4).DOB = "23/03/69"
        students(4).gender = "f"
        students(4).avMk = 26.5
        studentCount = 5
        UpdateList()
    End Sub

    Private Sub UpdateList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            lstStud.Items.Add(students(i).firstName & " - " & students(i).lastName & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " & students(i).avMk & ".")
        Next
    End Sub

End Class
