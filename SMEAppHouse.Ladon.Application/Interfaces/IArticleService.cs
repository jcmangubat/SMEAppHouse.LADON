using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IArticleService
{
    Task<ArticleModel?> GetArticleAsync(Guid articleId);

    Task<IEnumerable<ArticleModel>> GetArticlesAsync(int? articleCount = 3);

    Task<IEnumerable<ArticleModel>> GetArticlesAsync(Expression<Func<ArticleModel, bool>>? filter = null,
                                                                    int? articleCount = 0);

    Task<IEnumerable<ArticleModel>> GetNewsArticlesAsync(int? articleCount = 0);

    Task<ArticleModel?> GetArticleAsync(Expression<Func<ArticleModel, bool>> modelFilter);

    Task<ArticleModel?> AddArticleAsync(ArticleModel articleModel);

    Task UpdateArticleAsync(ArticleModel articleModel);

    Task<ArticleModel?> GetArticleBySlug(string slug);
}
