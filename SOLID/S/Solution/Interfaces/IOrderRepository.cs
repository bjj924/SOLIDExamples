using SOLID.S.Solution.Models;

namespace SOLID.S.Solution.Interfaces
{
    public interface IOrderRepository
    {
        bool InsertOrder(Order order);
    }
}
