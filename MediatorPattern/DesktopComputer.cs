namespace MediatR01;

public class DesktopComputer : Participant
{
    public DesktopComputer(IMediator mediator, string key) : base(mediator, key)
    {
    }

    public override void SendCommand(string receiver, string command)
    {
        Console.WriteLine($"Desktop issued {command} to {receiver}");
        base.SendCommand(receiver, command);
    }
    
    public override void SendCommand<T>(string receiver, string command, T payLoad)
    {
        Console.WriteLine($"Desktop issued {command} to {receiver} with payload {payLoad}");
        base.SendCommand(receiver, command, payLoad);
    }

    public override void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Desktop Computer {Key} received {command}");
        base.ReceiveCommand(sender, command);
    }
    
    public override void ReceiveCommand<T>(string sender, string command, T payLoad)
    {
        Console.WriteLine($"Desktop Computer {Key} received {command} with payload {nameof(T)}");
        base.ReceiveCommand(sender, command, payLoad);
    }
}