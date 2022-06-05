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
            tbSearch.Select();
            chbxAutoAdd.Checked = true;
            autoAddToolTip.SetToolTip(chbxAutoAdd, "For scanner convenience: check if you want item to be automatically added to cart");
        }

        private void RefreshProducts()
        {
            lvAllItems.Items.Clear();
            try
            {
                List<Product> products = InventoryService.GetAllProducts();

                foreach (Product p in products)
                {
                    ListViewItem entry = new ListViewItem(p.GetDataArray());
                    entry.Tag = p;
                    lvAllItems.Items.Add(entry);
                }

            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = tbSearch.Text;
            lvAllItems.Items.Clear();

            try
            {
                List<Product> foundProducts = InventoryService.SearchProducts(searchStr);
                foreach (Product p in foundProducts)
                {
                    ListViewItem entry = new ListViewItem(p.GetDataArray());
                    lvAllItems.Items.Add(entry);
                }

                if (foundProducts.Count == 1 & chbxAutoAdd.Checked)
                {
                    lvAllItems.Items[0].Selected = true;
                    lvAllItems.Items[0].Focused = true;

                    AddToCart(1);
                    tbSearch.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProducts();
            tbSearch.Select();
            tbSearch.Text = string.Empty;
        }

        private void btnAddAmountToCart_Click(object sender, EventArgs e)
        {
            AddToCart(null);
        }

        private void AddToCart(int? quantity)
        {
            int amount = 0;

            if (quantity.HasValue)
            {
                amount = quantity.Value;
            } 
            else
            {
                if (nmrAddAmountToCart.Value == 0)
                {
                    return;
                } 
                else
                {
                    amount = (int)nmrAddAmountToCart.Value;
                }
            }

            if (lvAllItems.SelectedItems.Count == 0) { return; }

            string[] cartItemInfo =
            {
                lvAllItems.SelectedItems[0].SubItems[0].Text,
                lvAllItems.SelectedItems[0].SubItems[1].Text,
                amount.ToString(),
                (Convert.ToDouble(lvAllItems.SelectedItems[0].SubItems[6].Text)*amount).ToString()
            };

            ListViewItem cartItem = new ListViewItem(cartItemInfo);
            cartItem.Tag = lvAllItems.SelectedItems[0].Tag;
            lvCart.Items.Add(cartItem);

            CalculateTotal();
            tbSearch.Select();
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
            if (lvAllItems.SelectedItems.Count > 0)
            {
                btnAddAmountToCart.Enabled = true;

                DesktopUtils.SetImage(lvAllItems.SelectedItems[0].Tag as Product, pbxPic);          
            }
            else
            {
                btnAddAmountToCart.Enabled = false;
            }
        }

        private void btnSellCart_Click(object sender, EventArgs e)
        {
            if (lvCart.Items.Count == 0) { return; }
            int empID = DesktopUtils.loggedEmployee.Id;

            for (int i=0; i<lvCart.Items.Count; i++)
            {
                int productId = Convert.ToInt32(lvCart.Items[i].SubItems[0].Text);
                int amountToSell = Convert.ToInt32(lvCart.Items[i].SubItems[2].Text);
                try
                {
                    InventoryService.SellProduct(productId, amountToSell, empID);
                }
                catch (Exception ex)
                {
                    VisualHelper.ShowError(ex.Message);
                }
                
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
            if (lvCart.SelectedItems.Count > 0)
            {
                btnRemoveEntry.Enabled = true;
                DesktopUtils.SetImage(lvCart.SelectedItems[0].Tag as Product, pbxPic);
            }
            else
            {
                btnRemoveEntry.Enabled = false;
            }
        }
    }
}
