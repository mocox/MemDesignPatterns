namespace StrategyPattern;

internal class CmsToInchesStrategy: ICalculateStrategy
{
    public string Name { get; set; } = "CmsToInches";
    public string Calculate(double value)
    {
        return $"{value} cms is {value / 2.54} inches";
    }

}