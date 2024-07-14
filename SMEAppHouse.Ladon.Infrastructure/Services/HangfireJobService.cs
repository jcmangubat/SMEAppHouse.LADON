using Hangfire.Storage.Monitoring;
using SMEAppHouse.Ladon.Application.Interfaces;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class HangfireJobService(IHangfireJobChecker jobChecker) : IHangfireJobService
{
    public bool IsRecurringJobCurrentlyExecuting(string recurringJobId) =>
        jobChecker.IsRecurringJobCurrentlyExecuting(recurringJobId);

    public JobDetailsDto? GetJobDetails(string jobId) =>
        jobChecker.GetJobDetails(jobId);
}
