using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Solution
{
    class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>(); // Get orders from data source

            ReportingService services = new ReportingService(new ReportGeneratorPDF()); //Send implementation with the type
            services.GenerateReport(orders);
        }
    }
}
