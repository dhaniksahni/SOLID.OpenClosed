using SOLID.OpenClosed.OpenClosedNormal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.RefectoredCode
{
    public interface IPricingCalculator
    {
        decimal CalCulatePrice(OrderItem item);
    }
}
