using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

internal class BasketItem : IItem
{
    public string Name { get; set; }
    private double Price { get; set; }

    public BasketItem(string name)
    {
        Name = name;
    }

    public void AddPrice(double price)
    {
        Price += price;
    }

    public double GetPrice()
    {
        return Price;
    }
}