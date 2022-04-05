using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBazaarClassLibrary.models;
using MySql.Data.MySqlClient;

namespace MBazaarClassLibrary.services
{
    //so i thought we could have all the data related to each object be handled by their own service
    //if this seems like a bad idea just move the classes in here to employee service

    public static class DepartmentService
    {
        private static MySqlConnection conn = new MySqlConnection(Utils.connectionString);
        public static List<Department> AllDepartments { get; set; }
        static DepartmentService()
        {
            UpdateDepartments();
        }

        public static bool CreateDepartment(Department dep)
        {
            try
            {
                if (string.IsNullOrEmpty(dep.Name))
                {
                    throw new Exception("Department name is required");
                }

                string query = "INSERT INTO Department (departmentName, essential) VALUES(@name, @essential)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", dep.Name);
                cmd.Parameters.AddWithValue("@essential", dep.IsEssential);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    UpdateDepartments();
                    return true;
                }
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static Department GetDepartmentByID(int id)
        {

            foreach (Department department in AllDepartments)
            {
                if (department.Id == id)
                    return department;
            }
            return null;

            #region OldCode
            //using MySqlConnection connection = new MySqlConnection(Utils.connectionString);

            //try
            //{

            //    string sql = "SELECT * FROM Department WHERE departmentId = @id";
            //    MySqlCommand cmd = new MySqlCommand(sql, connection);
            //    cmd.Parameters.AddWithValue("@id", id);
            //    connection.Open();
            //    MySqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.HasRows)
            //    {

            //        reader.Read();
            //        int deptId = reader.GetInt32("departmentId");
            //        string depName = reader.GetString("departmentName");

            //        Department department = new Department(deptId, depName);
            //        return department;

            //    }
            //    return null;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return null;

            //}
            #endregion 
        }
        public static List<Department> GetAllDepartments()
        {
            try
            {
                List<Department> departments = new List<Department>();
                string query = "SELECT * FROM Department";

                MySqlCommand command = new MySqlCommand(query, conn);

                conn.Open();
                MySqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    Department dp = new Department(r.GetInt32("departmentId"), r.GetString("DepartmentName"));
                    if (r.GetBoolean("essential") == true)
                        dp.IsEssential = true;
                    departments.Add(dp);
                }
                return departments;
            }
            finally
            { conn.Close(); }
        }
        public static void UpdateDepartments()
        {
            AllDepartments?.Clear();
            AllDepartments = GetAllDepartments();
        }
        public static bool RemoveDepartment(int id)
        {
            Department dep = GetDepartmentByID(id);
            if (dep.IsEssential && EmployeeService.loggedEmp.Role != "CEO")
            {
                throw new Exception("You can't delete this department!");              
            }
            try
            {
                string query = "DELETE FROM Department WHERE departmentId = @depId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@depId", id);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    UpdateDepartments();
                    return true;
                }
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool UpdateDepartment(Department d)
        {
            try
            {
                string query = "UPDATE Department SET departmentName = @newName WHERE departmentId = @depId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newName", d.Name);
                cmd.Parameters.AddWithValue("@depId", d.Id);

                conn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    UpdateDepartments();
                    return true;
                }
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
