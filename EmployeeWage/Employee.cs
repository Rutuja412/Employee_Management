using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class Employee
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        private int noOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public Employee()
        {
            this.companyEmpWageArray = new CompanyEmpWage[4];

        }
        public void addCompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.noOfCompany] = new CompanyEmpWage(company, empRatePerHours, numOfWorkingDays, maxHoursPerMonth);
            noOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHr = 0, totalWorkingDays = 0, empHrs = 0;
            while (totalEmpHr <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;

                Random random = new Random();

                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {

                    case Part_Time:

                        empHrs = 4;
                        break;

                    case Full_Time:

                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                            break;

                }
                totalEmpHr += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "EmpHrs" + empHrs);

            }

            return totalEmpHr * companyEmpWage.empRatePerHours;

        }
    }
}
