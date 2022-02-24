﻿
namespace MediaBazaar
{
    partial class Home
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnManageDepartments = new System.Windows.Forms.Button();
            this.btnRestockReq = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(515, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(528, 36);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(30, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(601, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 25);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.Location = new System.Drawing.Point(35, 20);
            this.btnManageEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(104, 46);
            this.btnManageEmp.TabIndex = 3;
            this.btnManageEmp.Text = "Manage Employees";
            this.btnManageEmp.UseVisualStyleBackColor = true;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnManageDepartments
            // 
            this.btnManageDepartments.Location = new System.Drawing.Point(35, 81);
            this.btnManageDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageDepartments.Name = "btnManageDepartments";
            this.btnManageDepartments.Size = new System.Drawing.Size(104, 46);
            this.btnManageDepartments.TabIndex = 4;
            this.btnManageDepartments.Text = "Manage Departments";
            this.btnManageDepartments.UseVisualStyleBackColor = true;
            this.btnManageDepartments.Click += new System.EventHandler(this.btnManageDepartments_Click);
            // 
            // btnRestockReq
            // 
            this.btnRestockReq.Location = new System.Drawing.Point(35, 186);
            this.btnRestockReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestockReq.Name = "btnRestockReq";
            this.btnRestockReq.Size = new System.Drawing.Size(104, 46);
            this.btnRestockReq.TabIndex = 6;
            this.btnRestockReq.Text = "View restock requests";
            this.btnRestockReq.UseVisualStyleBackColor = true;
            this.btnRestockReq.Click += new System.EventHandler(this.btnRestockReq_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(35, 132);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(104, 46);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(35, 236);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(104, 46);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "Enter Sell Screen";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnRestockReq);
            this.Controls.Add(this.btnManageDepartments);
            this.Controls.Add(this.btnManageEmp);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnManageDepartments;
        private System.Windows.Forms.Button btnRestockReq;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSell;
    }
}