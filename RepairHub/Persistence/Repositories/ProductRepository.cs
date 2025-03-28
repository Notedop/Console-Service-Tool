using ConsoleServiceTool.RepairHub.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Persistence.Repositories
{
    internal sealed class ProductRepository(DbContext dbContext) : Repository<Product, long>(dbContext), IProductRepository;
}
