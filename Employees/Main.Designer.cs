namespace Employees
{
    partial class updateBtn
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.birthDateDTP = new System.Windows.Forms.DateTimePicker();
            this.hireDateDTP = new System.Windows.Forms.DateTimePicker();
            this.workedHoursNUD = new System.Windows.Forms.NumericUpDown();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.jobCB = new System.Windows.Forms.ComboBox();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workedHoursNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.Size = new System.Drawing.Size(934, 530);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1208, 365);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 45);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1208, 365);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(160, 45);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update Employee";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(988, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(988, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(988, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(988, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Worked Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(988, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(988, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Job";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(988, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Department";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(1133, 21);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(235, 22);
            this.firstNameTB.TabIndex = 11;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(1133, 64);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(235, 22);
            this.lastNameTB.TabIndex = 12;
            // 
            // birthDateDTP
            // 
            this.birthDateDTP.Location = new System.Drawing.Point(1133, 108);
            this.birthDateDTP.Name = "birthDateDTP";
            this.birthDateDTP.Size = new System.Drawing.Size(235, 22);
            this.birthDateDTP.TabIndex = 13;
            // 
            // hireDateDTP
            // 
            this.hireDateDTP.Location = new System.Drawing.Point(1133, 150);
            this.hireDateDTP.Name = "hireDateDTP";
            this.hireDateDTP.Size = new System.Drawing.Size(235, 22);
            this.hireDateDTP.TabIndex = 14;
            // 
            // workedHoursNUD
            // 
            this.workedHoursNUD.Location = new System.Drawing.Point(1133, 193);
            this.workedHoursNUD.Maximum = new decimal(new int[] {
            260,
            0,
            0,
            0});
            this.workedHoursNUD.Name = "workedHoursNUD";
            this.workedHoursNUD.Size = new System.Drawing.Size(235, 22);
            this.workedHoursNUD.TabIndex = 15;
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(1133, 241);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(235, 24);
            this.genderCB.TabIndex = 16;
            // 
            // jobCB
            // 
            this.jobCB.FormattingEnabled = true;
            this.jobCB.Location = new System.Drawing.Point(1133, 279);
            this.jobCB.Name = "jobCB";
            this.jobCB.Size = new System.Drawing.Size(235, 24);
            this.jobCB.TabIndex = 17;
            // 
            // departmentCB
            // 
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(1133, 317);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(235, 24);
            this.departmentCB.TabIndex = 18;
            // 
            // updateBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 554);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.jobCB);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.workedHoursNUD);
            this.Controls.Add(this.hireDateDTP);
            this.Controls.Add(this.birthDateDTP);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateBtn";
            this.Text = "genderCB";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workedHoursNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.DateTimePicker birthDateDTP;
        private System.Windows.Forms.DateTimePicker hireDateDTP;
        private System.Windows.Forms.NumericUpDown workedHoursNUD;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.ComboBox jobCB;
        private System.Windows.Forms.ComboBox departmentCB;
    }
}

