﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProgramUC6
{
    public  class EmployeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAY = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static void MonthyWage()
        {
            //Variable 
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation 
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays<NUM_OF_WORKING_DAY)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch(empCheck)
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
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" +empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }
    }
}