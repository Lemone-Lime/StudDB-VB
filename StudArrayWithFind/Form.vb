Public Class Form
#Region "Initialisation - Setting variables"
    'set up a record or "class" for a student
    Class Student
        Public firstName As String
        Public lastName As String
        Public DOB As Date
        Public gender As String
        Public avMk As Single
        Public phoneNo As String
        Public paid As Boolean
    End Class


    Dim invalidColour As Color
    Dim validColour As Color

    'valid name variables
    Dim validFirstName As Boolean
    Dim validLastName As Boolean


    'valid dob
    Dim validDOB As Boolean

    'valid gender variables
    Dim validOther As Boolean
    Dim validGender As Boolean
    Dim myGender As String

    'valid mark
    Dim validAvMk As Boolean

    'valid phone number
    Dim validPhoneNo As Boolean


    Dim students(9) As Student
    Dim studentCount As Integer = 0
#End Region
#Region "Form Load Subroutine"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        validDOB = True
        invalidColour = Color.IndianRed
        validColour = SystemColors.Window

        For i = 0 To 9
            students(i) = New Student
        Next
        LoadTestRecords()
    End Sub
#End Region
#Region "Validate Names When Changed"
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged, txtFirstName.Leave
        If (Trim(txtFirstName.Text) = "") Then
            validFirstName = False
            btnAddStud.Enabled = False
            txtFirstName.BackColor = invalidColour
        Else
            validFirstName = True
            txtFirstName.BackColor = validColour
            CheckComplete()
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged, txtLastName.Leave
        If (Trim(txtLastName.Text) = "") Then
            validLastName = False
            btnAddStud.Enabled = False
            txtLastName.BackColor = invalidColour
        Else
            validLastName = True
            txtLastName.BackColor = validColour
            CheckComplete()
        End If
    End Sub
#End Region
#Region "Validate DOB"
    Private Sub txtDOB_ValueChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged
        If Not (txtDOB.Text >= #1/1/1960# AndAlso txtDOB.Text < #1/1/2010#) Then
            txtDOB.CalendarMonthBackground = invalidColour
            validDOB = False
            btnAddStud.Enabled = False
        Else
            txtDOB.CalendarMonthBackground = validColour
            validDOB = True
            CheckComplete()
        End If
    End Sub
#End Region
#Region "Validate Gender"
    Private Sub btnMale_CheckedChanged(sender As Object, e As EventArgs) Handles btnMale.CheckedChanged
        If (btnMale.Checked) Then
            validGender = True
            myGender = "Male"
            CheckComplete()
        End If
    End Sub

    Private Sub btnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles btnFemale.CheckedChanged
        If (btnFemale.Checked) Then
            validGender = True
            myGender = "Female"
            CheckComplete()
        End If
    End Sub

    Private Sub btnOther_CheckedChanged(sender As Object, e As EventArgs) Handles btnOther.CheckedChanged
        If (btnOther.Checked) Then
            If (txtOther.Text <> "") Then
                validGender = True
                myGender = txtOther.Text
                CheckComplete()
            Else
                validGender = False
                btnAddStud.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtOther_TextChanged(sender As Object, e As EventArgs) Handles txtOther.TextChanged, txtOther.Leave
        If (btnOther.Checked And txtOther.Text <> "") Then
            validGender = True
            txtOther.BackColor = validColour
            myGender = txtOther.Text
            CheckComplete()
        Else
            txtOther.BackColor = invalidColour
            btnAddStud.Enabled = False
            validGender = False
        End If
    End Sub
#End Region
#Region "Validate Average Mark"
    Private Sub txtAvMk_TextChanged(sender As Object, e As EventArgs) Handles txtAvMk.TextChanged, txtAvMk.Leave
        If (Not IsNumeric(txtAvMk.Text)) Then
            validAvMk = False
            btnAddStud.Enabled = False
            txtAvMk.BackColor = invalidColour
        ElseIf (txtAvMk.Text < 0) Or (txtAvMk.Text > 100) Then
            validAvMk = False
            btnAddStud.Enabled = False
            txtAvMk.BackColor = invalidColour
        Else
            validAvMk = True
            txtAvMk.BackColor = validColour
            CheckComplete()
        End If
    End Sub
#End Region
#Region "Validate Phone Number"
    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged, txtPhone.Leave
        If Not Len(Trim(txtPhone.Text)) = 12 Then
            txtPhone.BackColor = invalidColour
            btnAddStud.Enabled = False
            validPhoneNo = False
        Else
            txtPhone.BackColor = validColour
            validPhoneNo = True
            CheckComplete()
        End If
    End Sub
#End Region
#Region "Add Student Button"
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstName = txtFirstName.Text
        students(studentCount).lastName = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = myGender
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).paid = chkPaid.Checked
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = #1/01/2003#
        txtOther.Text = ""
        btnMale.Checked = False
        btnFemale.Checked = False
        btnOther.Checked = False
        txtAvMk.Text = ""
        txtPhone.Text = ""
        chkPaid.Checked = False

        'change colours back to default
        txtFirstName.BackColor = validColour
        txtLastName.BackColor = validColour
        txtDOB.CalendarTitleBackColor = validColour
        txtOther.BackColor = validColour
        txtAvMk.BackColor = validColour
        txtPhone.BackColor = validColour

        btnMale.BackColor = Color.Transparent
        btnFemale.BackColor = Color.Transparent
        btnOther.BackColor = Color.Transparent

        'make the add student button unusable
        btnAddStud.Enabled = False

        UpdateList()
    End Sub
#End Region
#Region "Load Test Records"
    Private Sub LoadTestRecords()
        students(0).firstName = "Johnny"
        students(0).lastName = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "Male"
        students(0).avMk = 78.2
        students(0).phoneNo = "0123456789"
        students(0).paid = False
        students(1).firstName = "Jennifer"
        students(1).lastName = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "Female"
        students(1).avMk = 88.2
        students(1).phoneNo = "0191845969"
        students(1).paid = False
        students(2).firstName = "George"
        students(2).lastName = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "Male"
        students(2).avMk = 68.2
        students(2).phoneNo = "0466589232"
        students(2).paid = True
        students(3).firstName = "Scarlett"
        students(3).lastName = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "Female"
        students(3).avMk = 72.2
        students(3).phoneNo = "0487950382"
        students(3).paid = False
        students(4).firstName = "Toe"
        students(4).lastName = "Fungus"
        students(4).DOB = "23/03/69"
        students(4).gender = "Female"
        students(4).avMk = 26.5
        students(4).phoneNo = "0291758928"
        students(4).paid = True
        studentCount = 5
        UpdateList()
    End Sub
#End Region
#Region "Update List"
    Private Sub UpdateList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            lstStud.Items.Add(students(i).firstName & " - " & students(i).lastName & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " & students(i).avMk &
                              " - " & students(i).phoneNo & " - " & students(i).paid & ".")
        Next
    End Sub
#End Region
#Region "Check if Complete"
    Private Sub CheckComplete()
        If (validFirstName And validLastName And validDOB And validGender And validAvMk And validPhoneNo) Then
            btnAddStud.Enabled = True
        Else
            btnAddStud.Enabled = False
        End If
    End Sub
#End Region
End Class
