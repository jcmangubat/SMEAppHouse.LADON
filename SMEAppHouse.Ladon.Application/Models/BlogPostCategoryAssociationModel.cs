using SMEAppHouse.Ladon.Application.Models.Base;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Models;

public class BlogPostCategoryAssociationModel : KeyedModel
{
    public required Guid BlogPostId { get; set; }
    public virtual required BlogPost BlogPost { get; set; }

    public required Guid BlogCategoryId { get; set; }
    public virtual required ArticleCategory ArticleCategory { get; set; }
}