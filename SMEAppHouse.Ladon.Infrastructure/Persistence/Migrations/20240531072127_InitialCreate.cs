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
                name: "SiteAreas",
                schema: "dbo",
                columns: table => new
                {
                    SiteAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(9534)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteAreas", x => x.SiteAreaId);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                schema: "dbo",
                columns: table => new
                {
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 223, DateTimeKind.Local).AddTicks(1654)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false)
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(1197)),
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 218, DateTimeKind.Local).AddTicks(1790)),
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
                name: "BlogDocuments",
                schema: "dbo",
                columns: table => new
                {
                    BlogDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 219, DateTimeKind.Local).AddTicks(1081)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Hearts = table.Column<int>(type: "int", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CanonicalUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Categories = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    AuthorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDocuments", x => x.BlogDocumentId);
                    table.ForeignKey(
                        name: "FK_BlogDocuments_UserProfileModels_AuthorUserProfileId",
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 218, DateTimeKind.Local).AddTicks(8640)),
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(7360)),
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 223, DateTimeKind.Local).AddTicks(9599)),
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
                name: "BlogComments",
                schema: "dbo",
                columns: table => new
                {
                    BlogCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 222, DateTimeKind.Local).AddTicks(8331)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BlogDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.BlogCommentId);
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogDocuments_BlogDocumentId",
                        column: x => x.BlogDocumentId,
                        principalSchema: "dbo",
                        principalTable: "BlogDocuments",
                        principalColumn: "BlogDocumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogRelatedAssociation",
                schema: "dbo",
                columns: table => new
                {
                    SourceBlogDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetBlogDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRelatedAssociation", x => new { x.SourceBlogDocumentId, x.TargetBlogDocumentId });
                    table.ForeignKey(
                        name: "FK_BlogRelatedAssociation_BlogDocuments_SourceBlogDocumentId",
                        column: x => x.SourceBlogDocumentId,
                        principalSchema: "dbo",
                        principalTable: "BlogDocuments",
                        principalColumn: "BlogDocumentId");
                    table.ForeignKey(
                        name: "FK_BlogRelatedAssociation_BlogDocuments_TargetBlogDocumentId",
                        column: x => x.TargetBlogDocumentId,
                        principalSchema: "dbo",
                        principalTable: "BlogDocuments",
                        principalColumn: "BlogDocumentId");
                });

            migrationBuilder.CreateTable(
                name: "QuoteRequestAttachments",
                schema: "dbo",
                columns: table => new
                {
                    QuoteRequestAttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 224, DateTimeKind.Local).AddTicks(4259)),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0a0e63b9-a559-4041-bd3c-828603cd6dc3"), null, "Visitor", "VISITOR" },
                    { new Guid("491af811-3c00-4907-aa04-f66d29e08f38"), null, "Moderator", "MODERATOR" },
                    { new Guid("4d921678-b584-4065-8b87-2ad098281fe3"), null, "Client", "CLIENT" },
                    { new Guid("58c1e699-845b-40c4-a7d8-cae039dd4743"), null, "Manager", "MANAGER" },
                    { new Guid("7661d4b7-5022-4ad5-aee5-f34cc78fd680"), null, "Editor", "EDITOR" },
                    { new Guid("d536ae67-d35d-42d3-a87a-ee85eb95664d"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "SiteAreas",
                columns: new[] { "SiteAreaId", "Code", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("01adbac7-4f20-4300-8792-a70c3932e87b"), "LCS-03", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4726), true, "Teams" },
                    { new Guid("25bdddd3-dfc2-4775-a93f-fe1a98cf9323"), "LCS-01", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4712), true, "About" },
                    { new Guid("441f4378-715b-4dc3-9081-1c65960de990"), "LCS-07", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4734), true, "ClientReviews" },
                    { new Guid("4e7beb33-9575-408d-a4c9-4918cc90a708"), "LCS-06", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4732), true, "FAQs" },
                    { new Guid("562bc141-f419-474c-a218-323d351c1b59"), "LCS-04", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4728), true, "Projects" },
                    { new Guid("5a8423fe-705c-4cfa-9eca-4dd719816830"), "LCS-08", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4736), true, "Contact" },
                    { new Guid("73fd64e6-07c8-43ec-9be0-9f94f2dad724"), "LCS-05", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4730), true, "Blogs" },
                    { new Guid("9e7b39d8-86e2-4925-95ab-0a30e603af8c"), "LCS-02", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4715), true, "Service" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("298ec5a2-660f-4d29-82c6-8bb69b83c3b6"), null, null, new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4580), "James", 0, new Guid("3c4d2914-5bfe-49f5-b81c-94a3e6789d1f"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("89458483-cb6f-4db7-af2e-f108d05666f0"), null, null, new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4617), "Charles", 0, new Guid("c604f261-fd9d-4881-b640-47dbe5569295"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3c4d2914-5bfe-49f5-b81c-94a3e6789d1f"), 0, "9b163a02-6a2c-4df2-bbb4-16ad7f80f4a8", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJH3o9lo9zm4swR2xWk/lWILwjXB/KLhd3IHagT5dqwiEKvm7KN3ciCXcrEmxIKzhg==", "+639672814641", false, "47cf6a00-178a-d92a-b9e3-79bd1ff391c8_20240531072126224", false, "jc.mangubat@hotmail.com" },
                    { new Guid("c604f261-fd9d-4881-b640-47dbe5569295"), 0, "7c93505e-1e3e-4963-8cfc-fad9d8463615", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEMrDaXn4sL3S/Hz6iDspf2whiboaTYsZhZsSafoZwLhaHjqsoLv0fDTuw+EAH5iRJg==", "+639951225449", false, "47cf6a00-178a-d92a-b9e3-79bd1ff391c8_20240531072126224", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("77d90d86-4392-40d4-8e77-faadbc76218a"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4685), true, "8000", "Davao del Sur", new Guid("89458483-cb6f-4db7-af2e-f108d05666f0") },
                    { new Guid("9caec870-f9fe-4382-b629-e2e9e76d6097"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 5, 31, 7, 21, 26, 356, DateTimeKind.Utc).AddTicks(4680), true, "8000", "Davao del Sur", new Guid("298ec5a2-660f-4d29-82c6-8bb69b83c3b6") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d536ae67-d35d-42d3-a87a-ee85eb95664d"), new Guid("3c4d2914-5bfe-49f5-b81c-94a3e6789d1f") },
                    { new Guid("58c1e699-845b-40c4-a7d8-cae039dd4743"), new Guid("c604f261-fd9d-4881-b640-47dbe5569295") }
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
                name: "IX_BlogComments_BlogDocumentId",
                schema: "dbo",
                table: "BlogComments",
                column: "BlogDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogDocuments_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogDocuments",
                column: "AuthorUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogRelatedAssociation_TargetBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                column: "TargetBlogDocumentId");

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
                name: "BlogComments",
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
                name: "QuoteRequestAttachments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SiteAreas",
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
                name: "BlogDocuments",
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
