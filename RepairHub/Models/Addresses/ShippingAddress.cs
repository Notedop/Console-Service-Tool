namespace ConsoleServiceTool.RepairHub.Models.Addresses;

public class ShippingAddress : AddressBase
{
    private ShippingAddress()
    {
        this.AddressType = AddressType.Shipping;
    }
}