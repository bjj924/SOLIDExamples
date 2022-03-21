using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I.Problem
{
    internal class BurguerOrderService: IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            // Code to order a Burger
        }
        public void OrderSteak(int quantity) 
        {
            throw new NotImplementedException("Can't order a steak from this service");
        }
        public void OrderSalad(int quantity) 
        {
            throw new NotImplementedException("Can't order a salad from this service");
        }
    }
}
