namespace DecoratorPattern;

internal class TaxDecorator: ItemDecorator
{
    // add tax as a percentage of price, for example 10% tax nis 10.00
    public void AddTax(double tax)
    {
        var currentPrice = GetPrice();
        var taxToAdd = currentPrice * (tax/100);
       
        base.AddPrice(taxToAdd);
    }
}