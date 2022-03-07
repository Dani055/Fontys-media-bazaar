
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
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.nmrMinStock = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(123, 20);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(168, 23);
            this.tbxProductName.TabIndex = 0;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(123, 56);
            this.tbxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(168, 23);
            this.tbxBarcode.TabIndex = 1;
            // 
            // nmrPrice
            // 
            this.nmrPrice.DecimalPlaces = 2;
            this.nmrPrice.Location = new System.Drawing.Point(123, 202);
            this.nmrPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(88, 23);
            this.nmrPrice.TabIndex = 5;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(123, 94);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(168, 23);
            this.cbxDepartment.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Product name";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(62, 56);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(50, 15);
            this.lblEan.TabIndex = 8;
            this.lblEan.Text = "Barcode";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(40, 94);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 15);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(64, 124);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 15);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Amount";
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Location = new System.Drawing.Point(27, 154);
            this.lblMinAmount.MaximumSize = new System.Drawing.Size(105, 0);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(82, 30);
            this.lblMinAmount.TabIndex = 11;
            this.lblMinAmount.Text = "Min. amount before restock";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(82, 203);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(123, 124);
            this.nmrAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(167, 23);
            this.nmrAmount.TabIndex = 13;
            // 
            // nmrMinStock
            // 
            this.nmrMinStock.Location = new System.Drawing.Point(123, 164);
            this.nmrMinStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrMinStock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrMinStock.Name = "nmrMinStock";
            this.nmrMinStock.Size = new System.Drawing.Size(167, 23);
            this.nmrMinStock.TabIndex = 14;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(142, 238);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(115, 40);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "Add item to inventory";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 302);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.nmrMinStock);
            this.Controls.Add(this.nmrAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMinAmount);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEan);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.nmrPrice);
            this.Controls.Add(this.tbxBarcode);
            this.Controls.Add(this.tbxProductName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddItem";
            this.Text = "AddItem";
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
        private System.Windows.Forms.Label lblMinAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.NumericUpDown nmrMinStock;
        private System.Windows.Forms.Button btnAddItem;
    }
}