using CAFSA.Domain.BaseEntity;
using System.Linq.Expressions;

namespace CAFSA.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {

        Task<OperationResult> GetEntityByIDAsync(int id);
        Task<OperationResult> AddEntityAsync(TEntity entity);
        Task<OperationResult> UpdateEntityAsync(TEntity entity);
        Task<OperationResult> DeleteEntityAsync(TEntity entity);
        Task<OperationResult> GetAllAsync();
        Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter);
        Task<bool> EntityExistsAsync(Expression<Func<TEntity, bool>> filter);
      
    }
}
