using SMEAppHouse.Core.Patterns.Repo.Repository.Abstractions;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Repositories;

public class UserProfileRepository(ApplicationDbContext dbContext) 
    : RepositoryForKeyedEntity<UserProfile, Guid>(dbContext), IUserProfileRepository
{

}
