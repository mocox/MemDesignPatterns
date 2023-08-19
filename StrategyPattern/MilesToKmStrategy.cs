
namespace StrategyPattern;

internal class MilesToKmStrategy: ICalculateStrategy
{
    public string Name { get; set; } = "MilesToKm";
    public string Calculate(double value)
    {
        return $"{value} miles is {(value * 8) / 5} Km." ;
    }
}