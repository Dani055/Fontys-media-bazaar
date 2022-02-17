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
                    string role = reader.GetString("role");
                    Employee emp = new Employee(id, uname, pwd, firstname, lastname, address, departmentid, role);
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
}
