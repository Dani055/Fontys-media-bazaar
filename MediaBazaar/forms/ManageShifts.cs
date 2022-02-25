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
        private Workday selectedWorkday;
        public ManageShifts(int empID)
        {
            InitializeComponent();
            emp = EmployeeService.GetEmployeeByID(empID);
        }

        private void ManageShifts_Load(object sender, EventArgs e)
        {
            

            lblEmpName.Text = $"{emp.FirstName} {emp.LastName}";
            DateTime dateTime = calShifts.SelectionRange.Start;
            RefreshListBox(dateTime);

        }

        private void RefreshListBox(DateTime dateTime) {


            string date = dateTime.ToString("yyyy-MM-dd");
            selectedWorkday = EmployeeService.GetEmployeeWorkday(emp, date);
            listBox1.Items.Clear();
            if (selectedWorkday == null) {

                listBox1.Items.Add("Nothing Scheduled for this date");

                return;
            }

            
            listBox1.Items.Add(selectedWorkday.Shifts);
        }

        private void calShifts_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dateTime = calShifts.SelectionRange.Start;
            RefreshListBox(dateTime);

        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            string shifts = "";
            if (cbMorning.Checked) {

                shifts += "morning#";

            }

            if (cbAfternoon.Checked) {

                shifts += "afternoon#";
            
            }

            if (cbEvening.Checked) {

                shifts += "evening#";

            }

            if (String.IsNullOrEmpty(shifts)) {

                
                MessageBox.Show("no shifts have been selected");
                return;

            }


            DateTime dateTime = calShifts.SelectionRange.Start;
            string date = dateTime.ToString("yyyy-MM-dd");
            Workday workday = EmployeeService.GetEmployeeWorkday(emp, date);

            if (workday != null) {

                MessageBox.Show("Shift already exists for current workday. consider removing it first");
                return;
            
            }

            workday = new Workday(emp.Id, date, shifts, false);

            if (EmployeeService.AddWorkday(workday))
            {

                MessageBox.Show("Successfuly added new schedule");
                RefreshListBox(dateTime);

            }

            else {

                MessageBox.Show("something went wrong");
                return;
            
            }

        }
    }
}
