namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            CheckEmployee checkEmployee = new CheckEmployee();
            checkEmployee.CheckEmployeeAttendence();
        }
    }
}