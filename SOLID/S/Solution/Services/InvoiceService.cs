using SOLID.S.Solution.Interfaces;
using SOLID.S.Solution.Models;

namespace SOLID.S.Solution.Services
{
    public class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            // Code to create the invoice
            return new Invoice();
        }
    }
}
