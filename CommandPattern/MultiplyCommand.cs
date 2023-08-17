namespace CommandPattern;

public class MultiplyCommand : ICommand
{
    private readonly double _valueToMultiply;

    public MultiplyCommand(double valueToMultiply)
    {
        _valueToMultiply = valueToMultiply;
    }

    public double Execute(double value) => value *= _valueToMultiply;

    public double Undo(double value) => value /= _valueToMultiply;
}