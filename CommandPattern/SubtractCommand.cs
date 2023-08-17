namespace CommandPattern;

public class SubtractCommand : ICommand
{
    private readonly double _valueToSubtract;

    public SubtractCommand(double valueToAdd)
    {
        _valueToSubtract = valueToAdd;
    }

    public double Execute(double value) => value -= _valueToSubtract;

    public double Undo(double value) => value += _valueToSubtract;
}