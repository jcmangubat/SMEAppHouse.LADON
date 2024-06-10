namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogPostArticleCategory
{
    public required Guid BlogPostId { get; set; }
    public virtual BlogPost BlogPost { get; set; }

    public required Guid ArticleCategoryId { get; set; }
    public virtual ArticleCategory ArticleCategory { get; set; }
}