
namespace MediaBazaar.forms
{
    partial class Inventory
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
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colEan = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.colStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSeatch = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSendRestockRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmps
            // 
            this.lvEmps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colEan,
            this.colDeptName,
            this.colStock,
            this.colMinStock,
            this.colPrice});
            this.lvEmps.FullRowSelect = true;
            this.lvEmps.GridLines = true;
            this.lvEmps.HideSelection = false;
            this.lvEmps.Location = new System.Drawing.Point(10, 29);
            this.lvEmps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvEmps.MultiSelect = false;
            this.lvEmps.Name = "lvEmps";
            this.lvEmps.Size = new System.Drawing.Size(686, 236);
            this.lvEmps.TabIndex = 2;
            this.lvEmps.UseCompatibleStateImageBehavior = false;
            this.lvEmps.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colName
            // 
            this.colName.Text = "Product name";
            this.colName.Width = 200;
            // 
            // colEan
            // 
            this.colEan.Text = "Barcode";
            this.colEan.Width = 150;
            // 
            // colDeptName
            // 
            this.colDeptName.Text = "Department";
            this.colDeptName.Width = 120;
            // 
            // colStock
            // 
            this.colStock.Text = "In stock";
            this.colStock.Width = 80;
            // 
            // colMinStock
            // 
            this.colMinStock.Text = "Min. Stock";
            this.colMinStock.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 100;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(62, 4);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(123, 23);
            this.tbSearch.TabIndex = 3;
            // 
            // lblSeatch
            // 
            this.lblSeatch.AutoSize = true;
            this.lblSeatch.Location = new System.Drawing.Point(10, 7);
            this.lblSeatch.Name = "lblSeatch";
            this.lblSeatch.Size = new System.Drawing.Size(42, 15);
            this.lblSeatch.TabIndex = 4;
            this.lblSeatch.Text = "Search";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(10, 278);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 45);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add new item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(150, 278);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(126, 45);
            this.btnRemoveItem.TabIndex = 7;
            this.btnRemoveItem.Text = "Remove selected item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnSendRestockRequest
            // 
            this.btnSendRestockRequest.Location = new System.Drawing.Point(576, 278);
            this.btnSendRestockRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendRestockRequest.Name = "btnSendRestockRequest";
            this.btnSendRestockRequest.Size = new System.Drawing.Size(120, 45);
            this.btnSendRestockRequest.TabIndex = 8;
            this.btnSendRestockRequest.Text = "Send ReStock Request";
            this.btnSendRestockRequest.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 398);
            this.Controls.Add(this.btnSendRestockRequest);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblSeatch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lvEmps);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEmps;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEan;
        private System.Windows.Forms.ColumnHeader colDeptName;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ColumnHeader colMinStock;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSeatch;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSendRestockRequest;
    }
}