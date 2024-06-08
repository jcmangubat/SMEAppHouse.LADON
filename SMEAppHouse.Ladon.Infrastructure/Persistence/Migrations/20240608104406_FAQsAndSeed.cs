using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FAQsAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 749, DateTimeKind.Local).AddTicks(4999),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 646, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 664, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(628),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(1254),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 666, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 669, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 750, DateTimeKind.Local).AddTicks(6409),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 648, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 651, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(8746),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 652, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(2961),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 663, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 760, DateTimeKind.Local).AddTicks(9040),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 662, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(4998),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                schema: "dbo",
                columns: table => new
                {
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 764, DateTimeKind.Local).AddTicks(2199)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.QuestionAnswerId);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("63bb0685-c393-42b3-82e5-e0b84ad88b9f"), null, "Moderator", "MODERATOR" },
                    { new Guid("93e57c25-4050-4c7d-bb84-b84467c189a4"), null, "Editor", "EDITOR" },
                    { new Guid("cc21e1b3-dcc3-4bf6-acef-15d04417f916"), null, "Admin", "ADMIN" },
                    { new Guid("deafbbd0-f283-49bf-9d1c-d94b2c9a3a0c"), null, "Client", "CLIENT" },
                    { new Guid("f143e2f2-7ecc-4e59-9607-42e17ef73420"), null, "Manager", "MANAGER" },
                    { new Guid("fb3d762c-ed6c-43bf-a0a4-6113dce4ebee"), null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "Question" },
                values: new object[,]
                {
                    { new Guid("0b8de8e4-2a17-4891-9716-6dc90fb5a172"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(444), true, "Can I visit the construction site during the project?" },
                    { new Guid("0dc6e761-0b8c-4d6c-92fb-57790cddf978"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(387), true, "How long has Ladon Construction Services been in business?" },
                    { new Guid("209ae0f8-7e2a-4218-a25d-3fc7f261595a"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(374), true, "What services does Ladon Construction Services offer?" },
                    { new Guid("31290918-2d85-4305-9665-5fbae3578e42"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(411), true, "Are there any hidden fees in your estimates?" },
                    { new Guid("49a4d341-f23f-44a5-8ac3-d4a915d5a136"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(413), true, "How do I pay for my project?" },
                    { new Guid("4e5f7cfe-9d1c-442b-a3e6-87ace5d817c1"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(419), true, "What safety measures do you take on construction sites?" },
                    { new Guid("601150e1-974b-4e21-99ac-38dfea3a2e71"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(430), true, "How will I be updated on the progress of my project?" },
                    { new Guid("7f37d6f8-c50d-4771-83e0-12a89dc29a37"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(392), true, "How do you handle project timelines?" },
                    { new Guid("81ab4bdc-51c0-4ea6-a827-154580c6ab9a"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(395), true, "Can you help with the design phase of my project?" },
                    { new Guid("87b619be-8485-4605-ba80-20792ba8b9cd"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(422), true, "Are you licensed and insured?" },
                    { new Guid("8c70b9b1-2617-4c00-8a36-705738cfe031"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(397), true, "What should I consider before starting a construction project?" },
                    { new Guid("9fd3e894-5012-4eb3-8130-22fe2685679e"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(446), true, "How do you handle project completion and handover?" },
                    { new Guid("b57b085b-0e2a-4b75-8c9c-9c723826f993"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(416), true, "How do you ensure the quality of your construction work?" },
                    { new Guid("bd3d41e7-8c4f-4130-8642-7f86f11064de"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(390), true, "How can I get a quote for my project?" },
                    { new Guid("c028573b-c15f-40c9-aecb-04490ca67165"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(403), true, "How do you determine the cost of a construction project?" },
                    { new Guid("c7331b53-f2ea-418e-abd3-7bb1af44d5b1"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(441), true, "Who will be my point of contact during the project?" },
                    { new Guid("d94c3a75-edff-4e73-9c6d-10642be9b6b7"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(399), true, "Do you provide a warranty for your work?" },
                    { new Guid("e03b4449-8eb8-4dd5-b495-930a39277aa5"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(435), true, "What if I need to make changes to the project after it has started?" },
                    { new Guid("e87b7542-dee1-479d-82ea-ccea472660d2"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(408), true, "Do you offer financing options?" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "SiteAreas",
                columns: new[] { "SiteAreaId", "Code", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("1248104f-89e2-4382-b030-4f6833aa4dc3"), "LCS-08", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(223), true, "Contact" },
                    { new Guid("3331675f-2ded-4494-b661-fe6f8998377a"), "LCS-02", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(201), true, "Service" },
                    { new Guid("46d74252-fd9b-4688-89fd-9512bbc35d69"), "LCS-04", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(215), true, "Projects" },
                    { new Guid("4c32b708-1653-404d-8a1a-ea20a2f6458c"), "LCS-07", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(221), true, "ClientReviews" },
                    { new Guid("62d6ff5d-b9cb-44d8-89a6-548b8e5921ac"), "LCS-03", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(212), true, "Teams" },
                    { new Guid("6dee099d-5ce1-4083-a8e8-e69d658c03b2"), "LCS-01", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(197), true, "About" },
                    { new Guid("eb7f736d-75c9-49de-963b-0de13178ceab"), "LCS-05", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(217), true, "Blogs" },
                    { new Guid("f20b4ff2-8393-4b4d-91f5-61783c208f54"), "LCS-06", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(219), true, "FAQs" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("6a4a7886-7639-49dd-bab4-30644d51c961"), null, null, new DateTime(2024, 6, 8, 10, 44, 4, 902, DateTimeKind.Utc).AddTicks(9864), "James", 0, new Guid("e75b23c7-08c1-40c5-a847-5b4f99d201d2"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("bb0ac16e-77bb-448b-9a65-733a0af44a5a"), null, null, new DateTime(2024, 6, 8, 10, 44, 4, 902, DateTimeKind.Utc).AddTicks(9908), "Charles", 0, new Guid("3dc6f035-97ff-4253-9eff-21a92da5b0cf"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3dc6f035-97ff-4253-9eff-21a92da5b0cf"), 0, "91693ab4-a16d-42ff-b261-29352f0dc1f6", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEO9ROyeLwPGW5sUkjkJmHFeAyOGX25YUdH43OfZUbs57dnV8vWqk8DFfgw7nMBmOtQ==", "+639951225449", false, "e3c83a30-7b0f-26f3-7b57-fbd9f8791c34_20240608104404764", false, "ladonconst@gmail.com" },
                    { new Guid("e75b23c7-08c1-40c5-a847-5b4f99d201d2"), 0, "f50c3db0-5ad1-4aaf-b836-0d3a6025fc97", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDYWPRQRipFf29ZjXJ6D/u+sjbes3PWw+KKeeBsvDmNsF8FHdN/a78epm6l5G5Mm0A==", "+639672814641", false, "e3c83a30-7b0f-26f3-7b57-fbd9f8791c34_20240608104404764", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("8c198c93-8433-4861-a558-8cc76a7d5e82"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(16), true, "8000", "Davao del Sur", new Guid("bb0ac16e-77bb-448b-9a65-733a0af44a5a") },
                    { new Guid("c58f36fb-ae6b-4a2e-a381-b29c702cf4c7"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(10), true, "8000", "Davao del Sur", new Guid("6a4a7886-7639-49dd-bab4-30644d51c961") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("1bee9053-99f3-4b39-a23a-1e03d579e1db"), null, new Guid("6a4a7886-7639-49dd-bab4-30644d51c961"), null, "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(279), null, true, null, null, null, null, null, new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(282), "sanctifying-spaces-crafting-sacred-church-architecture", null, "Sanctifying Spaces: Crafting Sacred Church Architecture", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f143e2f2-7ecc-4e59-9607-42e17ef73420"), new Guid("3dc6f035-97ff-4253-9eff-21a92da5b0cf") },
                    { new Guid("cc21e1b3-dcc3-4bf6-acef-15d04417f916"), new Guid("e75b23c7-08c1-40c5-a847-5b4f99d201d2") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogComments",
                columns: new[] { "BlogCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("73c6c1ae-bdfd-45cf-8c3e-c95accdb4cff"), "John Doe", new Guid("1bee9053-99f3-4b39-a23a-1e03d579e1db"), "This is a fantastic article!", new DateTime(2024, 6, 8, 10, 44, 4, 903, DateTimeKind.Utc).AddTicks(319), "commenter@gmail.com", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswers",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("8c198c93-8433-4861-a558-8cc76a7d5e82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("c58f36fb-ae6b-4a2e-a381-b29c702cf4c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("63bb0685-c393-42b3-82e5-e0b84ad88b9f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("93e57c25-4050-4c7d-bb84-b84467c189a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("deafbbd0-f283-49bf-9d1c-d94b2c9a3a0c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb3d762c-ed6c-43bf-a0a4-6113dce4ebee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogComments",
                keyColumn: "BlogCommentId",
                keyValue: new Guid("73c6c1ae-bdfd-45cf-8c3e-c95accdb4cff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("1248104f-89e2-4382-b030-4f6833aa4dc3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("3331675f-2ded-4494-b661-fe6f8998377a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("46d74252-fd9b-4688-89fd-9512bbc35d69"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("4c32b708-1653-404d-8a1a-ea20a2f6458c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("62d6ff5d-b9cb-44d8-89a6-548b8e5921ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("6dee099d-5ce1-4083-a8e8-e69d658c03b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("eb7f736d-75c9-49de-963b-0de13178ceab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "SiteAreas",
                keyColumn: "SiteAreaId",
                keyValue: new Guid("f20b4ff2-8393-4b4d-91f5-61783c208f54"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f143e2f2-7ecc-4e59-9607-42e17ef73420"), new Guid("3dc6f035-97ff-4253-9eff-21a92da5b0cf") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("cc21e1b3-dcc3-4bf6-acef-15d04417f916"), new Guid("e75b23c7-08c1-40c5-a847-5b4f99d201d2") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cc21e1b3-dcc3-4bf6-acef-15d04417f916"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f143e2f2-7ecc-4e59-9607-42e17ef73420"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("1bee9053-99f3-4b39-a23a-1e03d579e1db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("bb0ac16e-77bb-448b-9a65-733a0af44a5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dc6f035-97ff-4253-9eff-21a92da5b0cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e75b23c7-08c1-40c5-a847-5b4f99d201d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("6a4a7886-7639-49dd-bab4-30644d51c961"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 646, DateTimeKind.Local).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 749, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 664, DateTimeKind.Local).AddTicks(1272),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "SiteAreas",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(1160),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 666, DateTimeKind.Local).AddTicks(3185),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 669, DateTimeKind.Local).AddTicks(7084),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 648, DateTimeKind.Local).AddTicks(4823),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 750, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 651, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 652, DateTimeKind.Local).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 663, DateTimeKind.Local).AddTicks(6487),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 662, DateTimeKind.Local).AddTicks(9637),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 760, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 1, 11, 46, 11, 649, DateTimeKind.Local).AddTicks(6399),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(4998));

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
        }
    }
}
