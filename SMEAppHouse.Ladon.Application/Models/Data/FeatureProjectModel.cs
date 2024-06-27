using Newtonsoft.Json;
using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class FeatureProjectModel : KeyedModel
{
    [JsonProperty("title")]
    public required string Title { get; set; }

    public string? Slug { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("primaryImage")]
    public required string ImageCDNUrl { get; set; }

    [JsonProperty("location")]
    public string? Location { get; set; }

    [JsonProperty("completionDate")]
    public DateTime? CompletionDate { get; set; }

    public virtual List<FeatureProjectImageModel>? FeatureProjectImages { get; set; } = [];
}


