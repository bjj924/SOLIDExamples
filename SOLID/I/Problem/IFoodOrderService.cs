using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I.Problem
{
    interface IFoodOrderService
    {
        void OrderBurger(int quantity);
        void OrderSteak(int quantity);
        void OrderSalad(int quantity);
    }
}
