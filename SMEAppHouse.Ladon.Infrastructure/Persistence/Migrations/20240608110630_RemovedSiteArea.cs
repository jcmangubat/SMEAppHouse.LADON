using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSiteArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteAreas",
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
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0b8de8e4-2a17-4891-9716-6dc90fb5a172"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0dc6e761-0b8c-4d6c-92fb-57790cddf978"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("209ae0f8-7e2a-4218-a25d-3fc7f261595a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("31290918-2d85-4305-9665-5fbae3578e42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("49a4d341-f23f-44a5-8ac3-d4a915d5a136"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4e5f7cfe-9d1c-442b-a3e6-87ace5d817c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("601150e1-974b-4e21-99ac-38dfea3a2e71"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7f37d6f8-c50d-4771-83e0-12a89dc29a37"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("81ab4bdc-51c0-4ea6-a827-154580c6ab9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("87b619be-8485-4605-ba80-20792ba8b9cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8c70b9b1-2617-4c00-8a36-705738cfe031"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9fd3e894-5012-4eb3-8130-22fe2685679e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b57b085b-0e2a-4b75-8c9c-9c723826f993"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("bd3d41e7-8c4f-4130-8642-7f86f11064de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c028573b-c15f-40c9-aecb-04490ca67165"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c7331b53-f2ea-418e-abd3-7bb1af44d5b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d94c3a75-edff-4e73-9c6d-10642be9b6b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e03b4449-8eb8-4dd5-b495-930a39277aa5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e87b7542-dee1-479d-82ea-ccea472660d2"));

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
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(974),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 749, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(8288),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "dbo",
                table: "Subscribers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 192, DateTimeKind.Local).AddTicks(7834),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(3384),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 764, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 750, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(5209),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(7554),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(4972),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(2749),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 760, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(9086),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2b4592db-2403-423a-8539-c762317d9c98"), null, "Editor", "EDITOR" },
                    { new Guid("2bcfa103-49cd-495c-abd8-2d44c456cf4c"), null, "Manager", "MANAGER" },
                    { new Guid("30b28ad5-022e-4dd1-8c0f-3804db40fb40"), null, "Admin", "ADMIN" },
                    { new Guid("67039cb5-88ff-4496-b0a1-7fe3e869f8cc"), null, "Moderator", "MODERATOR" },
                    { new Guid("7046b85a-ad59-4601-8be8-a83d77a449f8"), null, "Client", "CLIENT" },
                    { new Guid("baf24ce9-c189-4b70-a45a-f87e2ad12b39"), null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "Question" },
                values: new object[,]
                {
                    { new Guid("13989607-40d8-46d8-930f-a884544bcd32"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6960), true, "What services does Ladon Construction Services offer?" },
                    { new Guid("15597a2b-91e1-42d9-a9b2-2fa04a1c0e92"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7028), true, "Are you licensed and insured?" },
                    { new Guid("1cdfa67f-a8e7-451f-a011-1645576e2ff7"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7010), true, "Do you offer financing options?" },
                    { new Guid("2d65165d-97c4-4363-bf99-6debf0e6999b"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7030), true, "How will I be updated on the progress of my project?" },
                    { new Guid("3116c1a5-e779-4610-b1da-4e340e018d26"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7033), true, "What if I need to make changes to the project after it has started?" },
                    { new Guid("327f339c-f043-4900-ba12-ff244404b558"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6993), true, "What should I consider before starting a construction project?" },
                    { new Guid("3cbe45e9-cfb5-4ea1-b12c-78ab4d046578"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7048), true, "How do you handle project completion and handover?" },
                    { new Guid("5f9ff43c-e1a7-44f8-851a-eb26d21e5325"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7002), true, "How do you determine the cost of a construction project?" },
                    { new Guid("6da54deb-a91f-45f8-9b57-b4bfad0587d2"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7045), true, "Can I visit the construction site during the project?" },
                    { new Guid("81ad9e9f-257e-4e7a-83dd-753a3f793a93"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7025), true, "What safety measures do you take on construction sites?" },
                    { new Guid("884bd96c-0f26-4fda-ab19-0bd622c7c548"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7016), true, "Are there any hidden fees in your estimates?" },
                    { new Guid("8c4b5cd8-b309-43ce-a159-be559e742b0a"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6974), true, "How long has Ladon Construction Services been in business?" },
                    { new Guid("a1396cb0-6c9e-4035-9ad7-c24241adbe33"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6977), true, "How can I get a quote for my project?" },
                    { new Guid("dbd64776-3bed-4297-983d-51c15b2943bc"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6999), true, "Do you provide a warranty for your work?" },
                    { new Guid("f1f26f92-9884-43c2-920d-df3c21ccb1b1"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7019), true, "How do I pay for my project?" },
                    { new Guid("f5b748ae-aa88-46c4-b15d-daab8b0819bd"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6985), true, "Can you help with the design phase of my project?" },
                    { new Guid("f73943d9-44fd-4845-94cc-0b83e3505fba"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6979), true, "How do you handle project timelines?" },
                    { new Guid("f84c69a8-070c-4866-812b-15a886751430"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7022), true, "How do you ensure the quality of your construction work?" },
                    { new Guid("fcefeb9c-7d65-473e-8db0-968cded0fdac"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(7039), true, "Who will be my point of contact during the project?" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("2cd88ae9-2dad-4089-9a5d-72fbc7e34d09"), null, null, new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6192), "Charles", 0, new Guid("084d3080-7356-4c83-9c9b-cc0759ee25a5"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("43b7050b-dfc3-46b1-89eb-dcafe09c967f"), null, null, new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6112), "James", 0, new Guid("a452dead-d9d0-4f7f-8caa-d28afd79d214"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("084d3080-7356-4c83-9c9b-cc0759ee25a5"), 0, "9b038f86-04e0-4892-93ba-01952add736a", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEJdJMMqZeGeiRSNBkcKHixEteT4g+XSYpSSxELjKyXWLCm1SGWeQ6FcNLDYm+OX5YQ==", "+639951225449", false, "032e1b1f-eb8a-ad1e-bdda-ddb6cdd550e4_20240608110629193", false, "ladonconst@gmail.com" },
                    { new Guid("a452dead-d9d0-4f7f-8caa-d28afd79d214"), 0, "a8b10eaf-280d-4b33-8a5f-f2f03a05ee6b", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFBHDfZDof21W/eFXstCMuFa0zc/oaF89I07cCNeEdbaAh6XUC4uR1DV5fdlxQ1hMQ==", "+639672814641", false, "032e1b1f-eb8a-ad1e-bdda-ddb6cdd550e4_20240608110629193", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("25a0156e-a713-40d7-ba6e-891fc052c755"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6420), true, "8000", "Davao del Sur", new Guid("43b7050b-dfc3-46b1-89eb-dcafe09c967f") },
                    { new Guid("49936618-1bad-419a-94d5-3948dfa0b0ab"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6431), true, "8000", "Davao del Sur", new Guid("2cd88ae9-2dad-4089-9a5d-72fbc7e34d09") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("cee49e34-a9fd-44c1-8d58-86d7d69a4ea2"), null, new Guid("43b7050b-dfc3-46b1-89eb-dcafe09c967f"), null, "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6777), null, true, null, null, null, null, null, new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6780), "sanctifying-spaces-crafting-sacred-church-architecture", null, "Sanctifying Spaces: Crafting Sacred Church Architecture", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2bcfa103-49cd-495c-abd8-2d44c456cf4c"), new Guid("084d3080-7356-4c83-9c9b-cc0759ee25a5") },
                    { new Guid("30b28ad5-022e-4dd1-8c0f-3804db40fb40"), new Guid("a452dead-d9d0-4f7f-8caa-d28afd79d214") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogComments",
                columns: new[] { "BlogCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("5dc0e1d1-24f0-4b99-8ff7-3a81dd92dad6"), "John Doe", new Guid("cee49e34-a9fd-44c1-8d58-86d7d69a4ea2"), "This is a fantastic article!", new DateTime(2024, 6, 8, 11, 6, 29, 362, DateTimeKind.Utc).AddTicks(6891), "commenter@gmail.com", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("25a0156e-a713-40d7-ba6e-891fc052c755"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("49936618-1bad-419a-94d5-3948dfa0b0ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2b4592db-2403-423a-8539-c762317d9c98"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("67039cb5-88ff-4496-b0a1-7fe3e869f8cc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7046b85a-ad59-4601-8be8-a83d77a449f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("baf24ce9-c189-4b70-a45a-f87e2ad12b39"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogComments",
                keyColumn: "BlogCommentId",
                keyValue: new Guid("5dc0e1d1-24f0-4b99-8ff7-3a81dd92dad6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("13989607-40d8-46d8-930f-a884544bcd32"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("15597a2b-91e1-42d9-a9b2-2fa04a1c0e92"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1cdfa67f-a8e7-451f-a011-1645576e2ff7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2d65165d-97c4-4363-bf99-6debf0e6999b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3116c1a5-e779-4610-b1da-4e340e018d26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("327f339c-f043-4900-ba12-ff244404b558"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3cbe45e9-cfb5-4ea1-b12c-78ab4d046578"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5f9ff43c-e1a7-44f8-851a-eb26d21e5325"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6da54deb-a91f-45f8-9b57-b4bfad0587d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("81ad9e9f-257e-4e7a-83dd-753a3f793a93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("884bd96c-0f26-4fda-ab19-0bd622c7c548"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8c4b5cd8-b309-43ce-a159-be559e742b0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a1396cb0-6c9e-4035-9ad7-c24241adbe33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("dbd64776-3bed-4297-983d-51c15b2943bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f1f26f92-9884-43c2-920d-df3c21ccb1b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f5b748ae-aa88-46c4-b15d-daab8b0819bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f73943d9-44fd-4845-94cc-0b83e3505fba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f84c69a8-070c-4866-812b-15a886751430"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("fcefeb9c-7d65-473e-8db0-968cded0fdac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2bcfa103-49cd-495c-abd8-2d44c456cf4c"), new Guid("084d3080-7356-4c83-9c9b-cc0759ee25a5") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30b28ad5-022e-4dd1-8c0f-3804db40fb40"), new Guid("a452dead-d9d0-4f7f-8caa-d28afd79d214") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2bcfa103-49cd-495c-abd8-2d44c456cf4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30b28ad5-022e-4dd1-8c0f-3804db40fb40"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("cee49e34-a9fd-44c1-8d58-86d7d69a4ea2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("2cd88ae9-2dad-4089-9a5d-72fbc7e34d09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("084d3080-7356-4c83-9c9b-cc0759ee25a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a452dead-d9d0-4f7f-8caa-d28afd79d214"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("43b7050b-dfc3-46b1-89eb-dcafe09c967f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 749, DateTimeKind.Local).AddTicks(4999),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "dbo",
                table: "Subscribers",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(1254),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 192, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 763, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 764, DateTimeKind.Local).AddTicks(2199),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 750, DateTimeKind.Local).AddTicks(6409),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 752, DateTimeKind.Local).AddTicks(8746),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 761, DateTimeKind.Local).AddTicks(2961),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 760, DateTimeKind.Local).AddTicks(9040),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(4998),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.CreateTable(
                name: "SiteAreas",
                schema: "dbo",
                columns: table => new
                {
                    SiteAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 8, 18, 44, 4, 751, DateTimeKind.Local).AddTicks(628)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteAreas", x => x.SiteAreaId);
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
    }
}
