using Newtonsoft.Json;
using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class FeatureProjectImage : GuidKeyedEntity
{
    [JsonProperty("imageCDNUrl")]
    public required string ImageCDNUrl { get; set; }

    [JsonProperty("imageCaption")]
    public string? ImageCaption { get; set; }

    [JsonProperty("style")]
    public ImageSizeOrientationStylesEnum? Style { get; set; }

    public required Guid FeatureProjectId { get; set; }
    public virtual FeatureProject FeatureProject { get; set; }

    public override string ToString() => $"Id:{Id}, Orientation:{Style}, ImageCDNUrl:{ImageCDNUrl}";

}