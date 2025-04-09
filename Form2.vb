Imports Microsoft.Data.SqlClient

Public Class Form2
    Dim conn As New SqlConnection("Server=WIZ;Database=QuizDB;Integrated Security=True;TrustServerCertificate=True;")
    Dim currentQuestion As Integer = 1
    Dim score As Integer = 0
    Dim totalQuestions As Integer = 10
    Dim timeLeft As Integer = 10 ' Set the timer duration (e.g., 30 seconds)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            MessageBox.Show("Login Successful")
            LoadQuestion(currentQuestion)
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadQuestion(qNum As Integer)
        Dim dt As DataTable = GetQuestion(qNum)

        If dt.Rows.Count > 0 Then
            txtNameOfTest.Text = dt.Rows(0)("TestName").ToString()
            txtQNumber.Text = dt.Rows(0)("QuestionNumber").ToString()
            txtQuestion.Text = dt.Rows(0)("QuestionText").ToString()
            txtPAnswer.Clear()
            Dim answers As String() = dt.Rows(0)("PossibleAnswers").ToString().Split(","c)
            For Each answer As String In answers
                txtPAnswer.AppendText(answer & Environment.NewLine)
            Next

            ' Populate the combo box with possible answers
            CBoxCorrect.Items.Clear()
            CBoxCorrect.Items.AddRange(answers)

            ' Ensure NO answer is selected for EVERY question
            CBoxCorrect.SelectedItem = Nothing
            CBoxCorrect.SelectedIndex = -1
            CBoxCorrect.Text = String.Empty

            ' Initialize and start the timer
            timeLeft = 10 ' Set the timer duration (e.g., 30 seconds)
            lblTimer.Text = $"Time left: {timeLeft} seconds"
            Timer1.Start()
        Else
            MessageBox.Show("No more questions available.")
            currentQuestion -= 1  ' Prevents overflow if user clicks 'Next' at the last question
        End If
    End Sub

    ' Function to fetch questions
    Function GetQuestion(ByVal qNum As Integer) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM Questions WHERE QuestionNumber = @qNum"

        Try
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@qNum", qNum)

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error fetching question: " & ex.Message)
        End Try

        Return dt
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Stop the timer
        Timer1.Stop()

        ' Check if there are no more questions
        If currentQuestion > totalQuestions Then
            MessageBox.Show("No more questions available.")
            Return
        End If

        ' Check the selected answer
        Dim selectedAnswer = CBoxCorrect.SelectedItem?.ToString()
        If Not String.IsNullOrEmpty(selectedAnswer) Then
            Dim correctAnswer = GetCorrectAnswer(currentQuestion)
            If selectedAnswer = correctAnswer Then
                score += 1
                MessageBox.Show($"Correct! Your score is now {score}.")
            Else
                MessageBox.Show($"Incorrect. The correct answer was {correctAnswer}.")
            End If
        End If

        currentQuestion += 1

        If currentQuestion > totalQuestions Then
            MessageBox.Show($"Your score is {score}/{totalQuestions}")
        Else
            LoadQuestion(currentQuestion)
        End If
    End Sub

    ' Function to fetch the correct answer for a question
    Function GetCorrectAnswer(ByVal qNum As Integer) As String
        Dim dt As New DataTable()
        Dim query As String = "SELECT CorrectAnswer FROM Questions WHERE QuestionNumber = @qNum"

        Try
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@qNum", qNum)

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error fetching correct answer: " & ex.Message)
        End Try

        If dt.Rows.Count > 0 Then
            ' Format the correct answer to match the possible answers format
            Dim correctAnswer As String = dt.Rows(0)("CorrectAnswer").ToString()
            Dim possibleAnswers As String() = GetQuestion(qNum).Rows(0)("PossibleAnswers").ToString().Split(","c)
            For Each answer As String In possibleAnswers
                If answer.Contains(correctAnswer) Then
                    Return answer
                End If
            Next
        End If

        Return String.Empty
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        ' Reset the current question and score
        currentQuestion = 1
        score = 0

        ' Reload the first question
        LoadQuestion(currentQuestion)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft > 0 Then
            timeLeft -= 1
            lblTimer.Text = $"Time left: {timeLeft} seconds"
        Else
            Timer1.Stop()
            MessageBox.Show("Time's up!")
            btnNext.PerformClick()
        End If
    End Sub
End Class

