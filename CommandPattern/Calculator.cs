namespace CommandPattern;

public class Calculator
{
    public double CurrentValue
    {
        get; private set;
    }

    private readonly Stack<ICommand> _commandHistory = new();

    public void ExecuteCommand(ICommand command)
    {
        CurrentValue = command.Execute(CurrentValue);
        _commandHistory.Push(command);
    }

    public void Undo()
    {
        var command = _commandHistory.Pop();
        CurrentValue = command.Undo(CurrentValue);
    }
}