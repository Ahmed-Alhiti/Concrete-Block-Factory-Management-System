# 🧱 Concrete Block Factory Management System

![C#](https://img.shields.io/badge/Language-C%23-blue) 
![WinForms](https://img.shields.io/badge/Framework-WinForms-orange)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)

A **desktop-based 3-tier application** built using **C# (WinForms), .NET Framework, and SQL Server**, designed to manage daily operations in a concrete block factory efficiently.

The system covers production, inventory, suppliers, sales, and financial management, with real-time monitoring and reporting capabilities.  
It also includes a **battery percentage indicator** displayed in the system using **Win32 API**, helping operators monitor laptop or UPS power status during factory operations.

---

## ✨ Key Features

> 💡 **Production Management**
- Daily production entry for concrete blocks.  
- Track production quantities and material usage.  

> 💡 **Raw Material Purchasing**
- Record purchases of cement, sand, gravel, etc.  
- Manage supplier deliveries and invoices.  
- Maintain supplier payment history.

> 💡 **Sales & Customer Management**
- Register and manage customer orders.  
- Generate sales invoices and track payments.

> 💡 **Inventory Tracking**
- Real-time inventory updates for raw materials and finished products.  
- Alerts when stock reaches minimum levels.  

> 💡 **Financial & Supplier Transactions**
- Record supplier payments and vouchers.  
- Monitor accounts payable and outstanding balances.

> 💡 **Reports & Analytics**
- Detailed production, purchase, sales, and transaction reports.  
- Inventory movement reports for better planning.

> 💡 **Battery Status Indicator**
- Display current battery percentage directly in the system UI.  
- Implemented using **Win32 API** for accurate Windows system integration.

---

## 🏗 Architecture

**3-Tier Architecture** ensures maintainability, scalability, and secure data management.

---

## 🛠 Technologies Used

| Layer | Technology |
|-------|-----------|
| UI / Presentation | WinForms |
| Logic / Business | C# – .NET Framework |
| Data / Storage | SQL Server + ADO.NET |
| Architecture | 3-Tier |

---

## 📥 Installation & Setup

1️⃣ **Open Project**  
Open the `.sln` solution file in **Visual Studio**.

2️⃣ **Restore Dependencies**  
Restore **NuGet packages** if needed.

3️⃣ **Prepare the Database**  
Open **SQL Server Management Studio (SSMS)** and run the provided `.sql` script to create tables and seed initial data.

4️⃣ **Update Configuration**  
Set your SQL Server connection string in: DataAccessLayer\clsConnection.cs

5️⃣ **Run Application**  
Press **F5** in Visual Studio to launch the system.

