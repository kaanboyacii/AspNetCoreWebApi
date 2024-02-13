
// Subject interface
public interface IEmployeeManagementSystem
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(string message);
}
