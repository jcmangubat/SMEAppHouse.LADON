using System.Security.Cryptography;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMEAppHouse.Core.Patterns.EF.SettingsModel;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;
using SMEAppHouse.Ladon.Infrastructure.SeedData.Articles;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;
using DataProtectionKey = Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey;
namespace SMEAppHouse.Ladon.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, DbMigrationInformation? dbMigrationInformation = null)
    : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>(options), IDataProtectionKeyContext
{
    private readonly DbMigrationInformation _dbMigrationInformation = dbMigrationInformation;
    private readonly List<ArticleCategory> _articleCategories = [
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Accessibility in Construction" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Building Codes and Standards" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Case Studies and Success Stories" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Client Education" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Client Resources" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Community and Culture" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Company Updates" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Construction Careers" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Construction Finance" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Construction Management" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Construction Techniques" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Cost Estimation and Budgeting" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Customer Stories and Interviews" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Design and Architecture" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Disaster Preparedness and Recovery" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Energy Efficiency" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Environmental Impact" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Equipment Maintenance" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Green Building Materials" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Health and Wellness in Construction" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Historic Preservation" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Home Improvement and DIY" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Industry News" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Innovation and Future Trends" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Innovation Awards and Recognitions" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Landscaping and Outdoor Design" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Legal and Insurance" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Materials and Equipment" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Modular and Prefabricated Construction" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Project Showcase" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Property Management" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Real Estate Development" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Safety and Compliance" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Smart Home Technology" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Supply Chain and Logistics" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Sustainability and Green Building" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Technology in Construction" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Training and Certification" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Urban Planning and Development" },
            new ArticleCategory() { Id = Guid.NewGuid(), Name = "Weather and Seasonal Tips" } ];

    public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
    public virtual DbSet<UserProfile> UserProfiles { get; set; }
    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<Address> Addresses { get; set; }
    public virtual DbSet<ClientTestimony> ClientTestimonies { get; set; }

    public virtual DbSet<Article> Articles { get; set; }
    public virtual DbSet<ArticleCategory> ArticleCategories { get; set; }

    public virtual DbSet<ArticleComment> ArticleComments { get; set; }
    public virtual DbSet<Subscriber> Subscribers { get; set; }
    public virtual DbSet<QuoteRequest> QuoteRequests { get; set; }
    public virtual DbSet<QuoteRequestAttachment> QuoteRequestAttachments { get; set; }
    public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }

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
        builder.ApplyConfiguration(new SubscriberConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuoteRequestConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuoteRequestAttachmentConfiguration(dbSchema));
        builder.ApplyConfiguration(new QuestionAnswerConfiguration(dbSchema));

        SeedRolesAndUsers(builder);
        SeedQuestionAndAnswers(builder);
        SeedArticleCategory(builder);
        SeedArticlePostEntity(builder);
    }

    public void SeedRolesAndUsers(ModelBuilder builder)
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

        var adminUsrProfile = new UserProfile
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

        var mgrUsrProfile = new UserProfile
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
        builder.Entity<UserProfile>().HasData(adminUsrProfile, mgrUsrProfile);

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
    }

    public void SeedArticleCategory(ModelBuilder builder)
    {
        builder.Entity<ArticleCategory>().HasData(_articleCategories);
    }

    public void SeedQuestionAndAnswers(ModelBuilder builder)
    {
        builder.Entity<QuestionAnswer>().HasData(
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "What services does Ladon Construction Services offer?",
                AnswerText = "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.",
                IsImportant = true,

            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How long has Ladon Construction Services been in business?",
                AnswerText = "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How can I get a quote for my project?",
                AnswerText = "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How do you handle project timelines?",
                AnswerText = "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Can you help with the design phase of my project?",
                AnswerText = "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "What should I consider before starting a construction project?",
                AnswerText = "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Do you provide a warranty for your work?",
                AnswerText = "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How do you determine the cost of a construction project?",
                AnswerText = "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Do you offer financing options?",
                AnswerText = "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Are there any hidden fees in your estimates?",
                AnswerText = "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How do I pay for my project?",
                AnswerText = "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How do you ensure the quality of your construction work?",
                AnswerText = "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "What safety measures do you take on construction sites?",
                AnswerText = "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Are you licensed and insured?",
                AnswerText = "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How will I be updated on the progress of my project?",
                AnswerText = "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "What if I need to make changes to the project after it has started?",
                AnswerText = "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Who will be my point of contact during the project?",
                AnswerText = "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.",
                IsImportant = true,
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Can I visit the construction site during the project?",
                AnswerText = "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How do you handle project completion and handover?",
                AnswerText = "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation."
            });
    }

    public void SeedArticlePostEntity(ModelBuilder builder)
    {
        var articlesFromManifest = ArticleManifestData.Read();

        var articleEntities = new List<Article>();
        var articleImageEntities = new List<ArticleImage>();
        var articleCommentEntities = new List<ArticleComment>();
        var articleArticleCategoryAssocs = new List<dynamic>();

        foreach (var post in articlesFromManifest.Posts)
        {
            var newPostId = Guid.NewGuid();
            var outputDirectory = AppContext.BaseDirectory;
            var mdFilePath = Path.Combine(outputDirectory, "SeedData", "Articles", post.ContentFile);
            if (!File.Exists(mdFilePath))
                continue;

            var article = new Article
            {
                Id = newPostId,
                Title = post.Title,
                ArticleType = post.ArticleType,
                ContentSourceMDFileName = post.ContentFile,
                PublishedDate = post.PublishedDate,
                LastModified = post.LastModified,
                Slug = post.Slug,
                Likes = post.Likes,
                Hearts = post.Hearts,
                Views = post.Views,
                IsFeatured = post.IsFeatured,
                MetaDescription = post.MetaDescription,
                CanonicalUrl = post.CanonicalUrl,
                MetaKeywords = post.MetaKeywords,
                Tags = post.Tags,
                AuthorName = post.AuthorName,
                AuthorAvatarImageCDNUrl = post.AuthorAvatarImageCDNUrl
            };

            articleEntities.Add(article);
            foreach (var category in post.ArticleCategories)
            {
                var articleCategories = _articleCategories
                                        .Where(bc => post.ArticleCategories.Any(mbc => mbc.Name == bc.Name))
                                        .Select(p => new
                                        {
                                            ArticleId = newPostId,
                                            ArticleCategoryId = p.Id
                                        })
                                        .ToList();

                articleArticleCategoryAssocs.AddRange(articleCategories);
            }

            articleCommentEntities.Add(new ArticleComment
            {
                Id = Guid.NewGuid(),
                Email = "commenter@gmail.com",
                ArticleId = newPostId,
                CommentText = "This is a fantastic article!",
                AuthorName = "John Doe"
            });

            foreach (var imagesUrl in post.ArticleImages)
            {
                articleImageEntities.Add(new ArticleImage()
                {
                    Id = Guid.NewGuid(),
                    ImageCDNUrl = imagesUrl,
                    ArticleId = newPostId,
                });
            }
        }

        builder.Entity<Article>().HasData(articleEntities);
        builder.Entity<ArticleCategoryAssociation>().HasData(articleArticleCategoryAssocs);

        builder.Entity<ArticleComment>().HasData(articleCommentEntities);
        builder.Entity<ArticleImage>().HasData(articleImageEntities);
    }
}