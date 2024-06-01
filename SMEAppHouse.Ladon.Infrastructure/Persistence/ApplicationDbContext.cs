using System.Security.Cryptography;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMEAppHouse.Core.Patterns.EF.SettingsModel;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;
using DataProtectionKey = Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey;
namespace SMEAppHouse.Ladon.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, DbMigrationInformation? dbMigrationInformation = null)
    : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>(options), IDataProtectionKeyContext
{
    private readonly DbMigrationInformation _dbMigrationInformation = dbMigrationInformation;

    public virtual DbSet<UserProfileModel> UserProfiles { get; set; }
    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<SiteArea> SiteAreas { get; set; }
    public virtual DbSet<Address> Addresses { get; set; }
    public virtual DbSet<ClientTestimony> ClientTestimonies { get; set; }
    public virtual DbSet<BlogPost> BlogPosts { get; set; }
    public virtual DbSet<BlogComment> BlogComments { get; set; }
    public virtual DbSet<Subscriber> Subscribers { get; set; }
    public virtual DbSet<QuoteRequest> QuoteRequests { get; set; }
    public virtual DbSet<QuoteRequestAttachment> QuoteRequestAttachments { get; set; }
    public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var dbSchema = "dbo";
        builder.HasDefaultSchema(dbSchema);

        //builder.Entity<DataProtectionKey>().ToTable("_DataProtectionKeys");

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
        builder.ApplyConfiguration(new SiteAreaConfiguration(dbSchema));
        builder.ApplyConfiguration(new AddressConfiguration(dbSchema));
        builder.ApplyConfiguration(new ClientTestimonyConfiguration(dbSchema));
        builder.ApplyConfiguration(new BlogPostConfiguration(dbSchema, builder));
        builder.ApplyConfiguration(new BlogCategoryConfiguration(dbSchema, builder));
        builder.ApplyConfiguration(new BlogCommentConfiguration(dbSchema));
        builder.ApplyConfiguration(new SubscriberConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuoteRequestConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuoteRequestAttachmentConfiguration(dbSchema));

        //Seed Users Data
        Seed(builder);
    }

    public static void Seed(ModelBuilder builder)
    {
        // Seed roles
        var adminRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" };
        var mgrRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Manager", NormalizedName = "MANAGER" };
        var modRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Moderator", NormalizedName = "MODERATOR" };

        builder.Entity<IdentityRole<Guid>>().HasData(
            adminRole, mgrRole, modRole,
            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Editor", NormalizedName = "EDITOR" },
            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Client", NormalizedName = "CLIENT" },
            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Visitor", NormalizedName = "VISITOR" }
        );

        // Seed users

        var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
        var hasher = new PasswordHasher<IdentityUser<Guid>>();

        byte[] randomBytes = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomBytes);
        }

        var adminIdentityUsr = new IdentityUser<Guid>()
        {
            Id = Guid.NewGuid(),
            UserName = "jc.mangubat@hotmail.com",
            NormalizedUserName = "JC.MANGUBAT@HOTMAIL.COM",
            Email = "jc.mangubat@hotmail.com",
            NormalizedEmail = "JC.MANGUBAT@HOTMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "letmein123."),
            SecurityStamp = $"{new Guid(randomBytes)}_{timestamp}",
            PhoneNumber = "+639672814641"
        };
        var mgrIdentityUsr = new IdentityUser<Guid>
        {
            Id = Guid.NewGuid(),
            UserName = "ladonconst@gmail.com",
            NormalizedUserName = "LADONCONST@GMAIL.COM",
            Email = "ladonconst@gmail.com",
            NormalizedEmail = "LADONCONST@GMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "letmein123."),
            SecurityStamp = $"{new Guid(randomBytes)}_{timestamp}",
            PhoneNumber = "+639951225449"
        };
        builder.Entity<IdentityUser<Guid>>().HasData(adminIdentityUsr, mgrIdentityUsr);

        // Assign users to their roles
        builder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid> { UserId = adminIdentityUsr.Id, RoleId = adminRole.Id },
            new IdentityUserRole<Guid> { UserId = mgrIdentityUsr.Id, RoleId = mgrRole.Id }
        );

        var adminUsrProfile = new UserProfileModel
        {
            Id = Guid.NewGuid(),
            IdentityUserId = adminIdentityUsr.Id,
            FirstName = "James",
            LastName = "Mangubat",
            Gender = GendersEnum.Male,
            ClientCode = null,
            ThumbnailUrl = "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg",
            MobilePhoneNo = "+639672814641",
        };

        var mgrUsrProfile = new UserProfileModel
        {
            Id = Guid.NewGuid(),
            IdentityUserId = mgrIdentityUsr.Id,
            FirstName = "Charles",
            LastName = "Reyes",
            Gender = GendersEnum.Male,
            ClientCode = null,
            ThumbnailUrl = "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png",
            MobilePhoneNo = "+639951225449",
        };

        // Seed the Application user 
        builder.Entity<UserProfileModel>().HasData(adminUsrProfile, mgrUsrProfile);

        // Seed addresses
        builder.Entity<Address>().HasData(
            new Address
            {
                Id = Guid.NewGuid(),
                UserProfileId = adminUsrProfile.Id, // Assign the address to the ApplicationUser
                AddressType = AddressTypesEnum.WorkOrOfficeAddress,
                AddressLine1 = "Lot20 Blk10 Park Villas 1",
                AddressLine2 = "Ellenita Heights, Catalunan Grande",
                City = "Davao",
                Region = "Davao del Sur",
                Country = "Philippines",
                PostalCode = "8000"
            },
            new Address
            {
                Id = Guid.NewGuid(),
                UserProfileId = mgrUsrProfile.Id, // Assign the address to the ApplicationUser
                AddressType = AddressTypesEnum.WorkOrOfficeAddress,
                AddressLine1 = "",
                AddressLine2 = "Tierra Nueva Tacunan, Tugbok",
                City = "Davao",
                Region = "Davao del Sur",
                Country = "Philippines",
                PostalCode = "8000"
            }
        );

        // Seed site areas:
        builder.Entity<SiteArea>().HasData(
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-01", Name = "About" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-02", Name = "Service" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-03", Name = "Teams" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-04", Name = "Projects" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-05", Name = "Blogs" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-06", Name = "FAQs" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-07", Name = "ClientReviews" },
            new SiteArea { Id = Guid.NewGuid(), Code = "LCS-08", Name = "Contact" }
        );

        // Seed blog posts
        var blogPostId = Guid.NewGuid();
        builder.Entity<BlogPost>().HasData(
            new BlogPost
            {
                Id = blogPostId,
                Title = "Sanctifying Spaces: Crafting Sacred Church Architecture",
                Content = "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.",
                PublishedDate = DateTime.UtcNow,
                Slug = "sanctifying-spaces-crafting-sacred-church-architecture",
                AuthorUserProfileId = adminUsrProfile.Id // Ensure this matches the seeded admin user ID
            }
        );

        // Seed blog comments if necessary
        builder.Entity<BlogComment>().HasData(
            new BlogComment
            {
                Id = Guid.NewGuid(),
                Email = "commenter@gmail.com",
                BlogPostId = blogPostId,
                CommentText = "This is a fantastic article!",
                AuthorName = "John Doe"
            }
        );
    }
}
