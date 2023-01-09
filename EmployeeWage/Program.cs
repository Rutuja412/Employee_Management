using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dMart = new Employee("DMart", 20, 2, 10);
            Employee reliance = new Employee("Reliance", 10, 4, 20);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString()); 

        }
    }
}
