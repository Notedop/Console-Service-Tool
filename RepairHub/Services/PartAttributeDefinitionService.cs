using ConsoleServiceTool.RepairHub.Persistence.Entities;
using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;
using ConsoleServiceTool.RepairHub.Persistence.Repositories;

namespace ConsoleServiceTool.RepairHub.Services;

public class PartAttributeDefinitionService : Service<PartAttributeDefinitionVM, PartAttributeDefinition, long>
{
    public PartAttributeDefinitionService(IRepository<PartAttributeDefinition, long> repository) : base(repository)
    {
    }

    public override PartAttributeDefinitionVM ToViewModel(PartAttributeDefinition entity)
    {
        return new PartAttributeDefinitionVM
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description
        };
    }

    internal override PartAttributeDefinition ToEntity(PartAttributeDefinitionVM viewModel)
    {
        return new PartAttributeDefinition
        {
            Id = viewModel.Id,
            Name = viewModel.Name,
            Description = viewModel.Description
        };
    }
}

public class PartAttributeDefinitionVM : Model<long>

{
    public required string Name { get; set; }
    public required string Description { get; set; }
}