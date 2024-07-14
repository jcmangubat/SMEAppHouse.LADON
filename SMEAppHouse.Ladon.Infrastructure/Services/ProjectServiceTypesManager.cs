using System.Text.Json;
using SMEAppHouse.Core.CodeKits.Extensions;
using SMEAppHouse.Ladon.Application.Interfaces;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class ProjectServiceTypesManager : IProjectServiceTypesManager
{
    private readonly Dictionary<ServiceCategoriesEnum, List<(string Code, string Description)>> _servicesByCategory;

    public ProjectServiceTypesManager()
    {
        var jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "services.json");
        if (!File.Exists(jsonFilePath))
            throw new FileNotFoundException("The services.json file was not found in the root of the project folder.");

        var jsonData = File.ReadAllText(jsonFilePath);
        var servicesData = JsonSerializer.Deserialize<Dictionary<string, List<ServiceType>>>(jsonData);
        _servicesByCategory = servicesData.ToDictionary(
            kvp => Enum.Parse<ServiceCategoriesEnum>(kvp.Key),
            kvp => kvp.Value.Select(service => (service.Code, service.Description)).ToList()
        );
    }

    internal class ServiceType
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public string GetServiceDescription(string serviceTypeCode) =>
        _servicesByCategory
           .SelectMany(category => category.Value)
           .FirstOrDefault(service => service.Code.EqualsCaseInsensitive(serviceTypeCode))
           .Description ?? throw new KeyNotFoundException(serviceTypeCode);

    public List<(string Code, string Description)> GetServices(ServiceCategoriesEnum? category = null)
    {
        List<(string Code, string Description)> services;

        if (category.HasValue)
        {
            services = _servicesByCategory.TryGetValue(category.Value, out var srvcs)
                ? srvcs.Select(s => (s.Code, s.Description)).ToList()
                : [];
        }
        else
        {
            services = _servicesByCategory.Values
                .SelectMany(s => s.Select(sv => (sv.Code, sv.Description)))
                .ToList();
        }

        services.Sort();
        return services;
    }
}