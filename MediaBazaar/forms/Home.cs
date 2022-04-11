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

namespace MediaBazaar
{
    public partial class Home : Form
    {
        bool closedByButton = false;
        public Home()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tmr.Start();
            lblRole.Text = EmployeeService.loggedEmp.Role;
            lblUsername.Text = $"Welcome, {EmployeeService.loggedEmp.Username}";

            string loggedEmpRole = EmployeeService.loggedEmp.Role.ToUpper();
            if (loggedEmpRole == "DEPOT MANAGER")
            {
                btnManageDepartments.Enabled = false;
            } else if (loggedEmpRole == "CASHIER")
            {
                btnManageEmp.Enabled = false;
                btnManageDepartments.Enabled = false;
                btnRestockReq.Enabled = false;
            } else if (loggedEmpRole == "EMPLOYEE MANAGER")
            {
                btnRestockReq.Enabled = false;
                btnSell.Enabled = false;
            } else if (loggedEmpRole == "DEPARTMENT MANAGER")
            {
                btnManageDepartments.Enabled = false;
                btnRestockReq.Enabled = false;
                btnSell.Enabled = false;
            } else if (loggedEmpRole == "DEPARTMENT EMPLOYEE")
            {
                btnManageEmp.Enabled = false;
                btnManageDepartments.Enabled = false;
                btnRestockReq.Enabled = false;
                btnSell.Enabled = false;
            } else if (loggedEmpRole == "WAREHOUSE WORKER")
            {
                btnManageEmp.Enabled = false;
                btnManageDepartments.Enabled = false;
                btnSell.Enabled = false;
            } else
            {
                btnManageEmp.Enabled = false;
                btnManageDepartments.Enabled = false;
                btnInventory.Enabled = false;
                btnRestockReq.Enabled = false;
                btnSell.Enabled = false;
            }

            if (loggedEmpRole == "CEO")
            {
                btnManageEmp.Enabled = true;
                btnManageDepartments.Enabled = true;
                btnInventory.Enabled = true;
                btnRestockReq.Enabled = true;
                btnSell.Enabled = true;
            }
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

        //Change color on disabled//
        private void ChangeButtonBGonDisabled(object sender, EventArgs e) 
        {
            (sender as Button).BackColor = (sender as Button).Enabled ? Color.FromArgb(255, 186, 8) : Color.FromArgb(181, 130, 0);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        
    }
}
