﻿
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
            this.lvRestockRequests = new System.Windows.Forms.ListView();
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
            // lvRestockRequests
            // 
            this.lvRestockRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDateCreated,
            this.colDateProcessed,
            this.colProductID,
            this.colProductName,
            this.colCurrentStock,
            this.colMinStock,
            this.colRequestAmount,
            this.columnStatus});
            this.lvRestockRequests.FullRowSelect = true;
            this.lvRestockRequests.GridLines = true;
            this.lvRestockRequests.HideSelection = false;
            this.lvRestockRequests.Location = new System.Drawing.Point(10, 9);
            this.lvRestockRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRestockRequests.MultiSelect = false;
            this.lvRestockRequests.Name = "lvRestockRequests";
            this.lvRestockRequests.Size = new System.Drawing.Size(995, 245);
            this.lvRestockRequests.TabIndex = 3;
            this.lvRestockRequests.UseCompatibleStateImageBehavior = false;
            this.lvRestockRequests.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.Width = 150;
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
            this.btnAcceptRequest.Click += new System.EventHandler(this.btnAcceptRequest_Click);
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Location = new System.Drawing.Point(133, 282);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(117, 52);
            this.btnDenyRequest.TabIndex = 5;
            this.btnDenyRequest.Text = "Deny Request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // RestockRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 374);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnAcceptRequest);
            this.Controls.Add(this.lvRestockRequests);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RestockRequests";
            this.Text = "RestockRequests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRestockRequests;
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