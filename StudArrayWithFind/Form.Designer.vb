<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAvMk = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnMale = New System.Windows.Forms.RadioButton()
        Me.btnFemale = New System.Windows.Forms.RadioButton()
        Me.btnOther = New System.Windows.Forms.RadioButton()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Location = New System.Drawing.Point(35, 107)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(148, 26)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Student Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(194, 107)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(148, 26)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(722, 77)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average Mk (0-100)"
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(40, 171)
        Me.txtAvMk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAvMk.MaxLength = 5
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(148, 26)
        Me.txtAvMk.TabIndex = 10
        '
        'btnAddStud
        '
        Me.btnAddStud.Enabled = False
        Me.btnAddStud.Location = New System.Drawing.Point(405, 205)
        Me.btnAddStud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(156, 35)
        Me.btnAddStud.TabIndex = 13
        Me.btnAddStud.Text = "Add Student"
        Me.btnAddStud.UseVisualStyleBackColor = True
        '
        'lstStud
        '
        Me.lstStud.FormattingEnabled = True
        Me.lstStud.ItemHeight = 20
        Me.lstStud.Location = New System.Drawing.Point(36, 267)
        Me.lstStud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstStud.Name = "lstStud"
        Me.lstStud.Size = New System.Drawing.Size(798, 244)
        Me.lstStud.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 238)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of Entered Students"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(203, 171)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(148, 26)
        Me.txtPhone.TabIndex = 11
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(366, 173)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(66, 24)
        Me.chkPaid.TabIndex = 12
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 148)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Phone Number"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(357, 107)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(350, 26)
        Me.txtDOB.TabIndex = 2
        Me.txtDOB.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'btnMale
        '
        Me.btnMale.AutoSize = True
        Me.btnMale.Location = New System.Drawing.Point(713, 100)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(68, 24)
        Me.btnMale.TabIndex = 6
        Me.btnMale.TabStop = True
        Me.btnMale.Text = "Male"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.AutoSize = True
        Me.btnFemale.Location = New System.Drawing.Point(713, 130)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(87, 24)
        Me.btnFemale.TabIndex = 7
        Me.btnFemale.TabStop = True
        Me.btnFemale.Text = "Female"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'btnOther
        '
        Me.btnOther.AutoSize = True
        Me.btnOther.Location = New System.Drawing.Point(713, 160)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(74, 24)
        Me.btnOther.TabIndex = 8
        Me.btnOther.TabStop = True
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(794, 158)
        Me.txtOther.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(109, 26)
        Me.txtOther.TabIndex = 9
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(916, 544)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstStud)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAvMk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form"
        Me.Text = "V02.1 - StudDB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvMk As TextBox


    Friend WithEvents lstStud As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents btnAddStud As Button
    Friend WithEvents btnMale As RadioButton
    Friend WithEvents btnFemale As RadioButton
    Friend WithEvents btnOther As RadioButton
    Friend WithEvents txtOther As TextBox
End Class
