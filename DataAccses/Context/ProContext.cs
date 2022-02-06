using DataAccses.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Context
{
    public class ProContext : DbContext
    {
        public ProContext(DbContextOptions<ProContext> options ) : base(options)
        {
          
        }

        public DbSet<Product> Products { get; set; }
    }
}
