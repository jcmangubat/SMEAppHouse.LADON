namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IMessageSenderServiceFactory
{
    void SendUnsentMessagesJob();
    bool JobInProgress { get; }
}