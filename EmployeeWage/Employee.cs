using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class Employee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void EmployeeAttendance()
        {
            int empHrs = 0, empWage = 0, totalEmpwage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpwage += empWage;
                Console.WriteLine("Emp Wage:" + empWage);
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpwage);
        }
    }
}
