using DataAccses.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccses.Repos.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected ProContext context;
        internal DbSet<T> dbSet;


        public GenericRepository(ProContext context)
        {

            this.context = context;

            dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
           dbSet.Update(entity);
        }

        public void UpdateAll(List<T> entities)
        {
            dbSet.UpdateRange(entities);
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> where)
        {          
           return dbSet.Where(where).ToList();           
        }
    }
}
