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
    public partial class ManageShifts : Form
    {

        private Employee emp;
        private Workday selectedWorkday;
        public ManageShifts(int empID)
        {
            InitializeComponent();
            try
            {
                emp = EmployeeService.GetEmployeeByID(empID);
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }
        }

        private void ManageShifts_Load(object sender, EventArgs e)
        {
            lblEmpName.Text = $"{emp.FirstName} {emp.LastName}";
            DateTime dateTime = calShifts.SelectionRange.Start;
            RefreshListBox(dateTime);
        }

        private void RefreshListBox(DateTime dateTime) 
        {

            string date = dateTime.ToString(Utils.DbDateFormat);
            string prevDate = dateTime.AddDays(-1).ToString(Utils.DbDateFormat);
            try
            {
                selectedWorkday = WorkdayService.GetEmployeeWorkday(emp, date);

                Workday prevWorkday = WorkdayService.GetEmployeeWorkday(emp, prevDate);

                if (prevWorkday != null)
                {
                    if (prevWorkday.Shifts.IndexOf("evening") != -1)
                    {
                        cbMorning.Enabled = false;
                    }
                    else
                    {
                        cbMorning.Enabled = true;
                    }
                }
                else
                {
                    cbMorning.Enabled = true;
                }
                listBox1.Items.Clear();
                if (selectedWorkday == null)
                {

                    listBox1.Items.Add("Nothing Scheduled for this date");

                    return;
                }

                listBox1.Items.Add("Assigned shifts:");
                List<string> shifts = selectedWorkday.Shifts.Split("#").ToList();
                foreach (string s in shifts)
                {
                    listBox1.Items.Add(s);
                }

            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }
            
            
        }

        private void calShifts_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dateTime = calShifts.SelectionRange.Start;
            cbMorning.Checked = false;
            cbAfternoon.Checked = false;
            cbEvening.Checked = false;
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
            shifts = shifts.Trim('#');
            if (String.IsNullOrEmpty(shifts)) {

                
                MessageBox.Show("no shifts have been selected");
                return;

            }


            DateTime dateTime = calShifts.SelectionRange.Start;
            string date = dateTime.ToString(Utils.DbDateFormat);
            
            Workday workday = new Workday(emp.Id, date, shifts, false);
            try
            {
                if (WorkdayService.AddWorkday(emp, workday))
                {
                    Utils.ShowInfo("Shift added");
                    RefreshListBox(dateTime);
                    cbMorning.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }
            

        }

        private void btnRemoveShift_Click(object sender, EventArgs e)
        {
            if (selectedWorkday == null)
            {
                Utils.ShowError("No workday to delete!");
                return;
            }
            try
            {
                if (WorkdayService.DeleteWorkday(selectedWorkday))
                {
                    Utils.ShowInfo("Workday deleted");
                }

            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }

            DateTime dateTime = calShifts.SelectionRange.Start;
            RefreshListBox(dateTime);
            cbMorning.Enabled = true;
        }

        private void cbMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMorning.Checked)
            {
                cbEvening.Checked = false;
                cbEvening.Enabled = false;
            }
            else
            {
                cbEvening.Checked = false;
                cbEvening.Enabled = true;
            }
        }

        private void cbEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvening.Checked)
            {
                cbMorning.Checked = false;
                cbMorning.Enabled = false;
            }
            else
            {
                cbMorning.Checked = false;
                cbMorning.Enabled = true;
            }
        }
    }
}
