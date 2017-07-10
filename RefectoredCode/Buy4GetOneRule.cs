using SOLID.OpenClosed.OpenClosedNormal;

namespace SOLID.OpenClosed.RefectoredCode
{
    public class Buy4GetOneRule : IPricingRule
    {
        public decimal CalcultorPrice(OrderItem item)
        {
            decimal total = 0;
            total += item.Quantity * 1m;
            int setOfFive = item.Quantity / 5;
            return total -= setOfFive * 1m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.StockKeepingUnit.StartsWith("B4GO");
        }
    }
}
