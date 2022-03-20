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
using MySql.Data.MySqlClient;

namespace MediaBazaar.forms
{
    public partial class Inventory : Form
    {
        public bool CanAccessControls = false;
        public Inventory()
        {
            InitializeComponent();
            RefreshProducts();
            pbxRemove.Enabled = false;
            btnSendRestockRequest.Enabled = false;
            pbxEdit.Enabled = false;

            string loggedEmpRole = EmployeeService.loggedEmp.Role.ToUpper();
            if (loggedEmpRole != "DEPOT MANAGER")
            {
                CanAccessControls = false;
                pbxAdd.Enabled = false;
            } else
            {
                CanAccessControls = true;
            }


            //lvProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
            RefreshProducts();
        }

        private void RefreshProducts()
        {
            lvProducts.Items.Clear();
            List<Product> products = InventoryService.GetAllProducts();

            foreach (Product p in products)
            {
                ListViewItem entry = new ListViewItem(p.GetDataArray());
                lvProducts.Items.Add(entry);
            }


        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0) return;
            int selectedID = Convert.ToInt32(lvProducts.SelectedItems[0].SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this item from the system", "Confirm actions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Yes)
            {
                InventoryService.DeleteProduct(selectedID);
                RefreshProducts();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count != 0 && CanAccessControls)
            {
                pbxRemove.Enabled = true;
                btnSendRestockRequest.Enabled = true;
                pbxEdit.Enabled = true;
            } else
            {
                pbxRemove.Enabled = false;
                btnSendRestockRequest.Enabled = false;
                pbxEdit.Enabled = false;
            }

            if (lvProducts.SelectedItems.Count != 0 && EmployeeService.loggedEmp.Role.ToUpper() == "DEPARTMENT MANAGER")
            {
                btnSendRestockRequest.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;

            List<Product> foundProducts = InventoryService.SearchProducts(searchStr);


            lvProducts.Items.Clear();

            foreach (Product p in foundProducts)
            {
                ListViewItem entry = new ListViewItem(p.GetDataArray());
                lvProducts.Items.Add(entry);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void btnSendRestockRequest_Click(object sender, EventArgs e)
        {
            int amountToRestock = Convert.ToInt32(nmrRestockAmount.Value);
            if (amountToRestock == 0) 
            {
                Utils.ShowError("Can't request amount of 0");
                return; 
            }

            int productIdToRestock = Convert.ToInt32(lvProducts.SelectedItems[0].SubItems[0].Text);
            InventoryService.CreateRestockRequest(productIdToRestock, amountToRestock);
            Utils.ShowInfo("Successfully created restock request");
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(lvProducts.SelectedItems[0].SubItems[0].Text);
            EditItem editItem = new EditItem(selectedID);
            editItem.ShowDialog();
        }

        private void Toggle_Hover(object sender, EventArgs e)
        {
            Utils.PicButtonHoverEffect(sender as PictureBox);
        }
    }
}
