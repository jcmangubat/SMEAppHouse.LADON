using FluentValidation;
using Hangfire;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Mappings;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Validators;
using SMEAppHouse.Ladon.Domain.Repositories;
using SMEAppHouse.Ladon.Infrastructure.Interfaces;
using SMEAppHouse.Ladon.Infrastructure.Persistence;
using SMEAppHouse.Ladon.Infrastructure.Persistence.Repositories;
using SMEAppHouse.Ladon.Infrastructure.Services;
using SMEAppHouse.Ladon.Infrastructure.Utilities;
using SMEAppHouse.Ladon.Web.Extensions;

namespace SMEAppHouse.Ladon.Web;

public class Startup(IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Logging Configuration
        services.AddLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddConsole();
            logging.AddDebug();
            logging.AddEventSourceLogger();
            logging.AddFilter("Microsoft", LogLevel.Information)
                   .AddFilter("System", LogLevel.Information)
                   .AddFilter("SMEAppHouse.Ladon.Web", LogLevel.Debug);
        });

        // Add in-memory caching services
        services.AddMemoryCache();

        // Alternatively, configure distributed caching (e.g., Redis)
        // services.AddStackExchangeRedisCache(options =>
        // {
        //     options.Configuration = Configuration.GetConnectionString("RedisConnection");
        //     options.InstanceName = "SampleInstance";
        // });

        // Database setup
        var connectionString = configuration.GetConnectionString("DefaultConnection") ??
            throw new InvalidOperationException("Connection string 'DefaultConnection' is not found.");

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString,
                sqlServerOptions =>
                {
                    sqlServerOptions.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                    sqlServerOptions.EnableRetryOnFailure();
                }));

        services.AddDatabaseDeveloperPageExceptionFilter();

        // Authentication and Authorization setup
        services.AddAuthentication(options =>
        {
            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.Cookie.HttpOnly = true;
                options.Cookie.MaxAge = TimeSpan.FromDays(1);
                options.Cookie.SameSite = SameSiteMode.Strict;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.SlidingExpiration = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;

                options.Events = new CookieAuthenticationEvents
                {
                    OnValidatePrincipal = async context =>
                    {
                        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Startup>>();
                        logger.LogInformation("Validating principal for user: {User}", context.Principal.Identity.Name);

                        // Log claims
                        foreach (var claim in context.Principal.Claims)
                        {
                            logger.LogInformation("Claim {Type}: {Value}", claim.Type, claim.Value);
                        }

                        await Task.CompletedTask;
                    },
                    OnSigningIn = context =>
                    {
                        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Startup>>();
                        logger.LogInformation("User signing in: {User}", context.Principal.Identity.Name);
                        return Task.CompletedTask;
                    },
                    OnSigningOut = context =>
                    {
                        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Startup>>();
                        logger.LogInformation("User signing out: {User}", context.HttpContext.User.Identity.Name);
                        return Task.CompletedTask;
                    }
                };
            });

        services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
            options.AddPolicy("ManagerOnly", policy => policy.RequireRole("Manager"));
            options.AddPolicy("EditorOnly", policy => policy.RequireRole("Editor"));
            options.AddPolicy("ModeratorOnly", policy => policy.RequireRole("Moderator"));
            options.AddPolicy("ClientOnly", policy => policy.RequireRole("Client"));
            options.AddPolicy("VisitorOnly", policy => policy.RequireRole("Visitor"));
            options.AddPolicy("ClientOrAdmin", policy => policy.RequireRole("Client", "Admin"));
        });

        // Identity setup
        services.AddIdentity<IdentityUser<Guid>, IdentityRole<Guid>>(
            options =>
            {
                options.Stores.MaxLengthForKeys = 225;

                options.SignIn.RequireConfirmedAccount = true;

                // User settings
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+#%*";
                options.User.RequireUniqueEmail = true;

                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

        // Repositories
        services.AddTransient<IAddressRepository, AddressRepository>();
        services.AddTransient<IBlogCommentRepository, BlogCommentRepository>();
        services.AddTransient<IBlogPostRepository, BlogPostRepository>();
        services.AddTransient<IClientTestimonyRepository, ClientTestimonyRepository>();
        services.AddTransient<IMessageRepository, MessageRepository>();
        services.AddTransient<ISiteAreaRepository, SiteAreaRepository>();
        services.AddTransient<ISubscriberRepository, SubscriberRepository>();
        services.AddTransient<IUserProfileRepository, UserProfileRepository>();
        services.AddTransient<IQuoteRequestRepository, QuoteRequestRepository>();
        services.AddTransient<IQuoteRequestAttachmentRepository, QuoteRequestAttachmentRepository>();
        services.AddTransient<IQuestionAnswerRepository, QuestionAnswerRepository>();

        // CORS Configuration
        services.AddCors(options =>
        {
            var allowedOrigins = Configuration.GetSection("AllowedOrigins").Get<string[]>();
            options.AddPolicy("DefaultPolicy", builder =>
            {
                builder.WithOrigins(allowedOrigins)
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
        });

        // SMTPSettings
        services.Configure<SMTPSettings>(Configuration.GetSection("Smtp"));
        services.AddSingleton(resolver =>
            resolver.GetRequiredService<IOptions<SMTPSettings>>().Value);

        // Cloudinary
        services.Configure<CloudinaryCredentials>(Configuration.GetSection("Cloudinary"));
        services.AddSingleton(resolver =>
            resolver.GetRequiredService<IOptions<CloudinaryCredentials>>().Value);

        // ImageKitIO
        services.Configure<ImageKitCredentials>(Configuration.GetSection("ImageKitIO"));
        services.AddSingleton(resolver =>
            resolver.GetRequiredService<IOptions<ImageKitCredentials>>().Value);

        // Load configuration settings
        // Bind the ApplicationSettings section to the ApplicationSettings class
        services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"));
        services.AddSingleton(resolver =>
            resolver.GetRequiredService<IOptions<ApplicationSettings>>().Value);

        // Application Services
        services.AddScoped<IAuthMembershipService, AuthMembershipService>();
        services.AddSingleton<IHangfireJobChecker, HangfireJobChecker>();
        services.AddScoped<IHangfireJobService, HangfireJobService>();
        services.AddScoped<IMessageService, MessageService>();
        services.AddScoped<IMessageSenderService, MessageSenderService>();
        services.AddSingleton<IMessageSenderServiceFactory, MessageSenderServiceFactory>();
        services.AddSingleton<IProjectServiceTypesManager, ProjectServiceTypesManager>();
        services.AddScoped<IQuoteRequestService, QuoteRequestService>();
        services.AddScoped<IQuoteRequestAttachmentService, QuoteRequestAttachmentService>();
        services.AddSingleton<ICloudinaryUploadService, CloudinaryUploadService>();
        services.AddSingleton<IImageKitUploadService, ImageKitUploadService>();
        services.AddScoped<IBlogPostService, BlogPostService>();
        services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();

        // Add MVC and Razor Pages
        services.AddControllersWithViews()
                .AddDataAnnotationsLocalization();

        services.AddRazorPages(options =>
        {
            //options.Conventions.AddAreaPageRoute("Client", "/QuoteRequest", "Client/QuoteRequest");
        })
        .AddRazorOptions(options =>
        {
            //options.ViewLocationFormats.Add("/Areas/Client/Pages/{0}.cshtml");
            options.ViewLocationFormats.Add("/{0}.cshtml");
        });

        // Register your validators
        services.AddTransient<IValidator<QuoteRequestModel>, QuoteRequestValidator>();

        //// Configure persistent storage for data protection keys
        //services.AddDataProtection()
        //    .PersistKeysToFileSystem(new DirectoryInfo(@"\\"))
        //    .SetApplicationName("SMEAppHouse.Ladon.Web");

        // Register custom IDataProtectionProvider implementation
        services.AddDataProtection().PersistKeysToDbContext<ApplicationDbContext>();

        // Antiforgery Configuration
        services.AddAntiforgery(options =>
        {
            options.HeaderName = "X-CSRF-TOKEN";
            options.Cookie.Name = "LADON-CSRF-TOKEN";
            options.FormFieldName = "LADON-CSRF-FIELD";
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            options.Cookie.MaxAge = TimeSpan.FromHours(72);
            options.Cookie.Expiration = TimeSpan.FromHours(24);
        });

        // Web Optimizer
        services.AddWebOptimizer(pipeline =>
        {
            pipeline.MinifyJsFiles("js/main.js");

            var cssFiles = Directory.GetFiles("wwwroot/css", "*.css", SearchOption.AllDirectories)
                            .Where(file => !file.EndsWith("quoterequest.css"))
                            .Select(file => file.Replace("wwwroot/", "/"));

            pipeline.MinifyCssFiles(cssFiles.ToArray());
            pipeline.AddCssBundle("/css/bundle.css", cssFiles.ToArray());

            //pipeline.MinifyCssFiles("css/**/*.css");
            //pipeline.AddCssBundle("/css/bundle.css", "/css/site.css", "/css/**/*.css");
            pipeline.AddJavaScriptBundle("/js/site.js", "/js/chat/*.js");
        });

        services.AddResponseCompression(options => options.EnableForHttps = true);
        services.ConfigureOptions<CustomResponseCompressionConfigurer>();

        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));

        // Hangfire services
        var hangfireConn = Configuration.GetConnectionString("HangfireConnection");
        services.AddHangfire(configuration => configuration
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(() => new Microsoft.Data.SqlClient.SqlConnection(hangfireConn)));
        services.AddHangfireServer();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseSerilogRequestLogging();

        app.UseRouting();
        app.UseWebOptimizer();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseErrorLoggingMiddleware();

        // Middleware for global anti-forgery token validation
        app.Use(next => context =>
        {
            if (string.Equals(context.Request.Method, "POST", StringComparison.OrdinalIgnoreCase))
            {
                var antiforgery = context.RequestServices.GetRequiredService<IAntiforgery>();
                antiforgery.ValidateRequestAsync(context).GetAwaiter().GetResult();
            }
            return next(context);
        });

        app.UseCors("DefaultPolicy");
        app.UseHangfireDashboard();

        // Add caching middleware
        app.UseResponseCaching();

        // Activate the custom Response Compression
        app.UseResponseCompression();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Map API controller routes
            endpoints.MapControllers();

            endpoints.MapRazorPages();
        });

        app.InitiateMessaging();
    }
}
