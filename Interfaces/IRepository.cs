using System.Collections.Generic;
using System.Threading.Tasks;

namespace tut01.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> FindAll();
        Task<T> Add(T entity);
        Task<T> Delete(int id);
        Task<T> FindById(int id);
    }
}