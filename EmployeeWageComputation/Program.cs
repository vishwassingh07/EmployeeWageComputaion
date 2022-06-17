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
            WageComputation empwagecomputation = new WageComputation(3);
            empwagecomputation.AddCompany("Reliance", 20, 8, 4, 100, 20);
            empwagecomputation.EmpWageCalculation("reliance");
            empwagecomputation.AddCompany("Tata", 25, 9, 5, 90, 24);       
            empwagecomputation.EmpWageCalculation("tata");
            empwagecomputation.AddCompany("Birla", 22, 7, 6, 110, 25);
            empwagecomputation.EmpWageCalculation("birla");


            Console.Write("Enter the name of the company you want to check the total wage : ");
            string name = Console.ReadLine();
            empwagecomputation.DisplayWage(name);


        }
    }
}