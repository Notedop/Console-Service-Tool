using System.Data;
using ConsoleServiceTool.RepairHub.Persistence.Entities;
using ConsoleServiceTool.RepairHub.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ConsoleServiceTool.RepairHub.Services;

public abstract class Service<TViewModel, TEntity, TId>(IRepository<TEntity, TId> repository)
    where TViewModel: Model<TId>
    where TEntity : Model<TId>
    where TId : struct
{
    protected readonly IRepository<TEntity, TId> Repository = repository;

    public virtual IQueryable<TEntity> GetQuery()
    {
        // Assuming your repository exposes an IQueryable via a method like Query()
        return Repository.Query();
    }
    public virtual TViewModel GetById(TId id) => ToViewModel(Repository.GetById(id) ?? throw new DataException("No object found with specified ID"));
    public virtual List<TViewModel> GetAll() => ToViewModel(GetQuery().ToList());

    public virtual List<TViewModel> GetAllExcept(List<TViewModel>? excludeList)
    {
        
        if (excludeList != null && excludeList.Any())
        {
            var excludeIds = excludeList.Select(e => e.Id).ToList();
            return ToViewModel(GetQuery().Where(item => !excludeIds.Contains(item.Id)).ToList());
        }
        else
        {
            return GetAll();
        }
        
    } 

    public virtual void Add(TViewModel viewModel) => Repository.Add(ToEntity(viewModel));

    public virtual void AddAll(List<TViewModel> viewModel) => Repository.AddAll(ToEntity(viewModel));

    public virtual void Update(TViewModel viewModel) => Repository.Update(ToEntity(viewModel));

    public virtual void UpdateAll(List<TViewModel> viewModel) => Repository.UpdateAll(ToEntity(viewModel));

    public virtual void Remove(TViewModel viewModel) => Repository.Remove(ToEntity(viewModel));

    public virtual void RemoveAll(List<TViewModel> viewModel) => Repository.RemoveAll(ToEntity(viewModel));

    public virtual void SaveChanges() => Repository.SaveChanges();

    public List<TViewModel> ToViewModel(List<TEntity> entities)
    {
        return entities.Select(ToViewModel).ToList();
    }

    public List<TEntity> ToEntity(List<TViewModel> entities)
    {
        return entities.Select(ToEntity).ToList();
    }

    public abstract TViewModel ToViewModel(TEntity entity);

    internal abstract TEntity ToEntity(TViewModel viewModel);
}