using ConsoleServiceTool.RepairHub.Persistence.Entities;

namespace ConsoleServiceTool.RepairHub.Services;

public interface IService<TViewModel> 
{
    List<TViewModel> GetAll();
    void Add(TViewModel viewModel);
    void AddAll(List<TViewModel> viewModel);
    void Update(TViewModel viewModel);
    void UpdateAll(List<TViewModel> viewModel);
    void Remove(TViewModel viewModel);
    void RemoveAll(List<TViewModel> viewModel);
    void SaveChanges();
}