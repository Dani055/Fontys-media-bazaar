using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBazaarClassLibrary;
using MBazaarClassLibrary.services;
using MBazaarClassLibrary.models;

namespace MediaBazaar.forms
{
    public partial class Inventory : Form
    {
        public bool CanAccessControls = false;
        public Inventory()
        {
            InitializeComponent();
            RefreshProducts();           
            pnlTools.Visible = false;
            tbSearch.Select();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            lvProducts.Items[0].Selected = true;          
            string loggedEmpRole = DesktopUtils.loggedEmployee.Role.ToUpper();
            if (loggedEmpRole == "DEPOT MANAGER" || loggedEmpRole == "CEO")
            {
                CanAccessControls = true;              
                pnlTools.Visible = true;
            }
            else
            {
                CanAccessControls = false;
                pnlTools.Visible = false;
            }          
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
            try
            {
                List<Product> products = InventoryService.GetAllProducts();

                foreach (Product p in products)
                {
                    ListViewItem entry = new ListViewItem(p.GetDataArray());
                    entry.Tag = p;
                    lvProducts.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }



        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0) return;
            int selectedID = Convert.ToInt32(lvProducts.SelectedItems[0].SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this item from the system", "Confirm actions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (InventoryService.DeleteProduct(selectedID))
                    {
                        VisualHelper.ShowInfo("Product updated");
                    }
                    RefreshProducts();
                }
                catch (Exception ex)
                {
                   VisualHelper.ShowError(ex.Message);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {           

            if (lvProducts.SelectedItems.Count == 0)
            {
                pnlTools.Visible = false;                            
            }           

            if (lvProducts.SelectedItems.Count != 0 && DesktopUtils.loggedEmployee.Role.ToUpper() == "DEPARTMENT MANAGER")
            {
                btnSendRestockRequest.Enabled = true;
            }

            if (lvProducts.SelectedItems.Count > 0)
            {
                DesktopUtils.SetImage(lvProducts.SelectedItems[0].Tag as Product, pbxPic);

            }
            pnlTools.Visible = CanAccessControls;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;
            lvProducts.Items.Clear();
            try
            {
                List<Product> foundProducts = InventoryService.SearchProducts(searchStr);

                foreach (Product p in foundProducts)
                {
                    ListViewItem entry = new ListViewItem(p.GetDataArray());
                    entry.Tag = p;
                    lvProducts.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }
            tbSearch.Select();

            if (lvProducts.Items.Count == 1)
            {
                tbSearch.Text = string.Empty;
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProducts();
            tbSearch.Select();
            tbSearch.Text = string.Empty;
        }

        private void btnSendRestockRequest_Click(object sender, EventArgs e)
        {
            int amountToRestock = Convert.ToInt32(nmrRestockAmount.Value);
            if (amountToRestock == 0) 
            {
                VisualHelper.ShowError("Can't request amount of 0");
                return; 
            }

            int productIdToRestock = Convert.ToInt32(lvProducts.SelectedItems[0].SubItems[0].Text);
            try
            {
                if (InventoryService.CreateRestockRequest(productIdToRestock, amountToRestock))
                {
                    VisualHelper.ShowInfo("Successfully created restock request");
                }

            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {    
            EditItem editItem = new EditItem(lvProducts.SelectedItems[0].Tag as Product);
            editItem.ShowDialog();
        }

        private void Toggle_Hover(object sender, EventArgs e)
        {
            VisualHelper.PicButtonHoverEffect(sender as PictureBox);
        }

    }
}
