using Hangfire;
using Hangfire.Storage;
using Hangfire.Storage.Monitoring;
using SMEAppHouse.Ladon.Application.Interfaces;

namespace SMEAppHouse.Ladon.Infrastructure.Utilities;

public class HangfireJobChecker : IHangfireJobChecker
{
    public bool IsJobCurrentlyExecuting(string jobId)
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();

        // Get the processing jobs
        var processingJobs = monitoringApi.ProcessingJobs(0, int.MaxValue);

        // Check if the jobId is in the processing jobs
        return processingJobs.Any(job => job.Key == jobId && job.Value.InProcessingState);
    }

    public bool IsRecurringJobCurrentlyExecuting(string recurringJobId)
    {
        using var connection = JobStorage.Current.GetConnection();
        var processingJobs = connection.GetRecurringJobs();
        var recurringJob = processingJobs.FirstOrDefault(p => p.Id.Equals(recurringJobId));
        if (recurringJob == null)
            return false;

        foreach (var processingJob in processingJobs)
        {
            var executing = IsJobCurrentlyExecuting(processingJob.LastJobId);
            if (executing)
                return true;
        }
        return false;
    }

    public JobDetailsDto? GetJobDetails(string jobId)
    {
        var monitoringApi = JobStorage.Current.GetMonitoringApi();
        var processingJobs = monitoringApi.ProcessingJobs(0, int.MaxValue);
        if (processingJobs == null || processingJobs.Count == 0)
            return null;

        return monitoringApi.JobDetails(jobId);
    }
}