using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderStores.Domain.Repository;
using OrderStores.Domain.Interfaces;
using OrderStores.Domain.Models;

namespace OrderStores.Domain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }

        public UnitOfWork(ApplicationDbContext bookStoreDbContext,
            IOrderRepository booksRepository,
            IProductRepository catalogueRepository)
        {
            this._context = bookStoreDbContext;

            this.Orders = booksRepository;
            this.Products = catalogueRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
