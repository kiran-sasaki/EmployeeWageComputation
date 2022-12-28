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
            int empHrs=0;
            Random random = new Random();
            int empCheck=random.Next(0, 3);
            switch(empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
                case 1:
                    Console.WriteLine("Employee is Present PartTime");
                    empHrs = 4;
                    break;
                case 2:
                    Console.WriteLine("Employee is Present FullTime");
                    empHrs = 8;
                    break;
            }
            int wage = empHrs * wagePerHour;
            Console.WriteLine("Employee wage is {0}",wage);
        }
    }
}
