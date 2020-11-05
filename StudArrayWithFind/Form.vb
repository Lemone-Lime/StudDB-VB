Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

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
        Public matches As Boolean

        Public Sub New(f As String, l As String, d As Date, g As String, am As Single, pn As String, p As Boolean)
            firstName = f
            lastName = l
            DOB = d
            gender = g
            avMk = am
            phoneNo = pn
            paid = p
        End Sub
    End Class

    Dim invalidColour As Color
    Dim validColour As Color

    'valid name variables
    Dim validFirstName As Boolean = False
    Dim validLastName As Boolean = False

    'valid dob
    Dim validDOB As Boolean = True

    'valid gender variables
    Dim validGender As Boolean = False
    Dim myGender As String = ""

    'valid mark
    Dim validAvMk As Boolean = False

    'valid phone number
    Dim validPhoneNo As Boolean = False

    Dim students As List(Of Student)
    Dim chkPaidAltered As Boolean = False
    Const myPath As String = "C:\Users\yhall\OneDrive - NSW Department of Education\Yr11\SDD\VB\V01-StudentDatabase\StudArrayWithFind\Storage\Data"

#End Region
#Region "Form Load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        invalidColour = Color.IndianRed
        validColour = SystemColors.Window
        txtAvMk.SetBounds(txtAvMk.Location.X, txtAvMk.Location.Y, 99, txtAvMk.Height)
        txtPhoneNo.Mask = "0000-000-000"
        txtPhoneNo.Text = ""
        txtPhoneNo.BackColor = validColour
        students = New List(Of Student)

        LoadTestRecords()
    End Sub
#End Region
#Region "Form Closing Event"
    Private Sub Form_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim boi = MessageBox.Show("Do you want to save your progress first?", "Save Progress?", MessageBoxButtons.YesNoCancel)
        If (boi = DialogResult.Yes) Then
            Serialise()
            MessageBox.Show("Saved Database", "Saved!", MessageBoxButtons.OK)
        ElseIf boi = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub
#End Region
#Region "Update Names"
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged, txtFirstName.Leave
        If (rbAdd.Checked) Then
            ValidateFirstName()
        Else
            UpdateFind()
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged, txtLastName.Leave
        If (rbAdd.Checked) Then
            ValidateLastName()
        Else
            UpdateFind()
        End If
    End Sub
#End Region
#Region "Update Average Mark"
    Private Sub txtAvMk_TextChanged(sender As Object, e As EventArgs) Handles txtAvMk.TextChanged, txtAvMk.Leave
        If (rbAdd.Checked) Then
            ValidateAvMk()
        Else
            UpdateFind()
        End If
    End Sub
#End Region
#Region "Update DOB"
    Private Sub txtDOB_ValueChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged
        If (rbAdd.Checked) Then
            ValidateDOB()
        Else
            UpdateFind()
        End If
    End Sub
#End Region
#Region "Update Gender"
    Private Sub btnGender_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged, rbFemale.CheckedChanged, rbOther.CheckedChanged
        If (rbAdd.Checked) Then
            ValidateGender()
        Else
            If (rbMale.Checked) Then
                myGender = "Male"
            ElseIf rbFemale.Checked Then
                myGender = "Female"
            Else
                myGender = txtOther.Text
            End If

            UpdateFind()
        End If
    End Sub
    Private Sub txtOther_TextChanged(sender As Object, e As EventArgs) Handles txtOther.TextChanged, txtOther.Leave
        If (rbAdd.Checked) Then
            ValidateOther()
        Else
            If (rbOther.Checked) Then
                myGender = txtOther.Text
                UpdateFind()
            End If
        End If
    End Sub
#End Region
#Region "Update Phone Number"
    Private Sub txtPhoneNo_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNo.TextChanged, txtPhoneNo.Leave
        If (rbAdd.Checked) Then
            ValidatePhone()
        Else
            UpdateFind()
        End If
    End Sub
#End Region
#Region "Update Greater Lesser Buttons"
    Private Sub rbGreater_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreater.CheckedChanged
        UpdateFind()
    End Sub
