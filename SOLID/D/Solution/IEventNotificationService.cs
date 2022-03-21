using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Solution
{
    public interface IEventNotificationService
    {
        void LogEvent(string message);
    }
}
