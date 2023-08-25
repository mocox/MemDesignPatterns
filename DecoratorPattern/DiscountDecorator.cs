using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

internal class DiscountDecorator : ItemDecorator
{

    public DiscountDecorator(IItem item) : base(item)
    {
    }

    public void AddDiscount(double discount)
    {
        AddPrice(-discount);
    }


}