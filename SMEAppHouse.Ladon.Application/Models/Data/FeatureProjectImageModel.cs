using SMEAppHouse.Ladon.Application.Models.Base;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class FeatureProjectImageModel : KeyedModel
{
    public required string ImageCDNUrl { get; set; }
    public string? ImageCaption { get; set; }
    public ImageSizeOrientationStylesEnum? Style { get; set; }
}