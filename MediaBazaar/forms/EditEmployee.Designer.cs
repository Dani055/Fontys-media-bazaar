
namespace MediaBazaar.forms
{
    partial class EditEmployee
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.numericWage = new System.Windows.Forms.NumericUpDown();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.cbxContract = new System.Windows.Forms.ComboBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.cbxStudent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericWage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(445, 46);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 20);
            this.lblDepartment.TabIndex = 48;
            this.lblDepartment.Text = "Department";
            // 
            // numericWage
            // 
            this.numericWage.Location = new System.Drawing.Point(197, 298);
            this.numericWage.Name = "numericWage";
            this.numericWage.Size = new System.Drawing.Size(80, 27);
            this.numericWage.TabIndex = 47;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(332, 360);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(138, 49);
            this.btnEditEmployee.TabIndex = 46;
            this.btnEditEmployee.Text = "Edit details";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(530, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "* Fields are required";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(436, 255);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(98, 20);
            this.lblContract.TabIndex = 44;
            this.lblContract.Text = "Contract type";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(429, 202);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(105, 20);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Phone number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(488, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "Email";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(495, 101);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 41;
            this.lblRole.Text = "Role";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(98, 300);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(93, 20);
            this.lblHourlyWage.TabIndex = 40;
            this.lblHourlyWage.Text = "Hourly wage";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAddress.Location = new System.Drawing.Point(118, 252);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address *";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLastname.Location = new System.Drawing.Point(104, 205);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(86, 20);
            this.lblLastname.TabIndex = 38;
            this.lblLastname.Text = "Last name *";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFirstName.Location = new System.Drawing.Point(104, 153);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 20);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "First name *";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Unassigned"});
            this.cbxDepartment.Location = new System.Drawing.Point(551, 42);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(151, 28);
            this.cbxDepartment.TabIndex = 36;
            // 
            // cbxContract
            // 
            this.cbxContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContract.FormattingEnabled = true;
            this.cbxContract.Items.AddRange(new object[] {
            "0 Hour fixed",
            "Permanent"});
            this.cbxContract.Location = new System.Drawing.Point(551, 252);
            this.cbxContract.Name = "cbxContract";
            this.cbxContract.Size = new System.Drawing.Size(151, 28);
            this.cbxContract.TabIndex = 35;
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "Unassigned",
            "Employee Manager",
            "Depot Manager",
            "Department Manager",
            "Department Employee",
            "Cashier",
            "Warehouse Worker"});
            this.cbxRole.Location = new System.Drawing.Point(551, 94);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(151, 28);
            this.cbxRole.TabIndex = 34;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPassword.Location = new System.Drawing.Point(111, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 20);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Password *";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUsername.Location = new System.Drawing.Point(106, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 20);
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Username *";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(551, 205);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(151, 27);
            this.tbxPhone.TabIndex = 31;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(551, 150);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(151, 27);
            this.tbxEmail.TabIndex = 30;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(196, 252);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(165, 27);
            this.tbxAddress.TabIndex = 29;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(197, 202);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(165, 27);
            this.tbxLastName.TabIndex = 28;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(197, 150);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(164, 27);
            this.tbxFirstName.TabIndex = 27;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(197, 94);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(164, 27);
            this.tbxPassword.TabIndex = 26;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(197, 43);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(164, 27);
            this.tbxUsername.TabIndex = 25;
            // 
            // cbxStudent
            // 
            this.cbxStudent.AutoSize = true;
            this.cbxStudent.Location = new System.Drawing.Point(551, 300);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Size = new System.Drawing.Size(82, 24);
            this.cbxStudent.TabIndex = 49;
            this.cbxStudent.Text = "Student";
            this.cbxStudent.UseVisualStyleBackColor = true;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxStudent);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.numericWage);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblHourlyWage);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.cbxContract);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.numericWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.NumericUpDown numericWage;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.ComboBox cbxContract;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.CheckBox cbxStudent;
    }
}