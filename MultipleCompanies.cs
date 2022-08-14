using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MultipleCompanies
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FUL_TIME = 2;
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalHr = 0, totalWorkingDays = 0;

            while (totalHr <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FUL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalHr += empHrs;
                Console.WriteLine("Days:  {0} and Employee Hrs: {1}", totalWorkingDays, empHrs);

            }
            int totalEmpWage = totalHr * empRatePerHour;
            Console.WriteLine("Total Employee wage for company:{0} is {1}", company, totalEmpWage);
            return totalEmpWage;
        }
    }
}
