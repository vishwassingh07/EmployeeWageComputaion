using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Company
    {
        public int EMP_WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, WORKING_DAYS_A_MONTH = 20,
            MAX_WORKING_HR = 100;
        public String COMPANY_NAME;

        public Company(string COMPANY_NAME, int EMP_WAGE_PER_HR, int FULL_DAY_HR, int PART_TIME_HR, int MAX_WORKING_HR, int WORKING_DAYS_A_MONTH)
        {
            this.COMPANY_NAME = COMPANY_NAME;
            this.EMP_WAGE_PER_HR = EMP_WAGE_PER_HR;
            this.FULL_DAY_HR = FULL_DAY_HR;
            this.PART_TIME_HR = PART_TIME_HR;
            this.MAX_WORKING_HR = MAX_WORKING_HR;
            this.WORKING_DAYS_A_MONTH = WORKING_DAYS_A_MONTH;
        }
    }
}
