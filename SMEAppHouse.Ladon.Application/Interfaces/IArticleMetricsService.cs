using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IArticleMetricsService
{
    Task TrackViewAsync(Guid articleId);

    Task TrackReactionAsync(Guid articleId, ReaderReactionsEnum reaction);
}
