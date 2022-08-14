namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            UsingSwitch usingSwitch = new UsingSwitch();
            usingSwitch.CheckEmployeeAttendence();
        }
    }
}