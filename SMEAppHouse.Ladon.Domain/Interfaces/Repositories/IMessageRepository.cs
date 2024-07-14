using SMEAppHouse.Core.Patterns.Repo.Repository.Abstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Repositories;

public interface IMessageRepository : IRepositoryForKeyedEntity<Message, Guid>
{
    List<Message> GetMessages(MessageStatusEnum? messageStatus = null);
}
