using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BlogPostLogicUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_BlogDocuments_BlogDocumentId",
                schema: "dbo",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogRelatedAssociation_BlogDocuments_SourceBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogRelatedAssociation_BlogDocuments_TargetBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation");

            migrationBuilder.DropTable(
                name: "BlogDocuments",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("0332302e-e837-4d90-bf17-a863e9e13827"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e93f964d-9677-43c7-a175-56b41320b80f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("46d8b1ca-ae74-45e0-9bef-e4415f7d6deb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("690efa09-905d-465c-b1c6-6a3a341f6803"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("94203281-ef11-4a57-9731-049eefa2c51b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d6a4eaef-efb4-4f67-987f-92f8801b4e33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogComments",
                keyColumn: "BlogCommentId",
                keyValue: new Guid("1d7b8083-0104-4b00-a683-4e14ab678c43"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("085d2862-2a7b-4856-9653-9dbb8182cb4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("1d9ddde8-36a1-4566-93ce-1d8e6fbe3d98"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("3962d3da-b00b-440f-8be8-a990d67cb3b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("4c82ea05-d718-432a-8799-1490dd479111"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("5d28a826-1483-41ed-b48d-e48486334cb1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("69c4895d-8171-44f7-8031-b112636a1de4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("821bd0be-229c-41a3-af47-fab12363cfd6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("da714bf1-ae7a-4cfc-a46e-7c56b5f81f35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("db66a3b5-94a4-4b49-8c8b-9eec68070466"), new Guid("67941a82-0729-4ae0-adcf-cb2efc9db196") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4f1ddd8c-7beb-4659-aa90-6347d750d72a"), new Guid("b89f7644-0dee-4258-a18d-6b4c30bdf15d") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4f1ddd8c-7beb-4659-aa90-6347d750d72a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("db66a3b5-94a4-4b49-8c8b-9eec68070466"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("0ea9434d-ef5b-4e58-8847-ebeb26017ec1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("6e10a069-4a29-453a-9ef4-ddb9c62855ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67941a82-0729-4ae0-adcf-cb2efc9db196"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b89f7644-0dee-4258-a18d-6b4c30bdf15d"));

            migrationBuilder.RenameColumn(
                name: "TargetBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                newName: "TargetBlogPostId");

            migrationBuilder.RenameColumn(
                name: "SourceBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                newName: "SourceBlogPostId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogRelatedAssociation_TargetBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                newName: "IX_BlogRelatedAssociation_TargetBlogPostId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "BlogComments",
                newName: "AuthorName");

            migrationBuilder.RenameColumn(
                name: "BlogDocumentId",
                schema: "dbo",
                table: "BlogComments",
                newName: "BlogPostId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_BlogDocumentId",
                schema: "dbo",
                table: "BlogComments",
                newName: "IX_BlogComments_BlogPostId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 953, DateTimeKind.Local).AddTicks(7507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 915, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(887),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 928, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(6620),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(8265),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 929, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 961, DateTimeKind.Local).AddTicks(2046),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 930, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 916, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(5617),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 918, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 959, DateTimeKind.Local).AddTicks(7483),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 927, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(8961),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(7657)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Categories = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    AuthorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("069d1c6c-be65-4c07-9e56-6dddfc854ce6"), null, "Editor", "EDITOR" },
                    { new Guid("1a31a447-a914-49e6-b196-74894873cb63"), null, "Visitor", "VISITOR" },
                    { new Guid("d64c7285-6b12-4e4a-99e9-b030e316cefd"), null, "Admin", "ADMIN" },
                    { new Guid("db718312-3c6f-4b1c-9564-2b6ff879853e"), null, "Client", "CLIENT" },
                    { new Guid("f6594a60-8411-44d1-a254-07a21c2edfd3"), null, "Moderator", "MODERATOR" },
                    { new Guid("f95b0c9d-23c1-4054-8a8a-f7657d479205"), null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "SiteAreas",
                columns: new[] { "SiteAreaId", "Code", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("041845c0-0864-4c12-ab0e-0575bd7b351a"), "LCS-05", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2769), true, "Blogs" },
                    { new Guid("5d1519ab-ea9d-4987-8b0d-5951f388ff96"), "LCS-06", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2776), true, "FAQs" },
                    { new Guid("666f9845-e845-4da2-b7e1-3968b8e06a36"), "LCS-01", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2759), true, "About" },
                    { new Guid("73503b4b-c146-41ab-9e90-e479bd49ca94"), "LCS-08", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2781), true, "Contact" },
                    { new Guid("7dd2bcb2-6a11-4905-828c-6a19a01f78d1"), "LCS-04", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2767), true, "Projects" },
                    { new Guid("8ded9bd9-3665-48d9-9b0a-6dd52b564374"), "LCS-03", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2765), true, "Teams" },
                    { new Guid("950dde9f-ff89-4b56-88b6-24da25c73983"), "LCS-02", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2763), true, "Service" },
                    { new Guid("a7bc6af4-1c3b-4eb0-aea4-89b457279a3d"), "LCS-07", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2779), true, "ClientReviews" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("6f19ce6f-961f-45d6-b125-745f997b6575"), null, null, new DateTime(2024, 5, 31, 16, 20, 30, 103, DateTimeKind.Utc).AddTicks(9893), "James", 0, new Guid("cec7423d-45f4-46ff-8164-872696810eda"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("8705c1d6-3735-4968-a817-404efe63159b"), null, null, new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(95), "Charles", 0, new Guid("2f671640-f0fb-48f0-810b-5f28ff499309"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2f671640-f0fb-48f0-810b-5f28ff499309"), 0, "9ae9d7ea-78e0-4b78-8b44-a05f5ff9740a", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEOQ7Cy72l0BqipqwgES9s2XStEVJDtLlwTp9lNXbGUthOjW6PnBEKM3HMpE9epIZgQ==", "+639951225449", false, "850da9ab-075e-9aca-3c47-6876058650f0_20240531162029961", false, "ladonconst@gmail.com" },
                    { new Guid("cec7423d-45f4-46ff-8164-872696810eda"), 0, "a71ec0c0-199d-46ee-88cf-4b949ae6b75a", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMXk1bNGyEZFfwPr+5azp9p5xGyF2rFPwxPMdddudySDkuf/3OoK39X7xiGnF+ya0Q==", "+639672814641", false, "850da9ab-075e-9aca-3c47-6876058650f0_20240531162029961", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("4a1c3033-03f1-4d22-afb2-eb6a245a8f31"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2679), true, "8000", "Davao del Sur", new Guid("8705c1d6-3735-4968-a817-404efe63159b") },
                    { new Guid("be0c6ee3-2196-403e-87a1-1d19a1c5feee"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2656), true, "8000", "Davao del Sur", new Guid("6f19ce6f-961f-45d6-b125-745f997b6575") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Categories", "Content", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("544efb97-7967-4964-bde7-95f8baf02c04"), null, new Guid("6f19ce6f-961f-45d6-b125-745f997b6575"), null, null, "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2844), null, true, null, null, null, null, null, new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2846), "sanctifying-spaces-crafting-sacred-church-architecture", null, "Sanctifying Spaces: Crafting Sacred Church Architecture", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f95b0c9d-23c1-4054-8a8a-f7657d479205"), new Guid("2f671640-f0fb-48f0-810b-5f28ff499309") },
                    { new Guid("d64c7285-6b12-4e4a-99e9-b030e316cefd"), new Guid("cec7423d-45f4-46ff-8164-872696810eda") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogComments",
                columns: new[] { "BlogCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("ffb18a6c-8cec-4056-b679-7e40feb3e848"), "John Doe", new Guid("544efb97-7967-4964-bde7-95f8baf02c04"), "This is a fantastic article!", new DateTime(2024, 5, 31, 16, 20, 30, 104, DateTimeKind.Utc).AddTicks(2891), "commenter@gmail.com", true });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogPosts",
                column: "AuthorUserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_BlogPosts_BlogPostId",
                schema: "dbo",
                table: "BlogComments",
                column: "BlogPostId",
                principalSchema: "dbo",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRelatedAssociation_BlogPosts_SourceBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                column: "SourceBlogPostId",
                principalSchema: "dbo",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRelatedAssociation_BlogPosts_TargetBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                column: "TargetBlogPostId",
                principalSchema: "dbo",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_BlogPosts_BlogPostId",
                schema: "dbo",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogRelatedAssociation_BlogPosts_SourceBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogRelatedAssociation_BlogPosts_TargetBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation");

            migrationBuilder.DropTable(
                name: "BlogPosts",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("4a1c3033-03f1-4d22-afb2-eb6a245a8f31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("be0c6ee3-2196-403e-87a1-1d19a1c5feee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("069d1c6c-be65-4c07-9e56-6dddfc854ce6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a31a447-a914-49e6-b196-74894873cb63"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("db718312-3c6f-4b1c-9564-2b6ff879853e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f6594a60-8411-44d1-a254-07a21c2edfd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogComments",
                keyColumn: "BlogCommentId",
                keyValue: new Guid("ffb18a6c-8cec-4056-b679-7e40feb3e848"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("041845c0-0864-4c12-ab0e-0575bd7b351a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("5d1519ab-ea9d-4987-8b0d-5951f388ff96"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("666f9845-e845-4da2-b7e1-3968b8e06a36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("73503b4b-c146-41ab-9e90-e479bd49ca94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("7dd2bcb2-6a11-4905-828c-6a19a01f78d1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("8ded9bd9-3665-48d9-9b0a-6dd52b564374"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("950dde9f-ff89-4b56-88b6-24da25c73983"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("a7bc6af4-1c3b-4eb0-aea4-89b457279a3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f95b0c9d-23c1-4054-8a8a-f7657d479205"), new Guid("2f671640-f0fb-48f0-810b-5f28ff499309") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d64c7285-6b12-4e4a-99e9-b030e316cefd"), new Guid("cec7423d-45f4-46ff-8164-872696810eda") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d64c7285-6b12-4e4a-99e9-b030e316cefd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f95b0c9d-23c1-4054-8a8a-f7657d479205"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("6f19ce6f-961f-45d6-b125-745f997b6575"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("8705c1d6-3735-4968-a817-404efe63159b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f671640-f0fb-48f0-810b-5f28ff499309"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cec7423d-45f4-46ff-8164-872696810eda"));

            migrationBuilder.RenameColumn(
                name: "TargetBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                newName: "TargetBlogDocumentId");

            migrationBuilder.RenameColumn(
                name: "SourceBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                newName: "SourceBlogDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogRelatedAssociation_TargetBlogPostId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                newName: "IX_BlogRelatedAssociation_TargetBlogDocumentId");

            migrationBuilder.RenameColumn(
                name: "BlogPostId",
                schema: "dbo",
                table: "BlogComments",
                newName: "BlogDocumentId");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                schema: "dbo",
                table: "BlogComments",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_BlogPostId",
                schema: "dbo",
                table: "BlogComments",
                newName: "IX_BlogComments_BlogDocumentId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 915, DateTimeKind.Local).AddTicks(917),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 953, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 928, DateTimeKind.Local).AddTicks(3750),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 929, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 930, DateTimeKind.Local).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 961, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 916, DateTimeKind.Local).AddTicks(6929),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 918, DateTimeKind.Local).AddTicks(9888),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 927, DateTimeKind.Local).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 959, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.CreateTable(
                name: "BlogDocuments",
                schema: "dbo",
                columns: table => new
                {
                    BlogDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 919, DateTimeKind.Local).AddTicks(5526)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    AuthorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CanonicalUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Categories = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hearts = table.Column<int>(type: "int", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Views = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("46d8b1ca-ae74-45e0-9bef-e4415f7d6deb"), null, "Moderator", "MODERATOR" },
                    { new Guid("4f1ddd8c-7beb-4659-aa90-6347d750d72a"), null, "Manager", "MANAGER" },
                    { new Guid("690efa09-905d-465c-b1c6-6a3a341f6803"), null, "Visitor", "VISITOR" },
                    { new Guid("94203281-ef11-4a57-9731-049eefa2c51b"), null, "Editor", "EDITOR" },
                    { new Guid("d6a4eaef-efb4-4f67-987f-92f8801b4e33"), null, "Client", "CLIENT" },
                    { new Guid("db66a3b5-94a4-4b49-8c8b-9eec68070466"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "SiteAreas",
                columns: new[] { "SiteAreaId", "Code", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("085d2862-2a7b-4856-9653-9dbb8182cb4a"), "LCS-04", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5408), true, "Projects" },
                    { new Guid("1d9ddde8-36a1-4566-93ce-1d8e6fbe3d98"), "LCS-05", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5411), true, "Blogs" },
                    { new Guid("3962d3da-b00b-440f-8be8-a990d67cb3b0"), "LCS-01", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5396), true, "About" },
                    { new Guid("4c82ea05-d718-432a-8799-1490dd479111"), "LCS-08", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5444), true, "Contact" },
                    { new Guid("5d28a826-1483-41ed-b48d-e48486334cb1"), "LCS-06", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5415), true, "FAQs" },
                    { new Guid("69c4895d-8171-44f7-8031-b112636a1de4"), "LCS-03", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5405), true, "Teams" },
                    { new Guid("821bd0be-229c-41a3-af47-fab12363cfd6"), "LCS-02", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5402), true, "Service" },
                    { new Guid("da714bf1-ae7a-4cfc-a46e-7c56b5f81f35"), "LCS-07", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5435), true, "ClientReviews" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("0ea9434d-ef5b-4e58-8847-ebeb26017ec1"), null, null, new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(4799), "James", 0, new Guid("67941a82-0729-4ae0-adcf-cb2efc9db196"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("6e10a069-4a29-453a-9ef4-ddb9c62855ec"), null, null, new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(4851), "Charles", 0, new Guid("b89f7644-0dee-4258-a18d-6b4c30bdf15d"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("67941a82-0729-4ae0-adcf-cb2efc9db196"), 0, "bf64faee-308b-4b1b-8acf-a0736725228f", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEA+uTZUGEIUtidHj2s+IUTGx567qFbo5703k6sCO9u0IxQgDparvJhjKO2DAVXFQzw==", "+639672814641", false, "8df1d324-28f2-d260-3fd8-73252175f20b_20240531135855930", false, "jc.mangubat@hotmail.com" },
                    { new Guid("b89f7644-0dee-4258-a18d-6b4c30bdf15d"), 0, "d519309d-dcf5-4f41-a50c-62c59af70b2a", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEDSLIjDpYe2bCUfXKFzD9XFE2oajA/Bn8Wa6wqfFUjvDuMK765AU7YM4T/C2EWfGYg==", "+639951225449", false, "8df1d324-28f2-d260-3fd8-73252175f20b_20240531135855930", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0332302e-e837-4d90-bf17-a863e9e13827"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5335), true, "8000", "Davao del Sur", new Guid("6e10a069-4a29-453a-9ef4-ddb9c62855ec") },
                    { new Guid("e93f964d-9677-43c7-a175-56b41320b80f"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5304), true, "8000", "Davao del Sur", new Guid("0ea9434d-ef5b-4e58-8847-ebeb26017ec1") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogDocuments",
                columns: new[] { "BlogDocumentId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Categories", "Content", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("82c5d921-57cc-41e1-89cf-2ec01e636bc9"), null, new Guid("0ea9434d-ef5b-4e58-8847-ebeb26017ec1"), null, null, "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5546), null, true, null, null, null, null, null, new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5550), null, null, "Sanctifying Spaces: Crafting Sacred Church Architecture", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("db66a3b5-94a4-4b49-8c8b-9eec68070466"), new Guid("67941a82-0729-4ae0-adcf-cb2efc9db196") },
                    { new Guid("4f1ddd8c-7beb-4659-aa90-6347d750d72a"), new Guid("b89f7644-0dee-4258-a18d-6b4c30bdf15d") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogComments",
                columns: new[] { "BlogCommentId", "BlogDocumentId", "CommentText", "_dateModified", "Email", "IsActive", "Name" },
                values: new object[] { new Guid("1d7b8083-0104-4b00-a683-4e14ab678c43"), new Guid("82c5d921-57cc-41e1-89cf-2ec01e636bc9"), "This is a fantastic article!", new DateTime(2024, 5, 31, 13, 58, 56, 189, DateTimeKind.Utc).AddTicks(5861), "commenter@gmail.com", true, "John Doe" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogDocuments_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogDocuments",
                column: "AuthorUserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_BlogDocuments_BlogDocumentId",
                schema: "dbo",
                table: "BlogComments",
                column: "BlogDocumentId",
                principalSchema: "dbo",
                principalTable: "BlogDocuments",
                principalColumn: "BlogDocumentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRelatedAssociation_BlogDocuments_SourceBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                column: "SourceBlogDocumentId",
                principalSchema: "dbo",
                principalTable: "BlogDocuments",
                principalColumn: "BlogDocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRelatedAssociation_BlogDocuments_TargetBlogDocumentId",
                schema: "dbo",
                table: "BlogRelatedAssociation",
                column: "TargetBlogDocumentId",
                principalSchema: "dbo",
                principalTable: "BlogDocuments",
                principalColumn: "BlogDocumentId");
        }
    }
}
