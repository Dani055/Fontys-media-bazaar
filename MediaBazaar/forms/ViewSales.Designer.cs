namespace MediaBazaar.forms
{
    partial class ViewSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSales));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvSales = new System.Windows.Forms.ListView();
            this.colSaleID = new System.Windows.Forms.ColumnHeader();
            this.colSaleDate = new System.Windows.Forms.ColumnHeader();
            this.colSellerID = new System.Windows.Forms.ColumnHeader();
            this.colSellerName = new System.Windows.Forms.ColumnHeader();
            this.colProductID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colAmountSold = new System.Windows.Forms.ColumnHeader();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTotalSales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTotalRevenue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTotalItemsSold = new System.Windows.Forms.TextBox();
            this.tbxItemsSold = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxRevenueFromItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRevenueDate = new System.Windows.Forms.TextBox();
            this.tbxItemsSoldDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxSalesDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(713, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvSales
            // 
            this.lvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSaleID,
            this.colSaleDate,
            this.colSellerID,
            this.colSellerName,
            this.colProductID,
            this.colProductName,
            this.colAmountSold});
            this.lvSales.FullRowSelect = true;
            this.lvSales.GridLines = true;
            this.lvSales.HideSelection = false;
            this.lvSales.Location = new System.Drawing.Point(12, 70);
            this.lvSales.Name = "lvSales";
            this.lvSales.Size = new System.Drawing.Size(776, 228);
            this.lvSales.TabIndex = 1;
            this.lvSales.UseCompatibleStateImageBehavior = false;
            this.lvSales.View = System.Windows.Forms.View.Details;
            this.lvSales.SelectedIndexChanged += new System.EventHandler(this.lvSales_SelectedIndexChanged);
            // 
            // colSaleID
            // 
            this.colSaleID.Text = "SaleID";
            // 
            // colSaleDate
            // 
            this.colSaleDate.Text = "Sale Date";
            this.colSaleDate.Width = 150;
            // 
            // colSellerID
            // 
            this.colSellerID.Text = "Seller ID";
            // 
            // colSellerName
            // 
            this.colSellerName.Text = "Seller name";
            this.colSellerName.Width = 150;
            // 
            // colProductID
            // 
            this.colProductID.Text = "Product ID";
            this.colProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colProductID.Width = 70;
            // 
            // colProductName
            // 
            this.colProductName.Text = "Product Name";
            this.colProductName.Width = 200;
            // 
            // colAmountSold
            // 
            this.colAmountSold.Text = "Amount sold";
            this.colAmountSold.Width = 80;
            // 
            // cbxSort
            // 
            this.cbxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Location = new System.Drawing.Point(12, 41);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(147, 23);
            this.cbxSort.TabIndex = 2;
            this.cbxSort.SelectedIndexChanged += new System.EventHandler(this.cbxSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Global";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(579, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected item";
            // 
            // tbxTotalSales
            // 
            this.tbxTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTotalSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxTotalSales.Location = new System.Drawing.Point(134, 71);
            this.tbxTotalSales.Name = "tbxTotalSales";
            this.tbxTotalSales.ReadOnly = true;
            this.tbxTotalSales.Size = new System.Drawing.Size(54, 16);
            this.tbxTotalSales.TabIndex = 5;
            this.tbxTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total revenue";
            // 
            // tbxTotalRevenue
            // 
            this.tbxTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxTotalRevenue.Location = new System.Drawing.Point(134, 128);
            this.tbxTotalRevenue.Name = "tbxTotalRevenue";
            this.tbxTotalRevenue.ReadOnly = true;
            this.tbxTotalRevenue.Size = new System.Drawing.Size(54, 16);
            this.tbxTotalRevenue.TabIndex = 5;
            this.tbxTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Items sold";
            // 
            // tbxTotalItemsSold
            // 
            this.tbxTotalItemsSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxTotalItemsSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTotalItemsSold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxTotalItemsSold.Location = new System.Drawing.Point(134, 100);
            this.tbxTotalItemsSold.Name = "tbxTotalItemsSold";
            this.tbxTotalItemsSold.ReadOnly = true;
            this.tbxTotalItemsSold.Size = new System.Drawing.Size(54, 16);
            this.tbxTotalItemsSold.TabIndex = 5;
            this.tbxTotalItemsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxItemsSold
            // 
            this.tbxItemsSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxItemsSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxItemsSold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxItemsSold.Location = new System.Drawing.Point(644, 99);
            this.tbxItemsSold.Name = "tbxItemsSold";
            this.tbxItemsSold.ReadOnly = true;
            this.tbxItemsSold.Size = new System.Drawing.Size(54, 16);
            this.tbxItemsSold.TabIndex = 5;
            this.tbxItemsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Items sold";
            // 
            // tbxRevenueFromItem
            // 
            this.tbxRevenueFromItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxRevenueFromItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRevenueFromItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxRevenueFromItem.Location = new System.Drawing.Point(646, 127);
            this.tbxRevenueFromItem.Name = "tbxRevenueFromItem";
            this.tbxRevenueFromItem.ReadOnly = true;
            this.tbxRevenueFromItem.Size = new System.Drawing.Size(54, 16);
            this.tbxRevenueFromItem.TabIndex = 5;
            this.tbxRevenueFromItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Revenue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(322, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Selected date";
            // 
            // tbxRevenueDate
            // 
            this.tbxRevenueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxRevenueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRevenueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxRevenueDate.Location = new System.Drawing.Point(389, 128);
            this.tbxRevenueDate.Name = "tbxRevenueDate";
            this.tbxRevenueDate.ReadOnly = true;
            this.tbxRevenueDate.Size = new System.Drawing.Size(54, 16);
            this.tbxRevenueDate.TabIndex = 5;
            this.tbxRevenueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxItemsSoldDate
            // 
            this.tbxItemsSoldDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxItemsSoldDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxItemsSoldDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxItemsSoldDate.Location = new System.Drawing.Point(389, 100);
            this.tbxItemsSoldDate.Name = "tbxItemsSoldDate";
            this.tbxItemsSoldDate.ReadOnly = true;
            this.tbxItemsSoldDate.Size = new System.Drawing.Size(54, 16);
            this.tbxItemsSoldDate.TabIndex = 5;
            this.tbxItemsSoldDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Revenue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Items sold";
            // 
            // tbxSalesDate
            // 
            this.tbxSalesDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxSalesDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSalesDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSalesDate.Location = new System.Drawing.Point(389, 70);
            this.tbxSalesDate.Name = "tbxSalesDate";
            this.tbxSalesDate.ReadOnly = true;
            this.tbxSalesDate.Size = new System.Drawing.Size(54, 16);
            this.tbxSalesDate.TabIndex = 5;
            this.tbxSalesDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Sales";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(579, 71);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(44, 15);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "label13";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxTotalSales);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxTotalRevenue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxSalesDate);
            this.groupBox1.Controls.Add(this.tbxItemsSoldDate);
            this.groupBox1.Controls.Add(this.tbxRevenueFromItem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxTotalItemsSold);
            this.groupBox1.Controls.Add(this.tbxItemsSold);
            this.groupBox1.Controls.Add(this.tbxRevenueDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.lvSales);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View sales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvSales;
        private System.Windows.Forms.ColumnHeader colSaleID;
        private System.Windows.Forms.ColumnHeader colSaleDate;
        private System.Windows.Forms.ColumnHeader colSellerName;
        private System.Windows.Forms.ColumnHeader colProductID;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colAmountSold;
        private System.Windows.Forms.ColumnHeader colSellerID;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTotalSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTotalRevenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTotalItemsSold;
        private System.Windows.Forms.TextBox tbxItemsSold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRevenueFromItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxRevenueDate;
        private System.Windows.Forms.TextBox tbxItemsSoldDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxSalesDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}