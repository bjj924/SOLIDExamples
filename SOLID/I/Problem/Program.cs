using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I.Problem
{
    internal class Program
    {
        public static void Main()
        {
            Problem.BurguerOrderService service = new Problem.BurguerOrderService();
            service.OrderBurger(2);
        }
    }
}
