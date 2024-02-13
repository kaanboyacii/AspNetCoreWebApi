
// Concrete Subject
public class HRDepartment : IEmployeeManagementSystem
{
    private List<IObserver> observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    public void HireEmployee(string employeeName)
    {
        Console.WriteLine($"{employeeName} has been hired.");
        NotifyObservers($"{employeeName} has been hired.");
    }

    public void FireEmployee(string employeeName)
    {
        Console.WriteLine($"{employeeName} has been fired.");
        NotifyObservers($"{employeeName} has been fired.");
    }
}
