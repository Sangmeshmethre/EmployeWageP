using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeProgramUC9.EmployeWageP;

namespace EmployeProgramUC9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Relience", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}