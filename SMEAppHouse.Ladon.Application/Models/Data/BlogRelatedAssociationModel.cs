using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class BlogRelatedAssociationModel
{
    public Guid SourceBlogPostId { get; set; }
    public virtual required BlogPost SourceBlogPost { get; set; }

    public Guid TargetBlogPostId { get; set; }
    public virtual required BlogPost TargetBlogPost { get; set; }
}
