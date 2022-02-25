
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Yordan",
            "Doykov",
            "Morning, Evening",
            "Attended"}, -1);
            this.calShifts = new System.Windows.Forms.MonthCalendar();
            this.lvShifts = new System.Windows.Forms.ListView();
            this.colShiftID = new System.Windows.Forms.ColumnHeader();
            this.colFirstName = new System.Windows.Forms.ColumnHeader();
            this.colLastName = new System.Windows.Forms.ColumnHeader();
            this.colShifts = new System.Windows.Forms.ColumnHeader();
            this.colAttended = new System.Windows.Forms.ColumnHeader();
            this.btnAttended = new System.Windows.Forms.Button();
            this.btnMissing = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calShifts
            // 
            this.calShifts.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.calShifts.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calShifts.Location = new System.Drawing.Point(25, 27);
            this.calShifts.Name = "calShifts";
            this.calShifts.TabIndex = 7;
            // 
            // lvShifts
            // 
            this.lvShifts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colShiftID,
            this.colFirstName,
            this.colLastName,
            this.colShifts,
            this.colAttended});
            this.lvShifts.HideSelection = false;
            this.lvShifts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvShifts.Location = new System.Drawing.Point(313, 67);
            this.lvShifts.Name = "lvShifts";
            this.lvShifts.Size = new System.Drawing.Size(614, 301);
            this.lvShifts.TabIndex = 8;
            this.lvShifts.UseCompatibleStateImageBehavior = false;
            this.lvShifts.View = System.Windows.Forms.View.Details;
            // 
            // colShiftID
            // 
            this.colShiftID.Text = "Shift ID";
            this.colShiftID.Width = 70;
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
            // colShifts
            // 
            this.colShifts.Text = "Shifts";
            this.colShifts.Width = 180;
            // 
            // colAttended
            // 
            this.colAttended.Text = "Attendance";
            this.colAttended.Width = 120;
            // 
            // btnAttended
            // 
            this.btnAttended.Location = new System.Drawing.Point(322, 393);
            this.btnAttended.Name = "btnAttended";
            this.btnAttended.Size = new System.Drawing.Size(94, 29);
            this.btnAttended.TabIndex = 9;
            this.btnAttended.Text = "Attended";
            this.btnAttended.UseVisualStyleBackColor = true;
            // 
            // btnMissing
            // 
            this.btnMissing.Location = new System.Drawing.Point(432, 393);
            this.btnMissing.Name = "btnMissing";
            this.btnMissing.Size = new System.Drawing.Size(94, 29);
            this.btnMissing.TabIndex = 10;
            this.btnMissing.Text = "Missing";
            this.btnMissing.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(323, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(236, 20);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "Viewing shifts for: All departments";
            // 
            // AllShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 513);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.btnMissing);
            this.Controls.Add(this.btnAttended);
            this.Controls.Add(this.lvShifts);
            this.Controls.Add(this.calShifts);
            this.Name = "AllShifts";
            this.Text = "AllShifts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calShifts;
        private System.Windows.Forms.ListView lvShifts;
        private System.Windows.Forms.ColumnHeader colShiftID;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colShifts;
        private System.Windows.Forms.ColumnHeader colAttended;
        private System.Windows.Forms.Button btnAttended;
        private System.Windows.Forms.Button btnMissing;
        private System.Windows.Forms.Label lblDepartment;
    }
}