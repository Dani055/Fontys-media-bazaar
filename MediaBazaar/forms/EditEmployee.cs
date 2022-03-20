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
        private List<Department> departments;
        public EditEmployee(int empID)
        {
            InitializeComponent();
            emp = EmployeeService.GetEmployeeByID(empID);
            departments = DepartmentService.GetAllDepartments();
            cbxDepartment.DataSource = departments;
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.ValueMember = "Id";
            FillData();
            cbxRole_SelectedIndexChanged(new object { }, new EventArgs());
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

            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].Id == emp.DepartmentId)
                {
                    cbxDepartment.SelectedIndex = i;
                    break;
                }
            }

            cbxRole.SelectedIndex = cbxRole.Items.IndexOf(emp.Role);
            cbxContract.SelectedIndex = cbxContract.Items.IndexOf(emp.ContractType ?? "Unassigned");
            cbxStudent.Checked = emp.IsStudent;
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
            string departmentId = cbxDepartment.SelectedValue == null ? "" : cbxDepartment.SelectedValue.ToString();
            string role = cbxRole.Text.ToString();
            string contractType = cbxContract.Text.ToString();
            Employee newEmp = new Employee(emp.Id, uname, pass, fName, lName, wage, address, departmentId, role, email, phone, contractType) { IsStudent = cbxStudent.Checked };
            EmployeeService.UpdateEmployee(newEmp);
        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRole.Text.ToLower() == "department employee" || cbxRole.Text.ToLower() == "department manager")
            {
                cbxDepartment.Enabled = true;
            }

            else {
                cbxDepartment.Enabled = false;
            }



            if (cbxRole.Text.ToLower() == "employee manager" || cbxRole.Text.ToLower() == "ceo")
            {
                ChangeDepartment("Management");
            }

            else if (cbxRole.Text.ToLower() == "cashier")
            {
                ChangeDepartment("Sales");
            }
            else if (cbxRole.Text.ToLower() == "warehouse worker" || cbxRole.Text.ToLower() == "depot manager")
            {
                ChangeDepartment("Warehouse");
            }
            else if (cbxRole.Text.ToLower() == "unassigned")
            {
                cbxDepartment.SelectedIndex = -1;
            }

        }
        private void ChangeDepartment(string departmentToChange)
        {
            cbxDepartment.SelectedIndex = cbxDepartment.FindStringExact(departmentToChange);
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] restricted = { "Management", "Warehouse" };
            if (restricted.Contains(cbxDepartment.Text) && cbxRole.Text.ToLower() == "department employee")
                ChangeDepartment("Sales");
        }

        private void wageSlider_Scroll(object sender, EventArgs e)
        {
            numericWage.Value = wageSlider.Value;
        }
    }
}
