using Newtonsoft.Json.Linq;
using SMEAppHouse.Core.CodeKits;
using SMEAppHouse.Core.CodeKits.Extensions;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Infrastructure.Seeder.ManifestModels;

public class FeatureProjectManifestData
{
    public static List<FeatureProject> Read()
    {
        var outputDirectory = AppContext.BaseDirectory;

        var featureProjectsJsonPath = Path.Combine(outputDirectory, "Seeder", "Data", "featureProjectsSeed.json");
        var featureProjectsJson = File.ReadAllText(featureProjectsJsonPath);
        if (string.IsNullOrEmpty(featureProjectsJson))
            return [];

        var jsonArray = JArray.Parse(featureProjectsJson);
        var results = new List<FeatureProject>();

        foreach (JObject obj in jsonArray.Cast<JObject>())
        {
            var result = new FeatureProject()
            {
                Id = Guid.NewGuid(),
                Title = (string)obj["title"],
                Slug = CodeKit.MakeSlug((string)obj["title"]),
                Description = (string?)obj["description"],
                ImageCDNUrl = (string)obj["primaryImage"],
                Location = (string?)obj["location"],
                CompletionDate = (DateTime?)obj["completionDate"],
            };

            JArray imagesArray = (JArray)obj["images"];

            if (imagesArray != null)
            {
                var images = new List<FeatureProjectImage>();
                foreach (var imageObj in imagesArray)
                {
                    var style = ((string?)imageObj["style"] ?? string.Empty).ToCamelCase();
                    _ = Enum.TryParse<ImageSizeOrientationStylesEnum>(style, out var oStyle);

                    var image = new FeatureProjectImage
                    {
                        Id = Guid.NewGuid(),
                        ImageCDNUrl = (string)imageObj["image"],
                        FeatureProjectId = result.Id,
                        Style = oStyle
                    };
                    images.Add(image);
                }
                result.FeatureProjectImages = images;
            }

            results.Add(result);
        }

        return results;
    }

    public List<FeatureProjectModel> FeatureProjects { get; set; } = [];
}
