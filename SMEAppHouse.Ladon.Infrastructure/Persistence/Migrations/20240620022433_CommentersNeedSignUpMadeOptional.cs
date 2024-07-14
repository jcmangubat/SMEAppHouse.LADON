using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CommentersNeedSignUpMadeOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("d05e6b64-de1d-46a9-81b0-6391ea085d9c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e53353aa-b052-4737-834f-5b467c1ccb0c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0133029c-151c-43ad-bbad-6c9f1d912d8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("176b7f42-bc47-44d2-95bc-d89f275b84fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2354c777-0d4a-463a-bad8-ccb4f89b3d11"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("24e2e1dd-6771-4dfa-b0b3-78d447f7b980"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("27dd1522-3495-4f32-8073-333c8880b56e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2ef71811-03a6-4224-a8ef-722a18f7bc5b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("32bf5e5d-abd1-4920-8d9c-dca25b7eceeb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("34c23b12-e55a-401c-b5a9-13c01855c685"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("395e8144-79c2-4da1-871b-087a97c3736d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4161e22b-359e-4438-9a0f-e9bd8f62c4fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("466f0b6a-097c-4272-8bc0-09f9c9357148"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4988b801-0de5-492f-acfa-59b0959c014d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("50fcf487-4d60-4ff1-b58b-7e35522139f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("57a3b949-9c5a-4268-8b4d-67c3b18e5048"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5ffad37b-d9d7-4348-be37-4398f5e2ecce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("658ec5ee-ddf8-41ed-afb5-b4d6f2a6c99a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("661441b6-4361-4ca4-9d4b-71f2f2ac3615"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6700183e-e204-49d8-8f1a-d5d23118781c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("671558f9-358d-4dd8-829a-7c501bd11b20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("71eed4b6-8a64-496d-a37c-72899c13a11c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("734a32a1-0381-4b75-8a13-1c66585d5a3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("806a4bb5-52b6-4ee0-8e3e-f0f94bcd219d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("846cb57a-2286-46a9-9b98-95c851de8830"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("853d3d3f-0bb9-425a-bb31-d9939d6fe105"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8efc9715-90fd-4e0c-9081-1a25acccded7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9750c967-87ee-4ef8-9484-602141b3d4f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9e030790-4371-4543-ad3e-345d2bb0fe70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a6270969-ce2a-471e-888e-a3eec218ffc9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a7b5e5d9-59b1-47a7-b86a-1d48a2dc9ba1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("aed36297-f774-46d4-ad29-2653886d88cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c017f9f1-0d61-4c07-8e59-df8b29fe5d7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cc224776-9ff0-45a6-90de-d060bee219c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f5b8eaf2-c27b-4cdf-9d4e-d8e6992ac35b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("3067df56-940a-4e73-a26b-32c551556ed3"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("e0351a3a-63ca-48fa-8e93-e3e83388592c"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("fdba2fdd-5833-4f12-8ad2-f09ce45ae61a"), new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("27d85071-1a1b-4587-a284-7fc20d67470a"), new Guid("caf0c44e-37dd-4258-93de-8e33245a491b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new Guid("eabce088-581e-47f9-b034-5e248e723b70") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("eabce088-581e-47f9-b034-5e248e723b70") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("27d85071-1a1b-4587-a284-7fc20d67470a"), new Guid("ec196330-bbdf-4dbd-b249-88b37052dacf") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("09f1bf17-2b77-421c-9705-e85ce95042e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("243fc35d-2a0c-49e5-af7b-e62799e7ee26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("40ed2ae5-4be5-477c-ab70-f2a7eaac1cb2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("59947f91-3623-4a7d-bd3c-5fc41141161c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("5c626d51-1889-43f3-a909-696c4042e1a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("6c303614-f78d-47fb-9242-69f0cf05d329"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("6ef8ba6b-70af-459b-acbb-f371db2652bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("8248b105-7dcc-41e8-87b4-1ea19954db0f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("f8010314-3915-48cf-bea6-5c083fe907f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("0fa1d88e-3c4d-42c2-bb69-5cea61cfb314"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("1e6816ec-1d8d-4f8f-bc7c-19a68bf17ce0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("707d02b4-ef02-46fc-8a8e-3a4af1a30fa8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("a819e601-c103-4b57-a457-e07a4aaee127"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ae41f823-3b87-492c-be46-b1ac99ba755c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("b7e0d064-39aa-4d61-bdda-3e25a2c40c5f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("c9b8a92d-46fb-4139-95cb-be25f0eb5629"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("e606a5d8-2d68-457b-abe8-0f584578c4d9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("f59b94d4-819f-4088-98dc-bf0f811ac3b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("31f5fadf-7ccb-4824-81b7-1ecd750a0acf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("45e8586a-cb24-4bdf-befe-8114c52f6779"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("54fbb3e2-e4a5-4077-9005-541a9a520d8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8c0313ed-311b-4943-a6ba-d78d89879cdd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("65cd4351-47f0-456e-a86f-d15ee99e73cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("8475459d-b91e-4141-88d2-50ec6596c6fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("c937ff58-d94c-4860-bb7e-b0373edd3f49"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("ef4538c9-06bd-4d55-8692-a8bae1e2498b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("010a5584-5d98-4fef-a60f-e83a66708bbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0504a802-fff3-4df1-acf3-e259622afc8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("108cbe2d-7739-411d-9f67-2e22f9240b94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2847a973-8322-46a7-a0a3-cbdcbfa40588"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("31137083-6a75-4e0a-9ecd-3bc85477dccd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("417c9b92-ac07-44c2-8cb2-3f71a36ec8a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("45cfc6ac-484a-4721-8618-7610e47c9d19"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("471b6dc3-eba7-4ae5-9d1e-d9c2df62080c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("57a7c4de-d6f4-40ce-aff7-a447bbe675a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("65453a9a-7436-428e-93e5-e9f447f6be0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6d324988-543a-44ae-ac6f-aecb9e41af1a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("914345e4-f17b-4d27-b538-6432bdf35371"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("935501cd-e681-4495-8a15-160d896ab783"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("aad12e5a-1256-4223-bc4f-719b9030cd7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b0e98090-3bbb-4c39-b0dc-4d4f739432c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b3ac6ef2-1711-4132-9886-347a6c65e1a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d21c0ca6-61ef-40c4-b264-b05225f5fc68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("de500451-d66a-4432-b6d0-0a22518978b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e0f3bdc1-1473-4a2b-a091-bf8e9c1d92b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e5485302-7016-4550-821b-da95725b8cfe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("faaad391-b38f-4bad-89a2-170212028c18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("fcf94cc5-c415-4e9a-bd01-de97a23bb4df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("309d464c-44ae-4850-9792-5df9105d9d2d"), new Guid("96f4c92c-204d-4cd2-b94d-1508452f279a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fe190203-930c-4723-a8b9-22676fdc436c"), new Guid("e364b2b6-a915-43b7-98c9-be4e1e46907e") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("27d85071-1a1b-4587-a284-7fc20d67470a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3067df56-940a-4e73-a26b-32c551556ed3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e0351a3a-63ca-48fa-8e93-e3e83388592c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fdba2fdd-5833-4f12-8ad2-f09ce45ae61a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("8d8ec95a-eed2-478d-943b-81c3da9a249f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("b95c8379-4102-4d3c-b336-560e5b90a4b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("caf0c44e-37dd-4258-93de-8e33245a491b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("eabce088-581e-47f9-b034-5e248e723b70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("ec196330-bbdf-4dbd-b249-88b37052dacf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("309d464c-44ae-4850-9792-5df9105d9d2d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe190203-930c-4723-a8b9-22676fdc436c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("728bd4f0-ed70-4ecf-90ff-f3e6b9621ef8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("953da12f-0f3b-4398-9a54-b8c36a5aea72"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96f4c92c-204d-4cd2-b94d-1508452f279a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e364b2b6-a915-43b7-98c9-be4e1e46907e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 207, DateTimeKind.Local).AddTicks(8137),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 476, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 223, DateTimeKind.Local).AddTicks(1660),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 491, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 224, DateTimeKind.Local).AddTicks(981),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 492, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 224, DateTimeKind.Local).AddTicks(5993),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 492, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 224, DateTimeKind.Local).AddTicks(8502),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 493, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 208, DateTimeKind.Local).AddTicks(9495),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 477, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 210, DateTimeKind.Local).AddTicks(2931),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 478, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 210, DateTimeKind.Local).AddTicks(8943),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 478, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 222, DateTimeKind.Local).AddTicks(3762),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 490, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 221, DateTimeKind.Local).AddTicks(6390),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 490, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 221, DateTimeKind.Local).AddTicks(9300),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 490, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "ArticleComments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                schema: "dbo",
                table: "ArticleComments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 221, DateTimeKind.Local).AddTicks(3682),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 489, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 209, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 477, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("07e6cfe1-f8ad-4722-a6b3-5237b7e6ab26"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9447), true, "Construction Careers" },
                    { new Guid("0b976ebb-6a51-4cea-80f7-c5b0657d9702"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9391), true, "Accessibility in Construction" },
                    { new Guid("0db7fd2f-d1d6-4bbd-9319-c1f2bc63329e"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9462), true, "Disaster Preparedness and Recovery" },
                    { new Guid("16ccb523-e33a-4e4b-9882-8dd00cfe5340"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9456), true, "Cost Estimation and Budgeting" },
                    { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9439), true, "Company Updates" },
                    { new Guid("22a8ee6e-2d25-484b-b531-cb8a457bb3c6"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9508), true, "Project Showcase" },
                    { new Guid("338ce375-fb5b-4718-b81d-774aea1fbf46"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9453), true, "Construction Techniques" },
                    { new Guid("354c3564-b297-4c78-bad8-3c970c3f5596"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9504), true, "Materials and Equipment" },
                    { new Guid("375f94dc-cb22-4c40-940b-51c1adab8390"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9517), true, "Safety and Compliance" },
                    { new Guid("3b204905-13c4-49ec-abc0-be68aaf0a787"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9498), true, "Innovation Awards and Recognitions" },
                    { new Guid("44b1462c-07d6-4cd4-a943-9ca3119f04dc"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9515), true, "Real Estate Development" },
                    { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9492), true, "Industry News" },
                    { new Guid("468ecf28-7e9b-4c8e-b434-f484a50fa25a"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9496), true, "Innovation and Future Trends" },
                    { new Guid("4b92b63e-76d1-4985-9065-eeda17ceb89b"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9435), true, "Client Resources" },
                    { new Guid("4dbe31c3-63c1-426f-a766-d886820eccb8"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9451), true, "Construction Management" },
                    { new Guid("56014cef-e640-4334-b2df-2b6b06488418"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9502), true, "Legal and Insurance" },
                    { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9433), true, "Client Education" },
                    { new Guid("61d2b544-6a08-473e-a3c8-dd1a698e3a7b"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9469), true, "Environmental Impact" },
                    { new Guid("66bb5570-c7d3-43fe-b04d-d91285020c67"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9506), true, "Modular and Prefabricated Construction" },
                    { new Guid("693aeffa-4a41-4f64-ab76-3955110f063c"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9458), true, "Customer Stories and Interviews" },
                    { new Guid("6ea3e316-8bba-498e-950f-2e2e947e0708"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9449), true, "Construction Finance" },
                    { new Guid("7edd11a4-33e7-46dd-9169-22aa0a75351f"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9488), true, "Historic Preservation" },
                    { new Guid("8128ca16-b7c6-4a46-b1cf-2a967ff259df"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9486), true, "Health and Wellness in Construction" },
                    { new Guid("855fd393-63e2-495d-a40d-c8af7ab979cd"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9525), true, "Technology in Construction" },
                    { new Guid("8db84c81-c0eb-4f5b-b019-64c7e7948c23"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9528), true, "Training and Certification" },
                    { new Guid("9435a234-e553-45b2-9011-b5f7b0f7f474"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9510), true, "Property Management" },
                    { new Guid("9e44e6c2-dad1-485c-8e6d-3ad3cf4cb0ca"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9428), true, "Building Codes and Standards" },
                    { new Guid("a27c3ac1-b0ae-4ed8-a8b1-f7a22aa0ce44"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9473), true, "Green Building Materials" },
                    { new Guid("ab9a2ea7-8070-4bd2-bcf1-dc08f04b3b1a"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9490), true, "Home Improvement and DIY" },
                    { new Guid("bda63882-6ba2-466f-9dc2-8fe67faaef62"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9519), true, "Smart Home Technology" },
                    { new Guid("c2f4356b-8a9d-493d-968f-e071b828f2c8"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9521), true, "Supply Chain and Logistics" },
                    { new Guid("cccfa1d3-453a-46f0-b0c4-b6b24774320c"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9460), true, "Design and Architecture" },
                    { new Guid("d811ad8a-1139-42a2-81b7-7b458b7b8c70"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9431), true, "Case Studies and Success Stories" },
                    { new Guid("d8f2f7b1-8a0d-4f71-9ff8-da57d741b4f2"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9523), true, "Sustainability and Green Building" },
                    { new Guid("da28de81-bfe8-4e15-8dea-a0306a646fde"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9500), true, "Landscaping and Outdoor Design" },
                    { new Guid("dda02a12-c9e1-4426-8cc5-bca85cebc10d"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9467), true, "Energy Efficiency" },
                    { new Guid("df33b247-670c-4374-a05e-8ed7f7979710"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9437), true, "Community and Culture" },
                    { new Guid("e1ba9c69-d133-4c11-bf54-2a79ef7e3196"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9534), true, "Weather and Seasonal Tips" },
                    { new Guid("e8d690cb-ef83-4298-bf18-3427f8be9e5a"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9471), true, "Equipment Maintenance" },
                    { new Guid("f7e5194a-0078-4a5b-b40d-03cf3e61e55f"), new DateTime(2024, 6, 20, 2, 24, 32, 224, DateTimeKind.Utc).AddTicks(9530), true, "Urban Planning and Development" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(977), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("3cab2bf0-0ff7-42fc-bb5e-25d096983cb6"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1188), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("4dd5cbc8-9acd-4a84-92e6-d74932342545"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1131), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(761), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 20, 2, 24, 32, 424, DateTimeKind.Utc).AddTicks(9664), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1068), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(159), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("d9bb919a-3849-44da-ad14-4aebac4ae677"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(642), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("eab9d618-bfa6-42fd-a741-a1b48d502184"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(830), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0cce77ff-f321-4dd0-bdbc-a5a3b2a48c65"), null, "Admin", "ADMIN" },
                    { new Guid("61078ce6-420d-4aec-95fc-4c8d03ee9f03"), null, "Editor", "EDITOR" },
                    { new Guid("7cec19a8-eadf-4e5d-a607-75a68e7e4cb5"), null, "Manager", "MANAGER" },
                    { new Guid("a6d9eda9-2405-4e33-9886-0db0e7f324e1"), null, "Client", "CLIENT" },
                    { new Guid("d5a443a4-05f2-4e92-bb9b-b425291a4db2"), null, "Moderator", "MODERATOR" },
                    { new Guid("f851da25-74ec-4b65-9a79-89e73de6bb10"), null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("078e681d-3125-43ca-a945-500bbd04b8da"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1892), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("106c8a74-9cee-4870-9882-0e9422859336"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1899), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("82feafc3-7546-4fe9-a044-774256708388"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1896), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("ea00cbf6-49e2-4235-afda-3a57208ff840"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1879), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("06549512-9e7c-46e2-99aa-fa69bff17d59"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8729), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("0dde54c2-22af-49b5-adb3-1605322fc8cd"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8678), true, true, "Are you licensed and insured?", null },
                    { new Guid("1ba7a204-798a-41d9-a94d-81a1ae37b149"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8629), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("2dcd800f-b7fa-43da-a754-417622d2f43e"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8658), true, null, "How do I pay for my project?", null },
                    { new Guid("3a5e02c1-5119-4deb-9568-a185e7328448"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8599), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("4527e760-6249-4d48-8031-beac4cd59f1d"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8635), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("4d63d178-daa7-4bad-9600-174be1440e03"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8671), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("569ccfef-8407-4c6f-af97-40bfb5ca994c"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8618), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("5a3a7509-9817-4c60-bf40-51003b6ff1a0"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8606), true, null, "How can I get a quote for my project?", null },
                    { new Guid("5bf60920-8b43-44c6-890b-625b4a184330"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8723), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("5e045215-ac1d-46e0-acdb-ea86b54582f3"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8641), true, null, "Do you offer financing options?", null },
                    { new Guid("650446ac-113c-4ef6-8755-2243858f5df3"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8684), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("6ded3352-9f5a-49c1-ade0-6a541f946e78"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8705), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("705b04bd-a6d9-46c9-ac23-fa5a0fa243fc"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8623), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("9128a1ce-48a1-464b-92bd-6df3714be71e"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8664), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("9a949588-88a0-4800-b262-2f9d89c2d160"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8611), true, true, "How do you handle project timelines?", null },
                    { new Guid("a288ae5e-3547-4221-b864-05dc19eaaa84"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8651), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("a97be5c8-b3bf-4c74-b9f6-7692dc7d08e2"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8711), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("b69b09e9-6e3d-42cc-81e1-0d37abd00a8c"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8690), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("d506cb8d-4d9d-4a57-9cdb-76f01e8e7e24"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8717), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("efcdf163-7dc1-4454-bd3a-91e36967bbf3"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8574), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("f980c8d6-6cc1-4442-bc7b-6fb4208618f1"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8695), true, true, "Who will be my point of contact during the project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("2599fad1-abed-4344-b5e7-fc195eac1984"), null, null, new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8239), "Charles", 0, new Guid("8a3d1be3-56d6-40f6-9491-e0a903973c6a"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("c6fc8e98-5ba3-451e-8f2a-7bf6c236661d"), null, null, new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8194), "James", 0, new Guid("006183ec-792a-43ce-8b48-31b4b1e5a83f"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("006183ec-792a-43ce-8b48-31b4b1e5a83f"), 0, "427473d0-f09d-42aa-a5cd-68b93458ae0d", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEA64U2eUKRZvTtdGQk2q2023F5jGbBnHXbv9bw8yvty4RIhbkA27iZX7A7bd4Z0aOQ==", "+639672814641", false, "e122cd39-ec91-1189-5a97-ce156a05e2f8_20240620022432224", false, "jc.mangubat@hotmail.com" },
                    { new Guid("8a3d1be3-56d6-40f6-9491-e0a903973c6a"), 0, "b16fe971-da16-4893-815d-33b5f93efe10", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEF/bLqNtQMYE+bLBXwyqwzsNzyC5aZmT0rUiXniv/jvKO9N0TcP62YZJG70AnsTRAA==", "+639951225449", false, "e122cd39-ec91-1189-5a97-ce156a05e2f8_20240620022432224", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("8c4d52e3-2ef3-4874-a853-db2acd707952"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8474), true, "8000", "Davao del Sur", new Guid("2599fad1-abed-4344-b5e7-fc195eac1984") },
                    { new Guid("e6282b8b-58ee-4c13-8bf7-6d7615241c97"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 20, 2, 24, 32, 419, DateTimeKind.Utc).AddTicks(8461), true, "8000", "Davao del Sur", new Guid("c6fc8e98-5ba3-451e-8f2a-7bf6c236661d") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") },
                    { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") },
                    { new Guid("4dbe31c3-63c1-426f-a766-d886820eccb8"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") },
                    { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") },
                    { new Guid("d8f2f7b1-8a0d-4f71-9ff8-da57d741b4f2"), new Guid("3cab2bf0-0ff7-42fc-bb5e-25d096983cb6") },
                    { new Guid("d8f2f7b1-8a0d-4f71-9ff8-da57d741b4f2"), new Guid("4dd5cbc8-9acd-4a84-92e6-d74932342545") },
                    { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3") },
                    { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3") },
                    { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce") },
                    { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce") },
                    { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be") },
                    { new Guid("22a8ee6e-2d25-484b-b531-cb8a457bb3c6"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be") },
                    { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be") },
                    { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e") },
                    { new Guid("8db84c81-c0eb-4f5b-b019-64c7e7948c23"), new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[,]
                {
                    { new Guid("052c5c58-8d4a-4c5a-a9b6-deb92801b107"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1057), "commenter@gmail.com", true },
                    { new Guid("1f327b0f-6849-4189-9655-041313166f40"), new Guid("3cab2bf0-0ff7-42fc-bb5e-25d096983cb6"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1226), "commenter@gmail.com", true },
                    { new Guid("20af04a0-182c-432e-bf44-59e2138685c0"), new Guid("eab9d618-bfa6-42fd-a741-a1b48d502184"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(877), "commenter@gmail.com", true },
                    { new Guid("250a1167-391a-4a01-a314-bbc4a11dbcf7"), new Guid("d9bb919a-3849-44da-ad14-4aebac4ae677"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(733), "commenter@gmail.com", true },
                    { new Guid("27a7b475-b15c-4463-93b6-17ba55781c4d"), new Guid("4dd5cbc8-9acd-4a84-92e6-d74932342545"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1174), "commenter@gmail.com", true },
                    { new Guid("6d0f9dfa-04d7-4eaa-9b47-f1e0d5a45480"), new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(599), "commenter@gmail.com", true },
                    { new Guid("93d9bb3d-28b6-4b05-8423-08e6429f4d8a"), new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(130), "commenter@gmail.com", true },
                    { new Guid("a3b7a34e-1fe0-4d73-8a8a-ef4b8c1ba38a"), new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(818), "commenter@gmail.com", true },
                    { new Guid("c6128def-155e-4d01-814e-1738feec0d3d"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1121), "commenter@gmail.com", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("14b80332-0313-404b-8010-057a6d91c772"), new Guid("3cab2bf0-0ff7-42fc-bb5e-25d096983cb6"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1231), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("1f89a561-3ae9-4d30-93c9-9d17ac5e416a"), new Guid("eab9d618-bfa6-42fd-a741-a1b48d502184"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(881), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("2621b3fd-e69d-4702-8bce-ab17d0f57c15"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1124), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("57628f29-50b1-49f8-9255-8d609806fa77"), new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(629), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("66fd4bd1-dbf8-46d0-81e5-20bbbbafe0f7"), new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(145), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("ab5e53fd-c9ac-4547-bd03-d14607dcb56b"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1061), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("ce9a5239-9b91-4106-ae77-142d78286c5c"), new Guid("4dd5cbc8-9acd-4a84-92e6-d74932342545"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(1177), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("e94a28da-10b7-474f-9a1d-cc8eff25b3d6"), new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(823), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("f5e9dd8d-a74b-4aaf-a322-3e5581cd0fc4"), new Guid("d9bb919a-3849-44da-ad14-4aebac4ae677"), new DateTime(2024, 6, 20, 2, 24, 32, 425, DateTimeKind.Utc).AddTicks(754), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0cce77ff-f321-4dd0-bdbc-a5a3b2a48c65"), new Guid("006183ec-792a-43ce-8b48-31b4b1e5a83f") },
                    { new Guid("7cec19a8-eadf-4e5d-a607-75a68e7e4cb5"), new Guid("8a3d1be3-56d6-40f6-9491-e0a903973c6a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("8c4d52e3-2ef3-4874-a853-db2acd707952"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e6282b8b-58ee-4c13-8bf7-6d7615241c97"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("07e6cfe1-f8ad-4722-a6b3-5237b7e6ab26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0b976ebb-6a51-4cea-80f7-c5b0657d9702"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0db7fd2f-d1d6-4bbd-9319-c1f2bc63329e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("16ccb523-e33a-4e4b-9882-8dd00cfe5340"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("338ce375-fb5b-4718-b81d-774aea1fbf46"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("354c3564-b297-4c78-bad8-3c970c3f5596"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("375f94dc-cb22-4c40-940b-51c1adab8390"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3b204905-13c4-49ec-abc0-be68aaf0a787"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("44b1462c-07d6-4cd4-a943-9ca3119f04dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("468ecf28-7e9b-4c8e-b434-f484a50fa25a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4b92b63e-76d1-4985-9065-eeda17ceb89b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("56014cef-e640-4334-b2df-2b6b06488418"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("61d2b544-6a08-473e-a3c8-dd1a698e3a7b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("66bb5570-c7d3-43fe-b04d-d91285020c67"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("693aeffa-4a41-4f64-ab76-3955110f063c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6ea3e316-8bba-498e-950f-2e2e947e0708"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7edd11a4-33e7-46dd-9169-22aa0a75351f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8128ca16-b7c6-4a46-b1cf-2a967ff259df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("855fd393-63e2-495d-a40d-c8af7ab979cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9435a234-e553-45b2-9011-b5f7b0f7f474"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9e44e6c2-dad1-485c-8e6d-3ad3cf4cb0ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a27c3ac1-b0ae-4ed8-a8b1-f7a22aa0ce44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ab9a2ea7-8070-4bd2-bcf1-dc08f04b3b1a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("bda63882-6ba2-466f-9dc2-8fe67faaef62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c2f4356b-8a9d-493d-968f-e071b828f2c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cccfa1d3-453a-46f0-b0c4-b6b24774320c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d811ad8a-1139-42a2-81b7-7b458b7b8c70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("da28de81-bfe8-4e15-8dea-a0306a646fde"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("dda02a12-c9e1-4426-8cc5-bca85cebc10d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("df33b247-670c-4374-a05e-8ed7f7979710"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e1ba9c69-d133-4c11-bf54-2a79ef7e3196"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e8d690cb-ef83-4298-bf18-3427f8be9e5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f7e5194a-0078-4a5b-b40d-03cf3e61e55f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("4dbe31c3-63c1-426f-a766-d886820eccb8"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d8f2f7b1-8a0d-4f71-9ff8-da57d741b4f2"), new Guid("3cab2bf0-0ff7-42fc-bb5e-25d096983cb6") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d8f2f7b1-8a0d-4f71-9ff8-da57d741b4f2"), new Guid("4dd5cbc8-9acd-4a84-92e6-d74932342545") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("22a8ee6e-2d25-484b-b531-cb8a457bb3c6"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"), new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"), new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("8db84c81-c0eb-4f5b-b019-64c7e7948c23"), new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("052c5c58-8d4a-4c5a-a9b6-deb92801b107"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("1f327b0f-6849-4189-9655-041313166f40"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("20af04a0-182c-432e-bf44-59e2138685c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("250a1167-391a-4a01-a314-bbc4a11dbcf7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("27a7b475-b15c-4463-93b6-17ba55781c4d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("6d0f9dfa-04d7-4eaa-9b47-f1e0d5a45480"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("93d9bb3d-28b6-4b05-8423-08e6429f4d8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("a3b7a34e-1fe0-4d73-8a8a-ef4b8c1ba38a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("c6128def-155e-4d01-814e-1738feec0d3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("14b80332-0313-404b-8010-057a6d91c772"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("1f89a561-3ae9-4d30-93c9-9d17ac5e416a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("2621b3fd-e69d-4702-8bce-ab17d0f57c15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("57628f29-50b1-49f8-9255-8d609806fa77"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("66fd4bd1-dbf8-46d0-81e5-20bbbbafe0f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ab5e53fd-c9ac-4547-bd03-d14607dcb56b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ce9a5239-9b91-4106-ae77-142d78286c5c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("e94a28da-10b7-474f-9a1d-cc8eff25b3d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("f5e9dd8d-a74b-4aaf-a322-3e5581cd0fc4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("61078ce6-420d-4aec-95fc-4c8d03ee9f03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a6d9eda9-2405-4e33-9886-0db0e7f324e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d5a443a4-05f2-4e92-bb9b-b425291a4db2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f851da25-74ec-4b65-9a79-89e73de6bb10"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("078e681d-3125-43ca-a945-500bbd04b8da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("106c8a74-9cee-4870-9882-0e9422859336"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("82feafc3-7546-4fe9-a044-774256708388"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("ea00cbf6-49e2-4235-afda-3a57208ff840"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("06549512-9e7c-46e2-99aa-fa69bff17d59"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0dde54c2-22af-49b5-adb3-1605322fc8cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1ba7a204-798a-41d9-a94d-81a1ae37b149"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2dcd800f-b7fa-43da-a754-417622d2f43e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3a5e02c1-5119-4deb-9568-a185e7328448"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4527e760-6249-4d48-8031-beac4cd59f1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4d63d178-daa7-4bad-9600-174be1440e03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("569ccfef-8407-4c6f-af97-40bfb5ca994c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5a3a7509-9817-4c60-bf40-51003b6ff1a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5bf60920-8b43-44c6-890b-625b4a184330"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5e045215-ac1d-46e0-acdb-ea86b54582f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("650446ac-113c-4ef6-8755-2243858f5df3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6ded3352-9f5a-49c1-ade0-6a541f946e78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("705b04bd-a6d9-46c9-ac23-fa5a0fa243fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9128a1ce-48a1-464b-92bd-6df3714be71e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9a949588-88a0-4800-b262-2f9d89c2d160"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a288ae5e-3547-4221-b864-05dc19eaaa84"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a97be5c8-b3bf-4c74-b9f6-7692dc7d08e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b69b09e9-6e3d-42cc-81e1-0d37abd00a8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d506cb8d-4d9d-4a57-9cdb-76f01e8e7e24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("efcdf163-7dc1-4454-bd3a-91e36967bbf3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f980c8d6-6cc1-4442-bc7b-6fb4208618f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0cce77ff-f321-4dd0-bdbc-a5a3b2a48c65"), new Guid("006183ec-792a-43ce-8b48-31b4b1e5a83f") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7cec19a8-eadf-4e5d-a607-75a68e7e4cb5"), new Guid("8a3d1be3-56d6-40f6-9491-e0a903973c6a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1d91f9dd-ad70-403b-826b-190056eac3b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("22a8ee6e-2d25-484b-b531-cb8a457bb3c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4651bf08-91e4-42cc-b44c-d4f7d1d936f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4dbe31c3-63c1-426f-a766-d886820eccb8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5ab66383-f768-4649-a02c-a47dd41f2cd2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8db84c81-c0eb-4f5b-b019-64c7e7948c23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d8f2f7b1-8a0d-4f71-9ff8-da57d741b4f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("1658059b-2d7f-4785-a9ed-de53baf6ad77"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("3cab2bf0-0ff7-42fc-bb5e-25d096983cb6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("4dd5cbc8-9acd-4a84-92e6-d74932342545"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("65648287-9ea6-4f2e-a264-f1deeb6abfd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("9619835c-66dd-4dc9-8d40-11199e38cfce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("a08e91f7-7c51-4182-a661-dcdc6917b2be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("d781ec94-b2f3-4994-87d4-81d47e69ae7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("d9bb919a-3849-44da-ad14-4aebac4ae677"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("eab9d618-bfa6-42fd-a741-a1b48d502184"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0cce77ff-f321-4dd0-bdbc-a5a3b2a48c65"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cec19a8-eadf-4e5d-a607-75a68e7e4cb5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("2599fad1-abed-4344-b5e7-fc195eac1984"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("c6fc8e98-5ba3-451e-8f2a-7bf6c236661d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("006183ec-792a-43ce-8b48-31b4b1e5a83f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a3d1be3-56d6-40f6-9491-e0a903973c6a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 476, DateTimeKind.Local).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 207, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 491, DateTimeKind.Local).AddTicks(5538),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 223, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 492, DateTimeKind.Local).AddTicks(4689),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 224, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 492, DateTimeKind.Local).AddTicks(9172),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 224, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 493, DateTimeKind.Local).AddTicks(1567),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 224, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 477, DateTimeKind.Local).AddTicks(1204),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 208, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 478, DateTimeKind.Local).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 210, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 478, DateTimeKind.Local).AddTicks(4026),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 210, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 490, DateTimeKind.Local).AddTicks(8000),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 222, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 490, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 221, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 490, DateTimeKind.Local).AddTicks(3890),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 221, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "ArticleComments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                schema: "dbo",
                table: "ArticleComments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 489, DateTimeKind.Local).AddTicks(8569),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 221, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 17, 22, 11, 28, 477, DateTimeKind.Local).AddTicks(3679),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 20, 10, 24, 32, 209, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("0133029c-151c-43ad-bbad-6c9f1d912d8d"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2514), true, "Case Studies and Success Stories" },
                    { new Guid("176b7f42-bc47-44d2-95bc-d89f275b84fb"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2584), true, "Modular and Prefabricated Construction" },
                    { new Guid("2354c777-0d4a-463a-bad8-ccb4f89b3d11"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2566), true, "Historic Preservation" },
                    { new Guid("24e2e1dd-6771-4dfa-b0b3-78d447f7b980"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2539), true, "Construction Techniques" },
                    { new Guid("27d85071-1a1b-4587-a284-7fc20d67470a"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2601), true, "Sustainability and Green Building" },
                    { new Guid("27dd1522-3495-4f32-8073-333c8880b56e"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2595), true, "Smart Home Technology" },
                    { new Guid("2ef71811-03a6-4224-a8ef-722a18f7bc5b"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2578), true, "Legal and Insurance" },
                    { new Guid("3067df56-940a-4e73-a26b-32c551556ed3"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2537), true, "Construction Management" },
                    { new Guid("32bf5e5d-abd1-4920-8d9c-dca25b7eceeb"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2603), true, "Technology in Construction" },
                    { new Guid("34c23b12-e55a-401c-b5a9-13c01855c685"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2576), true, "Landscaping and Outdoor Design" },
                    { new Guid("395e8144-79c2-4da1-871b-087a97c3736d"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2597), true, "Supply Chain and Logistics" },
                    { new Guid("4161e22b-359e-4438-9a0f-e9bd8f62c4fc"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2555), true, "Environmental Impact" },
                    { new Guid("466f0b6a-097c-4272-8bc0-09f9c9357148"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2547), true, "Customer Stories and Interviews" },
                    { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2524), true, "Client Education" },
                    { new Guid("4988b801-0de5-492f-acfa-59b0959c014d"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2511), true, "Building Codes and Standards" },
                    { new Guid("50fcf487-4d60-4ff1-b58b-7e35522139f6"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2591), true, "Real Estate Development" },
                    { new Guid("57a3b949-9c5a-4268-8b4d-67c3b18e5048"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2559), true, "Green Building Materials" },
                    { new Guid("5ffad37b-d9d7-4348-be37-4398f5e2ecce"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2458), true, "Accessibility in Construction" },
                    { new Guid("658ec5ee-ddf8-41ed-afb5-b4d6f2a6c99a"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2553), true, "Energy Efficiency" },
                    { new Guid("661441b6-4361-4ca4-9d4b-71f2f2ac3615"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2527), true, "Client Resources" },
                    { new Guid("6700183e-e204-49d8-8f1a-d5d23118781c"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2589), true, "Property Management" },
                    { new Guid("671558f9-358d-4dd8-829a-7c501bd11b20"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2607), true, "Urban Planning and Development" },
                    { new Guid("71eed4b6-8a64-496d-a37c-72899c13a11c"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2533), true, "Construction Careers" },
                    { new Guid("734a32a1-0381-4b75-8a13-1c66585d5a3b"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2593), true, "Safety and Compliance" },
                    { new Guid("806a4bb5-52b6-4ee0-8e3e-f0f94bcd219d"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2568), true, "Home Improvement and DIY" },
                    { new Guid("846cb57a-2286-46a9-9b98-95c851de8830"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2544), true, "Cost Estimation and Budgeting" },
                    { new Guid("853d3d3f-0bb9-425a-bb31-d9939d6fe105"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2574), true, "Innovation Awards and Recognitions" },
                    { new Guid("8efc9715-90fd-4e0c-9081-1a25acccded7"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2549), true, "Design and Architecture" },
                    { new Guid("9750c967-87ee-4ef8-9484-602141b3d4f4"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2609), true, "Weather and Seasonal Tips" },
                    { new Guid("9e030790-4371-4543-ad3e-345d2bb0fe70"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2529), true, "Community and Culture" },
                    { new Guid("a6270969-ce2a-471e-888e-a3eec218ffc9"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2557), true, "Equipment Maintenance" },
                    { new Guid("a7b5e5d9-59b1-47a7-b86a-1d48a2dc9ba1"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2582), true, "Materials and Equipment" },
                    { new Guid("aed36297-f774-46d4-ad29-2653886d88cf"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2563), true, "Health and Wellness in Construction" },
                    { new Guid("c017f9f1-0d61-4c07-8e59-df8b29fe5d7f"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2535), true, "Construction Finance" },
                    { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2570), true, "Industry News" },
                    { new Guid("cc224776-9ff0-45a6-90de-d060bee219c5"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2551), true, "Disaster Preparedness and Recovery" },
                    { new Guid("e0351a3a-63ca-48fa-8e93-e3e83388592c"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2586), true, "Project Showcase" },
                    { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2531), true, "Company Updates" },
                    { new Guid("f5b8eaf2-c27b-4cdf-9d4e-d8e6992ac35b"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2572), true, "Innovation and Future Trends" },
                    { new Guid("fdba2fdd-5833-4f12-8ad2-f09ce45ae61a"), new DateTime(2024, 6, 17, 14, 11, 28, 493, DateTimeKind.Utc).AddTicks(2605), true, "Training and Certification" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(5675), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6427), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6495), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("8d8ec95a-eed2-478d-943b-81c3da9a249f"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6200), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("b95c8379-4102-4d3c-b336-560e5b90a4b4"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6319), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6119), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("caf0c44e-37dd-4258-93de-8e33245a491b"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6590), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("eabce088-581e-47f9-b034-5e248e723b70"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6265), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("ec196330-bbdf-4dbd-b249-88b37052dacf"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6545), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("309d464c-44ae-4850-9792-5df9105d9d2d"), null, "Admin", "ADMIN" },
                    { new Guid("31f5fadf-7ccb-4824-81b7-1ecd750a0acf"), null, "Moderator", "MODERATOR" },
                    { new Guid("45e8586a-cb24-4bdf-befe-8114c52f6779"), null, "Client", "CLIENT" },
                    { new Guid("54fbb3e2-e4a5-4077-9005-541a9a520d8a"), null, "Editor", "EDITOR" },
                    { new Guid("8c0313ed-311b-4943-a6ba-d78d89879cdd"), null, "Visitor", "VISITOR" },
                    { new Guid("fe190203-930c-4723-a8b9-22676fdc436c"), null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("65cd4351-47f0-456e-a86f-d15ee99e73cd"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(7224), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("8475459d-b91e-4141-88d2-50ec6596c6fc"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(7217), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("c937ff58-d94c-4860-bb7e-b0373edd3f49"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(7221), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("ef4538c9-06bd-4d55-8692-a8bae1e2498b"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(7206), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("010a5584-5d98-4fef-a60f-e83a66708bbd"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(441), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("0504a802-fff3-4df1-acf3-e259622afc8d"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(431), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("108cbe2d-7739-411d-9f67-2e22f9240b94"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(420), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("2847a973-8322-46a7-a0a3-cbdcbfa40588"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(455), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("31137083-6a75-4e0a-9ecd-3bc85477dccd"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(397), true, null, "How can I get a quote for my project?", null },
                    { new Guid("417c9b92-ac07-44c2-8cb2-3f71a36ec8a9"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(446), true, true, "Are you licensed and insured?", null },
                    { new Guid("45cfc6ac-484a-4721-8618-7610e47c9d19"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(425), true, null, "Do you offer financing options?", null },
                    { new Guid("471b6dc3-eba7-4ae5-9d1e-d9c2df62080c"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(474), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("57a7c4de-d6f4-40ce-aff7-a447bbe675a9"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(423), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("65453a9a-7436-428e-93e5-e9f447f6be0e"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(476), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("6d324988-543a-44ae-ac6f-aecb9e41af1a"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(471), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("914345e4-f17b-4d27-b538-6432bdf35371"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(409), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("935501cd-e681-4495-8a15-160d896ab783"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(391), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("aad12e5a-1256-4223-bc4f-719b9030cd7e"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(479), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("b0e98090-3bbb-4c39-b0dc-4d4f739432c0"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(373), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("b3ac6ef2-1711-4132-9886-347a6c65e1a2"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(414), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("d21c0ca6-61ef-40c4-b264-b05225f5fc68"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(436), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("de500451-d66a-4432-b6d0-0a22518978b0"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(450), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("e0f3bdc1-1473-4a2b-a091-bf8e9c1d92b9"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(469), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("e5485302-7016-4550-821b-da95725b8cfe"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(434), true, null, "How do I pay for my project?", null },
                    { new Guid("faaad391-b38f-4bad-89a2-170212028c18"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(403), true, true, "How do you handle project timelines?", null },
                    { new Guid("fcf94cc5-c415-4e9a-bd01-de97a23bb4df"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(460), true, true, "Who will be my point of contact during the project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("728bd4f0-ed70-4ecf-90ff-f3e6b9621ef8"), null, null, new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(134), "James", 0, new Guid("96f4c92c-204d-4cd2-b94d-1508452f279a"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("953da12f-0f3b-4398-9a54-b8c36a5aea72"), null, null, new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(195), "Charles", 0, new Guid("e364b2b6-a915-43b7-98c9-be4e1e46907e"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("96f4c92c-204d-4cd2-b94d-1508452f279a"), 0, "953e6adb-a3b9-4aec-bec2-865e933fc689", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE8HA/E+pEWn01hBzyhuvKuN4QeVK3w8wuv6XcF200AGyQzwjZmwoX2mdGrwel3L1A==", "+639672814641", false, "7abf7fa7-2159-2e9b-ef03-1de50938e43f_20240617141128493", false, "jc.mangubat@hotmail.com" },
                    { new Guid("e364b2b6-a915-43b7-98c9-be4e1e46907e"), 0, "b9518473-d310-4972-a61b-5023ddcdedd8", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEDdLS+awz//gFMctCMLJTQMqUEDw3zG27lkLNvyIUQOyz4oipdQetNGdePbWcgTI0g==", "+639951225449", false, "7abf7fa7-2159-2e9b-ef03-1de50938e43f_20240617141128493", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("d05e6b64-de1d-46a9-81b0-6391ea085d9c"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(307), true, "8000", "Davao del Sur", new Guid("953da12f-0f3b-4398-9a54-b8c36a5aea72") },
                    { new Guid("e53353aa-b052-4737-834f-5b467c1ccb0c"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 17, 14, 11, 28, 657, DateTimeKind.Utc).AddTicks(299), true, "8000", "Davao del Sur", new Guid("728bd4f0-ed70-4ecf-90ff-f3e6b9621ef8") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9") },
                    { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9") },
                    { new Guid("3067df56-940a-4e73-a26b-32c551556ed3"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") },
                    { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") },
                    { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") },
                    { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10") },
                    { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c") },
                    { new Guid("e0351a3a-63ca-48fa-8e93-e3e83388592c"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c") },
                    { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c") },
                    { new Guid("474590f2-519f-4d9c-9868-a695ef91ffcc"), new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763") },
                    { new Guid("fdba2fdd-5833-4f12-8ad2-f09ce45ae61a"), new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763") },
                    { new Guid("27d85071-1a1b-4587-a284-7fc20d67470a"), new Guid("caf0c44e-37dd-4258-93de-8e33245a491b") },
                    { new Guid("c5269b17-d1e1-4886-bcc8-14af6c52d7e8"), new Guid("eabce088-581e-47f9-b034-5e248e723b70") },
                    { new Guid("f04e6c2d-1e1c-41c4-a2b6-f5d375a6038e"), new Guid("eabce088-581e-47f9-b034-5e248e723b70") },
                    { new Guid("27d85071-1a1b-4587-a284-7fc20d67470a"), new Guid("ec196330-bbdf-4dbd-b249-88b37052dacf") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Email", "IsActive" },
                values: new object[,]
                {
                    { new Guid("09f1bf17-2b77-421c-9705-e85ce95042e5"), new Guid("ec196330-bbdf-4dbd-b249-88b37052dacf"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6576), "commenter@gmail.com", true },
                    { new Guid("243fc35d-2a0c-49e5-af7b-e62799e7ee26"), new Guid("b95c8379-4102-4d3c-b336-560e5b90a4b4"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6353), "commenter@gmail.com", true },
                    { new Guid("40ed2ae5-4be5-477c-ab70-f2a7eaac1cb2"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6537), "commenter@gmail.com", true },
                    { new Guid("59947f91-3623-4a7d-bd3c-5fc41141161c"), new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6177), "commenter@gmail.com", true },
                    { new Guid("5c626d51-1889-43f3-a909-696c4042e1a0"), new Guid("caf0c44e-37dd-4258-93de-8e33245a491b"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6622), "commenter@gmail.com", true },
                    { new Guid("6c303614-f78d-47fb-9242-69f0cf05d329"), new Guid("8d8ec95a-eed2-478d-943b-81c3da9a249f"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6254), "commenter@gmail.com", true },
                    { new Guid("6ef8ba6b-70af-459b-acbb-f371db2652bc"), new Guid("eabce088-581e-47f9-b034-5e248e723b70"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6309), "commenter@gmail.com", true },
                    { new Guid("8248b105-7dcc-41e8-87b4-1ea19954db0f"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6484), "commenter@gmail.com", true },
                    { new Guid("f8010314-3915-48cf-bea6-5c083fe907f3"), new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6088), "commenter@gmail.com", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("0fa1d88e-3c4d-42c2-bb69-5cea61cfb314"), new Guid("caf0c44e-37dd-4258-93de-8e33245a491b"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6626), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("1e6816ec-1d8d-4f8f-bc7c-19a68bf17ce0"), new Guid("eabce088-581e-47f9-b034-5e248e723b70"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6313), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("707d02b4-ef02-46fc-8a8e-3a4af1a30fa8"), new Guid("6a440cb0-4216-41dc-9e7d-9a4057323fe9"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6106), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("a819e601-c103-4b57-a457-e07a4aaee127"), new Guid("ec196330-bbdf-4dbd-b249-88b37052dacf"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6584), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("ae41f823-3b87-492c-be46-b1ac99ba755c"), new Guid("c092f4cf-e2b8-45cd-b56c-c4db238a0763"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6180), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("b7e0d064-39aa-4d61-bdda-3e25a2c40c5f"), new Guid("7dcec4cb-24be-4dd7-bac5-463f91613d10"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6489), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("c9b8a92d-46fb-4139-95cb-be25f0eb5629"), new Guid("8d8ec95a-eed2-478d-943b-81c3da9a249f"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6259), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("e606a5d8-2d68-457b-abe8-0f584578c4d9"), new Guid("7ddaaf0b-8271-4550-8a7a-6cefa0464e2c"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6540), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("f59b94d4-819f-4088-98dc-bf0f811ac3b4"), new Guid("b95c8379-4102-4d3c-b336-560e5b90a4b4"), new DateTime(2024, 6, 17, 14, 11, 28, 661, DateTimeKind.Utc).AddTicks(6414), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("309d464c-44ae-4850-9792-5df9105d9d2d"), new Guid("96f4c92c-204d-4cd2-b94d-1508452f279a") },
                    { new Guid("fe190203-930c-4723-a8b9-22676fdc436c"), new Guid("e364b2b6-a915-43b7-98c9-be4e1e46907e") }
                });
        }
    }
}
