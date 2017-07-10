using SOLID.OpenClosed.OpenClosedNormal;

namespace SOLID.OpenClosed.RefectoredCode
{
    public class EachPricingRule : IPricingRule
    {
        public decimal CalcultorPrice(OrderItem item)
        {
            return item.Quantity * 5m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.StockKeepingUnit.StartsWith("EACH");
        }
    }
}
