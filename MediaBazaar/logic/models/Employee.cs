using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.logic.models
{
    public class Employee
    {
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double HourlyWage { get; set; }
        public string DepartmentId { get; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContractType { get; set; }
        public Employee(int id, string username, string pass, string firstname, string lastname,double wage, string address, string departmentid, string role, string email, string phone, string contract)
        {
            Id = id;
            Username = username;
            Password = pass;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            HourlyWage = wage;
            if (departmentid == "")
            {
                departmentid = null;
            }
            if (email == "")
            {
                email = null;
            }
            if (phone == "")
            {
                phone = null;
            }
            if(contract == "")
                contract = null;
            Email = email;
            Phone = phone;
            DepartmentId = departmentid;
            Role = role;
            ContractType = contract;
        }
    }
}
