using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IMessageService
{
    Task<MessageModel> GetMessageAsync(Guid? id);
    Task<IEnumerable<MessageModel>> GetMessagesAsync();
    Task AddMessageAsync(MessageModel message);
}
