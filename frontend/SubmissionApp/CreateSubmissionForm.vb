Imports System.Diagnostics
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = "Time: " & stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .FullName = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }

        Await SubmitToBackend(submission)
        Me.Close()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Async Function SubmitToBackend(submission As Submission) As Task
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000/") ' Adjust the base URL as necessary
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync("api/submissions", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Failed to submit. Please try again.")
            End If
        End Using
    End Function
End Class
