using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public static class EmployeeService
    {
        public static Employee loggedEmp { get; set; } = null;
        private static MySqlConnection conn = new MySqlConnection(Utils.connectionString);

        public static bool Login(string username, string password)
        {
            try
            {
                using (conn) {
                    string sql = "SELECT * FROM Employee WHERE username = @username and password = @password";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32("id");
                            string uname = reader.GetString("username");
                            string pwd = reader.GetString("password");
                            string firstname = reader.GetString("firstName");
                            string lastname = reader.GetString("lastName");
                            string address = reader.GetString("address");
                            double wage = reader.GetDouble("hourly_wage");
                            string departmentid = reader["department_id"].ToString();
                            string role = reader["role"].ToString();
                            string email = reader["email"].ToString();
                            string phone = reader["phone"].ToString();

                            Employee emp = new Employee(id, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone);
                            EmployeeService.loggedEmp = emp;
                        }
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!");
                    }
                    reader.Close();
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        public static List<Employee> GetEmployees()
        {
            try
            {
                using (conn)
                {
                    string sql;
                    MySqlCommand cmd;
                    if (loggedEmp.Role == "Department manager")
                    {
                        sql = "SELECT * FROM Employee WHERE department_id = @depID";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@depID", loggedEmp.DepartmentId);
                    }
                    else if (loggedEmp.Role == "Employee manager")
                    {
                        sql = "SELECT * FROM Employee";
                        cmd = new MySqlCommand(sql, conn);
                    }
                    else if (loggedEmp.Role == "Depot manager")
                    {
                        sql = "Select * from Employee where role IN ('Cashier', 'Depot worker')";
                        cmd = new MySqlCommand(sql, conn);
                    }
                    else
                    {
                        return new List<Employee>();
                    }

                    List<Employee> emps = new List<Employee>();

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        {

                            int id = reader.GetInt32("id");
                            string uname = reader.GetString("username");
                            string pwd = reader.GetString("password");
                            string firstname = reader.GetString("firstName");
                            string lastname = reader.GetString("lastName");
                            string address = reader.GetString("address");
                            double wage = reader.GetDouble("hourly_wage");
                            string departmentid = reader["department_id"].ToString();
                            string role = reader["role"].ToString();
                            string email = reader["email"].ToString();
                            string phone = reader["phone"].ToString();

                        Employee emp = new Employee(id, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone);
                        emps.Add(emp);
                        }
                    reader.Close();
                    conn.Close();
                    return emps;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Employee>();
            }
        }
    }
}
