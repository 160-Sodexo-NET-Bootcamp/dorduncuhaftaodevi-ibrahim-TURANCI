using Hangfire;
using Jobs.ProJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.JobsManagers
{
    public static class ProductManager
    {
        public static void NewProduct()
        {
            RecurringJob.AddOrUpdate<ProductJobs>(x => x.AddProduct(), "*/15 * * * *");
        }

        public static void UpdateProduct()
        {
            RecurringJob.AddOrUpdate<ProductJobs>(x => x.UpdateProduct(), "00 18 * * *",TimeZoneInfo.Local);
        }
    }
}
