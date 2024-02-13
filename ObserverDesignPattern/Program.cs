class Program
{
    static void Main(string[] args)
    {
        // Create subjects
        HRDepartment hrDepartment = new HRDepartment();

        // Create observers
        PayrollDepartment payrollDepartment = new PayrollDepartment();
        ITDepartment itDepartment = new ITDepartment();

        // Register observers to subject
        hrDepartment.RegisterObserver(payrollDepartment);
        hrDepartment.RegisterObserver(itDepartment);

        // Perform some actions
        hrDepartment.HireEmployee("Kaan Boyaci");
        hrDepartment.FireEmployee("Karan Boyaci");
        Console.ReadLine();
    }
}
