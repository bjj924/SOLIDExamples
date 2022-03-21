using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Solution
{
    public class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            //TODO: code to create the order

            // Send Notification to datadog
            _eventNotificationService.LogEvent("The order was succesfully created");
        }
    }

    public class Order
    {
    }
}
