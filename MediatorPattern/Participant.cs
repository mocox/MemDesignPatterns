namespace MediatR01;

public abstract class Participant : IParticipant
{
    private readonly IMediator _mediator;
    protected readonly string Key;

    protected Participant(IMediator mediator, string key)
    {
        _mediator = mediator;
        Key = key;
    }

    public virtual void SendCommand<T>(string receiver, string message, T payload)
    {
        
    }
    
    public virtual void SendCommand(string receiver, string command)
    {
        _mediator.SendCommand(receiver, Key, command);
    }

    public virtual void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Executing command {command}, issues by {sender}");
    }

    public virtual void ReceiveCommand<T>(string sender, string command, T payLoad)
    {
        Console.WriteLine($"Executing command {command}, issues by {sender} with payload {nameof(T)}");
    }
}