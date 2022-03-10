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
using MediaBazaar.logic;
using MediaBazaar.logic.models;
using MediaBazaar.logic.services;

namespace MediaBazaar.forms
{
    public partial class EditItem : Form
    {
        private Product prod;
        private List<Department> departments;

        public EditItem(int productId)
        {
            InitializeComponent();
            departments = DepartmentService.GetAllDepartments();
            prod = InventoryService.GetProductByID(productId);
            cbxDepartment.DataSource = departments;
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.ValueMember = "Id";

            PopulateInputs();

        }

        private void PopulateInputs()
        {
            tbxProductName.Text = prod.ProductName;
            tbxBarcode.Text = prod.ProductEAN;
            for (int i=0; i<departments.Count; i++)
            {
                if (departments[i].Id == prod.DepartmentID)
                {
                    cbxDepartment.SelectedIndex = i;
                }
            }
            nmrAmount.Value = prod.AmountInStock;
            nmrMinStock.Value = prod.MinStock;
            nmrPrice.Value = (decimal)prod.Price;
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            int prodID = prod.ProductID;
            string prodName;
            string prodEAN;
            int deptID;
            int amountInStock;
            int minStock;
            double price;

            Product editProduct;
            try
            {
                prodName = !string.IsNullOrEmpty(tbxProductName.Text) ? tbxProductName.Text : null;
                prodEAN = !string.IsNullOrEmpty(tbxBarcode.Text) ? tbxBarcode.Text : null;
                deptID = Convert.ToInt32(cbxDepartment.SelectedValue);
                amountInStock = Convert.ToInt32(nmrAmount.Value);
                minStock = Convert.ToInt32(nmrMinStock.Value);
                price = Convert.ToDouble(nmrPrice.Value);

                editProduct = new Product(prodID, prodName, prodEAN, deptID, amountInStock, minStock, price);
                InventoryService.EditProduct(editProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
