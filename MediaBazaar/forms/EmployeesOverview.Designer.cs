namespace MediaBazaar.forms
{
    partial class EmployeesOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesOverview));
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.role = new System.Windows.Forms.ColumnHeader();
            this.hourlyWage = new System.Windows.Forms.ColumnHeader();
            this.totalPerMonth = new System.Windows.Forms.ColumnHeader();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lvEmpBrakedown = new System.Windows.Forms.ListView();
            this.dividedBy = new System.Windows.Forms.ColumnHeader();
            this.numberOfEmp = new System.Windows.Forms.ColumnHeader();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.empRole = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lblBDContract = new System.Windows.Forms.Label();
            this.lblBDRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvEmployees
            // 
            this.lvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.role,
            this.hourlyWage,
            this.totalPerMonth});
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.GridLines = true;
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Location = new System.Drawing.Point(12, 32);
            this.lvEmployees.MultiSelect = false;
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(860, 166);
            this.lvEmployees.TabIndex = 0;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            this.lvEmployees.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvEmployees_ColumnClick);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.Width = 100;
            // 
            // hourlyWage
            // 
            this.hourlyWage.Text = "Hourly wage";
            this.hourlyWage.Width = 100;
            // 
            // totalPerMonth
            // 
            this.totalPerMonth.Text = "Total per month";
            this.totalPerMonth.Width = 150;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(12, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(284, 20);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Employees overview (exl. 0 hour contract)";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.Location = new System.Drawing.Point(343, 217);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(191, 23);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Employees breakdown";
            // 
            // lvEmpBrakedown
            // 
            this.lvEmpBrakedown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dividedBy,
            this.numberOfEmp});
            this.lvEmpBrakedown.GridLines = true;
            this.lvEmpBrakedown.HideSelection = false;
            this.lvEmpBrakedown.Location = new System.Drawing.Point(12, 324);
            this.lvEmpBrakedown.Name = "lvEmpBrakedown";
            this.lvEmpBrakedown.Size = new System.Drawing.Size(404, 179);
            this.lvEmpBrakedown.TabIndex = 2;
            this.lvEmpBrakedown.UseCompatibleStateImageBehavior = false;
            this.lvEmpBrakedown.View = System.Windows.Forms.View.Details;
            // 
            // dividedBy
            // 
            this.dividedBy.Text = "Divided by";
            this.dividedBy.Width = 200;
            // 
            // numberOfEmp
            // 
            this.numberOfEmp.Text = "Number of employees";
            this.numberOfEmp.Width = 200;
            // 
            // lvRoles
            // 
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empRole,
            this.columnHeader2});
            this.lvRoles.GridLines = true;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(468, 324);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(404, 179);
            this.lvRoles.TabIndex = 3;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // empRole
            // 
            this.empRole.Text = "Role";
            this.empRole.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number of employees";
            this.columnHeader2.Width = 200;
            // 
            // lblBDContract
            // 
            this.lblBDContract.AutoSize = true;
            this.lblBDContract.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBDContract.Location = new System.Drawing.Point(12, 298);
            this.lblBDContract.Name = "lblBDContract";
            this.lblBDContract.Size = new System.Drawing.Size(116, 23);
            this.lblBDContract.TabIndex = 1;
            this.lblBDContract.Text = "Common info";
            // 
            // lblBDRole
            // 
            this.lblBDRole.AutoSize = true;
            this.lblBDRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBDRole.Location = new System.Drawing.Point(468, 298);
            this.lblBDRole.Name = "lblBDRole";
            this.lblBDRole.Size = new System.Drawing.Size(51, 23);
            this.lblBDRole.TabIndex = 1;
            this.lblBDRole.Text = "Roles";
            // 
            // EmployeesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 515);
            this.Controls.Add(this.lvRoles);
            this.Controls.Add(this.lvEmpBrakedown);
            this.Controls.Add(this.lblBDRole);
            this.Controls.Add(this.lblBDContract);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lvEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeesOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesOverview";
            this.Load += new System.EventHandler(this.EmployeesOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.ColumnHeader hourlyWage;
        private System.Windows.Forms.ColumnHeader totalPerMonth;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.ListView lvEmpBrakedown;
        private System.Windows.Forms.ColumnHeader dividedBy;
        private System.Windows.Forms.ColumnHeader numberOfEmp;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader empRole;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblBDContract;
        private System.Windows.Forms.Label lblBDRole;
    }
}