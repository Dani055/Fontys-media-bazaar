
namespace MediaBazaar.forms
{
    partial class EditDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDepartment));
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNewName
            // 
            this.tbxNewName.Location = new System.Drawing.Point(12, 32);
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(313, 27);
            this.tbxNewName.TabIndex = 0;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(101, 9);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(130, 20);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department name";
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditDepartment.ForeColor = System.Drawing.Color.White;
            this.btnEditDepartment.Location = new System.Drawing.Point(0, 74);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(337, 51);
            this.btnEditDepartment.TabIndex = 2;
            this.btnEditDepartment.Text = "Edit department";
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 125);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.tbxNewName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDepartment";
            this.Text = "Edit Department";
            this.Load += new System.EventHandler(this.EditDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Button btnEditDepartment;
    }
}