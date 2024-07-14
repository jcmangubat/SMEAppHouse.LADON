namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IMessageSenderService
{
    Task SendUnsentMessagesAsync();
}