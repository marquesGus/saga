using saga.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace saga.Dal.Repository
{
    public class Repository<T> 
        : IDisposable, IRepository<T> where T : class
    {
        private readonly SagaContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(SagaContext context)
        {
            _context = context;            
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public  virtual void Add(T item)
        {
            _dbSet.Add(item);
        }

        public virtual void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
