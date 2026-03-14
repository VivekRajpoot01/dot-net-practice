# Student Management System (Case Study) — ASP.NET Core MVC Web App + EF Core

## Overview
This case study project is a **Student Management System** built using **ASP.NET Core MVC (.NET 8)** and **Entity Framework Core (SQL Server provider)**.  
It demonstrates a typical layered MVC structure with:

- **Models** for core entities (User, Student, Course, Department)
- **Controllers** for handling CRUD operations and account flows
- **EF Core DbContext** for database access and relationships
- **Views** for UI pages (Razor)

> Project path: `StudentManagementSystem_CaseStudy/StudentManagementSystem_CaseStudy`

---

## Tech Stack
- **Framework:** .NET 8 (ASP.NET Core MVC)
- **ORM:** Entity Framework Core 8
- **Database:** SQL Server (via EF Core provider)
- **Architecture:** MVC (Controllers + Views + Models)
- **Configuration:** `appsettings.json`, `appsettings.Development.json`

---

## Solution / Project Structure

Key folders/files in this project:

- `Controllers/`
  - `AccountController.cs`
  - `StudentController.cs`
  - `CourseController.cs`
  - `DepartmentController.cs`
  - `TeacherDashboardController.cs`
  - `StudentDashboardController.cs`
  - `HomeController.cs`
- `Models/`
  - `User.cs`
  - `Student.cs`
  - `Course.cs`
  - `Department.cs`
  - `ErrorViewModel.cs`
- `Data/`
  - `ApplicationDbContext.cs`
- `Migrations/` (EF Core migration files)
- `Views/` (Razor UI)
- `wwwroot/` (static files)
- `Program.cs` (application bootstrap)
- `StudentManagementSystem_CaseStudy.csproj` (project file)

---

## Features Implemented

### 1) Account / User Module
The project contains an `AccountController`, and the default startup route points to:

- **Controller:** `Account`
- **Action:** `Register`

So, when you run the app, it opens the registration flow by default.

**User model fields (stored in DB):**
- `FullName`
- `Email`
- `Password`
- `Role` (example roles: **Teacher** or **Student**)

> Note: This is a learning/case-study implementation. If you extend it, you should hash passwords and consider ASP.NET Core Identity.

---

### 2) Student Management
A `StudentController` exists for student-related operations (typically CRUD).

**Student entity includes:**
- `StudentName`, `Email`, `PhoneNumber`, `Address`
- `DepartmentId` (FK)
- `CourseId` (FK)
- Navigation properties: `Department`, `Course`

This models the idea that each student belongs to a **Department** and is associated with a **Course**.

---

### 3) Course Management
A `CourseController` exists for course-related operations (typically CRUD).

**Course entity includes:**
- `CourseName`
- `Duration` (int)
- `Fees` (decimal)
- `DepartmentId` (FK)
- Navigation property: `Department`

---

### 4) Department Management
A `DepartmentController` exists for department-related operations (typically CRUD).

**Department entity includes:**
- `DepartmentName` (required)
- `Description`

---

### 5) Dashboards (Role-based Pages)
The project includes:
- `TeacherDashboardController`
- `StudentDashboardController`

This suggests separate dashboard experiences for Teacher vs Student roles.

---

## Database Design (Entity Framework Core)

### ApplicationDbContext
The EF Core context is `ApplicationDbContext`, which defines the following tables:

- `Users`
- `Students`
- `Courses`
- `Departments`

### Relationships
EF Core configuration in `OnModelCreating` defines:

- `Student -> Department` (FK: `DepartmentId`)
- `Student -> Course` (FK: `CourseId`)
- Both relationships use **DeleteBehavior.Restrict** (prevents cascading delete)

This means you generally cannot delete a Department/Course if students still reference it (unless you remove/update the students first).

---

## How to Run the Project

### Prerequisites
- .NET SDK **8.0**
- SQL Server (LocalDB / SQL Express / SQL Server)

### Steps
1. Open the solution/project in Visual Studio (or use CLI).
2. Configure a SQL Server connection string named **DefaultConnection**.
3. Apply EF Core migrations.
4. Run the application.

When the app starts, it uses the route:

`{controller=Account}/{action=Register}/{id?}`

So the app will open at the Register page by default.

---

## Configuration Notes

### appsettings.json
Currently includes logging + allowed hosts.  
For database usage, you should add a connection string like:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=...;Database=...;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

(Adjust values depending on your SQL Server setup.)

---

## Learning Objectives (What this case study demonstrates)
- Building an ASP.NET Core MVC application using .NET 8
- Creating data models with relationships (Student–Course–Department)
- Using EF Core DbContext + migrations for database schema
- Organizing MVC controllers for separate modules (Account/Student/Course/Department)
- Basic role-based separation using Teacher/Student dashboards

---

## Possible Improvements (Optional Enhancements)
- Use **ASP.NET Core Identity** for authentication/authorization
- Hash + salt passwords (never store raw passwords)
- Add validation attributes to remaining model fields (Student/Course fields)
- Add authorization filters (only Teacher can manage Courses/Departments, etc.)
- Add pagination/search for Students/Courses
- Add seed data for Departments/Courses

---

## Author
- GitHub: `VivekRajpoot01`
