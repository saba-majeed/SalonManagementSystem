# SalonManagnmentSystem - Deployment Guide

## System Requirements
- Windows 10 or higher
- .NET Framework 4.7.2
- MySQL Server 8.0
- Visual Studio 2019/2022

## Step 1: Install Required Software

### Install .NET Framework
1. Go to: https://dotnet.microsoft.com
2. Download .NET Framework 4.7.2
3. Install it

### Install MySQL
1. Go to: https://dev.mysql.com/downloads/installer
2. Download MySQL Installer
3. Install MySQL Server
4. Remember your root password!

## Step 2: Setup Database

1. Open MySQL Workbench
2. Connect to your MySQL server
3. Open the file: database query.sql
4. Run the script (press the lightning bolt button)
5. Database "SalonManagementDB" will be created automatically

## Step 3: Configure Connection

1. Open the project in Visual Studio
2. Go to: Database/DBConnection.cs
3. Find this line:
   "Server=localhost;Database=SalonManagementDB;Uid=root;Pwd=your password;"
4. Replace "yourpassword" with YOUR MySQL password

## Step 4: Run the Project

1. Open SalonManagementSystem.slnx in Visual Studio
2. Press F5 or click the Start button
3. Login with default credentials:
   Username: admin
   Password: admin123

## Default Login Credentials
| Username | Password | Role  |
|----------|----------|-------|
| admin    | admin123 | Admin |

## Troubleshooting
- If connection fails: Check MySQL is running
- If build fails: Check NuGet package MySql.Data is installed
- To install package: Tools → NuGet Package Manager → 
  search "MySql.Data" → Install
