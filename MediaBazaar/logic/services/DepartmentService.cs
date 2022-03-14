using MediaBazaar.logic.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.logic.services
{
    //so i thought we could have all the data related to each object be handled by their own service
    //if this seems like a bad idea just move the classes in here to employee service

    public static class DepartmentService
    {
        public static List<Department> AllDepartments { get; set; }
        static DepartmentService()
        {
           UpdateDepartments();
        }

        public static void CreateDepartment(Department dep)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Utils.connectionString);
                using (conn)
                {
                    string query = "INSERT INTO Department (departmentName) VALUES(@name)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", dep.Name);
                    conn.Open();
                    if(cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show($"Successfuly added {dep.Name} department!");
                }
                UpdateDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Department GetDepartmentByID(int id) {

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
            List<Department> departments = new List<Department>();
            MySqlConnection conn = new MySqlConnection(Utils.connectionString);
            string query = "SELECT * FROM Department";
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    departments.Add(new Department(r.GetInt32("departmentId"), r.GetString("DepartmentName")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { conn.Close(); }

            return departments;
        }
        public static void UpdateDepartments()
        {
            AllDepartments?.Clear();
            AllDepartments = GetAllDepartments();
        }
        public static void RemoveDepartment(int id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Utils.connectionString);
                string query = "DELETE FROM Department WHERE departmentId = @depId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@depId", id);
                using (conn)
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        Utils.ShowInfo("Successfuly removed department.");
                }
                UpdateDepartments();
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }
        }
        public static bool EditName(Department d)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Utils.connectionString);
                string query = "UPDATE Department SET departmentName = @newName WHERE departmentId = @depId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newName", d.Name);
                cmd.Parameters.AddWithValue("@depId", d.Id);
                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                UpdateDepartments();
                return true;
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
                return false;
            }
        }
    }
}
