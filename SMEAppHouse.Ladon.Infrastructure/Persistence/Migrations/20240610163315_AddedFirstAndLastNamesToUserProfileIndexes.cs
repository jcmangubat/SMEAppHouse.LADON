using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstAndLastNamesToUserProfileIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserProfileModels_UserProfileId",
                schema: "dbo",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_UserProfileModels_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientTestimonies_UserProfileModels_UserProfileId",
                schema: "dbo",
                table: "ClientTestimonies");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_UserProfileModels_UserProfileId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_QuoteRequests_UserProfileModels_RequestorUserProfileId",
                schema: "dbo",
                table: "QuoteRequests");

            migrationBuilder.DropTable(
                name: "UserProfileModels",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("147f43f3-9813-4ee1-82bb-f09e8a7b85f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("5a76559b-9007-4bf4-9cc0-03b2834d9bb4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0386e147-ebfa-4205-b6e2-33965eeaa564"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("11a92ac0-1444-4288-ac98-ba6a24e5722f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("273304ac-4a0d-40c4-9d55-606dab3aae44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("28580dff-bc42-44ae-a731-885a2223b7ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2ab79803-c8c9-49e1-a1ce-c0889c57aa49"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2c47dc5c-e180-499f-a11e-434f62002d15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2f432f1f-a747-4f09-a26c-251860d9b54c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3b483fe5-dc55-4642-830e-a42ecbf8b9a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3f4a0910-3ba3-42f3-957c-66a4bfb29701"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4613d0f8-31ed-46b5-8cea-ba51d07647ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("477444c5-46dc-4deb-afda-df9871c48f8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4a8b6fb6-faed-483a-9245-1ecf52a0c3e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4fc9b97f-0c46-4505-8288-13b3897d1f14"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5510868f-518a-4862-b4df-906157410b73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("589f171f-004c-4e50-95f1-7eca6e8d72f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5908ae8b-92c9-42fa-a716-343830d7cd98"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5e7bb04c-f041-48cf-a4c8-f292f1e3a2ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("65075dc7-f9fe-491c-b8ba-b56927c50053"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6730bd81-12b9-4e34-933c-5adeaff1df8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6d0a3393-4162-4099-91cc-b45abbf48156"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6f2d6adc-0862-4b6d-9277-90daaaf5b27b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7a6dcba2-fae8-419d-9dd8-d7c2de0941de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7b09a973-8733-478e-8e39-aa2f6b76d783"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8a3503e8-73e1-48b0-852c-9d1686ffc286"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("90afd159-f02c-4fb8-ad09-f7adb0593a73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9f58dad8-9553-4eaf-a2b6-bb68cc9f7a1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a20a7ce3-0414-4d9a-ac77-e5f0f818b4d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a2cc2636-ee0b-477d-8c97-7e37503d5711"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a9b89609-d2cf-4b26-9e0d-69c4960cb76d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("abaa91e5-6c21-4d89-97af-fb390951c89c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b3a9efa9-e706-4bb0-ab87-38aa1b235857"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b9234713-495b-4b15-ac93-42505da58783"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("befcd7c0-716e-4acf-9b63-20d9cf8110e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c74febad-1633-4732-9713-b404ed2926f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cbd822de-dade-4243-834d-386d6a0a7b88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e47dce1f-5898-4ebc-bea7-4888bcad6dcb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f6eb5ada-e4a0-4cc4-9986-bf654e01a198"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fad62ed7-163d-4c37-89d0-c6c5dd2a6a9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fbbcb1ef-b899-44df-9915-3e432afaca69"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("34e81c13-87f0-47cd-a4de-dc4729e43bdf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("69a2b4f1-1c69-4821-8e82-96b251ae05c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8cd40563-1131-43d0-84c6-328020cedc57"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b0138031-cd5d-40e0-af1a-aa73f60e3db9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostArticleCategory",
                keyColumns: new[] { "ArticleCategoryId", "BlogPostId" },
                keyValues: new object[] { new Guid("a7e46ec3-bc6a-4ad8-ae1d-3dc709ec99cd"), new Guid("9cda41c5-df55-4891-a4d3-87ba683dac5e") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostComments",
                keyColumn: "BlogPostCommentId",
                keyValue: new Guid("950e92ca-7c3c-46e3-bc04-4ec82888a54c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostImages",
                keyColumn: "BlogPostImageId",
                keyValue: new Guid("3ad3336f-eb66-4f4c-8542-adaeb0d7ecc6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("044ef15d-8dc1-46d2-ae4b-3955aa39ca8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("26f881f7-e2d0-47d3-9b37-0cc09143b895"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("288a7279-a432-47c6-bb97-e159ebaf894d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4068aa9f-d338-4f7f-9a2a-ccd5c22f6a16"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("42650e93-0004-4c57-81ef-da04f602a9b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5913c8c9-9072-45f0-9f7f-a217247e7f70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("63770490-07ec-4da1-aca4-5d645c6de6fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("645d1825-5929-4138-bbdc-71b633469c1b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7fd82208-135e-460d-897d-7babc166af0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8889878e-a9be-46f4-bb72-af01ed7fe1ad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9ab1a73d-be6d-4889-955e-964356af1be7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9d5ae481-ce2c-436e-8fd6-cbed8697d4ad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a1900184-76ee-4393-81ba-b36bd02f7c9e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a2384588-207e-4cee-9aec-762a6b53876c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("aed4cfda-07c7-427c-b805-e7d7940d4e72"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d3e296dd-42b4-46bf-8af9-74ff989fefd6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("dfca9eb8-e016-4dd1-ad85-a172fed76c6a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f0a44265-0cf3-4149-b173-6c07b3939cf0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f50fab3a-6a56-44cc-8787-838e29c828e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("da77a34a-d89f-4e07-acc2-34449b48e4db"), new Guid("3c24a01f-29cc-4df5-8ab2-fc37a2279f82") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ffe6a612-e0c6-43a2-9cec-2b252c73e0ed"), new Guid("6c544500-c16b-4387-9afd-2af3c9494713") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a7e46ec3-bc6a-4ad8-ae1d-3dc709ec99cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("da77a34a-d89f-4e07-acc2-34449b48e4db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffe6a612-e0c6-43a2-9cec-2b252c73e0ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("9cda41c5-df55-4891-a4d3-87ba683dac5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c24a01f-29cc-4df5-8ab2-fc37a2279f82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c544500-c16b-4387-9afd-2af3c9494713"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(4731),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 805, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 806, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 807, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 659, DateTimeKind.Local).AddTicks(835),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 807, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(8599),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 794, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(7938),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 795, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 647, DateTimeKind.Local).AddTicks(746),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 795, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 805, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 805, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(5751),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 804, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(960),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 794, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "dbo",
                columns: table => new
                {
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(1385)),
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("05b782bf-df55-4792-88cc-e55df5b5fa3a"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3011), true, "Safety and Compliance" },
                    { new Guid("0efd2d0f-0458-437e-b192-0aa1aee2ab12"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2976), true, "Green Building Materials" },
                    { new Guid("1411d0a8-2473-40f2-bfe1-022b202876ef"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2979), true, "Health and Wellness in Construction" },
                    { new Guid("1975fe3a-d0dd-422a-bbf6-879ff950ba43"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2992), true, "Innovation Awards and Recognitions" },
                    { new Guid("22a5398f-9650-4c1f-af1a-88c9511d013b"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2933), true, "Client Resources" },
                    { new Guid("2b00abda-6fda-4166-a038-4bdd8e00acd3"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3007), true, "Real Estate Development" },
                    { new Guid("2f510cf0-e175-4ba3-a53e-9f958c03f16f"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2967), true, "Energy Efficiency" },
                    { new Guid("3b2b7e69-9ea6-472b-bd66-f9b93b8dea1d"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2930), true, "Client Education" },
                    { new Guid("3d64f0fb-6657-4a32-b501-ccadf528a78c"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2950), true, "Construction Finance" },
                    { new Guid("53dbe102-bdb1-4024-8b83-9b2c26c90070"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2905), true, "Case Studies and Success Stories" },
                    { new Guid("5972116f-bf54-46ea-8cb7-fee628cea5ac"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2981), true, "Historic Preservation" },
                    { new Guid("63e0222d-d771-441f-b147-a7fb202e4e4b"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2939), true, "Construction Careers" },
                    { new Guid("65111d8b-631c-443f-aa4c-0fa5c2334a68"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3005), true, "Property Management" },
                    { new Guid("6a11dc13-9d00-4d67-bd5a-8b8cdfdf9a1f"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3020), true, "Technology in Construction" },
                    { new Guid("71f732e0-e304-44e2-82a6-8a26162fa005"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3003), true, "Project Showcase" },
                    { new Guid("75ca83d6-e88b-4fae-b516-12cda64974af"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3018), true, "Sustainability and Green Building" },
                    { new Guid("7938a1b5-faff-41fd-8594-6f415dff7411"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3016), true, "Supply Chain and Logistics" },
                    { new Guid("84906515-88c6-4e6c-88fd-3bb25978525e"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2892), true, "Building Codes and Standards" },
                    { new Guid("8bbb5c04-38c8-477c-a26c-b672745e7bbc"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2958), true, "Cost Estimation and Budgeting" },
                    { new Guid("939d156b-e159-4e0a-9a5b-c39bee901a23"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2985), true, "Industry News" },
                    { new Guid("95f8290b-f8b0-43ee-a47d-ace43fb13121"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3070), true, "Weather and Seasonal Tips" },
                    { new Guid("986e836c-7047-464a-bf46-aad6b86e2522"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3023), true, "Training and Certification" },
                    { new Guid("9993b5a0-db3d-4254-a7de-04486aa79c91"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2953), true, "Construction Management" },
                    { new Guid("a9e1357e-dda8-4067-99b2-0a102387cf3f"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2960), true, "Customer Stories and Interviews" },
                    { new Guid("ad34f807-8e0b-4205-9346-a5a4cf708ea4"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2994), true, "Landscaping and Outdoor Design" },
                    { new Guid("ae1a07df-d353-4c52-874d-7b44f50944b4"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2996), true, "Legal and Insurance" },
                    { new Guid("af10cf9a-6071-4549-b0d3-bf6db42269e8"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3001), true, "Modular and Prefabricated Construction" },
                    { new Guid("af1c1635-b21a-4b74-a626-ad5b340e7007"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2972), true, "Environmental Impact" },
                    { new Guid("b4fb6524-bb51-4cf8-a0f5-8910f794ea23"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3014), true, "Smart Home Technology" },
                    { new Guid("b97ef451-3904-4a94-8016-4285572f478e"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2935), true, "Community and Culture" },
                    { new Guid("bfb84784-f956-43ca-8371-cfbeaa0c61bb"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2937), true, "Company Updates" },
                    { new Guid("d693d460-cbff-4c76-ba91-457d6c049384"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2974), true, "Equipment Maintenance" },
                    { new Guid("dbadb563-9a67-401b-bb03-de24ef4f9c8f"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2983), true, "Home Improvement and DIY" },
                    { new Guid("e51bc113-6d6d-4da2-9e44-2fba4e87022e"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2987), true, "Innovation and Future Trends" },
                    { new Guid("e74ada16-1d92-44a4-b330-f548c8de6b0b"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2962), true, "Design and Architecture" },
                    { new Guid("e9646197-ca29-450d-8abd-d546c86def66"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2965), true, "Disaster Preparedness and Recovery" },
                    { new Guid("ed969e04-8415-4f69-acb5-b9c25962d2df"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(1703), true, "Accessibility in Construction" },
                    { new Guid("ee82816e-9b3a-42db-86a5-caaa0aac9417"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2998), true, "Materials and Equipment" },
                    { new Guid("f09440e6-9836-4183-bb3d-74b689aaecdb"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(2956), true, "Construction Techniques" },
                    { new Guid("f1cde9ac-5a05-46db-9315-d3f69b3d4a8c"), new DateTime(2024, 6, 10, 16, 33, 12, 231, DateTimeKind.Utc).AddTicks(3068), true, "Urban Planning and Development" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("38c7c8ad-fa7e-486a-9634-91d0cd00c0da"), null, "Editor", "EDITOR" },
                    { new Guid("6934b69f-3190-4935-acca-ede71274855c"), null, "Admin", "ADMIN" },
                    { new Guid("6fdf29c9-96f5-4d79-904b-7c720de64604"), null, "Manager", "MANAGER" },
                    { new Guid("b1873bb5-e782-4132-ab05-daf7a10595da"), null, "Visitor", "VISITOR" },
                    { new Guid("c9811cb8-7e93-41c4-869f-9152c412045d"), null, "Client", "CLIENT" },
                    { new Guid("f5dc7a46-288e-43ae-913e-43a99a03ebba"), null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("f251bc4c-218d-4446-b284-5c4c3ba4158c"), "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "sustainable-solutions.md", new DateTime(2024, 6, 10, 16, 33, 13, 817, DateTimeKind.Utc).AddTicks(1772), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading the way in sustainable construction, minimizing environmental impact for a brighter future.", "[]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedBlogPostId" },
                values: new object[,]
                {
                    { new Guid("22314aaf-9b8f-40a4-ad6c-0ea6b37d0a56"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3675), true, true, "How do you handle project timelines?", null },
                    { new Guid("2243ec15-98c8-4bc8-be23-ff751dc2fc04"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3706), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("2d6d14c9-4cae-4a1c-b941-2b395707ad97"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3715), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("2dd0fcb6-fc43-4d41-9eb9-0025474ed741"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3687), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("3087c66e-2df2-4dd1-aa54-6c5e7db6dddd"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3678), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("34676370-898f-4a80-8f56-6a308ad6d8ce"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3711), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("39a407a9-b1b4-4df7-b203-324f1dff9443"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3698), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("536012c5-bd44-4fd9-bed5-98394086ae81"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3652), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("618920af-3bee-4f80-98a6-7a9db57b545b"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3679), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("628a76a0-80fb-460c-97d9-64d8886ccb50"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3674), true, null, "How can I get a quote for my project?", null },
                    { new Guid("6731cc87-4c3a-4694-969b-4d47bdd84337"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3696), true, null, "How do I pay for my project?", null },
                    { new Guid("6b59ee45-76a3-442d-ad87-d466095a026b"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3685), true, null, "Do you offer financing options?", null },
                    { new Guid("6fc2cb37-dd25-4d0b-94b0-eeb80d2b869d"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3709), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("7483a74c-5d94-4bff-91e2-946b8ced758f"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3656), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("ad43785e-2efa-4d9c-8f85-d0231fa3ad55"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3708), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("c9d6d35e-1acf-4497-9936-15fc12b3a136"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3704), true, true, "Are you licensed and insured?", null },
                    { new Guid("d5fcb206-513c-4600-bf5e-7a4ff7510ebb"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3681), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("eb7621dc-209d-4ad0-b865-2a26f14e3b00"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3700), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("fe230253-50c7-420a-bcfb-4eb02baef113"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3683), true, null, "How do you determine the cost of a construction project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("22ac835f-ca6c-4a6f-abfc-04270d808c33"), null, null, new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3458), "James", 0, new Guid("bb9a88ac-262e-486f-8286-e0595d9e9965"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("33712e33-6b11-4e2d-983e-664ce3626a97"), null, null, new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3500), "Charles", 0, new Guid("9e5c3c34-da64-475b-b587-305c1a79b994"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9e5c3c34-da64-475b-b587-305c1a79b994"), 0, "6dbcabbf-903b-4274-946f-c220fa4b66bd", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEKuGEUou8xtg0lQ1tBaj4bKvtyCvfWzBxCz6CFBAK8c7x9r39pNCSdu0aTtCZOlcWQ==", "+639951225449", false, "d04df2dc-0572-7b5d-a001-b6ec5e6d4f3d_20240610163313659", false, "ladonconst@gmail.com" },
                    { new Guid("bb9a88ac-262e-486f-8286-e0595d9e9965"), 0, "4524f6bb-24be-401e-b81c-715cc8d42488", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKZn/pLGVp+9eBJ1acVPAS7saAM8pfhBYd88YoBGC3MP2Qd4SYRXlANkx/fFVhe5nA==", "+639672814641", false, "d04df2dc-0572-7b5d-a001-b6ec5e6d4f3d_20240610163313659", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("6d8e261b-0d8b-47a1-b7e6-628b88dc5b4b"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3602), true, "8000", "Davao del Sur", new Guid("22ac835f-ca6c-4a6f-abfc-04270d808c33") },
                    { new Guid("c94ef1c6-2dbe-4102-ad61-f423a2f502ab"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 16, 33, 13, 816, DateTimeKind.Utc).AddTicks(3608), true, "8000", "Davao del Sur", new Guid("33712e33-6b11-4e2d-983e-664ce3626a97") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostArticleCategory",
                columns: new[] { "ArticleCategoryId", "BlogPostId" },
                values: new object[] { new Guid("75ca83d6-e88b-4fae-b516-12cda64974af"), new Guid("f251bc4c-218d-4446-b284-5c4c3ba4158c") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostComments",
                columns: new[] { "BlogPostCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("a712a160-b4ce-4d1b-8929-b98674ff0e15"), "John Doe", new Guid("f251bc4c-218d-4446-b284-5c4c3ba4158c"), "This is a fantastic article!", new DateTime(2024, 6, 10, 16, 33, 13, 817, DateTimeKind.Utc).AddTicks(2061), "commenter@gmail.com", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostImages",
                columns: new[] { "BlogPostImageId", "BlogPostId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[] { new Guid("b1af4d35-8a99-4ed2-9d99-50adfa2f48ee"), new Guid("f251bc4c-218d-4446-b284-5c4c3ba4158c"), new DateTime(2024, 6, 10, 16, 33, 13, 817, DateTimeKind.Utc).AddTicks(2069), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6fdf29c9-96f5-4d79-904b-7c720de64604"), new Guid("9e5c3c34-da64-475b-b587-305c1a79b994") },
                    { new Guid("6934b69f-3190-4935-acca-ede71274855c"), new Guid("bb9a88ac-262e-486f-8286-e0595d9e9965") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_FirstName_LastName",
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserProfiles_UserProfileId",
                schema: "dbo",
                table: "Addresses",
                column: "UserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfiles",
                principalColumn: "UserProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_UserProfiles_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogPosts",
                column: "AuthorUserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfiles",
                principalColumn: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientTestimonies_UserProfiles_UserProfileId",
                schema: "dbo",
                table: "ClientTestimonies",
                column: "UserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfiles",
                principalColumn: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_UserProfiles_UserProfileId",
                schema: "dbo",
                table: "Messages",
                column: "UserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfiles",
                principalColumn: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteRequests_UserProfiles_RequestorUserProfileId",
                schema: "dbo",
                table: "QuoteRequests",
                column: "RequestorUserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfiles",
                principalColumn: "UserProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserProfiles_UserProfileId",
                schema: "dbo",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_UserProfiles_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientTestimonies_UserProfiles_UserProfileId",
                schema: "dbo",
                table: "ClientTestimonies");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_UserProfiles_UserProfileId",
                schema: "dbo",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_QuoteRequests_UserProfiles_RequestorUserProfileId",
                schema: "dbo",
                table: "QuoteRequests");

            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("6d8e261b-0d8b-47a1-b7e6-628b88dc5b4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("c94ef1c6-2dbe-4102-ad61-f423a2f502ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("05b782bf-df55-4792-88cc-e55df5b5fa3a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0efd2d0f-0458-437e-b192-0aa1aee2ab12"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1411d0a8-2473-40f2-bfe1-022b202876ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1975fe3a-d0dd-422a-bbf6-879ff950ba43"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("22a5398f-9650-4c1f-af1a-88c9511d013b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2b00abda-6fda-4166-a038-4bdd8e00acd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2f510cf0-e175-4ba3-a53e-9f958c03f16f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3b2b7e69-9ea6-472b-bd66-f9b93b8dea1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3d64f0fb-6657-4a32-b501-ccadf528a78c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("53dbe102-bdb1-4024-8b83-9b2c26c90070"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5972116f-bf54-46ea-8cb7-fee628cea5ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("63e0222d-d771-441f-b147-a7fb202e4e4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("65111d8b-631c-443f-aa4c-0fa5c2334a68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6a11dc13-9d00-4d67-bd5a-8b8cdfdf9a1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("71f732e0-e304-44e2-82a6-8a26162fa005"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7938a1b5-faff-41fd-8594-6f415dff7411"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("84906515-88c6-4e6c-88fd-3bb25978525e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8bbb5c04-38c8-477c-a26c-b672745e7bbc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("939d156b-e159-4e0a-9a5b-c39bee901a23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("95f8290b-f8b0-43ee-a47d-ace43fb13121"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("986e836c-7047-464a-bf46-aad6b86e2522"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9993b5a0-db3d-4254-a7de-04486aa79c91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a9e1357e-dda8-4067-99b2-0a102387cf3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ad34f807-8e0b-4205-9346-a5a4cf708ea4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ae1a07df-d353-4c52-874d-7b44f50944b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("af10cf9a-6071-4549-b0d3-bf6db42269e8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("af1c1635-b21a-4b74-a626-ad5b340e7007"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b4fb6524-bb51-4cf8-a0f5-8910f794ea23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b97ef451-3904-4a94-8016-4285572f478e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("bfb84784-f956-43ca-8371-cfbeaa0c61bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d693d460-cbff-4c76-ba91-457d6c049384"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("dbadb563-9a67-401b-bb03-de24ef4f9c8f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e51bc113-6d6d-4da2-9e44-2fba4e87022e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e74ada16-1d92-44a4-b330-f548c8de6b0b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e9646197-ca29-450d-8abd-d546c86def66"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ed969e04-8415-4f69-acb5-b9c25962d2df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ee82816e-9b3a-42db-86a5-caaa0aac9417"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f09440e6-9836-4183-bb3d-74b689aaecdb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f1cde9ac-5a05-46db-9315-d3f69b3d4a8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("38c7c8ad-fa7e-486a-9634-91d0cd00c0da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b1873bb5-e782-4132-ab05-daf7a10595da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9811cb8-7e93-41c4-869f-9152c412045d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5dc7a46-288e-43ae-913e-43a99a03ebba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostArticleCategory",
                keyColumns: new[] { "ArticleCategoryId", "BlogPostId" },
                keyValues: new object[] { new Guid("75ca83d6-e88b-4fae-b516-12cda64974af"), new Guid("f251bc4c-218d-4446-b284-5c4c3ba4158c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostComments",
                keyColumn: "BlogPostCommentId",
                keyValue: new Guid("a712a160-b4ce-4d1b-8929-b98674ff0e15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostImages",
                keyColumn: "BlogPostImageId",
                keyValue: new Guid("b1af4d35-8a99-4ed2-9d99-50adfa2f48ee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("22314aaf-9b8f-40a4-ad6c-0ea6b37d0a56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2243ec15-98c8-4bc8-be23-ff751dc2fc04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2d6d14c9-4cae-4a1c-b941-2b395707ad97"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2dd0fcb6-fc43-4d41-9eb9-0025474ed741"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3087c66e-2df2-4dd1-aa54-6c5e7db6dddd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("34676370-898f-4a80-8f56-6a308ad6d8ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("39a407a9-b1b4-4df7-b203-324f1dff9443"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("536012c5-bd44-4fd9-bed5-98394086ae81"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("618920af-3bee-4f80-98a6-7a9db57b545b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("628a76a0-80fb-460c-97d9-64d8886ccb50"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6731cc87-4c3a-4694-969b-4d47bdd84337"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6b59ee45-76a3-442d-ad87-d466095a026b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6fc2cb37-dd25-4d0b-94b0-eeb80d2b869d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7483a74c-5d94-4bff-91e2-946b8ced758f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("ad43785e-2efa-4d9c-8f85-d0231fa3ad55"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c9d6d35e-1acf-4497-9936-15fc12b3a136"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d5fcb206-513c-4600-bf5e-7a4ff7510ebb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("eb7621dc-209d-4ad0-b865-2a26f14e3b00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("fe230253-50c7-420a-bcfb-4eb02baef113"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6fdf29c9-96f5-4d79-904b-7c720de64604"), new Guid("9e5c3c34-da64-475b-b587-305c1a79b994") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6934b69f-3190-4935-acca-ede71274855c"), new Guid("bb9a88ac-262e-486f-8286-e0595d9e9965") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("75ca83d6-e88b-4fae-b516-12cda64974af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6934b69f-3190-4935-acca-ede71274855c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6fdf29c9-96f5-4d79-904b-7c720de64604"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("f251bc4c-218d-4446-b284-5c4c3ba4158c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e5c3c34-da64-475b-b587-305c1a79b994"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb9a88ac-262e-486f-8286-e0595d9e9965"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 805, DateTimeKind.Local).AddTicks(8672),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 806, DateTimeKind.Local).AddTicks(7857),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 807, DateTimeKind.Local).AddTicks(2176),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 807, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 659, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 794, DateTimeKind.Local).AddTicks(722),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 795, DateTimeKind.Local).AddTicks(61),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 795, DateTimeKind.Local).AddTicks(2856),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 647, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 805, DateTimeKind.Local).AddTicks(2544),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 805, DateTimeKind.Local).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 804, DateTimeKind.Local).AddTicks(9973),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 794, DateTimeKind.Local).AddTicks(3033),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.CreateTable(
                name: "UserProfileModels",
                schema: "dbo",
                columns: table => new
                {
                    UserProfileModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _dateCreated = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2024, 6, 11, 0, 12, 38, 793, DateTimeKind.Local).AddTicks(4027)),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    _dateModified = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    BusinessInstitutionName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ClientCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IdentityUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MobilePhoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfileModels", x => x.UserProfileModelId);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("0386e147-ebfa-4205-b6e2-33965eeaa564"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2033), true, "Supply Chain and Logistics" },
                    { new Guid("11a92ac0-1444-4288-ac98-ba6a24e5722f"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1954), true, "Disaster Preparedness and Recovery" },
                    { new Guid("273304ac-4a0d-40c4-9d55-606dab3aae44"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2042), true, "Urban Planning and Development" },
                    { new Guid("28580dff-bc42-44ae-a731-885a2223b7ca"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1957), true, "Energy Efficiency" },
                    { new Guid("2ab79803-c8c9-49e1-a1ce-c0889c57aa49"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1906), true, "Building Codes and Standards" },
                    { new Guid("2c47dc5c-e180-499f-a11e-434f62002d15"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(217), true, "Accessibility in Construction" },
                    { new Guid("2f432f1f-a747-4f09-a26c-251860d9b54c"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2019), true, "Project Showcase" },
                    { new Guid("3b483fe5-dc55-4642-830e-a42ecbf8b9a6"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2021), true, "Property Management" },
                    { new Guid("3f4a0910-3ba3-42f3-957c-66a4bfb29701"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2044), true, "Weather and Seasonal Tips" },
                    { new Guid("4613d0f8-31ed-46b5-8cea-ba51d07647ce"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1991), true, "Green Building Materials" },
                    { new Guid("477444c5-46dc-4deb-afda-df9871c48f8e"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2026), true, "Safety and Compliance" },
                    { new Guid("4a8b6fb6-faed-483a-9245-1ecf52a0c3e1"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1928), true, "Community and Culture" },
                    { new Guid("4fc9b97f-0c46-4505-8288-13b3897d1f14"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1998), true, "Home Improvement and DIY" },
                    { new Guid("5510868f-518a-4862-b4df-906157410b73"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1960), true, "Environmental Impact" },
                    { new Guid("589f171f-004c-4e50-95f1-7eca6e8d72f8"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1933), true, "Construction Careers" },
                    { new Guid("5908ae8b-92c9-42fa-a716-343830d7cd98"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1995), true, "Historic Preservation" },
                    { new Guid("5e7bb04c-f041-48cf-a4c8-f292f1e3a2ab"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2012), true, "Legal and Insurance" },
                    { new Guid("65075dc7-f9fe-491c-b8ba-b56927c50053"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1926), true, "Client Resources" },
                    { new Guid("6730bd81-12b9-4e34-933c-5adeaff1df8e"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1993), true, "Health and Wellness in Construction" },
                    { new Guid("6d0a3393-4162-4099-91cc-b45abbf48156"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2039), true, "Training and Certification" },
                    { new Guid("6f2d6adc-0862-4b6d-9277-90daaaf5b27b"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2000), true, "Industry News" },
                    { new Guid("7a6dcba2-fae8-419d-9dd8-d7c2de0941de"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2002), true, "Innovation and Future Trends" },
                    { new Guid("7b09a973-8733-478e-8e39-aa2f6b76d783"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1935), true, "Construction Finance" },
                    { new Guid("8a3503e8-73e1-48b0-852c-9d1686ffc286"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1948), true, "Cost Estimation and Budgeting" },
                    { new Guid("90afd159-f02c-4fb8-ad09-f7adb0593a73"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1950), true, "Customer Stories and Interviews" },
                    { new Guid("9f58dad8-9553-4eaf-a2b6-bb68cc9f7a1f"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2009), true, "Landscaping and Outdoor Design" },
                    { new Guid("a20a7ce3-0414-4d9a-ac77-e5f0f818b4d8"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1922), true, "Case Studies and Success Stories" },
                    { new Guid("a2cc2636-ee0b-477d-8c97-7e37503d5711"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2014), true, "Materials and Equipment" },
                    { new Guid("a7e46ec3-bc6a-4ad8-ae1d-3dc709ec99cd"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2035), true, "Sustainability and Green Building" },
                    { new Guid("a9b89609-d2cf-4b26-9e0d-69c4960cb76d"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1988), true, "Equipment Maintenance" },
                    { new Guid("abaa91e5-6c21-4d89-97af-fb390951c89c"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1943), true, "Construction Management" },
                    { new Guid("b3a9efa9-e706-4bb0-ab87-38aa1b235857"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2023), true, "Real Estate Development" },
                    { new Guid("b9234713-495b-4b15-ac93-42505da58783"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1931), true, "Company Updates" },
                    { new Guid("befcd7c0-716e-4acf-9b63-20d9cf8110e5"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2005), true, "Innovation Awards and Recognitions" },
                    { new Guid("c74febad-1633-4732-9713-b404ed2926f9"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1924), true, "Client Education" },
                    { new Guid("cbd822de-dade-4243-834d-386d6a0a7b88"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2030), true, "Smart Home Technology" },
                    { new Guid("e47dce1f-5898-4ebc-bea7-4888bcad6dcb"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1952), true, "Design and Architecture" },
                    { new Guid("f6eb5ada-e4a0-4cc4-9986-bf654e01a198"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(1945), true, "Construction Techniques" },
                    { new Guid("fad62ed7-163d-4c37-89d0-c6c5dd2a6a9b"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2037), true, "Technology in Construction" },
                    { new Guid("fbbcb1ef-b899-44df-9915-3e432afaca69"), new DateTime(2024, 6, 10, 16, 12, 37, 565, DateTimeKind.Utc).AddTicks(2016), true, "Modular and Prefabricated Construction" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("34e81c13-87f0-47cd-a4de-dc4729e43bdf"), null, "Client", "CLIENT" },
                    { new Guid("69a2b4f1-1c69-4821-8e82-96b251ae05c9"), null, "Editor", "EDITOR" },
                    { new Guid("8cd40563-1131-43d0-84c6-328020cedc57"), null, "Moderator", "MODERATOR" },
                    { new Guid("b0138031-cd5d-40e0-af1a-aa73f60e3db9"), null, "Visitor", "VISITOR" },
                    { new Guid("da77a34a-d89f-4e07-acc2-34449b48e4db"), null, "Manager", "MANAGER" },
                    { new Guid("ffe6a612-e0c6-43a2-9cec-2b252c73e0ed"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[] { new Guid("9cda41c5-df55-4891-a4d3-87ba683dac5e"), "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "sustainable-solutions.md", new DateTime(2024, 6, 10, 16, 12, 38, 954, DateTimeKind.Utc).AddTicks(526), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading the way in sustainable construction, minimizing environmental impact for a brighter future.", "[]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedBlogPostId" },
                values: new object[,]
                {
                    { new Guid("044ef15d-8dc1-46d2-ae4b-3955aa39ca8b"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2829), true, true, "Are you licensed and insured?", null },
                    { new Guid("26f881f7-e2d0-47d3-9b37-0cc09143b895"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2903), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("288a7279-a432-47c6-bb97-e159ebaf894d"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2802), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("4068aa9f-d338-4f7f-9a2a-ccd5c22f6a16"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2791), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("42650e93-0004-4c57-81ef-da04f602a9b3"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2831), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("5913c8c9-9072-45f0-9f7f-a217247e7f70"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2812), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("63770490-07ec-4da1-aca4-5d645c6de6fd"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2823), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("645d1825-5929-4138-bbdc-71b633469c1b"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2798), true, null, "How can I get a quote for my project?", null },
                    { new Guid("7fd82208-135e-460d-897d-7babc166af0d"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2804), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("8889878e-a9be-46f4-bb72-af01ed7fe1ad"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2796), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("9ab1a73d-be6d-4889-955e-964356af1be7"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2836), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("9d5ae481-ce2c-436e-8fd6-cbed8697d4ad"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2821), true, null, "How do I pay for my project?", null },
                    { new Guid("a1900184-76ee-4393-81ba-b36bd02f7c9e"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2825), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("a2384588-207e-4cee-9aec-762a6b53876c"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2816), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("aed4cfda-07c7-427c-b805-e7d7940d4e72"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2901), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("d3e296dd-42b4-46bf-8af9-74ff989fefd6"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2838), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("dfca9eb8-e016-4dd1-ad85-a172fed76c6a"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2814), true, null, "Do you offer financing options?", null },
                    { new Guid("f0a44265-0cf3-4149-b173-6c07b3939cf0"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2800), true, true, "How do you handle project timelines?", null },
                    { new Guid("f50fab3a-6a56-44cc-8787-838e29c828e1"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2807), true, true, "Do you provide a warranty for your work?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfileModels",
                columns: new[] { "UserProfileModelId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("5541787c-61c6-48e5-8da8-a45defa1a0b7"), null, null, new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2633), "Charles", 0, new Guid("3c24a01f-29cc-4df5-8ab2-fc37a2279f82"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("b87dff82-11c4-44c1-a579-bb4523189620"), null, null, new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2592), "James", 0, new Guid("6c544500-c16b-4387-9afd-2af3c9494713"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3c24a01f-29cc-4df5-8ab2-fc37a2279f82"), 0, "69140ea6-1c2e-4f10-8ed9-a428625af099", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEN4VSbQ+K56dqm4GMxzsnB/Ftqi9VESUOg76gi73oD2IwVZY9VapnWCgOlrD176WHw==", "+639951225449", false, "d8eb3a55-8d1a-98a9-bf77-3412916e4b6d_20240610161238807", false, "ladonconst@gmail.com" },
                    { new Guid("6c544500-c16b-4387-9afd-2af3c9494713"), 0, "85e79cc8-0f18-4844-86fc-4a18d6fb99c0", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAENMzZGZFnjKA8pHgShPyqhh51JbA6I/i8dzavsGmixKeZXbgHqkcDDN+3ynvhNcDAw==", "+639672814641", false, "d8eb3a55-8d1a-98a9-bf77-3412916e4b6d_20240610161238807", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("147f43f3-9813-4ee1-82bb-f09e8a7b85f5"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2735), true, "8000", "Davao del Sur", new Guid("b87dff82-11c4-44c1-a579-bb4523189620") },
                    { new Guid("5a76559b-9007-4bf4-9cc0-03b2834d9bb4"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 10, 16, 12, 38, 953, DateTimeKind.Utc).AddTicks(2751), true, "8000", "Davao del Sur", new Guid("5541787c-61c6-48e5-8da8-a45defa1a0b7") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostArticleCategory",
                columns: new[] { "ArticleCategoryId", "BlogPostId" },
                values: new object[] { new Guid("a7e46ec3-bc6a-4ad8-ae1d-3dc709ec99cd"), new Guid("9cda41c5-df55-4891-a4d3-87ba683dac5e") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostComments",
                columns: new[] { "BlogPostCommentId", "AuthorName", "BlogPostId", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[] { new Guid("950e92ca-7c3c-46e3-bc04-4ec82888a54c"), "John Doe", new Guid("9cda41c5-df55-4891-a4d3-87ba683dac5e"), "This is a fantastic article!", new DateTime(2024, 6, 10, 16, 12, 38, 954, DateTimeKind.Utc).AddTicks(789), "commenter@gmail.com", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BlogPostImages",
                columns: new[] { "BlogPostImageId", "BlogPostId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[] { new Guid("3ad3336f-eb66-4f4c-8542-adaeb0d7ecc6"), new Guid("9cda41c5-df55-4891-a4d3-87ba683dac5e"), new DateTime(2024, 6, 10, 16, 12, 38, 954, DateTimeKind.Utc).AddTicks(796), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("da77a34a-d89f-4e07-acc2-34449b48e4db"), new Guid("3c24a01f-29cc-4df5-8ab2-fc37a2279f82") },
                    { new Guid("ffe6a612-e0c6-43a2-9cec-2b252c73e0ed"), new Guid("6c544500-c16b-4387-9afd-2af3c9494713") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserProfileModels_UserProfileId",
                schema: "dbo",
                table: "Addresses",
                column: "UserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfileModels",
                principalColumn: "UserProfileModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_UserProfileModels_AuthorUserProfileId",
                schema: "dbo",
                table: "BlogPosts",
                column: "AuthorUserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfileModels",
                principalColumn: "UserProfileModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientTestimonies_UserProfileModels_UserProfileId",
                schema: "dbo",
                table: "ClientTestimonies",
                column: "UserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfileModels",
                principalColumn: "UserProfileModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_UserProfileModels_UserProfileId",
                schema: "dbo",
                table: "Messages",
                column: "UserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfileModels",
                principalColumn: "UserProfileModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteRequests_UserProfileModels_RequestorUserProfileId",
                schema: "dbo",
                table: "QuoteRequests",
                column: "RequestorUserProfileId",
                principalSchema: "dbo",
                principalTable: "UserProfileModels",
                principalColumn: "UserProfileModelId");
        }
    }
}
