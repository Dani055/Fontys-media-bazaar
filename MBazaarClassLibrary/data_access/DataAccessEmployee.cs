using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBazaarClassLibrary.models;
using MySql.Data.MySqlClient;

namespace MBazaarClassLibrary.data_access
{
    public static class DataAccessEmployee
    {
        public static Employee Login (string username)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connectionString);
            try
            {
                string sql = "SELECT * FROM Employee INNER JOIN Department on Employee.departmentId = Department.departmentId WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int id = reader.GetInt32("id");
                    string uname = reader.GetString("username");
                    string pwd = reader.GetString("password");
                    string firstname = reader.GetString("firstName");
                    string lastname = reader.GetString("lastName");
                    string address = reader.GetString("address");
                    double wage = reader.GetDouble("hourlyWage");
                    string departmentid = reader["departmentId"].ToString();
                    string departmentName = reader["departmentName"].ToString();
                    string role = reader["role"].ToString();
                    string email = reader["email"].ToString();
                    string phone = reader["phone"].ToString();
                    string contractType = reader["contractType"] == DBNull.Value ? string.Empty : reader["contractType"].ToString();
                    Employee emp = new Employee(id, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType) { DepartmentName = departmentName};
                    reader.Close();

                    return emp;
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

        public static bool UpdateEmployee(Employee e)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connectionString);
            try
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
                command.Parameters.AddWithValue("@newDepartmentId", e.DepartmentId == -1 ? DBNull.Value : e.DepartmentId);
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
    }
}
