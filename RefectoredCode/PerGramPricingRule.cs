using SOLID.OpenClosed.OpenClosedNormal;

namespace SOLID.OpenClosed.RefectoredCode
{
    public class PerGramPricingRule:IPricingRule
    {
        public decimal CalcultorPrice(OrderItem item)
        {
            return item.Quantity * 4m/1000;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.StockKeepingUnit.StartsWith("WEIGHT");
        }
    }
}
