
# 🔐 ASP.NET Core Authentication & Authorization API

> A secure ASP.NET Core API with JWT authentication, role-based authorization, and refresh token support. Users can register, log in, and access protected routes based on roles. Uses SQL Server with EF Core, controller-based routing, and secure password hashing.

---

## 📌 Overview

This project is a complete backend solution built with **ASP.NET Core** and **SQL Server** to manage secure user authentication and role-based access control. It uses **JWT tokens** for session handling and includes a **refresh token** mechanism to ensure smooth token renewal without forcing re-login.

---

## ✅ Key Features

- 🔑 **JWT-Based Authentication (Login/Register)**
- 🔁 **Refresh Token Implementation** to extend session without login
- 👮 **Role-Based Authorization** (e.g., Admin, User)
- 🧠 **Secure Password Hashing & Salting**
- 🧩 **Clean Controller-Based Routing Structure**
- 🛢️ **SQL Server Integration via Entity Framework Core**
- 🧰 **Dependency Injection & Middleware for Token Handling**
- 🧾 **Claims-Based Identity System**

---

## 🛠 Tech Stack

- **Framework:** ASP.NET Core (.NET 6/7)
- **Language:** C#
- **Authentication:** JWT + Refresh Tokens
- **Authorization:** Role-Based
- **Database:** SQL Server
- **ORM:** Entity Framework Core

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name
```

### 2. Configure SQL Server

- Update your SQL Server connection string in `appsettings.json`.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=AuthDb;Trusted_Connection=True;"
}
```

### 3. Run Migrations and Create Database

```bash
dotnet ef database update
```

### 4. Run the Application

```bash
dotnet run
```

---

## 🔗 API Endpoints

| Method | Endpoint             | Description                    |
|--------|----------------------|--------------------------------|
| POST   | `/api/auth/register` | Register new user              |
| POST   | `/api/auth/login`    | User login and token generation|
| POST   | `/api/auth/refresh`  | Refresh JWT using refresh token|
| GET    | `/api/admin/data`    | Protected route for Admin role |
| GET    | `/api/user/data`     | Protected route for User role  |

---

## 📚 Folder Structure (Sample)

```
/Controllers
    AuthController.cs
    UserController.cs
/Models
    User.cs
    Role.cs
/Data
    ApplicationDbContext.cs
/Services
    TokenService.cs
```

---

## 📬 Feedback & Contribution

- ⭐ Star the repo if you find it helpful
- 📥 Feel free to open issues or submit pull requests
- 🧪 Suggestions and improvements are always welcome

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).
