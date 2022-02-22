using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
