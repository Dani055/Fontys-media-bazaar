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
    }
}
