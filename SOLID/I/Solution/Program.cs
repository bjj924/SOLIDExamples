using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I.Solution
{
    internal class Program
    {
        public static void Main()
        {
            BurguerOrderService service = new BurguerOrderService();
            service.OrderBurger(2);
        }
    }
}
