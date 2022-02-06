using DataAccses.Repos.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.UoW
{
   public interface IUnitOfWork
    {
        public IProductRepository Products { get; }
        int Complete();
    }
}
