using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Solution
{
    internal class AnyOtherMonitoringService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
            //Code To eventLog
        }
    }
}
