using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;
using SMEAppHouse.Ladon.Infrastructure.Helpers;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class BlogPostService(IMapper mapper,
                            ILogger<BlogPostService> logger,
                            IBlogPostRepository blogPostRepository) : IBlogPostService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<BlogPostService> _logger = logger;
    private readonly IBlogPostRepository _blogPostRepository = blogPostRepository;

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
            var blogPost = await _blogPostRepository.GetSingleAsync(a => a.Slug == slug);
            var blgPost = _mapper.Map<BlogPostModel>(blogPost);
            return blgPost;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}