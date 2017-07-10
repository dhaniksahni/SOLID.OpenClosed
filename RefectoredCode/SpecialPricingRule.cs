using SOLID.OpenClosed.OpenClosedNormal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.RefectoredCode
{
    public class SpecialPricingRule : IPricingRule
    {
        public decimal CalcultorPrice(OrderItem item)
        {
            decimal total = 0;
            total += item.Quantity * 4m;
            int setOfThree = item.Quantity / 3;
            return total -= setOfThree * 0.2m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.StockKeepingUnit.StartsWith("SPECIAL");
        }
    }
}
