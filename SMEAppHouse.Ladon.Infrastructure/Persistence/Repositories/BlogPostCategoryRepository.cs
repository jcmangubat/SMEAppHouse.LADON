using SMEAppHouse.Core.Patterns.Repo.Repository.GuidPKBasedVariation;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Repositories;

public class BlogPostCategoryRepository(ApplicationDbContext dbContext)
    : EntityRepositoryForKeyedEntity<ArticleCategory>(dbContext), IBlogPostCategoryRepository
{
}
