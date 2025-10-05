# StudentsService

This repository contains the **StudentsService** project, built with C# using the .NET and ASP.NET framework. The project provides services related to student management.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (.NET 8)
- Git (to clone the repository)
- PostgreSQL (default connection expects a database named `students_service`)

## Configuration

Before running the project, make sure to update `appsettings.json` with your PostgreSQL credentials:

{
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=5432;Database=students_service;User Id=postgres;Password=postgres"
  }
}


## Getting Started

1. **Clone the repository**

   ```bash
   git clone https://github.com/DaviLuquini/StudentsService.git
   cd StudentsService
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Build the project**

   ```bash
   dotnet build
   ```

4. **Run the project**

   ```bash
   dotnet run
   ```

   By default, this will start the application using the default configuration (http://localhost:5100/swagger/index.html or https://localhost:7199/swagger/index.html).

## Project Structure

- `src/` or root: Contains the main source code for StudentsService.

## Troubleshooting

- Ensure you have the correct .NET SDK version installed.
- If you encounter restore/build issues, run `dotnet clean` and try again.
- For issues with ports or configuration, check `appsettings.json` and environment variables.


**Responsible:** [DaviLuquini](https://github.com/DaviLuquini)
