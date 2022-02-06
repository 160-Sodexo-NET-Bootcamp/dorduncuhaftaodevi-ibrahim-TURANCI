using DataAccses.DataModels;
using DataAccses.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.ProJobs
{
   public class ProductJobs 
    {
        private readonly UnitOfWork unitOfWork;

        public ProductJobs(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;      
        }

        public void AddProduct()
        {
            var product = new Product()
            {
                ProductName = "asdf",
                Status = false,
                CreatedDate = DateTime.Now
            };

            unitOfWork.Products.Add(product);
            unitOfWork.Complete();


        }

        public void UpdateProduct()
        {
            var products = unitOfWork.Products.Where(p => p.CreatedDate.Date == DateTime.Now.Date).ToList();
            foreach (var product in products)
            {
                product.Status = true;
            }

            unitOfWork.Products.UpdateAll(products);
            unitOfWork.Complete();
        }

    }
}
