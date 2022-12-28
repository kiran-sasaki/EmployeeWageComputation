using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public static class EmployeeWage
    {
        public static void EmpWage()
        {
            int present = 1;
            int wagePerHour = 20;
            int empHrs;
            Random random = new Random();
            int empCheck=random.Next(0, 2);
            if(empCheck == present)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            int wage = empHrs * wagePerHour;
            Console.WriteLine("Employee wage is {0}",wage);
        }
    }
}
