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

public class BlogPostService(IMapper mapper,
                            ILogger<BlogPostService> logger,
                            IBlogPostRepository blogPostRepository,
                            IUserProfileRepository userProfileRepository,
                            MarkdownService markdownService) : IBlogPostService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<BlogPostService> _logger = logger;
    private readonly IBlogPostRepository _blogPostRepository = blogPostRepository;
    private readonly IUserProfileRepository _userProfileRepository = userProfileRepository;
    private readonly MarkdownService _markdownService = markdownService;

    public async Task<BlogPostModel?> GetBlogPostAsync(Guid blogPostId)
    {
        try
        {
            var blogPost = await _blogPostRepository.GetSingleAsync(a => a.Id == blogPostId);
            var blgPost = _mapper.Map<BlogPostModel>(blogPost);
            return blgPost;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<BlogPostModel?> GetBlogPostAsync(Expression<Func<BlogPostModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<BlogPost, bool>> efModelFilter = ExpressionConverter.Convert<BlogPost, BlogPostModel>(modelFilter);
            var blogPost = await _blogPostRepository.GetSingleAsync(efModelFilter) ??
                            throw new Exception("Blog entry not found.");

            var blgPost = _mapper.Map<BlogPostModel>(blogPost);
            return blgPost;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<BlogPostModel>?> GetBlogPostsAsync(Expression<Func<BlogPostModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<BlogPost, bool>> efModelFilter = ExpressionConverter.Convert<BlogPost, BlogPostModel>(modelFilter);
            var blogPosts = await _blogPostRepository.GetListAsync(efModelFilter);
            var blgPosts = _mapper.Map<List<BlogPostModel>>(blogPosts);
            return blgPosts;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<BlogPostModel?> SaveBlogPostAsync(BlogPostModel blogPostModel)
    {
        try
        {
            var blogPost = _mapper.Map<BlogPost>(blogPostModel);
            await _blogPostRepository.AddAsync(blogPost);
            await _blogPostRepository.CommitAsync();

            blogPostModel.Id = blogPost.Id;
            return blogPostModel;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateBlogPostAsync(BlogPostModel blogPostModel)
    {
        try
        {
            var blogPost = _mapper.Map<BlogPost>(blogPostModel);
            await _blogPostRepository.UpdateAsync(blogPost);
            await _blogPostRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<BlogPostModel?> GetBlogPostBySlug(string slug)
    {
        try
        {
            BlogPost blogPost = await _blogPostRepository.GetSingleAsync(
                                    predicate: a => a.Slug == slug,
                                    include: b => b.Include(p => p.Images)
                                                    .Include(p => p.Comments)
                                                    .Include(p => p.RelatedPostsFrom)
                                                    .Include(p => p.RelatedPostsTo)
                                                    .Include(p => p.ArticleCategories)
                                                    .Include(p => p.AuthorUserProfile));

            var blgPost = _mapper.Map<BlogPostModel>(blogPost);

            if (blgPost == null)
                return null;

            var authFullName = blgPost.AuthorName.Replace("  ", " ").ToLower();
            var userProfile = await _userProfileRepository.GetSingleAsync(u => (u.FirstName.ToLower() + " " + u.LastName.ToLower()) == authFullName);
            if (userProfile != null)
                blgPost.AuthorAvatarImageCDNUrl = userProfile.ThumbnailUrl;

            if (!string.IsNullOrEmpty(blgPost.ContentSourceMDCDNUrl))
            {
                // load from the CDN site the blog content
            }
            else if (!string.IsNullOrEmpty(blgPost.ContentSourceMDFileName))
            {
                var outputDirectory = AppContext.BaseDirectory;
                var phyMDFile = Path.Combine(outputDirectory, "SeedData", "BlogPost", blgPost.ContentSourceMDFileName);
                var mdContent = await _markdownService.ConvertMarkdownToHtmlAsync(phyMDFile);

                blgPost.Content = mdContent;
            }

            return blgPost;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}
