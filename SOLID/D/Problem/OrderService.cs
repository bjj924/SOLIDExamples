using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Problem
{
    public class DataDogService
    {
        public void LogEvent(string message)
        {
            //Code To eventLog
        }
    }

    public class OrderService
    {
        private readonly DataDogService _dataDogService;

        public OrderService(DataDogService dataDogService)
        {
            _dataDogService = dataDogService;
        }

        public void GenerateOrder(Order order)
        {
            //TODO: code to create the order

            // Send Notification to datadog
            _dataDogService.LogEvent("The order was succesfully created");
        }
    }

    public class Order
    {
    }
}
