using Microsoft.EntityFrameworkCore;
using OrderStores.Domain.Interfaces;
using OrderStores.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStores.Domain.Repository;



namespace OrderStores.Domain.Repository
{
    public class OrderRepository : IGenericRepository<Order>, IOrderRepository
    {
        private ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName)
        {
            return await _context.Orders.Where(c => c.OrderDetails.Contains(orderName)).ToListAsync();
        }


        public Task Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        /*public Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName)
        {
            throw new NotImplementedException();
        }*/

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}