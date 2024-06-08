using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Tools;
using SMEAppHouse.Core.Patterns.Repo.Repository.GuidPKBasedVariation;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Repositories;

public class QuestionAnswerRepository(ApplicationDbContext dbContext)
    : EntityRepositoryForKeyedEntity<QuestionAnswer>(dbContext), IQuestionAnswerRepository
{
    public async Task<IEnumerable<QuestionAnswer>> GetListRandomAsync(Expression<Func<QuestionAnswer, bool>> filter, int fetchSize)
    {
        try
        {
            var result = await RetryCodeKit.Do(async () =>
            {
                IQueryable<QuestionAnswer> query = DbSet.AsNoTracking().Where(filter);

                var random = new Random();
                var results = await query.ToListAsync();
                var randomResults = results
                                    .OrderBy(x => random.Next())
                                    .Take(fetchSize);
                return randomResults;
            }, new TimeSpan(0, 0, 0, 10));
            return result;
        }
        catch (Exception ex)
        {
            throw ExceptionHelpers.ThrowException(ex, true, "Fault in Repository");
        }
    }
}
