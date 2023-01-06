using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageUC8
{
    public  class EmployeWage
    {
        public const int IS_PART_TIME = 3;
        public const int IS_FULL_TIME = 2;
        public static int computrEmpWage(string company, int empRatePerHour, int numofworkingday, int maxiHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDAys = 0;
            while (totalEmpHrs <= maxiHoursPerMonth && totalWorkingDAys < numofworkingday)
            {
                totalWorkingDAys++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDAys + "Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + "is: " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
