using Employees.Data;
using Employees.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class updateBtn : Form
    {
        DataService service;
        Employee toUpdate;
        public updateBtn()
        {
            InitializeComponent();
            service = new DataService();
            toUpdate = new Employee();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            showAddBtn();
            showEmployees();
        }

        private void showAddBtn()
        {
            updateButton.Hide();
            addButton.Show();
        }

        private void showUpdateBtn()
        {
            updateButton.Show();
            addButton.Hide();
        }

        private void showEmployees()
        {
            employeesDataGridView.Columns.Clear();
            genderCB.Items.Clear();
            jobCB.Items.Clear();
            departmentCB.Items.Clear();

            foreach(Gender gender in service.GetAllGenders())
            {
                genderCB.Items.Add(gender.Name);
            }

            foreach(Job job in service.GetAllJobs())
            {
                jobCB.Items.Add(job.Name);
            }

            foreach(Department department in service.GetAllDepartments())
            {
                departmentCB.Items.Add(department.Name);
            }

            firstNameTB.Text = string.Empty;
            lastNameTB.Text = string.Empty;
            birthDateDTP.Text = string.Empty;
            hireDateDTP.Text = string.Empty;
            workedHoursNUD.Text = string.Empty;
            genderCB.Text = string.Empty;
            jobCB.Text = string.Empty;
            departmentCB.Text = string.Empty;

            var employees = (from e in service.GetAllEmployees()
                             select new
                             {
                                 e.Id,
                                 e.FirstName,
                                 e.LastName,
                                 e.BirthDate,
                                 e.HireDate,
                                 e.WorkedHours,
                                 Gender = e.Gender1.Name,
                                 Job = e.Job1.Name,
                                 PayPerHour = e.Job1.PayPerHour,
                                 Department = e.Department1.Name,
                                 Salary = (e.WorkedHours * e.Job1.PayPerHour)
                             });
            employeesDataGridView.DataSource = employees.ToList();
            employeesDataGridView.Columns[0].Visible = false;

            employeesDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Employees.Properties.Resources.update,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Update",
                Name = "update"
            });
            employeesDataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Employees.Properties.Resources.delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                HeaderText = "Delete",
                Name = "delete"
            });
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeesDataGridView.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                try
                {
                    service.DeleteEmployee(service.FindEmployeeById((int)employeesDataGridView.Rows[e.RowIndex].Cells[0].Value).Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                showEmployees();
            }

            if (employeesDataGridView.Columns[e.ColumnIndex].Name.Equals("update"))
            {
                toUpdate = service.FindEmployeeById((int)employeesDataGridView.Rows[e.RowIndex].Cells[0].Value);

                firstNameTB.Text = toUpdate.FirstName;
                lastNameTB.Text = toUpdate.LastName;
                birthDateDTP.Value = toUpdate.BirthDate;
                hireDateDTP.Value = toUpdate.HireDate;
                workedHoursNUD.Value = toUpdate.WorkedHours;
                genderCB.Text = toUpdate.Gender1.Name;
                jobCB.Text = toUpdate.Job1.Name;
                departmentCB.Text = toUpdate.Department1.Name;

                showUpdateBtn();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    FirstName = firstNameTB.Text,
                    LastName = lastNameTB.Text,
                    BirthDate = birthDateDTP.Value,
                    HireDate = hireDateDTP.Value,
                    WorkedHours = (int)workedHoursNUD.Value,
                    Gender = service.FindGenderByName(genderCB.Text).Id,
                    Job = service.FindJobByName(jobCB.Text).Id,
                    Department = service.FindDepartmentByName(departmentCB.Text).Id
                };
                service.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            showEmployees();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                toUpdate.FirstName = firstNameTB.Text;
                toUpdate.LastName = lastNameTB.Text;
                toUpdate.BirthDate = birthDateDTP.Value;
                toUpdate.HireDate = hireDateDTP.Value;
                toUpdate.WorkedHours = (int)workedHoursNUD.Value;
                toUpdate.Gender = service.FindGenderByName(genderCB.Text).Id;
                toUpdate.Job = service.FindJobByName(jobCB.Text).Id;
                toUpdate.Department = service.FindDepartmentByName(departmentCB.Text).Id;

                service.UpdateEmployee(toUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showAddBtn();
            showEmployees();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks tasks = new Tasks();
            tasks.ShowDialog();
            this.Show();
        }
    }
}
