namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            UsingSwitchMethod usingSwitch = new UsingSwitchMethod();
            usingSwitch.CheckEmployeeAttendence();
        }
    }
}