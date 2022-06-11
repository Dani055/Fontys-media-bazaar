using MBazaarClassLibrary.models;
using MBazaarClassLibrary.services;
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
    public partial class EmployeesOverview : Form
    {
        private int previouslySortedBy;
        private bool toggled;

        private Employee[] permanentContractEmployees;
        private Employee[] allEmployees;
        public EmployeesOverview()
        {
            InitializeComponent();
        }

        private void EmployeesOverview_Load(object sender, EventArgs e)
        {
            //Get the employees we are going to work with.
            List<Employee> employeesRaw = EmployeeService.GetEmployees(DesktopUtils.loggedEmployee);

            allEmployees = employeesRaw.ToArray();

            employeesRaw.RemoveAll(e => e.ContractType != "Permanent");
            permanentContractEmployees = employeesRaw.ToArray();

            previouslySortedBy = -1;
            toggled = false;

            //Fill them in the ListView
            FillDataInListViewEmployees();
            FillBrakeDownEmployees();
        }
        private void FillDataInListViewEmployees(int sortByColumn = 0)
        {
            Employee[] sortedEmployees = SortEmployees(sortByColumn);
            lvEmployees.Items.Clear();
            foreach (var employee in sortedEmployees)
            {
                string[] data = { employee.FullName, employee.Role, employee.HourlyWage.ToString(), '€' + employee.MonthlyWage.ToString() }; 
                ListViewItem emp = new ListViewItem(data);
                emp.Tag = employee;
                lvEmployees.Items.Add(emp);
            }
            //Adjust the width
            foreach (ColumnHeader column in lvEmployees.Columns)
            {
                column.Width = -2;
            }
        }
        private void FillBrakeDownEmployees()
        {
            ListViewItem[] itemsCommon = {
                new ListViewItem(new string[] { "All employees", $"{this.allEmployees.Length}" }),
                new ListViewItem(new string[] { "Permanent contract", $"{this.permanentContractEmployees.Length}" }),
                new ListViewItem(new string[] { "0 Hour contract", $"{this.allEmployees.Count(e => e.ContractType == "0 Hour fixed")}"}),
                new ListViewItem(new string[] { "Students", $"{this.allEmployees.Where(e => e.IsStudent).ToArray().Length}"})
            };
            ListViewItem[] itemsRoles = {
                new ListViewItem(new string[] { "Employee Managers", $"{this.allEmployees.Count(e => e.Role == "Employee Manager")}"}),
                new ListViewItem(new string[] { "Department Managers", $"{this.allEmployees.Count(e => e.Role == "Department Manager")}"}),
                new ListViewItem(new string[] { "Department Employees", $"{this.allEmployees.Count(e => e.Role == "Department Employee")}"}),
                new ListViewItem(new string[] { "Cashiers", $"{this.allEmployees.Count(e => e.Role == "Cashier")}"}),
                new ListViewItem(new string[] { "Depot Managers", $"{this.allEmployees.Count(e => e.Role == "Depot Manager")}"}),
                new ListViewItem(new string[] { "Warehouse Employees", $"{this.allEmployees.Count(e => e.Role == "Warehouse Worker")}"})

            };
            foreach (ListViewItem item in itemsCommon)
            {
                lvEmpBrakedown.Items.Add(item);
            } 
            foreach (ListViewItem item in itemsRoles)
            {
                lvRoles.Items.Add(item);
            }
        }
        private Employee[] SortEmployees(int sortByColumn)
        {
            List<Employee> result = permanentContractEmployees.ToList();
            if (sortByColumn == 0) //Sort by name
            {
                result = result.OrderBy(e => e.FullName).ToList();
            }
            else if (sortByColumn == 1) //Sort by role
            {
                result = result.OrderBy(e => e.Role).ToList();
            }
            else if (sortByColumn == 2) //Sort by Hourly wage
            {
                result = result.OrderBy(e => e.HourlyWage).ToList();
            }
            else if (sortByColumn == 3) //Sort by total monthly wage
            {
                result = result.OrderBy(e => e.MonthlyWage).ToList();
            }

            if (sortByColumn == previouslySortedBy) //If we clicked the same column
            {
                toggled = !toggled;
            }
            else
            {
                toggled = false; //If we clicked other column, display result as default.

            }
            if (toggled == true)
            {
                result.Reverse();               
            }

            previouslySortedBy = sortByColumn;
            return result.ToArray();
        }
        private void lvEmployees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FillDataInListViewEmployees(e.Column);
        }
    }
}
