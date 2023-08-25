using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

internal abstract class ItemDecorator : IItem
{
    public string Name { get; set; }
    private readonly IItem _item;

    protected ItemDecorator(IItem item)
    {
        _item = item;
        Name = item.Name;
    }
    
    public virtual void AddPrice(double price)
    {
        _item.AddPrice(price);
    }

    public virtual double GetPrice()
    {
        return _item.GetPrice();
    }
}