using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

internal class ItemDecorator : IItem
{
    private IItem _item = null!;

    public void SetItem(IItem item)
    {
        _item = item;
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