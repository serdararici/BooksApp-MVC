# 📚 Books App - ASP.NET Core MVC Book Management Application

A full-stack web application for book and category management, built with ASP.NET Core MVC and .NET 8. The project features layered architecture, authentication, CRUD operations, and responsive UI. Created as a learning project by following a comprehensive YouTube tutorial.

![Books App Screenshot](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/Admin_HomePage.png)

## 🔍 Overview

Books App is a role-based web application designed with clean architecture principles. It includes two user roles: **Admin** and **Customer**.

- **Admin** can manage categories and products (books) with full CRUD functionality.
- **Customer** can view the product list in a clean and user-friendly interface.

The project integrates **authentication and authorization**, **Entity Framework Core**, and a **layered architecture** to demonstrate a production-like backend structure. It also includes a modern responsive UI using **Bootstrap**, as well as user interaction enhancements with **Toastr** notifications and **TinyMCE** rich text editor.

---

## 🛠 Technologies & Tools

- **Framework:** ASP.NET Core MVC (.NET 8)
- **Language:** C#
- **Database:** MS SQL Server
- **ORM:** Entity Framework Core
- **Authentication & Authorization:** ASP.NET Identity
- **UI Framework:** Bootstrap 5
- **Text Editor:** TinyMCE (for product description)
- **Notifications:** Toastr.js
- **IDE:** Visual Studio 2022

---

## 🧱 Architecture

The project follows a clean, modular, and scalable architecture:

- **Layered Structure:**
  - `Models` – Application models like `Category`, `Product`, and `ApplicationUser`.
  - `DataAccess` – Contains DB context (`ApplicationDbContext`), repositories, and interfaces.
  - `Utilities` – Helper classes and constants.

- **Design Patterns:**
  - **Repository Pattern** – For abstracting data access.
  - **Dependency Injection** – Used throughout the project (e.g., Singleton services).

- **ASP.NET MVC Features:**
  - **Areas:** Admin and Customer areas separate business logic and views.
  - **CRUD Operations:** Implemented for both `Category` and `Product` entities.
  - **Role-Based Access Control:** Admins manage data; customers view products only.

---

## 🗄️ Database
The application uses MS SQL Server as its database and integrates it via Entity Framework Core using Code-First approach.

- Custom ApplicationDbContext handles the connection and database logic.

- Identity tables are included by default for user authentication and role management.

- The main application tables include:

  - **Categories**

  - **Products**

  - **ApplicationUsers**

Entity relationships are set up through navigation properties. Each product belongs to a category, and the admin user can perform all data operations on these entities via the admin panel.

📷 Below is a snapshot of the database structure (as viewed from SQL Server Management Studio):

### Tables:

![Database Tables](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Database%20Images/Databse_Tables.JPG)

### Products Table: 

![Database Products](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Database%20Images/Database_BooksTable.JPG)

---

## 🧠 Learned Skills & Experience

By building this project, I gained practical experience in:

- Implementing **layered architecture** in enterprise-level web applications.
- Performing **CRUD operations** using **Entity Framework Core**.
- Managing user roles and permissions with **ASP.NET Identity**.
- Structuring scalable code with the **Repository Pattern**.
- Creating **responsive UI layouts** with **Bootstrap**.
- Enhancing UX with **Toastr** notifications and **TinyMCE** editors.
- Applying **Dependency Injection** for service configuration.
- Using **Areas** in ASP.NET MVC for better organization.

This project helped me strengthen my backend development skills with ASP.NET Core and improve my confidence in building real-world applications.

---

## 📘 Learning Resources

This project was developed by following an excellent YouTube tutorial series that explains every step in detail:

🎥 **YouTube Tutorial:**  
[Build a Full ASP.NET Core MVC Application](https://www.youtube.com/watch?v=AopeJjkcRvU&list=PLQ1WykSPGHRhXRxVpGpOE_pSl0MuIOw7-&index=11)

---

## 🖼️ Project Screenshots

Below are screenshots from various pages of the application, showcasing both **Admin** and **Customer** functionalities such as CRUD operations, authentication, and product browsing.

### 🏠 Home Page  
![Home Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/HomePage.png)

### 📋 Product List Page  
![Product List Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/ProductList.png)

### 🔍 Product Details Page  
![Product Details Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/ProductDetails.png)

### ➕ Create Product Page  
![Create Product Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/CreateProduct.png)

### ✏️ Update Product Page  
![Update Product Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/UpdateProduct.png)

### ❌ Delete Product Page  
![Delete Product Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/DeleteProduct.png)

### 🗂️ Category List Page  
![Category List Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/CategoryList.png)

### 🧾 Register Page  
![Register Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/RegisterPage.png)

### 🔐 Login Page  
![Login Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/LoginPage.png)

### 👤 Profile Page  
![Profile Page](https://github.com/serdararici/BooksApp-MVC/blob/master/Documents/Project%20Screenshots/ProfilePage.png)


---

**Feel free to fork, star, or explore the project for your own learning journey!**
