namespace MediatR01;

public class NetworkMediator: IMediator
{
    private readonly Dictionary<string, IParticipant> _participants;

    public NetworkMediator()
    {
        _participants = new Dictionary<string, IParticipant>();
    }

    public void Register(string key, IParticipant participant)
    {
        _participants[key] = participant;
    }

    public void SendCommand(string receiver, string sender, string command)
    {
        if (_participants.ContainsKey(receiver))
        {
            _participants[receiver].ReceiveCommand(sender,command);
        }
    }

    public void SendCommand<T>(string receiver, string message, T payload)
    {
        throw new NotImplementedException();
    }
}