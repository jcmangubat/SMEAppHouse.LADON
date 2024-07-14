using Hangfire.Storage.Monitoring;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IHangfireJobService
{
    bool IsRecurringJobCurrentlyExecuting(string recurringJobId);

    JobDetailsDto? GetJobDetails(string jobId);
}