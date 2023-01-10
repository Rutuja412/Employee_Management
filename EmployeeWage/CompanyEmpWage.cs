using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empRatePerHours;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHours = empRatePerHours;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.numOfWorkingDays= numOfWorkingDays;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp wage of compay" + this.company + "is" + this.totalEmpWage;
        }
    }
}
