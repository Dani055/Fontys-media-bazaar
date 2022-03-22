using MediaBazaar.logic;
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
            try
            {
                departments = DepartmentService.GetAllDepartments();
                cbxDepartment.DataSource = departments;
                cbxDepartment.DisplayMember = "Name";
                cbxDepartment.ValueMember = "Id";
                cbxDepartment.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }

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
            string departmentId = cbxDepartment.SelectedValue?.ToString() ?? "0";
            string role =  cbxRole.Text.ToString();
            string contractType = cbxContractType.Text.ToString();
            Employee employeeToAdd = new Employee(id, uname, pass, fName, lName, wage, address, departmentId, role, email, phone, contractType) {IsStudent = cbxStudent.Checked };

            try
            {
                if (EmployeeService.AddEmployee(employeeToAdd))
                {
                    Utils.ShowInfo("Employee added");
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }

        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cbxRole.Text.ToLower() == "department employee")
                cbxDepartment.Enabled = true;
             else
                cbxDepartment.Enabled = false;


            if (cbxRole.Text.ToLower().Contains("manager"))
                ChangeDepartment("Management");

            else if (cbxRole.Text.ToLower() == "cashier")
                ChangeDepartment("Sales");
            else if (cbxRole.Text.ToLower() == "warehouse worker")
                ChangeDepartment("Warehouse");
            else
                cbxDepartment.SelectedIndex = -1;
        }
        private void ChangeDepartment(string departmentToChange)
        {
            cbxDepartment.SelectedIndex = cbxDepartment.FindStringExact(departmentToChange);
        }
        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] restricted = {"Management", "Warehouse"};
            if (restricted.Contains(cbxDepartment.Text) && cbxRole.Text.ToLower() == "department employee")
                ChangeDepartment("Sales");
        }

        private void wageSlider_Scroll(object sender, EventArgs e)
        {
            numericHourWage.Value = wageSlider.Value;
        }
    }
}
