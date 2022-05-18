using MBazaarClassLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBazaarClassLibrary.services
{
    public class AutoScheduler
    {
        private Tuple<DateTime, DateTime> nextWeekInterval;
        private Dictionary<int, List<Employee>> employeesByDepartment;
        private Dictionary<int, List<Employee>> studentEmployeesByDepartment;

        public AutoScheduler(Tuple<DateTime, DateTime> nextWeekInterval, Dictionary<int, List<Employee>> employeesByDepartment, Dictionary<int, List<Employee>> studentEmployeesByDepartment ) 
        {
            this.nextWeekInterval = nextWeekInterval;

            this.employeesByDepartment = employeesByDepartment;
            this.studentEmployeesByDepartment = studentEmployeesByDepartment;
        }

        public List<Workday> AppendStudentWorkdays()
        {
            //looping through students, their shifts being only at night
            List<Workday> workdays = new List<Workday>();
            foreach (KeyValuePair<int, List<Employee>> department in studentEmployeesByDepartment)
            {
                int dayLeftOut = 0;
                foreach (Employee employee in department.Value)
                {
                    DateTime dateOfWorkday = nextWeekInterval.Item1;
                    //assigned to all days except a random one, to reach the minimum 24 hours
                    for (int i = 0; i < 7; i++)
                    {

                        if (i == dayLeftOut)
                        {
                            dateOfWorkday = dateOfWorkday.AddDays(1);
                            continue;
                        }

                        workdays.Add(new Workday(employee.Id, dateOfWorkday.Date.ToString(Utils.DbDateFormat), "evening", false));
                        dateOfWorkday = dateOfWorkday.AddDays(1);

                    }

                    //this is by far the most horrible looking thing ive ever written
                    dayLeftOut = dayLeftOut == 6 ? 1 : dayLeftOut + 1;

                }

            }

            return workdays;
        }

        public List<Workday> AppendNormalEmployees(List<Workday> workdays)
        {
            int studentShifts = workdays.Count;

            int normalEmployeesShiftCount = 0;
            foreach (KeyValuePair<int, List<Employee>> department in employeesByDepartment)
            {

                normalEmployeesShiftCount += department.Value.Count;

            }

            // shift count not multiplied - done
            normalEmployeesShiftCount *= 10;
            // normalEmployeesShiftCount *= 10;

            //remove multiplication - done
            int studentShiftPercentage = (studentShifts / (studentShifts + normalEmployeesShiftCount)) * 100;

            int morningPercentage;
            int afternoonPercentage;
            int eveningPercentage;
            if (studentShiftPercentage >= 33)
            {
                morningPercentage = (100 - studentShiftPercentage) / 2;
                afternoonPercentage = morningPercentage;
                eveningPercentage = 0;

            }
            else
            {

                eveningPercentage = 33 - studentShiftPercentage;
                morningPercentage = 33; // moved to 33%
                                        // morningPercentage = studentShiftPercentage / 2 + 33;
                afternoonPercentage = morningPercentage;

            }

            double percentValueOfOneShift = ((double)studentShifts + (double)normalEmployeesShiftCount) / 100;

            percentValueOfOneShift = Math.Round(percentValueOfOneShift, 2);

            double currentMorningValue = 0;
            double currentAfternoonValue = 0;
            double currentEveningValue = studentShifts * percentValueOfOneShift;
            //the rest of the employees are assigned
            foreach (KeyValuePair<int, List<Employee>> department in employeesByDepartment)
            {


                //probably not needed
                int employeeCount = department.Value.Count;

                DateTime dateOfWorkday = nextWeekInterval.Item1;

                DateTime dayLeftOut = nextWeekInterval.Item1;

                foreach (Employee employee in department.Value)
                {

                    int assignedShifts = 0;
                    //cant be more than 4 single shift days or the emp wont reach 40 hours contract



                    while (assignedShifts < 10)
                    {
                        bool prevEvening = false;

                        if (assignedShifts > 0)
                        { //              ----not needed ---------------------------------
                            prevEvening = workdays[workdays.Count - 1].EmpID == employee.Id && workdays[workdays.Count - 1].Shifts.Contains("evening");
                        }


                        /*
                         * right now, double shifts are forced mon-wed because of the assigned shifts check
                         * fix: remove assigned shift check, instead for double shifts, check if afternoon is second minimum
                        */
                        if (assignedShifts < 8)
                        {

                            if (currentMorningValue <= currentEveningValue && !prevEvening)
                            {

                                workdays.Add(new Workday(employee.Id, dateOfWorkday.Date.ToString(Utils.DbDateFormat), "morning#afternoon", false));
                                currentMorningValue += percentValueOfOneShift;
                                currentAfternoonValue += percentValueOfOneShift;
                                //currentAfternoonValue = (currentMorningValue + currentEveningValue) / 2;
                                assignedShifts += 2;


                            }

                            else
                            {
                                workdays.Add(new Workday(employee.Id, dateOfWorkday.Date.ToString(Utils.DbDateFormat), "afternoon#evening", false));
                                currentEveningValue += percentValueOfOneShift;
                                currentAfternoonValue += percentValueOfOneShift;
                                //currentAfternoonValue = (currentMorningValue + currentEveningValue) / 2;
                                assignedShifts += 2;

                            }


                        }

                        else
                        {
                            double leastBusy = Math.Min(Math.Min(currentMorningValue, currentAfternoonValue / 1.57), currentEveningValue);

                            if (dateOfWorkday.Equals(dayLeftOut))
                            {
                                if (dateOfWorkday == nextWeekInterval.Item2)
                                {
                                    dateOfWorkday = nextWeekInterval.Item1;
                                }
                                else
                                {
                                    dateOfWorkday = dateOfWorkday.AddDays(1);
                                }
                                continue;
                            }
                            if (leastBusy == currentMorningValue && !prevEvening)
                            {
                                workdays.Add(new Workday(employee.Id, dateOfWorkday.Date.ToString(Utils.DbDateFormat), "morning", false));
                                currentMorningValue += percentValueOfOneShift;
                                assignedShifts++;

                            }
                            else
                            {
                                if (leastBusy == currentAfternoonValue / 1.57)
                                {
                                    workdays.Add(new Workday(employee.Id, dateOfWorkday.Date.ToString(Utils.DbDateFormat), "afternoon", false));
                                    currentAfternoonValue += percentValueOfOneShift;
                                    assignedShifts++;
                                }
                                else
                                {
                                    workdays.Add(new Workday(employee.Id, dateOfWorkday.Date.ToString(Utils.DbDateFormat), "evening", false));
                                    currentEveningValue += percentValueOfOneShift;
                                    assignedShifts++;
                                }
                            }

                        }


                        if (dateOfWorkday == nextWeekInterval.Item2)
                        {
                            dateOfWorkday = nextWeekInterval.Item1;
                        }
                        else
                        {
                            dateOfWorkday = dateOfWorkday.AddDays(1);
                        }
                    }

                    if (dayLeftOut == nextWeekInterval.Item2)
                    {
                        dayLeftOut = nextWeekInterval.Item1;
                    }
                    else
                    {
                        dayLeftOut = dayLeftOut.AddDays(1);
                    }

                }


            }

            return workdays;
        }
    }
}
