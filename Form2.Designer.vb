<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        txtNameOfTest = New TextBox()
        lblNameOfTest = New Label()
        Panel2 = New Panel()
        lblTimer = New Label()
        txtPAnswer = New TextBox()
        txtQuestion = New TextBox()
        txtQNumber = New TextBox()
        lblCAnswer = New Label()
        lblPAnswer = New Label()
        lblQuestion = New Label()
        lblQNumber = New Label()
        CBoxCorrect = New ComboBox()
        Panel3 = New Panel()
        btnRestart = New Button()
        btnExit = New Button()
        btnNext = New Button()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtNameOfTest)
        Panel1.Controls.Add(lblNameOfTest)
        Panel1.Location = New Point(12, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(499, 79)
        Panel1.TabIndex = 0
        ' 
        ' txtNameOfTest
        ' 
        txtNameOfTest.BackColor = Color.Wheat
        txtNameOfTest.Location = New Point(162, 24)
        txtNameOfTest.Multiline = True
        txtNameOfTest.Name = "txtNameOfTest"
        txtNameOfTest.Size = New Size(310, 30)
        txtNameOfTest.TabIndex = 5
        ' 
        ' lblNameOfTest
        ' 
        lblNameOfTest.AutoSize = True
        lblNameOfTest.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNameOfTest.ForeColor = Color.DeepSkyBlue
        lblNameOfTest.Image = CType(resources.GetObject("lblNameOfTest.Image"), Image)
        lblNameOfTest.Location = New Point(19, 26)
        lblNameOfTest.Name = "lblNameOfTest"
        lblNameOfTest.Size = New Size(104, 16)
        lblNameOfTest.TabIndex = 4
        lblNameOfTest.Text = "Name Of Test"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lblTimer)
        Panel2.Controls.Add(txtPAnswer)
        Panel2.Controls.Add(txtQuestion)
        Panel2.Controls.Add(txtQNumber)
        Panel2.Controls.Add(lblCAnswer)
        Panel2.Controls.Add(lblPAnswer)
        Panel2.Controls.Add(lblQuestion)
        Panel2.Controls.Add(lblQNumber)
        Panel2.Controls.Add(CBoxCorrect)
        Panel2.Location = New Point(12, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(499, 325)
        Panel2.TabIndex = 1
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.BackColor = Color.Red
        lblTimer.Location = New Point(377, 280)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(37, 15)
        lblTimer.TabIndex = 13
        lblTimer.Text = "Timer"
        ' 
        ' txtPAnswer
        ' 
        txtPAnswer.BackColor = Color.Wheat
        txtPAnswer.Location = New Point(158, 142)
        txtPAnswer.Multiline = True
        txtPAnswer.Name = "txtPAnswer"
        txtPAnswer.Size = New Size(310, 122)
        txtPAnswer.TabIndex = 12
        ' 
        ' txtQuestion
        ' 
        txtQuestion.BackColor = Color.Wheat
        txtQuestion.Location = New Point(158, 78)
        txtQuestion.Multiline = True
        txtQuestion.Name = "txtQuestion"
        txtQuestion.Size = New Size(310, 38)
        txtQuestion.TabIndex = 11
        ' 
        ' txtQNumber
        ' 
        txtQNumber.BackColor = Color.Wheat
        txtQNumber.Location = New Point(158, 24)
        txtQNumber.Multiline = True
        txtQNumber.Name = "txtQNumber"
        txtQNumber.Size = New Size(197, 24)
        txtQNumber.TabIndex = 10
        ' 
        ' lblCAnswer
        ' 
        lblCAnswer.AutoSize = True
        lblCAnswer.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblCAnswer.ForeColor = Color.DeepSkyBlue
        lblCAnswer.Image = CType(resources.GetObject("lblCAnswer.Image"), Image)
        lblCAnswer.Location = New Point(19, 277)
        lblCAnswer.Name = "lblCAnswer"
        lblCAnswer.Size = New Size(117, 16)
        lblCAnswer.TabIndex = 9
        lblCAnswer.Text = "Correct Answer"
        ' 
        ' lblPAnswer
        ' 
        lblPAnswer.AutoSize = True
        lblPAnswer.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPAnswer.ForeColor = Color.DeepSkyBlue
        lblPAnswer.Image = CType(resources.GetObject("lblPAnswer.Image"), Image)
        lblPAnswer.Location = New Point(19, 144)
        lblPAnswer.Name = "lblPAnswer"
        lblPAnswer.Size = New Size(124, 16)
        lblPAnswer.TabIndex = 8
        lblPAnswer.Text = "Possible Answer"
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblQuestion.ForeColor = Color.DeepSkyBlue
        lblQuestion.Image = CType(resources.GetObject("lblQuestion.Image"), Image)
        lblQuestion.Location = New Point(19, 88)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(72, 16)
        lblQuestion.TabIndex = 7
        lblQuestion.Text = "Question"
        ' 
        ' lblQNumber
        ' 
        lblQNumber.AutoSize = True
        lblQNumber.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblQNumber.ForeColor = Color.DeepSkyBlue
        lblQNumber.Image = CType(resources.GetObject("lblQNumber.Image"), Image)
        lblQNumber.Location = New Point(19, 24)
        lblQNumber.Name = "lblQNumber"
        lblQNumber.Size = New Size(133, 16)
        lblQNumber.TabIndex = 6
        lblQNumber.Text = "Question Number"
        ' 
        ' CBoxCorrect
        ' 
        CBoxCorrect.BackColor = Color.Wheat
        CBoxCorrect.FormattingEnabled = True
        CBoxCorrect.Items.AddRange(New Object() {"(a)", "(b)", "(c)", "(d)"})
        CBoxCorrect.Location = New Point(158, 277)
        CBoxCorrect.Name = "CBoxCorrect"
        CBoxCorrect.Size = New Size(163, 23)
        CBoxCorrect.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnRestart)
        Panel3.Controls.Add(btnExit)
        Panel3.Controls.Add(btnNext)
        Panel3.Location = New Point(12, 437)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(499, 79)
        Panel3.TabIndex = 2
        ' 
        ' btnRestart
        ' 
        btnRestart.BackColor = Color.Yellow
        btnRestart.Font = New Font("Algerian", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnRestart.ForeColor = Color.Indigo
        btnRestart.Location = New Point(188, 20)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(115, 42)
        btnRestart.TabIndex = 2
        btnRestart.Text = "RESTART"
        btnRestart.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Algerian", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.Indigo
        btnExit.Location = New Point(19, 20)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(82, 42)
        btnExit.TabIndex = 1
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Algerian", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnNext.ForeColor = Color.Indigo
        btnNext.Location = New Point(390, 20)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(82, 42)
        btnNext.TabIndex = 0
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(523, 528)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CBoxCorrect As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblNameOfTest As Label
    Friend WithEvents lblQNumber As Label
    Friend WithEvents lblCAnswer As Label
    Friend WithEvents lblPAnswer As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtNameOfTest As TextBox
    Friend WithEvents txtPAnswer As TextBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtQNumber As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer1 As Timer
End Class
