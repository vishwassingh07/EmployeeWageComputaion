﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int IS_PRESENT = 0;
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
                Console.WriteLine("Employee is Not Present");
            }
        }
    }
}
