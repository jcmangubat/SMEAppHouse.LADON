using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BlogPostsLogics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("77d90d86-4392-40d4-8e77-faadbc76218a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("9caec870-f9fe-4382-b629-e2e9e76d6097"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0a0e63b9-a559-4041-bd3c-828603cd6dc3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("491af811-3c00-4907-aa04-f66d29e08f38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4d921678-b584-4065-8b87-2ad098281fe3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7661d4b7-5022-4ad5-aee5-f34cc78fd680"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("01adbac7-4f20-4300-8792-a70c3932e87b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("25bdddd3-dfc2-4775-a93f-fe1a98cf9323"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("441f4378-715b-4dc3-9081-1c65960de990"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("4e7beb33-9575-408d-a4c9-4918cc90a708"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("562bc141-f419-474c-a218-323d351c1b59"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("5a8423fe-705c-4cfa-9eca-4dd719816830"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("73fd64e6-07c8-43ec-9be0-9f94f2dad724"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("9e7b39d8-86e2-4925-95ab-0a30e603af8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d536ae67-d35d-42d3-a87a-ee85eb95664d"), new Guid("3c4d2914-5bfe-49f5-b81c-94a3e6789d1f") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("58c1e699-845b-40c4-a7d8-cae039dd4743"), new Guid("c604f261-fd9d-4881-b640-47dbe5569295") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("58c1e699-845b-40c4-a7d8-cae039dd4743"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d536ae67-d35d-42d3-a87a-ee85eb95664d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("298ec5a2-660f-4d29-82c6-8bb69b83c3b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("89458483-cb6f-4db7-af2e-f108d05666f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c4d2914-5bfe-49f5-b81c-94a3e6789d1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c604f261-fd9d-4881-b640-47dbe5569295"));

            migrationBuilder.DropColumn(
                name: "Content",
                schema: "dbo",
                table: "BlogComments");

            migrationBuilder.RenameColumn(
                name: "PublishDate",
                schema: "dbo",
                table: "BlogDocuments",
                newName: "PublishedDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 915, DateTimeKind.Local).AddTicks(917),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 928, DateTimeKind.Local).AddTicks(3750),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 223, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 929, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 223, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 930, DateTimeKind.Local).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 224, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 916, DateTimeKind.Local).AddTicks(6929),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 918, DateTimeKind.Local).AddTicks(9888),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 218, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogDocuments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 919, DateTimeKind.Local).AddTicks(5526),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 219, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaKeywords",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaDescription",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 927, DateTimeKind.Local).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 222, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "BlogComments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AddColumn<string>(
                name: "CommentText",
                schema: "dbo",
                table: "BlogComments",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 218, DateTimeKind.Local).AddTicks(1790));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "BlogDocuments",
                keyColumn: "BlogDocumentId",
                keyValue: new Guid("82c5d921-57cc-41e1-89cf-2ec01e636bc9"));

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

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("0ea9434d-ef5b-4e58-8847-ebeb26017ec1"));

            migrationBuilder.DropColumn(
                name: "CommentText",
                schema: "dbo",
                table: "BlogComments");

            migrationBuilder.RenameColumn(
                name: "PublishedDate",
                schema: "dbo",
                table: "BlogDocuments",
                newName: "PublishDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(1197),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 915, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 223, DateTimeKind.Local).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 928, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(9534),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 223, DateTimeKind.Local).AddTicks(9599),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 929, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 224, DateTimeKind.Local).AddTicks(4259),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 930, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 217, DateTimeKind.Local).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 916, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 218, DateTimeKind.Local).AddTicks(8640),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 918, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogDocuments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 219, DateTimeKind.Local).AddTicks(1081),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 919, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaKeywords",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaDescription",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "BlogDocuments",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 222, DateTimeKind.Local).AddTicks(8331),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 927, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "BlogComments",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                schema: "dbo",
                table: "BlogComments",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 31, 15, 21, 26, 218, DateTimeKind.Local).AddTicks(1790),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 5, 31, 21, 58, 55, 917, DateTimeKind.Local).AddTicks(4455));

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
        }
    }
}
