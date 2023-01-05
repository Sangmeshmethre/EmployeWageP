using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProgramUC3
{
    public  class EmployeWage
    {
        public static void PartTime()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME=2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            
            Random random = new Random();
            int empChcek=random.Next(0,3);
            if (empChcek == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empChcek == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs=0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
