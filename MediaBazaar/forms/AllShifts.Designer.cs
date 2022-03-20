
namespace MediaBazaar.forms
{
    partial class AllShifts
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
            this.calShifts = new System.Windows.Forms.MonthCalendar();
            this.lvShifts = new System.Windows.Forms.ListView();
            this.colShiftId = new System.Windows.Forms.ColumnHeader();
            this.colFirstName = new System.Windows.Forms.ColumnHeader();
            this.colLastName = new System.Windows.Forms.ColumnHeader();
            this.colRole = new System.Windows.Forms.ColumnHeader();
            this.colDepartment = new System.Windows.Forms.ColumnHeader();
            this.colShifts = new System.Windows.Forms.ColumnHeader();
            this.colAttended = new System.Windows.Forms.ColumnHeader();
            this.btnAttended = new System.Windows.Forms.Button();
            this.btnMissing = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbAttendance = new System.Windows.Forms.GroupBox();
            this.gbAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // calShifts
            // 
            this.calShifts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calShifts.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.calShifts.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calShifts.ForeColor = System.Drawing.SystemColors.MenuText;
            this.calShifts.Location = new System.Drawing.Point(25, 27);
            this.calShifts.Name = "calShifts";
            this.calShifts.TabIndex = 7;
            this.calShifts.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calShifts_DateChanged);
            // 
            // lvShifts
            // 
            this.lvShifts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colShiftId,
            this.colFirstName,
            this.colLastName,
            this.colRole,
            this.colDepartment,
            this.colShifts,
            this.colAttended});
            this.lvShifts.FullRowSelect = true;
            this.lvShifts.GridLines = true;
            this.lvShifts.HideSelection = false;
            this.lvShifts.Location = new System.Drawing.Point(313, 67);
            this.lvShifts.MultiSelect = false;
            this.lvShifts.Name = "lvShifts";
            this.lvShifts.Size = new System.Drawing.Size(839, 301);
            this.lvShifts.TabIndex = 8;
            this.lvShifts.UseCompatibleStateImageBehavior = false;
            this.lvShifts.View = System.Windows.Forms.View.Details;
            // 
            // colShiftId
            // 
            this.colShiftId.Text = "Shift ID";
            this.colShiftId.Width = 70;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First name";
            this.colFirstName.Width = 120;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last name";
            this.colLastName.Width = 120;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 130;
            // 
            // colDepartment
            // 
            this.colDepartment.Text = "Department";
            this.colDepartment.Width = 120;
            // 
            // colShifts
            // 
            this.colShifts.Text = "Shifts";
            this.colShifts.Width = 180;
            // 
            // colAttended
            // 
            this.colAttended.Text = "Missing";
            this.colAttended.Width = 120;
            // 
            // btnAttended
            // 
            this.btnAttended.BackColor = System.Drawing.Color.Transparent;
            this.btnAttended.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAttended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttended.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttended.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAttended.Location = new System.Drawing.Point(24, 39);
            this.btnAttended.Name = "btnAttended";
            this.btnAttended.Size = new System.Drawing.Size(126, 45);
            this.btnAttended.TabIndex = 9;
            this.btnAttended.Text = "Attended";
            this.btnAttended.UseVisualStyleBackColor = true;
            this.btnAttended.Click += new System.EventHandler(this.btnAttended_Click);
            // 
            // btnMissing
            // 
            this.btnMissing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMissing.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMissing.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMissing.ForeColor = System.Drawing.Color.Crimson;
            this.btnMissing.Location = new System.Drawing.Point(696, 39);
            this.btnMissing.Name = "btnMissing";
            this.btnMissing.Size = new System.Drawing.Size(125, 45);
            this.btnMissing.TabIndex = 10;
            this.btnMissing.Text = "Missing";
            this.btnMissing.UseVisualStyleBackColor = true;
            this.btnMissing.Click += new System.EventHandler(this.btnMissing_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(323, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(244, 20);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "Viewing shifts for: All departments";
            // 
            // gbAttendance
            // 
            this.gbAttendance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbAttendance.Controls.Add(this.btnMissing);
            this.gbAttendance.Controls.Add(this.btnAttended);
            this.gbAttendance.Location = new System.Drawing.Point(313, 385);
            this.gbAttendance.Name = "gbAttendance";
            this.gbAttendance.Size = new System.Drawing.Size(839, 116);
            this.gbAttendance.TabIndex = 12;
            this.gbAttendance.TabStop = false;
            this.gbAttendance.Text = "Attendance";
            // 
            // AllShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 513);
            this.Controls.Add(this.gbAttendance);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lvShifts);
            this.Controls.Add(this.calShifts);
            this.Name = "AllShifts";
            this.Text = "AllShifts";
            this.gbAttendance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calShifts;
        private System.Windows.Forms.ListView lvShifts;
        private System.Windows.Forms.ColumnHeader colShiftId;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colShifts;
        private System.Windows.Forms.ColumnHeader colAttended;
        private System.Windows.Forms.Button btnAttended;
        private System.Windows.Forms.Button btnMissing;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ColumnHeader colDepartment;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.GroupBox gbAttendance;
    }
}