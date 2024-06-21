# Submission-App

The Submission App is a Windows Forms application that allows users to create submissions with their name, email, phone number, and GitHub link. It also features a stopwatch for tracking time spent on the form. The backend, built with ASP.NET Core, handles storing and retrieving submissions.

Table of Contents
Features
Technologies Used
Setup and Installation
Usage

Features
Create submissions with user details and a GitHub link.
Start/Stop a stopwatch to track time spent on the form.
View a list of all submissions.
Navigate through submissions.
Technologies Used
Frontend: Windows Forms (.NET Framework)
Backend: ASP.NET Core Web API
JSON Serialization: Newtonsoft.Json
HTTP Client for API calls
Setup and Installation
Clone the repository:

bash
Copy code
git clone https://github.com/yourusername/SubmissionApp.git
Follow the setup instructions for both the frontend and backend components.

Usage
Start the backend server as described in the backend README.
Run the frontend application as described in the frontend README.
License
This project is licensed under the MIT License.

Frontend README
Submission App Frontend
This is the frontend of the Submission App, built using Windows Forms in Visual Basic (.NET Framework). It allows users to create and view submissions.

Table of Contents
Features
Technologies Used
Setup and Installation
Usage
License
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


