namespace ConsoleServiceTool.RepairHub.Models.Addresses;

public class BillingAddress : AddressBase
{
    private BillingAddress()
    {
        this.AddressType = AddressType.Billing;
    }
}