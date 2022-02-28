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
    public partial class EditEmployee : Form
    {
        private Employee emp;
        public EditEmployee(int empID)
        {
            InitializeComponent();
            emp = EmployeeService.GetEmployeeByID(empID);
            FillData();
        }
        private void FillData()
        {
            if (emp == null)
                return;

            tbxUsername.Text = emp.Username;
            tbxPassword.Text = emp.Password;
            tbxFirstName.Text = emp.FirstName;
            tbxLastName.Text = emp.LastName;
            tbxAddress.Text = emp.Address;
            numericWage.Value = (decimal)emp.HourlyWage;
            tbxEmail.Text = emp.Email ?? String.Empty;
            tbxPhone.Text = emp.Phone ?? String.Empty;
            cbxDepartment.SelectedIndex = cbxDepartment.Items.IndexOf("Unassigned"); //* Somehow to get department name out of id cuz I don't want to make a request to DB only for that.
            cbxRole.SelectedIndex = cbxRole.Items.IndexOf(emp.Role);
            cbxContract.SelectedIndex = cbxContract.Items.IndexOf(emp.ContractType ?? "Unassigned");
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string uname = tbxUsername.Text;
            string pass = tbxPassword.Text;
            string fName = tbxFirstName.Text;
            string lName = tbxLastName.Text;
            double wage = (double)numericWage.Value;
            string address = tbxAddress.Text == string.Empty ? null : tbxAddress.Text;
            string email = tbxEmail.Text == string.Empty ? null : tbxEmail.Text;
            string phone = tbxPhone.Text == string.Empty ? null : tbxPhone.Text;
            string departmentId = "0"; //* cbxDeparment.SelectedValue.ToString();
            string role = cbxRole.Text.ToString();
            string contractType = cbxContract.Text.ToString();
            Employee newEmp = new Employee(emp.Id, uname, pass, fName, lName, wage, address, departmentId, role, email, phone, contractType);
            EmployeeService.UpdateEmployee(newEmp);
        }
    }
}
