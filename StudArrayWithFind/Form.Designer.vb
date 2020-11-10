<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbOther = New System.Windows.Forms.RadioButton()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbGender = New System.Windows.Forms.GroupBox()
        Me.gbDOB = New System.Windows.Forms.GroupBox()
        Me.rbAfter = New System.Windows.Forms.RadioButton()
        Me.rbBefore = New System.Windows.Forms.RadioButton()
        Me.gbLastName = New System.Windows.Forms.GroupBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.gbFirstName = New System.Windows.Forms.GroupBox()
        Me.gbAvMk = New System.Windows.Forms.GroupBox()
        Me.txtAvMk = New System.Windows.Forms.TextBox()
        Me.rbGreater = New System.Windows.Forms.RadioButton()
        Me.rbLesser = New System.Windows.Forms.RadioButton()
        Me.gbPhone = New System.Windows.Forms.GroupBox()
        Me.txtPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.gbAcMo = New System.Windows.Forms.GroupBox()
        Me.rbFind = New System.Windows.Forms.RadioButton()
        Me.rbAdd = New System.Windows.Forms.RadioButton()
        Me.gbPaid = New System.Windows.Forms.GroupBox()
        Me.gbList = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.gbGender.SuspendLayout()
        Me.gbDOB.SuspendLayout()
        Me.gbLastName.SuspendLayout()
        Me.gbFirstName.SuspendLayout()
        Me.gbAvMk.SuspendLayout()
        Me.gbPhone.SuspendLayout()
        Me.gbAcMo.SuspendLayout()
        Me.gbPaid.SuspendLayout()
        Me.gbList.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(4, 27)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(148, 26)
        Me.txtLastName.TabIndex = 3
        '
        'btnAddStud
        '
        Me.btnAddStud.BackColor = System.Drawing.SystemColors.Window
        Me.btnAddStud.Enabled = False
        Me.btnAddStud.Location = New System.Drawing.Point(390, 223)
        Me.btnAddStud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(156, 35)
        Me.btnAddStud.TabIndex = 10
        Me.btnAddStud.Text = "Add Student"
        Me.btnAddStud.UseVisualStyleBackColor = False
        '
        'lstStud
        '
        Me.lstStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lstStud.FormattingEnabled = True
        Me.lstStud.ItemHeight = 20
        Me.lstStud.Location = New System.Drawing.Point(7, 27)
        Me.lstStud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstStud.Name = "lstStud"
        Me.lstStud.Size = New System.Drawing.Size(924, 244)
        Me.lstStud.TabIndex = 11
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(60, 14)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(66, 24)
        Me.chkPaid.TabIndex = 6
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(6, 31)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(289, 26)
        Me.txtDOB.TabIndex = 8
        Me.txtDOB.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(6, 31)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(68, 24)
        Me.rbMale.TabIndex = 6
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(6, 65)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(87, 24)
        Me.rbFemale.TabIndex = 7
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.Location = New System.Drawing.Point(6, 100)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(74, 24)
        Me.rbOther.TabIndex = 8
        Me.rbOther.TabStop = True
        Me.rbOther.Text = "Other"
        Me.rbOther.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(84, 97)
        Me.txtOther.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(109, 26)
        Me.txtOther.TabIndex = 9
        '
        'gbGender
        '
        Me.gbGender.Controls.Add(Me.rbMale)
        Me.gbGender.Controls.Add(Me.txtOther)
        Me.gbGender.Controls.Add(Me.rbFemale)
        Me.gbGender.Controls.Add(Me.rbOther)
        Me.gbGender.Location = New System.Drawing.Point(353, 76)
        Me.gbGender.Name = "gbGender"
        Me.gbGender.Size = New System.Drawing.Size(200, 139)
        Me.gbGender.TabIndex = 4
        Me.gbGender.TabStop = False
        Me.gbGender.Text = "Gender"
        Me.toolTip.SetToolTip(Me.gbGender, "Please choose from 'Male', 'Female' and 'Other'. If you select 'Other', please en" &
        "ter your Gender in the box provided.")
        '
        'gbDOB
        '
        Me.gbDOB.Controls.Add(Me.rbAfter)
        Me.gbDOB.Controls.Add(Me.txtDOB)
        Me.gbDOB.Controls.Add(Me.rbBefore)
        Me.gbDOB.Location = New System.Drawing.Point(559, 76)
        Me.gbDOB.Name = "gbDOB"
        Me.gbDOB.Size = New System.Drawing.Size(399, 78)
        Me.gbDOB.TabIndex = 8
        Me.gbDOB.TabStop = False
        Me.gbDOB.Text = "Date of Birth"
        Me.toolTip.SetToolTip(Me.gbDOB, "Date of Birth must be from 1 January 1960 to 1 January 2010.")
        '
        'rbAfter
        '
        Me.rbAfter.AutoSize = True
        Me.rbAfter.BackColor = System.Drawing.Color.Transparent
        Me.rbAfter.Location = New System.Drawing.Point(311, 45)
        Me.rbAfter.Name = "rbAfter"
        Me.rbAfter.Size = New System.Drawing.Size(69, 24)
        Me.rbAfter.TabIndex = 8
        Me.rbAfter.Text = "After"
        Me.rbAfter.UseVisualStyleBackColor = False
        Me.rbAfter.Visible = False
        '
        'rbBefore
        '
        Me.rbBefore.AutoSize = True
        Me.rbBefore.BackColor = System.Drawing.Color.Transparent
        Me.rbBefore.Location = New System.Drawing.Point(311, 16)
        Me.rbBefore.Name = "rbBefore"
        Me.rbBefore.Size = New System.Drawing.Size(82, 24)
        Me.rbBefore.TabIndex = 7
        Me.rbBefore.Text = "Before"
        Me.rbBefore.UseVisualStyleBackColor = False
        Me.rbBefore.Visible = False
        '
        'gbLastName
        '
        Me.gbLastName.Controls.Add(Me.txtLastName)
        Me.gbLastName.Location = New System.Drawing.Point(190, 76)
        Me.gbLastName.Name = "gbLastName"
        Me.gbLastName.Size = New System.Drawing.Size(157, 69)
        Me.gbLastName.TabIndex = 1
        Me.gbLastName.TabStop = False
        Me.gbLastName.Text = "Last Name"
        Me.toolTip.SetToolTip(Me.gbLastName, "Names must contain only letters from A-Z and no numbers or special characters.")
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(4, 27)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(148, 26)
        Me.txtFirstName.TabIndex = 2
        Me.toolTip.SetToolTip(Me.txtFirstName, "Names must contain only letters from A-Z, ""-"" and ""''""")
        '
        'gbFirstName
        '
        Me.gbFirstName.Controls.Add(Me.txtFirstName)
        Me.gbFirstName.Location = New System.Drawing.Point(27, 77)
        Me.gbFirstName.Name = "gbFirstName"
        Me.gbFirstName.Size = New System.Drawing.Size(157, 69)
        Me.gbFirstName.TabIndex = 0
        Me.gbFirstName.TabStop = False
        Me.gbFirstName.Text = "FirstName"
        '
        'gbAvMk
        '
        Me.gbAvMk.Controls.Add(Me.txtAvMk)
        Me.gbAvMk.Controls.Add(Me.rbGreater)
        Me.gbAvMk.Controls.Add(Me.rbLesser)
        Me.gbAvMk.Location = New System.Drawing.Point(27, 146)
        Me.gbAvMk.Name = "gbAvMk"
        Me.gbAvMk.Size = New System.Drawing.Size(157, 69)
        Me.gbAvMk.TabIndex = 2
        Me.gbAvMk.TabStop = False
        Me.gbAvMk.Text = "Average Mark"
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(4, 27)
        Me.txtAvMk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(148, 26)
        Me.txtAvMk.TabIndex = 3
        '
        'rbGreater
        '
        Me.rbGreater.AutoSize = True
        Me.rbGreater.BackColor = System.Drawing.Color.Transparent
        Me.rbGreater.Location = New System.Drawing.Point(108, 39)
        Me.rbGreater.Name = "rbGreater"
        Me.rbGreater.Size = New System.Drawing.Size(43, 24)
        Me.rbGreater.TabIndex = 6
        Me.rbGreater.Text = ">"
        Me.rbGreater.UseVisualStyleBackColor = False
        Me.rbGreater.Visible = False
        '
        'rbLesser
        '
        Me.rbLesser.AutoSize = True
        Me.rbLesser.BackColor = System.Drawing.Color.Transparent
        Me.rbLesser.Checked = True
        Me.rbLesser.Location = New System.Drawing.Point(108, 14)
        Me.rbLesser.Name = "rbLesser"
        Me.rbLesser.Size = New System.Drawing.Size(43, 24)
        Me.rbLesser.TabIndex = 5
        Me.rbLesser.TabStop = True
        Me.rbLesser.Text = "<"
        Me.rbLesser.UseVisualStyleBackColor = False
        Me.rbLesser.Visible = False
        '
        'gbPhone
        '
        Me.gbPhone.Controls.Add(Me.txtPhoneNo)
        Me.gbPhone.Location = New System.Drawing.Point(190, 146)
        Me.gbPhone.Name = "gbPhone"
        Me.gbPhone.Size = New System.Drawing.Size(157, 69)
        Me.gbPhone.TabIndex = 50
        Me.gbPhone.TabStop = False
        Me.gbPhone.Text = "Phone Number"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(7, 27)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(144, 26)
        Me.txtPhoneNo.TabIndex = 50
        '
        'gbAcMo
        '
        Me.gbAcMo.Controls.Add(Me.rbFind)
        Me.gbAcMo.Controls.Add(Me.rbAdd)
        Me.gbAcMo.Location = New System.Drawing.Point(27, 12)
        Me.gbAcMo.Name = "gbAcMo"
        Me.gbAcMo.Size = New System.Drawing.Size(320, 59)
        Me.gbAcMo.TabIndex = 0
        Me.gbAcMo.TabStop = False
        Me.gbAcMo.Text = "Access Mode"
        '
        'rbFind
        '
        Me.rbFind.AutoSize = True
        Me.rbFind.Location = New System.Drawing.Point(167, 25)
        Me.rbFind.Name = "rbFind"
        Me.rbFind.Size = New System.Drawing.Size(65, 24)
        Me.rbFind.TabIndex = 1
        Me.rbFind.Text = "Find"
        Me.rbFind.UseVisualStyleBackColor = True
        '
        'rbAdd
        '
        Me.rbAdd.AutoSize = True
        Me.rbAdd.Checked = True
        Me.rbAdd.Location = New System.Drawing.Point(4, 25)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(103, 24)
        Me.rbAdd.TabIndex = 0
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "Add / Edit"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'gbPaid
        '
        Me.gbPaid.Controls.Add(Me.chkPaid)
        Me.gbPaid.Location = New System.Drawing.Point(584, 165)
        Me.gbPaid.Name = "gbPaid"
        Me.gbPaid.Size = New System.Drawing.Size(182, 44)
        Me.gbPaid.TabIndex = 18
        Me.gbPaid.TabStop = False
        Me.gbPaid.Text = "Paid"
        '
        'gbList
        '
        Me.gbList.Controls.Add(Me.btnEdit)
        Me.gbList.Controls.Add(Me.btnRemove)
        Me.gbList.Controls.Add(Me.lstStud)
        Me.gbList.Location = New System.Drawing.Point(27, 263)
        Me.gbList.Name = "gbList"
        Me.gbList.Size = New System.Drawing.Size(938, 281)
        Me.gbList.TabIndex = 19
        Me.gbList.TabStop = False
        Me.gbList.Text = "List of Entered Students"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnEdit.Location = New System.Drawing.Point(725, 25)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(102, 24)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnRemove.Location = New System.Drawing.Point(829, 25)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(102, 24)
        Me.btnRemove.TabIndex = 54
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        Me.btnRemove.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.Location = New System.Drawing.Point(802, 171)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 35)
        Me.btnReset.TabIndex = 51
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnLoadFile
        '
        Me.btnLoadFile.BackColor = System.Drawing.SystemColors.Window
        Me.btnLoadFile.Location = New System.Drawing.Point(678, 26)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(137, 35)
        Me.btnLoadFile.TabIndex = 52
        Me.btnLoadFile.Text = "Load File"
        Me.btnLoadFile.UseVisualStyleBackColor = False
        '
        'btnSaveFile
        '
        Me.btnSaveFile.BackColor = System.Drawing.SystemColors.Window
        Me.btnSaveFile.Location = New System.Drawing.Point(821, 26)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(137, 35)
        Me.btnSaveFile.TabIndex = 53
        Me.btnSaveFile.Text = "Save File"
        Me.btnSaveFile.UseVisualStyleBackColor = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(990, 567)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbList)
        Me.Controls.Add(Me.gbPaid)
        Me.Controls.Add(Me.gbAcMo)
        Me.Controls.Add(Me.gbPhone)
        Me.Controls.Add(Me.gbAvMk)
        Me.Controls.Add(Me.gbFirstName)
        Me.Controls.Add(Me.gbLastName)
        Me.Controls.Add(Me.gbDOB)
        Me.Controls.Add(Me.gbGender)
        Me.Controls.Add(Me.btnAddStud)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form"
        Me.Text = "V04.4 - StudDB"
        Me.gbGender.ResumeLayout(False)
        Me.gbGender.PerformLayout()
        Me.gbDOB.ResumeLayout(False)
        Me.gbDOB.PerformLayout()
        Me.gbLastName.ResumeLayout(False)
        Me.gbLastName.PerformLayout()
        Me.gbFirstName.ResumeLayout(False)
        Me.gbFirstName.PerformLayout()
        Me.gbAvMk.ResumeLayout(False)
        Me.gbAvMk.PerformLayout()
        Me.gbPhone.ResumeLayout(False)
        Me.gbPhone.PerformLayout()
        Me.gbAcMo.ResumeLayout(False)
        Me.gbAcMo.PerformLayout()
        Me.gbPaid.ResumeLayout(False)
        Me.gbPaid.PerformLayout()
        Me.gbList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLastName As TextBox


    Friend WithEvents lstStud As ListBox
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents btnAddStud As Button
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbOther As RadioButton
    Friend WithEvents txtOther As TextBox
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents gbDOB As GroupBox
    Friend WithEvents gbLastName As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents gbFirstName As GroupBox
    Friend WithEvents gbAvMk As GroupBox
    Friend WithEvents gbPhone As GroupBox
    Friend WithEvents gbAcMo As GroupBox
    Friend WithEvents rbFind As RadioButton
    Friend WithEvents rbAdd As RadioButton
    Friend WithEvents gbPaid As GroupBox
    Friend WithEvents gbList As GroupBox
    Friend WithEvents txtPhoneNo As MaskedTextBox
    Friend WithEvents rbGreater As RadioButton
    Friend WithEvents rbLesser As RadioButton
    Friend WithEvents txtAvMk As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents rbAfter As RadioButton
    Friend WithEvents rbBefore As RadioButton
    Friend WithEvents btnLoadFile As Button
    Friend WithEvents btnSaveFile As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRemove As Button
End Class
