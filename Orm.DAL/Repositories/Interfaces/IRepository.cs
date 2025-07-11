using Orm.Core.Entities.Common;

namespace Orm.DAL.Repositories.Interfaces;


public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task AddAsync(TEntity entity);
    Task DeleteAsync(int id);
    Task UpdateAsync(int id);
    Task<TEntity> GetByIdAsync(int id);
    Task<List<TEntity>> GetAllAsync();
}