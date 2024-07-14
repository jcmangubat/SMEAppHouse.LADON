using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Ladon.Application.Interfaces;

namespace SMEAppHouse.Ladon.Web;

/// <summary>
/// 
/// </summary>
public class MessageSenderServiceFactory(
                IServiceProvider serviceProvider,
                ILogger<IMessageSenderServiceFactory> logger
    ) : IMessageSenderServiceFactory
{
    private volatile bool _jobInProgress = false;

    public bool JobInProgress => _jobInProgress;

    /// <summary>
    /// Hangfire requires the job method to match the type specified in the RecurringJob.AddOrUpdate method. 
    /// In this case, it expects the job method to match the type IEmailSenderServiceFactory.
    /// To avoid any issues, we create a method that matches the expected signature for the Hangfire job called SendUnsentEmails***:
    /// </summary>
    public void SendUnsentMessagesJob()
    {
        try
        {
            if (_jobInProgress)
                return;

            _jobInProgress = true;
            using var scope = serviceProvider.CreateScope();
            var messageSenderService = scope.ServiceProvider.GetRequiredService<IMessageSenderService>();
            messageSenderService.SendUnsentMessagesAsync().Wait();
            _jobInProgress = false;

        }
        catch (Exception ex)
        {
            // Handle exceptions appropriately
            logger.LogError(message: $"Error executing job: {ex.Message}", ex);
            throw;
        }
    }
}
