
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDepartments));
            this.lvDepartments = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.colEssential = new System.Windows.Forms.ColumnHeader();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbAddDept = new System.Windows.Forms.GroupBox();
            this.chbxEssential = new System.Windows.Forms.CheckBox();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.gbAddDept.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDepartments
            // 
            this.lvDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDeptName,
            this.colEssential});
            this.lvDepartments.FullRowSelect = true;
            this.lvDepartments.GridLines = true;
            this.lvDepartments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDepartments.HideSelection = false;
            this.lvDepartments.Location = new System.Drawing.Point(11, 12);
            this.lvDepartments.MultiSelect = false;
            this.lvDepartments.Name = "lvDepartments";
            this.lvDepartments.Size = new System.Drawing.Size(414, 329);
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
            this.colDeptName.Width = 220;
            // 
            // colEssential
            // 
            this.colEssential.Text = "Essential";
            this.colEssential.Width = 120;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddDepartment.Location = new System.Drawing.Point(16, 40);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(139, 53);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.BackColor = System.Drawing.Color.White;
            this.tbDepartmentName.Location = new System.Drawing.Point(192, 46);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(130, 27);
            this.tbDepartmentName.TabIndex = 4;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(192, 23);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(130, 20);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department name";
            // 
            // gbAddDept
            // 
            this.gbAddDept.Controls.Add(this.chbxEssential);
            this.gbAddDept.Controls.Add(this.btnAddDepartment);
            this.gbAddDept.Controls.Add(this.lblDepartment);
            this.gbAddDept.Controls.Add(this.tbDepartmentName);
            this.gbAddDept.Location = new System.Drawing.Point(54, 347);
            this.gbAddDept.Name = "gbAddDept";
            this.gbAddDept.Size = new System.Drawing.Size(328, 116);
            this.gbAddDept.TabIndex = 6;
            this.gbAddDept.TabStop = false;
            this.gbAddDept.Text = "Add department";
            // 
            // chbxEssential
            // 
            this.chbxEssential.AutoSize = true;
            this.chbxEssential.Location = new System.Drawing.Point(192, 79);
            this.chbxEssential.Name = "chbxEssential";
            this.chbxEssential.Size = new System.Drawing.Size(88, 24);
            this.chbxEssential.TabIndex = 6;
            this.chbxEssential.Text = "Essential";
            this.chbxEssential.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveDepartment.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRemoveDepartment.Location = new System.Drawing.Point(11, 491);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(155, 53);
            this.btnRemoveDepartment.TabIndex = 7;
            this.btnRemoveDepartment.Text = "Remove department";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditDepartment.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditDepartment.Location = new System.Drawing.Point(273, 491);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(152, 53);
            this.btnEditDepartment.TabIndex = 8;
            this.btnEditDepartment.Text = "Edit department";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // ManageDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 563);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.gbAddDept);
            this.Controls.Add(this.lvDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.CheckBox chbxEssential;
        private System.Windows.Forms.ColumnHeader colEssential;
    }
}