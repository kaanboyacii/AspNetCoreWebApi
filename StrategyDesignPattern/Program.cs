class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee(new HourlySalaryStrategy());

        double baseSalary = 10;
        double hourlySalary = employee.CalculateSalary(baseSalary);
        Console.WriteLine("Hourly Salary: " + hourlySalary);

        employee.SetSalaryStrategy(new MonthlySalaryStrategy());

        double monthlySalary = employee.CalculateSalary(baseSalary);
        Console.WriteLine("Monthly Salary: " + monthlySalary);   
        
        employee.SetSalaryStrategy(new YearlySalaryStrategy());

        double yearlySalary = employee.CalculateSalary(baseSalary);
        Console.WriteLine("Yearly Salary: " + yearlySalary);

        Console.ReadLine();
    }
}
