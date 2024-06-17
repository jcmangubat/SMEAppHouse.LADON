using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Application.Services;

public class ArticleMetricsService(IArticleRepository articleRepository)
    : IArticleMetricsService
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task TrackViewAsync(Guid articleId)
    {
        var article = await _articleRepository.FindAsync(articleId);
        if (article != null)
        {
            article.Views++;
            await _articleRepository.UpdateAsync(article);
        }
    }

    public async Task TrackLikeAsync(Guid articleId)
    {
        var article = await _articleRepository.FindAsync(articleId);
        if (article != null)
        {
            article.Likes++;
            await _articleRepository.UpdateAsync(article);
        }
    }
}
