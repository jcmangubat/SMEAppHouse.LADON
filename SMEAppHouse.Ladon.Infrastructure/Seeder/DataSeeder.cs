using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Infrastructure.Seeder.ManifestModels;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Infrastructure.Seeder;

public class DataSeeder(ModelBuilder builder)
{
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

    private readonly ModelBuilder _builder = builder;

    internal DataSeeder SeedRolesAndUsers()
    {
        // Seed roles
        var adminRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" };
        var mgrRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Manager", NormalizedName = "MANAGER" };
        var modRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Moderator", NormalizedName = "MODERATOR" };

        _builder.Entity<IdentityRole<Guid>>().HasData(
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
        _builder.Entity<IdentityUser<Guid>>().HasData(adminIdentityUsr, mgrIdentityUsr);

        // Assign users to their roles
        _builder.Entity<IdentityUserRole<Guid>>().HasData(
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
        _builder.Entity<UserProfile>().HasData(adminUsrProfile, mgrUsrProfile);

        // Seed addresses
        _builder.Entity<Address>().HasData(
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

        return this;
    }

    internal DataSeeder SeedArticleCategory()
    {
        _builder.Entity<ArticleCategory>().HasData(_articleCategories);
        return this;
    }

    internal DataSeeder SeedQuestionAndAnswers()
    {
        _builder.Entity<QuestionAnswer>().HasData(
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
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "Why is certification important in the construction industry?",
                AnswerText = "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "What are the risks of hiring self-claimed experienced builders?",
                AnswerText = "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects."
            },
            new QuestionAnswer
            {
                Id = Guid.NewGuid(),
                Question = "How can certified skilled workers contribute to long-term cost savings?",
                AnswerText = "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run."
            });

        return this;
    }

    internal DataSeeder SeedArticlePostEntity()
    {
        var articlesFromManifest = ArticleManifestData.Read();

        var articleEntities = new List<Article>();
        var articleImageEntities = new List<ArticleImage>();
        var articleCommentEntities = new List<ArticleComment>();
        var articleArticleCategoryAssocs = new List<dynamic>();

        foreach (var post in articlesFromManifest)
        {
            var newPostId = Guid.NewGuid();

            var article = new Article
            {
                Id = newPostId,
                Title = post.Title,
                ArticleType = post.ArticleType,
                ArticleStatus = post.ArticleStatus,
                ContentSourceMDFileName = post.ContentFilename,
                PublishedDate = post.PublishedDate,
                LastModified = post.LastModified,
                Slug = post.Slug,
                Likes = post.Likes,
                Hearts = post.Hearts,
                Views = post.Views,
                IsFeatured = post.IsFeatured,
                MetaDescription = post.MetaDescription,
                ArticleOverview = post.ArticleOverview,
                CanonicalUrl = post.CanonicalUrl,
                MetaKeywords = post.MetaKeywords,
                Tags = post.Tags,
                AuthorName = post.AuthorName,
                AuthorAvatarImageCDNUrl = post.AuthorAvatarImageCDNUrl
            };

            articleEntities.Add(article);

            var articleCategories = _articleCategories
                                        .Where(bc => post.ArticleCategories.Contains(bc.Name))
                                        .Select(p => new
                                        {
                                            ArticleId = newPostId,
                                            ArticleCategoryId = p.Id
                                        })
                                        .ToList();
            articleArticleCategoryAssocs.AddRange(articleCategories);

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

        _builder.Entity<Article>().HasData(articleEntities);
        _builder.Entity<ArticleCategoryAssociation>().HasData(articleArticleCategoryAssocs);

        _builder.Entity<ArticleComment>().HasData(articleCommentEntities);
        _builder.Entity<ArticleImage>().HasData(articleImageEntities);

        return this;
    }

    internal DataSeeder SeedTestimoniesEntity()
    {
        _builder.Entity<ClientTestimony>().HasData(
            new ClientTestimony
            {
                Id = Guid.NewGuid(),
                ClientName = "Mr. Donnie Tefasco",
                ClientProfession = "Businessman",
                ClientBusinessName = "RDN Shipping",
                ClientThumnailUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg",
                ProjectImageUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==",
                Remarks = "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!",
            },
            new ClientTestimony
            {
                Id = Guid.NewGuid(),
                ClientName = "Mr. Thomas Bernardino",
                ClientProfession = "Businessman",
                ClientBusinessName = "AgriVents (Rizal)",
                ClientThumnailUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg",
                ProjectImageUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg",
                Remarks = "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility."
            },
            new ClientTestimony
            {
                Id = Guid.NewGuid(),
                ClientName = "Mr. & Mrs. Rominadores",
                ClientProfession = "Business Proprietor",
                ClientBusinessName = "Rice Sprout Orchids",
                ClientThumnailUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg",
                ProjectImageUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130",
                Remarks = "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results."
            },
            new ClientTestimony
            {
                Id = Guid.NewGuid(),
                ClientName = "Mr. Arnold Dominguez",
                ClientProfession = "VP Operations",
                ClientBusinessName = "La Cordia Centre Mall",
                ClientThumnailUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg",
                ProjectImageUrl = "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156",
                Remarks = "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future."
            });

        return this;
    }

    internal void SeedFeatureProjectsEntity()
    {
        var featurePrjsFromManifest = FeatureProjectManifestData.Read();
        var featurePrjImgs = new List<FeatureProjectImage>(featurePrjsFromManifest.SelectMany(p => p.FeatureProjectImages));
        var featurePrjs = featurePrjsFromManifest;

        foreach (var project in featurePrjsFromManifest)
            project.FeatureProjectImages = []; // Clear the list or assign an empty list

        _builder.Entity<FeatureProject>().HasData(featurePrjs);
        _builder.Entity<FeatureProjectImage>().HasData(featurePrjImgs);
    }
}