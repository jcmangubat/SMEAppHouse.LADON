using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenamedBlogPostToArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_BlogPosts_RelatedBlogPostId",
                schema: "dbo",
                table: "QuestionAnswers");

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
                name: "BlogPosts",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_RelatedBlogPostId",
                schema: "dbo",
                table: "QuestionAnswers");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("2959d603-0d80-4610-92dd-0b2bce1b0cde"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("f8b0a704-327e-432f-9001-ac6ac005b2f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("03825b28-128e-4e5f-bd67-b9e2c4ab0403"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0df7a39f-792c-4df4-8119-9e61a8d0ed1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0f6f1aeb-8684-4efd-a0fe-2ea85224bfad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("123dfe4a-ad5f-49e8-910c-9ca82bb1be76"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("13db0a37-b36f-40c5-b99d-135ddb5ef8c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("176601c7-723f-4279-b889-8139c37f1a04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("18f72779-1259-4973-b186-c8008593542c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("19489458-6656-446e-8bd4-5c726f1ba656"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1e5423d2-9628-49d2-841d-af4aeb1236a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2b9f5a31-437a-4691-8290-b1f24e7946ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2ef3d2fc-a7a8-40dc-89dd-313d15a80877"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("30b1b491-a7b7-4f64-b06a-d1f5c9333f06"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3e7a2f69-45dd-4c7b-b556-83ed90148f92"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("405c3da0-a2f9-4a36-a95b-a1854232eb88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("53792fbb-acef-4d48-9d22-49a7afd2972c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5c7ac0ad-8b77-42bd-9521-52c31fa4d9bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("610c73b1-6923-4e69-b31d-857f75a80740"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6c75c487-77c4-41ef-8f19-0203b2dd6ea9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("713bd683-03d1-4472-9336-9239478dcebf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7183f898-80cc-4fab-b637-d1c4994bb9af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7996107b-ad1e-463c-8687-4cfe5badc92b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7aa52905-97e1-4fdc-9c45-b238c05fa044"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("89ef2874-36b1-4fe2-b03e-6d905c8a8b88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("aad0ac38-9dfa-4e94-b99d-da88a0df32da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ac91464c-f516-4b1d-bcff-680859023e17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b2ce5c80-09dd-4743-b9a7-95c8746c2346"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c3634ce5-3b2a-4976-b08d-142d72806f35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c385ad73-8641-4461-b076-9ded84875769"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ca9cd332-25f4-461a-93e1-9545b3902ae7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ce8ee555-05e0-4b08-9568-ed35d2a187ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d3f7f797-14e7-4891-aa04-7bd9717764b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d50dabd8-3cf7-49e0-81c1-7d81288823d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("dc758a46-b208-4a2f-9b5a-3657c981c526"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e3fd94c2-f576-42af-8221-11b8e827dace"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f209ba48-fea3-487f-b448-27a2ec654052"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f41b5d18-81b9-4ae1-86cc-181e50233aa3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f56d64b7-b3c0-47f3-bd69-58411f12a4bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f82ea73e-0d79-49da-9b3c-b3d9b5a57258"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f915ed4f-a445-41dd-8da9-7b2f36b51dce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ff34eea8-db6d-4d84-907e-e1f1904cf64a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("016d7794-0d56-41ba-b6dd-f60976dc5d08"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b001e07-3acd-4dcb-96e9-6380c369ca3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("55b4d2ff-17ba-4e46-90c0-29fe3dc1301d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("88c2e092-87e5-4f8e-a69f-33764dbbe023"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("02ca5052-f7a3-4532-9951-d1a43835706c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("07366276-0101-4c56-be0b-b4ecd843fa88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("082e5a59-7e4d-46ea-ab27-3bdedba48032"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0a192ecc-113e-465f-a2ed-a428f07f4d34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1a7b72b5-df3c-4e59-942e-ec2c764cab7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("35c838d7-0238-414a-b50b-3517641cf15f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("363290ff-a94c-4a43-ac5a-d5141d299962"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("68e2bb12-801e-4908-9641-420cbe03d9d3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6b58a8bc-846f-40af-8844-c90a69ff849c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("75a3b059-0645-4db6-896e-8feac8134ab1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8121190b-540f-496a-a798-798886539da9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a3ca4647-a295-4add-a070-ac90318099ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("aa8f5930-2f8d-4697-a737-b2921b4cfb4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("afad9386-7788-4876-96c9-8259956a2538"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b02bd1b7-2fd1-400d-8413-9379b33814ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b26464fb-dfc5-4c59-86b4-435e74d1a97c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b8e8a3fd-a8c7-45f0-b628-4c03fce84cd1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b92db653-39cc-4973-a6bc-02fb3f295d36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e89172ca-14ec-49be-a8cc-6419869c438d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("00cf22d5-029d-4482-bc6a-fcd4ee94248b"), new Guid("0b647f90-5166-4738-93ea-84547dea4fe0") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0ef18b2d-d23c-4b8a-ab9e-3a2cbc500796"), new Guid("707b24cd-f729-4a15-b886-342837c2d453") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00cf22d5-029d-4482-bc6a-fcd4ee94248b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0ef18b2d-d23c-4b8a-ab9e-3a2cbc500796"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("399f2f76-88bd-4e55-8715-c071a692bcd4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("74a32ca2-9591-490c-8cac-d5d4188b5212"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b647f90-5166-4738-93ea-84547dea4fe0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("707b24cd-f729-4a15-b886-342837c2d453"));

            migrationBuilder.RenameColumn(
                name: "RelatedBlogPostId",
                schema: "dbo",
                table: "QuestionAnswers",
                newName: "RelatedArticleId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 159, DateTimeKind.Local).AddTicks(4610),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 385, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 175, DateTimeKind.Local).AddTicks(2611),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 398, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 176, DateTimeKind.Local).AddTicks(4039),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 176, DateTimeKind.Local).AddTicks(9657),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 177, DateTimeKind.Local).AddTicks(2547),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 160, DateTimeKind.Local).AddTicks(3919),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 161, DateTimeKind.Local).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 174, DateTimeKind.Local).AddTicks(1492),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 160, DateTimeKind.Local).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.CreateTable(
                name: "Articles",
                schema: "dbo",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 161, DateTimeKind.Local).AddTicks(9330)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ArticleType = table.Column<int>(type: "int", nullable: false),
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 174, DateTimeKind.Local).AddTicks(7916)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 174, DateTimeKind.Local).AddTicks(4886)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    ImageCDNUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("00fa268c-ca27-439d-af80-349f44015d47"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3203), true, "Supply Chain and Logistics" },
                    { new Guid("03f8d5cb-ed09-4bb6-95f0-8ec641df3b20"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3210), true, "Training and Certification" },
                    { new Guid("0a228566-a905-4e14-a3e4-05477ba785bd"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3218), true, "Weather and Seasonal Tips" },
                    { new Guid("0cb34bc7-90d6-405f-8d7a-ef37265341ba"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(1515), true, "Accessibility in Construction" },
                    { new Guid("11b099fe-0ead-4d9f-ad44-b2195ab24712"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3105), true, "Health and Wellness in Construction" },
                    { new Guid("1889bf66-e371-4697-a2e6-20522379537c"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3055), true, "Customer Stories and Interviews" },
                    { new Guid("1ac12081-fcd7-4a51-98bd-29b784896f00"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3050), true, "Construction Techniques" },
                    { new Guid("21a8c6d7-5afa-429e-a1f1-676e2b4ac8d4"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3016), true, "Client Education" },
                    { new Guid("224817da-4471-4769-a4a4-721269818d99"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3047), true, "Construction Management" },
                    { new Guid("269900f4-abf0-46c0-86fd-776826ec0bb2"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3063), true, "Disaster Preparedness and Recovery" },
                    { new Guid("29e16487-6593-498d-ad9a-60b63f8e1133"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3058), true, "Design and Architecture" },
                    { new Guid("2ba6ca47-2743-4921-ae8b-a66c6f381fc3"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3181), true, "Legal and Insurance" },
                    { new Guid("3715ea08-073a-4c05-9ce0-d0eebfc2b123"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3107), true, "Historic Preservation" },
                    { new Guid("3d3d7d52-4052-4e2a-bbfd-c66e9a421888"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3173), true, "Innovation and Future Trends" },
                    { new Guid("41e618fc-4c2d-482d-9dd2-0a0cf5f8a01c"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3102), true, "Green Building Materials" },
                    { new Guid("486f6f33-a58a-4123-be91-1bc35a943736"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3196), true, "Real Estate Development" },
                    { new Guid("49963d44-44b6-4e72-9f20-337b6c10fddd"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3013), true, "Case Studies and Success Stories" },
                    { new Guid("5b9fea9e-bc2d-4256-b16e-e39a15c23824"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3018), true, "Client Resources" },
                    { new Guid("652697b2-eba4-4d27-b24b-0ccc7f6bb2aa"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3208), true, "Technology in Construction" },
                    { new Guid("69f76ebf-bb80-424c-a804-f4fca5d65059"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3201), true, "Smart Home Technology" },
                    { new Guid("6e904ed1-4802-4c4a-8069-0b68f630a107"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3045), true, "Construction Finance" },
                    { new Guid("6f69eee1-b945-40bf-9fdd-a4c07aaa740b"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3170), true, "Industry News" },
                    { new Guid("70b57cf1-30a3-45d8-9bc7-6baf44fec250"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3042), true, "Construction Careers" },
                    { new Guid("77202bd1-f156-4f57-a18f-7afcf70c0c0d"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3188), true, "Project Showcase" },
                    { new Guid("82c69c40-1a52-4b5f-82ff-81fbabd567fb"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3021), true, "Community and Culture" },
                    { new Guid("8625f96d-468f-4500-977e-2d3fbe1769f0"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3176), true, "Innovation Awards and Recognitions" },
                    { new Guid("8cf58e92-6d2a-4938-ac36-2f0a44ef4ecf"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3193), true, "Property Management" },
                    { new Guid("8df1fe97-a5a5-4342-a1a4-f5848ad1c7ac"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3206), true, "Sustainability and Green Building" },
                    { new Guid("a2c4141a-b90a-49d4-8e66-6ac6f83150f3"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3069), true, "Environmental Impact" },
                    { new Guid("a7cc0470-bab1-4dab-8cc0-b914a5ce599d"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3183), true, "Materials and Equipment" },
                    { new Guid("ad6e3aef-6e50-4790-83b7-8d6a51f5600e"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3052), true, "Cost Estimation and Budgeting" },
                    { new Guid("b01b2d40-1de1-4316-84ad-95fc360a4bcb"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3099), true, "Equipment Maintenance" },
                    { new Guid("c11b4360-970e-43f1-be27-9e3472d4253d"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3186), true, "Modular and Prefabricated Construction" },
                    { new Guid("cd9a9358-45ab-41dd-9a18-e8f948f8ac5e"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3215), true, "Urban Planning and Development" },
                    { new Guid("cdebfdcb-a0e6-4964-b673-1c94fb926821"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(2995), true, "Building Codes and Standards" },
                    { new Guid("cfc04ef9-f481-4689-ace1-5ea4ab8fb4a5"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3110), true, "Home Improvement and DIY" },
                    { new Guid("d34c7dde-1b9a-4f8b-b257-dc6ff4fbf1b6"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3198), true, "Safety and Compliance" },
                    { new Guid("d4038a0d-2e3b-40e7-ad18-2f9aa4965a94"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3040), true, "Company Updates" },
                    { new Guid("ee325cbe-26bc-4d56-91ca-8246cefadc7a"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3178), true, "Landscaping and Outdoor Design" },
                    { new Guid("f42f149c-78da-4224-b7ef-2d1c8dec48d8"), new DateTime(2024, 6, 12, 12, 8, 48, 317, DateTimeKind.Utc).AddTicks(3066), true, "Energy Efficiency" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("fc4eefaa-bfb5-41a9-80e5-ab3b2f6efc94"), 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "sustainable-solutions.md", new DateTime(2024, 6, 12, 12, 8, 50, 333, DateTimeKind.Utc).AddTicks(6370), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading the way in sustainable construction, minimizing environmental impact for a brighter future.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3829d801-fcee-483c-bc65-8d05c1193bd3"), null, "Admin", "ADMIN" },
                    { new Guid("3e7a7af6-31d0-41b3-96dc-e918a53f85cc"), null, "Editor", "EDITOR" },
                    { new Guid("7dc84681-0cdc-4c29-bd5b-b83c571f5fff"), null, "Visitor", "VISITOR" },
                    { new Guid("ab0fae75-765f-4864-8348-3ba3162d59e3"), null, "Manager", "MANAGER" },
                    { new Guid("cb8cae03-986f-494c-a41c-2b1510256cac"), null, "Client", "CLIENT" },
                    { new Guid("ff164d5f-4077-4747-8aa5-fd70353b1321"), null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("0bc69892-08e7-4fac-bb5b-34f5396b6984"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6528), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("19ae5453-2557-44cc-b30d-908dc7e131da"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6507), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("21c667dd-23b7-433c-ade7-4c09a8e76573"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6505), true, null, "Do you offer financing options?", null },
                    { new Guid("2584ccde-8fd5-4745-9b54-0dc4cbe21f88"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6524), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("27a7c4db-cdb8-43ef-bfd0-b40381b4be7c"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6527), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("2b0efbc1-c30c-49d0-b873-f054b9dbf665"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6522), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("3f035e51-f1a5-45f7-8abe-46bc6c7540db"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6482), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("50f72dea-4ddf-473b-9ae1-6cc83794d29c"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6520), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("59c607b7-d7ad-4ff3-b93a-d87c5b24feec"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6513), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("5e6086bd-3087-455b-a0cf-558d6f687c50"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6501), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("61379eb4-d247-47b8-b3d2-c2694c6d35c6"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6491), true, true, "How do you handle project timelines?", null },
                    { new Guid("6eca351f-d2ae-43dc-b63c-f35ba2ad0a6f"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6509), true, null, "How do I pay for my project?", null },
                    { new Guid("83aa0ac8-eb17-4327-aa80-a01454b018a5"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6515), true, true, "Are you licensed and insured?", null },
                    { new Guid("a02961a4-86bd-4764-bfc4-244f8c0c2dc1"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6503), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("aefb166b-0a7e-4fcd-a070-c0c67b60f1cf"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6493), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("bcff0df2-6525-4d71-81ae-0c6688cb0e21"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6486), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("c2b3e757-6677-44c4-a839-b871ba3c9c3d"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6488), true, null, "How can I get a quote for my project?", null },
                    { new Guid("cc7208de-69bc-4017-8a7b-98b95262a017"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6511), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("eb5c7e4b-52f3-4fc4-a8cd-78b1f8836164"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6495), true, true, "What should I consider before starting a construction project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("03f7b33b-a4cd-4e1c-a2fa-a6e5a604b213"), null, null, new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6308), "James", 0, new Guid("b5bb26f3-73d4-41b6-b898-10d4eb27b8b9"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("8198253f-b3f2-44ce-a3fa-7cf09cc540ff"), null, null, new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6354), "Charles", 0, new Guid("c55a297a-cd7d-4890-b934-07a909d371af"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b5bb26f3-73d4-41b6-b898-10d4eb27b8b9"), 0, "384f47ac-684c-474d-a614-64adc7e63a66", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDlq2Q+YkyzEIdI/S0e4mnflWVhm4IN4meQEfdKq4UkzHQDti9Ch0Xk9zks/9s6Q2w==", "+639672814641", false, "98ec28c8-606b-2f78-1c45-f6a2f32991b3_20240612120850177", false, "jc.mangubat@hotmail.com" },
                    { new Guid("c55a297a-cd7d-4890-b934-07a909d371af"), 0, "922544fc-e938-4fc7-9517-1e3662e4aa84", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAELuqOhWFK9VbgbLH2w+EvXAVez9L48jeU0pr/p+hxquC+RjhLUgGsbrxZff/oLhbyQ==", "+639951225449", false, "98ec28c8-606b-2f78-1c45-f6a2f32991b3_20240612120850177", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("725cd08f-dba4-4ed7-9a5c-21c04cef106a"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6445), true, "8000", "Davao del Sur", new Guid("8198253f-b3f2-44ce-a3fa-7cf09cc540ff") },
                    { new Guid("e063bce8-7525-46f0-979a-4b9451b4176b"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 12, 12, 8, 50, 332, DateTimeKind.Utc).AddTicks(6438), true, "8000", "Davao del Sur", new Guid("03f7b33b-a4cd-4e1c-a2fa-a6e5a604b213") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[] { new Guid("8df1fe97-a5a5-4342-a1a4-f5848ad1c7ac"), new Guid("fc4eefaa-bfb5-41a9-80e5-ab3b2f6efc94") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("9588313c-033d-42bf-86ad-4ce6a87e2f8f"), new Guid("fc4eefaa-bfb5-41a9-80e5-ab3b2f6efc94"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 12, 12, 8, 50, 333, DateTimeKind.Utc).AddTicks(7117), "commenter@gmail.com", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[] { new Guid("b80f06d2-bcd2-415f-8293-ead37f3190ea"), new Guid("fc4eefaa-bfb5-41a9-80e5-ab3b2f6efc94"), new DateTime(2024, 6, 12, 12, 8, 50, 333, DateTimeKind.Utc).AddTicks(7129), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3829d801-fcee-483c-bc65-8d05c1193bd3"), new Guid("b5bb26f3-73d4-41b6-b898-10d4eb27b8b9") },
                    { new Guid("ab0fae75-765f-4864-8348-3ba3162d59e3"), new Guid("c55a297a-cd7d-4890-b934-07a909d371af") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_RelatedArticleId",
                schema: "dbo",
                table: "QuestionAnswers",
                column: "RelatedArticleId",
                unique: true,
                filter: "[RelatedArticleId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_Articles_RelatedArticleId",
                schema: "dbo",
                table: "QuestionAnswers",
                column: "RelatedArticleId",
                principalSchema: "dbo",
                principalTable: "Articles",
                principalColumn: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswers_Articles_RelatedArticleId",
                schema: "dbo",
                table: "QuestionAnswers");

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
                name: "Articles",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswers_RelatedArticleId",
                schema: "dbo",
                table: "QuestionAnswers");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("725cd08f-dba4-4ed7-9a5c-21c04cef106a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e063bce8-7525-46f0-979a-4b9451b4176b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("00fa268c-ca27-439d-af80-349f44015d47"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("03f8d5cb-ed09-4bb6-95f0-8ec641df3b20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0a228566-a905-4e14-a3e4-05477ba785bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0cb34bc7-90d6-405f-8d7a-ef37265341ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("11b099fe-0ead-4d9f-ad44-b2195ab24712"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1889bf66-e371-4697-a2e6-20522379537c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1ac12081-fcd7-4a51-98bd-29b784896f00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("21a8c6d7-5afa-429e-a1f1-676e2b4ac8d4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("224817da-4471-4769-a4a4-721269818d99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("269900f4-abf0-46c0-86fd-776826ec0bb2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("29e16487-6593-498d-ad9a-60b63f8e1133"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2ba6ca47-2743-4921-ae8b-a66c6f381fc3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3715ea08-073a-4c05-9ce0-d0eebfc2b123"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3d3d7d52-4052-4e2a-bbfd-c66e9a421888"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("41e618fc-4c2d-482d-9dd2-0a0cf5f8a01c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("486f6f33-a58a-4123-be91-1bc35a943736"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("49963d44-44b6-4e72-9f20-337b6c10fddd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5b9fea9e-bc2d-4256-b16e-e39a15c23824"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("652697b2-eba4-4d27-b24b-0ccc7f6bb2aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("69f76ebf-bb80-424c-a804-f4fca5d65059"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6e904ed1-4802-4c4a-8069-0b68f630a107"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6f69eee1-b945-40bf-9fdd-a4c07aaa740b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("70b57cf1-30a3-45d8-9bc7-6baf44fec250"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("77202bd1-f156-4f57-a18f-7afcf70c0c0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("82c69c40-1a52-4b5f-82ff-81fbabd567fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8625f96d-468f-4500-977e-2d3fbe1769f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8cf58e92-6d2a-4938-ac36-2f0a44ef4ecf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8df1fe97-a5a5-4342-a1a4-f5848ad1c7ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a2c4141a-b90a-49d4-8e66-6ac6f83150f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a7cc0470-bab1-4dab-8cc0-b914a5ce599d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ad6e3aef-6e50-4790-83b7-8d6a51f5600e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b01b2d40-1de1-4316-84ad-95fc360a4bcb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c11b4360-970e-43f1-be27-9e3472d4253d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cd9a9358-45ab-41dd-9a18-e8f948f8ac5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cdebfdcb-a0e6-4964-b673-1c94fb926821"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cfc04ef9-f481-4689-ace1-5ea4ab8fb4a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d34c7dde-1b9a-4f8b-b257-dc6ff4fbf1b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d4038a0d-2e3b-40e7-ad18-2f9aa4965a94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ee325cbe-26bc-4d56-91ca-8246cefadc7a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f42f149c-78da-4224-b7ef-2d1c8dec48d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3e7a7af6-31d0-41b3-96dc-e918a53f85cc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7dc84681-0cdc-4c29-bd5b-b83c571f5fff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cb8cae03-986f-494c-a41c-2b1510256cac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ff164d5f-4077-4747-8aa5-fd70353b1321"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0bc69892-08e7-4fac-bb5b-34f5396b6984"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("19ae5453-2557-44cc-b30d-908dc7e131da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("21c667dd-23b7-433c-ade7-4c09a8e76573"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2584ccde-8fd5-4745-9b54-0dc4cbe21f88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("27a7c4db-cdb8-43ef-bfd0-b40381b4be7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2b0efbc1-c30c-49d0-b873-f054b9dbf665"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3f035e51-f1a5-45f7-8abe-46bc6c7540db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("50f72dea-4ddf-473b-9ae1-6cc83794d29c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("59c607b7-d7ad-4ff3-b93a-d87c5b24feec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5e6086bd-3087-455b-a0cf-558d6f687c50"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("61379eb4-d247-47b8-b3d2-c2694c6d35c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6eca351f-d2ae-43dc-b63c-f35ba2ad0a6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("83aa0ac8-eb17-4327-aa80-a01454b018a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a02961a4-86bd-4764-bfc4-244f8c0c2dc1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("aefb166b-0a7e-4fcd-a070-c0c67b60f1cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("bcff0df2-6525-4d71-81ae-0c6688cb0e21"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c2b3e757-6677-44c4-a839-b871ba3c9c3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("cc7208de-69bc-4017-8a7b-98b95262a017"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("eb5c7e4b-52f3-4fc4-a8cd-78b1f8836164"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3829d801-fcee-483c-bc65-8d05c1193bd3"), new Guid("b5bb26f3-73d4-41b6-b898-10d4eb27b8b9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ab0fae75-765f-4864-8348-3ba3162d59e3"), new Guid("c55a297a-cd7d-4890-b934-07a909d371af") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3829d801-fcee-483c-bc65-8d05c1193bd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab0fae75-765f-4864-8348-3ba3162d59e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("03f7b33b-a4cd-4e1c-a2fa-a6e5a604b213"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("8198253f-b3f2-44ce-a3fa-7cf09cc540ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5bb26f3-73d4-41b6-b898-10d4eb27b8b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c55a297a-cd7d-4890-b934-07a909d371af"));

            migrationBuilder.RenameColumn(
                name: "RelatedArticleId",
                schema: "dbo",
                table: "QuestionAnswers",
                newName: "RelatedBlogPostId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 385, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 159, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 398, DateTimeKind.Local).AddTicks(1397),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 175, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(739),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 176, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(5010),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 176, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(7333),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 177, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(3899),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 160, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 161, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 174, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(8453),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 20, 8, 50, 160, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(8898)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    AuthorUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorAvatarImageCDNUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CanonicalUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentSourceMDCDNUrl = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    ContentSourceMDFileName = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    Hearts = table.Column<int>(type: "int", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuestionAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Views = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                    table.ForeignKey(
                        name: "FK_BlogPosts_UserProfiles_AuthorUserProfileId",
                        column: x => x.AuthorUserProfileId,
                        principalSchema: "dbo",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(7767)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(5446)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageCDNUrl = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("03825b28-128e-4e5f-bd67-b9e2c4ab0403"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7161), true, "Industry News" },
                    { new Guid("0df7a39f-792c-4df4-8119-9e61a8d0ed1d"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7117), true, "Energy Efficiency" },
                    { new Guid("0f6f1aeb-8684-4efd-a0fe-2ea85224bfad"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7086), true, "Client Resources" },
                    { new Guid("123dfe4a-ad5f-49e8-910c-9ca82bb1be76"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7110), true, "Customer Stories and Interviews" },
                    { new Guid("13db0a37-b36f-40c5-b99d-135ddb5ef8c9"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7157), true, "Historic Preservation" },
                    { new Guid("176601c7-723f-4279-b889-8139c37f1a04"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7119), true, "Environmental Impact" },
                    { new Guid("18f72779-1259-4973-b186-c8008593542c"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7155), true, "Health and Wellness in Construction" },
                    { new Guid("19489458-6656-446e-8bd4-5c726f1ba656"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7259), true, "Real Estate Development" },
                    { new Guid("1e5423d2-9628-49d2-841d-af4aeb1236a9"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7150), true, "Equipment Maintenance" },
                    { new Guid("2b9f5a31-437a-4691-8290-b1f24e7946ac"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7106), true, "Construction Techniques" },
                    { new Guid("2ef3d2fc-a7a8-40dc-89dd-313d15a80877"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7275), true, "Training and Certification" },
                    { new Guid("30b1b491-a7b7-4f64-b06a-d1f5c9333f06"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7279), true, "Weather and Seasonal Tips" },
                    { new Guid("3e7a2f69-45dd-4c7b-b556-83ed90148f92"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7173), true, "Legal and Insurance" },
                    { new Guid("405c3da0-a2f9-4a36-a95b-a1854232eb88"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7266), true, "Smart Home Technology" },
                    { new Guid("53792fbb-acef-4d48-9d22-49a7afd2972c"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(5808), true, "Accessibility in Construction" },
                    { new Guid("5c7ac0ad-8b77-42bd-9521-52c31fa4d9bf"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7103), true, "Construction Management" },
                    { new Guid("610c73b1-6923-4e69-b31d-857f75a80740"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7261), true, "Safety and Compliance" },
                    { new Guid("6c75c487-77c4-41ef-8f19-0203b2dd6ea9"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7094), true, "Construction Careers" },
                    { new Guid("713bd683-03d1-4472-9336-9239478dcebf"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7257), true, "Property Management" },
                    { new Guid("7183f898-80cc-4fab-b637-d1c4994bb9af"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7081), true, "Case Studies and Success Stories" },
                    { new Guid("7996107b-ad1e-463c-8687-4cfe5badc92b"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7164), true, "Innovation and Future Trends" },
                    { new Guid("7aa52905-97e1-4fdc-9c45-b238c05fa044"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7166), true, "Innovation Awards and Recognitions" },
                    { new Guid("89ef2874-36b1-4fe2-b03e-6d905c8a8b88"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7277), true, "Urban Planning and Development" },
                    { new Guid("aad0ac38-9dfa-4e94-b99d-da88a0df32da"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7175), true, "Materials and Equipment" },
                    { new Guid("ac91464c-f516-4b1d-bcff-680859023e17"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7067), true, "Building Codes and Standards" },
                    { new Guid("b2ce5c80-09dd-4743-b9a7-95c8746c2346"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7270), true, "Sustainability and Green Building" },
                    { new Guid("c3634ce5-3b2a-4976-b08d-142d72806f35"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7092), true, "Company Updates" },
                    { new Guid("c385ad73-8641-4461-b076-9ded84875769"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7159), true, "Home Improvement and DIY" },
                    { new Guid("ca9cd332-25f4-461a-93e1-9545b3902ae7"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7083), true, "Client Education" },
                    { new Guid("ce8ee555-05e0-4b08-9568-ed35d2a187ed"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7153), true, "Green Building Materials" },
                    { new Guid("d3f7f797-14e7-4891-aa04-7bd9717764b2"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7096), true, "Construction Finance" },
                    { new Guid("d50dabd8-3cf7-49e0-81c1-7d81288823d5"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7178), true, "Modular and Prefabricated Construction" },
                    { new Guid("dc758a46-b208-4a2f-9b5a-3657c981c526"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7108), true, "Cost Estimation and Budgeting" },
                    { new Guid("e3fd94c2-f576-42af-8221-11b8e827dace"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7112), true, "Design and Architecture" },
                    { new Guid("f209ba48-fea3-487f-b448-27a2ec654052"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7272), true, "Technology in Construction" },
                    { new Guid("f41b5d18-81b9-4ae1-86cc-181e50233aa3"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7171), true, "Landscaping and Outdoor Design" },
                    { new Guid("f56d64b7-b3c0-47f3-bd69-58411f12a4bb"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7268), true, "Supply Chain and Logistics" },
                    { new Guid("f82ea73e-0d79-49da-9b3c-b3d9b5a57258"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7254), true, "Project Showcase" },
                    { new Guid("f915ed4f-a445-41dd-8da9-7b2f36b51dce"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7114), true, "Disaster Preparedness and Recovery" },
                    { new Guid("ff34eea8-db6d-4d84-907e-e1f1904cf64a"), new DateTime(2024, 6, 10, 23, 45, 30, 932, DateTimeKind.Utc).AddTicks(7090), true, "Community and Culture" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("00cf22d5-029d-4482-bc6a-fcd4ee94248b"), null, "Manager", "MANAGER" },
                    { new Guid("016d7794-0d56-41ba-b6dd-f60976dc5d08"), null, "Editor", "EDITOR" },
                    { new Guid("0ef18b2d-d23c-4b8a-ab9e-3a2cbc500796"), null, "Admin", "ADMIN" },
                    { new Guid("4b001e07-3acd-4dcb-96e9-6380c369ca3f"), null, "Client", "CLIENT" },
                    { new Guid("55b4d2ff-17ba-4e46-90c0-29fe3dc1301d"), null, "Moderator", "MODERATOR" },
                    { new Guid("88c2e092-87e5-4f8e-a69f-33764dbbe023"), null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("b83f4030-ecac-45b6-807b-a86b3112b9e8"), "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "sustainable-solutions.md", new DateTime(2024, 6, 10, 23, 45, 32, 591, DateTimeKind.Utc).AddTicks(715), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading the way in sustainable construction, minimizing environmental impact for a brighter future.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedBlogPostId" },
                values: new object[,]
                {
                    { new Guid("02ca5052-f7a3-4532-9951-d1a43835706c"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8996), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("07366276-0101-4c56-be0b-b4ecd843fa88"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8945), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("082e5a59-7e4d-46ea-ab27-3bdedba48032"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8972), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("0a192ecc-113e-465f-a2ed-a428f07f4d34"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8949), true, null, "Do you offer financing options?", null },
                    { new Guid("1a7b72b5-df3c-4e59-942e-ec2c764cab7d"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8931), true, null, "How can I get a quote for my project?", null },
                    { new Guid("35c838d7-0238-414a-b50b-3517641cf15f"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8951), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("363290ff-a94c-4a43-ac5a-d5141d299962"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8941), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("68e2bb12-801e-4908-9641-420cbe03d9d3"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8991), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("6b58a8bc-846f-40af-8844-c90a69ff849c"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8995), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("75a3b059-0645-4db6-896e-8feac8134ab1"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8929), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("8121190b-540f-496a-a798-798886539da9"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8993), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("a3ca4647-a295-4add-a070-ac90318099ec"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8923), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("aa8f5930-2f8d-4697-a737-b2921b4cfb4a"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8965), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("afad9386-7788-4876-96c9-8259956a2538"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8947), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("b02bd1b7-2fd1-400d-8413-9379b33814ff"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8943), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("b26464fb-dfc5-4c59-86b4-435e74d1a97c"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8961), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("b8e8a3fd-a8c7-45f0-b628-4c03fce84cd1"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8970), true, true, "Are you licensed and insured?", null },
                    { new Guid("b92db653-39cc-4973-a6bc-02fb3f295d36"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8959), true, null, "How do I pay for my project?", null },
                    { new Guid("e89172ca-14ec-49be-a8cc-6419869c438d"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8933), true, true, "How do you handle project timelines?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("399f2f76-88bd-4e55-8715-c071a692bcd4"), null, null, new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8720), "James", 0, new Guid("707b24cd-f729-4a15-b886-342837c2d453"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("74a32ca2-9591-490c-8cac-d5d4188b5212"), null, null, new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8758), "Charles", 0, new Guid("0b647f90-5166-4738-93ea-84547dea4fe0"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0b647f90-5166-4738-93ea-84547dea4fe0"), 0, "6fceb003-3d17-40eb-9d92-c1cce0673987", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEPQ7YnBwLTDB+DXT7bd9Ph74hHO5T/3jte8kVxlS/oSeRSDhZF5mwt3cw6Y5d3p4lQ==", "+639951225449", false, "1286d8e2-b0a7-51b6-0f32-3aa6be39475b_20240610234532399", false, "ladonconst@gmail.com" },
                    { new Guid("707b24cd-f729-4a15-b886-342837c2d453"), 0, "1a1c85ec-fc20-4086-b50d-271e3a0ffab9", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFJWg57Kh+xM1kVz7nIaPNHvWzkmL32/SBj6ZBa9dB199BdU9MvXsO2IXa0zER1LIg==", "+639672814641", false, "1286d8e2-b0a7-51b6-0f32-3aa6be39475b_20240610234532399", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2959d603-0d80-4610-92dd-0b2bce1b0cde"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8881), true, "8000", "Davao del Sur", new Guid("74a32ca2-9591-490c-8cac-d5d4188b5212") },
                    { new Guid("f8b0a704-327e-432f-9001-ac6ac005b2f1"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 23, 45, 32, 589, DateTimeKind.Utc).AddTicks(8874), true, "8000", "Davao del Sur", new Guid("399f2f76-88bd-4e55-8715-c071a692bcd4") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostComments",
                columns: new[] { "BlogPostCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("8ee134d0-3551-43e0-80c7-9025bcfc4b6b"), "John Doe", new Guid("b83f4030-ecac-45b6-807b-a86b3112b9e8"), "This is a fantastic article!", new DateTime(2024, 6, 10, 23, 45, 32, 591, DateTimeKind.Utc).AddTicks(1004), "commenter@gmail.com", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostImages",
                columns: new[] { "BlogPostImageId", "BlogPostId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[] { new Guid("f710053a-afd8-4d9b-a3e5-71e0aaca5cdd"), new Guid("b83f4030-ecac-45b6-807b-a86b3112b9e8"), new DateTime(2024, 6, 10, 23, 45, 32, 591, DateTimeKind.Utc).AddTicks(1024), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00cf22d5-029d-4482-bc6a-fcd4ee94248b"), new Guid("0b647f90-5166-4738-93ea-84547dea4fe0") },
                    { new Guid("0ef18b2d-d23c-4b8a-ab9e-3a2cbc500796"), new Guid("707b24cd-f729-4a15-b886-342837c2d453") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_RelatedBlogPostId",
                schema: "dbo",
                table: "QuestionAnswers",
                column: "RelatedBlogPostId",
                unique: true,
                filter: "[RelatedBlogPostId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswers_BlogPosts_RelatedBlogPostId",
                schema: "dbo",
                table: "QuestionAnswers",
                column: "RelatedBlogPostId",
                principalSchema: "dbo",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId");
        }
    }
}
