
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
            this.lvProducts = new System.Windows.Forms.ListView();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrRestockAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRestockAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colEan,
            this.colDeptName,
            this.colStock,
            this.colMinStock,
            this.colPrice});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 76);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(784, 236);
            this.lvProducts.TabIndex = 2;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
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
            this.tbSearch.Location = new System.Drawing.Point(60, 26);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(123, 23);
            this.tbSearch.TabIndex = 3;
            // 
            // lblSeatch
            // 
            this.lblSeatch.AutoSize = true;
            this.lblSeatch.Location = new System.Drawing.Point(12, 29);
            this.lblSeatch.Name = "lblSeatch";
            this.lblSeatch.Size = new System.Drawing.Size(42, 15);
            this.lblSeatch.TabIndex = 4;
            this.lblSeatch.Text = "Search";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 342);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 45);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add new item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(138, 342);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(126, 45);
            this.btnRemoveItem.TabIndex = 7;
            this.btnRemoveItem.Text = "Remove selected item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSendRestockRequest
            // 
            this.btnSendRestockRequest.Location = new System.Drawing.Point(628, 360);
            this.btnSendRestockRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendRestockRequest.Name = "btnSendRestockRequest";
            this.btnSendRestockRequest.Size = new System.Drawing.Size(170, 27);
            this.btnSendRestockRequest.TabIndex = 8;
            this.btnSendRestockRequest.Text = "Send Restock Request";
            this.btnSendRestockRequest.UseVisualStyleBackColor = true;
            this.btnSendRestockRequest.Click += new System.EventHandler(this.btnSendRestockRequest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(719, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount to restock:";
            // 
            // nmrRestockAmount
            // 
            this.nmrRestockAmount.Location = new System.Drawing.Point(743, 332);
            this.nmrRestockAmount.Name = "nmrRestockAmount";
            this.nmrRestockAmount.Size = new System.Drawing.Size(53, 23);
            this.nmrRestockAmount.TabIndex = 13;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 398);
            this.Controls.Add(this.nmrRestockAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSendRestockRequest);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblSeatch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lvProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.nmrRestockAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrRestockAmount;
    }
}