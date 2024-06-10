using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IBlogPostService
{
    Task<BlogPostModel?> GetBlogPostAsync(Guid blogPostId);

    Task<IEnumerable<BlogPostModel>?> GetBlogPostsAsync(Expression<Func<BlogPostModel, bool>> modelFilter);

    Task<BlogPostModel?> GetBlogPostAsync(Expression<Func<BlogPostModel, bool>> modelFilter);

    Task<BlogPostModel?> SaveBlogPostAsync(BlogPostModel blogPostModel);

    Task UpdateBlogPostAsync(BlogPostModel blogPostModel);

    Task<BlogPostModel?> GetBlogPostBySlug(string slug);
}
