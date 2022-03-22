using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBazaarClassLibrary.services;
using MBazaarClassLibrary.models;
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

            try
            {
                if (EmployeeService.Login(username, password))
                {
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                logic.VisualHelper.ShowError(ex.Message);
            }
            
        }

        private void home_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
