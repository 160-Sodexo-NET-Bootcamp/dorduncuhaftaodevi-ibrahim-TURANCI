using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.DataModels
{
   public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public bool Status{ get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
