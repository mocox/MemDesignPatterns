namespace StrategyPattern;

internal class InchesToCmsStrategy: ICalculateStrategy
{
    public string Name { get; set; } = "InchesToCms";

    public string Calculate(double value)
    {
        return $"{value} inches is {2.54 * value} cms.";
    }


}