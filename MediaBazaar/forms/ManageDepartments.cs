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
    public partial class ManageDepartments : Form
    {
        public ManageDepartments()
        {
            InitializeComponent();
        }

        private void ManageDepartments_Load(object sender, EventArgs e)
        {
            RefreshDepartments();
        }

        private void RefreshDepartments()
        {
            lvDepartments.Items.Clear();
            foreach (var department in DepartmentService.AllDepartments)
            {
                string[] row = { department.Id.ToString(), department.Name };
                ListViewItem item = new ListViewItem(row);
                lvDepartments.Items.Add(item);
            }
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            try
            {

                EditDepartment editDepartment = new EditDepartment(Convert.ToInt16(lvDepartments.SelectedItems[0].Text));
                editDepartment.ShowDialog();
                RefreshDepartments();
            }

            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("No department has been selected");
                return;

            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            Department d = new Department(tbDepartmentName.Text);
            DepartmentService.CreateDepartment(d);
            RefreshDepartments();
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            int depid = -1;
            try
            {
                depid = Convert.ToInt32(lvDepartments.SelectedItems[0].Text);

                DialogResult dr = Utils.ShowConfirmation("Are you sure that you want to delete selected department?");
                if (dr == DialogResult.OK)
                {
                    DepartmentService.RemoveDepartment(depid);
                    RefreshDepartments();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Utils.ShowError("Please select department");
            }
        }
     
    }
}
