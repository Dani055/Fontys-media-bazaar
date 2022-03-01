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
        private List<Department> departments;
        public AddEmployee()
        {
            InitializeComponent();
            cbxRole.SelectedIndex = 0;
            cbxContractType.SelectedIndex = 0;
            departments = DepartmentService.GetAllDepartments();
            cbxDepartment.DataSource = departments;
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.ValueMember = "Id";
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
            string email = tbxEmail.Text == string.Empty ? null : tbxEmail.Text;
            string phone = tbxPhone.Text == string.Empty ? null : tbxPhone.Text;
            string departmentId = cbxDepartment.SelectedValue.ToString();
            string role =  cbxRole.Text.ToString();
            string contractType = cbxContractType.Text.ToString();
            Employee employeeToAdd = new Employee(id, uname, pass, fName, lName, wage, address, departmentId, role, email, phone, contractType) {IsStudent = cbxStudent.Checked };           

            EmployeeService.AddEmployee(employeeToAdd);
        }
    }
}
