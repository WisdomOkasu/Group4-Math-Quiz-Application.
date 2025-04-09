Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Username, Password As String
        Username = "Group4"
        Password = "Group4"

        ' Input validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Username cannot be empty")
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password cannot be empty")
            txtPassword.Focus()
            Return
        End If

        If txtUsername.Text.Length < 6 Then
            MessageBox.Show("Username must be at least 6 characters long")
            txtUsername.Focus()
            Return
        End If

        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long")
            txtPassword.Focus()
            Return
        End If

        Try
            If txtUsername.Text = Username And txtPassword.Text = Password Then
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class

