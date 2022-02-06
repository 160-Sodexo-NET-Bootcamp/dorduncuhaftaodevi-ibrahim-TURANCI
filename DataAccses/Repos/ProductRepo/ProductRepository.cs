using DataAccses.Context;
using DataAccses.DataModels;
using DataAccses.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Repos.ProductRepo
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProContext context) : base(context)
        {

        }
    }
}
