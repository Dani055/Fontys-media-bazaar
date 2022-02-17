using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool result = EmployeeService.Login(username, password);
            if (result)
            {
                Home home = new Home();
                /*home.Closed += new EventHandler(home_Closed);*/
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
        }

        private void home_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
