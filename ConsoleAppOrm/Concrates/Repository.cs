using ConsoleAppOrm.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConsoleAppOrm.Concrates
{
    class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly DbContext db;

        public Repository(DbContext db)
        {
            this.db = db;
        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>().AsQueryable();
        }

        public T? Get(Expression<Func<T, bool>> expression = null)
        {
            if (expression is null)
                return db.Set<T>().FirstOrDefault();

            return db.Set<T>().FirstOrDefault(expression);
        }

        public T Add(T entry)
        {
            db.Add(entry);

            return entry;
        }

        public T Edit(T entry)
        {
            db.Entry(entry).State = EntityState.Modified;
            return entry;
        }

        public void Remove(T entry)
        {
            db.Remove(entry);
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
