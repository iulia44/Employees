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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            panelCB.Items.Add("Task 3");
            panelCB.Items.Add("Task 4");
            panelCB.Items.Add("Task 5");
            panelCB.Items.Add("Task 6");
            panelCB.Items.Add("Task 7");
            panelCB.Items.Add("Task 8");
            panelCB.Items.Add("Task 9");
            panelCB.Items.Add("Task 10");
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            //panel9.Hide();
            //panel10.Hide();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasksDataSet.NoOfEmployeesPerJob' table. You can move, or remove it, as needed.
            this.noOfEmployeesPerJobTableAdapter.Fill(this.tasksDataSet.NoOfEmployeesPerJob);
            // TODO: This line of code loads data into the 'tasksDataSet.EmployeesView' table. You can move, or remove it, as needed.
            this.employeesViewTableAdapter.Fill(this.tasksDataSet.EmployeesView);
            // TODO: This line of code loads data into the 'tasksDataSet.FemalesWorkExpLessThan5Years' table. You can move, or remove it, as needed.
            this.femalesWorkExpLessThan5YearsTableAdapter.Fill(this.tasksDataSet.FemalesWorkExpLessThan5Years);
            // TODO: This line of code loads data into the 'tasksDataSet.AvgSalaryPerDepartment' table. You can move, or remove it, as needed.
            this.avgSalaryPerDepartmentTableAdapter.Fill(this.tasksDataSet.AvgSalaryPerDepartment);
            // TODO: This line of code loads data into the 'tasksDataSet.Retirees' table. You can move, or remove it, as needed.
            this.retireesTableAdapter.Fill(this.tasksDataSet.Retirees);
            // TODO: This line of code loads data into the 'tasksDataSet.YoungestEmployee' table. You can move, or remove it, as needed.
            this.youngestEmployeeTableAdapter.Fill(this.tasksDataSet.YoungestEmployee);
            this.task3RW.RefreshReport();
            this.task4RW.RefreshReport();
            this.task5RW.RefreshReport();
            this.task6RW.RefreshReport();
            this.task7RW.RefreshReport();
            this.task8RW.RefreshReport();
        }

        private void showPanel_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            //panel9.Hide();
            //panel10.Hide();

            string selectedTask = panelCB.SelectedItem.ToString(); // Get the selected item as a string

            switch (selectedTask)
            {
                case "Task 3":
                    // Show the panel for Task 3d
                    panel3.Show();
                    break;
                case "Task 4":
                    // Show the panel for Task 4
                    panel4.Show();
                    break;
                case "Task 5":
                    // Show the panel for Task 5
                    panel5.Show();
                    break;
                case "Task 6":
                    // Show the panel for Task 6
                    panel6.Show();
                    break;
                case "Task 7":
                    // Show the panel for Task 7
                    panel7.Show();
                    break;
                case "Task 8":
                    // Show the panel for Task 8
                    panel8.Show();
                    break;
                case "Task 9":
                    // Show the panel for Task 9
                    //panel9.Show();
                    break;
                case "Task 10":
                    // Show the panel for Task 10
                    //panel10.Show();
                    break;
                default:
                    // Hide all panels if no task is selected or the selected task is not handled
                    break;
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.avgSalaryPerDepartmentTableAdapter.Search(this.tasksDataSet.AvgSalaryPerDepartment, departmentToolStripTextBox.Text);
                this.task5RW.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesViewTableAdapter.Search(this.tasksDataSet.EmployeesView, ((decimal)(System.Convert.ChangeType(monthToolStripTextBox.Text, typeof(decimal)))));
                this.task7RW.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.noOfEmployeesPerJobTableAdapter.Search(this.tasksDataSet.NoOfEmployeesPerJob, jobToolStripTextBox.Text);
                this.task8RW.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
