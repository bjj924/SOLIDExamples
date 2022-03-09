using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Problem
{
    public class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType.GetType type)
        {
            //Generic code to create a report

            //Specific conversion depending on type

            if (type == ReportType.GetType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType.GetType.EXCEL)
            {
                CreateExcelReport(orders);
            }
        }

        private void CreatePDFReport(List<Order> orders)
        {
            //Create PDF Report
            throw new NotImplementedException();
        }

        private void CreateExcelReport(List<Order> orders)
        {
            //Create Excel Report
            throw new NotImplementedException();
        }
    }

    public class Order
    {
    }
     
    public class ReportType
    {
        public enum GetType
        {
            PDF = 1,
            EXCEL = 2
        }
    }
}
