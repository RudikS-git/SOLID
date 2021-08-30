using System;
using System.Collections.Generic;

namespace SOLID._5._The_Dependency_Inversion_Principle.Good_implementation
{
    public class Reporter
    {
        private readonly IReportBuilder _reportBuilder;
        private readonly IReportSender _reportSender;

        public Reporter(IReportBuilder reportBuilder, IReportSender reportSender)
        {
            _reportBuilder = reportBuilder;
            _reportSender = reportSender;
        }

        public void SendReports() // This method only depends on abstractions now
        {
            IList<Report> reports = _reportBuilder.CreateReports();

            if (reports.Count == 0)
                throw new NoReportsException();

            foreach (var report in reports)
            {
                _reportSender.Send(report);
            }
        }
    }
}
