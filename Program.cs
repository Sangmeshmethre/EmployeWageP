using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProgramUC14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();

            Console.WriteLine("Total wage for Dmart company is " + empWageBuilder.getTotalWage("Dmart"));
            Console.WriteLine("Total wage for Reliance company is " + empWageBuilder.getTotalWage("Reliance"));
        }
    }
}