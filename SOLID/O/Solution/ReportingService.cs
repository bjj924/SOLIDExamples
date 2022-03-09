using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Solution
{
    internal class ReportingService
    {
        private readonly IReportGenerator _reportGenerator;

        public ReportingService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport(List<Order> orders)
        {
            _reportGenerator.CreateReport(orders);
        }
    }
}
