Submission App Frontend
This is the frontend of the Submission App, built using Windows Forms in Visual Basic (.NET Framework). It allows users to create and view submissions.

Table of Contents
Features
Technologies Used
Setup and Installation
Usage

Features
Create new submissions with user details and a GitHub link.
Start/Stop a stopwatch to track time spent on the form.
View and navigate through a list of submissions.
Technologies Used
Windows Forms (.NET Framework)
JSON Serialization: Newtonsoft.Json
HTTP Client for API calls
Setup and Installation
Ensure you have Visual Studio installed with .NET desktop development workload.
Clone the repository:
bash
Copy code
git clone https://github.com/yourusername/SubmissionApp.git
Open the solution file (SubmissionApp.sln) in Visual Studio.
Restore NuGet packages:
bash
Copy code
Tools > NuGet Package Manager > Package Manager Console
Install-Package Newtonsoft.Json
Build the solution to ensure all dependencies are correctly installed.
Usage
Start the backend server.
Run the frontend application by pressing F5 in Visual Studio.
Use the form to create new submissions or view existing ones.
License
This project is licensed under the MIT License.

Backend README
Submission App Backend
This is the backend for the Submission App, built using ASP.NET Core Web API. It handles storing and retrieving submissions.

Table of Contents
Features
Technologies Used
Setup and Installation
Usage
API Endpoints
License
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



