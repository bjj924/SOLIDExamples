using System;
using System.IO;

namespace SOLID.S.Problem
{
    internal class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);

                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt", "The order has been complete");
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.Message);
            }
        }

        private bool InsertOrder(Order order)
        {
            // Code To insert order in the Data Base
            return true;
        }

        private Invoice CreateInvoice(Order order)
        {
            // Code to create the invoice
            return new Invoice();
        }

        private bool EmailInvoice(Invoice invoice)
        {
            // Code to email the invoice to the user
            return true;
        }
    }

    public class Order
    {
        public int Id { get; set; }
    }

    public class Invoice
    {
    }
}
