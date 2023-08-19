namespace StrategyPattern;

internal class Converter
{
    private readonly ICalculateStrategy _strategy;

    public Converter(ICalculateStrategy strategies)
    {
        _strategy = strategies;
    }

    public string Execute(double value)
    {
        return _strategy.Calculate(value);
    }
}