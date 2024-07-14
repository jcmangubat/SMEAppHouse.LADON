namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ArticleAssociation
{
    public Guid SourceArticleId { get; set; }
    public virtual required Article SourceArticle { get; set; }

    public Guid TargetArticleId { get; set; }
    public virtual required Article TargetArticle { get; set; }
}
