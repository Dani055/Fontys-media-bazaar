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
using MediaBazaar.logic.services;

namespace MediaBazaar
{
    public partial class Home : Form
    {
        bool closedByButton = false;
        public Home()
        {
            InitializeComponent();
            lblRole.Text = EmployeeService.loggedEmp.Username;
            lblUsername.Text = EmployeeService.loggedEmp.Role;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EmployeeService.loggedEmp = null;
            closedByButton = true;
            this.Dispose();
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            ManageEmployees frm = new ManageEmployees();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closedByButton)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnManageDepartments_Click(object sender, EventArgs e)
        {

            
            ManageDepartments frm = new ManageDepartments();
            frm.ShowDialog();

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
        }

        private void btnRestockReq_Click(object sender, EventArgs e)
        {
            RestockRequests restockRequests = new RestockRequests();
            restockRequests.ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.ShowDialog();
        }
    }
}
