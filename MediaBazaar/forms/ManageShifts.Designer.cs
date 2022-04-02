
namespace MediaBazaar.forms
{
    partial class ManageShifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageShifts));
            this.calShifts = new System.Windows.Forms.MonthCalendar();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbMorning = new System.Windows.Forms.CheckBox();
            this.cbAfternoon = new System.Windows.Forms.CheckBox();
            this.cbEvening = new System.Windows.Forms.CheckBox();
            this.gbManageShift = new System.Windows.Forms.GroupBox();
            this.btnRemoveShift = new System.Windows.Forms.Button();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.gbManageShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // calShifts
            // 
            this.calShifts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calShifts.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.calShifts.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calShifts.Location = new System.Drawing.Point(18, 19);
            this.calShifts.MaxSelectionCount = 1;
            this.calShifts.Name = "calShifts";
            this.calShifts.TabIndex = 0;
            this.calShifts.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calShifts_DateSelected);
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpName.Location = new System.Drawing.Point(307, 28);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(164, 25);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Name of employee";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Assigned Shifts: ",
            "Morning, Afternoon"});
            this.listBox1.Location = new System.Drawing.Point(307, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 79);
            this.listBox1.TabIndex = 2;
            // 
            // cbMorning
            // 
            this.cbMorning.AutoSize = true;
            this.cbMorning.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMorning.Location = new System.Drawing.Point(17, 92);
            this.cbMorning.Name = "cbMorning";
            this.cbMorning.Size = new System.Drawing.Size(102, 29);
            this.cbMorning.TabIndex = 3;
            this.cbMorning.Text = "Morning";
            this.cbMorning.UseVisualStyleBackColor = true;
            this.cbMorning.CheckedChanged += new System.EventHandler(this.cbMorning_CheckedChanged);
            // 
            // cbAfternoon
            // 
            this.cbAfternoon.AutoSize = true;
            this.cbAfternoon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAfternoon.Location = new System.Drawing.Point(177, 92);
            this.cbAfternoon.Name = "cbAfternoon";
            this.cbAfternoon.Size = new System.Drawing.Size(115, 29);
            this.cbAfternoon.TabIndex = 4;
            this.cbAfternoon.Text = "Afternoon";
            this.cbAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbEvening
            // 
            this.cbEvening.AutoSize = true;
            this.cbEvening.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEvening.Location = new System.Drawing.Point(347, 92);
            this.cbEvening.Name = "cbEvening";
            this.cbEvening.Size = new System.Drawing.Size(96, 29);
            this.cbEvening.TabIndex = 5;
            this.cbEvening.Text = "Evening";
            this.cbEvening.UseVisualStyleBackColor = true;
            this.cbEvening.CheckedChanged += new System.EventHandler(this.cbEvening_CheckedChanged);
            // 
            // gbManageShift
            // 
            this.gbManageShift.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbManageShift.Controls.Add(this.btnRemoveShift);
            this.gbManageShift.Controls.Add(this.btnAddShift);
            this.gbManageShift.Controls.Add(this.cbMorning);
            this.gbManageShift.Controls.Add(this.cbEvening);
            this.gbManageShift.Controls.Add(this.cbAfternoon);
            this.gbManageShift.Location = new System.Drawing.Point(307, 155);
            this.gbManageShift.Name = "gbManageShift";
            this.gbManageShift.Size = new System.Drawing.Size(461, 261);
            this.gbManageShift.TabIndex = 6;
            this.gbManageShift.TabStop = false;
            this.gbManageShift.Text = "Manage shift";
            // 
            // btnRemoveShift
            // 
            this.btnRemoveShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveShift.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveShift.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRemoveShift.Location = new System.Drawing.Point(251, 189);
            this.btnRemoveShift.Name = "btnRemoveShift";
            this.btnRemoveShift.Size = new System.Drawing.Size(139, 37);
            this.btnRemoveShift.TabIndex = 7;
            this.btnRemoveShift.Text = "Remove shift";
            this.btnRemoveShift.UseVisualStyleBackColor = true;
            this.btnRemoveShift.Click += new System.EventHandler(this.btnRemoveShift_Click);
            // 
            // btnAddShift
            // 
            this.btnAddShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShift.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddShift.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddShift.Location = new System.Drawing.Point(55, 189);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(138, 37);
            this.btnAddShift.TabIndex = 6;
            this.btnAddShift.Text = "Add shift";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // ManageShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.gbManageShift);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.calShifts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageShifts";
            this.Text = "ManageShifts";
            this.Load += new System.EventHandler(this.ManageShifts_Load);
            this.gbManageShift.ResumeLayout(false);
            this.gbManageShift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calShifts;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cbMorning;
        private System.Windows.Forms.CheckBox cbAfternoon;
        private System.Windows.Forms.CheckBox cbEvening;
        private System.Windows.Forms.GroupBox gbManageShift;
        private System.Windows.Forms.Button btnRemoveShift;
        private System.Windows.Forms.Button btnAddShift;
    }
}