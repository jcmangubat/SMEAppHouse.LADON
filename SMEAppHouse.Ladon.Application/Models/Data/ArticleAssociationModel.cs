using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ArticleAssociationModel
{
    public Guid SourceArticleId { get; set; }
    public virtual required Article SourceArticle { get; set; }

    public Guid TargetArticleId { get; set; }
    public virtual required Article TargetArticle { get; set; }
}
