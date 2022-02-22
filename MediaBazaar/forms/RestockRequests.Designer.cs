
namespace MediaBazaar.forms
{
    partial class RestockRequests
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
            this.colDateCreated = new System.Windows.Forms.ColumnHeader();
            this.colDateProcessed = new System.Windows.Forms.ColumnHeader();
            this.colProductID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colCurrentStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colRequestAmount = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmps
            // 
            this.lvEmps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDateCreated,
            this.colDateProcessed,
            this.colProductID,
            this.colProductName,
            this.colCurrentStock,
            this.colMinStock,
            this.colRequestAmount,
            this.columnStatus});
            this.lvEmps.FullRowSelect = true;
            this.lvEmps.GridLines = true;
            this.lvEmps.HideSelection = false;
            this.lvEmps.Location = new System.Drawing.Point(10, 9);
            this.lvEmps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvEmps.MultiSelect = false;
            this.lvEmps.Name = "lvEmps";
            this.lvEmps.Size = new System.Drawing.Size(996, 245);
            this.lvEmps.TabIndex = 3;
            this.lvEmps.UseCompatibleStateImageBehavior = false;
            this.lvEmps.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.Width = 200;
            // 
            // colDateProcessed
            // 
            this.colDateProcessed.Text = "Date processed";
            this.colDateProcessed.Width = 150;
            // 
            // colProductID
            // 
            this.colProductID.Text = "Product ID";
            this.colProductID.Width = 120;
            // 
            // colProductName
            // 
            this.colProductName.Text = "Product name";
            this.colProductName.Width = 180;
            // 
            // colCurrentStock
            // 
            this.colCurrentStock.Text = "Current stock";
            this.colCurrentStock.Width = 100;
            // 
            // colMinStock
            // 
            this.colMinStock.Text = "Min. Stock";
            this.colMinStock.Width = 80;
            // 
            // colRequestAmount
            // 
            this.colRequestAmount.Text = "Requested amount";
            this.colRequestAmount.Width = 150;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 100;
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.Location = new System.Drawing.Point(10, 282);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(117, 52);
            this.btnAcceptRequest.TabIndex = 4;
            this.btnAcceptRequest.Text = "Accept Request";
            this.btnAcceptRequest.UseVisualStyleBackColor = true;
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Location = new System.Drawing.Point(888, 282);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(117, 52);
            this.btnDenyRequest.TabIndex = 5;
            this.btnDenyRequest.Text = "Deny Request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            // 
            // RestockRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 374);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnAcceptRequest);
            this.Controls.Add(this.lvEmps);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RestockRequests";
            this.Text = "RestockRequests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEmps;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateProcessed;
        private System.Windows.Forms.ColumnHeader colProductID;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colCurrentStock;
        private System.Windows.Forms.ColumnHeader colMinStock;
        private System.Windows.Forms.ColumnHeader colRequestAmount;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Button btnAcceptRequest;
        private System.Windows.Forms.Button btnDenyRequest;
    }
}