using System.Linq.Expressions;
using ConsoleServiceTool.RepairHub.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Persistence.Repositories
{
    internal abstract class Repository<TEntity, TIdType> : IRepository<TEntity, TIdType> where TEntity : Model<TIdType>
        where TIdType : struct
    {
        protected readonly DbContext dbContext;

        protected Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<TEntity> Query()
        {
            return dbContext.Set<TEntity>().AsQueryable();
        }
        public virtual TEntity? GetById(TIdType id)
        {
            return Query().SingleOrDefault(p => p.Id.Equals(id));
        }

        public Task<TEntity?> GetByIdAsync(TIdType id)
        {
            return Query().SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public virtual List<TEntity> GetAll()
        {
            return Query().ToList();
        }

        public virtual TEntity? GetByExpression(Expression<Func<TEntity, bool>> expression)
        {
            Query().Where(expression).ToList();
            return Query().SingleOrDefault(expression);
        }

        public virtual void AddAll(List<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);
        }

        public virtual void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
        }

        public virtual void UpdateAll(List<TEntity> entities)
        {
            dbContext.Set<TEntity>().UpdateRange(entities);
        }

        public virtual void Remove(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public virtual void RemoveAll(List<TEntity> entities)
        {
            dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}