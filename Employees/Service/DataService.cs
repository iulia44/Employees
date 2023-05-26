using Employees.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
    public class DataService
    {
        private readonly DbRepository db;

        public DataService()
        {
            db = new DbRepository();
        }

        // Gender methods

        public List<Gender> GetAllGenders()
        {
            return db.Genders.ToList();
        }

        public Gender FindGenderById(int id)
        {
            return db.Genders.Find(id);
        }

        public Gender FindGenderByName(string name)
        {
            var gender = db.Genders.FirstOrDefault(g => g.Name == name);
            if (gender == null)
            {
                throw new Exception("Gender not found.");
            }
            return gender;
        }


        public void AddGender(Gender gender)
        {
            db.Genders.Add(gender);
            db.SaveChanges();
        }

        public void UpdateGender(Gender gender)
        {
            var existingGender = db.Genders.Find(gender.Id);
            if (existingGender != null)
            {
                existingGender.Name = gender.Name;
                db.SaveChanges();
            }
        }

        public void DeleteGender(int genderId)
        {
            var gender = db.Genders.Find(genderId);
            if (gender != null)
            {
                db.Genders.Remove(gender);
                db.SaveChanges();
            }
        }

        // Department methods

        public List<Department> GetAllDepartments()
        {
            return db.Departments.ToList();
        }

        public Department FindDepartmentById(int id)
        {
            return db.Departments.Find(id);
        }

        public Department FindDepartmentByName(string name)
        {
            var department = db.Departments.FirstOrDefault(d => d.Name == name);
            if (department == null)
            {
                throw new Exception("Department not found.");
            }
            return department;
        }

        public void AddDepartment(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            var existingDepartment = db.Departments.Find(department.Id);
            if (existingDepartment != null)
            {
                existingDepartment.Name = department.Name;
                db.SaveChanges();
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            var department = db.Departments.Find(departmentId);
            if (department != null)
            {
                db.Departments.Remove(department);
                db.SaveChanges();
            }
        }

        // Job methods

        public List<Job> GetAllJobs()
        {
            return db.Jobs.ToList();
        }

        public Job FindJobById(int id)
        {
            return db.Jobs.Find(id);
        }

        public Job FindJobByName(string name)
        {
            var job = db.Jobs.FirstOrDefault(j => j.Name == name);
            if (job == null)
            {
                throw new Exception("Job not found.");
            }
            return job;
        }


        public void AddJob(Job job)
        {
            db.Jobs.Add(job);
            db.SaveChanges();
        }

        public void UpdateJob(Job job)
        {
            var existingJob = db.Jobs.Find(job.Id);
            if (existingJob != null)
            {
                existingJob.Name = job.Name;
                existingJob.PayPerHour = job.PayPerHour;
                db.SaveChanges();
            }
        }

        public void DeleteJob(int jobId)
        {
            var job = db.Jobs.Find(jobId);
            if (job != null)
            {
                db.Jobs.Remove(job);
                db.SaveChanges();
            }
        }

        // Employee methods

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee FindEmployeeById(int id)
        {
            return db.Employees.Find(id);
        }

        public Employee FindEmployeeByUniqueFields(string firstName, string lastName, DateTime birthDate)
        {
            return db.Employees.FirstOrDefault(e =>
                e.FirstName == firstName &&
                e.LastName == lastName &&
                e.BirthDate == birthDate);
        }

        public void AddEmployee(Employee employee)
        {
            ValidateEmployee(employee);

            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = db.Employees.Find(employee.Id);
            if (existingEmployee != null)
            {
                ValidateEmployee(employee);
            
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.BirthDate = employee.BirthDate;
                existingEmployee.HireDate = employee.HireDate;
                existingEmployee.WorkedHours = employee.WorkedHours;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Job = employee.Job;
                existingEmployee.Department = employee.Department;

                db.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = db.Employees.Find(employeeId);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        private void ValidateEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                throw new Exception("First name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(employee.LastName))
                throw new Exception("Last name cannot be null or empty.");

            if (employee.BirthDate == DateTime.MinValue)
                throw new Exception("Birth date cannot be null.");

            if (employee.HireDate == DateTime.MinValue)
                throw new Exception("Hire date cannot be null.");

            if (employee.WorkedHours < 0)
                throw new Exception("Worked hours cannot be negative.");

            if (db.Genders.Find(employee.Gender) == null)
                throw new Exception("Invalid gender.");

            if (db.Jobs.Find(employee.Job) == null)
                throw new Exception("Invalid job.");

            if (db.Departments.Find(employee.Department) == null)
                throw new Exception("Invalid department.");
        }
    }
}
