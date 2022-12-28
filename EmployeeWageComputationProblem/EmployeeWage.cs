using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmployeeWage
    {
        public const int Is_FullTime = 2;
        public const int Is_PartTime = 1;
        public const int Wage_Per_Hour = 20;
        public const int MAX_Working_Day_Per_Month = 20;
        public const int MAX_Working_Hrs_Per_Month = 100;
        public void EmpWage()
        {
            int empHrs=0;
            int wage;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_Working_Hrs_Per_Month && totalWorkingDays <= MAX_Working_Day_Per_Month)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + "EmpHrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * Wage_Per_Hour;
            Console.WriteLine("Total Employee Wage is " + totalEmpWage);
        }
    }
}
