Submission App Backend
This is the backend for the Submission App, built using ASP.NET Core Web API. It handles storing and retrieving submissions.

Table of Contents
Features
Technologies Used
Setup and Installation
Usage
API Endpoints

Features
Store new submissions.
Retrieve a list of all submissions.
Technologies Used
ASP.NET Core Web API
In-memory database
Setup and Installation
Ensure you have .NET SDK installed.
Clone the repository:
bash
Copy code
git clone https://github.com/yourusername/SubmissionApp.git
Navigate to the backend directory:
bash
Copy code
cd SubmissionApp/Backend
Restore NuGet packages:
bash
Copy code
dotnet restore
Build the project:
bash
Copy code
dotnet build
Usage
Start the backend server:
bash
Copy code
dotnet run
The API will be available at http://localhost:5000.
API Endpoints
GET /api/submissions: Retrieve all submissions.
POST /api/submissions: Create a new submission.
