-- ================================================
-- Clinic Management System Database Script
-- MySQL Database Schema
-- Generated: January 21, 2026
-- ================================================

-- Create Database
CREATE DATABASE IF NOT EXISTS clinic_management;
USE clinic_management;

-- ================================================
-- DROP EXISTING TABLES (Clean Install)
-- Drop in reverse order of dependencies
-- ================================================
SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS medical_records;
DROP TABLE IF EXISTS appointments;
DROP TABLE IF EXISTS system_settings;
DROP TABLE IF EXISTS inventory;
DROP TABLE IF EXISTS audit_logs;
DROP TABLE IF EXISTS patients;
DROP TABLE IF EXISTS users;
SET FOREIGN_KEY_CHECKS = 1;

-- ================================================
-- Table: users
-- Description: Stores all system users (Admin, Clinic Staff, Students)
-- ================================================
CREATE TABLE IF NOT EXISTS users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Role ENUM('Admin', 'Clinic Staff', 'Student') NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Status ENUM('Active', 'Inactive') DEFAULT 'Active',
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    LastLogin DATETIME NULL,
    INDEX idx_username (Username),
    INDEX idx_role (Role),
    INDEX idx_status (Status)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- Table: audit_logs
-- Description: Tracks all system activities for security and monitoring
-- ================================================
CREATE TABLE IF NOT EXISTS audit_logs (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Activity VARCHAR(100) NOT NULL,
    Description TEXT,
    Status ENUM('Success', 'Failed', 'Warning') DEFAULT 'Success',
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_username (Username),
    INDEX idx_activity (Activity),
    INDEX idx_timestamp (Timestamp)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- Table: inventory
-- Description: Medical supplies and equipment inventory
-- ================================================
CREATE TABLE IF NOT EXISTS inventory (
    ItemID INT AUTO_INCREMENT PRIMARY KEY,
    ItemName VARCHAR(100) NOT NULL,
    Category VARCHAR(50),
    Quantity INT DEFAULT 0,
    Unit VARCHAR(20),
    MinimumStock INT DEFAULT 10,
    Price DECIMAL(10,2) DEFAULT 0.00,
    ExpiryDate DATE NULL,
    Status ENUM('Available', 'Low Stock', 'Out of Stock', 'Expired') DEFAULT 'Available',
    LastUpdated DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    INDEX idx_category (Category),
    INDEX idx_status (Status)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- Table: patients (Students)
-- Description: Student patient records
-- ================================================
CREATE TABLE IF NOT EXISTS patients (
    PatientID INT AUTO_INCREMENT PRIMARY KEY,
    StudentID VARCHAR(20) UNIQUE NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    DateOfBirth DATE,
    Gender ENUM('Male', 'Female', 'Other'),
    ContactNumber VARCHAR(20),
    Email VARCHAR(100),
    Address TEXT,
    EmergencyContact VARCHAR(100),
    EmergencyPhone VARCHAR(20),
    BloodType VARCHAR(5),
    Allergies TEXT,
    MedicalHistory TEXT,
    Status ENUM('Active', 'Inactive', 'Graduated') DEFAULT 'Active',
    RegisteredDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_studentid (StudentID),
    INDEX idx_status (Status)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- Table: appointments
-- Description: Clinic appointment scheduling
-- ================================================
CREATE TABLE IF NOT EXISTS appointments (
    AppointmentID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT NOT NULL,
    StaffID INT NOT NULL,
    AppointmentDate DATE NOT NULL,
    AppointmentTime TIME NOT NULL,
    Purpose VARCHAR(200),
    Status ENUM('Scheduled', 'Completed', 'Cancelled', 'No Show') DEFAULT 'Scheduled',
    Notes TEXT,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (PatientID) REFERENCES patients(PatientID) ON DELETE CASCADE,
    FOREIGN KEY (StaffID) REFERENCES users(UserID) ON DELETE CASCADE,
    INDEX idx_appointment_date (AppointmentDate),
    INDEX idx_status (Status)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- Table: medical_records
-- Description: Patient medical visit records
-- ================================================
CREATE TABLE IF NOT EXISTS medical_records (
    RecordID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT NOT NULL,
    StaffID INT NOT NULL,
    VisitDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    ChiefComplaint TEXT,
    Diagnosis TEXT,
    Treatment TEXT,
    Prescription TEXT,
    VitalSigns JSON,
    FollowUpDate DATE NULL,
    Notes TEXT,
    FOREIGN KEY (PatientID) REFERENCES patients(PatientID) ON DELETE CASCADE,
    FOREIGN KEY (StaffID) REFERENCES users(UserID) ON DELETE CASCADE,
    INDEX idx_visit_date (VisitDate)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- Table: system_settings
-- Description: Application configuration settings
-- ================================================
CREATE TABLE IF NOT EXISTS system_settings (
    SettingID INT AUTO_INCREMENT PRIMARY KEY,
    SettingKey VARCHAR(50) UNIQUE NOT NULL,
    SettingValue TEXT,
    Description VARCHAR(200),
    LastUpdated DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ================================================
-- INSERT DEFAULT DATA
-- ================================================

-- Insert Default Admin User (Password: admin123)
INSERT INTO users (Username, Password, FullName, Role, Email, Status) 
VALUES ('admin', 'admin123', 'System Administrator', 'Admin', 'admin@clinic.com', 'Active');

-- Insert Sample Clinic Staff (Password: staff123)
INSERT INTO users (Username, Password, FullName, Role, Email, Status) 
VALUES ('staff1', 'staff123', 'Dr. John Smith', 'Clinic Staff', 'john.smith@clinic.com', 'Active');

-- Insert Sample Student User (Password: student123)
INSERT INTO users (Username, Password, FullName, Role, Email, Status) 
VALUES ('student1', 'student123', 'Jane Doe', 'Student', 'jane.doe@student.edu', 'Active');

-- Insert Default System Settings
INSERT INTO system_settings (SettingKey, SettingValue, Description) VALUES
('ClinicName', 'University Health Clinic', 'Name of the clinic'),
('ClinicAddress', '123 Campus Drive, University City', 'Clinic address'),
('ClinicPhone', '+1 (555) 123-4567', 'Clinic contact number'),
('ClinicEmail', 'health@university.edu', 'Clinic email address'),
('BackupPath', 'C:\\ClinicBackups\\', 'Database backup location'),
('AutoBackup', 'true', 'Enable automatic backup'),
('EmailNotifications', 'true', 'Enable email notifications'),
('SystemNotifications', 'true', 'Enable system notifications');

-- Insert Sample Inventory Items
INSERT INTO inventory (ItemName, Category, Quantity, Unit, MinimumStock, Price, Status) VALUES
('Paracetamol 500mg', 'Medicine', 500, 'tablets', 100, 0.50, 'Available'),
('Ibuprofen 200mg', 'Medicine', 300, 'tablets', 100, 0.75, 'Available'),
('Bandages', 'Medical Supplies', 200, 'pieces', 50, 1.00, 'Available'),
('Gauze Pads', 'Medical Supplies', 150, 'packs', 30, 2.50, 'Available'),
('Surgical Gloves', 'Medical Supplies', 1000, 'pairs', 200, 0.25, 'Available'),
('Thermometer', 'Equipment', 25, 'pieces', 10, 15.00, 'Available'),
('Blood Pressure Monitor', 'Equipment', 10, 'pieces', 5, 50.00, 'Available'),
('Stethoscope', 'Equipment', 15, 'pieces', 5, 75.00, 'Available');

-- Insert Sample Audit Log
INSERT INTO audit_logs (Username, Activity, Description, Status) VALUES
('admin', 'Login', 'System administrator logged in', 'Success'),
('admin', 'User Management', 'Created default users', 'Success'),
('admin', 'System Setup', 'Initialized database', 'Success');

-- ================================================
-- END OF SCRIPT
-- ================================================

-- Display success message
SELECT 'Database created successfully! Default login credentials:' AS Message;
SELECT 'Admin - Username: admin, Password: admin123' AS AdminCredentials;
SELECT 'Staff - Username: staff1, Password: staff123' AS StaffCredentials;
SELECT 'Student - Username: student1, Password: student123' AS StudentCredentials;
