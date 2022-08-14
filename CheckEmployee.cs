using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CheckEmployee
    {
        public void CheckEmployeeAttendence()
        {
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
