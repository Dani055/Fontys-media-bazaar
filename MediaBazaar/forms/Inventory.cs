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
using MediaBazaar.logic.models;
using MediaBazaar.logic.services;
using MySql.Data.MySqlClient;

namespace MediaBazaar.forms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            RefreshProducts();
            btnRemoveItem.Enabled = false;
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
            if (lvProducts.SelectedItems.Count != 0)
            {
                btnRemoveItem.Enabled = true;
            } else
            {
                btnRemoveItem.Enabled = false;
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
    }
}
