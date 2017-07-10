using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.OpenClosedNormal
{
        public class Cart
        {
            private readonly List<OrderItem> _items;

            public string CustomerEmail { get; set; }
            public Cart()
            {
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
                    if (orderItem.StockKeepingUnit.StartsWith("EACH"))
                    {
                        total += orderItem.Quantity * 5m;
                    }
                    else if (orderItem.StockKeepingUnit.StartsWith("WEIGHT"))
                    {
                        total += orderItem.Quantity * 4m/1000;
                    }

                    else if (orderItem.StockKeepingUnit.StartsWith("SPECIAL"))
                    {
                        total += orderItem.Quantity * 4m;
                        int setOfThree = orderItem.Quantity / 3;
                        total -= setOfThree * 0.2m;
                    }

                }
                return total;
            }
    }
}
