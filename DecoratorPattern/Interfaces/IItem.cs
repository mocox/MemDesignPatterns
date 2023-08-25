namespace DecoratorPattern.Interfaces;

internal interface IItem
{
    void AddPrice(double price);
    double GetPrice();
}