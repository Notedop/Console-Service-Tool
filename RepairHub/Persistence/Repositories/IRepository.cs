using System.Linq.Expressions;
using ConsoleServiceTool.RepairHub.Persistence.Entities;

namespace ConsoleServiceTool.RepairHub.Persistence.Repositories;

public interface IRepository<TEntity, TIdType> 
    where TEntity : Model<TIdType> 
    where TIdType : struct
{
    Task<TEntity?> GetByIdAsync(TIdType id);
    List<TEntity> GetAll();
    TEntity GetByExpression(Expression<Func<TEntity, bool>> expression);
    void AddAll(List<TEntity> entities);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void UpdateAll(List<TEntity> entities);
    void Remove(TEntity entity);
    void RemoveAll(List<TEntity> entities);
    int SaveChanges();
    TEntity? GetById(TIdType id);
    IQueryable<TEntity> Query();
}