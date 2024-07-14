using SMEAppHouse.Core.Patterns.Repo.Repository.GuidPKBasedVariation;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Repositories;

public class MessageRepository(ApplicationDbContext dbContext)
    : EntityRepositoryForKeyedEntity<Message>(dbContext), IMessageRepository
{
    public List<Message> GetMessages(Rules.MessageStatusEnum? messageStatus = null)
    {
        IQueryable<Message> query = dbContext.Messages;

        if (messageStatus != null)
            query = query.Where(m => m.Status == messageStatus);
        
        return [.. query];
    }
}
