using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemovedFeatureProjectHideTitleField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("3429fc6e-f4b0-4e1b-9ef1-63ac2aa28fbc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e7c50690-f69c-4a50-967a-9b550d8b4329"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2f757eae-536c-4ff4-990d-b376920ec149"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("36f41cde-3148-4164-aba9-64081a1d630b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("434fb5c1-16d2-447a-a441-a1566905d43e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("48824ae4-efb5-47bc-bf85-ec85e71f0a1a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5217fc68-adaf-4441-86a1-1539e7449e70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("56d5a7b8-654d-4a13-938d-3a65c17b8c92"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5787da6b-c4ba-406a-ad86-a7810fefc1c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("57bcc92a-1247-4cdc-9726-ad8f4dfeeec2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5e3c6372-a798-4b80-8b4f-e5cfe895faae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6c959efb-cc98-4b2d-baa3-f2ece0172e60"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6e834efd-5ae7-4dc1-aa7c-6aa5d1c55b99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6fb47659-0dc8-4c79-a14f-34012e405e34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("76c78346-e7fc-4329-b3bb-c4a21dd6ee17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7ccabd63-4a22-4534-acaf-283cd45b59d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("802481ab-5a9a-4fb2-b8d0-482f796dcb74"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8aeb3798-11b8-4e47-ac7a-da91f2331464"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8fc3596b-b17d-4437-a550-c34077d13f1b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8fd16908-d186-498a-a593-be3e9f1cda7b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("91f87b28-e3ea-4acf-9b31-6ec89c8ef6ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("95329d67-a4bd-4eec-8a4a-afb50358f9bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("95b4837a-44db-4589-90bb-5578b8c20d14"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a1d11c68-89a2-456f-95cf-48a350084822"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b3210304-7b88-48b0-b5d7-773699b041dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b6f4d811-2d27-4881-ac68-6d9fe89dfb83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("bad5ffef-bf30-4312-ab11-fe3934ecdc67"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c4ab4d76-162e-4d93-b7ae-9ca220bc30c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c67f16cf-fdcb-4226-a8b5-a92741cc8c1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c9f40545-e0d8-4a4a-9c9a-c35cb5aa36c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("dd843a51-118c-4d73-8f22-357f52033105"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e094938c-4f0d-4d81-bde1-31e7af9a5226"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f0bcd3b9-2f7a-4069-b54d-00e283245b9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f5839e17-7405-4ae0-ae57-6e6836252b4f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f660e80f-94f3-4258-848e-fa0792ea3771"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("186cd40b-b1e5-4faf-9441-df4f6ee04645"), new Guid("25385761-1d29-4ff2-9e1c-e2b7307799b9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("186cd40b-b1e5-4faf-9441-df4f6ee04645"), new Guid("4a6fbb99-c779-4df7-8243-504f20c8ee23") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("865deddd-d238-44d5-b234-13b10ad9060d"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b4bc7bae-39e7-4f9e-86d2-34c354a67683"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("145a78d1-4e25-41a3-9e54-1c4c95366a7e"), new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("1c026658-28f2-4d05-9b89-b9266e17c0f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("2898bc6d-cd6a-4d0b-a003-ecc3aa3e55be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("55964667-040b-46a0-bccb-712f6475325b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("5dfad88d-6da7-4436-854e-ae0178abea66"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("6ac6006f-b4d5-42a9-84b9-84828ff6cf78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("93523acf-bde2-4f22-9f97-433df5cc8d3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("a74589ce-13c5-4076-b509-b9907adc6a67"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("b9437a1c-fdb5-4d08-b499-93d68e8735c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("f29c416f-48c6-49a6-a484-c5f48dd747ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("07f0454f-7026-4f57-a1e6-ac11d8be99de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("11cdb62d-5549-4e48-9cbb-e0b4fe11526f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("48da151b-ab60-4657-8f8b-cc62a2c8019e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("49bac859-b1e8-4b13-9839-894847119663"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("4caf4176-323c-455f-afa5-058b98004ed5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("61b903e4-0a19-4070-a7bb-714cfd16bfd5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ab30b691-e7ec-42ce-ba26-180e64db5d3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ae3d70d8-15c9-489b-bf95-76e75a1a46c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("d70e5c07-9087-4057-bcd3-c781ae4c409a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0e0232c7-8f8e-40e2-875a-0fd23b9ea463"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("225e1684-8841-4fe6-919c-0a6a4f86bdef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7ad51824-59a3-42f2-ac53-b0f33cc5f8f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("be9abc21-253d-454e-83dd-93acee7f3120"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("40af0364-1e08-4a68-b485-3e5fca9013cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("7fa7be84-2289-469a-ba5b-e53eb610dfff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("89794019-72c6-4cd7-8b0a-e10482e2f620"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("a326b88e-7c20-4db0-ac99-6fb754c7e1c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("00b0330a-edd3-4e90-86d6-63a2809a5596"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("028cae38-6355-42f2-81b7-98724f4a23c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("029e3345-2448-4636-8c42-fda4e09eac43"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0435482e-2423-4f99-834b-e2775ef94381"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("06559580-b666-4549-a098-cd331313a2ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0717a40c-6533-49ef-b040-349d9d976735"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("07f45583-1e92-45cc-8200-f04f17e3b7b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("088b4e88-9279-4ebe-9339-5278e5fcc307"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("094c733f-fb67-419f-b3d9-29d99e3a9c3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0dc4f69c-274b-4899-8014-019dc6c615df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0e1bfd75-969e-4366-8e83-a03cb2b5b79c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("114025a7-86a4-4dc8-871d-a491a9241d05"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("134d87c4-e718-44af-a35d-937e5bc2f53c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("138e189e-22f6-4609-a79e-bc196b34af5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1c1d5be9-f2b5-497e-bfff-2fee04602004"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1c775202-c4f9-4ced-abb2-b5d6358ba605"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1c9b9763-0a5e-4167-8b49-54638cb4390c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1e079a11-0d8e-4b8a-917a-d380745ac7ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1efe61b8-5953-4ada-8ffa-7988663b0b68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2025ba6b-964c-4611-89d7-bd4db522d79d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("211b8080-6ea6-4bf6-bbea-ac21d69bdc58"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("22253291-9a4b-4d3b-8992-1cc7dac7b2b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("23f4a39f-7c8f-4789-951a-71058e20ef42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2426c6d1-ef6e-4213-9e09-a300a17f6de1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2502c38d-5673-4b8a-8ae1-bbd35b1f4212"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("26206fca-0594-4f1a-8d3f-0ae58438a433"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("275387fd-08c5-4c39-aac2-b114835933e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("296a731e-22d5-4bb2-947b-27a257313b77"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("29bd7900-555a-4ad4-9ad6-de172cbfeeeb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2da81be5-952e-404e-a6f4-07503ab29dc7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2faa2af2-2817-491e-b8c2-c43ad14709ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2fd1e9d9-83a0-42cb-a5e5-78c735c9ec7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3044964c-78a9-4d85-9dc5-c58171423aa3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("30e5e2ba-2c3c-4bab-bfc9-37afba221672"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("34dd2d1c-5b5a-43e5-bdfa-3646c3b5b8d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("34f741c6-157c-45fb-8ac9-e25a42ac7bc2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3803bb8d-f97b-41fb-ba19-c9b696bd544f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("38b739ca-4022-4dbb-a326-886f3f7c26e7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("405aef1a-7621-44e6-8ec9-8a1cb3796dbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("453de0cc-74b9-4ed7-a8a2-e3930e11380b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4999cdf4-7544-4a56-8f3f-d531f79c97ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4c800ff6-4ae8-4445-aec5-5535a859d30b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4cc49fdd-8a53-478f-988d-705c30521809"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4da38edd-f7c6-4619-aa4a-7308fca633e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4fd27e31-ef5f-4c0c-b180-fb2c636cfa4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("50408bf2-edc6-4e41-8ae2-8454e3c93aed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("516dada0-5bfc-4d86-9988-c1434856575d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5325e0f6-4239-4461-8c57-49ac91710342"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5373b4ca-2132-44e5-a4ec-64acb1a058b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("54a2615b-70b1-44b1-aaf8-76a394998649"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("55887cb9-8674-421a-8ac5-7c89d5ddb7ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("560a29a6-831d-4500-bc42-3e03307d62ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("57d0a41d-a674-45dd-83df-90b843957768"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("588ae587-ba40-4183-be85-34774b9ea8b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("59764980-1111-46a0-a5b8-67db1bba3c21"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5a360098-054c-4dd9-a62e-db0ecaac0f0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5b2f9f9e-3979-4bd3-8e18-cf514e7bdb36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5c759efa-8071-4914-9a47-674cf4ee1de8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5fda784b-7120-475e-b06e-8554484a670c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("60e1e0f8-0c77-42a5-be37-f5549062263c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6331d7fd-c0ac-42ad-9360-6f29be9f88ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("63af8d11-847a-442f-b130-8746ed79f3de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("64bf4a19-bc21-4b21-a5cf-bcc87bfb5f8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("691b6600-0f8b-4c62-b5fe-8130ad105682"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("69e53a53-94c2-41a7-b216-220cf4f89e2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6a6503b7-d021-4310-8036-ba54c1b5167e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6b9bd1d2-e470-43b0-bf87-e132162487bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6cff59b4-6a61-4533-aae0-bb67689653b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6e86b817-3e5c-4d42-8dcf-5cf4eb00b85c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("71460959-d153-49c5-b7b8-1d045ce1b682"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("71beed2f-32c9-407a-b7c5-7cc10f2e2446"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("722329c0-bb2b-43e8-a920-a8d1e05e20f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("73e56932-3e3e-43d5-8e9e-0995efa93562"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("77f2badf-71bc-4556-939e-dd265f8dd316"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7907a890-aea3-42d1-9c31-b545550d7720"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("79c92e65-ee4d-47ce-bd46-a326730f0479"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7e0f409e-037a-4bab-842f-b712b6c1708a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7fef7ff3-6c51-4ae9-9840-326665866e8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("800480bd-dbd9-4cea-be5b-561cf0c68f5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("80c41f31-99c6-4719-a990-6384e866119b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("817bc5a0-46f1-4949-bde2-c9cf9f79aff2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8306b716-f481-4af7-9a2b-fb8fe15d8166"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("84d4f6eb-07cb-4dc7-82cb-480d0afd1385"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("87f183d0-769f-4929-80c8-fe85824caeb4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8897300f-df16-4f43-9c26-713d33caba9c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("89ef0739-df4e-4cfa-9cd6-e2eabdeeaab2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8d76907e-3737-4098-bd1f-4001e51bc91a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8d8a1480-2bc0-49ed-bb07-3c88e867cef0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8de26f74-d6ed-40b6-987b-31a035df231a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8ee7f2f2-bf23-49ff-bc61-ccc1f2a1d4f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("92473d18-02f2-4da8-90c9-535146cf5991"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("963ef555-5c47-4a73-ab23-fde5da61e9fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("97667698-3e39-43ff-a89d-5817d317973a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("98e17197-0f7e-43df-8b85-f125ca54c50b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9c42800a-5836-4553-bd03-094058e3e034"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a246d912-92b4-497a-b4fc-fd20de17a9e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a8960ab8-b205-41e7-b01e-8c3698d564fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("aac5ec15-11ae-4cff-bd81-9923a41fc415"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ab9cf751-54c1-4804-8398-5b8e844ac947"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("aba0e05c-2693-412e-802d-d237019148a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ac34f3b7-486b-40f3-9a4f-e86e625a42f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("af31f57d-bfdf-4709-9472-112de000931f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b1ea49fe-4e00-498a-b574-409dde0df805"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b4af9b1e-5d39-406e-89fd-1123a253af75"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b76c5c45-5a55-48d1-98c9-2cf946f252de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b774d9d0-1983-4613-9492-7070d09d2bb8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b8849d7f-3e7f-4d62-8728-1ff5e28efa7a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b931c3a6-91d6-4f2d-9d16-31a1b04f6056"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b940bd53-511b-4b85-a2a0-ee083f7a6378"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bfc2d5b4-e0bc-43b4-b90b-dcee796cf1fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c0848d9b-e001-4411-b0e3-29ca1fea1e99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c216e740-5467-433c-be53-72c996e5d2da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c68a2360-407a-4abb-ad1f-23a809f8a585"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c7a1e728-7e72-464e-b2c6-0b6d45a7bc65"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cb9e6a8f-1014-44c4-9ee7-3b8188a2c4f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cbe3e068-5098-4ea5-8ba3-79720b902eeb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cbff3c7a-1ca1-4893-bc78-7c107fa92589"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd64348e-1da7-4f29-bbe3-5616ff267845"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cea26776-207b-4f2d-9eae-de8db8b0e475"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d828dfcf-7b40-4291-a01a-e54663278981"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("daa61530-b456-4e1a-971c-f1cc8f6b3849"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("de1d49fa-5b11-4158-9f4b-9a47654e6381"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("de96be38-01c8-413e-9fd4-a5a942bca40b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e024aa50-7bd5-447f-9408-a5be95cf0284"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e07ca8d4-ffc3-4163-9234-d7cad14c5bee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eb77675e-9827-4783-a78c-f35ab8201ede"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eff219e7-0c4a-4503-8910-3c7e3256c6f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f06472ec-1640-49bf-a033-b18939b4ada0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f1fdeeda-505d-4de6-b58a-b4128171e973"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f2fe4509-a899-4872-a80e-f4a6b6f046a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f4002bcb-db42-4de6-ab5d-33a6029b45c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f45b2c3c-f12f-45f4-8ca9-27ed9839f7b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f4a7dd7c-737c-445d-8bbe-4527e32fd018"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f4d21a59-0fed-481a-a6e8-6dbbf8d9df86"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fb0047f6-e87b-4f15-b4a3-e002afd94392"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fc57b7e7-3771-45fb-aa83-62e1db821969"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ff20cf73-d9d2-4982-bae8-fec4539ce1f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ff89228e-737e-4588-ae80-cb63fa6aeb73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("00e3029c-2e5b-4937-8d73-1fa752e1b8dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0c54eb72-71b1-45b2-bac9-cdbac8378e33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0db65cc9-6f07-4124-985f-fadb814d4c84"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3707ae88-f9b4-4ba7-ab31-31661a0d3d93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5a0e7d29-bf38-4bda-ae22-8333bc2f6c3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("695eca77-0804-429b-93a0-f2fc621169a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("846e5ea2-3050-4ef9-a1b5-854f96d76b55"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8f6b1f80-b5aa-4c85-9199-e41080dde5f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("903771fa-f815-4e06-875c-0acb229b2988"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9cdd8138-9d9a-4084-979e-6562fdea881f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("bf03788a-c5c2-436b-a1db-4e7b1e1dd285"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c49a1b50-9dde-43d9-8416-82a03caf30c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("cff94fa3-4e25-47d0-a2b6-bec2aef7395c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d03683ff-2cd7-4f6e-ba3c-80979d789545"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d4a99bdd-1b8c-4dd3-8116-2c630ae76640"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d616726c-bfcd-49bc-98bd-a95a311d548e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d81e0dae-2933-4043-9042-de121730e9fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d8c4e52e-1816-4133-b1c3-9a743afd775b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("dd02ac62-d2c1-43ab-92bd-b0ead5ac7eff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e0d4ff6f-0a68-4828-a424-13a047c3c79b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e637e42b-1a25-45b6-8357-25a63348f48e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f75569ce-d4ef-4934-8411-1758ca09e104"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b136bc30-3de1-4862-8199-135ee9b058c0"), new Guid("234b2000-3d0d-471e-a2cb-5c70d700ddd4") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6b4a82b1-0416-42b1-8315-a136518686df"), new Guid("e67959a5-59cc-48e2-9ebc-f55b0e1323e4") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("145a78d1-4e25-41a3-9e54-1c4c95366a7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("186cd40b-b1e5-4faf-9441-df4f6ee04645"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("865deddd-d238-44d5-b234-13b10ad9060d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b4bc7bae-39e7-4f9e-86d2-34c354a67683"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("25385761-1d29-4ff2-9e1c-e2b7307799b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("4a6fbb99-c779-4df7-8243-504f20c8ee23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("55fe0db0-59a0-4832-bf2a-3353fdae42d6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("634c9bee-0716-42c8-902c-fae0a0e0bf5d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6b4a82b1-0416-42b1-8315-a136518686df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b136bc30-3de1-4862-8199-135ee9b058c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("0db011f6-151a-478f-b4a3-6157c1210683"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("8d887094-7226-4a33-be06-0e88a1ef12a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("ae83df8f-9ddb-4d0e-a0f1-1e5ace2c08fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("234b2000-3d0d-471e-a2cb-5c70d700ddd4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e67959a5-59cc-48e2-9ebc-f55b0e1323e4"));

            migrationBuilder.DropColumn(
                name: "HideTitle",
                schema: "dbo",
                table: "FeatureProjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 824, DateTimeKind.Local).AddTicks(1514),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 265, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 839, DateTimeKind.Local).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 840, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(1873),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(4598),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(296),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(8378),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 842, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(1554),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(4904),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 267, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(7642),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(4491),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 275, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(3221),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("003d4b1d-cf4f-4fba-bb41-bb47279a8c86"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4191), true, "Customer Stories and Interviews" },
                    { new Guid("087285ce-3b20-4553-9bbe-b542f6a92b78"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4270), true, "Training and Certification" },
                    { new Guid("124a2e3b-d087-4d34-a00d-4675494e9d09"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4216), true, "Innovation and Future Trends" },
                    { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4214), true, "Industry News" },
                    { new Guid("208da59b-b93f-4e08-84d1-2ad841fc396b"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4212), true, "Home Improvement and DIY" },
                    { new Guid("2100a397-cfd5-4b49-9afd-315e757a709a"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4172), true, "Construction Careers" },
                    { new Guid("221004c4-0db1-496b-b281-7ccd514c1eda"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4193), true, "Design and Architecture" },
                    { new Guid("22685de2-797a-414a-960b-894d44010810"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4228), true, "Modular and Prefabricated Construction" },
                    { new Guid("27855490-00e7-42bc-9263-71b8c996e6d5"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4275), true, "Weather and Seasonal Tips" },
                    { new Guid("27862994-bf87-4ec1-9a40-88d4a8e3e424"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4262), true, "Smart Home Technology" },
                    { new Guid("291c15b7-713f-4501-975f-ca989cb27732"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4234), true, "Project Showcase" },
                    { new Guid("29d4a1da-d255-48f0-a96a-4971ca9d6fc1"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4208), true, "Health and Wellness in Construction" },
                    { new Guid("29d9a3c4-101b-4ea2-8972-62b2494d83d1"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4220), true, "Innovation Awards and Recognitions" },
                    { new Guid("337bb2d4-d3b1-4435-a347-4c4696dee894"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4210), true, "Historic Preservation" },
                    { new Guid("36ed735f-34c4-40e6-ab51-95ace5083077"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4153), true, "Case Studies and Success Stories" },
                    { new Guid("3f05300e-4174-4f18-a4e9-90c6278414a4"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4195), true, "Disaster Preparedness and Recovery" },
                    { new Guid("559eb064-0026-4302-9560-6b2668c26eb3"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4256), true, "Real Estate Development" },
                    { new Guid("5c6b7f0f-151f-4571-86a1-05d80542787f"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4157), true, "Client Resources" },
                    { new Guid("6131f955-5828-461d-8d25-69a1313d68b8"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4254), true, "Property Management" },
                    { new Guid("753695de-84b5-4ca2-9d3b-acb299d88a28"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4185), true, "Construction Management" },
                    { new Guid("75a62566-cbaa-4970-b0ef-23e6dd72fbbb"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4206), true, "Green Building Materials" },
                    { new Guid("7a64ba27-5e51-4eed-af30-fc9a026f6f0d"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4272), true, "Urban Planning and Development" },
                    { new Guid("8638b69c-b71c-4cdf-b0fd-dcb765e8ccab"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4197), true, "Energy Efficiency" },
                    { new Guid("867d4fc6-93d5-41c5-9fbe-5fc1c5e5df03"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4159), true, "Community and Culture" },
                    { new Guid("90cebbd3-3095-4f24-95ed-9707c405f945"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4222), true, "Landscaping and Outdoor Design" },
                    { new Guid("949d9b22-25bb-4007-98c0-d4e7f7cde07c"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4150), true, "Building Codes and Standards" },
                    { new Guid("94b0cb3c-7153-42c3-a11f-be5d655dfa2d"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4202), true, "Environmental Impact" },
                    { new Guid("a23d84ab-a78d-4f01-b0af-30977e5bd922"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4183), true, "Construction Finance" },
                    { new Guid("aab9be11-bde1-43d2-a9c3-0a10b879dfb0"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4226), true, "Materials and Equipment" },
                    { new Guid("ac5a73b9-8362-42f9-8510-3d1eb542a687"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4187), true, "Construction Techniques" },
                    { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4161), true, "Company Updates" },
                    { new Guid("b218caee-80cd-4b0a-93f1-a79a8a88858c"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4260), true, "Safety and Compliance" },
                    { new Guid("b5ef7aad-cf22-4313-88f3-c6ad3f8abc82"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4264), true, "Supply Chain and Logistics" },
                    { new Guid("c3d181e7-9a6e-40af-8e2e-a4b03ec5a3b5"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4267), true, "Sustainability and Green Building" },
                    { new Guid("c4593a32-1c57-4f59-85b4-4f776ba9acdc"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4224), true, "Legal and Insurance" },
                    { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4155), true, "Client Education" },
                    { new Guid("e2db3d18-aa26-4994-81a0-1df9d216de78"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4204), true, "Equipment Maintenance" },
                    { new Guid("f3708802-01c8-4a75-b981-adb8dc303aa5"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4189), true, "Cost Estimation and Budgeting" },
                    { new Guid("f5d9f166-e566-45d5-8106-f6fed4d79da3"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4269), true, "Technology in Construction" },
                    { new Guid("f7648c8e-4af4-4557-bba7-7e23228458e3"), new DateTime(2024, 6, 27, 15, 2, 43, 842, DateTimeKind.Utc).AddTicks(4113), true, "Accessibility in Construction" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("3e4d3d76-f225-4fde-b911-7d1f1e47cea1"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2544), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("4673cefc-da25-4c61-8241-fb3157870adb"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2163), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("5fdd423d-3cae-446d-9adb-b0965fbfe79f"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2360), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("6e5c1db0-0577-4c20-8e73-79099de912ae"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2431), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2512), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("99a166bb-af49-4849-aeac-63e5ea49507c"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2472), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2326), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("e1573011-5e17-468c-8ed9-1a9614373433"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2398), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("e33ff3a7-696a-4e90-b841-2e7e8bd78ebb"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2575), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("08e3b61a-ace1-47fd-879b-4dfc64d7cc36"), null, "Admin", "ADMIN" },
                    { new Guid("0a2ee09e-8b6e-4315-b568-6eb672bc7686"), null, "Manager", "MANAGER" },
                    { new Guid("612ddaaa-4f8e-4775-93c6-1c3843c24487"), null, "Client", "CLIENT" },
                    { new Guid("78ffd478-d17d-4a3c-bc7e-fb8d67a0f4d2"), null, "Moderator", "MODERATOR" },
                    { new Guid("c732a579-6201-4e45-9a05-249b76d371c3"), null, "Visitor", "VISITOR" },
                    { new Guid("ed71d59f-3ffb-439d-9b5f-7b4ba4f5acc7"), null, "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("201a2240-3a8a-4891-b96c-05eb15de57f1"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2962), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("39f92031-42e2-474f-a7f5-a44c6b3c2682"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2967), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("88145fcd-b37a-43ac-9a08-34c04d571d1d"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2970), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("e5aace86-5efa-4001-9177-b26d704e6c20"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2972), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "ImageCDNUrl", "IsActive", "Location", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3630), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "aringay-lds-chapel-retiling-and-repainting-works", "Aringay LDS Chapel Retiling and Repainting Works" },
                    { new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3898), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "lds-chapel-retaining-wall-construction", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), null, new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2718), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "lds-church-improvements", "LDS Church Improvements" },
                    { new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), null, new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(1881), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "ladon-construction-service-davao-city-headquarter-office", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), null, new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2545), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", true, "Philippines", "company-workforce", "Company Workforce" },
                    { new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3400), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", true, "Davao City", "verdon-park-condominium", "Verdon Park Condominium" },
                    { new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), null, new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2827), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "um-library-fire-protection-pbax-paging-systems-project", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4018), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "talavera-chapel-general-repair-works", "Talavera Chapel General Repair Works" },
                    { new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3520), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "san-pedro-laguna-lds-chapel", "San Pedro Laguna LDS Chapel" },
                    { new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), null, new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3122), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", true, "Sasa. Davao City, Philippines", "sasa-lds-chapel-general-repainting-retiling-works", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2939), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "carmen-lds-chapel-general-repainting-electrical-works", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3786), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "general-milling-station", "General Milling Station" },
                    { new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3218), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "mang-inasal", "Mang Inasal" },
                    { new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3292), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "muntinlupa-lds-chapel-elevator-project", "Muntinlupa LDS Chapel Elevator Project" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("011cfda4-3035-435a-9799-d0f6b37de6cf"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3885), true, null, "How can I get a quote for my project?", null },
                    { new Guid("0e52f28c-042f-4f68-8501-0b25b3fab6a5"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3918), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("10d2c4df-f258-4a58-b0d2-903844f5df72"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3944), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("1e348ebc-70c6-4381-a34f-9e0b6ef8a28f"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3898), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("2a4ab07f-201e-42be-9906-6e394f8001b1"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3902), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("352063d8-5c2d-4d78-87c8-b493371f45f3"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3914), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("395489ca-5ac5-4508-94f1-59df021dcf3f"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3906), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("52791d02-8a21-4ed2-9730-c10c9c952307"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3889), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("5dd27602-2a70-4750-bbee-87cb24ac7d17"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3907), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("7bac67bc-fd40-4880-8127-349262f96c73"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3896), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("7d1565d6-8d3a-40a6-9373-2890e92ce5b7"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3904), true, null, "How do I pay for my project?", null },
                    { new Guid("7d614874-f080-4701-82c3-b5a974bc303c"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3882), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("8637904e-b4e8-4b34-99da-dfc45e01115d"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3921), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("98026b26-99a7-4710-9e10-c99dff0c0c8c"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3946), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("9e5793c8-c7b9-40a5-adf9-f607ba8b8ad7"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3891), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("a023f8ec-a3b4-47f2-96d2-ad64460d9af9"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3887), true, true, "How do you handle project timelines?", null },
                    { new Guid("a2fadd41-4e3f-4856-bec9-75e5c828ea93"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3900), true, null, "Do you offer financing options?", null },
                    { new Guid("c5136fc4-1329-436d-afb3-ac1103887570"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3916), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("c6c4eacd-f3d8-42c2-ad06-fffe3a1f4dfe"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3909), true, true, "Are you licensed and insured?", null },
                    { new Guid("ce06566d-d70d-42f0-8880-b57136dd65e2"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3878), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("d6ad8be8-ac50-4ac9-9e7d-0cd4cf46df14"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3942), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("dec7e19b-55d9-4f8b-bd6d-5f3a18cd2337"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3920), true, null, "Can I visit the construction site during the project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("5571372b-f245-46bd-b64d-93490ea78ffc"), null, null, new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3696), "James", 0, new Guid("8ad95d41-b7d6-4337-87b5-b5c01b458d3a"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("a03f96f8-e05f-4912-abf2-2f2b624f518c"), null, null, new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3734), "Charles", 0, new Guid("12a91264-501b-4f8a-898a-f3cb7db87cdc"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12a91264-501b-4f8a-898a-f3cb7db87cdc"), 0, "4495a22a-0244-4082-8183-3716a7d57733", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEGd32kp3y0Pv+6PglsDgB6H8RYIn8kONClQIFa8QT2cOxp8zWWvsCzN/UqIN5Xq8nw==", "+639951225449", false, "0ac4a4ce-421e-7f25-6032-21d3e1f05cf6_20240627150243842", false, "ladonconst@gmail.com" },
                    { new Guid("8ad95d41-b7d6-4337-87b5-b5c01b458d3a"), 0, "4255fae2-5b50-4715-8b53-1852a91d78be", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDbEtQRyvFGHiTUUJF0z0wN13c7TUTf2NukDnve0s/7vkoJPOgqUxKcapPBqZlFsLQ==", "+639672814641", false, "0ac4a4ce-421e-7f25-6032-21d3e1f05cf6_20240627150243842", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("a6e6eab0-60cc-4c7b-9fa7-3dc1f44a8e3a"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3838), true, "8000", "Davao del Sur", new Guid("5571372b-f245-46bd-b64d-93490ea78ffc") },
                    { new Guid("e0ee1afc-f19c-476a-af69-0f0a1324047a"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 15, 2, 44, 0, DateTimeKind.Utc).AddTicks(3843), true, "8000", "Davao del Sur", new Guid("a03f96f8-e05f-4912-abf2-2f2b624f518c") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("c3d181e7-9a6e-40af-8e2e-a4b03ec5a3b5"), new Guid("3e4d3d76-f225-4fde-b911-7d1f1e47cea1") },
                    { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("4673cefc-da25-4c61-8241-fb3157870adb") },
                    { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new Guid("4673cefc-da25-4c61-8241-fb3157870adb") },
                    { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb") },
                    { new Guid("291c15b7-713f-4501-975f-ca989cb27732"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb") },
                    { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb") },
                    { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") },
                    { new Guid("753695de-84b5-4ca2-9d3b-acb299d88a28"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") },
                    { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") },
                    { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") },
                    { new Guid("087285ce-3b20-4553-9bbe-b542f6a92b78"), new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2") },
                    { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2") },
                    { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new Guid("e1573011-5e17-468c-8ed9-1a9614373433") },
                    { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("e1573011-5e17-468c-8ed9-1a9614373433") },
                    { new Guid("c3d181e7-9a6e-40af-8e2e-a4b03ec5a3b5"), new Guid("e33ff3a7-696a-4e90-b841-2e7e8bd78ebb") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("00bc68e1-c962-4804-b027-50192e48e176"), new Guid("6e5c1db0-0577-4c20-8e73-79099de912ae"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2455), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("2d758098-6341-4252-9754-41ce14024187"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2538), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("35adae22-aa7d-4f22-9fc1-2c31f32dcd84"), new Guid("e33ff3a7-696a-4e90-b841-2e7e8bd78ebb"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2598), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("39360051-b808-4363-af8e-98be57467ae6"), new Guid("e1573011-5e17-468c-8ed9-1a9614373433"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2425), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("3dcb67b5-9c4d-4953-9725-e14b6d62bf98"), new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2353), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("58b6b748-f0ee-4ee2-a9a1-58b19c6e88ba"), new Guid("3e4d3d76-f225-4fde-b911-7d1f1e47cea1"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2566), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("7bfd504c-501b-49f7-b414-3a3535d050e3"), new Guid("4673cefc-da25-4c61-8241-fb3157870adb"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2306), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("9909b640-4c03-47d6-b398-b04b39a7c6d3"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2506), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("e93deead-d6a2-4706-ae47-de043ff027c7"), new Guid("5fdd423d-3cae-446d-9adb-b0965fbfe79f"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2383), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("1deaa03a-b5e4-4d11-9867-272b80c75ff9"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2540), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("3ba43a16-893e-44b3-afad-5b9d57436fd9"), new Guid("5fdd423d-3cae-446d-9adb-b0965fbfe79f"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2394), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("6d50783a-9a85-48f9-9358-b4937c8e5b38"), new Guid("e1573011-5e17-468c-8ed9-1a9614373433"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2427), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("70a34340-5985-4342-9304-474aa3cfc5ff"), new Guid("6e5c1db0-0577-4c20-8e73-79099de912ae"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2459), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("aea33a84-6569-42d2-bb98-282ed634dca5"), new Guid("e33ff3a7-696a-4e90-b841-2e7e8bd78ebb"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2600), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("c8298e0e-6fdd-48b7-b064-a9781a302b61"), new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2356), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("dd636c69-24f0-44f9-9e45-c32daed9c7ed"), new Guid("4673cefc-da25-4c61-8241-fb3157870adb"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2319), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("e7506a61-8f20-40ca-95c6-730d30ee0ad2"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2508), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("fc23c30d-ee65-4572-be72-ee8e9a454db3"), new Guid("3e4d3d76-f225-4fde-b911-7d1f1e47cea1"), new DateTime(2024, 6, 27, 15, 2, 44, 3, DateTimeKind.Utc).AddTicks(2569), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "ImageSizeOrientationStyle", "IsActive" },
                values: new object[,]
                {
                    { new Guid("01456bf7-c315-46a1-a431-851ff5255157"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3270), new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", null, null, true },
                    { new Guid("01edae80-7240-4656-9095-29f572777b13"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3101), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", null, null, true },
                    { new Guid("021140ed-1b03-45fd-8bec-33abe1dbf952"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3187), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", null, null, true },
                    { new Guid("05a12120-8731-4430-a2ab-7c94d596e01c"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3969), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", null, null, true },
                    { new Guid("07572a6f-9749-4bb5-9645-0d5f1985645c"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4141), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", null, null, true },
                    { new Guid("0c769b7e-1ffd-466b-8d08-8b29e6d48413"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3612), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", null, null, true },
                    { new Guid("0db23449-5835-49ae-82b2-99865cbaa252"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4098), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", null, null, true },
                    { new Guid("0f78a95b-9cb3-4850-a4d1-31ebaa8b6e34"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3363), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", null, null, true },
                    { new Guid("0fad2d98-3f15-4fa1-a6b5-6fc9bab8d7a2"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2609), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", null, null, true },
                    { new Guid("0fe2f499-e2f6-4afe-b190-dd91d248f8b7"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3864), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", null, null, true },
                    { new Guid("11d63662-93e3-4841-b60d-efbf01b10413"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3562), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", null, null, true },
                    { new Guid("12020215-fd80-440a-932c-81f3a9988bef"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3263), new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", null, null, true },
                    { new Guid("15e3c40f-26dc-447e-9d4f-d2e06a029c5e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3847), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", null, null, true },
                    { new Guid("1669b5e6-62c4-4ee3-8b9d-15d473aece57"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2922), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", null, null, true },
                    { new Guid("16c5dde3-3dd0-4431-813d-f277e5b1b3bc"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3596), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", null, null, true },
                    { new Guid("1b277e08-e072-4ffb-b40f-6ec463044a19"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2369), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", null, null, true },
                    { new Guid("1bfe5cbc-972f-4e7b-b1a5-336b87174905"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4088), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", null, null, true },
                    { new Guid("1f8779d9-ec8a-4ce8-be08-6cf2b27ab570"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2759), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", null, null, true },
                    { new Guid("20517aa6-4627-4e1e-8b48-20d049a4a60f"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2927), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", null, null, true },
                    { new Guid("21f5da87-0429-4df4-8d44-a2757b694ab0"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3351), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", null, null, true },
                    { new Guid("2356db1a-7a8e-47db-9669-1869e6bf2553"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3091), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", null, null, true },
                    { new Guid("2651911e-6dc3-4ace-9af0-08318136c6c2"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3256), new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", null, null, true },
                    { new Guid("26dfe82c-6f92-4f54-9ebc-6c513116db0e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4120), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", null, null, true },
                    { new Guid("270cbf2f-3700-46b6-bbaf-35b1acf798d3"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3842), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", null, null, true },
                    { new Guid("2a4a27ad-8f67-4000-b054-54e27fcc3f1a"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3881), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", null, null, true },
                    { new Guid("2b0dc2da-7353-4922-b718-44687927e661"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2389), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", null, null, true },
                    { new Guid("2cce2c34-373b-41f0-a430-1b94d64f380f"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2514), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", null, null, true },
                    { new Guid("2cee5189-28a1-4265-86f2-68521a27c457"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3855), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", null, null, true },
                    { new Guid("2d611be2-43e5-4e59-ad68-0047f2d35c89"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2375), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", null, null, true },
                    { new Guid("2e133826-8fcf-4870-9f39-d9235c7a5839"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3368), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", null, null, true },
                    { new Guid("2e5b1f9e-ddec-40b4-a82c-b83f243a626a"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3891), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", null, null, true },
                    { new Guid("34ac7243-a3ac-4840-9299-c5fad1e3b403"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3110), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", null, null, true },
                    { new Guid("3ae9a79f-ebb0-4a99-b1ad-1ae622957bea"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3747), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", null, null, true },
                    { new Guid("3b517ad0-3fb1-488a-93ce-00b3906ec1a2"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2526), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", null, null, true },
                    { new Guid("3d8de316-b4a6-48dc-9afe-091a03fd2032"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3199), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", null, null, true },
                    { new Guid("401c8c44-7ca8-4acc-9dc1-586b46dea434"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2534), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", null, null, true },
                    { new Guid("40a79ed7-3cc0-43d5-804c-32070683845f"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3994), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", null, null, true },
                    { new Guid("41c0788c-8553-4136-994e-69dc72ae3901"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2775), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", null, null, true },
                    { new Guid("4261cb02-a4e1-42c6-9adf-7ffe8717237f"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2696), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", null, null, true },
                    { new Guid("43ab72ca-39be-4b01-bd32-3f82c337c0c7"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3206), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", null, null, true },
                    { new Guid("464d0faf-8f4d-4c38-b9ab-89081b1fa41f"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2917), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", null, null, true },
                    { new Guid("468eca80-0580-4809-9e6b-a919856803ce"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3447), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", null, null, true },
                    { new Guid("484730c4-130c-4cd5-9550-7f2c8d438f78"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2785), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", null, null, true },
                    { new Guid("484e14ab-8b3f-48f3-b4df-13e10986e787"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3464), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", null, null, true },
                    { new Guid("48ba5724-75cb-46e6-87ae-0a6799ecf4f4"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2911), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", null, null, true },
                    { new Guid("49648ce5-4dd4-4443-8a28-f65817a397ea"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4136), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", null, null, true },
                    { new Guid("4982dfdf-db61-4973-a319-bac74f82b367"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3285), new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", null, null, true },
                    { new Guid("498cb9a3-17dd-4aea-b139-7631cb2ddbe3"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2812), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", null, null, true },
                    { new Guid("4ceeebe7-93a7-4ef9-a8fc-0d0f9bb83e31"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2641), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", null, null, true },
                    { new Guid("4d7d5918-8d52-41e3-abdd-a5f116babf45"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4132), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", null, null, true },
                    { new Guid("4eb0bcd6-0097-4dde-b569-7806f5cfa1aa"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3725), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", null, null, true },
                    { new Guid("4ed1837d-f0fa-44cd-bd27-71bfbb8e239d"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4103), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", null, null, true },
                    { new Guid("4f6a2356-cabd-4eab-9c9c-31fb37ddc38d"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3733), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", null, null, true },
                    { new Guid("4fd7b419-140f-41ba-ad30-1a5793ff3789"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3194), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", null, null, true },
                    { new Guid("524453ef-359d-4c3a-b185-81cf66e96f63"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3481), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", null, null, true },
                    { new Guid("53578936-dbcd-4241-9dcc-d61a1b1acfa0"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2700), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", null, null, true },
                    { new Guid("548320e8-2134-443b-82a7-1bc1f18b93e5"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3837), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", null, null, true },
                    { new Guid("5894b2aa-0b6d-4343-bdcb-1a3a1ce39692"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3601), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", null, null, true },
                    { new Guid("5b25e61e-4f02-48c8-8a3a-fd10e15a6ca2"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2595), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", null, null, true },
                    { new Guid("5bd1942e-3252-4340-94c1-4e304fda2518"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2604), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", null, null, true },
                    { new Guid("5c5c53f5-7d7a-4955-86ea-0ae1f23b4d38"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2789), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", null, null, true },
                    { new Guid("5c8a5508-95b5-4a98-8848-366bf1ccdd52"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3571), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", null, null, true },
                    { new Guid("632878f5-4a22-48be-a8c7-5ca302b97518"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3070), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", null, null, true },
                    { new Guid("6381f862-eb89-4f8e-a51c-a3fd011105a7"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3586), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", null, null, true },
                    { new Guid("65684747-4372-425e-b58d-dfc5996edf73"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3489), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", null, null, true },
                    { new Guid("6639ab3f-6ec0-43b1-b680-42aef3a92af4"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2691), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", null, null, true },
                    { new Guid("6d46f685-0238-4de6-93c6-a1d09ce61e8c"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3622), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", null, null, true },
                    { new Guid("6df5436f-c102-4dfb-b14b-ad2b80275591"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3757), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", null, null, true },
                    { new Guid("6eeb7e4b-bad6-41e8-90f0-f3002222dbd0"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3389), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", null, null, true },
                    { new Guid("72e2aa0c-3625-41de-94fd-1404d955bc85"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4012), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", null, null, true },
                    { new Guid("769b646e-0225-477f-84ce-1888bc87efef"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2521), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", null, null, true },
                    { new Guid("77d6f1bb-e3fd-426b-875b-b0dcb9cac6c2"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3740), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", null, null, true },
                    { new Guid("7a9fb730-94b9-4243-ac21-f04532e923c0"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3179), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", null, null, true },
                    { new Guid("7c5a5934-5f3d-4607-b908-d6451723db1a"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2891), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", null, null, true },
                    { new Guid("7d162c56-64ce-4e0b-932d-4bcb39f2284e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3081), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", null, null, true },
                    { new Guid("7db07541-5746-44e5-9ffd-697b92761c76"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3375), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", null, null, true },
                    { new Guid("7ee5f5bc-5974-4c5c-a4c7-7a4ac43841c1"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3503), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", null, null, true },
                    { new Guid("7f1f81e1-c462-4626-aa6e-0c1df525fb99"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3441), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", null, null, true },
                    { new Guid("7f8d6785-9a78-4cdd-8116-1d0b7c2468f3"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2349), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", null, null, true },
                    { new Guid("8284c915-741c-4a24-b883-c9c31ae7ee4a"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2629), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", null, null, true },
                    { new Guid("8411ed96-1ac9-4cb3-8bf9-3c23272c2243"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2646), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", null, null, true },
                    { new Guid("8462a45f-0ed1-46e2-8968-d110cdc7290e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2931), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", null, null, true },
                    { new Guid("85b780fe-d916-4e29-9ad4-0a985f55ce8e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2765), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", null, null, true },
                    { new Guid("86de39fa-b3c3-4558-9aa8-cb2fd2dda8bf"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4093), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", null, null, true },
                    { new Guid("87e77d3c-0cdf-4eb3-9fb5-d57b06076ef5"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3983), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", null, null, true },
                    { new Guid("8f9b1f84-7ead-49ce-85bc-05cf62bcef46"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2680), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", null, null, true },
                    { new Guid("8fc7e7b6-658c-4ebf-8c3b-944923f590b1"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2384), new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", null, null, true },
                    { new Guid("8fe6ff5b-4858-4a61-bccb-588210238e62"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2675), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", null, null, true },
                    { new Guid("9250f4e2-1cad-4194-8e5c-5065e240c3c9"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2905), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", null, null, true },
                    { new Guid("92c4eee5-3004-4db4-9208-b65b9e8ed01f"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3828), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", null, null, true },
                    { new Guid("98c40df4-ea78-4e20-ae39-06feb0840daa"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3452), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", null, null, true },
                    { new Guid("9f70867b-840a-43cc-94f5-14ab81f0c16e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2619), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", null, null, true },
                    { new Guid("a3a92511-06af-4edd-8a4d-078cea439f8b"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3887), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", null, null, true },
                    { new Guid("a60c95cd-2645-457f-a893-77f9a5907c83"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3275), new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", null, null, true },
                    { new Guid("a6535537-12b2-4857-8ddb-95ba1084f911"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4072), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", null, null, true },
                    { new Guid("a742c064-6bb3-44f5-91e1-6026731ae9cb"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2770), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", null, null, true },
                    { new Guid("a7766128-075e-47c1-9373-6db3d081cf72"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3958), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", null, null, true },
                    { new Guid("a86d4d66-ec86-4106-baad-78da04b12d37"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4116), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", null, null, true },
                    { new Guid("a945391a-2e33-438e-8863-46096a77dc39"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3460), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", null, null, true },
                    { new Guid("a95512d5-9214-4223-bf9c-aa7774a289bc"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3096), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", null, null, true },
                    { new Guid("af2f78ef-0510-427a-be5b-c17d91a0c599"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3356), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", null, null, true },
                    { new Guid("b2ff316b-dc4e-4d75-b69e-87e41553d5ac"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3115), new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", null, null, true },
                    { new Guid("b7216444-7e70-4d97-af9e-ce2e8a0f8710"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3494), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", null, null, true },
                    { new Guid("b93e3d22-8566-4ec7-8c20-d8cc56b405fc"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3280), new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", null, null, true },
                    { new Guid("b973024c-62d5-490b-8eb9-9638b7cec1fd"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2900), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", null, null, true },
                    { new Guid("bf12f8c2-7d04-4fa1-b1d0-61ad38f0254b"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4111), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", null, null, true },
                    { new Guid("c39fa3db-9562-481d-8048-ee6d1affd818"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3871), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", null, null, true },
                    { new Guid("c472daae-9bab-4343-bc08-a2d962e2fdf3"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3776), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", null, null, true },
                    { new Guid("cd38c193-09d7-4081-9536-8d4195b67201"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3170), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", null, null, true },
                    { new Guid("cd688932-3b93-4966-9ae2-c5eca344db99"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3713), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", null, null, true },
                    { new Guid("d0c7f7af-123a-4f78-8ef1-a31f6b8732a7"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3212), new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", null, null, true },
                    { new Guid("d32e0027-53c0-4f60-83e1-6abbdd3b72af"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3617), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", null, null, true },
                    { new Guid("d5b2eb79-f062-432c-9ff8-415b31230029"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3989), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", null, null, true },
                    { new Guid("d8651ffc-e3d2-42c5-9b62-a69266b5e458"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2779), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", null, null, true },
                    { new Guid("db1bd362-2908-447a-ad2c-1cf04e85b2c6"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3395), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", null, null, true },
                    { new Guid("ddd9579c-8b9a-402b-a937-c9c92954c3c8"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3384), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", null, null, true },
                    { new Guid("de13acaf-0ac2-4867-bcce-e831f57e45d5"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3590), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", null, null, true },
                    { new Guid("e0753240-5a88-4736-8cd1-9e589c17ec35"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3762), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", null, null, true },
                    { new Guid("e263310d-a543-4a02-8e9e-ebcea471fb9b"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3507), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", null, null, true },
                    { new Guid("e29f2568-0cc5-4e4e-b25d-ef71dee44ae0"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3379), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", null, null, true },
                    { new Guid("e36ffbdc-888d-40fe-8511-de73809809c4"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3469), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", null, null, true },
                    { new Guid("e3e4b9d4-1b11-4a19-b7f0-0c2827194566"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2885), new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", null, null, true },
                    { new Guid("e942a883-ff9f-438e-b11b-03631d7b76bd"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4079), new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", null, null, true },
                    { new Guid("ea88a244-0a6b-4b38-a26a-5b17f95ead0b"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2705), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", null, null, true },
                    { new Guid("ecbf0aee-fd5d-4c8d-a39a-b2130dff178a"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3578), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", null, null, true },
                    { new Guid("ee586365-caa2-4398-8e99-f066438d69da"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3337), new Guid("e60ca39b-e156-463b-a772-0d38808c9298"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", null, null, true },
                    { new Guid("ee95926a-9df3-46b1-a6c3-c58b34099ec0"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2806), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", null, null, true },
                    { new Guid("eeb1b79c-43b5-4b58-8a86-9099a3b89ddc"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(4004), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", null, null, true },
                    { new Guid("eee1bf45-199c-47c4-b650-681f42dc6f00"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3769), new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", null, null, true },
                    { new Guid("f41df26a-a2b0-4377-a041-0413b778a141"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3974), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", null, null, true },
                    { new Guid("f4f65e79-43ea-485e-a382-b8dbac9bfc11"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2624), new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", null, null, true },
                    { new Guid("f5761559-31a3-4f83-a71a-93fd1b87ebc7"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3979), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", null, null, true },
                    { new Guid("f8ce2811-f9f7-4a2a-a0b0-4d5fd6975591"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3474), new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", null, null, true },
                    { new Guid("f980b445-47c1-43a2-9c4e-946adfb03d0e"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3999), new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", null, null, true },
                    { new Guid("fc513e4d-9257-4337-ba87-cc787e4f947b"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(2818), new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", null, null, true },
                    { new Guid("fcf824de-53d2-4a1d-847e-6d60b4f57cc1"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3606), new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", null, null, true },
                    { new Guid("fefcbf1d-1ccf-4cd8-8b40-d28ccec4cede"), new DateTime(2024, 6, 27, 15, 2, 44, 4, DateTimeKind.Utc).AddTicks(3876), new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", null, null, true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a2ee09e-8b6e-4315-b568-6eb672bc7686"), new Guid("12a91264-501b-4f8a-898a-f3cb7db87cdc") },
                    { new Guid("08e3b61a-ace1-47fd-879b-4dfc64d7cc36"), new Guid("8ad95d41-b7d6-4337-87b5-b5c01b458d3a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("a6e6eab0-60cc-4c7b-9fa7-3dc1f44a8e3a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e0ee1afc-f19c-476a-af69-0f0a1324047a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("003d4b1d-cf4f-4fba-bb41-bb47279a8c86"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("124a2e3b-d087-4d34-a00d-4675494e9d09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("208da59b-b93f-4e08-84d1-2ad841fc396b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2100a397-cfd5-4b49-9afd-315e757a709a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("221004c4-0db1-496b-b281-7ccd514c1eda"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("22685de2-797a-414a-960b-894d44010810"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("27855490-00e7-42bc-9263-71b8c996e6d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("27862994-bf87-4ec1-9a40-88d4a8e3e424"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("29d4a1da-d255-48f0-a96a-4971ca9d6fc1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("29d9a3c4-101b-4ea2-8972-62b2494d83d1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("337bb2d4-d3b1-4435-a347-4c4696dee894"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("36ed735f-34c4-40e6-ab51-95ace5083077"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3f05300e-4174-4f18-a4e9-90c6278414a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("559eb064-0026-4302-9560-6b2668c26eb3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5c6b7f0f-151f-4571-86a1-05d80542787f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6131f955-5828-461d-8d25-69a1313d68b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("75a62566-cbaa-4970-b0ef-23e6dd72fbbb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7a64ba27-5e51-4eed-af30-fc9a026f6f0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8638b69c-b71c-4cdf-b0fd-dcb765e8ccab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("867d4fc6-93d5-41c5-9fbe-5fc1c5e5df03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("90cebbd3-3095-4f24-95ed-9707c405f945"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("949d9b22-25bb-4007-98c0-d4e7f7cde07c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("94b0cb3c-7153-42c3-a11f-be5d655dfa2d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a23d84ab-a78d-4f01-b0af-30977e5bd922"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("aab9be11-bde1-43d2-a9c3-0a10b879dfb0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ac5a73b9-8362-42f9-8510-3d1eb542a687"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b218caee-80cd-4b0a-93f1-a79a8a88858c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b5ef7aad-cf22-4313-88f3-c6ad3f8abc82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c4593a32-1c57-4f59-85b4-4f776ba9acdc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e2db3d18-aa26-4994-81a0-1df9d216de78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f3708802-01c8-4a75-b981-adb8dc303aa5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f5d9f166-e566-45d5-8106-f6fed4d79da3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f7648c8e-4af4-4557-bba7-7e23228458e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c3d181e7-9a6e-40af-8e2e-a4b03ec5a3b5"), new Guid("3e4d3d76-f225-4fde-b911-7d1f1e47cea1") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("4673cefc-da25-4c61-8241-fb3157870adb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new Guid("4673cefc-da25-4c61-8241-fb3157870adb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("291c15b7-713f-4501-975f-ca989cb27732"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("753695de-84b5-4ca2-9d3b-acb299d88a28"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new Guid("99a166bb-af49-4849-aeac-63e5ea49507c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("087285ce-3b20-4553-9bbe-b542f6a92b78"), new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"), new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("14ab79fa-b286-499a-b163-025ee58dba56"), new Guid("e1573011-5e17-468c-8ed9-1a9614373433") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"), new Guid("e1573011-5e17-468c-8ed9-1a9614373433") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c3d181e7-9a6e-40af-8e2e-a4b03ec5a3b5"), new Guid("e33ff3a7-696a-4e90-b841-2e7e8bd78ebb") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("00bc68e1-c962-4804-b027-50192e48e176"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("2d758098-6341-4252-9754-41ce14024187"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("35adae22-aa7d-4f22-9fc1-2c31f32dcd84"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("39360051-b808-4363-af8e-98be57467ae6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("3dcb67b5-9c4d-4953-9725-e14b6d62bf98"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("58b6b748-f0ee-4ee2-a9a1-58b19c6e88ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("7bfd504c-501b-49f7-b414-3a3535d050e3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("9909b640-4c03-47d6-b398-b04b39a7c6d3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("e93deead-d6a2-4706-ae47-de043ff027c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("1deaa03a-b5e4-4d11-9867-272b80c75ff9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("3ba43a16-893e-44b3-afad-5b9d57436fd9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("6d50783a-9a85-48f9-9358-b4937c8e5b38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("70a34340-5985-4342-9304-474aa3cfc5ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("aea33a84-6569-42d2-bb98-282ed634dca5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("c8298e0e-6fdd-48b7-b064-a9781a302b61"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("dd636c69-24f0-44f9-9e45-c32daed9c7ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("e7506a61-8f20-40ca-95c6-730d30ee0ad2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("fc23c30d-ee65-4572-be72-ee8e9a454db3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("612ddaaa-4f8e-4775-93c6-1c3843c24487"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("78ffd478-d17d-4a3c-bc7e-fb8d67a0f4d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c732a579-6201-4e45-9a05-249b76d371c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ed71d59f-3ffb-439d-9b5f-7b4ba4f5acc7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("201a2240-3a8a-4891-b96c-05eb15de57f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("39f92031-42e2-474f-a7f5-a44c6b3c2682"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("88145fcd-b37a-43ac-9a08-34c04d571d1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("e5aace86-5efa-4001-9177-b26d704e6c20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("01456bf7-c315-46a1-a431-851ff5255157"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("01edae80-7240-4656-9095-29f572777b13"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("021140ed-1b03-45fd-8bec-33abe1dbf952"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("05a12120-8731-4430-a2ab-7c94d596e01c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("07572a6f-9749-4bb5-9645-0d5f1985645c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0c769b7e-1ffd-466b-8d08-8b29e6d48413"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0db23449-5835-49ae-82b2-99865cbaa252"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0f78a95b-9cb3-4850-a4d1-31ebaa8b6e34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0fad2d98-3f15-4fa1-a6b5-6fc9bab8d7a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0fe2f499-e2f6-4afe-b190-dd91d248f8b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("11d63662-93e3-4841-b60d-efbf01b10413"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("12020215-fd80-440a-932c-81f3a9988bef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("15e3c40f-26dc-447e-9d4f-d2e06a029c5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1669b5e6-62c4-4ee3-8b9d-15d473aece57"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("16c5dde3-3dd0-4431-813d-f277e5b1b3bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1b277e08-e072-4ffb-b40f-6ec463044a19"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1bfe5cbc-972f-4e7b-b1a5-336b87174905"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1f8779d9-ec8a-4ce8-be08-6cf2b27ab570"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("20517aa6-4627-4e1e-8b48-20d049a4a60f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("21f5da87-0429-4df4-8d44-a2757b694ab0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2356db1a-7a8e-47db-9669-1869e6bf2553"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2651911e-6dc3-4ace-9af0-08318136c6c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("26dfe82c-6f92-4f54-9ebc-6c513116db0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("270cbf2f-3700-46b6-bbaf-35b1acf798d3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2a4a27ad-8f67-4000-b054-54e27fcc3f1a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2b0dc2da-7353-4922-b718-44687927e661"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2cce2c34-373b-41f0-a430-1b94d64f380f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2cee5189-28a1-4265-86f2-68521a27c457"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2d611be2-43e5-4e59-ad68-0047f2d35c89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2e133826-8fcf-4870-9f39-d9235c7a5839"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2e5b1f9e-ddec-40b4-a82c-b83f243a626a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("34ac7243-a3ac-4840-9299-c5fad1e3b403"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3ae9a79f-ebb0-4a99-b1ad-1ae622957bea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3b517ad0-3fb1-488a-93ce-00b3906ec1a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3d8de316-b4a6-48dc-9afe-091a03fd2032"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("401c8c44-7ca8-4acc-9dc1-586b46dea434"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("40a79ed7-3cc0-43d5-804c-32070683845f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("41c0788c-8553-4136-994e-69dc72ae3901"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4261cb02-a4e1-42c6-9adf-7ffe8717237f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("43ab72ca-39be-4b01-bd32-3f82c337c0c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("464d0faf-8f4d-4c38-b9ab-89081b1fa41f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("468eca80-0580-4809-9e6b-a919856803ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("484730c4-130c-4cd5-9550-7f2c8d438f78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("484e14ab-8b3f-48f3-b4df-13e10986e787"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("48ba5724-75cb-46e6-87ae-0a6799ecf4f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("49648ce5-4dd4-4443-8a28-f65817a397ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4982dfdf-db61-4973-a319-bac74f82b367"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("498cb9a3-17dd-4aea-b139-7631cb2ddbe3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4ceeebe7-93a7-4ef9-a8fc-0d0f9bb83e31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4d7d5918-8d52-41e3-abdd-a5f116babf45"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4eb0bcd6-0097-4dde-b569-7806f5cfa1aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4ed1837d-f0fa-44cd-bd27-71bfbb8e239d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4f6a2356-cabd-4eab-9c9c-31fb37ddc38d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4fd7b419-140f-41ba-ad30-1a5793ff3789"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("524453ef-359d-4c3a-b185-81cf66e96f63"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("53578936-dbcd-4241-9dcc-d61a1b1acfa0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("548320e8-2134-443b-82a7-1bc1f18b93e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5894b2aa-0b6d-4343-bdcb-1a3a1ce39692"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5b25e61e-4f02-48c8-8a3a-fd10e15a6ca2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5bd1942e-3252-4340-94c1-4e304fda2518"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5c5c53f5-7d7a-4955-86ea-0ae1f23b4d38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5c8a5508-95b5-4a98-8848-366bf1ccdd52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("632878f5-4a22-48be-a8c7-5ca302b97518"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6381f862-eb89-4f8e-a51c-a3fd011105a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("65684747-4372-425e-b58d-dfc5996edf73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6639ab3f-6ec0-43b1-b680-42aef3a92af4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6d46f685-0238-4de6-93c6-a1d09ce61e8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6df5436f-c102-4dfb-b14b-ad2b80275591"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6eeb7e4b-bad6-41e8-90f0-f3002222dbd0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("72e2aa0c-3625-41de-94fd-1404d955bc85"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("769b646e-0225-477f-84ce-1888bc87efef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("77d6f1bb-e3fd-426b-875b-b0dcb9cac6c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7a9fb730-94b9-4243-ac21-f04532e923c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7c5a5934-5f3d-4607-b908-d6451723db1a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7d162c56-64ce-4e0b-932d-4bcb39f2284e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7db07541-5746-44e5-9ffd-697b92761c76"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7ee5f5bc-5974-4c5c-a4c7-7a4ac43841c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7f1f81e1-c462-4626-aa6e-0c1df525fb99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7f8d6785-9a78-4cdd-8116-1d0b7c2468f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8284c915-741c-4a24-b883-c9c31ae7ee4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8411ed96-1ac9-4cb3-8bf9-3c23272c2243"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8462a45f-0ed1-46e2-8968-d110cdc7290e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("85b780fe-d916-4e29-9ad4-0a985f55ce8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("86de39fa-b3c3-4558-9aa8-cb2fd2dda8bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("87e77d3c-0cdf-4eb3-9fb5-d57b06076ef5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8f9b1f84-7ead-49ce-85bc-05cf62bcef46"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8fc7e7b6-658c-4ebf-8c3b-944923f590b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8fe6ff5b-4858-4a61-bccb-588210238e62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9250f4e2-1cad-4194-8e5c-5065e240c3c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("92c4eee5-3004-4db4-9208-b65b9e8ed01f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("98c40df4-ea78-4e20-ae39-06feb0840daa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9f70867b-840a-43cc-94f5-14ab81f0c16e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a3a92511-06af-4edd-8a4d-078cea439f8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a60c95cd-2645-457f-a893-77f9a5907c83"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a6535537-12b2-4857-8ddb-95ba1084f911"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a742c064-6bb3-44f5-91e1-6026731ae9cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a7766128-075e-47c1-9373-6db3d081cf72"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a86d4d66-ec86-4106-baad-78da04b12d37"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a945391a-2e33-438e-8863-46096a77dc39"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a95512d5-9214-4223-bf9c-aa7774a289bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("af2f78ef-0510-427a-be5b-c17d91a0c599"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b2ff316b-dc4e-4d75-b69e-87e41553d5ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b7216444-7e70-4d97-af9e-ce2e8a0f8710"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b93e3d22-8566-4ec7-8c20-d8cc56b405fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b973024c-62d5-490b-8eb9-9638b7cec1fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bf12f8c2-7d04-4fa1-b1d0-61ad38f0254b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c39fa3db-9562-481d-8048-ee6d1affd818"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c472daae-9bab-4343-bc08-a2d962e2fdf3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd38c193-09d7-4081-9536-8d4195b67201"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd688932-3b93-4966-9ae2-c5eca344db99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d0c7f7af-123a-4f78-8ef1-a31f6b8732a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d32e0027-53c0-4f60-83e1-6abbdd3b72af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d5b2eb79-f062-432c-9ff8-415b31230029"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d8651ffc-e3d2-42c5-9b62-a69266b5e458"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("db1bd362-2908-447a-ad2c-1cf04e85b2c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ddd9579c-8b9a-402b-a937-c9c92954c3c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("de13acaf-0ac2-4867-bcce-e831f57e45d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e0753240-5a88-4736-8cd1-9e589c17ec35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e263310d-a543-4a02-8e9e-ebcea471fb9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e29f2568-0cc5-4e4e-b25d-ef71dee44ae0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e36ffbdc-888d-40fe-8511-de73809809c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e3e4b9d4-1b11-4a19-b7f0-0c2827194566"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e942a883-ff9f-438e-b11b-03631d7b76bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ea88a244-0a6b-4b38-a26a-5b17f95ead0b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ecbf0aee-fd5d-4c8d-a39a-b2130dff178a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ee586365-caa2-4398-8e99-f066438d69da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ee95926a-9df3-46b1-a6c3-c58b34099ec0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eeb1b79c-43b5-4b58-8a86-9099a3b89ddc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eee1bf45-199c-47c4-b650-681f42dc6f00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f41df26a-a2b0-4377-a041-0413b778a141"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f4f65e79-43ea-485e-a382-b8dbac9bfc11"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f5761559-31a3-4f83-a71a-93fd1b87ebc7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f8ce2811-f9f7-4a2a-a0b0-4d5fd6975591"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f980b445-47c1-43a2-9c4e-946adfb03d0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fc513e4d-9257-4337-ba87-cc787e4f947b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fcf824de-53d2-4a1d-847e-6d60b4f57cc1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fefcbf1d-1ccf-4cd8-8b40-d28ccec4cede"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("011cfda4-3035-435a-9799-d0f6b37de6cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0e52f28c-042f-4f68-8501-0b25b3fab6a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("10d2c4df-f258-4a58-b0d2-903844f5df72"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1e348ebc-70c6-4381-a34f-9e0b6ef8a28f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2a4ab07f-201e-42be-9906-6e394f8001b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("352063d8-5c2d-4d78-87c8-b493371f45f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("395489ca-5ac5-4508-94f1-59df021dcf3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("52791d02-8a21-4ed2-9730-c10c9c952307"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5dd27602-2a70-4750-bbee-87cb24ac7d17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7bac67bc-fd40-4880-8127-349262f96c73"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7d1565d6-8d3a-40a6-9373-2890e92ce5b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7d614874-f080-4701-82c3-b5a974bc303c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8637904e-b4e8-4b34-99da-dfc45e01115d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("98026b26-99a7-4710-9e10-c99dff0c0c8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9e5793c8-c7b9-40a5-adf9-f607ba8b8ad7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a023f8ec-a3b4-47f2-96d2-ad64460d9af9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a2fadd41-4e3f-4856-bec9-75e5c828ea93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c5136fc4-1329-436d-afb3-ac1103887570"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c6c4eacd-f3d8-42c2-ad06-fffe3a1f4dfe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("ce06566d-d70d-42f0-8880-b57136dd65e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d6ad8be8-ac50-4ac9-9e7d-0cd4cf46df14"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("dec7e19b-55d9-4f8b-bd6d-5f3a18cd2337"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0a2ee09e-8b6e-4315-b568-6eb672bc7686"), new Guid("12a91264-501b-4f8a-898a-f3cb7db87cdc") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("08e3b61a-ace1-47fd-879b-4dfc64d7cc36"), new Guid("8ad95d41-b7d6-4337-87b5-b5c01b458d3a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("087285ce-3b20-4553-9bbe-b542f6a92b78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("14ab79fa-b286-499a-b163-025ee58dba56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("291c15b7-713f-4501-975f-ca989cb27732"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("753695de-84b5-4ca2-9d3b-acb299d88a28"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("af991d6b-815a-47b2-a27c-fb9aa12a297c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c3d181e7-9a6e-40af-8e2e-a4b03ec5a3b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("daaa23a5-a015-4ab0-92e0-589d4828b1e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("3e4d3d76-f225-4fde-b911-7d1f1e47cea1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("4673cefc-da25-4c61-8241-fb3157870adb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("5fdd423d-3cae-446d-9adb-b0965fbfe79f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("6e5c1db0-0577-4c20-8e73-79099de912ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("71ca8680-397c-4db3-adf5-c6a5626a1bfb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("99a166bb-af49-4849-aeac-63e5ea49507c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("b8d3ff2f-ef76-4c2a-b6a6-5f0ecb4e15b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("e1573011-5e17-468c-8ed9-1a9614373433"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("e33ff3a7-696a-4e90-b841-2e7e8bd78ebb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("08e3b61a-ace1-47fd-879b-4dfc64d7cc36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0a2ee09e-8b6e-4315-b568-6eb672bc7686"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("0b8b203b-0092-4094-a3ce-c2b3dd47c861"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("2160b8b6-e6d4-4fce-8a1b-0435247bd206"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("25a52b2c-c109-4ba9-b1c3-7b1dfa856e65"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("25b1f6a3-87a4-4720-b609-dcb5bf317bc3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("284ae86e-6c8b-4c37-a939-5913edd1ceb7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("2c23428a-b0c2-48ae-9936-7eacc999a8b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("59d685d5-7452-4bb4-bf21-8f9a159b25a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("5a620593-d5bc-46df-8697-f6ba45b28507"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("613c4768-8d7c-48a1-8d39-984fb15b03ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("871e4357-272e-436f-8eb3-cff1ca7d9a9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("8ad56572-fb03-44c3-9ecc-3e25e0613b4f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("96d984c4-dadb-4c80-a7b2-4f9ceb4051f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("d9e53a85-0aba-4e7e-a6d3-78c0779c8236"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("e60ca39b-e156-463b-a772-0d38808c9298"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("5571372b-f245-46bd-b64d-93490ea78ffc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("a03f96f8-e05f-4912-abf2-2f2b624f518c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12a91264-501b-4f8a-898a-f3cb7db87cdc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ad95d41-b7d6-4337-87b5-b5c01b458d3a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 265, DateTimeKind.Local).AddTicks(6187),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 824, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(6429),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 839, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(3500),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 840, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(6942),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(8916),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(1508),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.AddColumn<bool>(
                name: "HideTitle",
                schema: "dbo",
                table: "FeatureProjects",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 842, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(9747),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 267, DateTimeKind.Local).AddTicks(2111),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(83),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(2902),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 275, DateTimeKind.Local).AddTicks(8572),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("145a78d1-4e25-41a3-9e54-1c4c95366a7e"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5498), true, "Training and Certification" },
                    { new Guid("186cd40b-b1e5-4faf-9441-df4f6ee04645"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5492), true, "Sustainability and Green Building" },
                    { new Guid("2f757eae-536c-4ff4-990d-b376920ec149"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5372), true, "Customer Stories and Interviews" },
                    { new Guid("36f41cde-3148-4164-aba9-64081a1d630b"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5443), true, "Disaster Preparedness and Recovery" },
                    { new Guid("434fb5c1-16d2-447a-a441-a1566905d43e"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5466), true, "Innovation and Future Trends" },
                    { new Guid("48824ae4-efb5-47bc-bf85-ec85e71f0a1a"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5488), true, "Smart Home Technology" },
                    { new Guid("5217fc68-adaf-4441-86a1-1539e7449e70"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5460), true, "Historic Preservation" },
                    { new Guid("56d5a7b8-654d-4a13-938d-3a65c17b8c92"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5353), true, "Community and Culture" },
                    { new Guid("5787da6b-c4ba-406a-ad86-a7810fefc1c9"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5478), true, "Modular and Prefabricated Construction" },
                    { new Guid("57bcc92a-1247-4cdc-9726-ad8f4dfeeec2"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5351), true, "Client Resources" },
                    { new Guid("5e3c6372-a798-4b80-8b4f-e5cfe895faae"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5374), true, "Design and Architecture" },
                    { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5464), true, "Industry News" },
                    { new Guid("6c959efb-cc98-4b2d-baa3-f2ece0172e60"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5361), true, "Construction Finance" },
                    { new Guid("6e834efd-5ae7-4dc1-aa7c-6aa5d1c55b99"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5455), true, "Health and Wellness in Construction" },
                    { new Guid("6fb47659-0dc8-4c79-a14f-34012e405e34"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5367), true, "Cost Estimation and Budgeting" },
                    { new Guid("76c78346-e7fc-4329-b3bb-c4a21dd6ee17"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5468), true, "Innovation Awards and Recognitions" },
                    { new Guid("7ccabd63-4a22-4534-acaf-283cd45b59d6"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5341), true, "Case Studies and Success Stories" },
                    { new Guid("802481ab-5a9a-4fb2-b8d0-482f796dcb74"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5470), true, "Landscaping and Outdoor Design" },
                    { new Guid("865deddd-d238-44d5-b234-13b10ad9060d"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5480), true, "Project Showcase" },
                    { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5343), true, "Client Education" },
                    { new Guid("8aeb3798-11b8-4e47-ac7a-da91f2331464"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5445), true, "Energy Efficiency" },
                    { new Guid("8fc3596b-b17d-4437-a550-c34077d13f1b"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5339), true, "Building Codes and Standards" },
                    { new Guid("8fd16908-d186-498a-a593-be3e9f1cda7b"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5490), true, "Supply Chain and Logistics" },
                    { new Guid("91f87b28-e3ea-4acf-9b31-6ec89c8ef6ff"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5482), true, "Property Management" },
                    { new Guid("95329d67-a4bd-4eec-8a4a-afb50358f9bc"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5502), true, "Weather and Seasonal Tips" },
                    { new Guid("95b4837a-44db-4589-90bb-5578b8c20d14"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5448), true, "Environmental Impact" },
                    { new Guid("a1d11c68-89a2-456f-95cf-48a350084822"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5462), true, "Home Improvement and DIY" },
                    { new Guid("b3210304-7b88-48b0-b5d7-773699b041dd"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5486), true, "Safety and Compliance" },
                    { new Guid("b4bc7bae-39e7-4f9e-86d2-34c354a67683"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5363), true, "Construction Management" },
                    { new Guid("b6f4d811-2d27-4881-ac68-6d9fe89dfb83"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5472), true, "Legal and Insurance" },
                    { new Guid("bad5ffef-bf30-4312-ab11-fe3934ecdc67"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5308), true, "Accessibility in Construction" },
                    { new Guid("c4ab4d76-162e-4d93-b7ae-9ca220bc30c6"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5358), true, "Construction Careers" },
                    { new Guid("c67f16cf-fdcb-4226-a8b5-a92741cc8c1d"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5500), true, "Urban Planning and Development" },
                    { new Guid("c9f40545-e0d8-4a4a-9c9a-c35cb5aa36c6"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5365), true, "Construction Techniques" },
                    { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5356), true, "Company Updates" },
                    { new Guid("dd843a51-118c-4d73-8f22-357f52033105"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5496), true, "Technology in Construction" },
                    { new Guid("e094938c-4f0d-4d81-bde1-31e7af9a5226"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5484), true, "Real Estate Development" },
                    { new Guid("f0bcd3b9-2f7a-4069-b54d-00e283245b9a"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5474), true, "Materials and Equipment" },
                    { new Guid("f5839e17-7405-4ae0-ae57-6e6836252b4f"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5451), true, "Equipment Maintenance" },
                    { new Guid("f660e80f-94f3-4258-848e-fa0792ea3771"), new DateTime(2024, 6, 27, 8, 15, 41, 279, DateTimeKind.Utc).AddTicks(5453), true, "Green Building Materials" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("25385761-1d29-4ff2-9e1c-e2b7307799b9"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3098), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2883), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("4a6fbb99-c779-4df7-8243-504f20c8ee23"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3135), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("55fe0db0-59a0-4832-bf2a-3353fdae42d6"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2924), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("634c9bee-0716-42c8-902c-fae0a0e0bf5d"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2847), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3058), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2419), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2965), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2797), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0e0232c7-8f8e-40e2-875a-0fd23b9ea463"), null, "Client", "CLIENT" },
                    { new Guid("225e1684-8841-4fe6-919c-0a6a4f86bdef"), null, "Moderator", "MODERATOR" },
                    { new Guid("6b4a82b1-0416-42b1-8315-a136518686df"), null, "Manager", "MANAGER" },
                    { new Guid("7ad51824-59a3-42f2-ac53-b0f33cc5f8f1"), null, "Visitor", "VISITOR" },
                    { new Guid("b136bc30-3de1-4862-8199-135ee9b058c0"), null, "Admin", "ADMIN" },
                    { new Guid("be9abc21-253d-454e-83dd-93acee7f3120"), null, "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("40af0364-1e08-4a68-b485-3e5fca9013cb"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3784), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("7fa7be84-2289-469a-ba5b-e53eb610dfff"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3801), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("89794019-72c6-4cd7-8b0a-e10482e2f620"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3796), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("a326b88e-7c20-4db0-ac99-6fb754c7e1c6"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3798), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "HideTitle", "ImageCDNUrl", "IsActive", "Location", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), null, new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5264), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "um-library-fire-protection-pbax-paging-systems-project", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5877), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", true, "Davao City", "verdon-park-condominium", "Verdon Park Condominium" },
                    { new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), null, new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4533), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "ladon-construction-service-davao-city-headquarter-office", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5737), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "muntinlupa-lds-chapel-elevator-project", "Muntinlupa LDS Chapel Elevator Project" },
                    { new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5416), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "carmen-lds-chapel-general-repainting-electrical-works", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), null, new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5024), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", true, "Philippines", "company-workforce", "Company Workforce" },
                    { new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5973), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "san-pedro-laguna-lds-chapel", "San Pedro Laguna LDS Chapel" },
                    { new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), null, new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5174), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "lds-church-improvements", "LDS Church Improvements" },
                    { new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), null, new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5597), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", true, "Sasa. Davao City, Philippines", "sasa-lds-chapel-general-repainting-retiling-works", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6335), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "lds-chapel-retaining-wall-construction", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6240), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "general-milling-station", "General Milling Station" },
                    { new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6076), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "aringay-lds-chapel-retiling-and-repainting-works", "Aringay LDS Chapel Retiling and Repainting Works" },
                    { new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6433), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "talavera-chapel-general-repair-works", "Talavera Chapel General Repair Works" },
                    { new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5675), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "mang-inasal", "Mang Inasal" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("00e3029c-2e5b-4937-8d73-1fa752e1b8dd"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5874), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("0c54eb72-71b1-45b2-bac9-cdbac8378e33"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5840), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("0db65cc9-6f07-4124-985f-fadb814d4c84"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5846), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("3707ae88-f9b4-4ba7-ab31-31661a0d3d93"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5882), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("5a0e7d29-bf38-4bda-ae22-8333bc2f6c3d"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5865), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("695eca77-0804-429b-93a0-f2fc621169a2"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5886), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("846e5ea2-3050-4ef9-a1b5-854f96d76b55"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5878), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("8f6b1f80-b5aa-4c85-9199-e41080dde5f9"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5838), true, true, "How do you handle project timelines?", null },
                    { new Guid("903771fa-f815-4e06-875c-0acb229b2988"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5836), true, null, "How can I get a quote for my project?", null },
                    { new Guid("9cdd8138-9d9a-4084-979e-6562fdea881f"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5862), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("bf03788a-c5c2-436b-a1db-4e7b1e1dd285"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5826), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("c49a1b50-9dde-43d9-8416-82a03caf30c1"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5876), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("cff94fa3-4e25-47d0-a2b6-bec2aef7395c"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5850), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("d03683ff-2cd7-4f6e-ba3c-80979d789545"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5844), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("d4a99bdd-1b8c-4dd3-8116-2c630ae76640"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5860), true, null, "How do I pay for my project?", null },
                    { new Guid("d616726c-bfcd-49bc-98bd-a95a311d548e"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5821), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("d81e0dae-2933-4043-9042-de121730e9fc"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5888), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("d8c4e52e-1816-4133-b1c3-9a743afd775b"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5872), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("dd02ac62-d2c1-43ab-92bd-b0ead5ac7eff"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5884), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("e0d4ff6f-0a68-4828-a424-13a047c3c79b"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5842), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("e637e42b-1a25-45b6-8357-25a63348f48e"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5848), true, null, "Do you offer financing options?", null },
                    { new Guid("f75569ce-d4ef-4934-8411-1758ca09e104"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5870), true, true, "Are you licensed and insured?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("8d887094-7226-4a33-be06-0e88a1ef12a0"), null, null, new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(3498), "James", 0, new Guid("234b2000-3d0d-471e-a2cb-5c70d700ddd4"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("ae83df8f-9ddb-4d0e-a0f1-1e5ace2c08fb"), null, null, new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(3542), "Charles", 0, new Guid("e67959a5-59cc-48e2-9ebc-f55b0e1323e4"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("234b2000-3d0d-471e-a2cb-5c70d700ddd4"), 0, "7faf07de-4126-475a-b195-205df8904c51", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKxYpYA1eSSOLGQ7klzxeG7A6m2wyMoMSQAFz9xnvE0dladeEmzB6rf8C61Ox+JebQ==", "+639672814641", false, "d3d9c50d-e497-c1f6-3a13-f4f93db80c76_20240627081541279", false, "jc.mangubat@hotmail.com" },
                    { new Guid("e67959a5-59cc-48e2-9ebc-f55b0e1323e4"), 0, "98e7c1e5-6239-4494-8fcc-ebb2eb755012", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEOmJ6cE9LGaRTQGlVDI4CcKlM0zYBLzYC9Rca1NxnkC7zfirAWASYUrVwmEsnBtzHA==", "+639951225449", false, "d3d9c50d-e497-c1f6-3a13-f4f93db80c76_20240627081541279", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("3429fc6e-f4b0-4e1b-9ef1-63ac2aa28fbc"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5720), true, "8000", "Davao del Sur", new Guid("ae83df8f-9ddb-4d0e-a0f1-1e5ace2c08fb") },
                    { new Guid("e7c50690-f69c-4a50-967a-9b550d8b4329"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 8, 15, 41, 433, DateTimeKind.Utc).AddTicks(5700), true, "8000", "Davao del Sur", new Guid("8d887094-7226-4a33-be06-0e88a1ef12a0") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("186cd40b-b1e5-4faf-9441-df4f6ee04645"), new Guid("25385761-1d29-4ff2-9e1c-e2b7307799b9") },
                    { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982") },
                    { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982") },
                    { new Guid("186cd40b-b1e5-4faf-9441-df4f6ee04645"), new Guid("4a6fbb99-c779-4df7-8243-504f20c8ee23") },
                    { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba") },
                    { new Guid("865deddd-d238-44d5-b234-13b10ad9060d"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba") },
                    { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba") },
                    { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1") },
                    { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1") },
                    { new Guid("69302f2f-ced8-43a6-8c75-08c7852cb1c7"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") },
                    { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") },
                    { new Guid("b4bc7bae-39e7-4f9e-86d2-34c354a67683"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") },
                    { new Guid("d1e79dcc-82ae-4fcc-85ca-5cc147bd48ec"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3") },
                    { new Guid("145a78d1-4e25-41a3-9e54-1c4c95366a7e"), new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b") },
                    { new Guid("89b23ebe-a93f-497e-b35f-c9f868d20716"), new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1c026658-28f2-4d05-9b89-b9266e17c0f9"), new Guid("55fe0db0-59a0-4832-bf2a-3353fdae42d6"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2954), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("2898bc6d-cd6a-4d0b-a003-ecc3aa3e55be"), new Guid("4a6fbb99-c779-4df7-8243-504f20c8ee23"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3164), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("55964667-040b-46a0-bccb-712f6475325b"), new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2765), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("5dfad88d-6da7-4436-854e-ae0178abea66"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3050), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("6ac6006f-b4d5-42a9-84b9-84828ff6cf78"), new Guid("634c9bee-0716-42c8-902c-fae0a0e0bf5d"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2877), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("93523acf-bde2-4f22-9f97-433df5cc8d3c"), new Guid("25385761-1d29-4ff2-9e1c-e2b7307799b9"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3127), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("a74589ce-13c5-4076-b509-b9907adc6a67"), new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2837), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("b9437a1c-fdb5-4d08-b499-93d68e8735c2"), new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2912), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("f29c416f-48c6-49a6-a484-c5f48dd747ce"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3089), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("07f0454f-7026-4f57-a1e6-ac11d8be99de"), new Guid("25385761-1d29-4ff2-9e1c-e2b7307799b9"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3131), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("11cdb62d-5549-4e48-9cbb-e0b4fe11526f"), new Guid("f93d50b8-3c4d-4ce5-95b6-340a96fa9b9b"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2840), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("48da151b-ab60-4657-8f8b-cc62a2c8019e"), new Guid("786c2a3c-1c4e-4c1d-bf7e-8de9ad217bba"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3094), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("49bac859-b1e8-4b13-9839-894847119663"), new Guid("89ed5c1f-44d5-4f6b-94f6-1ed95fc081a1"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2781), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("4caf4176-323c-455f-afa5-058b98004ed5"), new Guid("ce4b9828-676f-463e-bbfa-369c6bba02c3"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3053), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("61b903e4-0a19-4070-a7bb-714cfd16bfd5"), new Guid("55fe0db0-59a0-4832-bf2a-3353fdae42d6"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2960), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("ab30b691-e7ec-42ce-ba26-180e64db5d3b"), new Guid("634c9bee-0716-42c8-902c-fae0a0e0bf5d"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2879), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("ae3d70d8-15c9-489b-bf95-76e75a1a46c5"), new Guid("4a6fbb99-c779-4df7-8243-504f20c8ee23"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(3167), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("d70e5c07-9087-4057-bcd3-c781ae4c409a"), new Guid("37298206-9ac5-439c-8f8c-2cb7c672e982"), new DateTime(2024, 6, 27, 8, 15, 41, 437, DateTimeKind.Utc).AddTicks(2917), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "ImageSizeOrientationStyle", "IsActive" },
                values: new object[,]
                {
                    { new Guid("00b0330a-edd3-4e90-86d6-63a2809a5596"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5724), new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", null, null, true },
                    { new Guid("028cae38-6355-42f2-81b7-98724f4a23c3"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6062), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", null, null, true },
                    { new Guid("029e3345-2448-4636-8c42-fda4e09eac43"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5946), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", null, null, true },
                    { new Guid("0435482e-2423-4f99-834b-e2775ef94381"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5064), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", null, null, true },
                    { new Guid("06559580-b666-4549-a098-cd331313a2ca"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5399), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", null, null, true },
                    { new Guid("0717a40c-6533-49ef-b040-349d9d976735"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5956), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", null, null, true },
                    { new Guid("07f45583-1e92-45cc-8200-f04f17e3b7b0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6320), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", null, null, true },
                    { new Guid("088b4e88-9279-4ebe-9339-5278e5fcc307"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5844), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", null, null, true },
                    { new Guid("094c733f-fb67-419f-b3d9-29d99e3a9c3b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5096), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", null, null, true },
                    { new Guid("0dc4f69c-274b-4899-8014-019dc6c615df"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5229), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", null, null, true },
                    { new Guid("0e1bfd75-969e-4366-8e83-a03cb2b5b79c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4998), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", null, null, true },
                    { new Guid("114025a7-86a4-4dc8-871d-a491a9241d05"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6030), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", null, null, true },
                    { new Guid("134d87c4-e718-44af-a35d-937e5bc2f53c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6553), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", null, null, true },
                    { new Guid("138e189e-22f6-4609-a79e-bc196b34af5a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5563), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", null, null, true },
                    { new Guid("1c1d5be9-f2b5-497e-bfff-2fee04602004"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4953), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", null, null, true },
                    { new Guid("1c775202-c4f9-4ced-abb2-b5d6358ba605"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6546), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", null, null, true },
                    { new Guid("1c9b9763-0a5e-4167-8b49-54638cb4390c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5649), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", null, null, true },
                    { new Guid("1e079a11-0d8e-4b8a-917a-d380745ac7ce"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4969), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", null, null, true },
                    { new Guid("1efe61b8-5953-4ada-8ffa-7988663b0b68"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5567), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", null, null, true },
                    { new Guid("2025ba6b-964c-4611-89d7-bd4db522d79d"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5937), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", null, null, true },
                    { new Guid("211b8080-6ea6-4bf6-bbea-ac21d69bdc58"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5317), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", null, null, true },
                    { new Guid("22253291-9a4b-4d3b-8992-1cc7dac7b2b0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6560), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", null, null, true },
                    { new Guid("23f4a39f-7c8f-4789-951a-71058e20ef42"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5716), new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", null, null, true },
                    { new Guid("2426c6d1-ef6e-4213-9e09-a300a17f6de1"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6055), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", null, null, true },
                    { new Guid("2502c38d-5673-4b8a-8ae1-bbd35b1f4212"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5856), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", null, null, true },
                    { new Guid("26206fca-0594-4f1a-8d3f-0ae58438a433"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6515), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", null, null, true },
                    { new Guid("275387fd-08c5-4c39-aac2-b114835933e9"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6525), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", null, null, true },
                    { new Guid("296a731e-22d5-4bb2-947b-27a257313b77"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5252), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", null, null, true },
                    { new Guid("29bd7900-555a-4ad4-9ad6-de172cbfeeeb"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6034), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", null, null, true },
                    { new Guid("2da81be5-952e-404e-a6f4-07503ab29dc7"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5167), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", null, null, true },
                    { new Guid("2faa2af2-2817-491e-b8c2-c43ad14709ea"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4933), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", null, null, true },
                    { new Guid("2fd1e9d9-83a0-42cb-a5e5-78c735c9ec7c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5657), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", null, null, true },
                    { new Guid("3044964c-78a9-4d85-9dc5-c58171423aa3"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6286), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", null, null, true },
                    { new Guid("30e5e2ba-2c3c-4bab-bfc9-37afba221672"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6230), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", null, null, true },
                    { new Guid("34dd2d1c-5b5a-43e5-bdfa-3646c3b5b8d0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5409), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", null, null, true },
                    { new Guid("34f741c6-157c-45fb-8ac9-e25a42ac7bc2"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6405), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", null, null, true },
                    { new Guid("3803bb8d-f97b-41fb-ba19-c9b696bd544f"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5929), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", null, null, true },
                    { new Guid("38b739ca-4022-4dbb-a326-886f3f7c26e7"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5921), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", null, null, true },
                    { new Guid("405aef1a-7621-44e6-8ec9-8a1cb3796dbd"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5960), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", null, null, true },
                    { new Guid("453de0cc-74b9-4ed7-a8a2-e3930e11380b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5012), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", null, null, true },
                    { new Guid("4999cdf4-7544-4a56-8f3f-d531f79c97ba"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5639), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", null, null, true },
                    { new Guid("4c800ff6-4ae8-4445-aec5-5535a859d30b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5868), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", null, null, true },
                    { new Guid("4cc49fdd-8a53-478f-988d-705c30521809"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6206), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", null, null, true },
                    { new Guid("4da38edd-f7c6-4619-aa4a-7308fca633e3"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5577), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", null, null, true },
                    { new Guid("4fd27e31-ef5f-4c0c-b180-fb2c636cfa4a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5385), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", null, null, true },
                    { new Guid("50408bf2-edc6-4e41-8ae2-8454e3c93aed"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5933), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", null, null, true },
                    { new Guid("516dada0-5bfc-4d86-9988-c1434856575d"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5214), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", null, null, true },
                    { new Guid("5325e0f6-4239-4461-8c57-49ac91710342"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5246), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", null, null, true },
                    { new Guid("5373b4ca-2132-44e5-a4ec-64acb1a058b9"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5731), new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", null, null, true },
                    { new Guid("54a2615b-70b1-44b1-aaf8-76a394998649"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6568), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", null, null, true },
                    { new Guid("55887cb9-8674-421a-8ac5-7c89d5ddb7ce"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5086), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", null, null, true },
                    { new Guid("560a29a6-831d-4500-bc42-3e03307d62ab"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5917), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", null, null, true },
                    { new Guid("57d0a41d-a674-45dd-83df-90b843957768"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6538), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", null, null, true },
                    { new Guid("588ae587-ba40-4183-be85-34774b9ea8b9"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6427), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", null, null, true },
                    { new Guid("59764980-1111-46a0-a5b8-67db1bba3c21"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5256), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_12.png", null, null, true },
                    { new Guid("5a360098-054c-4dd9-a62e-db0ecaac0f0d"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5209), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", null, null, true },
                    { new Guid("5b2f9f9e-3979-4bd3-8e18-cf514e7bdb36"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5163), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", null, null, true },
                    { new Guid("5c759efa-8071-4914-9a47-674cf4ee1de8"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6226), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", null, null, true },
                    { new Guid("5fda784b-7120-475e-b06e-8554484a670c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5406), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", null, null, true },
                    { new Guid("60e1e0f8-0c77-42a5-be37-f5549062263c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5556), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", null, null, true },
                    { new Guid("6331d7fd-c0ac-42ad-9360-6f29be9f88ef"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5836), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", null, null, true },
                    { new Guid("63af8d11-847a-442f-b130-8746ed79f3de"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6534), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", null, null, true },
                    { new Guid("64bf4a19-bc21-4b21-a5cf-bcc87bfb5f8b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6422), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", null, null, true },
                    { new Guid("691b6600-0f8b-4c62-b5fe-8130ad105682"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5395), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", null, null, true },
                    { new Guid("69e53a53-94c2-41a7-b216-220cf4f89e2c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5668), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", null, null, true },
                    { new Guid("6a6503b7-d021-4310-8036-ba54c1b5167e"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6394), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", null, null, true },
                    { new Guid("6b9bd1d2-e470-43b0-bf87-e132162487bc"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5572), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", null, null, true },
                    { new Guid("6cff59b4-6a61-4533-aae0-bb67689653b0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5859), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", null, null, true },
                    { new Guid("6e86b817-3e5c-4d42-8dcf-5cf4eb00b85c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5390), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", null, null, true },
                    { new Guid("71460959-d153-49c5-b7b8-1d045ce1b682"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4960), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", null, null, true },
                    { new Guid("71beed2f-32c9-407a-b7c5-7cc10f2e2446"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5224), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", null, null, true },
                    { new Guid("722329c0-bb2b-43e8-a920-a8d1e05e20f7"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5942), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", null, null, true },
                    { new Guid("73e56932-3e3e-43d5-8e9e-0995efa93562"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6550), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", null, null, true },
                    { new Guid("77f2badf-71bc-4556-939e-dd265f8dd316"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5712), new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", null, null, true },
                    { new Guid("7907a890-aea3-42d1-9c31-b545550d7720"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6067), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", null, null, true },
                    { new Guid("79c92e65-ee4d-47ce-bd46-a326730f0479"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5864), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", null, null, true },
                    { new Guid("7e0f409e-037a-4bab-842f-b712b6c1708a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5312), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", null, null, true },
                    { new Guid("7fef7ff3-6c51-4ae9-9840-326665866e8e"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5073), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", null, null, true },
                    { new Guid("800480bd-dbd9-4cea-be5b-561cf0c68f5a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6414), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", null, null, true },
                    { new Guid("80c41f31-99c6-4719-a990-6384e866119b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6301), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", null, null, true },
                    { new Guid("817bc5a0-46f1-4949-bde2-c9cf9f79aff2"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5832), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", null, null, true },
                    { new Guid("8306b716-f481-4af7-9a2b-fb8fe15d8166"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6390), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", null, null, true },
                    { new Guid("84d4f6eb-07cb-4dc7-82cb-480d0afd1385"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5220), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", null, null, true },
                    { new Guid("87f183d0-769f-4929-80c8-fe85824caeb4"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5911), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", null, null, true },
                    { new Guid("8897300f-df16-4f43-9c26-713d33caba9c"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6325), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", null, null, true },
                    { new Guid("89ef0739-df4e-4cfa-9cd6-e2eabdeeaab2"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6058), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", null, null, true },
                    { new Guid("8d76907e-3737-4098-bd1f-4001e51bc91a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5379), new Guid("07b85e70-1cba-4959-aa15-17699aea9f1e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", null, null, true },
                    { new Guid("8d8a1480-2bc0-49ed-bb07-3c88e867cef0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6542), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", null, null, true },
                    { new Guid("8de26f74-d6ed-40b6-987b-31a035df231a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5840), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", null, null, true },
                    { new Guid("8ee7f2f2-bf23-49ff-bc61-ccc1f2a1d4f9"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6234), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", null, null, true },
                    { new Guid("92473d18-02f2-4da8-90c9-535146cf5991"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5082), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", null, null, true },
                    { new Guid("963ef555-5c47-4a73-ab23-fde5da61e9fd"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6193), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", null, null, true },
                    { new Guid("97667698-3e39-43ff-a89d-5817d317973a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6071), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", null, null, true },
                    { new Guid("98e17197-0f7e-43df-8b85-f125ca54c50b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5148), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", null, null, true },
                    { new Guid("9c42800a-5836-4553-bd03-094058e3e034"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5826), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", null, null, true },
                    { new Guid("a246d912-92b4-497a-b4fc-fd20de17a9e1"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6310), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", null, null, true },
                    { new Guid("a8960ab8-b205-41e7-b01e-8c3698d564fc"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5090), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", null, null, true },
                    { new Guid("aac5ec15-11ae-4cff-bd81-9923a41fc415"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5590), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", null, null, true },
                    { new Guid("ab9cf751-54c1-4804-8398-5b8e844ac947"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5849), new Guid("415e76ce-7b53-4f10-9dce-b077690626dd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", null, null, true },
                    { new Guid("aba0e05c-2693-412e-802d-d237019148a3"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6200), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", null, null, true },
                    { new Guid("ac34f3b7-486b-40f3-9a4f-e86e625a42f4"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6410), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", null, null, true },
                    { new Guid("af31f57d-bfdf-4709-9472-112de000931f"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5644), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", null, null, true },
                    { new Guid("b1ea49fe-4e00-498a-b574-409dde0df805"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6398), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", null, null, true },
                    { new Guid("b4af9b1e-5d39-406e-89fd-1123a253af75"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5720), new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", null, null, true },
                    { new Guid("b76c5c45-5a55-48d1-98c9-2cf946f252de"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6530), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", null, null, true },
                    { new Guid("b774d9d0-1983-4613-9492-7070d09d2bb8"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5584), new Guid("8b09a3ab-526e-4f8a-a1f1-b35b9cabdb1d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", null, null, true },
                    { new Guid("b8849d7f-3e7f-4d62-8728-1ff5e28efa7a"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5950), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", null, null, true },
                    { new Guid("b931c3a6-91d6-4f2d-9d16-31a1b04f6056"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6306), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", null, null, true },
                    { new Guid("b940bd53-511b-4b85-a2a0-ee083f7a6378"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6222), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", null, null, true },
                    { new Guid("bfc2d5b4-e0bc-43b4-b90b-dcee796cf1fd"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5706), new Guid("fc1694c7-dfc1-4ce4-94b1-b982785f1dca"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", null, null, true },
                    { new Guid("c0848d9b-e001-4411-b0e3-29ca1fea1e99"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5233), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", null, null, true },
                    { new Guid("c216e740-5467-433c-be53-72c996e5d2da"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5101), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", null, null, true },
                    { new Guid("c68a2360-407a-4abb-ad1f-23a809f8a585"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5106), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", null, null, true },
                    { new Guid("c7a1e728-7e72-464e-b2c6-0b6d45a7bc65"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6294), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", null, null, true },
                    { new Guid("cb9e6a8f-1014-44c4-9ee7-3b8188a2c4f0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6314), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", null, null, true },
                    { new Guid("cbe3e068-5098-4ea5-8ba3-79720b902eeb"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5242), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", null, null, true },
                    { new Guid("cbff3c7a-1ca1-4893-bc78-7c107fa92589"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5007), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", null, null, true },
                    { new Guid("cd64348e-1da7-4f29-bbe3-5616ff267845"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6279), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", null, null, true },
                    { new Guid("cea26776-207b-4f2d-9eae-de8db8b0e475"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6217), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", null, null, true },
                    { new Guid("d828dfcf-7b40-4291-a01a-e54663278981"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5144), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", null, null, true },
                    { new Guid("daa61530-b456-4e1a-971c-f1cc8f6b3849"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6384), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", null, null, true },
                    { new Guid("de1d49fa-5b11-4158-9f4b-9a47654e6381"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6038), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", null, null, true },
                    { new Guid("de96be38-01c8-413e-9fd4-a5a942bca40b"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6564), new Guid("d325b550-391e-4c7e-b432-5f743ccb168e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", null, null, true },
                    { new Guid("e024aa50-7bd5-447f-9408-a5be95cf0284"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5003), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", null, null, true },
                    { new Guid("e07ca8d4-ffc3-4163-9234-d7cad14c5bee"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5204), new Guid("b7c2a02c-baba-4721-a47d-e74c79ba4a34"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", null, null, true },
                    { new Guid("eb77675e-9827-4783-a78c-f35ab8201ede"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5115), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", null, null, true },
                    { new Guid("eff219e7-0c4a-4503-8910-3c7e3256c6f2"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5653), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", null, null, true },
                    { new Guid("f06472ec-1640-49bf-a033-b18939b4ada0"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5664), new Guid("b9f38ea5-1357-42be-a67b-6bcbd644bf88"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", null, null, true },
                    { new Guid("f1fdeeda-505d-4de6-b58a-b4128171e973"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5966), new Guid("0db011f6-151a-478f-b4a3-6157c1210683"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", null, null, true },
                    { new Guid("f2fe4509-a899-4872-a80e-f4a6b6f046a7"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(4949), new Guid("27545b2f-b270-4b1e-a389-306ed65156d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", null, null, true },
                    { new Guid("f4002bcb-db42-4de6-ab5d-33a6029b45c4"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6042), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", null, null, true },
                    { new Guid("f45b2c3c-f12f-45f4-8ca9-27ed9839f7b1"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6048), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", null, null, true },
                    { new Guid("f4a7dd7c-737c-445d-8bbe-4527e32fd018"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(5109), new Guid("9354bcd0-5195-441d-8e0f-846b1a465c3e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", null, null, true },
                    { new Guid("f4d21a59-0fed-481a-a6e8-6dbbf8d9df86"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6210), new Guid("cbea7c95-8ee1-4f2e-ae94-144a212c7889"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", null, null, true },
                    { new Guid("fb0047f6-e87b-4f15-b4a3-e002afd94392"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6298), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", null, null, true },
                    { new Guid("fc57b7e7-3771-45fb-aa83-62e1db821969"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6329), new Guid("c7046c58-a56b-4ddb-8079-063786fd604e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", null, null, true },
                    { new Guid("ff20cf73-d9d2-4982-bae8-fec4539ce1f5"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6418), new Guid("c62de9bf-683a-46be-91cd-04df220c4cda"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", null, null, true },
                    { new Guid("ff89228e-737e-4588-ae80-cb63fa6aeb73"), new DateTime(2024, 6, 27, 8, 15, 41, 438, DateTimeKind.Utc).AddTicks(6006), new Guid("9954deaa-e793-41c8-beaa-3e316e543ec5"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", null, null, true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b136bc30-3de1-4862-8199-135ee9b058c0"), new Guid("234b2000-3d0d-471e-a2cb-5c70d700ddd4") },
                    { new Guid("6b4a82b1-0416-42b1-8315-a136518686df"), new Guid("e67959a5-59cc-48e2-9ebc-f55b0e1323e4") }
                });
        }
    }
}
