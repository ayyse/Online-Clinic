using System;
using System.Linq;
using System.Linq.Expressions;

namespace Online_Clinic.Data.Concrats
{
    //abstract class'lar ve interface'ler newlenemez bu yüzden sadece normal sınıfların gelmesi için aşağıda new() ibaresini belirttim.
    public interface IRepositoryBase<T> where T : class, new()
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string includeProperties = null);

        T Get(int id);

        T GetFirstorDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);

    }
}
