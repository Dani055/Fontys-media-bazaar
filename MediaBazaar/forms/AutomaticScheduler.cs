using MBazaarClassLibrary;
using MBazaarClassLibrary.data_access;
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
    public partial class AutomaticScheduler : Form
    {
        private Tuple<DateTime, DateTime> nextWeekInterval;

        private Dictionary<int, List<Employee>> managerEmployeesByDepartment;


        private Dictionary<int, List<Employee>> employeesByDepartment;

        private Dictionary<int, List<Employee>> studentEmployeesByDepartment;

        private static Random rng = new Random(); // for shuffling the list of employees

        public AutomaticScheduler()
        {
            InitializeComponent();
            nextWeekInterval = Utils.GetNextWeekIntervals();
            lblDates.Text = $"{nextWeekInterval.Item1.Date} - {nextWeekInterval.Item2.Date}";
            studentEmployeesByDepartment = new();
            employeesByDepartment = new();
            managerEmployeesByDepartment = new();
        }

        

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            FillEmployeeDictionaries();
            if (!DataAccessWorkday.DeleteWorkdaysInTimeInterval(nextWeekInterval))
            {
                VisualHelper.ShowError("Could not delete Workdays. Check connection to the database");
                return;
            }

            List<Workday> workdays = new List<Workday>();
            AutoScheduler autoScheduler = new AutoScheduler(nextWeekInterval, employeesByDepartment, studentEmployeesByDepartment);


            workdays.AddRange(autoScheduler.AppendStudentWorkdays());

            workdays = autoScheduler.AppendNormalEmployees(workdays);

            

            List<Employee> employees = EmployeeService.GetEmployees(DesktopUtils.loggedEmployee);
            foreach (Workday workday in workdays)
            {
                Employee emp = null;
                foreach (Employee employee in employees)
                {
                    if (employee.Id == workday.EmpID)
                    {
                        emp = employee;
                        break;
                    }
                }

                WorkdayService.AddWorkday(emp, workday, DesktopUtils.loggedEmployee);

            }


        }

        private void FillEmployeeDictionaries()
        {
            List<Employee> employees = EmployeeService.GetEmployees(DesktopUtils.loggedEmployee);

            //lambda expression that shuffles the main list
            List<Employee> shuffledEmps = employees.OrderBy(a => rng.Next()).ToList();
            
            foreach (Employee employee in shuffledEmps)
            {
                if (employee.ContractType.Contains("Permanent"))
                {
                    
                    if (employee.Role.ToLower().Contains("manager")) 
                    {

                        if (managerEmployeesByDepartment.ContainsKey(employee.DepartmentId))
                        {
                            managerEmployeesByDepartment[employee.DepartmentId].Add(employee);
                        }
                        else
                        {
                            managerEmployeesByDepartment.Add(employee.DepartmentId, new List<Employee> { employee });
                        }

                        continue;
                    }


                    if (employee.IsStudent)
                    {
                        if (studentEmployeesByDepartment.ContainsKey(employee.DepartmentId))
                        {
                            studentEmployeesByDepartment[employee.DepartmentId].Add(employee);
                        }
                        else
                        {
                            studentEmployeesByDepartment.Add(employee.DepartmentId, new List<Employee> { employee });
                        }

                    }
                    else
                    {
                        if (employeesByDepartment.ContainsKey(employee.DepartmentId))
                        {
                            employeesByDepartment[employee.DepartmentId].Add(employee);
                        }
                        else
                        {
                            employeesByDepartment.Add(employee.DepartmentId, new List<Employee> { employee });
                        }

                    }

                }
            }
        }
    }
}
