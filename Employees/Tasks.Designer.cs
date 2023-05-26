namespace Employees
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel3 = new System.Windows.Forms.Panel();
            this.task3RW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelCB = new System.Windows.Forms.ComboBox();
            this.showPanel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.task4RW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.task5RW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.departmentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.departmentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.task6RW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.task7RW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.monthToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.monthToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.task8RW = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.jobToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.jobToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.noOfEmployeesPerJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksDataSet = new Employees.TasksDataSet();
            this.employeesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.femalesWorkExpLessThan5YearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avgSalaryPerDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RetireesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.youngestEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.youngestEmployeeTableAdapter = new Employees.TasksDataSetTableAdapters.YoungestEmployeeTableAdapter();
            this.retireesTableAdapter = new Employees.TasksDataSetTableAdapters.RetireesTableAdapter();
            this.avgSalaryPerDepartmentTableAdapter = new Employees.TasksDataSetTableAdapters.AvgSalaryPerDepartmentTableAdapter();
            this.femalesWorkExpLessThan5YearsTableAdapter = new Employees.TasksDataSetTableAdapters.FemalesWorkExpLessThan5YearsTableAdapter();
            this.employeesViewTableAdapter = new Employees.TasksDataSetTableAdapters.EmployeesViewTableAdapter();
            this.noOfEmployeesPerJobTableAdapter = new Employees.TasksDataSetTableAdapters.NoOfEmployeesPerJobTableAdapter();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.searchToolStrip1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.searchToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfEmployeesPerJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.femalesWorkExpLessThan5YearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgSalaryPerDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetireesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youngestEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.task3RW);
            this.panel3.Location = new System.Drawing.Point(12, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 463);
            this.panel3.TabIndex = 0;
            // 
            // task3RW
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.youngestEmployeeBindingSource;
            this.task3RW.LocalReport.DataSources.Add(reportDataSource1);
            this.task3RW.LocalReport.ReportEmbeddedResource = "Employees.Report.Task 3.rdlc";
            this.task3RW.Location = new System.Drawing.Point(3, 35);
            this.task3RW.Name = "task3RW";
            this.task3RW.ServerReport.BearerToken = null;
            this.task3RW.Size = new System.Drawing.Size(830, 425);
            this.task3RW.TabIndex = 0;
            // 
            // panelCB
            // 
            this.panelCB.FormattingEnabled = true;
            this.panelCB.Location = new System.Drawing.Point(12, 12);
            this.panelCB.Name = "panelCB";
            this.panelCB.Size = new System.Drawing.Size(190, 24);
            this.panelCB.TabIndex = 2;
            // 
            // showPanel
            // 
            this.showPanel.Location = new System.Drawing.Point(232, 12);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(102, 23);
            this.showPanel.TabIndex = 3;
            this.showPanel.Text = "Show";
            this.showPanel.UseVisualStyleBackColor = true;
            this.showPanel.Click += new System.EventHandler(this.showPanel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.task4RW);
            this.panel4.Location = new System.Drawing.Point(12, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 463);
            this.panel4.TabIndex = 1;
            // 
            // task4RW
            // 
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.RetireesBindingSource;
            this.task4RW.LocalReport.DataSources.Add(reportDataSource2);
            this.task4RW.LocalReport.ReportEmbeddedResource = "Employees.Report.Task 4.rdlc";
            this.task4RW.Location = new System.Drawing.Point(3, 35);
            this.task4RW.Name = "task4RW";
            this.task4RW.ServerReport.BearerToken = null;
            this.task4RW.Size = new System.Drawing.Size(830, 425);
            this.task4RW.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchToolStrip);
            this.panel5.Controls.Add(this.task5RW);
            this.panel5.Location = new System.Drawing.Point(12, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(836, 463);
            this.panel5.TabIndex = 4;
            // 
            // task5RW
            // 
            reportDataSource3.Name = "DataSet";
            reportDataSource3.Value = this.avgSalaryPerDepartmentBindingSource;
            this.task5RW.LocalReport.DataSources.Add(reportDataSource3);
            this.task5RW.LocalReport.ReportEmbeddedResource = "Employees.Report.Task 5.rdlc";
            this.task5RW.Location = new System.Drawing.Point(4, 35);
            this.task5RW.Name = "task5RW";
            this.task5RW.ServerReport.BearerToken = null;
            this.task5RW.Size = new System.Drawing.Size(829, 425);
            this.task5RW.TabIndex = 0;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripLabel,
            this.departmentToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(4, 5);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.searchToolStrip.Size = new System.Drawing.Size(264, 31);
            this.searchToolStrip.TabIndex = 5;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // departmentToolStripLabel
            // 
            this.departmentToolStripLabel.Name = "departmentToolStripLabel";
            this.departmentToolStripLabel.Size = new System.Drawing.Size(92, 28);
            this.departmentToolStripLabel.Text = "Department:";
            // 
            // departmentToolStripTextBox
            // 
            this.departmentToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.departmentToolStripTextBox.Name = "departmentToolStripTextBox";
            this.departmentToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(57, 28);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel8);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.showPanel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panelCB);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel3);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(868, 525);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(868, 525);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.task6RW);
            this.panel6.Location = new System.Drawing.Point(12, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(836, 463);
            this.panel6.TabIndex = 5;
            // 
            // task6RW
            // 
            reportDataSource6.Name = "DataSet";
            reportDataSource6.Value = this.femalesWorkExpLessThan5YearsBindingSource;
            this.task6RW.LocalReport.DataSources.Add(reportDataSource6);
            this.task6RW.LocalReport.ReportEmbeddedResource = "Employees.Report.Task 6.rdlc";
            this.task6RW.Location = new System.Drawing.Point(4, 35);
            this.task6RW.Name = "task6RW";
            this.task6RW.ServerReport.BearerToken = null;
            this.task6RW.Size = new System.Drawing.Size(829, 425);
            this.task6RW.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.searchToolStrip1);
            this.panel7.Controls.Add(this.task7RW);
            this.panel7.Location = new System.Drawing.Point(12, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(836, 463);
            this.panel7.TabIndex = 6;
            // 
            // task7RW
            // 
            reportDataSource5.Name = "DataSet";
            reportDataSource5.Value = this.employeesViewBindingSource;
            this.task7RW.LocalReport.DataSources.Add(reportDataSource5);
            this.task7RW.LocalReport.ReportEmbeddedResource = "Employees.Report.Task 7.rdlc";
            this.task7RW.Location = new System.Drawing.Point(4, 35);
            this.task7RW.Name = "task7RW";
            this.task7RW.ServerReport.BearerToken = null;
            this.task7RW.Size = new System.Drawing.Size(829, 425);
            this.task7RW.TabIndex = 0;
            // 
            // searchToolStrip1
            // 
            this.searchToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthToolStripLabel,
            this.monthToolStripTextBox,
            this.searchToolStripButton1});
            this.searchToolStrip1.Location = new System.Drawing.Point(4, 5);
            this.searchToolStrip1.Name = "searchToolStrip1";
            this.searchToolStrip1.Size = new System.Drawing.Size(227, 31);
            this.searchToolStrip1.TabIndex = 7;
            this.searchToolStrip1.Text = "searchToolStrip1";
            // 
            // monthToolStripLabel
            // 
            this.monthToolStripLabel.Name = "monthToolStripLabel";
            this.monthToolStripLabel.Size = new System.Drawing.Size(55, 28);
            this.monthToolStripLabel.Text = "Month:";
            // 
            // monthToolStripTextBox
            // 
            this.monthToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monthToolStripTextBox.Name = "monthToolStripTextBox";
            this.monthToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // searchToolStripButton1
            // 
            this.searchToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton1.Name = "searchToolStripButton1";
            this.searchToolStripButton1.Size = new System.Drawing.Size(57, 28);
            this.searchToolStripButton1.Text = "Search";
            this.searchToolStripButton1.Click += new System.EventHandler(this.searchToolStripButton1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.searchToolStrip2);
            this.panel8.Controls.Add(this.task8RW);
            this.panel8.Location = new System.Drawing.Point(12, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(836, 460);
            this.panel8.TabIndex = 7;
            // 
            // task8RW
            // 
            reportDataSource4.Name = "DataSet";
            reportDataSource4.Value = this.noOfEmployeesPerJobBindingSource;
            this.task8RW.LocalReport.DataSources.Add(reportDataSource4);
            this.task8RW.LocalReport.ReportEmbeddedResource = "Employees.Report.Task 8.rdlc";
            this.task8RW.Location = new System.Drawing.Point(4, 35);
            this.task8RW.Name = "task8RW";
            this.task8RW.ServerReport.BearerToken = null;
            this.task8RW.Size = new System.Drawing.Size(829, 422);
            this.task8RW.TabIndex = 0;
            // 
            // searchToolStrip2
            // 
            this.searchToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobToolStripLabel,
            this.jobToolStripTextBox,
            this.searchToolStripButton2});
            this.searchToolStrip2.Location = new System.Drawing.Point(4, 5);
            this.searchToolStrip2.Name = "searchToolStrip2";
            this.searchToolStrip2.Size = new System.Drawing.Size(207, 27);
            this.searchToolStrip2.TabIndex = 7;
            this.searchToolStrip2.Text = "searchToolStrip2";
            // 
            // jobToolStripLabel
            // 
            this.jobToolStripLabel.Name = "jobToolStripLabel";
            this.jobToolStripLabel.Size = new System.Drawing.Size(35, 24);
            this.jobToolStripLabel.Text = "Job:";
            // 
            // jobToolStripTextBox
            // 
            this.jobToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jobToolStripTextBox.Name = "jobToolStripTextBox";
            this.jobToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchToolStripButton2
            // 
            this.searchToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton2.Name = "searchToolStripButton2";
            this.searchToolStripButton2.Size = new System.Drawing.Size(57, 24);
            this.searchToolStripButton2.Text = "Search";
            this.searchToolStripButton2.Click += new System.EventHandler(this.searchToolStripButton2_Click);
            // 
            // noOfEmployeesPerJobBindingSource
            // 
            this.noOfEmployeesPerJobBindingSource.DataMember = "NoOfEmployeesPerJob";
            this.noOfEmployeesPerJobBindingSource.DataSource = this.tasksDataSet;
            // 
            // tasksDataSet
            // 
            this.tasksDataSet.DataSetName = "TasksDataSet";
            this.tasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesViewBindingSource
            // 
            this.employeesViewBindingSource.DataMember = "EmployeesView";
            this.employeesViewBindingSource.DataSource = this.tasksDataSet;
            // 
            // femalesWorkExpLessThan5YearsBindingSource
            // 
            this.femalesWorkExpLessThan5YearsBindingSource.DataMember = "FemalesWorkExpLessThan5Years";
            this.femalesWorkExpLessThan5YearsBindingSource.DataSource = this.tasksDataSet;
            // 
            // avgSalaryPerDepartmentBindingSource
            // 
            this.avgSalaryPerDepartmentBindingSource.DataMember = "AvgSalaryPerDepartment";
            this.avgSalaryPerDepartmentBindingSource.DataSource = this.tasksDataSet;
            // 
            // RetireesBindingSource
            // 
            this.RetireesBindingSource.DataMember = "Retirees";
            this.RetireesBindingSource.DataSource = this.tasksDataSet;
            // 
            // youngestEmployeeBindingSource
            // 
            this.youngestEmployeeBindingSource.DataMember = "YoungestEmployee";
            this.youngestEmployeeBindingSource.DataSource = this.tasksDataSet;
            // 
            // youngestEmployeeTableAdapter
            // 
            this.youngestEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // retireesTableAdapter
            // 
            this.retireesTableAdapter.ClearBeforeFill = true;
            // 
            // avgSalaryPerDepartmentTableAdapter
            // 
            this.avgSalaryPerDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // femalesWorkExpLessThan5YearsTableAdapter
            // 
            this.femalesWorkExpLessThan5YearsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesViewTableAdapter
            // 
            this.employeesViewTableAdapter.ClearBeforeFill = true;
            // 
            // noOfEmployeesPerJobTableAdapter
            // 
            this.noOfEmployeesPerJobTableAdapter.ClearBeforeFill = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 525);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.searchToolStrip1.ResumeLayout(false);
            this.searchToolStrip1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.searchToolStrip2.ResumeLayout(false);
            this.searchToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfEmployeesPerJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.femalesWorkExpLessThan5YearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgSalaryPerDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetireesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youngestEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox panelCB;
        private System.Windows.Forms.Button showPanel;
        private Microsoft.Reporting.WinForms.ReportViewer task3RW;
        private TasksDataSet tasksDataSet;
        private System.Windows.Forms.BindingSource youngestEmployeeBindingSource;
        private TasksDataSetTableAdapters.YoungestEmployeeTableAdapter youngestEmployeeTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer task4RW;
        private System.Windows.Forms.BindingSource RetireesBindingSource;
        private TasksDataSetTableAdapters.RetireesTableAdapter retireesTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private Microsoft.Reporting.WinForms.ReportViewer task5RW;
        private System.Windows.Forms.BindingSource avgSalaryPerDepartmentBindingSource;
        private TasksDataSetTableAdapters.AvgSalaryPerDepartmentTableAdapter avgSalaryPerDepartmentTableAdapter;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel departmentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox departmentToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel6;
        private Microsoft.Reporting.WinForms.ReportViewer task6RW;
        private System.Windows.Forms.BindingSource femalesWorkExpLessThan5YearsBindingSource;
        private TasksDataSetTableAdapters.FemalesWorkExpLessThan5YearsTableAdapter femalesWorkExpLessThan5YearsTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private Microsoft.Reporting.WinForms.ReportViewer task7RW;
        private System.Windows.Forms.BindingSource employeesViewBindingSource;
        private TasksDataSetTableAdapters.EmployeesViewTableAdapter employeesViewTableAdapter;
        private System.Windows.Forms.ToolStrip searchToolStrip1;
        private System.Windows.Forms.ToolStripLabel monthToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox monthToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton1;
        private System.Windows.Forms.Panel panel8;
        private Microsoft.Reporting.WinForms.ReportViewer task8RW;
        private System.Windows.Forms.BindingSource noOfEmployeesPerJobBindingSource;
        private TasksDataSetTableAdapters.NoOfEmployeesPerJobTableAdapter noOfEmployeesPerJobTableAdapter;
        private System.Windows.Forms.ToolStrip searchToolStrip2;
        private System.Windows.Forms.ToolStripLabel jobToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox jobToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton2;
    }
}