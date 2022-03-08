
namespace MediaBazaar.forms
{
    partial class Sell
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
            this.lvAllItems = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colEan = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.colStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnResetCart = new System.Windows.Forms.Button();
            this.btnSellCart = new System.Windows.Forms.Button();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnAmount = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.btnAddAmountToCart = new System.Windows.Forms.Button();
            this.nmrAddAmountToCart = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSeatch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAddAmountToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAllItems
            // 
            this.lvAllItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colEan,
            this.colDeptName,
            this.colStock,
            this.colMinStock,
            this.colPrice});
            this.lvAllItems.FullRowSelect = true;
            this.lvAllItems.GridLines = true;
            this.lvAllItems.HideSelection = false;
            this.lvAllItems.Location = new System.Drawing.Point(12, 49);
            this.lvAllItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAllItems.MultiSelect = false;
            this.lvAllItems.Name = "lvAllItems";
            this.lvAllItems.Size = new System.Drawing.Size(786, 236);
            this.lvAllItems.TabIndex = 3;
            this.lvAllItems.UseCompatibleStateImageBehavior = false;
            this.lvAllItems.View = System.Windows.Forms.View.Details;
            this.lvAllItems.SelectedIndexChanged += new System.EventHandler(this.lvAllItems_SelectedIndexChanged);
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
            // gbCart
            // 
            this.gbCart.Controls.Add(this.btnRemoveEntry);
            this.gbCart.Controls.Add(this.label1);
            this.gbCart.Controls.Add(this.tbxTotal);
            this.gbCart.Controls.Add(this.btnResetCart);
            this.gbCart.Controls.Add(this.btnSellCart);
            this.gbCart.Controls.Add(this.lvCart);
            this.gbCart.Controls.Add(this.btnAddAmountToCart);
            this.gbCart.Controls.Add(this.nmrAddAmountToCart);
            this.gbCart.Location = new System.Drawing.Point(14, 326);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(784, 275);
            this.gbCart.TabIndex = 4;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "Cart";
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.Location = new System.Drawing.Point(287, 242);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(153, 24);
            this.btnRemoveEntry.TabIndex = 18;
            this.btnRemoveEntry.Text = "Remove selected entry";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(657, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "TOTAL:";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(719, 246);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(59, 23);
            this.tbxTotal.TabIndex = 17;
            // 
            // btnResetCart
            // 
            this.btnResetCart.Location = new System.Drawing.Point(145, 129);
            this.btnResetCart.Name = "btnResetCart";
            this.btnResetCart.Size = new System.Drawing.Size(110, 39);
            this.btnResetCart.TabIndex = 8;
            this.btnResetCart.Text = "Reset Cart";
            this.btnResetCart.UseVisualStyleBackColor = true;
            this.btnResetCart.Click += new System.EventHandler(this.btnResetCart_Click);
            // 
            // btnSellCart
            // 
            this.btnSellCart.Location = new System.Drawing.Point(29, 129);
            this.btnSellCart.Name = "btnSellCart";
            this.btnSellCart.Size = new System.Drawing.Size(110, 39);
            this.btnSellCart.TabIndex = 7;
            this.btnSellCart.Text = "Sell Cart";
            this.btnSellCart.UseVisualStyleBackColor = true;
            this.btnSellCart.Click += new System.EventHandler(this.btnSellCart_Click);
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnAmount,
            this.columnPrice});
            this.lvCart.FullRowSelect = true;
            this.lvCart.GridLines = true;
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(287, 21);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(491, 215);
            this.lvCart.TabIndex = 15;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.SelectedIndexChanged += new System.EventHandler(this.lvCart_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Product name";
            this.columnName.Width = 300;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            // 
            // btnAddAmountToCart
            // 
            this.btnAddAmountToCart.Location = new System.Drawing.Point(29, 74);
            this.btnAddAmountToCart.Name = "btnAddAmountToCart";
            this.btnAddAmountToCart.Size = new System.Drawing.Size(153, 32);
            this.btnAddAmountToCart.TabIndex = 5;
            this.btnAddAmountToCart.Text = "Add amount to cart";
            this.btnAddAmountToCart.UseVisualStyleBackColor = true;
            this.btnAddAmountToCart.Click += new System.EventHandler(this.btnAddAmountToCart_Click);
            // 
            // nmrAddAmountToCart
            // 
            this.nmrAddAmountToCart.Location = new System.Drawing.Point(202, 81);
            this.nmrAddAmountToCart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrAddAmountToCart.Name = "nmrAddAmountToCart";
            this.nmrAddAmountToCart.Size = new System.Drawing.Size(51, 23);
            this.nmrAddAmountToCart.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(723, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSeatch
            // 
            this.lblSeatch.AutoSize = true;
            this.lblSeatch.Location = new System.Drawing.Point(16, 15);
            this.lblSeatch.Name = "lblSeatch";
            this.lblSeatch.Size = new System.Drawing.Size(42, 15);
            this.lblSeatch.TabIndex = 12;
            this.lblSeatch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(64, 12);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(123, 23);
            this.tbSearch.TabIndex = 11;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 620);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSeatch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.lvAllItems);
            this.Name = "Sell";
            this.Text = "Sell";
            this.gbCart.ResumeLayout(false);
            this.gbCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAddAmountToCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAllItems;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEan;
        private System.Windows.Forms.ColumnHeader colDeptName;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ColumnHeader colMinStock;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.Button btnAddAmountToCart;
        private System.Windows.Forms.NumericUpDown nmrAddAmountToCart;
        private System.Windows.Forms.Button btnSellCart;
        private System.Windows.Forms.Button btnResetCart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSeatch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button btnRemoveEntry;
    }
}