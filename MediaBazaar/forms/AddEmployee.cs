using MediaBazaar.logic.models;
using MediaBazaar.logic.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int id = EmployeeService.GetNewAvailableID();
            string uname = tbxUsername.Text;
            string pass = tbxPassword.Text;
            string fName = tbxFirstName.Text;
            string lName = tbxLastName.Text;
            double wage = (double)numericHourWage.Value;
            string address = tbxAddress.Text == string.Empty ? null : tbxAddress.Text;
            string departmentId = "0"; //* cbxDeparment.SelectedValue.ToString();
            string role =  cbxRole.SelectedText.ToString();
            string email = tbxEmail.Text == string.Empty ? null : tbxEmail.Text;
            string phone = tbxPhone.Text == string.Empty ? null : tbxPhone.Text;

            Employee employeeToAdd = new Employee(id, uname, pass, fName, lName, wage, address, departmentId, role, email, phone);
            EmployeeService.AddEmployee(employeeToAdd);
        }
    }
}
