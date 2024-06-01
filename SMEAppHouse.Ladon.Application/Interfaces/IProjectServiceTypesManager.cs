using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Interfaces
{
    public interface IProjectServiceTypesManager
    {
        string GetServiceDescription(string serviceTypeCode);
        List<(string Code, string Description)> GetServices(ServiceCategoriesEnum? category = null);
    }
}