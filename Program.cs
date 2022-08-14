namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            EmpWageBuilder dMart = new EmpWageBuilder("Dmart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);

            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());

            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}