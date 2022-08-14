namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();

            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for Dmart company :{0} ", empWageBuilder.getTotalWage("Dmart"));
            Console.WriteLine("Total Wage for Reliance company :{0} ", empWageBuilder.getTotalWage("Reliance"));
        }
    }
}