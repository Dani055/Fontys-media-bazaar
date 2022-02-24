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

        public static Department GetDepartmentByID(int id) {

            using MySqlConnection connection = new MySqlConnection(Utils.connectionString);

            try
            {

                string sql = "SELECT * FROM Department WHERE departmentId = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    reader.Read();
                    int deptId = reader.GetInt32("departmentId");
                    string depName = reader.GetString("departmentName");

                    Department department = new Department(deptId, depName);
                    return department;

                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;

            }


            
        }


    }
}
