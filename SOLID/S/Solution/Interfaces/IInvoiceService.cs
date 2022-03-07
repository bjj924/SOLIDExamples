using SOLID.S.Solution.Models;

namespace SOLID.S.Solution.Interfaces
{
    public interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }
}
