
namespace StrategyPattern;

internal class KmToMilesStrategy: ICalculateStrategy
{
    public string Name { get; set; } = "KmToMiles";
    public string Calculate(double value)
    {
        return $"{value} Km is {(value * 5) / 8} miles." ;
    }
}