namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ArticleCategoryAssociation
{
    public required Guid ArticleId { get; set; }
    public virtual Article Article { get; set; }

    public required Guid ArticleCategoryId { get; set; }
    public virtual ArticleCategory ArticleCategory { get; set; }
}