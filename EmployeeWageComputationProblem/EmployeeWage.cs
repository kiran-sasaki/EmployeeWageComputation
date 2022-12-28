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
            int fullTime = 2;
            int partTime = 1;
            int wagePerHour = 20;
            int empHrs;
            Random random = new Random();
            int empCheck=random.Next(0, 3);
            if(empCheck == fullTime)
            {
                Console.WriteLine("Employee is FullTime");
                empHrs = 8;

            }
            else if(empCheck == partTime)
            {
                Console.WriteLine("Employee is PartTime");
                empHrs = 4;
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
