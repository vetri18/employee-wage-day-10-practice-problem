namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            MultipleCompanies.ComputeEmpWage("Dmart", 20, 2, 10);
            MultipleCompanies.ComputeEmpWage("Reliance", 10, 4, 20);
        }
    }
}