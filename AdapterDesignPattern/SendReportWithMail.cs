partial class Program
{
    public class SendReportWithMail : IEmployee
    {
        private string _report;
        public string Report
        {
            get { return _report; }
            set { _report = value; }
        }

        public void SendReport()
        {
            Console.WriteLine("{0} -> Report sent with Mail", Report);
        }
    }
}
