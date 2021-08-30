using System;
using System.Collections.Generic;

namespace SOLID._5._The_Dependency_Inversion_Principle.Bad_implementation
{
    public class Reporter
    {
        public void SendReports()
        {
            var reportBuilder = new ReportBuilder(); // this is bad due to the fact that depends on specific class
            IList<Report> reports = reportBuilder.CreateReports();

            if (reports.Count == 0)
                throw new NoReportsException();

            var reportSender = new EmailReportSender(); // this is bad due to the fact that depends on specific class
            foreach (var report in reports)
            {
                reportSender.Send(report);
            }
        }
    }
}
