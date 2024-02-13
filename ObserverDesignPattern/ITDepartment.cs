
// Concrete Observer
public class ITDepartment : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"IT department received notification: {message}");
    }
}
