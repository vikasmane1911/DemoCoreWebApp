using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Core.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task CreateAsync(TEntity entity);

        Task UpdateAsync(int id, TEntity entity);

        Task DeleteAsync(int id);
    }
}
