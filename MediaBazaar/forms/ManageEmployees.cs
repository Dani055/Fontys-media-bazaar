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
using MediaBazaar.logic.models;
using MediaBazaar.logic.services;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            List<Employee> emps = EmployeeService.GetEmployees();
            foreach (Employee emp in emps)
            {
                string[] row = { emp.Id.ToString(), emp.Username, emp.Password, emp.Role, emp.FirstName, emp.LastName, emp.HourlyWage.ToString(), emp.DepartmentId, emp.Email, emp.Phone };
                ListViewItem item = new ListViewItem(row);
                lvEmps.Items.Add(item);
            }
            SetListViewColumnSizes(lvEmps, -2);
        }
        private void SetListViewColumnSizes(ListView lvw, int width)
        {
            foreach (ColumnHeader col in lvw.Columns)
                col.Width = width;
        }

        private void btnManageShifts_Click(object sender, EventArgs e)
        {

            try
            {

                ManageShifts manageShifts = new ManageShifts(Convert.ToInt16(lvEmps.SelectedItems[0].Text));
                manageShifts.ShowDialog();
            }

            catch (ArgumentOutOfRangeException) {

                MessageBox.Show("No employee has been selected");
                return;

            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }

        private void btnViewShifts_Click(object sender, EventArgs e)
        {
            AllShifts allShifts = new AllShifts();
            allShifts.ShowDialog();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {

                EditEmployee editEmployee = new EditEmployee(Convert.ToInt16(lvEmps.SelectedItems[0].Text));
                editEmployee.ShowDialog();
            }

            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("No employee has been selected");
                return;

            }

        }
    }
}
