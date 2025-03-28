namespace ConsoleServiceTool.RepairHub.Persistence.Entities.Addresses;

public abstract class AddressBase
{
    public required int Id { get; set; }
    public required AddressType AddressType { get; set; }
    public required string Name { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string StreetName { get; set; }
    public required string City { get; set; }
    public required string Region { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public required string PhoneNumber { get; set; }
    public required string EmailAddress { get; set; }

}
public enum AddressType
{
    Billing,
    Shipping,
    Home,
    Owner
}

public class HomeAddress : AddressBase
{
    public HomeAddress()
    {
        AddressType = AddressType.Home;
    }
}

public class ShippingAddress : AddressBase
{
    private ShippingAddress()
    {
        AddressType = AddressType.Shipping;
    }
}
public class BillingAddress : AddressBase
{
    private BillingAddress()
    {
        AddressType = AddressType.Billing;
    }
}