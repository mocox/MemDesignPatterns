namespace MediatR01;

public interface IParticipant
{
    void SendCommand(string receiver, string command);
    void ReceiveCommand(string sender, string command);
    void ReceiveCommand<T>(string sender, string command, T payLoad);
}