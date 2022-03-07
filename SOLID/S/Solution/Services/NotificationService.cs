using SOLID.S.Solution.Interfaces;
using SOLID.S.Solution.Models;

namespace SOLID.S.Solution.Services
{
    public class NotificationService: INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            // Code to email the invoice to the user
            return true;
        }
    }
}
