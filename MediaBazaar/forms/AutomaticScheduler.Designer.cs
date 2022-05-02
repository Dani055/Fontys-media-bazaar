namespace MediaBazaar.forms
{
    partial class AutomaticScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticScheduler));
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblNextWeek = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarningMessage.Location = new System.Drawing.Point(135, 50);
            this.lblWarningMessage.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(497, 84);
            this.lblWarningMessage.TabIndex = 0;
            this.lblWarningMessage.Text = resources.GetString("lblWarningMessage.Text");
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.Location = new System.Drawing.Point(313, 207);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(141, 15);
            this.lblContinue.TabIndex = 1;
            this.lblContinue.Text = "Do you wish to continue?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(216, 260);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(88, 45);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(460, 260);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(88, 45);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblNextWeek
            // 
            this.lblNextWeek.AutoSize = true;
            this.lblNextWeek.Location = new System.Drawing.Point(148, 159);
            this.lblNextWeek.Name = "lblNextWeek";
            this.lblNextWeek.Size = new System.Drawing.Size(92, 15);
            this.lblNextWeek.TabIndex = 4;
            this.lblNextWeek.Text = "*Affected Week:";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(246, 159);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(135, 15);
            this.lblDates.TabIndex = 5;
            this.lblDates.Text = "<insert following week>";
            // 
            // AutomaticScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.lblNextWeek);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblWarningMessage);
            this.Name = "AutomaticScheduler";
            this.Text = "AutomaticScheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarningMessage;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblNextWeek;
        private System.Windows.Forms.Label lblDates;
    }
}