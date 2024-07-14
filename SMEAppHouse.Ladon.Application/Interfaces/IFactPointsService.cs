using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IFactPointsService
{
    int GetExpertWorkersCount { get; }

    int GetHappyClientsCount { get; }

    int GetCompletedProjectsCount { get; }

    int GetRunningPojectsCount { get; }

    void UpdateDataPoint(FactPointsEnum factPoint, int value);
}