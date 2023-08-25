using DecoratorPattern.Interfaces;

namespace DecoratorPattern;

internal class TaxDecorator: ItemDecorator
{
    public TaxDecorator(IItem item) : base(item)
    {
    }

    // add tax as a percentage of price, for example 10% tax is 10.00
    public void AddTax(double tax)
    {
        var currentPrice = GetPrice();
        var taxToAdd = currentPrice * (tax/100);
       
        AddPrice(taxToAdd);
    }

    
}