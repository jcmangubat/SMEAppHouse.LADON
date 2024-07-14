using FluentValidation;
using Hangfire;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Mappings;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Application.Models.Validators;
using SMEAppHouse.Ladon.Application.Services;
using SMEAppHouse.Ladon.Domain.Repositories;
using SMEAppHouse.Ladon.Infrastructure;
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

        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        // Authentication setup
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
            })
            .AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = configuration["Authentication:Google:ClientSecret"];
                googleOptions.SaveTokens = true;

                googleOptions.Events = new OAuthEvents
                {
                    OnRedirectToAuthorizationEndpoint = context =>
                    {
                        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();
                        logger.LogInformation("Redirecting to Google for authentication. RedirectUri: {RedirectUri}", context.RedirectUri);

                        context.Response.Redirect(context.RedirectUri);
                        return Task.CompletedTask;
                    },
                    OnRemoteFailure = context =>
                    {
                        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();
                        logger.LogError("Remote authentication failure: {Error}", context.Failure.Message);
                        context.Response.Redirect("/Account/Login");
                        context.HandleResponse();
                        return Task.CompletedTask;
                    }
                };
            });

        // Authorization setup
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

                options.Tokens.EmailConfirmationTokenProvider = "emailconfirmation";
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders()
            .AddTokenProvider<DataProtectorTokenProvider<IdentityUser<Guid>>>("emailconfirmation");

        // Configure token lifespan
        services.Configure<DataProtectionTokenProviderOptions>(options =>
        {
            options.TokenLifespan = TimeSpan.FromHours(3); // Set the token lifespan to 3 hours
        });

        // Repositories
        services.AddTransient<IAddressRepository, AddressRepository>();
        services.AddTransient<IArticleCommentRepository, ArticleCommentRepository>();
        services.AddTransient<IArticleRepository, ArticleRepository>();
        services.AddTransient<IClientTestimonyRepository, ClientTestimonyRepository>();
        services.AddTransient<IMessageRepository, MessageRepository>();
        services.AddTransient<ISubscriberRepository, SubscriberRepository>();
        services.AddTransient<IUserProfileRepository, UserProfileRepository>();
        services.AddTransient<IQuoteRequestRepository, QuoteRequestRepository>();
        services.AddTransient<IQuoteRequestAttachmentRepository, QuoteRequestAttachmentRepository>();
        services.AddTransient<IQuestionAnswerRepository, QuestionAnswerRepository>();
        services.AddTransient<IFeatureProjectRepository, FeatureProjectRepository>();
        services.AddTransient<IFeatureProjectImageRepository, FeatureProjectImageRepository>();

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

        // OpenAI
        services.Configure<OpenAICredentials>(Configuration.GetSection("OpenAI"));
        services.AddSingleton(resolver =>
            resolver.GetRequiredService<IOptions<OpenAICredentials>>().Value);

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
        services.AddTransient<IEmailSender, EmailSender>();
        services.AddScoped<IFactPointsService, FactPointsService>();
        services.AddTransient<IMarkdownService, MarkdownService>();
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
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<IArticleMetricsService, ArticleMetricsService>();
        services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();
        services.AddScoped<IClientTestimonialsService, ClientTestimonialsService>();
        services.AddScoped<IFeatureProjectService, FeatureProjectService>();
        services.AddScoped<IFeatureProjectImageService, FeatureProjectImageService>();
        services.AddScoped<IUserProfileService, UserProfileService>();

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

        // Configure persistent storage for data protection keys
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
            options.Cookie.SameSite = SameSiteMode.Lax;
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
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseErrorLoggingMiddleware();

        app.UseSession();

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

            endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            /*endpoints.MapControllerRoute(
                name: "identity",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");*/
        });

        app.InitiateMessaging();
    }
}
