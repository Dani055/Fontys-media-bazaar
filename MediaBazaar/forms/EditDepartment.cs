using MBazaarClassLibrary;
using MBazaarClassLibrary.services;
using MBazaarClassLibrary.models;
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

    //on the edit forms i imagine we have an obj which represents the thing we wanna edit
    //and after edits are done we can use its specific service to update the data on the database
    public partial class EditDepartment : Form
    {

        Department department;
        public EditDepartment(int depID)
        {
            InitializeComponent();
            department = DepartmentService.GetDepartmentByID(depID);
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {           
            tbxNewName.Text = department.Name;
            chbxEssential.Checked = department.IsEssential;
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentService.UpdateDepartment(new Department(department.Id, tbxNewName.Text)))
                    this.Close();
            }
            catch (Exception ex)
            {
                VisualHelper.ShowError(ex.Message);
            }

        }
    }
}
