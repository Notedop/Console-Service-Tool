namespace ConsoleServiceTool.RepairHub.Models.Parts;

public class PartsBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<PartAttributes> PartAttributes { get; set; }

}