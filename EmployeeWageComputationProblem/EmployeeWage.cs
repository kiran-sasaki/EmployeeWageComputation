using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public static class EmployeeWage
    {
        public const int Is_FullTime = 2;
        public const int Is_PartTime = 1;
        public const int Wage_Per_Hour = 20;
        public const int Working_Day_Per_Month = 20;
        public static void EmpWage()
        {
            int empHrs=0;
            int wage;
            int totalEmpWage = 0;
            for (int i = 0; i < Working_Day_Per_Month; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                wage = empHrs * Wage_Per_Hour;
                Console.WriteLine("Employee wage is {0}", wage);
                totalEmpWage += wage;
            }
            Console.WriteLine("Total Employee Wage is " + totalEmpWage);
        }
    }
}
