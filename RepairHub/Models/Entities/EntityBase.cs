using ConsoleServiceTool.RepairHub.Models.Addresses;

namespace ConsoleServiceTool.RepairHub.Models.Entities;

public abstract class EntityBase
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required EntityType EntityType { get; set; }
    public required HomeAddress HomeAddress { get; set; }
    public required ShippingAddress ShippingAddress { get; set; }
    public required BillingAddress BillingAddress { get; set; }
}