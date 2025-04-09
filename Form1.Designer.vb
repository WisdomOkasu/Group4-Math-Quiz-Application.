<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblWQA = New Label()
        btnClose = New Button()
        btnStart = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label4 = New Label()
        chkShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' lblWQA
        ' 
        lblWQA.AutoSize = True
        lblWQA.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblWQA.ForeColor = Color.IndianRed
        lblWQA.Image = CType(resources.GetObject("lblWQA.Image"), Image)
        lblWQA.Location = New Point(85, 9)
        lblWQA.Name = "lblWQA"
        lblWQA.Size = New Size(422, 25)
        lblWQA.TabIndex = 0
        lblWQA.Text = "GROUP4 MATH QUIZ APPLICATION" & vbCrLf
        ' 
        ' btnClose
        ' 
        btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), Image)
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.Location = New Point(534, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(36, 32)
        btnClose.TabIndex = 1
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.Lime
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Algerian", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = Color.Purple
        btnStart.Location = New Point(453, 317)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(91, 30)
        btnStart.TabIndex = 2
        btnStart.Text = "START"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.IndianRed
        lblUsername.Image = CType(resources.GetObject("lblUsername.Image"), Image)
        lblUsername.Location = New Point(135, 176)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(138, 25)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.IndianRed
        lblPassword.Image = CType(resources.GetObject("lblPassword.Image"), Image)
        lblPassword.Location = New Point(135, 213)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(133, 25)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Wheat
        txtUsername.Location = New Point(286, 180)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(164, 23)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Wheat
        txtPassword.Location = New Point(286, 219)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(164, 23)
        txtPassword.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Yellow
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(179, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(312, 28)
        Label4.TabIndex = 7
        Label4.Text = "Enter details to start..."
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(286, 248)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 8
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(582, 359)
        Controls.Add(chkShowPassword)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnStart)
        Controls.Add(btnClose)
        Controls.Add(lblWQA)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWQA As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkShowPassword As CheckBox

End Class

