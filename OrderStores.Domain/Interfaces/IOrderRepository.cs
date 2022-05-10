using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStores.Domain.Models;

namespace OrderStores.Domain.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName);
    }
}
