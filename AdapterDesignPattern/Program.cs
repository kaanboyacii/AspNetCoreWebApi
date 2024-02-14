using System;
using static Program;

partial class Program
{
    static void Main(string[] args)
    {
        SendReportWithSMS sendReportWithSMS = new SendReportWithSMS { Report = "Report 1" };


        IEmployee[] reports = {
            new SendReportWithEmail{Report="Report 1 with email" },
            new SendReportWithMail{Report="Report 1 with mail" },
            new SendReportWithSMSAdapter(sendReportWithSMS)
        };

        foreach (IEmployee report in reports)
            report.SendReport();

        Console.ReadKey();
    }
}


