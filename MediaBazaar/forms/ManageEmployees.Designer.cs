﻿
namespace MediaBazaar
{
    partial class ManageEmployees
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
            this.lvEmps = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colUsername = new System.Windows.Forms.ColumnHeader();
            this.colPass = new System.Windows.Forms.ColumnHeader();
            this.colRole = new System.Windows.Forms.ColumnHeader();
            this.colFirstname = new System.Windows.Forms.ColumnHeader();
            this.colLastname = new System.Windows.Forms.ColumnHeader();
            this.colWage = new System.Windows.Forms.ColumnHeader();
            this.colDepartmentID = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.colPhone = new System.Windows.Forms.ColumnHeader();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnViewShifts = new System.Windows.Forms.Button();
            this.btnManageShifts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmps
            // 
            this.lvEmps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colUsername,
            this.colPass,
            this.colRole,
            this.colFirstname,
            this.colLastname,
            this.colWage,
            this.colDepartmentID,
            this.colEmail,
            this.colPhone});
            this.lvEmps.FullRowSelect = true;
            this.lvEmps.GridLines = true;
            this.lvEmps.HideSelection = false;
            this.lvEmps.Location = new System.Drawing.Point(10, 9);
            this.lvEmps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvEmps.MultiSelect = false;
            this.lvEmps.Name = "lvEmps";
            this.lvEmps.Size = new System.Drawing.Size(1025, 237);
            this.lvEmps.TabIndex = 1;
            this.lvEmps.UseCompatibleStateImageBehavior = false;
            this.lvEmps.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            // 
            // colPass
            // 
            this.colPass.Text = "Password";
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            // 
            // colFirstname
            // 
            this.colFirstname.Text = "First name";
            // 
            // colLastname
            // 
            this.colLastname.Text = "Last name";
            // 
            // colWage
            // 
            this.colWage.Text = "Hourly wage";
            // 
            // colDepartmentID
            // 
            this.colDepartmentID.Text = "Depart. ID";
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(22, 262);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(131, 40);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(170, 262);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(136, 40);
            this.btnRemoveEmployee.TabIndex = 3;
            this.btnRemoveEmployee.Text = "Remove selected employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Location = new System.Drawing.Point(322, 262);
            this.btnEditInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(136, 40);
            this.btnEditInfo.TabIndex = 4;
            this.btnEditInfo.Text = "Edit info";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnViewShifts
            // 
            this.btnViewShifts.Location = new System.Drawing.Point(170, 318);
            this.btnViewShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewShifts.Name = "btnViewShifts";
            this.btnViewShifts.Size = new System.Drawing.Size(131, 40);
            this.btnViewShifts.TabIndex = 5;
            this.btnViewShifts.Text = "View work shifts and attendance";
            this.btnViewShifts.UseVisualStyleBackColor = true;
            this.btnViewShifts.Click += new System.EventHandler(this.btnViewShifts_Click);
            // 
            // btnManageShifts
            // 
            this.btnManageShifts.Location = new System.Drawing.Point(17, 318);
            this.btnManageShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageShifts.Name = "btnManageShifts";
            this.btnManageShifts.Size = new System.Drawing.Size(136, 40);
            this.btnManageShifts.TabIndex = 6;
            this.btnManageShifts.Text = "Manage shifts for employee";
            this.btnManageShifts.UseVisualStyleBackColor = true;
            this.btnManageShifts.Click += new System.EventHandler(this.btnManageShifts_Click);
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 442);
            this.Controls.Add(this.btnManageShifts);
            this.Controls.Add(this.btnViewShifts);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lvEmps);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageEmployees";
            this.Text = "ManageEmployees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvEmps;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPass;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colFirstname;
        private System.Windows.Forms.ColumnHeader colLastname;
        private System.Windows.Forms.ColumnHeader colDepartmentID;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colWage;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnViewShifts;
        private System.Windows.Forms.Button btnManageShifts;
    }
}