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

            Product newProduct;
            try
            {
                prodName = !string.IsNullOrEmpty(tbxProductName.Text) ? tbxProductName.Text : null;
                prodEAN = !string.IsNullOrEmpty(tbxBarcode.Text) ? tbxBarcode.Text : null;
                deptID = Convert.ToInt32(cbxDepartment.SelectedValue);
                amountInStock = Convert.ToInt32(nmrAmount.Value);
                minStock = Convert.ToInt32(nmrMinStock.Value);
                price = Convert.ToDouble(nmrPrice.Value);

                newProduct = new Product(prodName, prodEAN, deptID, amountInStock, minStock, price);
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
    }
}
