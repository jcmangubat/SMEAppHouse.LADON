using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Domain.Repositories;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

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

    public async Task TrackReactionAsync(Guid articleId, ReaderReactionsEnum reaction)
    {
        var article = await _articleRepository.FindAsync(articleId);
        if (article != null)
        {
            if (reaction == ReaderReactionsEnum.Like)
                article.Likes++;
            else article.Hearts++;

            await _articleRepository.UpdateAsync(article);
            await _articleRepository.CommitAsync();
        }
    }
}

