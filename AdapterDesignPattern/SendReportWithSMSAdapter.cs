partial class Program
{
    public class SendReportWithSMSAdapter : IEmployee
    {
        private SendReportWithSMS _sendReportWithSMS;

        public SendReportWithSMSAdapter(SendReportWithSMS sendReportWithSMS)
        {
            _sendReportWithSMS = sendReportWithSMS;
        }
        public string Report
        {
            get { return _sendReportWithSMS.Report; }
            set { _sendReportWithSMS.Report = value; }
        }

        public void SendReport()
        {
            Console.WriteLine("{0} -> Report sent with SMS", Report);
        }
    }
}
