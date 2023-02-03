using System.Linq.Expressions;
using Contact.Domain.Abstracts;

namespace Contact.Application.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetById(Guid id);
    IQueryable<TEntity> All();
    IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
    Task<Guid> Save(TEntity entity);
    Task<int> Count(Expression<Func<TEntity, bool>> predicate);
    Task<bool> Any(Expression<Func<TEntity, bool>> predicate);
    Task<IList<TEntity>> FilterBy(Expression<Func<TEntity, bool>> predicate);
    TEntity Update(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
}