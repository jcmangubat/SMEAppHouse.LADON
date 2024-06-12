using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;
using SMEAppHouse.Ladon.Infrastructure.Helpers;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class ArticleService(IMapper mapper,
                            ILogger<ArticleService> logger,
                            IArticleRepository articleRepository,
                            IUserProfileRepository userProfileRepository,
                            MarkdownService markdownService) : IArticleService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<ArticleService> _logger = logger;
    private readonly IArticleRepository _articleRepository = articleRepository;
    private readonly IUserProfileRepository _userProfileRepository = userProfileRepository;
    private readonly MarkdownService _markdownService = markdownService;

    public async Task<ArticleModel?> GetArticleAsync(Guid articleId)
    {
        try
        {
            var article = await _articleRepository.GetSingleAsync(a => a.Id == articleId);
            return _mapper.Map<ArticleModel>(article);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<ArticleModel?> GetArticleAsync(Expression<Func<ArticleModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<Article, bool>> efModelFilter = ExpressionConverter.Convert<Article, ArticleModel>(modelFilter);
            var article = await _articleRepository.GetSingleAsync(efModelFilter) ??
                            throw new Exception("Article entry not found.");

            return _mapper.Map<ArticleModel>(article);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<ArticleModel>?> GetArticlesAsync(Expression<Func<ArticleModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<Article, bool>> efModelFilter = ExpressionConverter.Convert<Article, ArticleModel>(modelFilter);
            var articles = await _articleRepository.GetListAsync(efModelFilter);
            return _mapper.Map<List<ArticleModel>>(articles);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<ArticleModel?> SaveArticleAsync(ArticleModel articleModel)
    {
        try
        {
            var article = _mapper.Map<Article>(articleModel);
            await _articleRepository.AddAsync(article);
            await _articleRepository.CommitAsync();

            articleModel.Id = article.Id;
            return articleModel;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateArticleAsync(ArticleModel articleModel)
    {
        try
        {
            var article = _mapper.Map<Article>(articleModel);
            await _articleRepository.UpdateAsync(article);
            await _articleRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<ArticleModel?> GetArticleBySlug(string slug)
    {
        try
        {
            Article articleEF = await _articleRepository.GetSingleAsync(
                                    predicate: a => a.Slug == slug,
                                    include: b => b.Include(p => p.Images)
                                                    .Include(p => p.Comments)
                                                    .Include(p => p.RelatedPostsFrom)
                                                    .Include(p => p.RelatedPostsTo)
                                                    .Include(p => p.ArticleCategories)
                                                    .Include(p => p.AuthorUserProfile));

            var article = _mapper.Map<ArticleModel>(articleEF);

            if (article == null)
                return null;

            if (string.IsNullOrEmpty(article.AuthorAvatarImageCDNUrl))
            {
                var authFullName = article.AuthorName.Replace("  ", " ").ToLower();
                var userProfile = await _userProfileRepository.GetSingleAsync(u => (u.FirstName.ToLower() + " " + u.LastName.ToLower()) == authFullName);
                if (userProfile != null)
                    article.AuthorAvatarImageCDNUrl = userProfile.ThumbnailUrl;
            }

            if (!string.IsNullOrEmpty(article.ContentSourceMDCDNUrl))
            {
                // load from the CDN site the Article content
            }
            else if (!string.IsNullOrEmpty(article.ContentSourceMDFileName))
            {
                var outputDirectory = AppContext.BaseDirectory;
                var phyMDFile = Path.Combine(outputDirectory, "SeedData", "Article", article.ContentSourceMDFileName);
                var mdContent = await _markdownService.ConvertMarkdownToHtmlAsync(phyMDFile);

                article.Content = mdContent;
            }

            return article;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}
