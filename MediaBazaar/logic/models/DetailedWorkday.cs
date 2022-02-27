using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.logic.models
{
    public class DetailedWorkday : Workday
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        
        public DetailedWorkday(int id, int empId, string date, string shifts, bool missing, string firstname, string lastname, string role, string deptId, string deptName) : base( id,  empId,  date,  shifts,  missing)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = role;
            DepartmentId = deptId;
            DepartmentName = deptName;
        }
    }
}
