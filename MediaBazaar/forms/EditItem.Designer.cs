
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.nmrMinStock = new System.Windows.Forms.NumericUpDown();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPic = new System.Windows.Forms.PictureBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnRemovePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmitChanges.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitChanges.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitChanges.Location = new System.Drawing.Point(0, 347);
            this.btnSubmitChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(396, 40);
            this.btnSubmitChanges.TabIndex = 28;
            this.btnSubmitChanges.Text = "Submit changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = false;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // nmrMinStock
            // 
            this.nmrMinStock.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrMinStock.Location = new System.Drawing.Point(220, 79);
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
            this.nmrAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrAmount.Location = new System.Drawing.Point(220, 32);
            this.nmrAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(172, 23);
            this.nmrAmount.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(220, 105);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(220, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 15);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "Amount";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(10, 104);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 15);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "Department";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(10, 57);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(50, 15);
            this.lblEan.TabIndex = 21;
            this.lblEan.Text = "Barcode";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Product name";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(10, 125);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(172, 23);
            this.cbxDepartment.TabIndex = 19;
            // 
            // nmrPrice
            // 
            this.nmrPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrPrice.DecimalPlaces = 2;
            this.nmrPrice.Location = new System.Drawing.Point(220, 126);
            this.nmrPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(172, 23);
            this.nmrPrice.TabIndex = 18;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxBarcode.Location = new System.Drawing.Point(10, 78);
            this.tbxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(172, 23);
            this.tbxBarcode.TabIndex = 17;
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxProductName.Location = new System.Drawing.Point(10, 31);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(172, 23);
            this.tbxProductName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Amount before restock";
            // 
            // pbxPic
            // 
            this.pbxPic.BackColor = System.Drawing.SystemColors.Control;
            this.pbxPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPic.Location = new System.Drawing.Point(223, 166);
            this.pbxPic.Name = "pbxPic";
            this.pbxPic.Size = new System.Drawing.Size(167, 167);
            this.pbxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPic.TabIndex = 32;
            this.pbxPic.TabStop = false;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(10, 281);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(168, 23);
            this.btnChooseFile.TabIndex = 31;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(10, 263);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(44, 15);
            this.lblFile.TabIndex = 30;
            this.lblFile.Text = "Picture";
            // 
            // btnRemovePic
            // 
            this.btnRemovePic.Location = new System.Drawing.Point(12, 310);
            this.btnRemovePic.Name = "btnRemovePic";
            this.btnRemovePic.Size = new System.Drawing.Size(167, 23);
            this.btnRemovePic.TabIndex = 33;
            this.btnRemovePic.Text = "Remove picture";
            this.btnRemovePic.UseVisualStyleBackColor = true;
            this.btnRemovePic.Click += new System.EventHandler(this.btnRemovePic_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 387);
            this.Controls.Add(this.btnRemovePic);
            this.Controls.Add(this.pbxPic);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitChanges);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditItem";
            this.Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitChanges;
        private System.Windows.Forms.NumericUpDown nmrMinStock;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxPic;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnRemovePic;
    }
}