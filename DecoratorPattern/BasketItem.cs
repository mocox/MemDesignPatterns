using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

internal class BasketItem : IItem
{
    private double Price { get; set; }

    public void AddPrice(double price)
    {
        Price += price;
    }

    public double GetPrice()
    {
        return Price;
    }
}