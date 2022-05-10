using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStores.Domain.Repository;
using OrderStores.Domain.Interfaces;
using OrderStores.Domain.Models;

namespace OrderStores.Domain.Repository
{
    class ProductRepository : IGenericRepository<Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
