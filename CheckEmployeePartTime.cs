using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CheckEmployeePartTime
    {
        public void CheckEmployeeAttendence()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int WAGE_PER_HOUR = 20;
            //Variables
            int empHr = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHr = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee did Parttime.");
                empHr = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHr = 0;
            }
            empWage = empHr * WAGE_PER_HOUR;
            Console.WriteLine("Employee wage is: " + empWage);

        }
    }
}
