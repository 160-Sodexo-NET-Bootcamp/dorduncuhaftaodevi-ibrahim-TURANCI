using DataAccses.Context;
using DataAccses.Repos.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProContext context;

        public UnitOfWork(ProContext context)
        {
            this.context = context;
            Products = new ProductRepository(context);
        }
        public IProductRepository Products { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }
    }
}
