// Concrete strategy
public class YearlySalaryStrategy : ISalaryStrategy
{
    public double CalculateSalary(double baseSalary)
    {
        return baseSalary * 12;
    }
}
