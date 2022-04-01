
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployees));
            this.lvEmps = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colUsername = new System.Windows.Forms.ColumnHeader();
            this.colPass = new System.Windows.Forms.ColumnHeader();
            this.colRole = new System.Windows.Forms.ColumnHeader();
            this.colFirstname = new System.Windows.Forms.ColumnHeader();
            this.colLastname = new System.Windows.Forms.ColumnHeader();
            this.colWage = new System.Windows.Forms.ColumnHeader();
            this.colContract = new System.Windows.Forms.ColumnHeader();
            this.colDepName = new System.Windows.Forms.ColumnHeader();
            this.colDepartmentID = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.colPhone = new System.Windows.Forms.ColumnHeader();
            this.colIsStudent = new System.Windows.Forms.ColumnHeader();
            this.tbSearchEmps = new System.Windows.Forms.TextBox();
            this.btnSearchEmps = new System.Windows.Forms.Button();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxManageShift = new System.Windows.Forms.PictureBox();
            this.pbxSchedule = new System.Windows.Forms.PictureBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManageShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSchedule)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEmps
            // 
            this.lvEmps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEmps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colUsername,
            this.colPass,
            this.colRole,
            this.colFirstname,
            this.colLastname,
            this.colWage,
            this.colContract,
            this.colDepName,
            this.colDepartmentID,
            this.colEmail,
            this.colPhone,
            this.colIsStudent});
            this.lvEmps.FullRowSelect = true;
            this.lvEmps.GridLines = true;
            this.lvEmps.HideSelection = false;
            this.lvEmps.Location = new System.Drawing.Point(14, 56);
            this.lvEmps.MultiSelect = false;
            this.lvEmps.Name = "lvEmps";
            this.lvEmps.Size = new System.Drawing.Size(1453, 399);
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
            // colContract
            // 
            this.colContract.Text = "Contract";
            // 
            // colDepName
            // 
            this.colDepName.Text = "Department Name";
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
            // colIsStudent
            // 
            this.colIsStudent.Text = "Student";
            // 
            // tbSearchEmps
            // 
            this.tbSearchEmps.Location = new System.Drawing.Point(15, 12);
            this.tbSearchEmps.Name = "tbSearchEmps";
            this.tbSearchEmps.Size = new System.Drawing.Size(225, 27);
            this.tbSearchEmps.TabIndex = 7;
            // 
            // btnSearchEmps
            // 
            this.btnSearchEmps.Location = new System.Drawing.Point(251, 12);
            this.btnSearchEmps.Name = "btnSearchEmps";
            this.btnSearchEmps.Size = new System.Drawing.Size(94, 29);
            this.btnSearchEmps.TabIndex = 8;
            this.btnSearchEmps.Text = "🔍Search";
            this.btnSearchEmps.UseVisualStyleBackColor = true;
            this.btnSearchEmps.Click += new System.EventHandler(this.btnSearchEmps_Click);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(200, 11);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(60, 60);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 9;
            this.pbxAdd.TabStop = false;
            this.ttpMain.SetToolTip(this.pbxAdd, "Add new employee");
            this.pbxAdd.Click += new System.EventHandler(this.btnAddEmployee_Click);
            this.pbxAdd.MouseEnter += new System.EventHandler(this.TogglePictureButtonSize);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.TogglePictureButtonSize);
            // 
            // pbxRemove
            // 
            this.pbxRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbxRemove.Image")));
            this.pbxRemove.Location = new System.Drawing.Point(454, 11);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Padding = new System.Windows.Forms.Padding(2);
            this.pbxRemove.Size = new System.Drawing.Size(60, 60);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRemove.TabIndex = 9;
            this.pbxRemove.TabStop = false;
            this.ttpMain.SetToolTip(this.pbxRemove, "Remove selected employee");
            this.pbxRemove.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            this.pbxRemove.MouseEnter += new System.EventHandler(this.TogglePictureButtonSize);
            this.pbxRemove.MouseLeave += new System.EventHandler(this.TogglePictureButtonSize);
            // 
            // pbxEdit
            // 
            this.pbxEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbxEdit.Image")));
            this.pbxEdit.Location = new System.Drawing.Point(708, 11);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Padding = new System.Windows.Forms.Padding(2);
            this.pbxEdit.Size = new System.Drawing.Size(60, 60);
            this.pbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEdit.TabIndex = 9;
            this.pbxEdit.TabStop = false;
            this.ttpMain.SetToolTip(this.pbxEdit, "Edit selected employee");
            this.pbxEdit.Click += new System.EventHandler(this.btnEditInfo_Click);
            this.pbxEdit.MouseEnter += new System.EventHandler(this.TogglePictureButtonSize);
            this.pbxEdit.MouseLeave += new System.EventHandler(this.TogglePictureButtonSize);
            // 
            // pbxManageShift
            // 
            this.pbxManageShift.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxManageShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxManageShift.Image = ((System.Drawing.Image)(resources.GetObject("pbxManageShift.Image")));
            this.pbxManageShift.Location = new System.Drawing.Point(962, 11);
            this.pbxManageShift.Name = "pbxManageShift";
            this.pbxManageShift.Padding = new System.Windows.Forms.Padding(2);
            this.pbxManageShift.Size = new System.Drawing.Size(60, 60);
            this.pbxManageShift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxManageShift.TabIndex = 9;
            this.pbxManageShift.TabStop = false;
            this.ttpMain.SetToolTip(this.pbxManageShift, "Schedule new shift");
            this.pbxManageShift.Click += new System.EventHandler(this.btnManageShifts_Click);
            this.pbxManageShift.MouseEnter += new System.EventHandler(this.TogglePictureButtonSize);
            this.pbxManageShift.MouseLeave += new System.EventHandler(this.TogglePictureButtonSize);
            // 
            // pbxSchedule
            // 
            this.pbxSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pbxSchedule.Image")));
            this.pbxSchedule.Location = new System.Drawing.Point(1216, 11);
            this.pbxSchedule.Name = "pbxSchedule";
            this.pbxSchedule.Size = new System.Drawing.Size(60, 60);
            this.pbxSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSchedule.TabIndex = 9;
            this.pbxSchedule.TabStop = false;
            this.ttpMain.SetToolTip(this.pbxSchedule, "View shifts and manage attendance");
            this.pbxSchedule.Click += new System.EventHandler(this.btnViewShifts_Click);
            this.pbxSchedule.MouseEnter += new System.EventHandler(this.TogglePictureButtonSize);
            this.pbxSchedule.MouseLeave += new System.EventHandler(this.TogglePictureButtonSize);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlTools.Controls.Add(this.pbxAdd);
            this.pnlTools.Controls.Add(this.pbxSchedule);
            this.pnlTools.Controls.Add(this.pbxRemove);
            this.pnlTools.Controls.Add(this.pbxManageShift);
            this.pnlTools.Controls.Add(this.pbxEdit);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTools.Location = new System.Drawing.Point(2, 475);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(1477, 80);
            this.pnlTools.TabIndex = 10;
            // 
            // ManageEmployees
            // 
            this.AcceptButton = this.btnSearchEmps;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1481, 557);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.btnSearchEmps);
            this.Controls.Add(this.tbSearchEmps);
            this.Controls.Add(this.lvEmps);
            this.MinimumSize = new System.Drawing.Size(1151, 569);
            this.Name = "ManageEmployees";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "ManageEmployees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManageShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSchedule)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ColumnHeader colDepName;
        private System.Windows.Forms.ColumnHeader colIsStudent;
        private System.Windows.Forms.TextBox tbSearchEmps;
        private System.Windows.Forms.Button btnSearchEmps;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxManageShift;
        private System.Windows.Forms.PictureBox pbxSchedule;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ToolTip ttpMain;
        private System.Windows.Forms.ColumnHeader colContract;
    }
}