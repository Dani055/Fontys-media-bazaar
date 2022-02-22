
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
            this.lvItemSell = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colEan = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.colStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.btnAddAmountToCart = new System.Windows.Forms.Button();
            this.numAddAmountToCart = new System.Windows.Forms.NumericUpDown();
            this.btnSellCart = new System.Windows.Forms.Button();
            this.btnResetCart = new System.Windows.Forms.Button();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddAmountToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lvItemSell
            // 
            this.lvItemSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colEan,
            this.colDeptName,
            this.colStock,
            this.colMinStock,
            this.colPrice});
            this.lvItemSell.FullRowSelect = true;
            this.lvItemSell.GridLines = true;
            this.lvItemSell.HideSelection = false;
            this.lvItemSell.Location = new System.Drawing.Point(12, 11);
            this.lvItemSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvItemSell.MultiSelect = false;
            this.lvItemSell.Name = "lvItemSell";
            this.lvItemSell.Size = new System.Drawing.Size(776, 236);
            this.lvItemSell.TabIndex = 3;
            this.lvItemSell.UseCompatibleStateImageBehavior = false;
            this.lvItemSell.View = System.Windows.Forms.View.Details;
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
            this.gbCart.Controls.Add(this.btnResetCart);
            this.gbCart.Controls.Add(this.btnSellCart);
            this.gbCart.Controls.Add(this.btnAddAmountToCart);
            this.gbCart.Controls.Add(this.numAddAmountToCart);
            this.gbCart.Location = new System.Drawing.Point(12, 287);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(260, 186);
            this.gbCart.TabIndex = 4;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "Cart";
            // 
            // btnAddAmountToCart
            // 
            this.btnAddAmountToCart.Location = new System.Drawing.Point(6, 35);
            this.btnAddAmountToCart.Name = "btnAddAmountToCart";
            this.btnAddAmountToCart.Size = new System.Drawing.Size(110, 39);
            this.btnAddAmountToCart.TabIndex = 5;
            this.btnAddAmountToCart.Text = "Add amount to cart";
            this.btnAddAmountToCart.UseVisualStyleBackColor = true;
            // 
            // numAddAmountToCart
            // 
            this.numAddAmountToCart.Location = new System.Drawing.Point(122, 45);
            this.numAddAmountToCart.Name = "numAddAmountToCart";
            this.numAddAmountToCart.Size = new System.Drawing.Size(53, 23);
            this.numAddAmountToCart.TabIndex = 6;
            // 
            // btnSellCart
            // 
            this.btnSellCart.Location = new System.Drawing.Point(6, 141);
            this.btnSellCart.Name = "btnSellCart";
            this.btnSellCart.Size = new System.Drawing.Size(110, 39);
            this.btnSellCart.TabIndex = 7;
            this.btnSellCart.Text = "Sell Cart";
            this.btnSellCart.UseVisualStyleBackColor = true;
            // 
            // btnResetCart
            // 
            this.btnResetCart.Location = new System.Drawing.Point(144, 141);
            this.btnResetCart.Name = "btnResetCart";
            this.btnResetCart.Size = new System.Drawing.Size(110, 39);
            this.btnResetCart.TabIndex = 8;
            this.btnResetCart.Text = "Reset Cart";
            this.btnResetCart.UseVisualStyleBackColor = true;
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 15;
            this.lbCart.Location = new System.Drawing.Point(278, 302);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(380, 169);
            this.lbCart.TabIndex = 5;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(278, 284);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(29, 15);
            this.lblCart.TabIndex = 6;
            this.lblCart.Text = "Cart";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.lvItemSell);
            this.Name = "Sell";
            this.Text = "Sell";
            this.gbCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddAmountToCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvItemSell;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEan;
        private System.Windows.Forms.ColumnHeader colDeptName;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ColumnHeader colMinStock;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.Button btnAddAmountToCart;
        private System.Windows.Forms.NumericUpDown numAddAmountToCart;
        private System.Windows.Forms.Button btnSellCart;
        private System.Windows.Forms.Button btnResetCart;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Label lblCart;
    }
}