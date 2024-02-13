
// Concrete Observer
public class PayrollDepartment : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Payroll department received notification: {message}");
    }
}
