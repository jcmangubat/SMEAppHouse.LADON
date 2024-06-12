using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class ArticleImage : GuidKeyedEntity
{
    public required string ImageCDNUrl { get; set; }

    public Guid? ArticleId { get; set; }
    public virtual Article? Article { get; set; } // Navigation property
}
