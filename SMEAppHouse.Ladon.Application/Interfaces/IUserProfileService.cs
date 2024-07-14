using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IUserProfileService
{
    Task<UserProfileModel?> GetUserProfileAsync(Guid UserProfileId);    
    Task<UserProfileModel?> GetUserProfileAsync(Expression<Func<UserProfileModel, bool>> modelFilter);

    Task<IEnumerable<UserProfileModel>> GetUserProfilesAsync(int? userProfileCount = 0);
    Task<IEnumerable<UserProfileModel>> GetUserProfilesAsync(Expression<Func<UserProfileModel, bool>>? filter = null,
                                                                    int? userProfileCount = 0);
    
    Task<UserProfileModel?> AddUserProfileAsync(UserProfileModel userProfile);

    Task UpdateUserProfileAsync(UserProfileModel userProfile);

}