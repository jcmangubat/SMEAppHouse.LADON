using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogPostImage : GuidKeyedEntity
{
    public required string ImageCDNUrl { get; set; }

    public Guid? BlogPostId { get; set; }
    public virtual BlogPost? BlogPost { get; set; } // Navigation property
}
