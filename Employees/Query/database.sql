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
	   g.Name AS GENDER, 
	   j.Name AS Job, 
	   j.PayPerHour, 
	   d.Name AS Department,
	   (e.WorkedHours * j.PayPerHour) AS Salary
FROM Employee e
INNER JOIN Department d ON e.Department = d.Id
INNER JOIN Job j ON e.Job = j.Id
INNER JOIN Gender g ON e.Gender = g.Id