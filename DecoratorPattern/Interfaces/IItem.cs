namespace DecoratorPattern.Interfaces;

internal interface IItem
{
    string Name { get; set; }
    void AddPrice(double price);
    double GetPrice();
}