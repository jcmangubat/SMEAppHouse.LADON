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

namespace SMEAppHouse.Ladon.Application.Services;

public class ArticleService(IMapper mapper,
                            ILogger<ArticleService> logger,
                            IArticleRepository articleRepository,
                            IUserProfileRepository userProfileRepository,
                            IMarkdownService markdownService) : IArticleService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<ArticleService> _logger = logger;
    private readonly IArticleRepository _articleRepository = articleRepository;
    private readonly IUserProfileRepository _userProfileRepository = userProfileRepository;
    private readonly IMarkdownService _markdownService = markdownService;

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

    public async Task<IEnumerable<ArticleModel>> GetArticlesAsync(Expression<Func<ArticleModel, bool>>? filter = null,
                                                                    int? articleCount = 0)
    {
        try
        {
            Expression<Func<Article, bool>> efModelFilter = p => p.IsActive ?? false &&
                                p.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Published;

            if (filter != null)
                efModelFilter = ExpressionConverter.Convert<Article, ArticleModel>(filter);

            var articles = await _articleRepository.GetListAsync(efModelFilter,
                                                                    fetchSize: articleCount ?? 0,
                                                                    orderBy: q => q.OrderBy(a => a.PublishedDate),
                                                                    include: b => b.Include(p => p.Images)
                                                                                    .Include(p => p.Comments)
                                                                                    .Include(p => p.RelatedPostsFrom)
                                                                                    .Include(p => p.RelatedPostsTo)
                                                                                    .Include(p => p.ArticleCategories)
                                                                                    .Include(p => p.AuthorUserProfile));
            return _mapper.Map<List<ArticleModel>>(articles);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<ArticleModel>> GetNewsArticlesAsync(int? articleCount = 0)
    {
        try
        {
            var articles = await _articleRepository.GetListAsync(filter: p =>
                                                                        p.IsActive ?? false &&
                                                                        p.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Published &&
                                                                        p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.News,
                                                                fetchSize: articleCount ?? 0,
                                                                orderBy: q => q.OrderBy(a => a.PublishedDate),
                                                                include: b => b.Include(p => p.Images)
                                                                                .Include(p => p.Comments)
                                                                                .Include(p => p.RelatedPostsFrom)
                                                                                .Include(p => p.RelatedPostsTo)
                                                                                .Include(p => p.ArticleCategories)
                                                                                .Include(p => p.AuthorUserProfile));
            return _mapper.Map<List<ArticleModel>>(articles);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<ArticleModel>> GetArticlesAsync(int? articleCount = 3)
    {
        try
        {
            var articles = await _articleRepository.GetListAsync(filter: p => (p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Blog ||
                                                                                p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Tutorial ||
                                                                                p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Feature ||
                                                                                p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Opinion ||
                                                                                p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.CaseStudy ||
                                                                                p.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Review) &&
                                                                        p.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Published,
                                                                fetchSize: articleCount ?? 0,
                                                                orderBy: q => q.OrderBy(a => a.PublishedDate),
                                                                include: b => b.Include(p => p.Images)
                                                                                .Include(p => p.Comments)
                                                                                .Include(p => p.RelatedPostsFrom)
                                                                                .Include(p => p.RelatedPostsTo)
                                                                                .Include(p => p.ArticleCategories)
                                                                                .Include(p => p.AuthorUserProfile));
            return _mapper.Map<List<ArticleModel>>(articles);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<ArticleModel?> AddArticleAsync(ArticleModel articleModel)
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
                                    filterPredicate: a => a.Slug == slug,
                                    includeExpression: b => b.Include(p => p.Images)
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
                var userProfile = await _userProfileRepository.GetSingleAsync(u => u.FirstName.ToLower() + " " + u.LastName.ToLower() == authFullName);
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
                var phyMDFile = Path.Combine(outputDirectory, "Resources", "Documents", "Articles", article.ContentSourceMDFileName);
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
