using System;
using TasksAPI.Entities;

namespace TasksAPI.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> RemoveEntityAsync(TEntity entity);
        Task<TEntity> RemoveEntityAsync(Guid id);
    }
}

