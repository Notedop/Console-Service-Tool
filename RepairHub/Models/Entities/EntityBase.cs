using ConsoleServiceTool.RepairHub.Persistence.Entities.Addresses;

namespace ConsoleServiceTool.RepairHub.Models.Entities;

public abstract class EntityBase
{
    public required int EntityBaseId { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompany { get; set; }
    public required EntityType EntityType { get; set; }
    public required HomeAddress HomeAddress { get; set; }
    public required ShippingAddress ShippingAddress { get; set; }
    public required BillingAddress BillingAddress { get; set; }
}

public enum EntityType
{
    Customer,
    Seller,
    Owner,
    Buyer
}

public class CustomerEntity : EntityBase
{
    private CustomerEntity()
    {
        EntityType = EntityType.Customer;
    }

}

public class SellerEntity : EntityBase
{
    private SellerEntity()
    {
        EntityType = EntityType.Seller;
    }

}