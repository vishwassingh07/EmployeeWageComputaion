﻿using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Employee Wage Calculation Program");
            WageComputation attendancecheck = new WageComputation();
            attendancecheck.EmployeeAttendence();
            WageComputation empwagecomputation = new WageComputation();
            empwagecomputation.EmpWageCalculation();

        }
    }
}