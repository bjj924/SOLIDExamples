using SOLID.S.Solution.Models;

namespace SOLID.S.Solution.Interfaces
{
    public interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }
}
