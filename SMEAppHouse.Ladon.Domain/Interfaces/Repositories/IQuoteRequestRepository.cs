using SMEAppHouse.Core.Patterns.Repo.Repository.Abstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Domain.Repositories;

public interface IQuoteRequestRepository : IRepositoryForKeyedEntity<QuoteRequest, Guid>
{
}
