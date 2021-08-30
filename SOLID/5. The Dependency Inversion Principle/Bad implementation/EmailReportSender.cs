using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._5._The_Dependency_Inversion_Principle.Bad_implementation
{
    class EmailReportSender
    {
        public void Send(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
