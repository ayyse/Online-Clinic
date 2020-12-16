using Microsoft.EntityFrameworkCore;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Online_Clinic.Data.Implementation
{
    public class Repository<T> : IRepositoryBase<T> where T : class, new()
    {
        private readonly ClinicContext _ctx;
        internal DbSet<T> dbSet;

        public Repository(ClinicContext ctx)
        {
            _ctx = ctx;
            this.dbSet = ctx.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);

            }
            if (includeProperties != null)
            {
                foreach(var item in includeProperties.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            if(orderby != null)
            {
                return orderby(query);
            }
            return query;
        }

        public T GetFirstorDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);

            }
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
