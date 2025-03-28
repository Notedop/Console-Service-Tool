using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Persistence.Repositories
{
    internal class PartAttributeDefinitionRepository(DbContext dbContext) : Repository<PartAttributeDefinition, long>(dbContext), IPartAttributeDefinitionRepository;
}
