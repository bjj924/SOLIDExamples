using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Solution
{
    interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
