using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lblRole.Text = EmployeeService.loggedEmp.Username;
            lblUsername.Text = EmployeeService.loggedEmp.Role;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EmployeeService.loggedEmp = null;
            this.Dispose();
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            ManageEmployees frm = new ManageEmployees();
            frm.ShowDialog();
        }
    }
}
