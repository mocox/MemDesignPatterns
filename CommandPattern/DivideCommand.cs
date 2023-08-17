namespace CommandPattern;

public class DivideCommand : ICommand
{
    private readonly double _valueToDivide;

    public DivideCommand(double valueToDivide)
    {
        _valueToDivide = valueToDivide;
    }
    
    public double Execute(double value) => value /= _valueToDivide;

    public double Undo(double value) => value *= _valueToDivide;
}