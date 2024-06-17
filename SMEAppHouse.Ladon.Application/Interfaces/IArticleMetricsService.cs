namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IArticleMetricsService
{

    Task TrackViewAsync(Guid articleId);

    Task TrackLikeAsync(Guid articleId);
}