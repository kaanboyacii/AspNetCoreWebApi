partial class Program
{
    public interface IEmployee
    {
        string Report { get; set; }
        void SendReport();
    }
}
