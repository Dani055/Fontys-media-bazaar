
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
            this.lvEmps.Location = new System.Drawing.Point(12, 38);
            this.lvEmps.MultiSelect = false;
            this.lvEmps.Name = "lvEmps";
            this.lvEmps.Size = new System.Drawing.Size(826, 309);
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
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 588);
            this.Controls.Add(this.lvEmps);
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
    }
}