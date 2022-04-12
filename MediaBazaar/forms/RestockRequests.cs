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
using MBazaarClassLibrary.services;
using MBazaarClassLibrary.models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaar.forms
{
    public partial class RestockRequests : Form
    {
        public RestockRequests()
        {
            InitializeComponent();
            RefreshRestockRequests();

            if (DesktopUtils.loggedEmployee.Role.ToUpper() == "DEPOT MANAGER" || DesktopUtils.loggedEmployee.Role.ToUpper() == "CEO")
            {
                btnAcceptRequest.Enabled = true;
                btnDenyRequest.Enabled = true;
            }
            else
            {
                btnAcceptRequest.Enabled = false;
                btnDenyRequest.Enabled = false;
            }
        }

        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            if (lvRestockRequests.SelectedItems.Count == 0) return;
            int selectedID = Convert.ToInt32(lvRestockRequests.SelectedItems[0].SubItems[0].Text);

            if (lvRestockRequests.SelectedItems[0].SubItems[2].Text != "Not processed yet")
            {
                VisualHelper.ShowError("Request has already been processed!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to accept this request? Product will be restocked with requested amount. A request can be processed only once.", "Confirm actions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    InventoryService.AcceptOrDenyRestockRequest(selectedID, true);

                    int amountToRestock = Convert.ToInt32(lvRestockRequests.SelectedItems[0].SubItems[7].Text);
                    int productIDToRestock = Convert.ToInt32(lvRestockRequests.SelectedItems[0].SubItems[3].Text);
                    InventoryService.RestockProduct(productIDToRestock, amountToRestock);
                    RefreshRestockRequests();

                    VisualHelper.ShowInfo("Request accepted successfully.");
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

        private void btnDenyRequest_Click(object sender, EventArgs e)
        {
            if (lvRestockRequests.SelectedItems.Count == 0) return;
            int selectedID = Convert.ToInt32(lvRestockRequests.SelectedItems[0].SubItems[0].Text);

            if (lvRestockRequests.SelectedItems[0].SubItems[2].Text != "Not processed yet")
            {
                VisualHelper.ShowError("Request has already been processed!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to deny this request? A request can be processed only once.", "Confirm actions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    InventoryService.AcceptOrDenyRestockRequest(selectedID, false);
                    RefreshRestockRequests();
                    VisualHelper.ShowInfo("Request denied successfully.");
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

        private void RefreshRestockRequests()
        {
            lvRestockRequests.Items.Clear();
            try
            {
                List<RestockRequest> rrs = InventoryService.GetRestockRequests();
                foreach (RestockRequest rr in rrs)
                {
                    string[] data = rr.GetDataArray();

                    ListViewItem entry = new ListViewItem(data);

                    if (data[8] == "Pending")
                    {
                        entry.SubItems[8].BackColor = Color.FromArgb(64, 245, 226, 39);
                    }
                    else if (data[8] == "Accepted")
                    {
                        entry.SubItems[8].BackColor = Color.FromArgb(64, 8, 255, 0);
                    }
                    else if (data[8] == "Denied")
                    {
                        entry.SubItems[8].BackColor = Color.FromArgb(64, 255, 0, 0);
                    }

                    entry.UseItemStyleForSubItems = false;

                    lvRestockRequests.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }
            

            
        }


    }
}
