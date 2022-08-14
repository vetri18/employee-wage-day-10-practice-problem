namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            CheckEmployeePartTime checkEmployee = new CheckEmployeePartTime();
            checkEmployee.CheckEmployeeAttendence();
        }
    }
}