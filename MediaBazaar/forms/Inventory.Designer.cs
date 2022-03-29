
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
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRestockAmount)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
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
            this.lvProducts.Location = new System.Drawing.Point(14, 57);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(895, 357);
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
            this.btnSendRestockRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.btnSendRestockRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendRestockRequest.FlatAppearance.BorderSize = 0;
            this.btnSendRestockRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnSendRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRestockRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendRestockRequest.ForeColor = System.Drawing.Color.Indigo;
            this.btnSendRestockRequest.Location = new System.Drawing.Point(740, 440);
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
            this.btnRefresh.Location = new System.Drawing.Point(824, 20);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount to restock";
            // 
            // nmrRestockAmount
            // 
            this.nmrRestockAmount.Location = new System.Drawing.Point(578, 471);
            this.nmrRestockAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrRestockAmount.Name = "nmrRestockAmount";
            this.nmrRestockAmount.Size = new System.Drawing.Size(134, 27);
            this.nmrRestockAmount.TabIndex = 13;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlControls.Controls.Add(this.pbxRemove);
            this.pnlControls.Controls.Add(this.pbxEdit);
            this.pnlControls.Controls.Add(this.pbxAdd);
            this.pnlControls.Location = new System.Drawing.Point(14, 447);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(308, 76);
            this.pnlControls.TabIndex = 16;
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(14, 7);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(63, 65);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 17;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pbxEdit
            // 
            this.pbxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbxEdit.Image")));
            this.pbxEdit.Location = new System.Drawing.Point(123, 7);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(63, 65);
            this.pbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEdit.TabIndex = 18;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // pbxRemove
            // 
            this.pbxRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbxRemove.Image")));
            this.pbxRemove.Location = new System.Drawing.Point(225, 8);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(63, 65);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRemove.TabIndex = 18;
            this.pbxRemove.TabStop = false;
            this.pbxRemove.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Inventory
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 531);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.nmrRestockAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSendRestockRequest);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lvProducts);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.nmrRestockAmount)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
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
    }
}