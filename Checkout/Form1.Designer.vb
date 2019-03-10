<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.lblregister = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpostcode = New System.Windows.Forms.TextBox()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirtstname = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.combotitle = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.lblpostcode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(91, 144)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(273, 20)
        Me.txtlastname.TabIndex = 3
        '
        'lblregister
        '
        Me.lblregister.AutoSize = True
        Me.lblregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregister.Location = New System.Drawing.Point(10, 22)
        Me.lblregister.Name = "lblregister"
        Me.lblregister.Size = New System.Drawing.Size(305, 29)
        Me.lblregister.TabIndex = 1
        Me.lblregister.Text = "Register an account with us"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(13, 141)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(77, 18)
        Me.lbllastname.TabIndex = 2
        Me.lbllastname.Text = "Last name"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(13, 175)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(45, 18)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(91, 178)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(273, 20)
        Me.txtemail.TabIndex = 4
        '
        'txtpostcode
        '
        Me.txtpostcode.Location = New System.Drawing.Point(91, 240)
        Me.txtpostcode.Name = "txtpostcode"
        Me.txtpostcode.Size = New System.Drawing.Size(273, 20)
        Me.txtpostcode.TabIndex = 6
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(12, 207)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(62, 18)
        Me.lbladdress.TabIndex = 6
        Me.lbladdress.Text = "Address"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(11, 306)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(75, 18)
        Me.lblpassword.TabIndex = 7
        Me.lblpassword.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(92, 307)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(272, 20)
        Me.txtpassword.TabIndex = 7
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(92, 341)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirm.Size = New System.Drawing.Size(272, 20)
        Me.txtconfirm.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Confirm"
        '
        'btnregister
        '
        Me.btnregister.Location = New System.Drawing.Point(156, 369)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(96, 30)
        Me.btnregister.TabIndex = 11
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = True
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(91, 111)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(273, 20)
        Me.txtfirstname.TabIndex = 2
        '
        'lblfirtstname
        '
        Me.lblfirtstname.AutoSize = True
        Me.lblfirtstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirtstname.Location = New System.Drawing.Point(13, 108)
        Me.lblfirtstname.Name = "lblfirtstname"
        Me.lblfirtstname.Size = New System.Drawing.Size(78, 18)
        Me.lblfirtstname.TabIndex = 15
        Me.lblfirtstname.Text = "First name"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(13, 75)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(35, 18)
        Me.lbltitle.TabIndex = 14
        Me.lbltitle.Text = "Title"
        '
        'combotitle
        '
        Me.combotitle.FormattingEnabled = True
        Me.combotitle.Items.AddRange(New Object() {"Mr.", "Dr." & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Mrs.", "Ms." & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Admiral"})
        Me.combotitle.Location = New System.Drawing.Point(91, 76)
        Me.combotitle.Name = "combotitle"
        Me.combotitle.Size = New System.Drawing.Size(273, 21)
        Me.combotitle.TabIndex = 1
        Me.combotitle.Text = "Please select..."
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(91, 208)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(274, 20)
        Me.txtaddress.TabIndex = 5
        '
        'lblpostcode
        '
        Me.lblpostcode.AutoSize = True
        Me.lblpostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpostcode.Location = New System.Drawing.Point(13, 239)
        Me.lblpostcode.Name = "lblpostcode"
        Me.lblpostcode.Size = New System.Drawing.Size(72, 18)
        Me.lblpostcode.TabIndex = 19
        Me.lblpostcode.Text = "Postcode"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 424)
        Me.Controls.Add(Me.lblpostcode)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.combotitle)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.lblfirtstname)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.txtpostcode)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lbllastname)
        Me.Controls.Add(Me.lblregister)
        Me.Controls.Add(Me.txtlastname)
        Me.Name = "Register"
        Me.Text = "title"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents lblregister As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtpostcode As System.Windows.Forms.TextBox
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnregister As System.Windows.Forms.Button
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblfirtstname As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents combotitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblpostcode As System.Windows.Forms.Label

End Class
