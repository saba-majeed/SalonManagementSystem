CREATE DATABASE IF NOT EXISTS SalonManagementDB;
USE SalonManagementDB;

-- =============================================
-- USERS TABLE: Login ke liye
-- =============================================
CREATE TABLE Users (
    UserID   INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50)  NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role     VARCHAR(20)  NOT NULL DEFAULT 'Staff',
    CreatedAt DATETIME    DEFAULT CURRENT_TIMESTAMP
);

-- =============================================
-- CUSTOMERS TABLE: Salon ke customers
-- =============================================
CREATE TABLE Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FullName   VARCHAR(100) NOT NULL,
    Phone      VARCHAR(20),
    Email      VARCHAR(100),
    Address    VARCHAR(255),
    CreatedAt  DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- =============================================
-- STAFF TABLE: Salon ke employees
-- =============================================
CREATE TABLE Staff (
    StaffID        INT AUTO_INCREMENT PRIMARY KEY,
    FullName       VARCHAR(100) NOT NULL,
    Phone          VARCHAR(20),
    Specialization VARCHAR(100),
    Salary         DECIMAL(10,2),
    JoiningDate    DATE,
    IsActive       TINYINT(1) DEFAULT 1
);

-- =============================================
-- SERVICES TABLE: Haircut, facial wagera
-- =============================================
CREATE TABLE Services (
    ServiceID       INT AUTO_INCREMENT PRIMARY KEY,
    ServiceName     VARCHAR(100) NOT NULL,
    Description     VARCHAR(255),
    Price           DECIMAL(10,2) NOT NULL,
    DurationMinutes INT
);

-- =============================================
-- INVENTORY TABLE: Products aur stock
-- =============================================
CREATE TABLE Inventory (
    ItemID      INT AUTO_INCREMENT PRIMARY KEY,
    ItemName    VARCHAR(100) NOT NULL,
    Quantity    INT           DEFAULT 0,
    UnitPrice   DECIMAL(10,2),
    Supplier    VARCHAR(100),
    LastUpdated DATETIME DEFAULT CURRENT_TIMESTAMP
                         ON UPDATE CURRENT_TIMESTAMP
);

-- =============================================
-- APPOINTMENTS TABLE: Customer bookings
-- =============================================
CREATE TABLE Appointments (
    AppointmentID   INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID      INT,
    StaffID         INT,
    ServiceID       INT,
    AppointmentDate DATETIME     NOT NULL,
    Status          VARCHAR(20)  DEFAULT 'Pending',
    Notes           VARCHAR(255),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (StaffID)    REFERENCES Staff(StaffID),
    FOREIGN KEY (ServiceID)  REFERENCES Services(ServiceID)
);

-- =============================================
-- DEFAULT ADMIN USER: Password = admin123
-- =============================================
INSERT INTO Users (Username, Password, Role)
VALUES ('admin', 'admin123', 'Admin');