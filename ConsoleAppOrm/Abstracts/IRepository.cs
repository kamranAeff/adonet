using System.Linq.Expressions;

namespace ConsoleAppOrm.Abstracts
{
    public interface IRepository<T>
        where T : class
    {
        T Add(T entry);
        T Edit(T entry);
        void Remove(T entry);
        IQueryable<T> GetAll();
        T? Get(Expression<Func<T, bool>> expression = null);
        int Save();
    }
}
