using SMEAppHouse.Ladon.Application.Models.Base;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Models;

public class ArticleCategoryAssociationModel : KeyedModel
{
    public required Guid ArticleId { get; set; }
    public virtual required Article Article { get; set; }

    public required Guid ArticleCategoryId { get; set; }
    public virtual required ArticleCategory ArticleCategory { get; set; }
}