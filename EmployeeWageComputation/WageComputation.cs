using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_PRESENT = 0,WAGE_PER_HR = 20, FULL_DAY_HR = 8,PART_TIME_HR = 4,
        IS_FULL_DAY_PRESENT = 0, IS_PART_TIME_PRESENT = 1, WORKING_DAYS_A_MONTH = 20;
        int empHrs,totalEmpHrs, totalEmpWage, empWage, totalWorkingDays;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0,2);
            if (check == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Not Present ");
            }
        }
        public void EmpWageCalculation()
        {
            for (int day = 0; day <= WORKING_DAYS_A_MONTH && empHrs<=100; day++)
            {

                Random random = new Random();
                int check = random.Next(0, 3);

                switch (check)
                {
                    case IS_FULL_DAY_PRESENT:
                        empHrs = FULL_DAY_HR;
                        break;
                    case IS_PART_TIME_PRESENT:
                        empHrs = PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : {0}  Emp Hours : {1}", day, empHrs);
            }
            int totalEmpWage = totalEmpHrs * WAGE_PER_HR;
            Console.WriteLine("Total Wage Of Employee is {0}", totalEmpWage);


        }
    }
}
