USE MASTER;

GO

DROP DATABASE IF EXISTS EmployeesDB;

GO

CREATE DATABASE EmployeesDB;

GO

USE EmployeesDB;

GO

-- TABLES

CREATE TABLE Gender(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL
);

GO

INSERT INTO Gender
	VALUES
		('Female'),
		('Male');

GO

CREATE TABLE Department(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL
);

GO

INSERT INTO Department ("Name")
VALUES ('Sales'),
       ('Marketing'),
       ('Engineering'),
       ('Finance'),
       ('Human Resources');


GO

CREATE TABLE Job(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL,
	PayPerHour FLOAT NOT NULL
);

GO

INSERT INTO Job ("Name", PayPerHour)
VALUES ('Sales Manager', 25.50),
       ('Marketing Coordinator', 20.75),
       ('Software Engineer', 35.00),
       ('Financial Analyst', 30.25),
       ('HR Specialist', 22.50);

GO

CREATE TABLE Employee (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	BirthDate DATE NOT NULL,
	HireDate DATE NOT NULL,
	WorkedHours INT NOT NULL,
	Gender INT FOREIGN KEY REFERENCES Gender(Id) NOT NULL,
	Job INT FOREIGN KEY REFERENCES Job(Id) NOT NULL,
	Department INT FOREIGN KEY REFERENCES Department(Id) NOT NULL
);

GO

-- /TABLES

DROP VIEW IF EXISTS EmployeesView;

GO

CREATE VIEW EmployeesView AS
SELECT e.FirstName, 
	   e.LastName, 
	   e.BirthDate, 
	   e.HireDate, 
	   e.WorkedHours, 
	   g.Name AS Gender, 
	   j.Name AS Job, 
	   j.PayPerHour, 
	   d.Name AS Department,
	   (e.WorkedHours * j.PayPerHour) AS Salary,
	   FLOOR(DATEDIFF(DAY, e.BirthDate , GETDATE()) / 365.25) AS Age,
	   FLOOR(DATEDIFF(DAY, e.HireDate , GETDATE()) / 365.25) AS WorkExperience
FROM Employee e
INNER JOIN Department d ON e.Department = d.Id
INNER JOIN Job j ON e.Job = j.Id
INNER JOIN Gender g ON e.Gender = g.Id

GO

DROP VIEW IF EXISTS YoungestEmployee;

GO

CREATE VIEW YoungestEmployee AS
SELECT * FROM EmployeesView ev
WHERE ev.BirthDate = (
	SELECT MAX(ev.BirthDate) FROM EmployeesView ev
	);

GO

CREATE VIEW Retirees AS
SELECT TOP 9999 * FROM EmployeesView ev
WHERE (ev.Gender = 'Male' AND ev.Age >= 62) OR (ev.Gender = 'Female' AND ev.Age >= 57)
ORDER BY ev.Age;

GO

DROP VIEW IF EXISTS AvgSalaryPerDepartment;

GO

CREATE VIEW AvgSalaryPerDepartment AS
SELECT d.Name, AVG(e.WorkedHours * j.PayPerHour) AS AvgSalary FROM Employee e
INNER JOIN Department d ON e.Department = d.Id
INNER JOIN Job j ON e.Job = j.Id
INNER JOIN Gender g ON e.Gender = g.Id
WHERE g.Name = 'Male'
GROUP BY d.Name

GO

CREATE VIEW FemalesWorkExpLessThan5Years AS
SELECT * FROM EmployeesView ev
WHERE Gender = 'Female' AND WorkExperience < 5;

GO

CREATE VIEW NoOfEmployeesPerJob AS
SELECT Job, COUNT(*) AS NoOfEmployees FROM EmployeesView
GROUP BY Job;

GO

CREATE VIEW Top3Employees AS
SELECT TOP 3 * FROM EmployeesView 
ORDER BY WorkedHours DESC;

GO

CREATE VIEW OnlyMales AS
SELECT * FROM EmployeesView
WHERE Gender = 'Male';