using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.forms;
using MBazaarClassLibrary;
using MBazaarClassLibrary.services;
using MBazaarClassLibrary.models;
using System.IO;

namespace MediaBazaar.forms
{
    public partial class AddItem : Form
    {
        private List<Department> departments;

        public AddItem()
        {
            InitializeComponent();
            try
            {
                departments = DepartmentService.GetAllDepartments();
                cbxDepartment.DataSource = departments;
                cbxDepartment.DisplayMember = "Name";
                cbxDepartment.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string prodName;
            string prodEAN;
            int deptID;
            int amountInStock;
            int minStock;
            double price;
            byte[] pic;

            Product newProduct;
            try
            {
                prodName = !string.IsNullOrEmpty(tbxProductName.Text) ? tbxProductName.Text : null;
                prodEAN = !string.IsNullOrEmpty(tbxBarcode.Text) ? tbxBarcode.Text : null;
                deptID = Convert.ToInt32(cbxDepartment.SelectedValue);
                amountInStock = Convert.ToInt32(nmrAmount.Value);
                minStock = Convert.ToInt32(nmrMinStock.Value);
                price = Convert.ToDouble(nmrPrice.Value);
                pic = pbxPic.Image == null ? null : ImageToByteArray(pbxPic.Image);

                newProduct = new Product(prodName, prodEAN, deptID, amountInStock, minStock, price, pic);
                try
                {
                    if (InventoryService.AddNewProduct(newProduct))
                    {
                        VisualHelper.ShowInfo("Product added");
                    }
                    
                }
                catch (Exception ex)
                {
                    VisualHelper.ShowError(ex.Message);
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdPicture = new OpenFileDialog();
                ofdPicture.InitialDirectory = @"C:\";
                ofdPicture.RestoreDirectory = true;
                ofdPicture.Title = "Choose a picture";
                ofdPicture.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp; *.png";

                Bitmap pic;
                if (ofdPicture.ShowDialog() == DialogResult.OK)
                {
                    long fileSize = new FileInfo(ofdPicture.FileName).Length;
                    if (fileSize > Utils.MaxPicSize)
                    {
                        VisualHelper.ShowError($"File exceeds {Utils.MaxPicSize / 1000}KB size limit.");
                        return;
                    }
                    pic = new Bitmap(ofdPicture.FileName);
                    pbxPic.Image = pic;

                }
            } catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }


        }

        private byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            pbxPic.Image = null;
        }
    }
}
