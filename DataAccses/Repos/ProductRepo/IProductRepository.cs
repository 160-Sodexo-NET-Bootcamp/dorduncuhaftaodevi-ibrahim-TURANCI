using DataAccses.DataModels;
using DataAccses.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Repos.ProductRepo
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
