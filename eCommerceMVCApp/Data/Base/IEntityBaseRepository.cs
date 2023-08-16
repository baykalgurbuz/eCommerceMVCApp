using eCommerceMVCApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerceMVCApp.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> ActorGetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateASync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
