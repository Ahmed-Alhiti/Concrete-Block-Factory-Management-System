# Concrete Block Factory Management System

A desktop-based **3-tier architecture** application built using **C# (WinForms)**, **.NET Framework**, and **SQL Server**, designed to manage all daily operations inside a concrete block factory, including production, purchases, inventory, sales, and financial processes.

---

## 🧱 Overview

The **Concrete Block Factory Management System** provides a complete workflow solution for managing the daily activities of concrete block production.  
It ensures accuracy, real-time data tracking, and smooth coordination between production, inventory, suppliers, and finance.

The system follows a **3-Tier Architecture** to enhance scalability, maintainability, and data security.

---

## 🧩 Core Features

### 🏭 Production Management
- Daily production entry for concrete blocks.
- Track quantities produced per day.
- Calculate material usage based on production output.

### 🛒 Raw Material Purchasing
- Record purchase orders for raw materials (cement, sand, gravel, etc.).
- Track supplier deliveries and invoice amounts.
- Maintain supplier histories and outstanding balances.

### 📦 Real-Time Inventory Tracking
- Auto-update inventory on production, sales, and purchases.
- Monitor raw materials and finished products.
- Alerts when stock reaches minimum threshold.

### 💰 Sales and Customer Management
- Register customers and manage their orders.
- Generate sales invoices.
- Track customer balances and payments.

### 🧾 Supplier Payments & Financial Transactions
- Record supplier payment vouchers.
- Track payable accounts and supplier balances.

### 🔄 Currency & Exchange Rate Support
- Set daily exchange rates.
- Convert transactions between currencies automatically.

### 📊 Reports & Analytics
Generate detailed reports including:
- Daily production reports
- Purchase reports
- Sales reports
- Inventory movement reports
- Financial transactions
- Supplier and customer statements

### 🔐 User Roles & Access Control
- Role-based permissions  
- Admin, accountant, production manager, warehouse officer, etc.
- Ensures secure access to sensitive financial and operational data.

---

## 🏗 Architecture
- **Presentation Layer:** WinForms UI  
- **Business Logic Layer (BLL)**  
- **Data Access Layer (DAL):** SQL Server + ADO.NET  

This separation ensures better maintainability and easier scalability.

---

## 🛠 Technologies Used
- C# – .NET Framework  
- WinForms  
- SQL Server  
- ADO.NET  
- 3-Tier Architecture  

---

## 📥 Installation & Setup

### 1️⃣ Open the Project
- Open the solution file (`.sln`) using **Visual Studio**.

### 2️⃣ Restore Dependencies
- Restore **NuGet packages** (if required).

### 3️⃣ Prepare the Database
- Open **SQL Server Management Studio (SSMS)**.
- Execute the provided `.sql` script to create tables, stored procedures, and seed data.

### 4️⃣ Update Configuration
- Set your connection string in : DataAccessLayer\clsConnection.cs
  
