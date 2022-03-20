
namespace MediaBazaar.forms
{
    partial class AddItem
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
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.nmrMinStock = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblBeforeRestock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxProductName.Location = new System.Drawing.Point(12, 37);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(191, 27);
            this.tbxProductName.TabIndex = 0;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxBarcode.Location = new System.Drawing.Point(12, 100);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(191, 27);
            this.tbxBarcode.TabIndex = 1;
            // 
            // nmrPrice
            // 
            this.nmrPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrPrice.DecimalPlaces = 2;
            this.nmrPrice.Location = new System.Drawing.Point(242, 164);
            this.nmrPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(191, 27);
            this.nmrPrice.TabIndex = 5;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(12, 163);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(191, 28);
            this.cbxDepartment.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Product name";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(12, 72);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(64, 20);
            this.lblEan.TabIndex = 8;
            this.lblEan.Text = "Barcode";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 135);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(89, 20);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(242, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 20);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Amount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(242, 136);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // nmrAmount
            // 
            this.nmrAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrAmount.Location = new System.Drawing.Point(242, 38);
            this.nmrAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(191, 27);
            this.nmrAmount.TabIndex = 13;
            // 
            // nmrMinStock
            // 
            this.nmrMinStock.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrMinStock.Location = new System.Drawing.Point(242, 101);
            this.nmrMinStock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrMinStock.Name = "nmrMinStock";
            this.nmrMinStock.Size = new System.Drawing.Size(191, 27);
            this.nmrMinStock.TabIndex = 14;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(0, 212);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(451, 53);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "Add item to inventory";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblBeforeRestock
            // 
            this.lblBeforeRestock.AutoSize = true;
            this.lblBeforeRestock.Location = new System.Drawing.Point(242, 73);
            this.lblBeforeRestock.Name = "lblBeforeRestock";
            this.lblBeforeRestock.Size = new System.Drawing.Size(161, 20);
            this.lblBeforeRestock.TabIndex = 16;
            this.lblBeforeRestock.Text = "Amount before restock";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 265);
            this.Controls.Add(this.lblBeforeRestock);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.nmrMinStock);
            this.Controls.Add(this.nmrAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEan);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.nmrPrice);
            this.Controls.Add(this.tbxBarcode);
            this.Controls.Add(this.tbxProductName);
            this.Name = "AddItem";
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.NumericUpDown nmrMinStock;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblBeforeRestock;
    }
}