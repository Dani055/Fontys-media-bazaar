using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Employee
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double hourlyWage { get; set; }
        public string DepartmentId { get; }
        public string Role { get; set; }

        public Employee(int id, string username, string pass, string firstname, string lastname, string address, string departmentid, string role)
        {
            Id = id;
            Username = username;
            Password = pass;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            if (departmentid == "")
            {
                departmentid = null;
            }
            DepartmentId = departmentid;
            Role = role;
        }
    }
}
