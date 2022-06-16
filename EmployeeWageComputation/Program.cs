using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Employee Wage Calculation Program");
            //WageComputation attendancecheck = new WageComputation();
            //attendancecheck.EmployeeAttendence();
            WageComputation empwagecomputation = new WageComputation();
            empwagecomputation.AddCompany("Reliance", 20, 8, 4, 100, 20);
            empwagecomputation.AddCompany("Tata", 25, 9, 5, 90, 24);
            empwagecomputation.EmpWageCalculation("reliance");
            empwagecomputation.EmpWageCalculation("tata");


        }
    }
}