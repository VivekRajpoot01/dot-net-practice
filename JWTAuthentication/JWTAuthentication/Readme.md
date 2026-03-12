# JWT Authentication and Authorization in ASP.NET Core Web API

This project demonstrates how to implement **Authentication and Authorization in an ASP.NET Core Web API using JSON Web Tokens (JWT)**.
It allows users to **register, login, generate JWT tokens, and access protected API endpoints**.

---

## 🚀 Features

* User Registration
* User Login
* JWT Token Generation
* Role-Based Authorization (Admin / User)
* ASP.NET Core Identity Integration
* SQL Server Database using Entity Framework Core
* Protected API endpoints using `[Authorize]`

---

## 🛠 Technologies Used

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core
* ASP.NET Identity
* JSON Web Tokens (JWT)
* SQL Server (LocalDB)
* Swagger / Postman for API testing

---

## 📁 Project Structure

```
Authentication
│
├── ApplicationUser.cs
├── ApplicationDbContext.cs
├── UserRoles.cs
├── RegisterModel.cs
├── LoginModel.cs
└── Response.cs

Controllers
└── AuthenticateController.cs

Program.cs
appsettings.json
```

---

## ⚙️ Setup Instructions

### 1️⃣ Install Required NuGet Packages

```
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNetCore.Authentication.JwtBearer
```

---

### 2️⃣ Configure Database

Update the connection string in **appsettings.json**

```
"ConnectionStrings": {
  "ConnStr": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JWTAuthDB;Integrated Security=True"
}
```

---

### 3️⃣ JWT Configuration

```
"JWT": {
  "ValidAudience": "http://localhost:4200",
  "ValidIssuer": "http://localhost:5000",
  "Secret": "THIS_IS_MY_SUPER_SECRET_KEY"
}
```

---

### 4️⃣ Apply Database Migration

Open **Package Manager Console** and run:

```
add-migration Initial
update-database
```

This will create the required **ASP.NET Identity tables** in SQL Server.

---

## 📌 API Endpoints

### Register User

```
POST /api/authenticate/register
```

Request Body

```
{
 "username": "vivek",
 "email": "vivek@gmail.com",
 "password": "Vivek@123"
}
```

---

### Login User

```
POST /api/authenticate/login
```

Request Body

```
{
 "username": "vivek",
 "password": "Vivek@123"
}
```

Response

```
{
 "token": "JWT_TOKEN",
 "expiration": "TOKEN_EXPIRATION_TIME"
}
```

---

### Register Admin

```
POST /api/authenticate/register-admin
```

Creates a user with **Admin role**.

---

## 🔐 Access Protected APIs

1. Login to obtain a JWT token
2. Add the token in request headers

```
Authorization: Bearer YOUR_JWT_TOKEN
```

---

## 📊 HTTP Status Codes

| Code | Meaning               |
| ---- | --------------------- |
| 200  | Success               |
| 401  | Unauthorized          |
| 403  | Forbidden             |
| 500  | Internal Server Error |

---

## 🧠 JWT Structure

A JWT token consists of three parts:

```
HEADER.PAYLOAD.SIGNATURE
```

Example

```
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

---

## 🎯 Learning Outcomes

* Understanding Authentication vs Authorization
* Implementing JWT-based security
* Working with ASP.NET Identity
* Securing APIs using tokens
* Role-based access control in Web APIs
