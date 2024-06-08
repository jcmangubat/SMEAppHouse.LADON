using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedImportanceMarkerForFAQs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 360, DateTimeKind.Local).AddTicks(373),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 372, DateTimeKind.Local).AddTicks(3139),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 373, DateTimeKind.Local).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 192, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 374, DateTimeKind.Local).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 374, DateTimeKind.Local).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.AddColumn<bool>(
                name: "IsImportant",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 360, DateTimeKind.Local).AddTicks(7562),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 362, DateTimeKind.Local).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 362, DateTimeKind.Local).AddTicks(7720),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 371, DateTimeKind.Local).AddTicks(6544),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 371, DateTimeKind.Local).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 361, DateTimeKind.Local).AddTicks(2214),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0d5e48df-23d7-42b2-bc0c-5d3ba4a09cb3"), null, "Visitor", "VISITOR" },
                    { new Guid("adb82ab0-e728-47a1-918f-0bde869a7fd9"), null, "Manager", "MANAGER" },
                    { new Guid("b306b698-2fbe-4960-b23f-94f17c19728f"), null, "Moderator", "MODERATOR" },
                    { new Guid("be257fef-fd55-4376-a16c-1deaf8ff5ae9"), null, "Client", "CLIENT" },
                    { new Guid("d5c45204-162a-4057-a2d1-2c8cdcf1c7b2"), null, "Admin", "ADMIN" },
                    { new Guid("fe1e3ada-9017-4f5a-86cc-490e5daaa934"), null, "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question" },
                values: new object[,]
                {
                    { new Guid("06627c2f-2b36-4eab-9a63-945bd8b95406"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9619), true, true, "How do you ensure the quality of your construction work?" },
                    { new Guid("12dbdef8-0ccd-408b-bfc4-c8bbcf751cf1"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9621), true, null, "What safety measures do you take on construction sites?" },
                    { new Guid("28539c9e-4c21-43b1-84df-29626662a39c"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9623), true, true, "Are you licensed and insured?" },
                    { new Guid("2a40b490-e4c4-4677-878f-ce35d0e3349b"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9625), true, null, "How will I be updated on the progress of my project?" },
                    { new Guid("3512b77e-9dd8-4325-8bc0-385168c1ac26"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9598), true, true, "Do you provide a warranty for your work?" },
                    { new Guid("3a210d45-bb2d-415f-a90e-25cb7923576a"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9591), true, null, "How can I get a quote for my project?" },
                    { new Guid("4431a332-f3c7-4ebf-a639-e3e9a979ee80"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9634), true, null, "How do you handle project completion and handover?" },
                    { new Guid("4d74f8fc-b402-432f-af84-05f69844b77a"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9617), true, null, "How do I pay for my project?" },
                    { new Guid("64a32be9-1d89-4eeb-8c7f-1498712098f9"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9597), true, true, "What should I consider before starting a construction project?" },
                    { new Guid("69f3d714-3d4c-483a-8e67-15cf84f2fced"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9626), true, null, "What if I need to make changes to the project after it has started?" },
                    { new Guid("70c042db-57dd-4bba-86c5-43759bd4b663"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9575), true, true, "What services does Ladon Construction Services offer?" },
                    { new Guid("7911a5bb-976d-4c35-88a0-4ef1b00ada01"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9628), true, true, "Who will be my point of contact during the project?" },
                    { new Guid("7f26899b-0278-456d-927d-f81e36a399d6"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9610), true, true, "Are there any hidden fees in your estimates?" },
                    { new Guid("90ec4d69-ef71-4119-bb6d-0a89b4652cfd"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9579), true, true, "How long has Ladon Construction Services been in business?" },
                    { new Guid("9261277b-56b7-4f34-a7a8-6e7e504f828e"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9601), true, null, "How do you determine the cost of a construction project?" },
                    { new Guid("b362dd0f-8b9b-46aa-9dc2-ef100c353a83"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9608), true, null, "Do you offer financing options?" },
                    { new Guid("b874bd15-a61b-4920-9d44-2b2589723511"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9630), true, null, "Can I visit the construction site during the project?" },
                    { new Guid("dbbb2a4d-1876-4fdf-a5d0-6f483307619b"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9593), true, true, "How do you handle project timelines?" },
                    { new Guid("e6455220-4214-4beb-abf2-8fff58e21110"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9595), true, null, "Can you help with the design phase of my project?" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("1ae96038-5a0b-40ed-a429-21b4912d9716"), null, null, new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9016), "James", 0, new Guid("601b8873-ed96-46e9-ae18-5ae098183d2b"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("b2e3eb43-2d55-4d34-844b-3a00d44508da"), null, null, new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9063), "Charles", 0, new Guid("d855ad02-4668-4167-a178-52d5763159cb"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("601b8873-ed96-46e9-ae18-5ae098183d2b"), 0, "c14da110-b4c2-489f-9804-b5458f9a6105", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGHy1OK/bg6gbbBhk2oMnndsC2CpSum3DDvxRP9mwRpO7zogg45Vpv+uc9RxNIiW/Q==", "+639672814641", false, "bb300f90-cbac-fa7b-39da-744667f7f0d8_20240608112415375", false, "jc.mangubat@hotmail.com" },
                    { new Guid("d855ad02-4668-4167-a178-52d5763159cb"), 0, "b97bb01b-1c4d-45e8-b3ff-8ce46097aa58", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEDJllJlSE45aXZF7uRxf9IpqsJzoy6gHpcp6FW2GjTFMAogVa9qcayhQnL3cNSRcKA==", "+639951225449", false, "bb300f90-cbac-fa7b-39da-744667f7f0d8_20240608112415375", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0b50959e-8451-4c33-a529-8727eb444f9d"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9182), true, "8000", "Davao del Sur", new Guid("b2e3eb43-2d55-4d34-844b-3a00d44508da") },
                    { new Guid("da71831c-e385-41b4-8aed-7eb4aae6e2c4"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9174), true, "8000", "Davao del Sur", new Guid("1ae96038-5a0b-40ed-a429-21b4912d9716") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("a26b6741-e1ad-400d-857e-92b0f5782b56"), null, new Guid("1ae96038-5a0b-40ed-a429-21b4912d9716"), null, "Creating holy sanctuaries with inspired design, fostering spiritual growth and community.", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9228), null, true, null, null, null, null, null, new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9386), "sanctifying-spaces-crafting-sacred-church-architecture", null, "Sanctifying Spaces: Crafting Sacred Church Architecture", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5c45204-162a-4057-a2d1-2c8cdcf1c7b2"), new Guid("601b8873-ed96-46e9-ae18-5ae098183d2b") },
                    { new Guid("adb82ab0-e728-47a1-918f-0bde869a7fd9"), new Guid("d855ad02-4668-4167-a178-52d5763159cb") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogComments",
                columns: new[] { "BlogCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("82483c3e-a668-4d9c-8cdb-3595186c1592"), "John Doe", new Guid("a26b6741-e1ad-400d-857e-92b0f5782b56"), "This is a fantastic article!", new DateTime(2024, 6, 8, 11, 24, 15, 522, DateTimeKind.Utc).AddTicks(9536), "commenter@gmail.com", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("0b50959e-8451-4c33-a529-8727eb444f9d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("da71831c-e385-41b4-8aed-7eb4aae6e2c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0d5e48df-23d7-42b2-bc0c-5d3ba4a09cb3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b306b698-2fbe-4960-b23f-94f17c19728f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("be257fef-fd55-4376-a16c-1deaf8ff5ae9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe1e3ada-9017-4f5a-86cc-490e5daaa934"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogComments",
                keyColumn: "BlogCommentId",
                keyValue: new Guid("82483c3e-a668-4d9c-8cdb-3595186c1592"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("06627c2f-2b36-4eab-9a63-945bd8b95406"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("12dbdef8-0ccd-408b-bfc4-c8bbcf751cf1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("28539c9e-4c21-43b1-84df-29626662a39c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2a40b490-e4c4-4677-878f-ce35d0e3349b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3512b77e-9dd8-4325-8bc0-385168c1ac26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3a210d45-bb2d-415f-a90e-25cb7923576a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4431a332-f3c7-4ebf-a639-e3e9a979ee80"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4d74f8fc-b402-432f-af84-05f69844b77a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("64a32be9-1d89-4eeb-8c7f-1498712098f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("69f3d714-3d4c-483a-8e67-15cf84f2fced"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("70c042db-57dd-4bba-86c5-43759bd4b663"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7911a5bb-976d-4c35-88a0-4ef1b00ada01"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7f26899b-0278-456d-927d-f81e36a399d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("90ec4d69-ef71-4119-bb6d-0a89b4652cfd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9261277b-56b7-4f34-a7a8-6e7e504f828e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b362dd0f-8b9b-46aa-9dc2-ef100c353a83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b874bd15-a61b-4920-9d44-2b2589723511"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("dbbb2a4d-1876-4fdf-a5d0-6f483307619b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e6455220-4214-4beb-abf2-8fff58e21110"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5c45204-162a-4057-a2d1-2c8cdcf1c7b2"), new Guid("601b8873-ed96-46e9-ae18-5ae098183d2b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("adb82ab0-e728-47a1-918f-0bde869a7fd9"), new Guid("d855ad02-4668-4167-a178-52d5763159cb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("adb82ab0-e728-47a1-918f-0bde869a7fd9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d5c45204-162a-4057-a2d1-2c8cdcf1c7b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("a26b6741-e1ad-400d-857e-92b0f5782b56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("b2e3eb43-2d55-4d34-844b-3a00d44508da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("601b8873-ed96-46e9-ae18-5ae098183d2b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d855ad02-4668-4167-a178-52d5763159cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfileModels",
                keyColumn: "UserProfileModelId",
                keyValue: new Guid("1ae96038-5a0b-40ed-a429-21b4912d9716"));

            migrationBuilder.DropColumn(
                name: "IsImportant",
                schema: "dbo",
                table: "QuestionAnswers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfileModels",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(974),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 360, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(8288),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 372, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 192, DateTimeKind.Local).AddTicks(7834),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 373, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(3384),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 374, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 193, DateTimeKind.Local).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 374, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 360, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(5209),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 362, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 186, DateTimeKind.Local).AddTicks(7554),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 362, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(4972),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 371, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 191, DateTimeKind.Local).AddTicks(2749),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 371, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 8, 19, 6, 29, 185, DateTimeKind.Local).AddTicks(9086),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 8, 19, 24, 15, 361, DateTimeKind.Local).AddTicks(2214));

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
    }
}
