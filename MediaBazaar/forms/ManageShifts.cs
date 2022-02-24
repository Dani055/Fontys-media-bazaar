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
    public partial class ManageShifts : Form
    {

        private Employee emp;
        public ManageShifts(int empID)
        {
            InitializeComponent();
            emp = EmployeeService.GetEmployeeByID(empID);
        }

        private void ManageShifts_Load(object sender, EventArgs e)
        {
            

            lblEmpName.Text = $"{emp.FirstName} {emp.LastName}";

        }
    }
}
