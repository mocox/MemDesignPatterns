namespace MediatR01;

public interface IMediator
{
    void Register(string key, IParticipant participant);
    void SendCommand(string receiver, string sender, string command);
    void SendCommand<T>(string receiver, string message, T payload);
}