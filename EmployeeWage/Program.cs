using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.addCompanyEmpWage("DMart", 20, 2, 10);
            employee.addCompanyEmpWage("Reliance", 10, 4, 20);
            employee.computeEmpWage();

        }
    }
}
