using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
