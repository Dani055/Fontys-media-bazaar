using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.logic.models;
using MySql.Data.MySqlClient;

namespace MediaBazaar.logic.services
{
    public static class WorkdayService
    {

        public static Workday GetEmployeeWorkday(Employee emp, string date)
        {
            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            if (EmployeeService.loggedEmp.Role != "Employee Manager")
            {
                MessageBox.Show("You are not an Employee manager!");
                return null;
            }
            try
            {

                string sql = "SELECT * FROM Workday WHERE employeeId = @id AND day = @date";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", emp.Id);
                cmd.Parameters.AddWithValue("@date", date);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Read();
                    int id = reader.GetInt32("workdayId");
                    int empId = reader.GetInt32("employeeId");
                    string day = reader.GetString("day");
                    string shifts = reader.GetString("shifts");
                    bool missing = reader.GetBoolean("missing");

                    Workday workday = new Workday(id, empId, day, shifts, missing);
                    return workday;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static List<DetailedWorkday> GetWorkdays(string date)
        {
            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            if (EmployeeService.loggedEmp.Role != "Employee Manager" && EmployeeService.loggedEmp.Role != "Department Manager" && EmployeeService.loggedEmp.Role != "Depot Manager")
            {
                MessageBox.Show("You are not authorized!");
                return null;
            }
            try
            {

                string sql = "SELECT workdayId, employeeId, firstName, lastName, role, day, e.departmentId, departmentName ,shifts, missing FROM Workday as w " +
                    "inner join Employee as e " +
                    "on e.id = w.employeeId " +
                    "left join Department as d " +
                    "on e.departmentId = d.departmentId";

                if (EmployeeService.loggedEmp.Role != "Employee Manager")
                {
                    sql += " WHERE e.departmentId = @deptId AND day = @date"; 
                }
                else
                {
                    sql += " WHERE day = @date";
                }
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);
                if (EmployeeService.loggedEmp.Role != "Employee Manager")
                {
                    cmd.Parameters.AddWithValue("@deptId", EmployeeService.loggedEmp.DepartmentId);
                }

                List<DetailedWorkday> workdays = new List<DetailedWorkday>();
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("workdayId");
                        int empId = reader.GetInt32("employeeId");
                        string day = reader.GetString("day");
                        string shifts = reader.GetString("shifts");
                        bool missing = reader.GetBoolean("missing");
                        string firstName = reader.GetString("firstName");
                        string lastName = reader.GetString("lastName");
                        string role = reader["role"].ToString();
                        string departmentId = reader["departmentId"].ToString();
                        string departmentName = reader["departmentName"].ToString();

                        DetailedWorkday workday = new DetailedWorkday(id, empId, day, shifts, missing, firstName, lastName, role, departmentId, departmentName);
                        workdays.Add(workday);
                    }
                }
                else
                {
                    return null;
                }
                return workdays;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool AddWorkday(Employee emp, Workday workday)
        {
            if (EmployeeService.loggedEmp.Role != "Employee Manager")
            {
                MessageBox.Show("You are not an Employee manager!");
                return false;
            }
            Workday foundDay = WorkdayService.GetEmployeeWorkday(emp, workday.Date);

            if (foundDay != null)
            {
                MessageBox.Show("Shift already exists for current workday. Consider removing it first");
                return false;
            }
            if (StudentNotWorkingNightShift(emp, workday))
            {
                Utils.ShowError("This person is a student and can only work an evening shift!");
                return false;
            }
            if (WorkedEveningShiftPrevDay(emp, workday))
            {
                MessageBox.Show("You have selected morning shift and the previous day contains an evening shift!");
                return false;
            }
            if (OverworkingThisWeek(emp, workday))
            {
                MessageBox.Show("Worktime of employee this week becomes more than 40 hours!");
                return false;
            }

            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            try
            {

                string sql = "INSERT INTO Workday (employeeId, day, shifts, missing) VALUES (@employeeId, @day, @shifts, @missing)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@employeeId", workday.EmpID);
                cmd.Parameters.AddWithValue("@day", workday.Date);
                cmd.Parameters.AddWithValue("@shifts", workday.Shifts);
                cmd.Parameters.AddWithValue("@missing", workday.Missing);
                connection.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully added shift.");
                    return true;
                }
                return false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;

            }
        }
        public static bool MarkAttendance(string workdayId, bool missing)
        {
            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            if (EmployeeService.loggedEmp.Role != "Employee Manager" && EmployeeService.loggedEmp.Role != "Department Manager" && EmployeeService.loggedEmp.Role != "Depot Manager")
            {
                MessageBox.Show("You are not authorized!");
                return false;
            }
            if (workdayId == null)
            {
                MessageBox.Show("No workday selected!");
                return false;
            }
            try
            {
                string sql = "UPDATE Workday SET missing = @missing WHERE workdayId = @workdayId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@workdayId", workdayId);
                cmd.Parameters.AddWithValue("@missing", missing);
                connection.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Attendance marked successfully");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool DeleteWorkday(Workday workday)
        {
            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            if (EmployeeService.loggedEmp.Role != "Employee Manager")
            {
                MessageBox.Show("You are not an Employee manager!");
                return false;
            }
            try
            {
                string sql = "DELETE from Workday WHERE workdayId = @workdayId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@workdayId", workday.Id);
                connection.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Workday deleted successfully!");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool WorkedEveningShiftPrevDay(Employee emp, Workday workday)
        {
            DateTime prevDate = DateTime.Parse(workday.Date);
            prevDate = prevDate.AddDays(-1);
            Workday prevWorkday = GetEmployeeWorkday(emp, prevDate.ToString(Utils.DbDateFormat));

            if (workday.Shifts.IndexOf("morning") != -1)
            {
                if (prevWorkday != null && prevWorkday.Shifts.IndexOf("evening") != -1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool OverworkingThisWeek(Employee emp, Workday workdayToAdd)
        {
            DateTime currDate = DateTime.Parse(workdayToAdd.Date);
            DateTime startWeek;
            DateTime endWeek;

            if (currDate.DayOfWeek == DayOfWeek.Monday)
            {
                startWeek = currDate;
                endWeek = startWeek.AddDays(6);
            }
            else if (currDate.DayOfWeek == DayOfWeek.Tuesday)
            {
                startWeek = currDate.AddDays(-1);
                endWeek = startWeek.AddDays(6);
            }
            else if (currDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                startWeek = currDate.AddDays(-2);
                endWeek = startWeek.AddDays(6);
            }
            else if (currDate.DayOfWeek == DayOfWeek.Thursday)
            {
                startWeek = currDate.AddDays(-3);
                endWeek = startWeek.AddDays(6);
            }
            else if (currDate.DayOfWeek == DayOfWeek.Friday)
            {
                startWeek = currDate.AddDays(-4);
                endWeek = startWeek.AddDays(6);
            }
            else if (currDate.DayOfWeek == DayOfWeek.Saturday)
            {
                startWeek = currDate.AddDays(-5);
                endWeek = startWeek.AddDays(6);
            }
            else
            {
                startWeek = currDate.AddDays(-6);
                endWeek = currDate;
            }
            
            try
            {
                MySqlConnection conn = new MySqlConnection(Utils.connectionString);
                string sql = "Select * from Workday WHERE employeeId = @employeeId AND day BETWEEN @startDate and @endDate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employeeId", emp.Id);
                cmd.Parameters.AddWithValue("@startDate", startWeek.ToString(Utils.DbDateFormat));
                cmd.Parameters.AddWithValue("@endDate", endWeek.ToString(Utils.DbDateFormat));

                conn.Open();
                List<Workday> workdays = new List<Workday>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("workdayId");
                    int empId = reader.GetInt32("employeeId");
                    string day = reader.GetString("day");
                    string shifts = reader.GetString("shifts");
                    bool missing = reader.GetBoolean("missing");

                    Workday workday = new Workday(id, empId, day, shifts, missing);
                    workdays.Add(workday);
                }
                reader.Close();
                conn.Close();

                int totalHours = 0;
                int maxHours = 40;
                foreach (Workday wd in workdays)
                {
                    int shifts = wd.Shifts.Split("#").Count();
                    totalHours += shifts * 4;
                }
                if ((workdayToAdd.Shifts.Split("#").Count() * 4) + totalHours > maxHours)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return true;
            }

        }
        public static bool StudentNotWorkingNightShift(Employee emp, Workday workday)
        {
            if (emp.IsStudent && (workday.Shifts.Contains("morning") || workday.Shifts.Contains("afternoon")))
            {
                return true;
            }
            return false;
        }
    }
}
