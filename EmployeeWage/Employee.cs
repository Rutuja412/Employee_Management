using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class Employee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string compony;
        private int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;//global variable stored in heap memory
        public Employee(string compony, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)//local variable stired in stack memory which is temporary
        {
            this.compony = compony;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth=maxHoursPerMonth;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public  void ComputeEmpWage( )
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Part Time");
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Full Time");
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                 totalEmpHrs += empHrs;
                 Console.WriteLine(" Days : " + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for compony:" + compony +" is:"  +totalEmpWage);
        }
        public string toString()
        {
            return "Total Employee wage for compony : " + this.compony + " is:  " + this.totalEmpWage;
        }
    }
}
