using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5._The_Dependency_Inversion_Principle.Good_implementation
{
    public interface IReportSender
    {
        public void Send(Report report);
    }
}
