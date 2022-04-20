using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBazaarClassLibrary.models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double HourlyWage { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContractType { get; set; }
        public bool IsStudent { get; set; } //It is not in constructor because it is false by default. It can be changed after creation

        public Employee()
        {

        }
        public Employee(int id, string username, string pass, string firstname, string lastname, double wage, string address, string departmentid, string role, string email, string phone, string contract)
        {
            Id = id;
            Username = username;
            Password = pass;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            HourlyWage = wage;
            departmentid = departmentid == String.Empty ? "-1" : departmentid;
            if (email == "")
            {
                email = null;
            }
            if (phone == "")
            {
                phone = null;
            }
            if (contract == "")
                contract = null;
            Email = email;
            Phone = phone;
            DepartmentId = int.Parse(departmentid);
            Role = role;
            ContractType = contract;
        }
    }
}
