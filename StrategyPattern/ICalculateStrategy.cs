namespace StrategyPattern;

internal interface ICalculateStrategy : ICalculateBehaviour{
    string Name { get; set; }
}