#End Region
#Region "Update Other Buttons"
    Private Sub btnAccess_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdd.CheckedChanged
        If (rbAdd.Checked) Then
            btnAddStud.Visible = True

            rbGreater.Visible = False
            rbLesser.Visible = False
            rbAfter.Visible = False
            rbBefore.Visible = False

            txtAvMk.SetBounds(txtAvMk.Location.X, txtAvMk.Location.Y, 99, txtAvMk.Height)

            gbList.Text = "List of Entered Students"

            If (txtFirstName.Text <> "") Then
                ValidateFirstName()
            End If
            If (txtLastName.Text <> "") Then
                ValidateLastName()
            End If
            If (txtAvMk.Text <> "") Then
                ValidateAvMk()
            End If
            If (txtPhoneNo.Text <> "    -   -") Then
                ValidatePhone()
            End If

            CheckComplete()
        Else
            btnAddStud.Visible = False

            rbGreater.Visible = True
            rbLesser.Visible = True
            rbAfter.Visible = True
            rbBefore.Visible = True

            txtAvMk.SetBounds(txtAvMk.Location.X, txtAvMk.Location.Y, 64, txtAvMk.Height)

            'change colours back to default
            txtFirstName.BackColor = validColour
            txtLastName.BackColor = validColour
            txtDOB.CalendarTitleBackColor = validColour
            txtOther.BackColor = validColour
            txtAvMk.BackColor = validColour
            txtPhoneNo.BackColor = validColour

            gbList.Text = "Sorted List of Students"

            UpdateFind()
        End If
    End Sub
    Private Sub chkPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaid.CheckedChanged
        If (rbFind.Checked) Then
            chkPaidAltered = True
            UpdateFind()
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
#End Region
#Region "Add Student Button"
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students.Add(New Student(txtFirstName.Text, txtLastName.Text, txtDOB.Text, myGender, txtAvMk.Text, txtPhoneNo.Text, chkPaid.Checked))

        ResetForm()
        UpdateList()
    End Sub
#End Region
#Region "Load Test Records"
    Private Sub LoadTestRecords()
        students.Add(New Student("Johnny", "Depp", "9/6/63", "Male", 78.2, "0123456789", False))
        students.Add(New Student("Jennifer", "Lawrence", "15/8/90", "Female", 88.2, "0191845969", False))
        students.Add(New Student("George", "Clooney", "6/5/61", "Male", 68.2, "0191845969", True))
        students.Add(New Student("Scarlett", "Johansson", "22/11/84", "Female", 72.2, "0487950382", False))

        UpdateList()
    End Sub
