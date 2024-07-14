using Hangfire.Storage.Monitoring;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IHangfireJobChecker
{
    bool IsJobCurrentlyExecuting(string jobId);

    bool IsRecurringJobCurrentlyExecuting(string recurringJobId);

    JobDetailsDto? GetJobDetails(string jobId);
}
