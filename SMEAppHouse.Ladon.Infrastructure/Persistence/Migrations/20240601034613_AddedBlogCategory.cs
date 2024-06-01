using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedBlogCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("544efb97-7967-4964-bde7-95f8baf02c04"));

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

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("6f19ce6f-961f-45d6-b125-745f997b6575"));

            migrationBuilder.DropColumn(
                name: "Categories",
                schema: "dbo",
                table: "BlogPosts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 646, DateTimeKind.Local).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 953, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 664, DateTimeKind.Local).AddTicks(1272),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(1160),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 666, DateTimeKind.Local).AddTicks(3185),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 669, DateTimeKind.Local).AddTicks(7084),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 961, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 648, DateTimeKind.Local).AddTicks(4823),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 651, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 652, DateTimeKind.Local).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 663, DateTimeKind.Local).AddTicks(6487),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 959, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(6399),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                schema: "dbo",
                columns: table => new
                {
                    BlogCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 662, DateTimeKind.Local).AddTicks(9637)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.BlogCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostCategory",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostCategory", x => new { x.BlogPostId, x.BlogCategoryId });
                    table.ForeignKey(
                        name: "FK_BlogPostCategory_BlogCategories_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalSchema: "dbo",
                        principalTable: "BlogCategories",
                        principalColumn: "BlogCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostCategory_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalSchema: "dbo",
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("33c82a8d-9f3f-4eb0-87bc-141918ca913f"), null, "Editor", "EDITOR" },
                    { new Guid("4bb4532b-1884-4359-9f5e-50c7e682bdc2"), null, "Visitor", "VISITOR" },
                    { new Guid("8df3ddcf-fae0-4f97-894c-e0ab5d153537"), null, "Moderator", "MODERATOR" },
                    { new Guid("92439679-dcc6-482d-8d35-b0818ce21256"), null, "Manager", "MANAGER" },
                    { new Guid("e168070e-6345-4630-b520-62bdc66f5081"), null, "Admin", "ADMIN" },
                    { new Guid("f2bbcabc-0779-49f2-9413-fd13574d5f32"), null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "SiteAreas",
                columns: new[] { "SiteAreaId", "Code", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("09008ba3-0647-46ff-bf29-425da15a2ef7"), "LCS-05", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5305), true, "Blogs" },
                    { new Guid("15e470c7-7d7a-40d9-ab00-db0a9a7336d8"), "LCS-06", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5307), true, "FAQs" },
                    { new Guid("1a4a61dd-b7ff-434d-9fc8-cad1e81628f7"), "LCS-04", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5303), true, "Projects" },
                    { new Guid("2fbefbfe-5e42-4770-8506-94af3cf33fdf"), "LCS-02", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5285), true, "Service" },
                    { new Guid("786822a3-6753-4bb7-a034-49d603cac4f1"), "LCS-01", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5282), true, "About" },
                    { new Guid("91078d6a-7e92-4d08-9c5d-ba72cf0b9774"), "LCS-08", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5311), true, "Contact" },
                    { new Guid("cc8a74a7-320b-4049-9c02-ea39d0967da5"), "LCS-07", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5309), true, "ClientReviews" },
                    { new Guid("ffe57815-1afe-47df-af78-7b053f046d2d"), "LCS-03", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5301), true, "Teams" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("738a4d8d-36dc-4660-b2d0-044d53295503"), null, null, new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5181), "Charles", 0, new Guid("756e42b2-d955-4b35-8988-8c1717fe64aa"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("b8aa91ce-eadd-417f-a55d-b8e413e699ad"), null, null, new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5146), "James", 0, new Guid("d30188eb-8213-4ba8-99c8-a450c84220b6"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("756e42b2-d955-4b35-8988-8c1717fe64aa"), 0, "c43cbe48-de60-4f09-ad35-89fb3902061b", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEPbYS2LifQTcEs+QT57Orv4Qr6ghvPu5tOa5QDbfMNn/1SrSDCAB+ieRTl1IlLkS8g==", "+639951225449", false, "ad519418-ad1d-d67b-613b-b1f8b0272630_20240601034611676", false, "ladonconst@gmail.com" },
                    { new Guid("d30188eb-8213-4ba8-99c8-a450c84220b6"), 0, "7f2547ef-5068-4eca-8ef3-6570d715941c", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAENOQAtbUWGx7Y7PxVPQZjAOGNuJeYnGlakZ9ZkyXPg/TtViSS4c0bcORcGF2C4W6ww==", "+639672814641", false, "ad519418-ad1d-d67b-613b-b1f8b0272630_20240601034611676", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("23dbe370-15a1-4d60-b054-d17607e5b29a"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5256), true, "8000", "Davao del Sur", new Guid("738a4d8d-36dc-4660-b2d0-044d53295503") },
                    { new Guid("6bf1b1b6-6807-4ea8-ba50-c3c302cf3d96"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5248), true, "8000", "Davao del Sur", new Guid("b8aa91ce-eadd-417f-a55d-b8e413e699ad") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("21b76fe6-937a-4c00-bf03-77065ab15143"), null, new Guid("b8aa91ce-eadd-417f-a55d-b8e413e699ad"), null, "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5362), null, true, null, null, null, null, null, new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5364), "sanctifying-spaces-crafting-sacred-church-architecture", null, "Sanctifying Spaces: Crafting Sacred Church Architecture", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("92439679-dcc6-482d-8d35-b0818ce21256"), new Guid("756e42b2-d955-4b35-8988-8c1717fe64aa") },
                    { new Guid("e168070e-6345-4630-b520-62bdc66f5081"), new Guid("d30188eb-8213-4ba8-99c8-a450c84220b6") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogComments",
                columns: new[] { "BlogCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("25a00e41-1c96-4c27-bc1c-5fe347211a4a"), "John Doe", new Guid("21b76fe6-937a-4c00-bf03-77065ab15143"), "This is a fantastic article!", new DateTime(2024, 6, 1, 3, 46, 11, 832, DateTimeKind.Utc).AddTicks(5392), "commenter@gmail.com", true });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostCategory_BlogCategoryId",
                schema: "dbo",
                table: "BlogPostCategory",
                column: "BlogCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BlogCategories",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("23dbe370-15a1-4d60-b054-d17607e5b29a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("6bf1b1b6-6807-4ea8-ba50-c3c302cf3d96"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("33c82a8d-9f3f-4eb0-87bc-141918ca913f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4bb4532b-1884-4359-9f5e-50c7e682bdc2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8df3ddcf-fae0-4f97-894c-e0ab5d153537"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f2bbcabc-0779-49f2-9413-fd13574d5f32"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogComments",
                keyColumn: "BlogCommentId",
                keyValue: new Guid("25a00e41-1c96-4c27-bc1c-5fe347211a4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("09008ba3-0647-46ff-bf29-425da15a2ef7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("15e470c7-7d7a-40d9-ab00-db0a9a7336d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("1a4a61dd-b7ff-434d-9fc8-cad1e81628f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("2fbefbfe-5e42-4770-8506-94af3cf33fdf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("786822a3-6753-4bb7-a034-49d603cac4f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("91078d6a-7e92-4d08-9c5d-ba72cf0b9774"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("cc8a74a7-320b-4049-9c02-ea39d0967da5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("ffe57815-1afe-47df-af78-7b053f046d2d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92439679-dcc6-482d-8d35-b0818ce21256"), new Guid("756e42b2-d955-4b35-8988-8c1717fe64aa") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e168070e-6345-4630-b520-62bdc66f5081"), new Guid("d30188eb-8213-4ba8-99c8-a450c84220b6") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("92439679-dcc6-482d-8d35-b0818ce21256"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e168070e-6345-4630-b520-62bdc66f5081"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("21b76fe6-937a-4c00-bf03-77065ab15143"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("738a4d8d-36dc-4660-b2d0-044d53295503"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("756e42b2-d955-4b35-8988-8c1717fe64aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d30188eb-8213-4ba8-99c8-a450c84220b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("b8aa91ce-eadd-417f-a55d-b8e413e699ad"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 953, DateTimeKind.Local).AddTicks(7507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 646, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(887),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 664, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(6620),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 960, DateTimeKind.Local).AddTicks(8265),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 666, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 961, DateTimeKind.Local).AddTicks(2046),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 669, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 648, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(5617),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 651, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 955, DateTimeKind.Local).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 652, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.AddColumn<string>(
                name: "Categories",
                schema: "dbo",
                table: "BlogPosts",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 959, DateTimeKind.Local).AddTicks(7483),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 663, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 0, 20, 29, 954, DateTimeKind.Local).AddTicks(8961),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(6399));

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
        }
    }
}
