// Concrete strategy
public class HourlySalaryStrategy : ISalaryStrategy
{
    public double CalculateSalary(double baseSalary)
    {
        return baseSalary * 24;
    }
}
