CREATE DATABASE CollegeDB;
USE CollegeDB;
ALTER TABLE College AUTO_INCREMENT = 1;
ALTER TABLE Department AUTO_INCREMENT = 1;
ALTER TABLE Department ADD CONSTRAINT unique_department UNIQUE (DepartmentName, DepartmentCode);
ALTER TABLE College ADD CONSTRAINT unique_college UNIQUE (CollegeName, CollegeCode);



-- ✅ Create College Table
CREATE TABLE College (
    CollegeID INT AUTO_INCREMENT PRIMARY KEY,
    CollegeName VARCHAR(255) NOT NULL,
    CollegeCode VARCHAR(10) NOT NULL,
    IsActive BIT DEFAULT 1
);

-- ✅ Create Department Table
CREATE TABLE Department (
    DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
    CollegeID INT,
    DepartmentName VARCHAR(255) NOT NULL,
    DepartmentCode VARCHAR(10) NOT NULL,
    IsActive BIT DEFAULT 1,
    FOREIGN KEY (CollegeID) REFERENCES College(CollegeID) ON DELETE CASCADE
);

-- Show Data 
-- 0 Active, 1 Inactive
SELECT * FROM College;
SELECT * FROM College WHERE IsActive = 1;
SELECT * FROM College WHERE IsActive = 0;


SELECT * FROM Department;
SELECT * FROM Department WHERE IsActive = 1;
SELECT * FROM Department WHERE IsActive = 0;

----















 








