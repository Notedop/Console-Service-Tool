using System.ComponentModel;
using System.Data;
using ConsoleServiceTool.RepairHub.Persistence.Entities;
using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;
using ConsoleServiceTool.RepairHub.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Services;

public class PartDefinitionService : Service<PartDefinitionVM, PartDefinition, long>
{
    private readonly PartAttributeDefinitionService _partAttributeDefinitionService;

    public PartDefinitionService(IRepository<PartDefinition, long> repository, PartAttributeDefinitionService partAttributeDefinitionService) : base(repository)
    {
        _partAttributeDefinitionService = partAttributeDefinitionService;
    }

    public override IQueryable<PartDefinition> GetQuery()
    {
        return base.GetQuery()
            .Include(p => p.PartAttributes)
            .ThenInclude(pa => pa.PartAttributeDefinition)
            .Include(p => p.PartType);
    }

    public override PartDefinitionVM GetById(long id)
    {
        return ToViewModel(GetQuery().SingleOrDefault(p => p.Id.Equals(id)) ?? throw new DataException("Unable to find object with Id"));
    }

    public override List<PartDefinitionVM> GetAll()
    {
        return ToViewModel(GetQuery().ToList());
    }

    public override PartDefinitionVM ToViewModel(PartDefinition entity)
    {
        var vm = new PartDefinitionVM
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            PartTypeId = entity.PartTypeId,
            PartTypeName = entity.PartType.Name,
            PartTypeDescription = entity.PartType.Description
        };

        if (entity.PartAttributes.Count > 0)
        {
            vm.PartAttributes = new BindingList<PartAttributeVM>();
            foreach (var partAttribute in entity.PartAttributes)
            {
                vm.PartAttributes.Add(
                    new PartAttributeVM
                    {
                        PartDefinitionId = partAttribute.PartDefinitionId,
                        IsRequired = partAttribute.IsRequired,
                        Id = partAttribute.PartAttributeDefinition.Id,
                        Description = partAttribute.PartAttributeDefinition.Description,
                        Name = partAttribute.PartAttributeDefinition.Name
                    }
                );
            }
        }


        return vm;
    }

    internal override PartDefinition ToEntity(PartDefinitionVM viewModel)
    {
        var entity = new PartDefinition
        {
            Id = viewModel.Id,
            Name = viewModel.Name,
            Description = viewModel.Description,
            PartTypeId = viewModel.PartTypeId,
            PartType = new PartType
            {
                Id = viewModel.PartTypeId,
                Description = viewModel.PartTypeDescription,
                Name = viewModel.PartTypeName
            }
        };

        if (viewModel.PartAttributes.Count > 0)
        {
            entity.PartAttributes = new List<PartDefinitionPartAttributeDefinition>();
            foreach (var attributeVm in viewModel.PartAttributes)
            {
                entity.PartAttributes.Add(new PartDefinitionPartAttributeDefinition
                {
                    PartDefinitionId = attributeVm.PartDefinitionId,
                    IsRequired = attributeVm.IsRequired,
                    PartAttributeDefinitionId = attributeVm.Id,
                    PartAttributeDefinition = _partAttributeDefinitionService.ToEntity(attributeVm)
                });
            }
        }


        return entity;
    }
}

public class PartDefinitionVM  : Model<long>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required long PartTypeId { get; set; }
    public required string PartTypeName { get; set; }
    public required string PartTypeDescription { get; set; }
    public BindingList<PartAttributeVM> PartAttributes { get; set; }

}

public class PartAttributeVM : PartAttributeDefinitionVM
{
    public required long PartDefinitionId { get; set; }
    public required bool IsRequired { get; set; }
}