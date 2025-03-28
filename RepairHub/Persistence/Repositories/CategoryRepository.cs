using ConsoleServiceTool.RepairHub.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Persistence.Repositories
{
    internal class CategoryRepository(DbContext dbContext) : Repository<Category, long>(dbContext), ICategoryRepository;
}
