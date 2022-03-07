using SOLID.S.Solution.Interfaces;
using SOLID.S.Solution.Models;

namespace SOLID.S.Solution.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            // Code To insert order in the Data Base
            return true;
        }
    }
}
