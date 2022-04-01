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
using MBazaarClassLibrary;
using MBazaarClassLibrary.services;
using MBazaarClassLibrary.models;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
            HideUI();
        }
        private void HideUI()
        {
            string loggedEmpRole = EmployeeService.loggedEmp.Role.ToUpper();
            if (loggedEmpRole == "EMPLOYEE MANAGER" || loggedEmpRole == "CEO")
            {
                pnlTools.Visible = true;
            }
            else
                pnlTools.Visible = false;
        }
        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            RefreshEmployees();
        }

        private void RefreshEmployees()
        {
            try
            {
                List<Employee> emps = EmployeeService.GetEmployees();
                PopulateListView(emps);
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }

        }
        private void PopulateListView(List<Employee> emps)
        {
            lvEmps.Items.Clear();
            foreach (Employee emp in emps)
            {
                string depName = DepartmentService.GetDepartmentByID(emp.DepartmentId)?.Name;
                depName ??= String.Empty;
                string[] row = { emp.Id.ToString(), emp.Username, emp.Password, emp.Role, emp.FirstName, emp.LastName, emp.HourlyWage.ToString(), emp.ContractType, depName, (emp.DepartmentId.ToString() == "-1" ? "" : emp.DepartmentId.ToString()), emp.Email, emp.Phone, emp.IsStudent.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = emp;
                item.UseItemStyleForSubItems = false;
                item.SubItems[12].BackColor = emp.IsStudent ? Color.Tomato : Color.LightGreen;

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

                VisualHelper.ShowError("Select employee first");
                return;

            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            addEmployee.Dispose();
            RefreshEmployees();
        }
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeService.RemoveEmployee((lvEmps.SelectedItems[0].Tag as Employee).Id))
                {
                    VisualHelper.ShowInfo("Employee removed");
                }
                RefreshEmployees();
            }
            catch (ArgumentOutOfRangeException)
            {
                VisualHelper.ShowError("Select employee first");
            }

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
                editEmployee.Dispose();
                RefreshEmployees();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                VisualHelper.ShowError("Select employee first");
                return;
            }

        }

        private void btnSearchEmps_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchEmps.Text.Trim();
            try
            {
                List<Employee> emps = EmployeeService.SearchEmployees(keyword);
                PopulateListView(emps);
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }
        }

        public void TogglePictureButtonSize(object sender, EventArgs e)
        {
            VisualHelper.PicButtonHoverEffect(sender as PictureBox);
        }
    }
}
