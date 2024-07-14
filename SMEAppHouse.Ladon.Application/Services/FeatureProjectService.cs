using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Application.Services;

public class FeatureProjectService(IMapper mapper,
                            ILogger<FeatureProjectService> logger,
                            IFeatureProjectRepository featureProjectRepository) : IFeatureProjectService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<FeatureProjectService> _logger = logger;
    private readonly IFeatureProjectRepository _featureProjectRepository = featureProjectRepository;

    public async Task<FeatureProjectModel?> GetFeatureProjectAsync(Guid featureProjectId)
    {
        try
        {
            var featureProject = await _featureProjectRepository.GetSingleAsync(a => a.Id == featureProjectId);
            var featurePrj = _mapper.Map<FeatureProjectModel>(featureProject);
            return featurePrj;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<FeatureProjectModel?> GetFeatureProjectBySlugAsync(string titleSlug)
    {
        try
        {
            var featureProject = await _featureProjectRepository.GetSingleAsync(filterPredicate: a => a.Slug == titleSlug,
                                                                                includeExpression: p => p.Include(s => s.FeatureProjectImages));
            var featurePrj = _mapper.Map<FeatureProjectModel>(featureProject);
            return featurePrj;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<FeatureProjectModel>?> GetFeatureProjectsAsync(Expression<Func<FeatureProjectModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<FeatureProject, bool>> efModelFilter = ExpressionConverter.Convert<FeatureProject, FeatureProjectModel>(modelFilter);
            var featureProjects = await _featureProjectRepository.GetListAsync(efModelFilter);
            var featurePrjs = _mapper.Map<List<FeatureProjectModel>>(featureProjects);
            return featurePrjs;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<FeatureProjectModel?> AddFeatureProjectAsync(FeatureProjectModel featureProjectModel)
    {
        try
        {
            var featureProject = _mapper.Map<FeatureProject>(featureProjectModel);
            await _featureProjectRepository.AddAsync(featureProject);
            await _featureProjectRepository.CommitAsync();

            featureProjectModel.Id = featureProject.Id;
            return featureProjectModel;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateFeatureProjectAsync(FeatureProjectModel featureProjectModel)
    {
        try
        {
            var featureProject = _mapper.Map<FeatureProject>(featureProjectModel);
            await _featureProjectRepository.UpdateAsync(featureProject);
            await _featureProjectRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}