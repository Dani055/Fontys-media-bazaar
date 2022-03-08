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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
            RefreshProducts();
            btnAddAmountToCart.Enabled = false;
            btnRemoveEntry.Enabled = false;
            tbxTotal.Text = string.Empty;
        }

        private void RefreshProducts()
        {
            lvAllItems.Items.Clear();
            List<Product> products = InventoryService.GetAllProducts();

            foreach (Product p in products)
            {
                ListViewItem entry = new ListViewItem(p.GetDataArray());
                lvAllItems.Items.Add(entry);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;

            List<Product> foundProducts = InventoryService.SearchProducts(searchStr);


            lvAllItems.Items.Clear();

            foreach (Product p in foundProducts)
            {
                ListViewItem entry = new ListViewItem(p.GetDataArray());
                lvAllItems.Items.Add(entry);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void btnAddAmountToCart_Click(object sender, EventArgs e)
        {
            int amount = 0;

            if (nmrAddAmountToCart.Value == 0)
            {
                return;
            }

            amount = Convert.ToInt32(nmrAddAmountToCart.Value);

            string[] cartItemInfo =
            {
                lvAllItems.SelectedItems[0].SubItems[0].Text,
                lvAllItems.SelectedItems[0].SubItems[1].Text,
                amount.ToString(),
                (Convert.ToDouble(lvAllItems.SelectedItems[0].SubItems[6].Text)*amount).ToString()
            };

            ListViewItem cartItem = new ListViewItem(cartItemInfo);
            lvCart.Items.Add(cartItem);

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            double total = 0;

            for (int i = 0; i < lvCart.Items.Count; i++)
            {
                double pricePerEntry = Convert.ToDouble(lvCart.Items[i].SubItems[3].Text);
                total = total + pricePerEntry;
            }

            tbxTotal.Clear();
            tbxTotal.Text = total.ToString();
        }

        private void lvAllItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAllItems.SelectedItems.Count != 0)
            {
                btnAddAmountToCart.Enabled = true;
            }
            else
            {
                btnAddAmountToCart.Enabled = false;
            }
        }

        private void btnSellCart_Click(object sender, EventArgs e)
        {
            if (lvCart.Items.Count == 0) { return; }

            for (int i=0; i<lvCart.Items.Count; i++)
            {
                int productId = Convert.ToInt32(lvCart.Items[i].SubItems[0].Text);
                int amountToSell = Convert.ToInt32(lvCart.Items[i].SubItems[2].Text);

                InventoryService.SellProduct(productId, amountToSell);
            }

            lvCart.Items.Clear();
            tbxTotal.Clear();
            RefreshProducts();
        }

        private void btnResetCart_Click(object sender, EventArgs e)
        {
            lvCart.Items.Clear();
            tbxTotal.Clear();
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            lvCart.SelectedItems[0].Remove();
            CalculateTotal();
        }

        private void lvCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count != 0)
            {
                btnRemoveEntry.Enabled = true;
            }
            else
            {
                btnRemoveEntry.Enabled = false;
            }
        }
    }
}
