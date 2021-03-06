using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Problem
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>(); // Get orders from data source

            ReportingService services = new ReportingService();
            services.GenerateReport(orders, ReportType.GetType.PDF);
        }
    }
}
