using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBazaarClassLibrary.models;
using MySql.Data.MySqlClient;

namespace MBazaarClassLibrary.data_access
{
    public static class DataAccessWorkday
    {
        public static Workday GetEmpWorkdayQuery(Employee emp, string date)
        {
            MySqlConnection connection = new MySqlConnection(Utils.connectionString);
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
            finally
            {
                connection.Close();
            }
        }
        public static List<DetailedWorkday> GetAllWorkdaysQuery(string date)
        {
            MySqlConnection connection = new MySqlConnection(Utils.connectionString);

            try
            {

                string sql = "SELECT workdayId, employeeId, firstName, lastName, role, day, e.departmentId, departmentName ,shifts, missing FROM Workday as w " +
                    "inner join Employee as e " +
                    "on e.id = w.employeeId " +
                    "left join Department as d " +
                    "on e.departmentId = d.departmentId " +
                    "WHERE day = @date" ;

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);

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
                return workdays;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<DetailedWorkday> GetDepartmentWorkdaysQuery(string date, int depIdToFind)
        {
            MySqlConnection connection = new MySqlConnection(Utils.connectionString);

            try
            {
                string sql = "SELECT workdayId, employeeId, firstName, lastName, role, day, e.departmentId, departmentName ,shifts, missing FROM Workday as w " +
                    "inner join Employee as e " +
                    "on e.id = w.employeeId " +
                    "left join Department as d " +
                    "on e.departmentId = d.departmentId " +
                    "WHERE e.departmentId = @deptId AND day = @date";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@deptId", depIdToFind);

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
                return workdays;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Workday> GetEmpWorkdaysBetweenDatesQuery(Employee emp, DateTime startWeek, DateTime endWeek)
        {

            MySqlConnection conn = new MySqlConnection(Utils.connectionString);
            List<Workday> workdays = new List<Workday>();
            try
            {
                string sql = "Select * from Workday WHERE employeeId = @employeeId AND day BETWEEN @startDate and @endDate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employeeId", emp.Id);
                cmd.Parameters.AddWithValue("@startDate", startWeek.ToString(Utils.DbDateFormat));
                cmd.Parameters.AddWithValue("@endDate", endWeek.ToString(Utils.DbDateFormat));

                conn.Open();

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
                return workdays;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool AddWorkdayQuery(Workday workday)
        {
            MySqlConnection connection = new MySqlConnection(Utils.connectionString);
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
                    return true;
                }
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddMultipleWorkdaysQuery(List<Workday> workdays) 
        {
            StringBuilder sCommand = new("INSERT INTO Workday (employeeId, day, shifts) VALUES  ");
            using MySqlConnection conn = new(Utils.connectionString);
            try
            {
                List<string> rows = new();
                for (int i = 0; i < workdays.Count; i++)
                {
                    rows.Add(String.Format("('{0}','{1}','{2}')",
                        MySqlHelper.EscapeString(workdays[i].EmpID.ToString()),
                        MySqlHelper.EscapeString(workdays[i].Date),
                        MySqlHelper.EscapeString(workdays[i].Shifts)));
                }

                if (rows.Count == 0)
                {
                    return true;
                }

                sCommand.Append(String.Join(",", rows));
                sCommand.Append(';');
                conn.Open();
                using (MySqlCommand cmd = new(sCommand.ToString(), conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool MarkAttendanceQuery(string workdayId, bool missing)
        {
            MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            try
            {
                string sql = "UPDATE Workday SET missing = @missing WHERE workdayId = @workdayId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@workdayId", workdayId);
                cmd.Parameters.AddWithValue("@missing", missing);
                connection.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool DeleteWorkdayQuery(Workday workday)
        {
            MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            try
            {
                string sql = "DELETE from Workday WHERE workdayId = @workdayId";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@workdayId", workday.Id);
                connection.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool DeleteWorkdaysInTimeInterval(Tuple<DateTime, DateTime> dateInterval) {


            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);
            try {

                string sql = "DELETE from Workday WHERE day BETWEEN @dateIntervalLOWER AND @dateIntervalUPPER";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@dateIntervalLOWER", dateInterval.Item1);
                command.Parameters.AddWithValue("@dateIntervalUPPER", dateInterval.Item2);
                connection.Open();

                if (command.ExecuteNonQuery() >= 0)
                {
                    return true;
                }
                return false;

            }
            catch {
            
                return false;
            
            }

        
        
        }
    }
}
