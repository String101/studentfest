using Microsoft.EntityFrameworkCore;
using studentfest.Data;
using studentfest.Interface;
using System.Linq.Expressions;

namespace studentfest.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly SqlContext _context;
        internal DbSet<T> _dbSet;

        public Repository(SqlContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public  bool Any(Expression<Func<T, bool>>? filter)
        {
          return  _dbSet.Any(filter);
        }

        public T Get(Expression<Func<T, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }

            return  query.FirstOrDefault();
        }


        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter , string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }

            return  query.ToList();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
