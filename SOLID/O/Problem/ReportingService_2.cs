using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Problem
{
    internal class ReportingService_2
    {
        public void GenerateReport(List<Order> orders, ReportType_2.GetType type)
        {
            //Generic code to create a report

            //Specific conversion depending on type

            if (type == ReportType_2.GetType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType_2.GetType.EXCEL)
            {
                CreateExcelReport(orders);
            }
            else if (type == ReportType_2.GetType.JSON)
            {
                CreateJsonReport(orders);
            }
            else if (type == ReportType_2.GetType.XML)
            {
                CreateXMLReport(orders);
            }
        }

        private void CreateXMLReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        private void CreateJsonReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        private void CreateExcelReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        private void CreatePDFReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }
    }

    internal class ReportType_2
    {
            public enum GetType
            {
                PDF = 1,
                EXCEL = 2,
                JSON = 3,
                XML = 4
            }
    }
}
