using Serilog;
using Serilog.Events;
using SMEAppHouse.Ladon.Web;

var builder = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                var env = context.HostingEnvironment;
                if (env.IsDevelopment())
                    config.AddUserSecrets<Program>();
                config.AddEnvironmentVariables();
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
            })
            .UseSerilog((context, configuration) =>
            {
                configuration.ReadFrom.Configuration(context.Configuration)
                             .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                             .MinimumLevel.Override("System", LogEventLevel.Warning)
                             .MinimumLevel.Override("System.Net.Mail", LogEventLevel.Error);
            });

builder.Build().Run();
