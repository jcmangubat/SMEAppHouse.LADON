using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Repositories;
using System.Linq.Expressions;
using FeatureProjectImage = SMEAppHouse.Ladon.Domain.Entities.EFModels.FeatureProjectImage;

namespace SMEAppHouse.Ladon.Application.Services;

public class FeatureProjectImageService(ILogger<FeatureProjectImageService> logger, IMapper mapper,
                                IFeatureProjectImageRepository featureProjectImageRepository)
    : IFeatureProjectImageService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger _logger = logger;
    private readonly IFeatureProjectImageRepository _featureProjectImageRepository = featureProjectImageRepository;

    public async Task<FeatureProjectImageModel?> GetFeatureProjectImageAsync(Guid featureProjectImageId)
    {
        try
        {
            var featureProjectImage = await _featureProjectImageRepository.GetSingleAsync(a => a.Id == featureProjectImageId);
            var featureProjectImg = _mapper.Map<FeatureProjectImageModel>(featureProjectImage);
            return featureProjectImg;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<FeatureProjectImageModel>?> GetFeatureProjectImagesAsync(Guid featureProjectId)
    {
        try
        {
            var featureProjectImages = await _featureProjectImageRepository.GetListAsync(a => a.FeatureProjectId == featureProjectId);
            var featureProjectImgs = _mapper.Map<List<FeatureProjectImageModel>>(featureProjectImages);
            return featureProjectImgs;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<FeatureProjectImageModel?> AddFeatureProjectImageAsync(FeatureProjectImageModel featureProjectImage)
    {
        try
        {
            var featureProjectImg = _mapper.Map<FeatureProjectImage>(featureProjectImage);
            await _featureProjectImageRepository.AddAsync(featureProjectImg);
            await _featureProjectImageRepository.CommitAsync();

            featureProjectImage.Id = featureProjectImage.Id;
            return featureProjectImage;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateFeatureProjectImageAsync(FeatureProjectImageModel featureProjectImage)
    {
        try
        {
            var featureProjectImg = _mapper.Map<FeatureProjectImage>(featureProjectImage);
            await _featureProjectImageRepository.UpdateAsync(featureProjectImg);
            await _featureProjectImageRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<FeatureProjectImageModel>?> GetFeatureProjectImagesAsync(Expression<Func<FeatureProjectImageModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<FeatureProjectImage, bool>> efModelFilter = ExpressionConverter.Convert<FeatureProjectImage, FeatureProjectImageModel>(modelFilter);
            var featureProjectImages = await _featureProjectImageRepository.GetListAsync(efModelFilter);
            var featureProjectImgs = _mapper.Map<List<FeatureProjectImageModel>>(featureProjectImages);
            return featureProjectImgs;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}