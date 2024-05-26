namespace EmployeeManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDepartmentIDForReport = new System.Windows.Forms.TextBox();
            this.btnReportByDepartment = new System.Windows.Forms.Button();
            this.dtpHireDateForReport = new System.Windows.Forms.DateTimePicker();
            this.btnReportByHireDate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(12, 64);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(12, 90);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(100, 20);
            this.txtDepartmentID.TabIndex = 3;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(12, 116);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDate.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 142);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 23);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 171);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDepartmentIDForReport
            // 
            this.txtDepartmentIDForReport.Location = new System.Drawing.Point(12, 197);
            this.txtDepartmentIDForReport.Name = "txtDepartmentIDForReport";
            this.txtDepartmentIDForReport.Size = new System.Drawing.Size(100, 20);
            this.txtDepartmentIDForReport.TabIndex = 8;
            // 
            // btnReportByDepartment
            // 
            this.btnReportByDepartment.Location = new System.Drawing.Point(118, 195);
            this.btnReportByDepartment.Name = "btnReportByDepartment";
            this.btnReportByDepartment.Size = new System.Drawing.Size(154, 23);
            this.btnReportByDepartment.TabIndex = 9;
            this.btnReportByDepartment.Text = "Report By Department";
            this.btnReportByDepartment.UseVisualStyleBackColor = true;
            this.btnReportByDepartment.Click += new System.EventHandler(this.btnReportByDepartment_Click);
            // 
            // dtpHireDateForReport
            // 
            this.dtpHireDateForReport.Location = new System.Drawing.Point(12, 223);
            this.dtpHireDateForReport.Name = "dtpHireDateForReport";
            this.dtpHireDateForReport.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDateForReport.TabIndex = 10;
            // 
            // btnReportByHireDate
            // 
            this.btnReportByHireDate.Location = new System.Drawing.Point(218, 223);
            this.btnReportByHireDate.Name = "btnReportByHireDate";
            this.btnReportByHireDate.Size = new System.Drawing.Size(154, 23);
            this.btnReportByHireDate.TabIndex = 11;
            this.btnReportByHireDate.Text = "Report By Hire Date";
            this.btnReportByHireDate.UseVisualStyleBackColor = true;
            this.btnReportByHireDate.Click += new System.EventHandler(this.btnReportByHireDate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReportByHireDate);
            this.Controls.Add(this.dtpHireDateForReport);
            this.Controls.Add(this.btnReportByDepartment);
            this.Controls.Add(this.txtDepartmentIDForReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "MainForm";
            this.Text = "Employee Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDepartmentIDForReport;
        private System.Windows.Forms.Button btnReportByDepartment;
        private System.Windows.Forms.DateTimePicker dtpHireDateForReport;
        private System.Windows.Forms.Button btnReportByHireDate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
