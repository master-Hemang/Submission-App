Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Inherits Form

    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        submissions = Await FetchSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            lblName.Text = "Name: " & submission.FullName
            lblEmail.Text = "Email: " & submission.Email
            lblPhone.Text = "Phone: " & submission.Phone
            lblGithubLink.Text = "GitHub: " & submission.GithubLink
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Async Function FetchSubmissions() As Task(Of List(Of Submission))
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000/") ' Adjust the base URL as necessary
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response As HttpResponseMessage = Await client.GetAsync("api/submissions")
            If response.IsSuccessStatusCode Then
                Dim data As String = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of List(Of Submission))(data)
            Else
                MessageBox.Show("Failed to fetch submissions.")
                Return New List(Of Submission)()
            End If
        End Using
    End Function
End Class
