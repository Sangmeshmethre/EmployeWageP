using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeProgramUC10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpwage("Dmart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpwage("Reliance", 10, 4, 20);
            empWageBuilderArray.computeEmpWage();
        }
    }
}