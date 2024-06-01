using Hangfire;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Options;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Helper;

namespace SMEAppHouse.Ladon.Web.Extensions;

public static class ServiceRegistrationExtensions
{
    /// <summary>
    /// Schedule the background job to run every 3 minutes as default
    /// </summary>
    /// <param name="app"></param>
    public static void InitiateMessaging(this IApplicationBuilder app)
    {

        // Remove first any existing as the succeeding line adds new entry
        RecurringJob.RemoveIfExists("SendUnsentMessages");

        using var scope = app.ApplicationServices.CreateScope();
        var options = scope.ServiceProvider.GetRequiredService<IOptions<ApplicationSettings>>();
        var appSettings = options.Value;

        var cronOfMessagingInterval = "*/3 * * * *";
        if (appSettings.MessageForwardingInterval != null && appSettings.MessageForwardingInterval.HasValue)
        {
            var cronInf = appSettings.MessageForwardingInterval.Value.Convert();
            cronOfMessagingInterval = cronInf.CronExpression;
        }
        RecurringJob.AddOrUpdate<IMessageSenderServiceFactory>("SendUnsentMessages",
            factory => factory.SendUnsentMessagesJob(), cronOfMessagingInterval);

        /*BackgroundJob.Schedule<IEmailSenderServiceFactory>(
            factory => factory.SendUnsentEmailsJob(),
            TimeSpan.FromMinutes(5) // Adjust the timespan as needed
        );*/
    }

    public static void ConfigureMimeTypes(this ResponseCompressionOptions options)
    {
        var additionalMimeTypes = new[] {
                "application/javascript",   //: JavaScript files
                "text/css",                 //: CSS files
                "text/xml",                 //: XML files
                "application/json",         //: JSON data
                "application/xml",          //: XML data
                "application/xhtml+xml",    //: XHTML documents
                "text/plain",               //: Plain text files
                "application/vnd.ms-excel", //: Excel spreadsheets
                "application/vnd.ms-powerpoint",    //: PowerPoint presentations
                "application/vnd.ms-word",  //: Word documents
                "text/csv",                 //: CSV files
                "text/markdown",            //: Markdown documents
                "text/vtt",                 //: WebVTT subtitle files
        };
        options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(additionalMimeTypes);
    }
}
