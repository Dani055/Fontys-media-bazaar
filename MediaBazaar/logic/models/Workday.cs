using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.logic.models
{
    public class Workday
    {

        public int Id { get; private set; }
        public int EmpID { get; private set; }
        public string Date { get; set; }
        public string Shifts { get; set; }
        public bool Missing { get; set; }

        public Workday(int id, int empId, string date, string shifts, bool missing) 
        {
            Id = id;
            EmpID = empId;
            Date = date;
            Shifts = shifts;
            Missing = missing;
        }

        //overload for adding workday to db
        public Workday(int empId, string date, string shifts, bool missing)
        {
            EmpID = empId;
            Date = date;
            Shifts = shifts;
            Missing = missing;
        }



    }
}
