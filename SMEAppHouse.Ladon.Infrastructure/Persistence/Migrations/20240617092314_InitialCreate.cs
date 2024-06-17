using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                schema: "dbo",
                columns: table => new
                {
                    ArticleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 472, DateTimeKind.Local).AddTicks(6874)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.ArticleCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataProtectionKeys",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xml = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProtectionKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                schema: "dbo",
                columns: table => new
                {
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 473, DateTimeKind.Local).AddTicks(3862)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "dbo",
                columns: table => new
                {
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 462, DateTimeKind.Local).AddTicks(7408)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    IdentityUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    MobilePhoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BusinessInstitutionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserProfileId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "dbo",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 463, DateTimeKind.Local).AddTicks(5891)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                schema: "dbo",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 464, DateTimeKind.Local).AddTicks(4601)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ArticleType = table.Column<int>(type: "int", nullable: false),
                    ArticleStatus = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentSourceMDFileName = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    ContentSourceMDCDNUrl = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Hearts = table.Column<int>(type: "int", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ArticleOverview = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    CanonicalUrl = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    AuthorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    AuthorAvatarImageCDNUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_UserProfiles_AuthorUserProfileId",
                        column: x => x.AuthorUserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "ClientTestimonies",
                schema: "dbo",
                columns: table => new
                {
                    ClientTestimonyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 464, DateTimeKind.Local).AddTicks(2130)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ClientProfession = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ClientBusinessName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    ClientThumnailUrl = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: true),
                    ProjectImageUrl = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: true),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTestimonies", x => x.ClientTestimonyId);
                    table.ForeignKey(
                        name: "FK_ClientTestimonies_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                schema: "dbo",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 463, DateTimeKind.Local).AddTicks(3915)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ContentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MobilePhoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SiteMessageSource = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "QuoteRequests",
                schema: "dbo",
                columns: table => new
                {
                    QuoteRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 474, DateTimeKind.Local).AddTicks(654)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StateOrRegion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SiteProjectName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SiteAddressLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SiteAddressLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SiteStateOrRegion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SiteCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SiteZipCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SiteCountryCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ProjectCategory = table.Column<int>(type: "int", nullable: true),
                    ProjectServiceTypeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DesiredStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DesiredEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectDurationMonths = table.Column<int>(type: "int", nullable: true),
                    ProjectDurationDays = table.Column<int>(type: "int", nullable: true),
                    ProjectDurationHours = table.Column<int>(type: "int", nullable: true),
                    SquareArea = table.Column<double>(type: "float", nullable: true),
                    SquareAreaUoM = table.Column<int>(type: "int", nullable: true),
                    NumberOfFloors = table.Column<int>(type: "int", nullable: true),
                    SpecialRequirementsOrFeatures = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: true),
                    BudgetMinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BudgetMaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BudgetSpecificAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdditionalCommentsOrQuestions = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: true),
                    PreferredCommunicationMethod = table.Column<int>(type: "int", nullable: false),
                    ReferralSource = table.Column<int>(type: "int", nullable: false),
                    RequestorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteRequests", x => x.QuoteRequestId);
                    table.ForeignKey(
                        name: "FK_QuoteRequests_UserProfiles_RequestorUserProfileId",
                        column: x => x.RequestorUserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(112)", maxLength: 112, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(112)", maxLength: 112, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleAssociation",
                schema: "dbo",
                columns: table => new
                {
                    SourceArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAssociation", x => new { x.SourceArticleId, x.TargetArticleId });
                    table.ForeignKey(
                        name: "FK_ArticleAssociation_Articles_SourceArticleId",
                        column: x => x.SourceArticleId,
                        principalSchema: "dbo",
                        principalTable: "Articles",
                        principalColumn: "ArticleId");
                    table.ForeignKey(
                        name: "FK_ArticleAssociation_Articles_TargetArticleId",
                        column: x => x.TargetArticleId,
                        principalSchema: "dbo",
                        principalTable: "Articles",
                        principalColumn: "ArticleId");
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategoryAssociation",
                schema: "dbo",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategoryAssociation", x => new { x.ArticleId, x.ArticleCategoryId });
                    table.ForeignKey(
                        name: "FK_ArticleCategoryAssociation_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalSchema: "dbo",
                        principalTable: "ArticleCategories",
                        principalColumn: "ArticleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategoryAssociation_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalSchema: "dbo",
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComments",
                schema: "dbo",
                columns: table => new
                {
                    ArticleCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 473, DateTimeKind.Local).AddTicks(965)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComments", x => x.ArticleCommentId);
                    table.ForeignKey(
                        name: "FK_ArticleComments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalSchema: "dbo",
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleImages",
                schema: "dbo",
                columns: table => new
                {
                    ArticleImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 472, DateTimeKind.Local).AddTicks(9025)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    ImageCDNUrl = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleImages", x => x.ArticleImageId);
                    table.ForeignKey(
                        name: "FK_ArticleImages_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalSchema: "dbo",
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                schema: "dbo",
                columns: table => new
                {
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 474, DateTimeKind.Local).AddTicks(6167)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsImportant = table.Column<bool>(type: "bit", nullable: true),
                    RelatedArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.QuestionAnswerId);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_Articles_RelatedArticleId",
                        column: x => x.RelatedArticleId,
                        principalSchema: "dbo",
                        principalTable: "Articles",
                        principalColumn: "ArticleId");
                });

            migrationBuilder.CreateTable(
                name: "QuoteRequestAttachments",
                schema: "dbo",
                columns: table => new
                {
                    QuoteRequestAttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 17, 17, 23, 13, 474, DateTimeKind.Local).AddTicks(4319)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    OriginalFilename = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AssetCDNUrl = table.Column<string>(type: "nvarchar(2400)", maxLength: 2400, nullable: true),
                    QuoteRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteRequestAttachments", x => x.QuoteRequestAttachmentId);
                    table.ForeignKey(
                        name: "FK_QuoteRequestAttachments_QuoteRequests_QuoteRequestId",
                        column: x => x.QuoteRequestId,
                        principalSchema: "dbo",
                        principalTable: "QuoteRequests",
                        principalColumn: "QuoteRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("00dce585-e312-4e6a-891d-feb2c8842277"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7279), true, "Health and Wellness in Construction" },
                    { new Guid("0a925f23-f84b-41dd-a9f8-dcc3c6bbeecb"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7364), true, "Property Management" },
                    { new Guid("0e6755e4-a39c-499e-8b9e-b0822901927e"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7236), true, "Design and Architecture" },
                    { new Guid("10e65a13-272f-4f9b-8512-757244ec41b1"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7240), true, "Energy Efficiency" },
                    { new Guid("11ae3d54-e9f6-406a-8c69-792658062846"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7230), true, "Construction Techniques" },
                    { new Guid("137a3e74-57fb-4875-b2d5-5d2147466d99"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7348), true, "Innovation and Future Trends" },
                    { new Guid("1483a457-1370-41e1-a383-dbbe1a03d7cc"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7346), true, "Industry News" },
                    { new Guid("14d07496-9e79-47c8-bfa2-1f5845d3dcd4"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7358), true, "Materials and Equipment" },
                    { new Guid("1ab4fbe7-1e64-45fd-83fd-d186ab3384d4"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7373), true, "Smart Home Technology" },
                    { new Guid("28aa1da3-2842-47ef-bfcf-9f4f7f5c4927"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7344), true, "Home Improvement and DIY" },
                    { new Guid("343c88ba-2f8f-4fd2-8140-b816aa0b6a64"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7196), true, "Building Codes and Standards" },
                    { new Guid("36108267-9dd2-4bfc-874a-fb531c986c8d"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7234), true, "Customer Stories and Interviews" },
                    { new Guid("4303f904-c300-47d5-ba91-fb9a77b2927e"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(5321), true, "Accessibility in Construction" },
                    { new Guid("4a9576a4-d036-4719-84eb-28456d74f26d"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7384), true, "Weather and Seasonal Tips" },
                    { new Guid("5c7e8d17-648b-453f-a672-eb187705a6bc"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7216), true, "Community and Culture" },
                    { new Guid("66eeabf9-e05c-4b5d-bb5d-42b40402a4fe"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7214), true, "Client Resources" },
                    { new Guid("6c887c19-820f-4fa6-a9ba-c4a61f3654cc"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7378), true, "Technology in Construction" },
                    { new Guid("6f944bf5-9a6e-4b8a-b25e-653138b6709f"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7368), true, "Safety and Compliance" },
                    { new Guid("7183c54e-5755-42a7-be07-9a6f7eff6996"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7220), true, "Construction Careers" },
                    { new Guid("788ad824-5fe7-441d-9b52-e4bf88cf3daf"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7354), true, "Landscaping and Outdoor Design" },
                    { new Guid("79480a7e-31b8-4b2c-8258-b0b691c4ff32"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7376), true, "Sustainability and Green Building" },
                    { new Guid("797a49aa-baf4-4ea2-8419-7bdf3eff1001"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7350), true, "Innovation Awards and Recognitions" },
                    { new Guid("7a1301bc-1ddb-430b-8178-bfe8a3071ff3"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7238), true, "Disaster Preparedness and Recovery" },
                    { new Guid("7dcc2d92-894a-4b2e-b319-eccc62beca23"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7270), true, "Environmental Impact" },
                    { new Guid("8dbe67a9-33fb-4872-99d9-6550085202a8"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7282), true, "Historic Preservation" },
                    { new Guid("8e734cb8-494a-4b9a-add1-aac9979c2f4b"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7211), true, "Client Education" },
                    { new Guid("9f8d9128-54c8-40fa-b991-feb5ba04b821"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7275), true, "Equipment Maintenance" },
                    { new Guid("ae5f084e-20bb-4bc4-84fe-b074f2acdd45"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7218), true, "Company Updates" },
                    { new Guid("b01c2bdb-53ee-4c21-a824-311d3c7dbd32"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7374), true, "Supply Chain and Logistics" },
                    { new Guid("b0bb475a-294d-4adb-9539-9c48899784d6"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7356), true, "Legal and Insurance" },
                    { new Guid("b38cf726-2e7a-414a-a51c-aa0b4f570b9a"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7382), true, "Urban Planning and Development" },
                    { new Guid("cee5fb61-76b0-4af0-a44e-9df714d11f29"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7366), true, "Real Estate Development" },
                    { new Guid("d7600f8f-2789-4b03-a7bb-0dca002d017a"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7362), true, "Project Showcase" },
                    { new Guid("db1dfd2b-4282-421b-b3f8-4fb29faa3152"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7228), true, "Construction Management" },
                    { new Guid("df641bbd-d89f-420c-878a-c634059f5027"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7222), true, "Construction Finance" },
                    { new Guid("e0788f87-e89d-4d61-a02b-2de8ba43bf20"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7380), true, "Training and Certification" },
                    { new Guid("e5cbe7bb-0ac7-4a7f-9e15-5952e908d7e1"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7209), true, "Case Studies and Success Stories" },
                    { new Guid("e78bfc85-7661-4da4-bb8c-baeaa80eef5c"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7360), true, "Modular and Prefabricated Construction" },
                    { new Guid("f36f285d-d769-4045-b8a0-d8cae4c5d463"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7278), true, "Green Building Materials" },
                    { new Guid("fc79c7f7-57b8-45a0-893c-40624c3ccb9a"), new DateTime(2024, 6, 17, 9, 23, 12, 191, DateTimeKind.Utc).AddTicks(7232), true, "Cost Estimation and Budgeting" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("2162460f-ba6b-4a6b-8c79-dd19ca70870c"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8372), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("264c9d72-35cc-4133-bdc2-046d8b51efe2"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(7964), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("42779084-531c-4a82-8c5e-a64629690ad4"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8601), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8537), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("6024dc2d-2f2e-427b-be0a-fa3e1a7c61db"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8679), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("6b2bee1e-eb10-49eb-81a6-71ef8ee52d40"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8415), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("8e8a78e0-160e-45c7-a1ac-7c73fae11297"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8455), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("a1c5ba06-f212-4442-b88c-67cded9c3b0b"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8639), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("e261b356-b229-4db3-8af1-91687304c703"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8314), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0b08e8bf-c288-4393-b69e-98e1186c3eeb"), null, "Client", "CLIENT" },
                    { new Guid("36af103c-9800-4483-8762-e6bf6229f7cd"), null, "Editor", "EDITOR" },
                    { new Guid("3fd21aed-f5f5-4ce7-b930-6f5c306ba9e1"), null, "Admin", "ADMIN" },
                    { new Guid("663a9160-4aab-4cb2-be04-83b7b2d4b03c"), null, "Visitor", "VISITOR" },
                    { new Guid("6c3117eb-8e97-413e-ba53-96e7b1b5eda0"), null, "Manager", "MANAGER" },
                    { new Guid("8c6fa8fc-6ed4-459d-b5b6-4d7157205b4a"), null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("4e77177a-53a9-4c42-b157-72cb292eb67c"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(9533), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("654b065c-91f9-416d-b106-a9588cedfdcf"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(9543), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("81454925-6193-4beb-bd68-53beba2071ae"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(9545), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("94d20497-3150-47ea-866e-23ae87ac5a00"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(9540), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("063446d7-ae07-40bb-81c4-8fcb9d638c9c"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(106), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("09d75475-1e74-4956-a315-9b8c42aa2282"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(111), true, true, "How do you handle project timelines?", null },
                    { new Guid("2062db1e-02dd-4f4c-8e3d-ab1ed2d7f01c"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(136), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("2c7e6c85-f593-49c9-86d3-0468f473dd55"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(158), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("40e20c9a-e4d1-4a3d-bf2c-824648bc3b33"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(156), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("5a899bf3-a1b3-4cae-823e-f27ad392ef29"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(123), true, null, "Do you offer financing options?", null },
                    { new Guid("6886ed6b-64df-4cf6-9806-52dc6ba027dd"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(109), true, null, "How can I get a quote for my project?", null },
                    { new Guid("70b75821-24ee-4ba5-9185-5b21fff715b7"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(125), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("7d39f6e6-6f21-4531-966d-40bb92a956e5"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(149), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("7f726cca-4dbb-47d4-b56c-a36a837d5218"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(150), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("811c9da7-5373-46e3-8bea-cc14d59fed06"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(161), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("85a8d2ca-0093-4fda-8f1f-8e58a3a8d0ce"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(121), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("8cf7510c-8a75-4986-a6a8-49406dffd262"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(159), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("940b6864-b34c-4f47-828d-cd51c8989eed"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(114), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("9533aed0-1c73-4ddd-b034-fa7ed92ab36b"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(119), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("982985ba-afe5-4277-a606-260c262d146b"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(154), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("9eae2b7d-cb0a-44c4-839d-30b0b5aba3e0"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(102), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("a576b41f-1d50-4e31-accc-781b306a4d89"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(113), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("c0fea72d-0014-4034-9952-d57a60aba201"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(134), true, null, "How do I pay for my project?", null },
                    { new Guid("c7c228f1-758e-4380-971d-f76772d8f352"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(144), true, true, "Are you licensed and insured?", null },
                    { new Guid("e82f11a6-4d34-4e91-95b4-a5b3b4387a09"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(152), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("f7f4ffa1-ed60-43d5-a7e6-8ed3237c82c9"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(138), true, null, "What safety measures do you take on construction sites?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("84750a44-3a3f-462a-9dc0-5aed66d7fa74"), null, null, new DateTime(2024, 6, 17, 9, 23, 13, 609, DateTimeKind.Utc).AddTicks(9882), "James", 0, new Guid("35e3cb1b-edbf-454a-8263-475757d668d8"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("a2f4e407-5e41-48d4-80fe-11b4debf747f"), null, null, new DateTime(2024, 6, 17, 9, 23, 13, 609, DateTimeKind.Utc).AddTicks(9924), "Charles", 0, new Guid("e19da5fd-d922-49cd-aadb-ca1f2fe6d6d5"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("35e3cb1b-edbf-454a-8263-475757d668d8"), 0, "d1dbae2a-afd4-4eda-b574-c79207654a0c", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIn/kupO5FnxEz5apOvcIXaj7heu4OG/+zkfp7TCoj7r52Ykyety5PLVHT2wXyZoUw==", "+639672814641", false, "6a73ff1a-013d-1083-01bd-44fd9ee38349_20240617092313474", false, "jc.mangubat@hotmail.com" },
                    { new Guid("e19da5fd-d922-49cd-aadb-ca1f2fe6d6d5"), 0, "2c0755d9-2505-4bf3-b195-a942274317d8", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEC4VZiwbBhnngPkMx7xHkWWCwRmNuRkcfI0edWCPWsSGhH+EpCDVHKNlvs7jQt2UdQ==", "+639951225449", false, "6a73ff1a-013d-1083-01bd-44fd9ee38349_20240617092313474", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("02cdfcf0-bc5a-4b33-8e68-4943a64e2838"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(46), true, "8000", "Davao del Sur", new Guid("84750a44-3a3f-462a-9dc0-5aed66d7fa74") },
                    { new Guid("17d56cd4-3927-458b-b934-d6f348706e96"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 17, 9, 23, 13, 610, DateTimeKind.Utc).AddTicks(52), true, "8000", "Davao del Sur", new Guid("a2f4e407-5e41-48d4-80fe-11b4debf747f") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("8e734cb8-494a-4b9a-add1-aac9979c2f4b"), new Guid("264c9d72-35cc-4133-bdc2-046d8b51efe2") },
                    { new Guid("ae5f084e-20bb-4bc4-84fe-b074f2acdd45"), new Guid("264c9d72-35cc-4133-bdc2-046d8b51efe2") },
                    { new Guid("1483a457-1370-41e1-a383-dbbe1a03d7cc"), new Guid("42779084-531c-4a82-8c5e-a64629690ad4") },
                    { new Guid("ae5f084e-20bb-4bc4-84fe-b074f2acdd45"), new Guid("42779084-531c-4a82-8c5e-a64629690ad4") },
                    { new Guid("d7600f8f-2789-4b03-a7bb-0dca002d017a"), new Guid("42779084-531c-4a82-8c5e-a64629690ad4") },
                    { new Guid("1483a457-1370-41e1-a383-dbbe1a03d7cc"), new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4") },
                    { new Guid("8e734cb8-494a-4b9a-add1-aac9979c2f4b"), new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4") },
                    { new Guid("ae5f084e-20bb-4bc4-84fe-b074f2acdd45"), new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4") },
                    { new Guid("db1dfd2b-4282-421b-b3f8-4fb29faa3152"), new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4") },
                    { new Guid("79480a7e-31b8-4b2c-8258-b0b691c4ff32"), new Guid("6024dc2d-2f2e-427b-be0a-fa3e1a7c61db") },
                    { new Guid("1483a457-1370-41e1-a383-dbbe1a03d7cc"), new Guid("6b2bee1e-eb10-49eb-81a6-71ef8ee52d40") },
                    { new Guid("ae5f084e-20bb-4bc4-84fe-b074f2acdd45"), new Guid("6b2bee1e-eb10-49eb-81a6-71ef8ee52d40") },
                    { new Guid("79480a7e-31b8-4b2c-8258-b0b691c4ff32"), new Guid("a1c5ba06-f212-4442-b88c-67cded9c3b0b") },
                    { new Guid("8e734cb8-494a-4b9a-add1-aac9979c2f4b"), new Guid("e261b356-b229-4db3-8af1-91687304c703") },
                    { new Guid("e0788f87-e89d-4d61-a02b-2de8ba43bf20"), new Guid("e261b356-b229-4db3-8af1-91687304c703") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[,]
                {
                    { new Guid("02565906-c4b9-4445-8530-f3552296bd9a"), new Guid("264c9d72-35cc-4133-bdc2-046d8b51efe2"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8289), "commenter@gmail.com", true },
                    { new Guid("0fc49a92-ac2b-4657-b3d7-1c157895c089"), new Guid("a1c5ba06-f212-4442-b88c-67cded9c3b0b"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8668), "commenter@gmail.com", true },
                    { new Guid("14b25cf9-6bfc-4a65-88ce-84d163250077"), new Guid("8e8a78e0-160e-45c7-a1ac-7c73fae11297"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8488), "commenter@gmail.com", true },
                    { new Guid("1bcfb9d4-456b-47dc-b18b-6396a1ee2cb7"), new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8591), "commenter@gmail.com", true },
                    { new Guid("22c9f18f-29cd-4b59-9acc-75dfbdf0b5ab"), new Guid("6024dc2d-2f2e-427b-be0a-fa3e1a7c61db"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8710), "commenter@gmail.com", true },
                    { new Guid("31374b84-5313-47e3-8869-2c1da254077d"), new Guid("6b2bee1e-eb10-49eb-81a6-71ef8ee52d40"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8449), "commenter@gmail.com", true },
                    { new Guid("4fb4de9a-265e-4865-bf55-5cce12cfe9b0"), new Guid("42779084-531c-4a82-8c5e-a64629690ad4"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8633), "commenter@gmail.com", true },
                    { new Guid("5da58152-a4f7-42e2-96ae-8933f8215a0c"), new Guid("e261b356-b229-4db3-8af1-91687304c703"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8357), "commenter@gmail.com", true },
                    { new Guid("cdc4144d-1382-4123-b385-e20b3638f83f"), new Guid("2162460f-ba6b-4a6b-8c79-dd19ca70870c"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8405), "commenter@gmail.com", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("301e089c-b9ea-4f54-80e3-7656be883a3f"), new Guid("8e8a78e0-160e-45c7-a1ac-7c73fae11297"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8497), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("39a4457c-3108-48f1-826f-d5e906b63730"), new Guid("a1c5ba06-f212-4442-b88c-67cded9c3b0b"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8672), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("5ea2bdcd-b0d3-4d9d-a550-3401908d2d90"), new Guid("2162460f-ba6b-4a6b-8c79-dd19ca70870c"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8408), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("696022aa-e51b-40ad-9b0c-bf838729742e"), new Guid("e261b356-b229-4db3-8af1-91687304c703"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8368), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("8be0f603-8c9f-4193-971c-f5ac6918f6ce"), new Guid("264c9d72-35cc-4133-bdc2-046d8b51efe2"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8306), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("8e55ab9b-16a5-4fa6-9af0-f5fcab372127"), new Guid("6024dc2d-2f2e-427b-be0a-fa3e1a7c61db"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8713), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("c7b553b3-cddd-47d6-bffc-e6a42ecd58b2"), new Guid("42779084-531c-4a82-8c5e-a64629690ad4"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8635), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("d2561089-a378-494f-b3a1-85e8bd5dbde5"), new Guid("6b2bee1e-eb10-49eb-81a6-71ef8ee52d40"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8452), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("f9e027fc-5949-46a8-9fb6-adac5d4a8a92"), new Guid("5481a58b-e692-46ac-8ab3-8ac86e56cac4"), new DateTime(2024, 6, 17, 9, 23, 13, 614, DateTimeKind.Utc).AddTicks(8596), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3fd21aed-f5f5-4ce7-b930-6f5c306ba9e1"), new Guid("35e3cb1b-edbf-454a-8263-475757d668d8") },
                    { new Guid("6c3117eb-8e97-413e-ba53-96e7b1b5eda0"), new Guid("e19da5fd-d922-49cd-aadb-ca1f2fe6d6d5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserProfileId",
                schema: "dbo",
                table: "Addresses",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleAssociation_TargetArticleId",
                schema: "dbo",
                table: "ArticleAssociation",
                column: "TargetArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategoryAssociation_ArticleCategoryId",
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_ArticleId",
                schema: "dbo",
                table: "ArticleComments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleImages_ArticleId",
                schema: "dbo",
                table: "ArticleImages",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorUserProfileId",
                schema: "dbo",
                table: "Articles",
                column: "AuthorUserProfileId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTestimonies_UserProfileId",
                schema: "dbo",
                table: "ClientTestimonies",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserProfileId",
                schema: "dbo",
                table: "Messages",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_RelatedArticleId",
                schema: "dbo",
                table: "QuestionAnswers",
                column: "RelatedArticleId",
                unique: true,
                filter: "[RelatedArticleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteRequestAttachments_QuoteRequestId",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                column: "QuoteRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteRequests_RequestorUserProfileId",
                schema: "dbo",
                table: "QuoteRequests",
                column: "RequestorUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "dbo",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "dbo",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "dbo",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_FirstName_LastName",
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "dbo",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticleAssociation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticleCategoryAssociation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticleComments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticleImages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ClientTestimonies",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DataProtectionKeys",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Messages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "QuestionAnswers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "QuoteRequestAttachments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Subscribers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticleCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Articles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "QuoteRequests",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "dbo");
        }
    }
}
