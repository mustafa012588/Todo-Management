
#  Todo Management App

A simple Todo Management web application built with ASP.NET Core and Bootstrap.

---

##  Features Implemented

-  Create, Read, Update, and Delete (CRUD) operations for todos
-  Basic validation (title required, max 100 chars, etc.)
-  SQL Server integration using Entity Framework Core
-  Clean UI built with Bootstrap and plain JavaScript
-  CORS enabled for frontend-backend integration

---

##  Not Implemented

-  PATCH endpoint (e.g., mark as complete) — replaced by full update using PUT
-  Domain events or DDD principles
-  ABP Framework usage

---

##  Technologies Used

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- Bootstrap (via CDN)
- JavaScript, HTML

---

##  How to Run the Project

###  Backend (ASP.NET Core API)

1. Clone the repository:

   ```bash
   git clone https://github.com/mustafa012588/Todo-Management
   cd todo-app
   ```

2. Update the connection string in `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=TodoDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```

3. Run the following commands:

   ```bash
   dotnet restore
   dotnet ef database update
   dotnet run
   ```

4. Swagger UI will be available at `https://localhost:<port>/swagger`.

---

###  Frontend (index.html)

1. Open `index.html` in a browser using a local server (e.g., Live Server in VS Code).
2. Make sure the backend API is running.
3. All interactions (add, edit, delete) are done via the UI and connected to the API.

---

##  Notes

- CORS is enabled globally in `Program.cs` for development purposes.
- PATCH endpoints were removed — task completion is handled via a full PUT update instead.

---

##  What Was Challenging

- Setting up CORS correctly to allow frontend communication.
- Keeping the frontend simple but functional without any frameworks.
- Deciding on using PUT instead of PATCH due to simplicity and time.

---

##  Developed by

**Mostafa Alaa**  
Email: [mustafa012588@gmail.com]  
GitHub: [https://github.com/mustafa012588/Todo-Management]
