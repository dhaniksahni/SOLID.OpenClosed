using SOLID.OpenClosed.OpenClosedNormal;
using SOLID.OpenClosed.RefectoredCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.RefectoredCode
{
    public class Cart
    {
        private readonly List<OrderItem> _items;
        public IPricingCalculator _pricingCalculator;

        public string CustomerEmail { get; set; }

        public Cart() : this(new PricingCalcultaor())
        {

        }
        public Cart(IPricingCalculator pricingCalculator)
        {
            _pricingCalculator = pricingCalculator;
            _items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0;
            foreach (OrderItem orderItem in Items)
            {
                total += _pricingCalculator.CalCulatePrice(orderItem);

            }
            return total;
        }
    }
}
