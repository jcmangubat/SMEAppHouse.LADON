using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IArticleService
{
    Task<ArticleModel?> GetArticleAsync(Guid articleId);

    Task<IEnumerable<ArticleModel>> GetArticlesAsync(Expression<Func<ArticleModel, bool>> modelFilter,
                                                                    int? articleCount = 0);

    Task<IEnumerable<ArticleModel>> GetNewsArticlesAsync(int? articleCount = 0);

    Task<ArticleModel?> GetArticleAsync(Expression<Func<ArticleModel, bool>> modelFilter);

    Task<ArticleModel?> SaveArticleAsync(ArticleModel articleModel);

    Task UpdateArticleAsync(ArticleModel articleModel);

    Task<ArticleModel?> GetArticleBySlug(string slug);

    Task<IEnumerable<ArticleModel>> GetBlogsAsync(int? articleCount = 3);

}
