// Context class
public class Employee
{
    private ISalaryStrategy _salaryStrategy;

    public Employee(ISalaryStrategy salaryStrategy)
    {
        _salaryStrategy = salaryStrategy;
    }

    public void SetSalaryStrategy(ISalaryStrategy salaryStrategy)
    {
        _salaryStrategy = salaryStrategy;
    }

    public double CalculateSalary(double baseSalary)
    {
        return _salaryStrategy.CalculateSalary(baseSalary);
    }
}
