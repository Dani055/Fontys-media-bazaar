using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.logic;
using MediaBazaar.logic.models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaar.logic.services
{
    public static class EmployeeService
    {
        public static Employee loggedEmp { get; set; }
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
                            double wage = reader.GetDouble("hourlyWage");
                            string departmentid = reader["departmentId"].ToString();
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
                        sql = "SELECT * FROM Employee WHERE departmentId = @depID";
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
                            double wage = reader.GetDouble("hourlyWage");
                            string departmentid = reader["departmentId"].ToString();
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

        public static Employee GetEmployeeByID(int id) {


            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);

            try
            {

                string sql = "SELECT * FROM Employee WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    reader.Read();
                    int empid = reader.GetInt32("id");
                    string uname = reader.GetString("username");
                    string pwd = reader.GetString("password");
                    string firstname = reader.GetString("firstName");
                    string lastname = reader.GetString("lastName");
                    string address = reader.GetString("address");
                    double wage = reader.GetDouble("hourlyWage");
                    string departmentid = reader["departmentId"].ToString();
                    string role = reader["role"].ToString();
                    string email = reader["email"].ToString();
                    string phone = reader["phone"].ToString();

                    Employee emp = new Employee(empid, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone);
                    return emp;

                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;

            }
            finally
            {
                conn.Close();
            }
        }
        public static void AddEmployee(Employee e)
        {
            string query = "INSERT INTO Employee (username,password,firstName,lastName,address,hourlyWage,departmentId,role,email,phone,contractType) VALUES (@Username, @Password, @FirstName, @LastName, @Address, @HourlyWage, @DepartmentId, @Role, @Email, @Phone, @ContractType)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Username", e.Username);
            command.Parameters.AddWithValue("@Password", e.Password);
            command.Parameters.AddWithValue("@FirstName", e.FirstName);
            command.Parameters.AddWithValue("@LastName", e.LastName);
            command.Parameters.AddWithValue("@Address", e.Address);
            command.Parameters.AddWithValue("@HourlyWage", e.HourlyWage);
            command.Parameters.AddWithValue("@DepartmentId", e.DepartmentId == "0" ? DBNull.Value : e.DepartmentId);
            command.Parameters.AddWithValue("@Role", e.Role == null ? DBNull.Value : e.Role);
            command.Parameters.AddWithValue("@Email", e.Email == null ? DBNull.Value : e.Email);
            command.Parameters.AddWithValue("@Phone", e.Phone == null ? DBNull.Value : e.Phone);
            command.Parameters.AddWithValue("@ContractType", DBNull.Value); //TODO : INSERT CONTRACT TYPE HERE
            try
            {
                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfuly added new employee");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public static int GetNewAvailableID()
        {
            var emps = GetEmployees();
            return emps.ElementAt(emps.Count - 1).Id + 1;
        }

       
    }
}
