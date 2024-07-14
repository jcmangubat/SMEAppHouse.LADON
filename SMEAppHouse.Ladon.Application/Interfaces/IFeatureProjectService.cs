using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IFeatureProjectService
{
    Task<FeatureProjectModel?> GetFeatureProjectAsync(Guid featureProjectId);

    Task<FeatureProjectModel?> GetFeatureProjectBySlugAsync(string titleSlug);
    
    Task<IEnumerable<FeatureProjectModel>?> GetFeatureProjectsAsync(Expression<Func<FeatureProjectModel, bool>> modelFilter);
    
    Task<FeatureProjectModel?> AddFeatureProjectAsync(FeatureProjectModel featureProject);

    Task UpdateFeatureProjectAsync(FeatureProjectModel featureProjectModel);
}
