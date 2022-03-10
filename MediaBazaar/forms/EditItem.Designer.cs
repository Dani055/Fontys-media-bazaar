
namespace MediaBazaar.forms
{
    partial class EditItem
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
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.nmrMinStock = new System.Windows.Forms.NumericUpDown();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Location = new System.Drawing.Point(95, 247);
            this.btnSubmitChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(115, 40);
            this.btnSubmitChanges.TabIndex = 28;
            this.btnSubmitChanges.Text = "Submit changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // nmrMinStock
            // 
            this.nmrMinStock.Location = new System.Drawing.Point(122, 163);
            this.nmrMinStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrMinStock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrMinStock.Name = "nmrMinStock";
            this.nmrMinStock.Size = new System.Drawing.Size(170, 23);
            this.nmrMinStock.TabIndex = 27;
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(122, 131);
            this.nmrAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(170, 23);
            this.nmrAmount.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(77, 206);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Location = new System.Drawing.Point(28, 163);
            this.lblMinAmount.MaximumSize = new System.Drawing.Size(105, 0);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(82, 30);
            this.lblMinAmount.TabIndex = 24;
            this.lblMinAmount.Text = "Min. amount before restock";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(65, 133);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 15);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "Amount";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(41, 103);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 15);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "Department";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(63, 65);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(50, 15);
            this.lblEan.TabIndex = 21;
            this.lblEan.Text = "Barcode";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Product name";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(123, 100);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(168, 23);
            this.cbxDepartment.TabIndex = 19;
            // 
            // nmrPrice
            // 
            this.nmrPrice.DecimalPlaces = 2;
            this.nmrPrice.Location = new System.Drawing.Point(122, 204);
            this.nmrPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(88, 23);
            this.nmrPrice.TabIndex = 18;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(124, 65);
            this.tbxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(168, 23);
            this.tbxBarcode.TabIndex = 17;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(124, 29);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(168, 23);
            this.tbxProductName.TabIndex = 16;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 325);
            this.Controls.Add(this.btnSubmitChanges);
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
            this.Name = "EditItem";
            this.Text = "EditItem";
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitChanges;
        private System.Windows.Forms.NumericUpDown nmrMinStock;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMinAmount;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.TextBox tbxProductName;
    }
}