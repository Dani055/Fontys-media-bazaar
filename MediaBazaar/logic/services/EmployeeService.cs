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
                            string contractType = reader["contractType"] == DBNull.Value ? string.Empty : reader["contractType"].ToString();
                            Employee emp = new Employee(id, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType);
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
                    string loggedEmpRole = loggedEmp.Role.ToUpper();

                    if (loggedEmpRole == "DEPARTMENT MANAGER" || loggedEmpRole == "DEPOT MANAGER")
                    {
                        sql = "SELECT * FROM Employee WHERE departmentId = @depID order by departmentId";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@depID", loggedEmp.DepartmentId);
                    }
                    else if (loggedEmpRole == "EMPLOYEE MANAGER")
                    {
                        sql = "SELECT * FROM Employee order by departmentId";
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
                        string contractType = reader["contractType"] == DBNull.Value ? string.Empty : reader["contractType"].ToString();
                        bool isStudent = reader.GetBoolean("isStudent");
                        Employee emp = new Employee(id, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType) {IsStudent = isStudent };
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

        public static List<Employee> SearchEmployees(string keyword)
        {
            try
            {
                string sql;
                MySqlCommand cmd;
                string loggedEmpRole = loggedEmp.Role.ToUpper();
                
                if (loggedEmpRole == "DEPARTMENT MANAGER" || loggedEmpRole == "DEPOT MANAGER")
                {
                    sql = "SELECT * FROM Employee WHERE departmentId = @depID AND (firstName like @keyword or lastName like @keyword or address like @keyword or role like @keyword or phone like @keyword)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@depID", loggedEmp.DepartmentId);
                }
                else if (loggedEmpRole == "EMPLOYEE MANAGER")
                {
                    sql = "SELECT * FROM Employee WHERE firstName like @keyword or lastName like @keyword or address like @keyword or role like @keyword or phone like @keyword";
                    cmd = new MySqlCommand(sql, conn);
                }
                else
                {
                    throw new Exception("You are not authorized to search employees.");
                }
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
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
                    string contractType = reader["contractType"] == DBNull.Value ? string.Empty : reader["contractType"].ToString();
                    bool isStudent = reader.GetBoolean("isStudent");
                    Employee emp = new Employee(id, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType) { IsStudent = isStudent };
                    emps.Add(emp);
                }
                reader.Close();
                return emps;       
            }
            finally
            {
                conn.Close();
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
                    string contractType = reader["contractType"] == DBNull.Value ? string.Empty : reader["contractType"].ToString();
                    bool isStudent = reader.GetBoolean("isStudent");
                    Employee emp = new Employee(empid, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType) {IsStudent = isStudent };
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
            string query = "INSERT INTO Employee (username,password,firstName,lastName,address,hourlyWage,departmentId,role,email,phone,contractType,isStudent) VALUES (@Username, @Password, @FirstName, @LastName, @Address, @HourlyWage, @DepartmentId, @Role, @Email, @Phone, @ContractType, @isStudent)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Username", e.Username);
            command.Parameters.AddWithValue("@Password", e.Password);
            command.Parameters.AddWithValue("@FirstName", e.FirstName);
            command.Parameters.AddWithValue("@LastName", e.LastName);
            command.Parameters.AddWithValue("@Address", e.Address);
            command.Parameters.AddWithValue("@HourlyWage", e.HourlyWage);
            command.Parameters.AddWithValue("@DepartmentId", e.DepartmentId == 0 ? DBNull.Value : e.DepartmentId.ToString());
            command.Parameters.AddWithValue("@Role", e.Role == null ? DBNull.Value : e.Role);
            command.Parameters.AddWithValue("@Email", e.Email == null ? DBNull.Value : e.Email);
            command.Parameters.AddWithValue("@Phone", e.Phone == null ? DBNull.Value : e.Phone);
            command.Parameters.AddWithValue("@ContractType", e.ContractType == null ? DBNull.Value : e.ContractType);
            command.Parameters.AddWithValue("@isStudent", e.IsStudent);
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
        public static void RemoveEmployee(int id)
        {
            string query = "DELETE FROM Employee WHERE id = @id";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfuly deleted employee.");
                }
                else
                {
                    MessageBox.Show("Could not delete employee.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            { conn.Close(); }
            
        }
        public static void UpdateEmployee(Employee e)
        {
            string query = "UPDATE Employee SET username = @newUName, password = @newPassword, firstName = @newFirstName, lastName = @newLastName, address = @newAddress, hourlyWage = @newHourlyWage, departmentId = @newDepartmentId, role = @newRole, email = @newEmail, phone = @newPhone, contractType = @newContractType, isStudent = @newIsStudent WHERE id = @id";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", e.Id);
            command.Parameters.AddWithValue("@newUName", e.Username);
            command.Parameters.AddWithValue("@newPassword", e.Password);
            command.Parameters.AddWithValue("@newFirstName", e.FirstName);
            command.Parameters.AddWithValue("@newLastName", e.LastName);
            command.Parameters.AddWithValue("@newAddress", e.Address);
            command.Parameters.AddWithValue("@newHourlyWage", e.HourlyWage);
            command.Parameters.AddWithValue("@newDepartmentId", e.DepartmentId == 0 ? DBNull.Value : e.DepartmentId);
            command.Parameters.AddWithValue("@newRole", e.Role);
            command.Parameters.AddWithValue("@newEmail", e.Email);
            command.Parameters.AddWithValue("@newPhone", e.Phone);
            command.Parameters.AddWithValue("@newContractType", e.ContractType);
            command.Parameters.AddWithValue("@newIsStudent", e.IsStudent);
            try
            {
                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                    MessageBox.Show("Data changed");
                else
                    MessageBox.Show("No data was changed");
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
