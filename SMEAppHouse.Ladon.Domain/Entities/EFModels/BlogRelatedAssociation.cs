namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogRelatedAssociation
{
    public Guid SourceBlogPostId { get; set; }
    public virtual required BlogPost SourceBlogPost { get; set; }

    public Guid TargetBlogPostId { get; set; }
    public virtual required BlogPost TargetBlogPost { get; set; }
}
