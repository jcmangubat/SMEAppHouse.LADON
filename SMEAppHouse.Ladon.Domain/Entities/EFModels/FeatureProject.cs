using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class FeatureProject : GuidKeyedEntity
{
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public string? Description { get; set; }
    public DateTime? CompletionDate { get; set; }
    public required string ImageCDNUrl { get; set; }
    public string? Location { get; set; }
    public virtual List<FeatureProjectImage>? FeatureProjectImages { get; set; } = [];
}
