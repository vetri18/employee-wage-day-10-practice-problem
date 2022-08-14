namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            UsingSwitchMonth usingSwitch = new UsingSwitchMonth();
            usingSwitch.CheckEmployeeAttendence();
        }
    }
}