using Microsoft.Extensions.Configuration;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Ladon.Application.Interfaces;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Services;

public class FactPointsService(IConfiguration configuration) : IFactPointsService
{
    private readonly IConfiguration _configuration = configuration;

    public int GetExpertWorkersCount =>
        _configuration.GetValue<int>("ApplicationSettings:FactPoints:ExpertWorkers");

    public int GetHappyClientsCount =>
        _configuration.GetValue<int>("ApplicationSettings:FactPoints:HappyClients");

    public int GetCompletedProjectsCount =>
        _configuration.GetValue<int>("ApplicationSettings:FactPoints:CompletedProjects");

    public int GetRunningPojectsCount =>
        _configuration.GetValue<int>("ApplicationSettings:FactPoints:RunningPojects");

    // Method to update or persist data points 
    public void UpdateDataPoint(FactPointsEnum factPoint, int value)
    {
        var section = _configuration.GetSection("ApplicationSettings:FactPoints");
        section[factPoint.ToString()] = value.ToString();
    }
}

