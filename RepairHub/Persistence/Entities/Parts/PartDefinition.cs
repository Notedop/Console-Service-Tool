namespace ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;

public class PartDefinition : Model<long>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public long PartTypeId { get; set; }
    public virtual PartType PartType { get; set; } = null!;

    public ICollection<PartDefinitionPartAttributeDefinition> PartAttributes { get; set; } = new List<PartDefinitionPartAttributeDefinition>();
}

public class PartType : Model<long>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}

public class PartAttributeDefinition : Model<long>
{
    public required string Name { get; set; }
    public required string Description { get; set; }

    public ICollection<PartDefinitionPartAttributeDefinition> PartDefinitions { get; set; } = new List<PartDefinitionPartAttributeDefinition>();
}

public class PartDefinitionPartAttributeDefinition
{
    public long PartDefinitionId { get; set; }
    public PartDefinition PartDefinition { get; set; } = null!;
    public long PartAttributeDefinitionId { get; set; }
    public PartAttributeDefinition PartAttributeDefinition { get; set; } = null!;
    public bool IsRequired { get; set; }
}