using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Persistence.Repositories
{
    internal class PartDefinitionRepository(DbContext dbContext) : Repository<PartDefinition, long>(dbContext), IPartDefinitionRepository;
}