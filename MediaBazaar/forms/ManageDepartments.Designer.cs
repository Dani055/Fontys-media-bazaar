
namespace MediaBazaar.forms
{
    partial class ManageDepartments
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
            this.lvDepartments = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbAddDept = new System.Windows.Forms.GroupBox();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.gbAddDept.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDepartments
            // 
            this.lvDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDeptName});
            this.lvDepartments.FullRowSelect = true;
            this.lvDepartments.GridLines = true;
            this.lvDepartments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDepartments.HideSelection = false;
            this.lvDepartments.Location = new System.Drawing.Point(10, 9);
            this.lvDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDepartments.MultiSelect = false;
            this.lvDepartments.Name = "lvDepartments";
            this.lvDepartments.Size = new System.Drawing.Size(288, 248);
            this.lvDepartments.TabIndex = 2;
            this.lvDepartments.UseCompatibleStateImageBehavior = false;
            this.lvDepartments.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colDeptName
            // 
            this.colDeptName.Text = "Department";
            this.colDeptName.Width = 240;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(19, 30);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(96, 40);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(134, 47);
            this.tbDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(110, 23);
            this.tbDepartmentName.TabIndex = 4;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(130, 30);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(103, 15);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department name";
            // 
            // gbAddDept
            // 
            this.gbAddDept.Controls.Add(this.btnAddDepartment);
            this.gbAddDept.Controls.Add(this.lblDepartment);
            this.gbAddDept.Controls.Add(this.tbDepartmentName);
            this.gbAddDept.Location = new System.Drawing.Point(10, 260);
            this.gbAddDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAddDept.Name = "gbAddDept";
            this.gbAddDept.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAddDept.Size = new System.Drawing.Size(287, 103);
            this.gbAddDept.TabIndex = 6;
            this.gbAddDept.TabStop = false;
            this.gbAddDept.Text = "Add department";
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Location = new System.Drawing.Point(10, 368);
            this.btnRemoveDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(136, 40);
            this.btnRemoveDepartment.TabIndex = 7;
            this.btnRemoveDepartment.Text = "Remove department";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(164, 368);
            this.btnEditDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(133, 40);
            this.btnEditDepartment.TabIndex = 8;
            this.btnEditDepartment.Text = "Edit department";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // ManageDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 422);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.gbAddDept);
            this.Controls.Add(this.lvDepartments);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageDepartments";
            this.Text = "ManageDepartments";
            this.Load += new System.EventHandler(this.ManageDepartments_Load);
            this.gbAddDept.ResumeLayout(false);
            this.gbAddDept.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDepartments;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colDeptName;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.GroupBox gbAddDept;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
    }
}