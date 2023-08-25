namespace DecoratorPattern;

internal class DiscountDecorator : ItemDecorator
{
    public void AddDiscount(double discount)
    {
        base.AddPrice(-discount);
    }
}