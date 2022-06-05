
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnManageDepartments = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRestockReq = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.lblLoggedAs = new System.Windows.Forms.Label();
            this.pbxLogout = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pnlClockBG = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlClockBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsername.Location = new System.Drawing.Point(68, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(167, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Welcome, Username";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRole.Location = new System.Drawing.Point(681, 23);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 23);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnManageEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmp.FlatAppearance.BorderSize = 0;
            this.btnManageEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnManageEmp.Location = new System.Drawing.Point(16, 12);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(158, 83);
            this.btnManageEmp.TabIndex = 1;
            this.btnManageEmp.Text = "Manage Employees";
            this.btnManageEmp.UseVisualStyleBackColor = false;
            this.btnManageEmp.EnabledChanged += new System.EventHandler(this.ChangeButtonBGonDisabled);
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnManageDepartments
            // 
            this.btnManageDepartments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnManageDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDepartments.FlatAppearance.BorderSize = 0;
            this.btnManageDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnManageDepartments.Location = new System.Drawing.Point(185, 12);
            this.btnManageDepartments.Name = "btnManageDepartments";
            this.btnManageDepartments.Size = new System.Drawing.Size(160, 83);
            this.btnManageDepartments.TabIndex = 2;
            this.btnManageDepartments.Text = "Manage Departments";
            this.btnManageDepartments.UseVisualStyleBackColor = false;
            this.btnManageDepartments.EnabledChanged += new System.EventHandler(this.ChangeButtonBGonDisabled);
            this.btnManageDepartments.Click += new System.EventHandler(this.btnManageDepartments_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnInventory.Location = new System.Drawing.Point(357, 12);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(159, 83);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.EnabledChanged += new System.EventHandler(this.ChangeButtonBGonDisabled);
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.pnlNav.Controls.Add(this.btnManageEmp);
            this.pnlNav.Controls.Add(this.btnSell);
            this.pnlNav.Controls.Add(this.btnManageDepartments);
            this.pnlNav.Controls.Add(this.btnRestockReq);
            this.pnlNav.Controls.Add(this.btnInventory);
            this.pnlNav.Location = new System.Drawing.Point(0, 66);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(871, 106);
            this.pnlNav.TabIndex = 9;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnSell.Location = new System.Drawing.Point(696, 12);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(159, 83);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "Sell screen";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.EnabledChanged += new System.EventHandler(this.ChangeButtonBGonDisabled);
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRestockReq
            // 
            this.btnRestockReq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestockReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnRestockReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestockReq.FlatAppearance.BorderSize = 0;
            this.btnRestockReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestockReq.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestockReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnRestockReq.Location = new System.Drawing.Point(526, 12);
            this.btnRestockReq.Name = "btnRestockReq";
            this.btnRestockReq.Size = new System.Drawing.Size(159, 83);
            this.btnRestockReq.TabIndex = 3;
            this.btnRestockReq.Text = "Restock requests";
            this.btnRestockReq.UseVisualStyleBackColor = false;
            this.btnRestockReq.EnabledChanged += new System.EventHandler(this.ChangeButtonBGonDisabled);
            this.btnRestockReq.Click += new System.EventHandler(this.btnRestockReq_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.pbxProfile);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.lblLoggedAs);
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 66);
            this.panel2.TabIndex = 10;
            // 
            // pbxProfile
            // 
            this.pbxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfile.Image")));
            this.pbxProfile.Location = new System.Drawing.Point(12, 11);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(50, 44);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfile.TabIndex = 1;
            this.pbxProfile.TabStop = false;
            // 
            // lblLoggedAs
            // 
            this.lblLoggedAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedAs.AutoSize = true;
            this.lblLoggedAs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedAs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoggedAs.Location = new System.Drawing.Point(534, 23);
            this.lblLoggedAs.Name = "lblLoggedAs";
            this.lblLoggedAs.Size = new System.Drawing.Size(151, 23);
            this.lblLoggedAs.TabIndex = 1;
            this.lblLoggedAs.Text = "You are logged as ";
            // 
            // pbxLogout
            // 
            this.pbxLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogout.Image")));
            this.pbxLogout.Location = new System.Drawing.Point(783, 425);
            this.pbxLogout.Name = "pbxLogout";
            this.pbxLogout.Size = new System.Drawing.Size(65, 62);
            this.pbxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogout.TabIndex = 11;
            this.pbxLogout.TabStop = false;
            this.pbxLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(279, 277);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(331, 219);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 12;
            this.pbxLogo.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(184, 73);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "00:00";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // pnlClockBG
            // 
            this.pnlClockBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlClockBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.pnlClockBG.Controls.Add(this.lblTime);
            this.pnlClockBG.Location = new System.Drawing.Point(357, 195);
            this.pnlClockBG.Name = "pnlClockBG";
            this.pnlClockBG.Size = new System.Drawing.Size(184, 73);
            this.pnlClockBG.TabIndex = 14;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 508);
            this.Controls.Add(this.pnlClockBG);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pbxLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(889, 498);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.pnlNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlClockBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnManageDepartments;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnRestockReq;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.PictureBox pbxLogout;
        private System.Windows.Forms.Label lblLoggedAs;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Panel pnlClockBG;
    }
}