// Concrete strategy
public class MonthlySalaryStrategy : ISalaryStrategy
{
    public double CalculateSalary(double baseSalary)
    {
        return baseSalary * 1;
    }
}
