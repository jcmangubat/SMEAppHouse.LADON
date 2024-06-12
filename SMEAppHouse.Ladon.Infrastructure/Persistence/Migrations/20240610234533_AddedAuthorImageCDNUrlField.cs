using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuthorImageCDNUrlField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("22ac835f-ca6c-4a6f-abfc-04270d808c33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("33712e33-6b11-4e2d-983e-664ce3626a97"));

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
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 385, DateTimeKind.Local).AddTicks(1303),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 398, DateTimeKind.Local).AddTicks(1397),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(739),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(5010),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(7333),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 659, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(3899),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(8898),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 647, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.AddColumn<string>(
                name: "AuthorAvatarImageCDNUrl",
                schema: "dbo",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(5446),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(7767),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(8453),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(960));

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
                table: "BlogPostArticleCategory",
                columns: new[] { "ArticleCategoryId", "BlogPostId" },
                values: new object[] { new Guid("b2ce5c80-09dd-4743-b9a7-95c8746c2346"), new Guid("b83f4030-ecac-45b6-807b-a86b3112b9e8") });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "BlogPostArticleCategory",
                keyColumns: new[] { "ArticleCategoryId", "BlogPostId" },
                keyValues: new object[] { new Guid("b2ce5c80-09dd-4743-b9a7-95c8746c2346"), new Guid("b83f4030-ecac-45b6-807b-a86b3112b9e8") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostComments",
                keyColumn: "BlogPostCommentId",
                keyValue: new Guid("8ee134d0-3551-43e0-80c7-9025bcfc4b6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "BlogPostImages",
                keyColumn: "BlogPostImageId",
                keyValue: new Guid("f710053a-afd8-4d9b-a3e5-71e0aaca5cdd"));

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
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b2ce5c80-09dd-4743-b9a7-95c8746c2346"));

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
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("b83f4030-ecac-45b6-807b-a86b3112b9e8"));

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

            migrationBuilder.DropColumn(
                name: "AuthorAvatarImageCDNUrl",
                schema: "dbo",
                table: "BlogPosts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(1385),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 385, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(4731),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 398, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 658, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 659, DateTimeKind.Local).AddTicks(835),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 399, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 645, DateTimeKind.Local).AddTicks(8599),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(7938),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPosts",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 647, DateTimeKind.Local).AddTicks(746),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 387, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "BlogPostComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 657, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 656, DateTimeKind.Local).AddTicks(5751),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 397, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 11, 0, 33, 13, 646, DateTimeKind.Local).AddTicks(960),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 11, 7, 45, 32, 386, DateTimeKind.Local).AddTicks(8453));

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
        }
    }
}
