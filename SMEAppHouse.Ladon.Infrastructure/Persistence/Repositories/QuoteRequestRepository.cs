using SMEAppHouse.Core.Patterns.Repo.Repository.GuidPKBasedVariation;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Repositories;

public class QuoteRequestRepository(ApplicationDbContext dbContext)
    : EntityRepositoryForKeyedEntity<QuoteRequest>(dbContext), IQuoteRequestRepository
{
}
