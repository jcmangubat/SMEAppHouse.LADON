using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogPostCategoryAssociation : GuidKeyedEntity
{
    public required Guid BlogPostId { get; set; }
    public virtual BlogPost BlogPost { get; set; }

    public required Guid BlogCategoryId { get; set; }
    public virtual BlogPostCategory BlogPostCategory { get; set; }
}