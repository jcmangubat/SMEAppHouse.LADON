using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMEAppHouse.Core.Patterns.EF.SettingsModel;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;
using SMEAppHouse.Ladon.Infrastructure.Seeder;
using DataProtectionKey = Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey;
namespace SMEAppHouse.Ladon.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, DbMigrationInformation? dbMigrationInformation = null)
    : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>(options), IDataProtectionKeyContext
{
    private readonly DbMigrationInformation _dbMigrationInformation = dbMigrationInformation;


    public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
    public virtual DbSet<UserProfile> UserProfiles { get; set; }
    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<Address> Addresses { get; set; }
    public virtual DbSet<ClientTestimony> ClientTestimonies { get; set; }

    public virtual DbSet<Article> Articles { get; set; }
    public virtual DbSet<ArticleCategory> ArticleCategories { get; set; }
    public virtual DbSet<ArticleMetric> ArticleMetrics { get; set; }

    public virtual DbSet<ArticleComment> ArticleComments { get; set; }
    public virtual DbSet<Subscriber> Subscribers { get; set; }
    public virtual DbSet<QuoteRequest> QuoteRequests { get; set; }
    public virtual DbSet<QuoteRequestAttachment> QuoteRequestAttachments { get; set; }
    public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }

    public virtual DbSet<FeatureProject> FeatureProjects { get; set; }
    public virtual DbSet<FeatureProjectImage> FeatureProjectImages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var dbSchema = "dbo";
        builder.HasDefaultSchema(dbSchema);

        builder.Entity<IdentityUser<Guid>>().ToTable("Users");
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
        builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
        builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");

        builder.Entity<IdentityUserLogin<Guid>>().Property(x => x.ProviderKey).HasMaxLength(225);
        builder.Entity<IdentityUserLogin<Guid>>().Property(x => x.LoginProvider).HasMaxLength(225);
        builder.Entity<IdentityUserToken<Guid>>().Property(x => x.Name).HasMaxLength(112);
        builder.Entity<IdentityUserToken<Guid>>().Property(x => x.LoginProvider).HasMaxLength(112);

        // Additional configurations

        if (_dbMigrationInformation != null
            && !string.IsNullOrEmpty(_dbMigrationInformation.DbSchema))
        {
            dbSchema = _dbMigrationInformation.DbSchema;
            builder.HasDefaultSchema(_dbMigrationInformation.DbSchema);
        }

        builder.ApplyConfiguration(new UserProfileConfiguration(dbSchema));
        builder.ApplyConfiguration(new MessageConfiguration(dbSchema));
        builder.ApplyConfiguration(new AddressConfiguration(dbSchema));
        builder.ApplyConfiguration(new ClientTestimonyConfiguration(dbSchema));
        builder.ApplyConfiguration(new ArticleConfiguration(dbSchema, builder));
        builder.ApplyConfiguration(new ArticleCategoryConfiguration(dbSchema, builder));
        builder.ApplyConfiguration(new ArticleImageConfiguration(dbSchema, builder));
        builder.ApplyConfiguration(new ArticleCommentConfiguration(dbSchema));
        builder.ApplyConfiguration(new ArticleMetricConfiguration(dbSchema));
        builder.ApplyConfiguration(new SubscriberConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuoteRequestConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuoteRequestAttachmentConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuestionAnswerConfiguration(dbSchema));
        builder.ApplyConfiguration(new FeatureProjectConfiguration(dbSchema));
        builder.ApplyConfiguration(new FeatureProjectImageConfiguration(dbSchema));

        new DataSeeder(builder)
            .SeedRolesAndUsers()
            .SeedQuestionAndAnswers()
            .SeedArticleCategory()
            .SeedArticlePostEntity()
            .SeedTestimoniesEntity()
            .SeedFeatureProjectsEntity();
    }
}
