using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;
using System.Linq.Expressions;

namespace SMEAppHouse.Ladon.Application.Services;

public class UserProfileService(IMapper mapper,
                                ILogger<UserProfileService> logger,
                                IUserProfileRepository userProfileRepository)
    : IUserProfileService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<UserProfileService> _logger = logger;
    private readonly IUserProfileRepository _userProfileRepository = userProfileRepository;

    public async Task<UserProfileModel?> AddUserProfileAsync(UserProfileModel userProfile)
    {
        try
        {
            var userProfileEntity = _mapper.Map<UserProfile>(userProfile);
            await _userProfileRepository.AddAsync(userProfileEntity);
            await _userProfileRepository.CommitAsync();

            userProfile.Id = userProfileEntity.Id;
            return userProfile;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<UserProfileModel?> GetUserProfileAsync(Guid userProfileId)
    {
        try
        {
            var userProfileEntity = await _userProfileRepository.GetSingleAsync(a => a.Id == userProfileId);
            var userProfile = _mapper.Map<UserProfileModel>(userProfileEntity);
            return userProfile;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<UserProfileModel?> GetUserProfileAsync(Expression<Func<UserProfileModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<UserProfile, bool>> efModelFilter = ExpressionConverter.Convert<UserProfile, UserProfileModel>(modelFilter);
            var userProfileEntity= await _userProfileRepository.GetSingleAsync(efModelFilter);
            var userProfile = _mapper.Map<UserProfileModel>(userProfileEntity);
            return userProfile;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<UserProfileModel>> GetUserProfilesAsync(int? userProfileCount = 0)
    {
        try
        {
            var userProfileEntities = await _userProfileRepository.GetListAsync(filter: p => p.IsActive == true,
                                                                fetchSize: userProfileCount ?? 0,
                                                                orderBy: q => q.OrderBy(a => a.LastName).ThenBy(a=>a.FirstName));
            return _mapper.Map<List<UserProfileModel>>(userProfileEntities);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<UserProfileModel>> GetUserProfilesAsync(Expression<Func<UserProfileModel, bool>>? filter = null, int? userProfileCount = 0)
    {
        try
        {
            Expression<Func<UserProfile, bool>> efModelFilter = ExpressionConverter.Convert<UserProfile, UserProfileModel>(filter);
            var userProfileEntities = await _userProfileRepository.GetListAsync(efModelFilter);
            var userProfiles = _mapper.Map<List<UserProfileModel>>(userProfileEntities);
            return userProfiles;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateUserProfileAsync(UserProfileModel userProfile)
    {
        try
        {
            var userProfileEntity = _mapper.Map<UserProfile>(userProfile);
            await _userProfileRepository.UpdateAsync(userProfileEntity);
            await _userProfileRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}