#End Region
#Region "Validate"
    Private Sub ValidateFirstName()
        If Trim(txtFirstName.Text) = "" Or Regex.IsMatch(txtFirstName.Text, "[^a-zA-Z\-\s\']") Then
            validFirstName = False
            btnAddStud.Enabled = False
            txtFirstName.BackColor = invalidColour
        Else
            validFirstName = True
            txtFirstName.BackColor = validColour
            CheckComplete()
        End If
    End Sub
    Private Sub ValidateLastName()
        If Trim(txtLastName.Text) = "" Or Regex.IsMatch(txtLastName.Text, "[^a-zA-Z\-\s\']") Then
            validLastName = False
            btnAddStud.Enabled = False
            txtLastName.BackColor = invalidColour
        Else
            validLastName = True
            txtLastName.BackColor = validColour
            CheckComplete()
        End If
    End Sub
    Private Sub ValidateAvMk()
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
    Private Sub ValidatePhone()
        If Not Len(Trim(txtPhoneNo.Text)) = 12 Then
            txtPhoneNo.BackColor = invalidColour
            btnAddStud.Enabled = False
            validPhoneNo = False
        Else
            txtPhoneNo.BackColor = validColour
            validPhoneNo = True
            CheckComplete()
        End If
    End Sub
    Private Sub ValidateGender()
        If (rbMale.Checked) Then
            validGender = True
            txtOther.BackColor = validColour
            myGender = "Male"
            CheckComplete()
        ElseIf (rbFemale.Checked) Then
            validGender = True
            txtOther.BackColor = validColour
            myGender = "Female"
            CheckComplete()
        Else
            If (txtOther.Text = "" Or Regex.IsMatch(txtFirstName.Text, "[^a-zA-Z\-\s\']")) Then
                validGender = False
                btnAddStud.Enabled = False
            Else
                validGender = True
                txtOther.BackColor = validColour
                myGender = txtOther.Text
                CheckComplete()
            End If
        End If
    End Sub
    Private Sub ValidateOther()
        If (rbOther.Checked) Then
            If ((txtOther.Text = "" Or Regex.IsMatch(txtOther.Text, "[^a-zA-Z\-\s\']"))) Then
                txtOther.BackColor = invalidColour
                btnAddStud.Enabled = False
                validGender = False
            Else
                validGender = True
                txtOther.BackColor = validColour
                myGender = txtOther.Text
                CheckComplete()
            End If
        End If
    End Sub
    Private Sub ValidateDOB()
        If (Not (txtDOB.Value >= #1/1/1960# And txtDOB.Value < #1/1/2010#)) Then
            validDOB = False
            btnAddStud.Enabled = False
        Else
            validDOB = True
            CheckComplete()
        End If
    End Sub
    Private Sub ValidateFields()
        ValidateFirstName()
        ValidateLastName()
        ValidateAvMk()
        ValidatePhone()
        ValidateGender()
        ValidateOther()
        ValidateDOB()
    End Sub
#End Region
#Region "Matches"
    Public Sub UpdateFind()
        For Each s In students
            s.matches = True
            s.matches = (txtFirstName.Text = "" OrElse Regex.IsMatch(s.firstName, "^" + txtFirstName.Text))
            s.matches = (s.matches AndAlso (txtLastName.Text = "" OrElse Regex.IsMatch(s.lastName, "^" + txtLastName.Text)))

            If (rbGreater.Checked) Then
                s.matches = (s.matches AndAlso (txtAvMk.Text = "" OrElse CType(txtAvMk.Text, Single) < s.avMk))
            Else
                s.matches = (s.matches AndAlso (txtAvMk.Text = "" OrElse CType(txtAvMk.Text, Single) > s.avMk))
            End If

            s.matches = (s.matches AndAlso (Regex.Replace(txtPhoneNo.Text, "[^0-9]", "") = "" OrElse Regex.IsMatch(s.phoneNo, "^" + Regex.Replace(txtPhoneNo.Text, "[^0-9]", ""))))
            s.matches = (s.matches AndAlso (myGender = "" OrElse Regex.IsMatch(s.gender, "^" + myGender)))

            If (rbAfter.Checked) Then
                s.matches = (s.matches AndAlso (s.DOB >= txtDOB.Text))
            ElseIf (rbBefore.Checked) Then
                s.matches = (s.matches AndAlso (s.DOB < txtDOB.Text))
            End If

            s.matches = (s.matches AndAlso (Not chkPaidAltered OrElse chkPaid.Checked = s.paid))
        Next

        UpdateList()
    End Sub
#End Region
#Region "Other Subs"
    Private Sub UpdateList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()

        'loop through the array to print all rows
        For i = 0 To students.Count - 1
            If (Not rbAdd.Checked AndAlso Not students(i).matches) Then
                Continue For
            End If

            lstStud.Items.Add(students(i).firstName & " - " & students(i).lastName & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " & students(i).avMk &
                              " - " & students(i).phoneNo & " - " & students(i).paid & ".")
        Next
    End Sub
    Private Sub CheckComplete()
        If (validFirstName And validLastName And validDOB And validGender And validAvMk And validPhoneNo) Then
            btnAddStud.Enabled = True
            Console.WriteLine("//......| The form is complete! |......\\")
        Else
            btnAddStud.Enabled = False
            Console.Write("The form is not complete. ")
            If (Not validFirstName) Then
                Console.Write("Invalid First Name. ")
            End If
            If (Not validLastName) Then
                Console.Write("Invalid Last Name. ")
            End If
            If (Not validDOB) Then
                Console.Write("Invalid DOB. ")
            End If
            If (Not validGender) Then
                Console.Write("Invalid Gender. ")
            End If
            If (Not validAvMk) Then
                Console.Write("Invalid AvMk. ")
            End If
            If (Not validPhoneNo) Then
                Console.Write("Invalid Phone No. ")
            End If
            Console.WriteLine()
        End If
    End Sub
    Private Sub ResetForm()
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = #1/01/2003#
        txtAvMk.Text = ""
        txtPhoneNo.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        rbOther.Checked = False
        txtOther.Text = ""

        chkPaid.Checked = False
        chkPaidAltered = False

        rbAfter.Checked = False
        rbBefore.Checked = False

        'change colours back to default
        txtFirstName.BackColor = validColour
        txtLastName.BackColor = validColour
        txtDOB.CalendarTitleBackColor = validColour
        txtOther.BackColor = validColour
        txtAvMk.BackColor = validColour
        txtPhoneNo.BackColor = validColour

        'make the add student button unusable
        btnAddStud.Enabled = False

        'Reset Valid Variables
        validFirstName = False
        validLastName = False
        validAvMk = False
        validPhoneNo = False
        validGender = False
        validDOB = True
        myGender = ""

        If (rbFind.Checked) Then
            UpdateFind()
        End If
    End Sub
    Private Sub Serialise()
        Dim output As String = JsonConvert.SerializeObject(students)
        File.WriteAllText(myPath, output)
    End Sub
    Private Sub Deserialise()
        Dim strLine As String = File.ReadAllText(myPath)
        students = JsonConvert.DeserializeObject(Of List(Of Student))(strLine)

        UpdateList()
    End Sub
    Private Sub rbBefAft_CheckedChanged(sender As Object, e As EventArgs) Handles rbBefore.CheckedChanged, rbAfter.CheckedChanged
        UpdateFind()
    End Sub
    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        Deserialise()
        MessageBox.Show("Loaded the file and updated the list!", "File Loaded", MessageBoxButtons.OK)
    End Sub
    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        Serialise()
        MessageBox.Show("File successfully saved!", "File Saved", MessageBoxButtons.OK)
    End Sub
#End Region
End Class