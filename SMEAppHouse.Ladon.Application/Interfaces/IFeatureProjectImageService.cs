using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IFeatureProjectImageService
{
    Task<FeatureProjectImageModel?> GetFeatureProjectImageAsync(Guid featureProjectImageId);

    Task<IEnumerable<FeatureProjectImageModel>?> GetFeatureProjectImagesAsync(Guid featureProjectId);
    Task<IEnumerable<FeatureProjectImageModel>?> GetFeatureProjectImagesAsync(Expression<Func<FeatureProjectImageModel, bool>> modelFilter);

    Task<FeatureProjectImageModel?> AddFeatureProjectImageAsync(FeatureProjectImageModel featureProjectImage);

    Task UpdateFeatureProjectImageAsync(FeatureProjectImageModel featureProjectImageModel);
}