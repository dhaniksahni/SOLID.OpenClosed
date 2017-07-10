using SOLID.OpenClosed.OpenClosedNormal;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OpenClosed.RefectoredCode
{
    public class PricingCalcultaor : IPricingCalculator
    {
        public readonly List<IPricingRule> _pricingRule;
        public PricingCalcultaor()
        {
            _pricingRule = new List<IPricingRule>();
            _pricingRule.Add(new EachPricingRule());
            _pricingRule.Add(new PerGramPricingRule());
            _pricingRule.Add(new SpecialPricingRule());
            _pricingRule.Add(new Buy4GetOneRule());
        }


        public decimal CalCulatePrice(OrderItem item)
        {
            return _pricingRule.First(r => r.IsMatch(item)).CalcultorPrice(item);
        }
    }
}
