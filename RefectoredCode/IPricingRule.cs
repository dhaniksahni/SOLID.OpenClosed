using SOLID.OpenClosed.OpenClosedNormal;

namespace SOLID.OpenClosed.RefectoredCode
{
    public interface IPricingRule
    {
        bool IsMatch(OrderItem item);
        decimal CalcultorPrice(OrderItem item);
    }
}
