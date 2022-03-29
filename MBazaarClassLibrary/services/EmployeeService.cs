using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBazaarClassLibrary.models;
using MySql.Data.MySqlClient;

namespace MBazaarClassLibrary.services
{
    public static class EmployeeService
    {
        public static Employee loggedEmp { get; set; }
        private static MySqlConnection conn = new MySqlConnection(Utils.connectionString);

        public static bool Login(string username, string password)
        {
            try
            {
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
                    return true;
                }
                else
                {
                    reader.Close();
                    throw new Exception("Wrong username or password!");
                }
            }
            finally
            {
                conn.Close();
            }

        }
        public static List<Employee> GetEmployees()
        {
            try
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

        public static Employee GetEmployeeByID(int id)
        {
            try
            {
                string sql = "SELECT * FROM Employee WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
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
                    Employee emp = new Employee(empid, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType) { IsStudent = isStudent };
                    return emp;
                }
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool AddEmployee(Employee e)
        {
            try
            {
                ValidateEmployee(e.Username, e.Password, e.FirstName, e.LastName, e.Address);
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

                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        public static bool RemoveEmployee(int id)
        {
            try
            {
                string query = "DELETE FROM Employee WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally
            { conn.Close(); }

        }
        public static bool UpdateEmployee(Employee e)
        {
            try
            {
                ValidateEmployee(e.Username, e.Password, e.FirstName, e.LastName, e.Address);
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

                conn.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally { conn.Close(); }
        }
        public static int GetNewAvailableID()
        {
            try
            {
                var emps = GetEmployees();
                return emps.ElementAt(emps.Count - 1).Id + 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public static bool ValidateEmployee(string username, string password, string firstname, string lastname, string address)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Username is required!");
            }
            else if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password is required!");
            }
            else if (string.IsNullOrEmpty(firstname))
            {
                throw new Exception("First name is required!");
            }
            else if (string.IsNullOrEmpty(lastname))
            {
                throw new Exception("Last name is required!");
            }
            else if (string.IsNullOrEmpty(address))
            {
                throw new Exception("Address is required!");
            }
            return true;
        }
    }
}
