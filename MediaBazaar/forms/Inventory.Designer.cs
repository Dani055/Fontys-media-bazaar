﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.lvProducts = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colEan = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.colStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSendRestockRequest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrRestockAmount = new System.Windows.Forms.NumericUpDown();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRestockAmount)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lvProducts.Location = new System.Drawing.Point(14, 57);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(889, 357);
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
            this.tbSearch.Location = new System.Drawing.Point(14, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(195, 27);
            this.tbSearch.TabIndex = 3;
            // 
            // btnSendRestockRequest
            // 
            this.btnSendRestockRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRestockRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnSendRestockRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendRestockRequest.FlatAppearance.BorderSize = 0;
            this.btnSendRestockRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnSendRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRestockRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendRestockRequest.ForeColor = System.Drawing.Color.Indigo;
            this.btnSendRestockRequest.Location = new System.Drawing.Point(744, 11);
            this.btnSendRestockRequest.Name = "btnSendRestockRequest";
            this.btnSendRestockRequest.Size = new System.Drawing.Size(169, 76);
            this.btnSendRestockRequest.TabIndex = 8;
            this.btnSendRestockRequest.Text = "Send Restock Request";
            this.btnSendRestockRequest.UseVisualStyleBackColor = false;
            this.btnSendRestockRequest.Click += new System.EventHandler(this.btnSendRestockRequest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(216, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "🔍Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(818, 20);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 31);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(585, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount to restock";
            // 
            // nmrRestockAmount
            // 
            this.nmrRestockAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrRestockAmount.Location = new System.Drawing.Point(585, 46);
            this.nmrRestockAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrRestockAmount.Name = "nmrRestockAmount";
            this.nmrRestockAmount.Size = new System.Drawing.Size(143, 27);
            this.nmrRestockAmount.TabIndex = 13;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Wheat;
            this.pnlControls.Controls.Add(this.pbxRemove);
            this.pnlControls.Controls.Add(this.pbxEdit);
            this.pnlControls.Controls.Add(this.pbxAdd);
            this.pnlControls.Location = new System.Drawing.Point(14, 11);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(378, 76);
            this.pnlControls.TabIndex = 16;
            // 
            // pbxRemove
            // 
            this.pbxRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbxRemove.Image")));
            this.pbxRemove.Location = new System.Drawing.Point(306, 9);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(60, 60);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRemove.TabIndex = 18;
            this.pbxRemove.TabStop = false;
            this.pbxRemove.Click += new System.EventHandler(this.btnRemoveItem_Click);
            this.pbxRemove.MouseEnter += new System.EventHandler(this.Toggle_Hover);
            this.pbxRemove.MouseLeave += new System.EventHandler(this.Toggle_Hover);
            // 
            // pbxEdit
            // 
            this.pbxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbxEdit.Image")));
            this.pbxEdit.Location = new System.Drawing.Point(153, 9);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(60, 60);
            this.pbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEdit.TabIndex = 18;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.btnEditItem_Click);
            this.pbxEdit.MouseEnter += new System.EventHandler(this.Toggle_Hover);
            this.pbxEdit.MouseLeave += new System.EventHandler(this.Toggle_Hover);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(11, 9);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(60, 60);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 17;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.btnAddItem_Click);
            this.pbxAdd.MouseEnter += new System.EventHandler(this.Toggle_Hover);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.Toggle_Hover);
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.pnlControls);
            this.pnlTools.Controls.Add(this.nmrRestockAmount);
            this.pnlTools.Controls.Add(this.label1);
            this.pnlTools.Controls.Add(this.btnSendRestockRequest);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTools.Location = new System.Drawing.Point(0, 433);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(920, 98);
            this.pnlTools.TabIndex = 17;
            // 
            // Inventory
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 531);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lvProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(938, 578);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrRestockAmount)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
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
        private System.Windows.Forms.Button btnSendRestockRequest;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrRestockAmount;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.Panel pnlTools;
    }
}