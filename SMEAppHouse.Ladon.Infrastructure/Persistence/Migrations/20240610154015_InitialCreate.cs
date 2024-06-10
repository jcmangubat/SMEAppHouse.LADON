using System;
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 893, DateTimeKind.Local).AddTicks(5481)),
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 894, DateTimeKind.Local).AddTicks(3038)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfileModels",
                schema: "dbo",
                columns: table => new
                {
                    UserProfileModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 883, DateTimeKind.Local).AddTicks(4628)),
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
                    table.PrimaryKey("PK_UserProfileModels", x => x.UserProfileModelId);
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 884, DateTimeKind.Local).AddTicks(2693)),
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
                        name: "FK_Addresses_UserProfileModels_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfileModels",
                        principalColumn: "UserProfileModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 885, DateTimeKind.Local).AddTicks(1094)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
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
                    MetaDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CanonicalUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    AuthorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                    table.ForeignKey(
                        name: "FK_BlogPosts_UserProfileModels_AuthorUserProfileId",
                        column: x => x.AuthorUserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfileModels",
                        principalColumn: "UserProfileModelId");
                });

            migrationBuilder.CreateTable(
                name: "ClientTestimonies",
                schema: "dbo",
                columns: table => new
                {
                    ClientTestimonyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 884, DateTimeKind.Local).AddTicks(8398)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ClientProfession = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ClientBusinessName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ClientThumnailUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProjectImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTestimonies", x => x.ClientTestimonyId);
                    table.ForeignKey(
                        name: "FK_ClientTestimonies_UserProfileModels_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfileModels",
                        principalColumn: "UserProfileModelId");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                schema: "dbo",
                columns: table => new
                {
                    MessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 884, DateTimeKind.Local).AddTicks(622)),
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
                        name: "FK_Messages_UserProfileModels_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfileModels",
                        principalColumn: "UserProfileModelId");
                });

            migrationBuilder.CreateTable(
                name: "QuoteRequests",
                schema: "dbo",
                columns: table => new
                {
                    QuoteRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 894, DateTimeKind.Local).AddTicks(9896)),
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
                        name: "FK_QuoteRequests_UserProfileModels_RequestorUserProfileId",
                        column: x => x.RequestorUserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfileModels",
                        principalColumn: "UserProfileModelId");
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
                name: "BlogPostArticleCategory",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostArticleCategory", x => new { x.BlogPostId, x.ArticleCategoryId });
                    table.ForeignKey(
                        name: "FK_BlogPostArticleCategory_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalSchema: "dbo",
                        principalTable: "ArticleCategories",
                        principalColumn: "ArticleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostArticleCategory_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostComments",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 893, DateTimeKind.Local).AddTicks(9919)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostComments", x => x.BlogPostCommentId);
                    table.ForeignKey(
                        name: "FK_BlogPostComments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostImages",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 893, DateTimeKind.Local).AddTicks(7848)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    ImageCDNUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostImages", x => x.BlogPostImageId);
                    table.ForeignKey(
                        name: "FK_BlogPostImages_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogRelatedAssociation",
                schema: "dbo",
                columns: table => new
                {
                    SourceBlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetBlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRelatedAssociation", x => new { x.SourceBlogPostId, x.TargetBlogPostId });
                    table.ForeignKey(
                        name: "FK_BlogRelatedAssociation_BlogPosts_SourceBlogPostId",
                        column: x => x.SourceBlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId");
                    table.ForeignKey(
                        name: "FK_BlogRelatedAssociation_BlogPosts_TargetBlogPostId",
                        column: x => x.TargetBlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId");
                });

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                schema: "dbo",
                columns: table => new
                {
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 895, DateTimeKind.Local).AddTicks(5748)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    IsImportant = table.Column<bool>(type: "bit", nullable: true),
                    RelatedBlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.QuestionAnswerId);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_BlogPosts_RelatedBlogPostId",
                        column: x => x.RelatedBlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId");
                });

            migrationBuilder.CreateTable(
                name: "QuoteRequestAttachments",
                schema: "dbo",
                columns: table => new
                {
                    QuoteRequestAttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 10, 23, 40, 14, 895, DateTimeKind.Local).AddTicks(3747)),
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
                    { new Guid("0193565e-6fca-47c1-8dac-d8e770a90358"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8252), true, "Company Updates" },
                    { new Guid("05ea97a6-cb02-4863-931d-3f18443c8a53"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8343), true, "Smart Home Technology" },
                    { new Guid("0e458c28-529f-46f8-adbf-6ebd3247a6ef"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8347), true, "Sustainability and Green Building" },
                    { new Guid("1b766757-422c-47e6-bc17-878146d5fcc9"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8329), true, "Materials and Equipment" },
                    { new Guid("376d3333-b298-4b45-be30-ddd2a9e70392"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8331), true, "Modular and Prefabricated Construction" },
                    { new Guid("38e9682a-a257-43a1-9148-e1f2d3fba0c8"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8274), true, "Energy Efficiency" },
                    { new Guid("3c64557b-e82a-4960-ac89-ebde0b2db007"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8305), true, "Equipment Maintenance" },
                    { new Guid("45bcba6c-f4a1-40b2-ad45-94d3e96cf945"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8353), true, "Urban Planning and Development" },
                    { new Guid("4694d080-7828-4d0e-aca3-9500dddde88a"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8311), true, "Historic Preservation" },
                    { new Guid("483a3750-7712-4071-9d32-d7bfeb214632"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8327), true, "Legal and Insurance" },
                    { new Guid("4870ed27-45cb-492f-b251-99d82ae6079f"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8246), true, "Client Education" },
                    { new Guid("4a3c9d58-842f-4482-b7b8-5f98854476a6"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8309), true, "Health and Wellness in Construction" },
                    { new Guid("4be8ad93-33ef-4310-a8a1-68708825d7a2"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8266), true, "Cost Estimation and Budgeting" },
                    { new Guid("4d8955dd-c518-471a-9210-1591d29b5f58"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8307), true, "Green Building Materials" },
                    { new Guid("6a4f7fef-c711-41bf-bf99-24b74a210268"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8313), true, "Home Improvement and DIY" },
                    { new Guid("7714d38f-c68c-432f-ae3d-1a082fefe024"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8319), true, "Innovation and Future Trends" },
                    { new Guid("800e8620-5e42-41c8-a931-4ac0bb95c292"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8317), true, "Industry News" },
                    { new Guid("84200a9d-51a6-4306-94bf-dc07f4486e8c"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8333), true, "Project Showcase" },
                    { new Guid("86396238-4c84-406e-bcb0-78110346511d"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8301), true, "Environmental Impact" },
                    { new Guid("8baaf5bd-ada9-4fce-b12e-7f8422104be7"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8256), true, "Construction Finance" },
                    { new Guid("8c704877-b547-4cf4-9b0c-72eefa0a3ef7"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8272), true, "Disaster Preparedness and Recovery" },
                    { new Guid("935c537c-2fc5-4b9a-b304-df9daf8cd3c5"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8249), true, "Community and Culture" },
                    { new Guid("942b34d7-b7a4-4a7f-ae54-55df12fafddc"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8321), true, "Innovation Awards and Recognitions" },
                    { new Guid("95597eca-790e-4e9c-aecd-a360a9cf3be6"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8337), true, "Real Estate Development" },
                    { new Guid("9a30791d-21e3-41b2-8d27-919a22ae4a46"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8345), true, "Supply Chain and Logistics" },
                    { new Guid("9a800635-7fbf-4bcb-89b5-e3cbb84a0ca6"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8325), true, "Landscaping and Outdoor Design" },
                    { new Guid("9c3c65a0-3125-4cbb-bb00-062b62f0f245"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8355), true, "Weather and Seasonal Tips" },
                    { new Guid("a768ce77-31eb-445e-8de6-390371c8832f"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8254), true, "Construction Careers" },
                    { new Guid("ada6987a-7b77-4523-8cf6-ccf6f789fd55"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(6749), true, "Accessibility in Construction" },
                    { new Guid("ae129d96-4545-4db4-9bbc-e1caf5570be3"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8264), true, "Construction Techniques" },
                    { new Guid("b15168de-0e5d-4352-a586-ed3881f43072"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8248), true, "Client Resources" },
                    { new Guid("b30de336-c412-4f73-b7a8-6f9354c14dbb"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8230), true, "Building Codes and Standards" },
                    { new Guid("bbe8db04-0ce8-4884-9188-c8c16ba18cf0"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8268), true, "Customer Stories and Interviews" },
                    { new Guid("be9c912b-1a94-4081-aea2-8b71c6b3bac1"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8349), true, "Technology in Construction" },
                    { new Guid("c92a2482-bd07-4c8d-81db-8b2613e66a51"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8351), true, "Training and Certification" },
                    { new Guid("d09adda2-7750-4536-80f7-ecac0efd8a3a"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8243), true, "Case Studies and Success Stories" },
                    { new Guid("d427fc0e-7c80-4cd1-825b-fc660efa2e52"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8335), true, "Property Management" },
                    { new Guid("d8f8053b-2d55-4f73-95c5-88e476ed6b08"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8270), true, "Design and Architecture" },
                    { new Guid("e5b24c7d-5479-485e-b1a0-811ace2ee968"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8262), true, "Construction Management" },
                    { new Guid("ebf57841-cd2b-4fcf-99f8-00c45921bde3"), new DateTime(2024, 6, 10, 15, 40, 13, 837, DateTimeKind.Utc).AddTicks(8339), true, "Safety and Compliance" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5fe850e4-cb5b-4f8e-9fba-eb3ddb7e5301"), null, "Visitor", "VISITOR" },
                    { new Guid("6aed6e45-df3d-4885-81ef-2529298896c0"), null, "Editor", "EDITOR" },
                    { new Guid("7e3a056b-dfa9-4627-86b0-181c9feba805"), null, "Moderator", "MODERATOR" },
                    { new Guid("83e29c32-650a-4aac-a0d3-7c8a547661d5"), null, "Admin", "ADMIN" },
                    { new Guid("885b85c7-6c20-4bd8-9d2e-998b5ec52c3b"), null, "Manager", "MANAGER" },
                    { new Guid("fbb7d93a-a895-4a23-a800-a3947abbe2cf"), null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("b8a0fa03-dc56-49d4-b69c-0778769e0ef5"), "John Doe", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "sustainable-solutions.md", new DateTime(2024, 6, 10, 15, 40, 15, 35, DateTimeKind.Utc).AddTicks(8187), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading the way in sustainable construction, minimizing environmental impact for a brighter future.", "[]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedBlogPostId" },
                values: new object[,]
                {
                    { new Guid("209fd9be-0ea5-405b-b185-478c64ea109b"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9123), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("27802de4-6545-46a9-9e71-208605cb6b2c"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9086), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("280d05d3-20a7-451a-8ada-93c06f28cf7b"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9115), true, true, "Are you licensed and insured?", null },
                    { new Guid("288ac65d-6674-4784-b345-037090204d07"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9073), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("3512104d-3f6a-4745-9265-7c2f43769ff6"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9078), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("48999360-4f97-4e81-8737-6f3e09fcd0ce"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9091), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("4a57748f-f2e7-4d3e-922c-198a5ad47e18"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9082), true, true, "How do you handle project timelines?", null },
                    { new Guid("5f8d1cc7-44a1-4fe7-a9c1-039773bd676b"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9080), true, null, "How can I get a quote for my project?", null },
                    { new Guid("a1a1e533-decf-41bd-bd19-7db74fce95ed"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9084), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("b715d00a-84f6-4e3a-9c0e-9107267fe99a"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9109), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("b8e5b706-1e92-4eb7-9975-7cff87055e76"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9126), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("b9dc3d48-5ff7-4a2a-b2a2-84cd0ba08055"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9121), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("be083598-204a-45c2-919b-37ee268e545d"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9095), true, null, "Do you offer financing options?", null },
                    { new Guid("d12ec1c8-cebe-43d6-865c-e29a9ea3fec3"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9119), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("d95d1064-1d1f-447e-a592-4f95fe300298"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9111), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("dcc579ba-e1ab-41a3-8409-b41d2d6686d4"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9093), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("ebee0458-6dc9-440f-b808-7a6dff872946"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9107), true, null, "How do I pay for my project?", null },
                    { new Guid("fceaf87d-030b-4431-96a3-276d75e203e2"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9097), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("fe89220a-40fe-4558-afff-9d7bc3869ab9"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(9125), true, null, "Can I visit the construction site during the project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("50a7c441-03c0-4079-bb0e-10eac82098b0"), null, null, new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(8719), "James", 0, new Guid("80569cd1-fe71-4b7f-ad9d-9702570d7ba1"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("548afb06-d5af-43b0-9f87-b8fb9007a584"), null, null, new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(8754), "Charles", 0, new Guid("da682e32-0dfe-4cef-91db-ecb5c8da7648"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("80569cd1-fe71-4b7f-ad9d-9702570d7ba1"), 0, "03a8a4d7-d82c-461f-95ea-ea9362181cb0", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHqyVTg3VzK+5L+kW2adx34IFEwyMFBlnEa1st1rZEfZbkh4HuyO/Q3A8/aNpsUU/w==", "+639672814641", false, "31503500-1452-990d-3123-4ddadf572b1e_20240610154014895", false, "jc.mangubat@hotmail.com" },
                    { new Guid("da682e32-0dfe-4cef-91db-ecb5c8da7648"), 0, "c7577d4d-c2b0-4f5e-a1e6-1d8459646d63", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEC5U2KtRCFWJheWSQM21ODHdHscjV6dzVplDSQ8IU6MafqVPD487aN0hiH2/0LtsbQ==", "+639951225449", false, "31503500-1452-990d-3123-4ddadf572b1e_20240610154014895", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("09745413-f25a-4586-9000-7b774df4603a"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(8914), true, "8000", "Davao del Sur", new Guid("50a7c441-03c0-4079-bb0e-10eac82098b0") },
                    { new Guid("34b48a07-d704-485b-ab2c-4a3e40829704"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 15, 40, 15, 34, DateTimeKind.Utc).AddTicks(8922), true, "8000", "Davao del Sur", new Guid("548afb06-d5af-43b0-9f87-b8fb9007a584") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostArticleCategory",
                columns: new[] { "ArticleCategoryId", "BlogPostId" },
                values: new object[] { new Guid("0e458c28-529f-46f8-adbf-6ebd3247a6ef"), new Guid("b8a0fa03-dc56-49d4-b69c-0778769e0ef5") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostComments",
                columns: new[] { "BlogPostCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("13915351-24d7-476b-ba89-1dfb98732ec7"), "John Doe", new Guid("b8a0fa03-dc56-49d4-b69c-0778769e0ef5"), "This is a fantastic article!", new DateTime(2024, 6, 10, 15, 40, 15, 35, DateTimeKind.Utc).AddTicks(8480), "commenter@gmail.com", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostImages",
                columns: new[] { "BlogPostImageId", "BlogPostId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[] { new Guid("3b1c4d4f-aee1-458a-96e7-609b5463bf7a"), new Guid("b8a0fa03-dc56-49d4-b69c-0778769e0ef5"), new DateTime(2024, 6, 10, 15, 40, 15, 35, DateTimeKind.Utc).AddTicks(8490), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("83e29c32-650a-4aac-a0d3-7c8a547661d5"), new Guid("80569cd1-fe71-4b7f-ad9d-9702570d7ba1") },
                    { new Guid("885b85c7-6c20-4bd8-9d2e-998b5ec52c3b"), new Guid("da682e32-0dfe-4cef-91db-ecb5c8da7648") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserProfileId",
                schema: "dbo",
                table: "Addresses",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostArticleCategory_ArticleCategoryId",
                schema: "dbo",
                table: "BlogPostArticleCategory",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComments_BlogPostId",
                schema: "dbo",
                table: "BlogPostComments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostImages_BlogPostId",
                schema: "dbo",
                table: "BlogPostImages",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogPosts",
                column: "AuthorUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogRelatedAssociation_TargetBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                column: "TargetBlogPostId");

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
                name: "IX_QuestionAnswers_RelatedBlogPostId",
                schema: "dbo",
                table: "QuestionAnswers",
                column: "RelatedBlogPostId",
                unique: true,
                filter: "[RelatedBlogPostId] IS NOT NULL");

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
                name: "BlogPostArticleCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BlogPostComments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BlogPostImages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BlogRelatedAssociation",
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
                name: "BlogPosts",
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
                name: "UserProfileModels",
                schema: "dbo");
        }
    }
}
