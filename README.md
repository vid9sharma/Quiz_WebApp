# Quiz_WebApp

A C# ASP.NET Core MVC Web Application for taking and tracking quizzes.

## Features

- Presents 10 random questions per quiz session, one at a time.
- Allows users to navigate back and forth between questions.
- Calculates and displays the final score after submission.
- Stores quiz results and allows users to view their previous quiz scores.
- Uses Entity Framework Core with SQL Server for data storage.
- Session-based state management for quiz progress.
- Responsive UI styled with Bootstrap.

## Project Structure

- `Controllers/` – MVC controllers for quiz and home pages.
- `Models/` – Entity and view models, session helpers.
- `Views/` – Razor views for quiz, results, and history.
- `Migrations/` – Entity Framework Core migrations and seed data.
- `wwwroot/` – Static files (CSS, JS, Bootstrap, jQuery).
- `appsettings.json` – Configuration, including database connection string.

## Getting Started

### Prerequisites

- [.NET Core SDK 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- SQL Server (LocalDB or full instance)

### Setup

1. **Clone the repository:**
   ```sh
   git clone <repo-url>
   cd Quiz_WebApp
   ```

2. **Restore NuGet packages:**
   ```sh
   dotnet restore
   ```

3. **Apply database migrations:**
   ```sh
   dotnet ef database update
   ```

4. **Run the application:**
   ```sh
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`.

## Usage

- Click "Start Quiz" to begin a new quiz session.
- Answer each question and use "Next" or "Previous" to navigate.
- Submit your answers to see your score.
- View your previous quiz results from the home page.

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap
- jQuery
