using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FeatureProjectImageFieldRename2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("031d5da6-9e5b-442c-998c-bcf501b59a21"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("b97f4a2a-238f-48fa-b3c0-c6596e54996f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0334ff9a-405b-49ed-bf84-df0d8ba7df4f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0751aa18-7f70-45b1-b5f6-76e21e2cf3bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1addbd6a-cbf7-4462-a7b0-5b98ac98ebf1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1f53fb77-11db-4be8-a943-8192d244d91d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("281cd258-03a5-49d8-a873-8ff966640266"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2ccbb302-c1ad-417e-b151-3b07df4504f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2d033a4e-3124-496a-836a-f299c9ac6065"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3ad901db-baaa-4921-884a-e945dd15409f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4450c1f3-2fcd-4b5b-b5e7-65c5b9359f2b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4b0ede20-c40e-4c65-ac2f-98b1286e4d9e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5200213c-fc0d-4c2a-a275-c5ae1b758cdd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5b875595-c861-45b5-afc2-8bd1a8c96d3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5fd1fbc5-65fc-406f-955d-561d6c1342ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6764c8e0-8a72-4cd2-aff3-cb7a78b97d0c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6cf4ec8e-c0fb-4c61-bf9b-315d703e56a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("727d39fa-5dcd-41da-9e1c-d8ea39ce3801"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7758ca8b-be9c-4390-bf50-a039137580ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7830fd77-1db2-40a2-b8a8-4dfd1fc8debd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("862a5689-7d53-4b09-ab9b-ad324daba6ad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("88b6c8d6-8409-453a-846d-3e63b548f474"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8a18aa7c-2b69-4664-8f78-8100fca788d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8d861e59-1e8c-4bda-8356-ded02b616d0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("954f5042-c177-4d10-b142-5e0d45359b1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("97d439b5-ce34-43f7-aa5e-95ffbedb4209"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("988fd777-e8b7-40cf-a5eb-9c558e4d51eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9d68b334-fb26-43c9-a39a-cbeb1db6fd2d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cd498d61-c18a-4092-98d6-161204dd50aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d061137d-1f60-4a8e-a28c-7596cc62b9a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d15dba9b-23a5-4c76-8688-6c18f222ca09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("db39bbdb-b753-40d1-a23a-8aaeb5e6bdec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e1ac9f74-c24f-4d07-a92d-cfbf91acbf52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e4ea2923-6de5-4886-a00a-56cef6e797b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fd5780c7-6d1c-4df3-b89e-8f055e9cdbf7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("6f4f42d1-66bc-4fdb-9642-816c88fd6d69"), new Guid("3ccdd8cc-49d1-4877-ac96-9c012c0d9fee") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("3e5219e1-4360-4aff-bb4d-12604d92a961"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new Guid("805ef16c-4227-491b-8526-91d9aed457b7") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("805ef16c-4227-491b-8526-91d9aed457b7") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d5c1666a-f204-4047-9b8e-1d0e62ab0060"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("7b38ca77-b641-4753-adad-8e8322e4a71c"), new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("6f4f42d1-66bc-4fdb-9642-816c88fd6d69"), new Guid("c0ff91b7-a308-451c-88a4-e3f46c596512") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("158af346-0694-450d-869e-abda2c2f463b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("3b9dabc8-c893-4724-b12c-e37952cff8c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("6be71336-e09e-4b4d-933d-aee1c6baf4a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("76c2606e-3509-4247-b4b6-793f77f017d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("985c544b-97c6-4bfd-baa3-b4f63f22fd0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("996c0d04-0d43-49e6-8c44-830709c7024d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("a26e0dad-01c4-4626-a3f6-3e8f22dbfce6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("a958e659-51af-4b35-b3bc-36106cb54743"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("c224204a-f9c8-47d3-a9ba-96c16ca6b410"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("0882c451-ac04-4ff3-925c-f2dd6d9ef7dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("1e23de0e-7d5e-4a0a-875b-7bccc72b350c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("70d1f995-f9b1-4a55-8425-cd27d3306550"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("88b0e9c4-00b0-4ac7-961d-6b59c2a3df25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("92be83f3-8eb2-4f35-a9d8-71592e1d101b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("93c2ce5e-8b7d-49d5-9521-85997a914a91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("acaf94ec-0c24-442c-8ba3-95b81eb2637f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("d023d242-145a-4096-9985-22e30fc7ebaa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("dd3c0b32-4c2d-467d-85a3-ecea1be7427f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2b46849b-b415-4ae9-94e1-3c88355b8b43"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4808ba8c-49bc-4c14-8e7b-33b1cd96fa6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4db02a34-da2e-4875-bd0f-d63510e03fb2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f139a8b6-c508-44b8-a868-1e6d080fa8ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("0a0669cf-4224-436d-9c48-04ac41f7465b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("1e26cc52-bb97-4ea6-ba98-543895193d1e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("466fe2ac-0ca1-44d2-95cc-a3418ed6d678"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("c56c3b2f-fe8d-432c-b5ab-613d07beb5c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("01d0b613-ab11-4d8f-b4a4-2437424bba81"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("04820b92-3e7a-4a68-bd23-9b1a679173f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("05a9e22b-1ad8-4c28-9fe8-685ab4ab7074"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0711816a-5307-48b9-8192-bad72f321258"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0d8e89bd-fa0d-4e6d-845e-560a1c7a6d86"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("10048ea3-1b39-44dc-99ca-ef9ba926c7a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("10a0feb2-2752-47a3-b10b-7730e107ca8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("127688bd-c652-4298-b94c-8af2c1854170"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("130bba8b-1577-4bf9-a645-1636b7c5919a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("160fe10a-3355-45b0-9ba3-bb0d3ca65e0b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("16411cd4-095a-4029-8868-3a481b5dc069"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("196e7f4b-542f-4fc6-b73a-87220f2e1139"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1d7b6a40-74eb-401b-939a-c023d2ea47af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("20c0db00-227f-4a02-bdd2-fdfc503e404c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("20eb585c-e77f-448d-8051-a03440226240"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("21c4d643-7a96-4c04-b862-79c88445bbd5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("22d20b88-2bc6-44cc-a268-22b620fe57af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("24e794df-3cf2-404c-872b-5eecd06c7b68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2805a81d-f61f-4896-8672-dea75a02d55e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2822c716-173a-4a61-a04d-94558c2f2ad7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2825d7a4-1a7b-4dce-bc0e-82fdeee9d9d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2ad36c9a-84b3-4b2a-802f-295a1f431551"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2c8b40bd-9483-4e45-a864-eb11adeab657"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2daaabb5-faa5-4a4f-8135-05fc9590d67e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("30b3671e-4343-4b52-8bfd-0fa4b2d62716"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("33e7c3b8-077e-47d0-80d1-a31fa28e8005"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("34006cb5-0c0b-42ae-8861-ba081401f75c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("346bbddb-92b0-440b-bc95-1d90a73b053d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("367043d3-cb97-494b-a0cc-85987ced622b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3b968121-bdb4-4a6b-ab5f-01aeae2167a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3dae2f74-7995-4649-90da-635a2eb0cbdc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3fbc8cbc-5e9a-4e2b-9c26-18d7654bd702"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("40d1ae53-7ab2-4118-b1f1-9ef4bb02932c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("415e7923-b7b8-4649-8a72-f5c23820f5f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("433556b6-2418-42c9-9987-b0e24b0f0870"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("47824620-1bba-42bf-96e9-8f033cd79605"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4a22d652-ba6b-4d6a-ae7f-0cf65909f6a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4b58f44d-7970-43ee-b583-0ce8081351fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4e432a08-d5f7-45bc-9aef-f3b28ec311a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("50160210-9551-4d73-8b41-a318b90bc84c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("50c180b4-e1ed-4004-a9fe-821c48faa193"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("54bd3f7d-fa18-40c6-9362-b9176b8d568e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("59ceb868-13c3-42a0-9faf-b0811c1737ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5b1a2b5d-fb1f-4649-84c8-9fc6c76d1673"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5e61f8ee-77f1-4ac5-91b0-756b2a8346f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("607a427d-8256-460e-920d-366a0fd5d695"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("64c4a912-d45c-462e-ad57-1e8439b4fa8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6761ba1e-463f-4c49-ade3-92d6881f0efb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("68bbaa63-1c5d-4974-b099-a5e269c37604"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("691c24f4-9e2f-4852-b14d-391ef3bd50c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("69934ff8-89a0-484d-9a85-a3a2b6d39ddb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6bc9b9f9-4f01-48d3-9810-ad718c3fb5f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6c253d15-4c11-48ea-9a41-d2a0b4eef3da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6c31eadf-23a1-41f3-a234-be0fda8f6bd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("72466577-96c9-4774-8602-f18837dde331"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("746f3e88-ef74-4cbe-89c0-e7af05db13b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7606d4bc-718b-4931-9688-e1eede4ba948"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7a049002-2fa5-40bc-8446-cb0dcdc2f0ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7b2e67d0-71de-4758-9793-de6a630b9c18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7c5d6315-36eb-4b3c-adbd-e91fcbd0c4b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7e06ac7e-735d-41f4-b241-637b3c7508f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7fc64261-3224-4a51-a1a2-bf34d1565722"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7ff1ff7c-c3d0-4d93-b361-24f8742ae855"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7ffd8593-ec93-4be3-8e2a-a4be1555f800"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("801e126f-8998-4670-923c-7f3551080270"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("80daf496-fbec-430c-8da7-e44134b429b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("819ce9ab-9bca-4225-b3d7-5c56c2133751"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("845d4c35-d7ac-43cc-90a8-42562aa70cd5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("858da5ff-6217-4353-99cc-f387d740a05b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8d171970-f578-47bb-9ea1-7abcd6a1a23d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8d67360b-dcd0-4ed6-b59e-ccee5e432e3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("91b1f480-ce17-4f9f-bb20-5fa705495f2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9331e2b0-e2eb-4db4-a013-de8430b3802e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("991eb80d-9222-411c-85b3-e2c49951b2e8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9ddee5a0-13f5-4014-94b3-4ee8b55a6af0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9e12639c-f1d4-4bb1-876b-6043b9b48eea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a14f30c4-ead9-413c-86e9-e253296a8966"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a3424d80-fcc4-48b8-8609-ee6735288500"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a4063806-30eb-49b7-a138-0eda4c59cd35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a49600dc-5c95-42d6-9d9f-db9f4638acd9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a557f5ab-dc91-497a-928e-ee21895e4ff6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a5d2b3fe-3a1a-4eaa-8905-e611a35c58ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a810e67c-8147-4f33-a429-a1fb9ab7bceb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("aa426dd5-8269-47f6-9839-e29f9ce57a42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ab2cc5e0-2cf4-4d6b-82b7-56a873402eb5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ab5ebbcc-837c-4843-8b5e-30e4a7e798f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("abfaf0e7-b0df-491a-8aee-30776f84f93c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b02c1c9f-5bfc-4d4c-a79c-9a5b77e377b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b0ec1ac7-dd9d-45ab-bdfe-f851df8e7159"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b4891c73-d5ec-4331-8dcb-02e658a1a66e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b4eabe6c-3271-427b-a45f-41cd2d28151b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b59d586d-4dfc-48dd-a6c5-8d7e5038b6df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b605ee31-b475-410b-b29e-62c8774511f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b6c38247-8b11-47da-aca8-f20e305c504e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b81e1ad4-5fac-443c-a924-da4ee691205b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bc18108e-47bc-4bc0-8ec5-5217ba9ee9a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bdee167c-59f1-4cc9-8134-68f0960e6be4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("be1afadb-84e5-4083-a15a-01ee5e7f49cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bed04bf8-322d-47a4-8511-ee3739fbec6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bf387910-ffeb-40da-b385-9df5ddeec606"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c11cc0ae-4881-42a4-bc99-1115623a41a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c2165fdf-7fb0-41f8-98d1-9b8b8760dc19"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c378775b-4981-4495-91fc-324e1d2770c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c3c52b4e-9003-48d5-b90d-c64f9d1f90be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ca069ae3-790c-449c-b60b-066e910a9014"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cb368070-f056-4565-8c5f-9fde38b53165"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd11462e-b614-4d12-81a6-5b443667228c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd1fb367-3356-4316-a146-65fdbd495de6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd267f70-5edd-4178-922a-e4f05a21cf33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cddcf9d5-5282-417e-840b-1feef6d989f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ced155ec-69af-4265-bb21-061593e0638c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d104c0b1-45d8-4e87-aa7f-c46d4d6490c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d36a000d-b80f-4ed4-bc4b-449b92c19899"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d49f3ffe-d4cc-49e3-8333-5abd54b15b32"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d4bb3683-717d-4f6c-b19c-a1c88743571a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d839a66d-584e-412a-9642-e10cd511c663"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("da3ac7b4-74ca-4a47-9411-02c10d7d3842"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dcc5187b-1543-40cc-8641-612476ef2eae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dce35d52-a8c8-41c5-b5ac-be309327a895"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dcfe44ec-0073-4ce0-b681-ad0d585581b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e0091979-ed4c-49e0-b920-24f53573f462"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e104365a-a41a-443f-9962-47eb9c1e42c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e318bd78-4794-486d-a303-a5fe22634c42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e3a9e7c3-67e8-41a5-b847-2501e520887d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e3bf04ac-f378-49e5-93a4-bbc28e947e33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e50d8d0d-b92d-4de1-8cdb-7ef78a8de567"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e5ea67c9-833d-491e-9111-087d3a7f4e4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e67dead8-4024-4dfd-a9b4-794b06cb799a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e6c9803b-01cb-4b94-bc29-766e34b007c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e9eacc70-1814-4f35-84f0-4e00dff2583b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eaade404-2443-4d25-9f50-cbc4b56fad8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eeba5976-4232-4b09-87c4-fce77ef5d2c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f3549633-25cf-4d5e-bac3-a22a9334f815"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f8a0db30-9d99-45a5-8041-7b0bfb8aef24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fa50a818-8e97-4f54-964e-1a122d3857c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fcaca8fd-2110-4acb-a89d-14cd455d16fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fd626a40-d4d4-40f5-a6ca-77594d85d2a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("06b00fbc-dd86-4815-a29c-ef952275983d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("075d2503-183a-44f7-8d51-af30662fa251"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2334c6ed-d480-4f5a-af74-1a5a8bbe174a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("345b7602-0f39-492e-8f83-25ff6df171cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3dc4b52a-76f3-4840-857c-356de81bf99a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("402d5272-0b76-4109-9a46-2e3f122a335e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("45d8464d-bfac-4fb7-bcee-3abbabcaac06"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4b7f71cd-53f4-4063-b6e0-68f845d71fff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("5554285e-67d6-48a2-a7f4-2e446a0964b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("58104a82-b2af-4702-a2d8-7d2277ace3ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("62e5cb8f-6329-4f34-8834-cd9affad233f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6c4f17e0-629f-488b-bc09-cd63dd8ef42b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("73785131-02a0-4ec7-8fb9-a9b4d7c2cc2f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("765a9375-97b8-4572-bf3d-8b3d1c0eea56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("894b50e2-b86d-4d65-9480-14f9987dc834"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("89e3b36f-5525-4a21-8a01-a463747acca5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8b9dff41-f508-4b04-9392-18ff2b7a7caf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d443bd51-4151-46cf-8617-f64936883887"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("da3d2dc6-80b2-4ab0-899a-0e946ff69e0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("da867e7e-9056-42f4-bca2-02ae4bd38885"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("dc3a8848-dffd-40ce-8285-edeef9f624d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("df9d0292-4633-482c-b0e5-8fcadb95a6e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a8fdfac0-1ead-4468-b586-13e363b7fe2e"), new Guid("378d9979-c9b3-45f4-8211-69ae9b9d1934") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bad3a2d2-496d-4ceb-a1b3-fbc2e2be6223"), new Guid("8960a695-c03d-432d-96b0-c8681dceed4d") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3e5219e1-4360-4aff-bb4d-12604d92a961"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6f4f42d1-66bc-4fdb-9642-816c88fd6d69"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7b38ca77-b641-4753-adad-8e8322e4a71c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d5c1666a-f204-4047-9b8e-1d0e62ab0060"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("03e9534d-06ed-411d-8567-2f1e0889e322"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("3ccdd8cc-49d1-4877-ac96-9c012c0d9fee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("5f0be940-001f-4648-a217-20dc0879d819"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("664e8bcd-d648-4f22-9e5b-2beee17fb146"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("805ef16c-4227-491b-8526-91d9aed457b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("c0ff91b7-a308-451c-88a4-e3f46c596512"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a8fdfac0-1ead-4468-b586-13e363b7fe2e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bad3a2d2-496d-4ceb-a1b3-fbc2e2be6223"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("380511be-d719-420b-9c63-6cbf898653cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("57b8b003-273c-4971-a093-46fa932cf91f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("2191f962-bcab-4d7a-a093-bd3c0ed47917"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("aab62a6c-ccc5-43e5-a8fb-d130dd270a6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("378d9979-c9b3-45f4-8211-69ae9b9d1934"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8960a695-c03d-432d-96b0-c8681dceed4d"));

            migrationBuilder.RenameColumn(
                name: "OrientationStyle",
                schema: "dbo",
                table: "FeatureProjectImages",
                newName: "Style");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 52, DateTimeKind.Local).AddTicks(1248),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 890, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 63, DateTimeKind.Local).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 905, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 64, DateTimeKind.Local).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 906, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 64, DateTimeKind.Local).AddTicks(8363),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 65, DateTimeKind.Local).AddTicks(723),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 52, DateTimeKind.Local).AddTicks(6914),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 65, DateTimeKind.Local).AddTicks(3507),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 65, DateTimeKind.Local).AddTicks(8059),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 53, DateTimeKind.Local).AddTicks(4211),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 53, DateTimeKind.Local).AddTicks(6509),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 63, DateTimeKind.Local).AddTicks(740),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 61, DateTimeKind.Local).AddTicks(9333),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 62, DateTimeKind.Local).AddTicks(3404),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 61, DateTimeKind.Local).AddTicks(5658),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 52, DateTimeKind.Local).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8754), true, "Industry News" },
                    { new Guid("0e2eaab4-ebd2-43ae-b660-22d9c328d513"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8760), true, "Landscaping and Outdoor Design" },
                    { new Guid("0e885db1-62be-412b-81b6-473e0016f723"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8787), true, "Technology in Construction" },
                    { new Guid("1b45914f-e0d7-4cef-a604-a081b92bede4"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8680), true, "Design and Architecture" },
                    { new Guid("247aa9a4-8b90-4011-9763-d4ceeff89b23"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8688), true, "Equipment Maintenance" },
                    { new Guid("39a86a8b-d686-4a2a-8d83-7934f9b4335b"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8671), true, "Construction Techniques" },
                    { new Guid("3ff503c1-cb81-44a1-878a-37cd6e56043f"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8661), true, "Community and Culture" },
                    { new Guid("4360de95-098a-4322-9df2-f351a9be62d0"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8789), true, "Training and Certification" },
                    { new Guid("43fbd20d-d4f1-4e16-82bf-65a2197d516b"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8774), true, "Real Estate Development" },
                    { new Guid("4e13ef53-d7cc-435d-9c1b-73294c31b5bb"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8747), true, "Health and Wellness in Construction" },
                    { new Guid("4f9c534d-e875-4f09-a09a-8fb0c4e8143a"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8644), true, "Case Studies and Success Stories" },
                    { new Guid("5691f198-51ca-45c0-9597-1cb93d0d3b0e"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8752), true, "Home Improvement and DIY" },
                    { new Guid("5bb29f91-3d6d-4789-b33a-830ed2503c75"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8682), true, "Disaster Preparedness and Recovery" },
                    { new Guid("658d72a8-02e3-42fe-b9cf-cae2336e6ddd"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8658), true, "Client Resources" },
                    { new Guid("682178b4-f2cb-4853-8614-ac65a5713374"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8776), true, "Safety and Compliance" },
                    { new Guid("75ea084b-300c-4ed5-9c74-4807973af422"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8750), true, "Historic Preservation" },
                    { new Guid("82c0945b-447e-46b2-b52d-fcf796b52c7f"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8678), true, "Customer Stories and Interviews" },
                    { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8663), true, "Company Updates" },
                    { new Guid("853f5e03-01c2-4d78-9482-4ba22153d557"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8768), true, "Modular and Prefabricated Construction" },
                    { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8656), true, "Client Education" },
                    { new Guid("97c89b9b-7f76-4379-8ce1-45bf1f2c45ae"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8772), true, "Property Management" },
                    { new Guid("9ed28b1f-c1c2-4da0-a797-f296cbf2c9f8"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8791), true, "Urban Planning and Development" },
                    { new Guid("a06c9416-7dda-4f9d-880e-a498c768dc68"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8684), true, "Energy Efficiency" },
                    { new Guid("a80ac543-328f-4998-a2b5-c950c2cb76fb"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8686), true, "Environmental Impact" },
                    { new Guid("a810e713-0599-4571-8885-b46d85a14952"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8676), true, "Cost Estimation and Budgeting" },
                    { new Guid("ae7e0b15-83b0-4dd4-9e3f-e3a2d81e86a7"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8793), true, "Weather and Seasonal Tips" },
                    { new Guid("b0db665f-dd0b-4191-a122-e09ba34d88dd"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8756), true, "Innovation and Future Trends" },
                    { new Guid("b13d971b-5c4a-4179-b9e5-dd6ee59802a4"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8780), true, "Supply Chain and Logistics" },
                    { new Guid("b194c93b-6780-4c4d-b4db-33790f5c685f"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8762), true, "Legal and Insurance" },
                    { new Guid("baa46a9f-fc15-45bb-9750-d66a341ec1de"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8778), true, "Smart Home Technology" },
                    { new Guid("c4bfc7dd-3a19-4d23-85ec-29b13f3f9f4c"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8641), true, "Building Codes and Standards" },
                    { new Guid("ca3458d4-9137-4269-9a2f-dcce10b8fa42"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8667), true, "Construction Finance" },
                    { new Guid("cc819816-c998-4ebc-8e8f-da726396e8b3"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8770), true, "Project Showcase" },
                    { new Guid("cdf06eb4-ccef-4cf4-bd4a-bb41b1e79b84"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8689), true, "Green Building Materials" },
                    { new Guid("e188742b-2e93-4932-b40f-5ce9ae0dcf50"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8758), true, "Innovation Awards and Recognitions" },
                    { new Guid("e4852136-0dce-4564-8e5b-58896dede63f"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8580), true, "Accessibility in Construction" },
                    { new Guid("e9cdd2c6-b160-4fe1-a2d5-04ddeb6c5777"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8665), true, "Construction Careers" },
                    { new Guid("f737a41a-4d12-4e80-b227-a9cf0b880b54"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8766), true, "Materials and Equipment" },
                    { new Guid("f81681e8-7fa5-44b0-80f3-7668f1391e8e"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8669), true, "Construction Management" },
                    { new Guid("fe738283-8299-4aef-bece-a007aec36cad"), new DateTime(2024, 7, 4, 5, 37, 25, 65, DateTimeKind.Utc).AddTicks(8785), true, "Sustainability and Green Building" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("0db940f0-87b3-4120-a1f9-a7c3e99d917d"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6197), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6247), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("1a5491de-e86b-4562-8c04-dab390a501e9"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6371), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("30fbf473-4ea0-476c-b592-671ba6e54957"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6028), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("384dad1c-71ea-4b50-82fb-0682b0087194"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6458), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(5444), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6152), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("aeb97e45-383b-4688-941a-5f67e11a3265"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6110), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("d72caab6-e279-434f-b5d7-fa7c04c6e04e"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6411), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("094d8454-8b30-466b-95ff-5dd389770d2b"), null, "Admin", "ADMIN" },
                    { new Guid("378bed8c-a7b1-494d-abb5-5db7ea97d4a1"), null, "Editor", "EDITOR" },
                    { new Guid("be1e0ce1-d66d-434d-878c-46ad414a05e0"), null, "Moderator", "MODERATOR" },
                    { new Guid("d1d81b06-0820-40c1-8ab0-0dd50b11df08"), null, "Visitor", "VISITOR" },
                    { new Guid("eca4aaa8-f212-498f-a129-5336ead52e00"), null, "Manager", "MANAGER" },
                    { new Guid("f9312d5b-bc18-4b64-8ab4-93f3c203af00"), null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("37ea9037-374b-4362-8542-fb738e566ff3"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(7625), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("cfd2814e-73a5-414f-b288-cff3ce84f289"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(7650), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("ea89f333-dbdf-4579-9df3-620ceec69cfd"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(7648), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("eb1805bb-94ae-44da-a445-b70c5cc6b992"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(7636), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "ImageCDNUrl", "IsActive", "Location", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3077), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "muntinlupa-lds-chapel-elevator-project", "Muntinlupa LDS Chapel Elevator Project" },
                    { new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3540), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "aringay-lds-chapel-retiling-and-repainting-works", "Aringay LDS Chapel Retiling and Repainting Works" },
                    { new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4089), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "talavera-chapel-general-repair-works", "Talavera Chapel General Repair Works" },
                    { new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), null, new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2859), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", true, "Sasa. Davao City, Philippines", "sasa-lds-chapel-general-repainting-retiling-works", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3789), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "general-milling-station", "General Milling Station" },
                    { new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), null, new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2416), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "um-library-fire-protection-pbax-paging-systems-project", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3402), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "san-pedro-laguna-lds-chapel", "San Pedro Laguna LDS Chapel" },
                    { new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2544), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "carmen-lds-chapel-general-repainting-electrical-works", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3930), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "lds-chapel-retaining-wall-construction", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3258), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", true, "Davao City", "verdon-park-condominium", "Verdon Park Condominium" },
                    { new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), null, new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1390), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "ladon-construction-service-davao-city-headquarter-office", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), null, new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2027), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", true, "Philippines", "company-workforce", "Company Workforce" },
                    { new Guid("e3874308-9651-4722-af95-74af7e1853e2"), null, new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2284), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "lds-church-improvements", "LDS Church Improvements" },
                    { new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2992), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "mang-inasal", "Mang Inasal" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("14abbad4-9c8c-45a6-bf73-0534f7b469ef"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7767), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("2d33a7c6-66d8-435c-b448-81d0241acf5d"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7745), true, true, "Are you licensed and insured?", null },
                    { new Guid("4ee070fd-6880-4911-8590-8d595ccb75e4"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7759), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("58eb2312-6465-4312-8c20-a01d03025468"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7698), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("60a461b8-f740-43ff-bd84-9986ca93c368"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7680), true, true, "How do you handle project timelines?", null },
                    { new Guid("6e7298dc-0204-42ac-b712-1159cb455778"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7713), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("7625be3d-9bca-4be9-9869-8521bae12c7b"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7701), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("7e88cf5c-f9a9-4511-8d13-f72c48f7fe48"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7707), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("7fd601e6-f137-4259-9b38-e2dde3704ae9"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7770), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("91eba503-73c5-409c-98f6-b09f063261bb"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7750), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("a484fc55-f8c8-4759-9329-21fcc3d9b523"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7748), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("ab9f970d-5ccf-43a9-a3ec-8dac82558974"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7704), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("b0aeec14-9be2-42b9-a951-3932980833c8"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7674), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("b404ea7d-d6b2-43e5-aa99-956351ab321e"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7677), true, null, "How can I get a quote for my project?", null },
                    { new Guid("baa27527-297c-4359-961d-35230969fd5e"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7753), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("c143a19c-7890-455a-a751-85d5a06925d7"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7756), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("cbb0e44b-9fa5-41a5-be92-67815b661dd7"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7732), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("cdf2ae17-bbcc-4cde-aa75-0ccdb97407fe"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7738), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("d5a7eb9d-d122-4692-b9ec-f740cd618a64"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7761), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("e0a3997d-71b8-4d42-9e8c-283ccddd80be"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7728), true, null, "How do I pay for my project?", null },
                    { new Guid("e34abb56-d99c-4196-b207-18b3461c1841"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7664), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("f5e29e9b-880a-4e63-9a6f-40fc978d5ef4"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7710), true, null, "Do you offer financing options?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("276ed141-0dee-49c3-8282-2bf60b69f502"), null, null, new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(6975), "James", 0, new Guid("c597f0ab-36e8-4e9f-9a5f-11011dacb63b"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("d8b5926e-a296-4917-bf13-4181b5cce76b"), null, null, new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7042), "Charles", 0, new Guid("e64476eb-12b7-4053-929f-55378baba253"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c597f0ab-36e8-4e9f-9a5f-11011dacb63b"), 0, "bb8b2f24-a2e6-475d-a768-1aa905bad872", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBaU0hH2NebvDZo9VKGtkJAzI2i/Y1Zp/FWYEKlfssTcxlRaU0F1HFEXyHOT+eaWfQ==", "+639672814641", false, "362620b4-ac50-ec2a-c24b-d71cbcce3b79_20240704053725065", false, "jc.mangubat@hotmail.com" },
                    { new Guid("e64476eb-12b7-4053-929f-55378baba253"), 0, "6edd55eb-6966-4061-804e-89a6f5649c03", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEJUYqw1tfcGd4yDQHUBNfcWKFiFY9DqocZViOrTQ5AZlyzfGqH+kdQAytLt/06SsVg==", "+639951225449", false, "362620b4-ac50-ec2a-c24b-d71cbcce3b79_20240704053725065", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("8dd8d4b8-7634-45de-9e03-d67e70462386"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7296), true, "8000", "Davao del Sur", new Guid("d8b5926e-a296-4917-bf13-4181b5cce76b") },
                    { new Guid("962b11bf-4bc1-415d-8a4f-9b2b4092ce7c"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 7, 4, 5, 37, 25, 211, DateTimeKind.Utc).AddTicks(7285), true, "8000", "Davao del Sur", new Guid("276ed141-0dee-49c3-8282-2bf60b69f502") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") },
                    { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") },
                    { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") },
                    { new Guid("f81681e8-7fa5-44b0-80f3-7668f1391e8e"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") },
                    { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9") },
                    { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9") },
                    { new Guid("cc819816-c998-4ebc-8e8f-da726396e8b3"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9") },
                    { new Guid("4360de95-098a-4322-9df2-f351a9be62d0"), new Guid("30fbf473-4ea0-476c-b592-671ba6e54957") },
                    { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new Guid("30fbf473-4ea0-476c-b592-671ba6e54957") },
                    { new Guid("fe738283-8299-4aef-bece-a007aec36cad"), new Guid("384dad1c-71ea-4b50-82fb-0682b0087194") },
                    { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777") },
                    { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777") },
                    { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49") },
                    { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49") },
                    { new Guid("fe738283-8299-4aef-bece-a007aec36cad"), new Guid("d72caab6-e279-434f-b5d7-fa7c04c6e04e") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("1e931ebd-228f-4a17-85a4-06af80060134"), new Guid("d72caab6-e279-434f-b5d7-fa7c04c6e04e"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6445), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("3ecff49a-aba8-40ba-b0c8-3a4206d1e897"), new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6188), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("42edf25f-8370-45e7-9ba0-e5dadf760ff6"), new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(5990), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("73436dea-7695-4108-9b7e-7e14605c6908"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6362), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("c9562eaa-75a3-4c91-92db-105ccc44868c"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6402), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("d6c12642-90e7-47cd-92a7-e67b16e70072"), new Guid("0db940f0-87b3-4120-a1f9-a7c3e99d917d"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6228), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("db9d6f06-4c82-40bf-972a-7c239b168501"), new Guid("30fbf473-4ea0-476c-b592-671ba6e54957"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6084), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("e2b0b919-a36d-4209-86f7-6d365de869ae"), new Guid("384dad1c-71ea-4b50-82fb-0682b0087194"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6488), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("e7eb4e27-4be3-40bc-91b9-64b80bdf7e36"), new Guid("aeb97e45-383b-4688-941a-5f67e11a3265"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6144), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("1082f107-86be-4594-ada3-12a206383eca"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6404), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("40ae026a-026c-4bc5-a796-5cba6918237c"), new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6013), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("68013dcd-29de-4c92-99d9-4bf79916efa4"), new Guid("0db940f0-87b3-4120-a1f9-a7c3e99d917d"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6241), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("6a48859d-5c5d-416b-8a0a-dd1af6e3df33"), new Guid("384dad1c-71ea-4b50-82fb-0682b0087194"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6493), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("6cb9c6c1-4c05-44dc-af46-29e1ecea5404"), new Guid("30fbf473-4ea0-476c-b592-671ba6e54957"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6105), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("872a2f8c-e210-4e06-bb3b-6a5a9b65eec1"), new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6190), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("a30ab315-c843-4478-bf94-e5a41669263c"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6366), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("adfe229c-f301-4a0d-876d-45f1a3fea30a"), new Guid("aeb97e45-383b-4688-941a-5f67e11a3265"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6148), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("cc18342e-f71e-4e15-859c-4682aa13c135"), new Guid("d72caab6-e279-434f-b5d7-fa7c04c6e04e"), new DateTime(2024, 7, 4, 5, 37, 25, 217, DateTimeKind.Utc).AddTicks(6454), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "IsActive", "Style" },
                values: new object[,]
                {
                    { new Guid("00a455a3-3211-4962-81b6-6168625711f2"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1881), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", null, true, 0 },
                    { new Guid("0302b5e1-5596-4a11-93ce-cc5bfda76015"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2391), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", null, true, 0 },
                    { new Guid("0798ea3c-6d3f-4f2d-8c50-554cc06f4f1e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3909), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", null, true, 0 },
                    { new Guid("0a55bb88-54fd-4f81-a85a-c08279e31d01"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3395), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", null, true, 0 },
                    { new Guid("0ba92036-253e-4d7f-8cf2-bd8d15cf57a0"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3528), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", null, true, 0 },
                    { new Guid("0db5cf6c-343e-4884-91b1-0796c2971b1b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3779), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", null, true, 1 },
                    { new Guid("0f5da82b-dc37-410f-9f98-271e5bb5a5f5"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3498), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", null, true, 0 },
                    { new Guid("1088bdc2-d2d7-49dc-9c32-3ec3dcdd2ef2"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2508), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", null, true, 0 },
                    { new Guid("12567162-37ec-4ab3-be7b-7964ac01865c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3334), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", null, true, 1 },
                    { new Guid("16210c82-0602-4780-b8cc-fbf1b7b6b514"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4171), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", null, true, 0 },
                    { new Guid("1721d55f-84f2-41e6-9c76-03d0d8681d7f"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3037), new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", null, true, 0 },
                    { new Guid("17bfc6dc-2484-4d0b-a06a-67f932251395"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3728), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", null, true, 3 },
                    { new Guid("18fb7df1-7624-4a6b-bb97-71892d51335c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3059), new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", null, true, 0 },
                    { new Guid("19efc8d3-2f5d-4435-afad-813ee0712631"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3487), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", null, true, 0 },
                    { new Guid("1b3ecbf6-e7a3-4556-9276-671dbbe49f47"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4234), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", null, true, 0 },
                    { new Guid("1b3f9a0f-003a-4d48-a4af-91fca548bf56"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2409), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", null, true, 3 },
                    { new Guid("20e9a4ca-271b-4b10-b414-8e77aeb6ca20"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2341), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", null, true, 0 },
                    { new Guid("235b0b34-35b4-488b-8f67-c43ccf406bc8"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4196), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", null, true, 0 },
                    { new Guid("25a31cdb-4051-4c6c-beab-d5ca6ddcc534"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2324), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", null, true, 0 },
                    { new Guid("25b6ad9f-05b3-46f2-9954-449bb7ad392e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3240), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", null, true, 0 },
                    { new Guid("26631cfa-63a4-49a5-9937-ffdecb13f271"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2819), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", null, true, 0 },
                    { new Guid("28166260-11e1-4765-8446-3dfe1c3d2abd"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2977), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", null, true, 0 },
                    { new Guid("29a00c5b-8633-4d38-9b17-a3d542bf1496"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3983), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", null, true, 0 },
                    { new Guid("2c5c7db2-92b0-4a31-b657-3f8c3c306436"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4051), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", null, true, 0 },
                    { new Guid("2f321ef5-ee53-4ffc-b672-c416b4265550"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2356), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", null, true, 0 },
                    { new Guid("3033232b-be7a-48cd-80db-7e754c8d98fd"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3924), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", null, true, 0 },
                    { new Guid("31a6a755-7f55-4def-a0a0-ef2f5b4ec8c6"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2193), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", null, true, 0 },
                    { new Guid("3287f7ef-c30d-485e-9eed-cabc67f7466f"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3481), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", null, true, 1 },
                    { new Guid("3339f0a9-cd4f-4241-b6af-c8b3ff7ca0fa"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3389), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", null, true, 0 },
                    { new Guid("34a176d5-94a7-49b7-bd1e-515690bdd40e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3756), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", null, true, 0 },
                    { new Guid("370ca049-74b4-44ed-b915-ee568ad54602"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2931), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", null, true, 1 },
                    { new Guid("37ab0dd5-33ed-496c-902c-a08e367ddc31"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3465), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", null, true, 3 },
                    { new Guid("3b595c41-5eaf-4f6d-91e4-0389f57a5e65"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4201), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", null, true, 0 },
                    { new Guid("3c8bbb15-ed2d-4d6e-8bd6-5a169143d985"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3146), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", null, true, 3 },
                    { new Guid("3d785141-8a0d-4858-9cf5-e08223b25503"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4072), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", null, true, 0 },
                    { new Guid("42930a17-1753-4118-b625-db3ac527fda4"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3504), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", null, true, 0 },
                    { new Guid("45fc6a26-2021-412f-ae33-82f6e85cbfa7"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2524), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", null, true, 0 },
                    { new Guid("49759004-ea9e-403c-b543-17f8d005e4ca"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3904), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", null, true, 0 },
                    { new Guid("4d19cd84-9c57-4aef-81c2-7076b09b9d9b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4184), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", null, true, 0 },
                    { new Guid("4f29504e-fdf3-494b-8c26-58095bee0301"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3044), new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", null, true, 0 },
                    { new Guid("4f7c5868-0d0e-4e69-9da8-577474259abb"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2375), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", null, true, 0 },
                    { new Guid("51fa78f2-9de8-4fd5-aa5b-69e639008861"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3384), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", null, true, 0 },
                    { new Guid("53ea1a37-ffcf-4d29-8601-0bf45f95fcf2"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3177), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", null, true, 0 },
                    { new Guid("55b8c992-962a-4bcb-89e3-9379b4ab02b9"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2833), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", null, true, 3 },
                    { new Guid("57f4f952-115e-4975-8dcb-0052fb583a5a"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3916), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", null, true, 0 },
                    { new Guid("5d04d148-2bc9-45e0-832d-5344c7401f5c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4164), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", null, true, 1 },
                    { new Guid("5db2477c-1211-4ef8-8248-34b497dc9c38"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2131), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", null, true, 0 },
                    { new Guid("684bd8b0-b93c-49df-921f-dadd414699b3"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1861), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", null, true, 0 },
                    { new Guid("68b12be5-3889-4cfa-9c14-c211c6b006f3"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2013), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", null, true, 0 },
                    { new Guid("69997185-606c-4afb-abc5-50c55722e3be"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2529), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", null, true, 0 },
                    { new Guid("6b1b902e-a213-42dc-a763-56fa4797909b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2349), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", null, true, 0 },
                    { new Guid("6ba87ea5-b671-4f20-ab2d-49f59842c554"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2842), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", null, true, 0 },
                    { new Guid("6bd6ec63-f3d1-49fd-b65c-9e6b9f89d392"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4077), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", null, true, 0 },
                    { new Guid("73a47273-c50d-49f8-a68d-da71e7f19d49"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1892), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", null, true, 0 },
                    { new Guid("7668907c-6988-468f-bea4-390422b2e087"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1980), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", null, true, 1 },
                    { new Guid("82b4437c-5f5a-4987-aa4e-0fe70890369f"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2003), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", null, true, 0 },
                    { new Guid("8318c9ab-9315-45b8-b945-282ccae98c34"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4058), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", null, true, 0 },
                    { new Guid("8415ce86-fa99-4354-9fb3-d583af5f4ba8"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3306), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", null, true, 0 },
                    { new Guid("877d51f0-fc6c-4512-b242-179fac58c2f2"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2970), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", null, true, 1 },
                    { new Guid("88070a73-65de-44e8-91a2-bbe0aaa1b60b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3696), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", null, true, 3 },
                    { new Guid("8915e26c-2d5f-4117-b793-6baee40f8b44"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2174), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", null, true, 0 },
                    { new Guid("898ce64e-9848-45fa-b26d-41bebcb8dea3"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2184), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", null, true, 0 },
                    { new Guid("8a203c44-172a-43ce-8518-cb385639bab8"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3165), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", null, true, 0 },
                    { new Guid("8db4f99b-6448-453e-a7f0-98a1b10277b1"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4213), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", null, true, 3 },
                    { new Guid("8e35ef79-a977-4fc2-a532-8a0eace36f5f"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2385), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", null, true, 0 },
                    { new Guid("8e466a7a-a042-461c-b3c9-f39532fc491a"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3247), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", null, true, 0 },
                    { new Guid("8eb89149-0290-4e7c-8483-a84f7090bb0d"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3231), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", null, true, 0 },
                    { new Guid("91a9b69f-e316-47a2-970a-f8a1315eacc3"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2136), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", null, true, 0 },
                    { new Guid("91cc47fe-1213-4d3f-91aa-cf71e67623d7"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3767), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", null, true, 1 },
                    { new Guid("91d1a60c-c5a8-4017-9fa4-1ee99305da38"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2519), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", null, true, 0 },
                    { new Guid("92a391ce-d212-4f15-845a-f84e4de468e2"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2103), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", null, true, 1 },
                    { new Guid("935087ac-ba8c-420c-a1d2-d8b572daf28d"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2953), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", null, true, 1 },
                    { new Guid("963aebcf-9162-4ee2-abd8-81c247218ae4"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1997), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", null, true, 0 },
                    { new Guid("975ab919-0ccd-44d4-9069-97cc5f78d508"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3064), new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", null, true, 0 },
                    { new Guid("9898ce75-9adf-4ad2-b906-7b8c819f63fc"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3850), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", null, true, 1 },
                    { new Guid("9a235b4b-af6b-4022-b116-23ef7b841d7e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3522), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", null, true, 0 },
                    { new Guid("9a84ca76-a878-4073-9b6c-53dd44f4f0ad"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2123), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", null, true, 0 },
                    { new Guid("9c1dd71a-0abd-4428-b6dd-b34eaabf2da4"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3715), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", null, true, 1 },
                    { new Guid("9c6732c3-206c-469b-8782-7a4709f42da7"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3313), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", null, true, 0 },
                    { new Guid("9cbbea2d-7471-4157-b1b5-8bbb87c576ce"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4179), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", null, true, 0 },
                    { new Guid("9cc20b16-89f5-4025-9189-f40c6dd3543a"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3990), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", null, true, 0 },
                    { new Guid("9e6f6ec4-2e1d-4193-b19f-7d68f7ed7568"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4226), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", null, true, 0 },
                    { new Guid("9e81758f-0f2a-41d9-96ff-22f215756a2c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2534), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", null, true, 0 },
                    { new Guid("9f695a81-a8d3-43a3-b1d9-8e8e30b5d2ba"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3751), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", null, true, 0 },
                    { new Guid("a13db329-00b8-4334-a467-fe51c3df4a64"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2076), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", null, true, 0 },
                    { new Guid("a58eb88e-434b-4d54-a725-ab757d7e658e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2939), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", null, true, 0 },
                    { new Guid("a6edd243-581d-49c8-a572-91e1f1a26376"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2336), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", null, true, 0 },
                    { new Guid("a9b2437f-ab33-43d7-86dd-0cb9df7a5a17"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4145), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", null, true, 0 },
                    { new Guid("acac3445-64cf-4864-92ba-04403ed1fb44"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3373), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", null, true, 0 },
                    { new Guid("b2003e28-ea0e-4474-aaec-d882cfacf3cc"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2983), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", null, true, 0 },
                    { new Guid("b2eafb83-5646-4bed-aca4-216dfec69130"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4220), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", null, true, 0 },
                    { new Guid("b9248ef8-7912-416c-9eaf-64d9990ba786"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3680), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", null, true, 1 },
                    { new Guid("ba16b882-a96c-4383-81be-732de92b0d3b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2085), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", null, true, 0 },
                    { new Guid("bbbb2f12-37bd-4d31-b554-df690af151de"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3743), new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", null, true, 1 },
                    { new Guid("c2f9a90a-50df-490b-a993-f22a4a46eb4a"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2706), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", null, true, 1 },
                    { new Guid("c55c7913-b4d4-417f-bd0f-cc4b47798925"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2198), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", null, true, 0 },
                    { new Guid("c8dd5722-f619-4de2-a343-ecab490cf60e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3867), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", null, true, 0 },
                    { new Guid("c9130bbe-7c6f-4782-9c9f-e3b00fdb3b17"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2331), new Guid("e3874308-9651-4722-af95-74af7e1853e2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", null, true, 0 },
                    { new Guid("cbb29155-2867-4799-b6ee-eee925f81668"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2273), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", null, true, 1 },
                    { new Guid("cc86bd71-d730-4897-84ca-fbb4e4f5c464"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3346), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", null, true, 0 },
                    { new Guid("cd2e82ad-1d22-491a-ae00-33f12ebffef0"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2723), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", null, true, 3 },
                    { new Guid("ced8300a-e9df-4886-b1e7-03feed2b197f"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3154), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", null, true, 0 },
                    { new Guid("cee3fd60-c808-4603-8c97-4aca48268b18"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3492), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", null, true, 0 },
                    { new Guid("cefdb73f-29b0-4ea6-9751-e3508be3ea40"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4006), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", null, true, 0 },
                    { new Guid("cf96fcb4-1903-4622-8d82-d0881ca2646d"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2008), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", null, true, 0 },
                    { new Guid("d1856e30-c5e3-4801-b1dc-edfefb78da56"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4000), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", null, true, 0 },
                    { new Guid("d1a26b3f-fa7c-4690-8b4e-0c4e7ec7e77a"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2112), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", null, true, 0 },
                    { new Guid("d2bcb670-9881-486f-ae0d-dcc6dc7ed1da"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2513), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", null, true, 0 },
                    { new Guid("d359cd3a-d5c2-44db-b70f-a44ba7c007c0"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3367), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", null, true, 1 },
                    { new Guid("d47fd015-e59d-4d0f-95aa-2c302e2eae75"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4083), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", null, true, 0 },
                    { new Guid("d494f0c0-7dc1-43b8-ace8-4d2d0e77141d"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3874), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", null, true, 0 },
                    { new Guid("d611ba9a-0faf-4739-bfb7-a3848e94b62b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2117), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", null, true, 0 },
                    { new Guid("da00be4f-be71-4020-8c97-007abd29dfd4"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3171), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", null, true, 0 },
                    { new Guid("dc4e4eb7-ea84-49fe-aa31-91322c098aa1"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3533), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", null, true, 0 },
                    { new Guid("e0ebde94-9efd-4aa7-994a-6bd195663144"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3898), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", null, true, 0 },
                    { new Guid("e12fda2d-a2e0-4285-b842-bad64c9e1b90"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3054), new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", null, true, 0 },
                    { new Guid("e2153f2a-6ca9-466b-9a84-cde8ecb97cf0"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3341), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", null, true, 0 },
                    { new Guid("e226cb8e-9443-4f83-9cd3-59019b4613da"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3160), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", null, true, 0 },
                    { new Guid("e815d482-b50c-4110-af05-bb3ecbaed70c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3070), new Guid("ed398e88-4e12-477c-9317-b051259fa68b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", null, true, 0 },
                    { new Guid("eb71234e-7c42-4332-a201-3c2c74ab50fa"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(1875), new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", null, true, 0 },
                    { new Guid("ef8faba0-a566-4250-aa44-c83240ee1cdd"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3514), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", null, true, 0 },
                    { new Guid("f0416db9-57ca-4e57-9157-9bb90fa4359e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3355), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", null, true, 0 },
                    { new Guid("f0bf0b7a-5241-446b-9580-a39538512b4c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2847), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", null, true, 0 },
                    { new Guid("f10bf180-eaf2-4734-896a-922c51d6c93b"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3879), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", null, true, 0 },
                    { new Guid("f2910760-d237-4673-bcaf-2f3aae5d2fdb"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3509), new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", null, true, 0 },
                    { new Guid("f376fa41-a294-4edf-87db-99e205748a40"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4066), new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", null, true, 0 },
                    { new Guid("f44f1a59-e01e-40be-8b78-06a00eefec0e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(4190), new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", null, true, 0 },
                    { new Guid("f4ef51e6-048c-4c69-a741-cc6e6cd749fd"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3182), new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", null, true, 0 },
                    { new Guid("f560d77b-bae8-4bef-bc08-3e4cc73e8f7f"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2502), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", null, true, 0 },
                    { new Guid("f5e748f7-8985-4f32-9892-62ff1d8f993c"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2811), new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", null, true, 0 },
                    { new Guid("f8397f7c-23ef-436c-bbe0-666f12493216"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2960), new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", null, true, 0 },
                    { new Guid("f90e09ab-8713-4be9-a1dc-854261ae12a1"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3378), new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", null, true, 0 },
                    { new Guid("fc21e4ee-e167-4a8e-83e8-b07b5b77b75e"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3892), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", null, true, 1 },
                    { new Guid("fc8959f7-3cea-4d1c-93a4-27b33b7d90d2"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2496), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", null, true, 1 },
                    { new Guid("fcdc2401-5e8a-4a88-903c-f11b62efe277"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(3859), new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", null, true, 0 },
                    { new Guid("fd874813-20c5-4fd2-89c1-90d4e1afd729"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2476), new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", null, true, 0 },
                    { new Guid("ff6e1886-56aa-4da3-8de8-dd0d3294ed70"), new DateTime(2024, 7, 4, 5, 37, 25, 219, DateTimeKind.Utc).AddTicks(2167), new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", null, true, 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("094d8454-8b30-466b-95ff-5dd389770d2b"), new Guid("c597f0ab-36e8-4e9f-9a5f-11011dacb63b") },
                    { new Guid("eca4aaa8-f212-498f-a129-5336ead52e00"), new Guid("e64476eb-12b7-4053-929f-55378baba253") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("8dd8d4b8-7634-45de-9e03-d67e70462386"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("962b11bf-4bc1-415d-8a4f-9b2b4092ce7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0e2eaab4-ebd2-43ae-b660-22d9c328d513"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0e885db1-62be-412b-81b6-473e0016f723"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1b45914f-e0d7-4cef-a604-a081b92bede4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("247aa9a4-8b90-4011-9763-d4ceeff89b23"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("39a86a8b-d686-4a2a-8d83-7934f9b4335b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3ff503c1-cb81-44a1-878a-37cd6e56043f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("43fbd20d-d4f1-4e16-82bf-65a2197d516b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4e13ef53-d7cc-435d-9c1b-73294c31b5bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4f9c534d-e875-4f09-a09a-8fb0c4e8143a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5691f198-51ca-45c0-9597-1cb93d0d3b0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5bb29f91-3d6d-4789-b33a-830ed2503c75"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("658d72a8-02e3-42fe-b9cf-cae2336e6ddd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("682178b4-f2cb-4853-8614-ac65a5713374"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("75ea084b-300c-4ed5-9c74-4807973af422"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("82c0945b-447e-46b2-b52d-fcf796b52c7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("853f5e03-01c2-4d78-9482-4ba22153d557"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("97c89b9b-7f76-4379-8ce1-45bf1f2c45ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9ed28b1f-c1c2-4da0-a797-f296cbf2c9f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a06c9416-7dda-4f9d-880e-a498c768dc68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a80ac543-328f-4998-a2b5-c950c2cb76fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a810e713-0599-4571-8885-b46d85a14952"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ae7e0b15-83b0-4dd4-9e3f-e3a2d81e86a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b0db665f-dd0b-4191-a122-e09ba34d88dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b13d971b-5c4a-4179-b9e5-dd6ee59802a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b194c93b-6780-4c4d-b4db-33790f5c685f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("baa46a9f-fc15-45bb-9750-d66a341ec1de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c4bfc7dd-3a19-4d23-85ec-29b13f3f9f4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ca3458d4-9137-4269-9a2f-dcce10b8fa42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cdf06eb4-ccef-4cf4-bd4a-bb41b1e79b84"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e188742b-2e93-4932-b40f-5ce9ae0dcf50"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e4852136-0dce-4564-8e5b-58896dede63f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e9cdd2c6-b160-4fe1-a2d5-04ddeb6c5777"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f737a41a-4d12-4e80-b227-a9cf0b880b54"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f81681e8-7fa5-44b0-80f3-7668f1391e8e"), new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("cc819816-c998-4ebc-8e8f-da726396e8b3"), new Guid("1a5491de-e86b-4562-8c04-dab390a501e9") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("4360de95-098a-4322-9df2-f351a9be62d0"), new Guid("30fbf473-4ea0-476c-b592-671ba6e54957") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new Guid("30fbf473-4ea0-476c-b592-671ba6e54957") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("fe738283-8299-4aef-bece-a007aec36cad"), new Guid("384dad1c-71ea-4b50-82fb-0682b0087194") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"), new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"), new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"), new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("fe738283-8299-4aef-bece-a007aec36cad"), new Guid("d72caab6-e279-434f-b5d7-fa7c04c6e04e") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("1e931ebd-228f-4a17-85a4-06af80060134"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("3ecff49a-aba8-40ba-b0c8-3a4206d1e897"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("42edf25f-8370-45e7-9ba0-e5dadf760ff6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("73436dea-7695-4108-9b7e-7e14605c6908"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("c9562eaa-75a3-4c91-92db-105ccc44868c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("d6c12642-90e7-47cd-92a7-e67b16e70072"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("db9d6f06-4c82-40bf-972a-7c239b168501"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("e2b0b919-a36d-4209-86f7-6d365de869ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("e7eb4e27-4be3-40bc-91b9-64b80bdf7e36"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("1082f107-86be-4594-ada3-12a206383eca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("40ae026a-026c-4bc5-a796-5cba6918237c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("68013dcd-29de-4c92-99d9-4bf79916efa4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("6a48859d-5c5d-416b-8a0a-dd1af6e3df33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("6cb9c6c1-4c05-44dc-af46-29e1ecea5404"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("872a2f8c-e210-4e06-bb3b-6a5a9b65eec1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("a30ab315-c843-4478-bf94-e5a41669263c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("adfe229c-f301-4a0d-876d-45f1a3fea30a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("cc18342e-f71e-4e15-859c-4682aa13c135"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("378bed8c-a7b1-494d-abb5-5db7ea97d4a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("be1e0ce1-d66d-434d-878c-46ad414a05e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d1d81b06-0820-40c1-8ab0-0dd50b11df08"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f9312d5b-bc18-4b64-8ab4-93f3c203af00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("37ea9037-374b-4362-8542-fb738e566ff3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("cfd2814e-73a5-414f-b288-cff3ce84f289"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("ea89f333-dbdf-4579-9df3-620ceec69cfd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("eb1805bb-94ae-44da-a445-b70c5cc6b992"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("00a455a3-3211-4962-81b6-6168625711f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0302b5e1-5596-4a11-93ce-cc5bfda76015"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0798ea3c-6d3f-4f2d-8c50-554cc06f4f1e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0a55bb88-54fd-4f81-a85a-c08279e31d01"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0ba92036-253e-4d7f-8cf2-bd8d15cf57a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0db5cf6c-343e-4884-91b1-0796c2971b1b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0f5da82b-dc37-410f-9f98-271e5bb5a5f5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1088bdc2-d2d7-49dc-9c32-3ec3dcdd2ef2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("12567162-37ec-4ab3-be7b-7964ac01865c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("16210c82-0602-4780-b8cc-fbf1b7b6b514"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1721d55f-84f2-41e6-9c76-03d0d8681d7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("17bfc6dc-2484-4d0b-a06a-67f932251395"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("18fb7df1-7624-4a6b-bb97-71892d51335c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("19efc8d3-2f5d-4435-afad-813ee0712631"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1b3ecbf6-e7a3-4556-9276-671dbbe49f47"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1b3f9a0f-003a-4d48-a4af-91fca548bf56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("20e9a4ca-271b-4b10-b414-8e77aeb6ca20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("235b0b34-35b4-488b-8f67-c43ccf406bc8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("25a31cdb-4051-4c6c-beab-d5ca6ddcc534"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("25b6ad9f-05b3-46f2-9954-449bb7ad392e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("26631cfa-63a4-49a5-9937-ffdecb13f271"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("28166260-11e1-4765-8446-3dfe1c3d2abd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("29a00c5b-8633-4d38-9b17-a3d542bf1496"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2c5c7db2-92b0-4a31-b657-3f8c3c306436"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2f321ef5-ee53-4ffc-b672-c416b4265550"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3033232b-be7a-48cd-80db-7e754c8d98fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("31a6a755-7f55-4def-a0a0-ef2f5b4ec8c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3287f7ef-c30d-485e-9eed-cabc67f7466f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3339f0a9-cd4f-4241-b6af-c8b3ff7ca0fa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("34a176d5-94a7-49b7-bd1e-515690bdd40e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("370ca049-74b4-44ed-b915-ee568ad54602"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("37ab0dd5-33ed-496c-902c-a08e367ddc31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3b595c41-5eaf-4f6d-91e4-0389f57a5e65"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3c8bbb15-ed2d-4d6e-8bd6-5a169143d985"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3d785141-8a0d-4858-9cf5-e08223b25503"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("42930a17-1753-4118-b625-db3ac527fda4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("45fc6a26-2021-412f-ae33-82f6e85cbfa7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("49759004-ea9e-403c-b543-17f8d005e4ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4d19cd84-9c57-4aef-81c2-7076b09b9d9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4f29504e-fdf3-494b-8c26-58095bee0301"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4f7c5868-0d0e-4e69-9da8-577474259abb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("51fa78f2-9de8-4fd5-aa5b-69e639008861"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("53ea1a37-ffcf-4d29-8601-0bf45f95fcf2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("55b8c992-962a-4bcb-89e3-9379b4ab02b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("57f4f952-115e-4975-8dcb-0052fb583a5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5d04d148-2bc9-45e0-832d-5344c7401f5c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5db2477c-1211-4ef8-8248-34b497dc9c38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("684bd8b0-b93c-49df-921f-dadd414699b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("68b12be5-3889-4cfa-9c14-c211c6b006f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("69997185-606c-4afb-abc5-50c55722e3be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6b1b902e-a213-42dc-a763-56fa4797909b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6ba87ea5-b671-4f20-ab2d-49f59842c554"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6bd6ec63-f3d1-49fd-b65c-9e6b9f89d392"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("73a47273-c50d-49f8-a68d-da71e7f19d49"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7668907c-6988-468f-bea4-390422b2e087"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("82b4437c-5f5a-4987-aa4e-0fe70890369f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8318c9ab-9315-45b8-b945-282ccae98c34"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8415ce86-fa99-4354-9fb3-d583af5f4ba8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("877d51f0-fc6c-4512-b242-179fac58c2f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("88070a73-65de-44e8-91a2-bbe0aaa1b60b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8915e26c-2d5f-4117-b793-6baee40f8b44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("898ce64e-9848-45fa-b26d-41bebcb8dea3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8a203c44-172a-43ce-8518-cb385639bab8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8db4f99b-6448-453e-a7f0-98a1b10277b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8e35ef79-a977-4fc2-a532-8a0eace36f5f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8e466a7a-a042-461c-b3c9-f39532fc491a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8eb89149-0290-4e7c-8483-a84f7090bb0d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("91a9b69f-e316-47a2-970a-f8a1315eacc3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("91cc47fe-1213-4d3f-91aa-cf71e67623d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("91d1a60c-c5a8-4017-9fa4-1ee99305da38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("92a391ce-d212-4f15-845a-f84e4de468e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("935087ac-ba8c-420c-a1d2-d8b572daf28d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("963aebcf-9162-4ee2-abd8-81c247218ae4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("975ab919-0ccd-44d4-9069-97cc5f78d508"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9898ce75-9adf-4ad2-b906-7b8c819f63fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9a235b4b-af6b-4022-b116-23ef7b841d7e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9a84ca76-a878-4073-9b6c-53dd44f4f0ad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9c1dd71a-0abd-4428-b6dd-b34eaabf2da4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9c6732c3-206c-469b-8782-7a4709f42da7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9cbbea2d-7471-4157-b1b5-8bbb87c576ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9cc20b16-89f5-4025-9189-f40c6dd3543a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9e6f6ec4-2e1d-4193-b19f-7d68f7ed7568"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9e81758f-0f2a-41d9-96ff-22f215756a2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9f695a81-a8d3-43a3-b1d9-8e8e30b5d2ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a13db329-00b8-4334-a467-fe51c3df4a64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a58eb88e-434b-4d54-a725-ab757d7e658e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a6edd243-581d-49c8-a572-91e1f1a26376"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a9b2437f-ab33-43d7-86dd-0cb9df7a5a17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("acac3445-64cf-4864-92ba-04403ed1fb44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b2003e28-ea0e-4474-aaec-d882cfacf3cc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b2eafb83-5646-4bed-aca4-216dfec69130"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b9248ef8-7912-416c-9eaf-64d9990ba786"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ba16b882-a96c-4383-81be-732de92b0d3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bbbb2f12-37bd-4d31-b554-df690af151de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c2f9a90a-50df-490b-a993-f22a4a46eb4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c55c7913-b4d4-417f-bd0f-cc4b47798925"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c8dd5722-f619-4de2-a343-ecab490cf60e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c9130bbe-7c6f-4782-9c9f-e3b00fdb3b17"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cbb29155-2867-4799-b6ee-eee925f81668"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cc86bd71-d730-4897-84ca-fbb4e4f5c464"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd2e82ad-1d22-491a-ae00-33f12ebffef0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ced8300a-e9df-4886-b1e7-03feed2b197f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cee3fd60-c808-4603-8c97-4aca48268b18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cefdb73f-29b0-4ea6-9751-e3508be3ea40"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cf96fcb4-1903-4622-8d82-d0881ca2646d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d1856e30-c5e3-4801-b1dc-edfefb78da56"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d1a26b3f-fa7c-4690-8b4e-0c4e7ec7e77a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d2bcb670-9881-486f-ae0d-dcc6dc7ed1da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d359cd3a-d5c2-44db-b70f-a44ba7c007c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d47fd015-e59d-4d0f-95aa-2c302e2eae75"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d494f0c0-7dc1-43b8-ace8-4d2d0e77141d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d611ba9a-0faf-4739-bfb7-a3848e94b62b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("da00be4f-be71-4020-8c97-007abd29dfd4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dc4e4eb7-ea84-49fe-aa31-91322c098aa1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e0ebde94-9efd-4aa7-994a-6bd195663144"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e12fda2d-a2e0-4285-b842-bad64c9e1b90"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e2153f2a-6ca9-466b-9a84-cde8ecb97cf0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e226cb8e-9443-4f83-9cd3-59019b4613da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e815d482-b50c-4110-af05-bb3ecbaed70c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("eb71234e-7c42-4332-a201-3c2c74ab50fa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ef8faba0-a566-4250-aa44-c83240ee1cdd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f0416db9-57ca-4e57-9157-9bb90fa4359e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f0bf0b7a-5241-446b-9580-a39538512b4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f10bf180-eaf2-4734-896a-922c51d6c93b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f2910760-d237-4673-bcaf-2f3aae5d2fdb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f376fa41-a294-4edf-87db-99e205748a40"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f44f1a59-e01e-40be-8b78-06a00eefec0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f4ef51e6-048c-4c69-a741-cc6e6cd749fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f560d77b-bae8-4bef-bc08-3e4cc73e8f7f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f5e748f7-8985-4f32-9892-62ff1d8f993c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f8397f7c-23ef-436c-bbe0-666f12493216"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f90e09ab-8713-4be9-a1dc-854261ae12a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fc21e4ee-e167-4a8e-83e8-b07b5b77b75e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fc8959f7-3cea-4d1c-93a4-27b33b7d90d2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fcdc2401-5e8a-4a88-903c-f11b62efe277"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fd874813-20c5-4fd2-89c1-90d4e1afd729"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ff6e1886-56aa-4da3-8de8-dd0d3294ed70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("14abbad4-9c8c-45a6-bf73-0534f7b469ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2d33a7c6-66d8-435c-b448-81d0241acf5d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4ee070fd-6880-4911-8590-8d595ccb75e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("58eb2312-6465-4312-8c20-a01d03025468"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("60a461b8-f740-43ff-bd84-9986ca93c368"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6e7298dc-0204-42ac-b712-1159cb455778"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7625be3d-9bca-4be9-9869-8521bae12c7b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7e88cf5c-f9a9-4511-8d13-f72c48f7fe48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7fd601e6-f137-4259-9b38-e2dde3704ae9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("91eba503-73c5-409c-98f6-b09f063261bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("a484fc55-f8c8-4759-9329-21fcc3d9b523"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("ab9f970d-5ccf-43a9-a3ec-8dac82558974"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b0aeec14-9be2-42b9-a951-3932980833c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b404ea7d-d6b2-43e5-aa99-956351ab321e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("baa27527-297c-4359-961d-35230969fd5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c143a19c-7890-455a-a751-85d5a06925d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("cbb0e44b-9fa5-41a5-be92-67815b661dd7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("cdf2ae17-bbcc-4cde-aa75-0ccdb97407fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d5a7eb9d-d122-4692-b9ec-f740cd618a64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e0a3997d-71b8-4d42-9e8c-283ccddd80be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("e34abb56-d99c-4196-b207-18b3461c1841"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f5e29e9b-880a-4e63-9a6f-40fc978d5ef4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("094d8454-8b30-466b-95ff-5dd389770d2b"), new Guid("c597f0ab-36e8-4e9f-9a5f-11011dacb63b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("eca4aaa8-f212-498f-a129-5336ead52e00"), new Guid("e64476eb-12b7-4053-929f-55378baba253") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0c703189-6d68-4146-ae87-3f01398be1c2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4360de95-098a-4322-9df2-f351a9be62d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("82f06311-d986-48f3-88e8-c970bf671bb5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("95d3b88e-9ba9-4475-9569-e8a0ce712ac5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cc819816-c998-4ebc-8e8f-da726396e8b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f81681e8-7fa5-44b0-80f3-7668f1391e8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fe738283-8299-4aef-bece-a007aec36cad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("0db940f0-87b3-4120-a1f9-a7c3e99d917d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("0efc1c1b-2825-44d6-9045-2413dda12ef9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("1a5491de-e86b-4562-8c04-dab390a501e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("30fbf473-4ea0-476c-b592-671ba6e54957"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("384dad1c-71ea-4b50-82fb-0682b0087194"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("4e8a0f0e-c368-40f2-b33d-7bca42ab1777"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("9c58b6a2-9ebe-4254-a1c9-71627b87de49"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("aeb97e45-383b-4688-941a-5f67e11a3265"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("d72caab6-e279-434f-b5d7-fa7c04c6e04e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("094d8454-8b30-466b-95ff-5dd389770d2b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eca4aaa8-f212-498f-a129-5336ead52e00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("03c3c5fd-61c1-45c5-8711-a84b2c5d4b4f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("0a990147-af9a-410c-a287-d8e33a47ba45"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("2622fa79-27a3-467e-9775-8ea3b76c0b25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("3d86206f-5f62-4eb6-9843-560f362ca59a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("78e50d24-4f3f-4a6a-96cc-38e90255a8ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("7b6d5fa7-603a-447b-a493-ad02b919b653"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("87b5a8c9-71fc-4872-878e-997ba53366ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("8ef89c5c-3e2f-4b15-bfef-789fa99e695a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("a2a5a06b-7e77-4192-9764-777dc5e1df39"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("b0e9efe7-e590-48a2-b231-4b4a439491d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("b38f9978-b3ee-4245-8a42-b3aad20121f7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("bda095cf-fee9-4a1f-a0e6-02489411de09"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("e3874308-9651-4722-af95-74af7e1853e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("ed398e88-4e12-477c-9317-b051259fa68b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("276ed141-0dee-49c3-8282-2bf60b69f502"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("d8b5926e-a296-4917-bf13-4181b5cce76b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c597f0ab-36e8-4e9f-9a5f-11011dacb63b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e64476eb-12b7-4053-929f-55378baba253"));

            migrationBuilder.RenameColumn(
                name: "Style",
                schema: "dbo",
                table: "FeatureProjectImages",
                newName: "OrientationStyle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 890, DateTimeKind.Local).AddTicks(3790),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 52, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 905, DateTimeKind.Local).AddTicks(8196),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 63, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 906, DateTimeKind.Local).AddTicks(9140),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 64, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(4335),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 64, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(7031),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 65, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 52, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(1176),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 65, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(7554),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 65, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(1671),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 53, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(4764),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 53, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 63, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 61, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 62, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(4764),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 61, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(4468),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 37, 25, 52, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("0334ff9a-405b-49ed-bf84-df0d8ba7df4f"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8410), true, "Materials and Equipment" },
                    { new Guid("0751aa18-7f70-45b1-b5f6-76e21e2cf3bd"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8388), true, "Green Building Materials" },
                    { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8399), true, "Industry News" },
                    { new Guid("1addbd6a-cbf7-4462-a7b0-5b98ac98ebf1"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8421), true, "Real Estate Development" },
                    { new Guid("1f53fb77-11db-4be8-a943-8192d244d91d"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8390), true, "Health and Wellness in Construction" },
                    { new Guid("281cd258-03a5-49d8-a873-8ff966640266"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8441), true, "Weather and Seasonal Tips" },
                    { new Guid("2ccbb302-c1ad-417e-b151-3b07df4504f9"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8367), true, "Construction Techniques" },
                    { new Guid("2d033a4e-3124-496a-836a-f299c9ac6065"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8363), true, "Construction Finance" },
                    { new Guid("3ad901db-baaa-4921-884a-e945dd15409f"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8379), true, "Disaster Preparedness and Recovery" },
                    { new Guid("3e5219e1-4360-4aff-bb4d-12604d92a961"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8365), true, "Construction Management" },
                    { new Guid("4450c1f3-2fcd-4b5b-b5e7-65c5b9359f2b"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8383), true, "Environmental Impact" },
                    { new Guid("4b0ede20-c40e-4c65-ac2f-98b1286e4d9e"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8408), true, "Legal and Insurance" },
                    { new Guid("5200213c-fc0d-4c2a-a275-c5ae1b758cdd"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8296), true, "Accessibility in Construction" },
                    { new Guid("5b875595-c861-45b5-afc2-8bd1a8c96d3c"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8414), true, "Modular and Prefabricated Construction" },
                    { new Guid("5fd1fbc5-65fc-406f-955d-561d6c1342ab"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8356), true, "Community and Culture" },
                    { new Guid("6764c8e0-8a72-4cd2-aff3-cb7a78b97d0c"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8419), true, "Property Management" },
                    { new Guid("6cf4ec8e-c0fb-4c61-bf9b-315d703e56a9"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8381), true, "Energy Efficiency" },
                    { new Guid("6f4f42d1-66bc-4fdb-9642-816c88fd6d69"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8430), true, "Sustainability and Green Building" },
                    { new Guid("727d39fa-5dcd-41da-9e1c-d8ea39ce3801"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8354), true, "Client Resources" },
                    { new Guid("7758ca8b-be9c-4390-bf50-a039137580ce"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8427), true, "Supply Chain and Logistics" },
                    { new Guid("7830fd77-1db2-40a2-b8a8-4dfd1fc8debd"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8395), true, "Historic Preservation" },
                    { new Guid("7b38ca77-b641-4753-adad-8e8322e4a71c"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8436), true, "Training and Certification" },
                    { new Guid("862a5689-7d53-4b09-ab9b-ad324daba6ad"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8434), true, "Technology in Construction" },
                    { new Guid("88b6c8d6-8409-453a-846d-3e63b548f474"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8401), true, "Innovation and Future Trends" },
                    { new Guid("8a18aa7c-2b69-4664-8f78-8100fca788d8"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8386), true, "Equipment Maintenance" },
                    { new Guid("8d861e59-1e8c-4bda-8356-ded02b616d0d"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8360), true, "Construction Careers" },
                    { new Guid("954f5042-c177-4d10-b142-5e0d45359b1f"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8336), true, "Building Codes and Standards" },
                    { new Guid("97d439b5-ce34-43f7-aa5e-95ffbedb4209"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8339), true, "Case Studies and Success Stories" },
                    { new Guid("988fd777-e8b7-40cf-a5eb-9c558e4d51eb"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8425), true, "Smart Home Technology" },
                    { new Guid("9d68b334-fb26-43c9-a39a-cbeb1db6fd2d"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8438), true, "Urban Planning and Development" },
                    { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8341), true, "Client Education" },
                    { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8358), true, "Company Updates" },
                    { new Guid("cd498d61-c18a-4092-98d6-161204dd50aa"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8405), true, "Landscaping and Outdoor Design" },
                    { new Guid("d061137d-1f60-4a8e-a28c-7596cc62b9a2"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8369), true, "Cost Estimation and Budgeting" },
                    { new Guid("d15dba9b-23a5-4c76-8688-6c18f222ca09"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8397), true, "Home Improvement and DIY" },
                    { new Guid("d5c1666a-f204-4047-9b8e-1d0e62ab0060"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8416), true, "Project Showcase" },
                    { new Guid("db39bbdb-b753-40d1-a23a-8aaeb5e6bdec"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8423), true, "Safety and Compliance" },
                    { new Guid("e1ac9f74-c24f-4d07-a92d-cfbf91acbf52"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8377), true, "Design and Architecture" },
                    { new Guid("e4ea2923-6de5-4886-a00a-56cef6e797b4"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8375), true, "Customer Stories and Interviews" },
                    { new Guid("fd5780c7-6d1c-4df3-b89e-8f055e9cdbf7"), new DateTime(2024, 7, 4, 5, 21, 13, 908, DateTimeKind.Utc).AddTicks(8403), true, "Innovation Awards and Recognitions" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("03e9534d-06ed-411d-8567-2f1e0889e322"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1655), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("3ccdd8cc-49d1-4877-ac96-9c012c0d9fee"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1759), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("5f0be940-001f-4648-a217-20dc0879d819"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1687), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("664e8bcd-d648-4f22-9e5b-2beee17fb146"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1530), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("805ef16c-4227-491b-8526-91d9aed457b7"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1131), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1579), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1727), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1488), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("c0ff91b7-a308-451c-88a4-e3f46c596512"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1786), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2b46849b-b415-4ae9-94e1-3c88355b8b43"), null, "Moderator", "MODERATOR" },
                    { new Guid("4808ba8c-49bc-4c14-8e7b-33b1cd96fa6b"), null, "Visitor", "VISITOR" },
                    { new Guid("4db02a34-da2e-4875-bd0f-d63510e03fb2"), null, "Editor", "EDITOR" },
                    { new Guid("a8fdfac0-1ead-4468-b586-13e363b7fe2e"), null, "Admin", "ADMIN" },
                    { new Guid("bad3a2d2-496d-4ceb-a1b3-fbc2e2be6223"), null, "Manager", "MANAGER" },
                    { new Guid("f139a8b6-c508-44b8-a868-1e6d080fa8ab"), null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0a0669cf-4224-436d-9c48-04ac41f7465b"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(2361), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("1e26cc52-bb97-4ea6-ba98-543895193d1e"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(2366), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("466fe2ac-0ca1-44d2-95cc-a3418ed6d678"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(2364), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("c56c3b2f-fe8d-432c-b5ab-613d07beb5c3"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(2352), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "ImageCDNUrl", "IsActive", "Location", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4728), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "carmen-lds-chapel-general-repainting-electrical-works", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5490), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "aringay-lds-chapel-retiling-and-repainting-works", "Aringay LDS Chapel Retiling and Repainting Works" },
                    { new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5403), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "san-pedro-laguna-lds-chapel", "San Pedro Laguna LDS Chapel" },
                    { new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5303), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", true, "Davao City", "verdon-park-condominium", "Verdon Park Condominium" },
                    { new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5800), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "lds-chapel-retaining-wall-construction", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("380511be-d719-420b-9c63-6cbf898653cb"), null, new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4639), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "um-library-fire-protection-pbax-paging-systems-project", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), null, new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5004), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", true, "Sasa. Davao City, Philippines", "sasa-lds-chapel-general-repainting-retiling-works", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), null, new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4362), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", true, "Philippines", "company-workforce", "Company Workforce" },
                    { new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5154), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "muntinlupa-lds-chapel-elevator-project", "Muntinlupa LDS Chapel Elevator Project" },
                    { new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5089), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "mang-inasal", "Mang Inasal" },
                    { new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5902), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "talavera-chapel-general-repair-works", "Talavera Chapel General Repair Works" },
                    { new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), null, new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(3862), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "ladon-construction-service-davao-city-headquarter-office", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5705), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "general-milling-station", "General Milling Station" },
                    { new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), null, new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4543), null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "lds-church-improvements", "LDS Church Improvements" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("06b00fbc-dd86-4815-a29c-ef952275983d"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6394), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("075d2503-183a-44f7-8d51-af30662fa251"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6405), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("2334c6ed-d480-4f5a-af74-1a5a8bbe174a"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6404), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("345b7602-0f39-492e-8f83-25ff6df171cf"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6359), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("3dc4b52a-76f3-4840-857c-356de81bf99a"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6397), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("402d5272-0b76-4109-9a46-2e3f122a335e"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6364), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("45d8464d-bfac-4fb7-bcee-3abbabcaac06"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6385), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("4b7f71cd-53f4-4063-b6e0-68f845d71fff"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6356), true, true, "How do you handle project timelines?", null },
                    { new Guid("5554285e-67d6-48a2-a7f4-2e446a0964b4"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6390), true, true, "Are you licensed and insured?", null },
                    { new Guid("58104a82-b2af-4702-a2d8-7d2277ace3ea"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6369), true, null, "Do you offer financing options?", null },
                    { new Guid("62e5cb8f-6329-4f34-8834-cd9affad233f"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6399), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("6c4f17e0-629f-488b-bc09-cd63dd8ef42b"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6392), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("73785131-02a0-4ec7-8fb9-a9b4d7c2cc2f"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6361), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("765a9375-97b8-4572-bf3d-8b3d1c0eea56"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6354), true, null, "How can I get a quote for my project?", null },
                    { new Guid("894b50e2-b86d-4d65-9480-14f9987dc834"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6366), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("89e3b36f-5525-4a21-8a01-a463747acca5"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6408), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("8b9dff41-f508-4b04-9392-18ff2b7a7caf"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6338), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("d443bd51-4151-46cf-8617-f64936883887"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6380), true, null, "How do I pay for my project?", null },
                    { new Guid("da3d2dc6-80b2-4ab0-899a-0e946ff69e0a"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6410), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("da867e7e-9056-42f4-bca2-02ae4bd38885"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6342), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("dc3a8848-dffd-40ce-8285-edeef9f624d7"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6383), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("df9d0292-4633-482c-b0e5-8fcadb95a6e2"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6371), true, true, "Are there any hidden fees in your estimates?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("2191f962-bcab-4d7a-a093-bd3c0ed47917"), null, null, new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6177), "Charles", 0, new Guid("8960a695-c03d-432d-96b0-c8681dceed4d"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("aab62a6c-ccc5-43e5-a8fb-d130dd270a6b"), null, null, new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6130), "James", 0, new Guid("378d9979-c9b3-45f4-8211-69ae9b9d1934"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("378d9979-c9b3-45f4-8211-69ae9b9d1934"), 0, "64db6fe1-c2e2-4837-8231-67cdf13e226a", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAED4Wy0GQ9HriUlSExdFpehkKSGkBnrwFVycCQh7QR5P7Hw8T8BE1gzz6H6nIZ506ZA==", "+639672814641", false, "f9790bab-92a7-52d2-c46e-0e65d871f7d5_20240704052113908", false, "jc.mangubat@hotmail.com" },
                    { new Guid("8960a695-c03d-432d-96b0-c8681dceed4d"), 0, "de3ca03a-95da-4688-afb4-06723b176ea5", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEFkW2yjTz10kW6GSBFIuNnm7BBPgA3Q0h2vSLDXQXMhFM+5uSUrBK3l4SK2GkogmbQ==", "+639951225449", false, "f9790bab-92a7-52d2-c46e-0e65d871f7d5_20240704052113908", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("031d5da6-9e5b-442c-998c-bcf501b59a21"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6284), true, "8000", "Davao del Sur", new Guid("aab62a6c-ccc5-43e5-a8fb-d130dd270a6b") },
                    { new Guid("b97f4a2a-238f-48fa-b3c0-c6596e54996f"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 7, 4, 5, 21, 14, 74, DateTimeKind.Utc).AddTicks(6289), true, "8000", "Davao del Sur", new Guid("2191f962-bcab-4d7a-a093-bd3c0ed47917") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("6f4f42d1-66bc-4fdb-9642-816c88fd6d69"), new Guid("3ccdd8cc-49d1-4877-ac96-9c012c0d9fee") },
                    { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") },
                    { new Guid("3e5219e1-4360-4aff-bb4d-12604d92a961"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") },
                    { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") },
                    { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("5f0be940-001f-4648-a217-20dc0879d819") },
                    { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new Guid("805ef16c-4227-491b-8526-91d9aed457b7") },
                    { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("805ef16c-4227-491b-8526-91d9aed457b7") },
                    { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d") },
                    { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d") },
                    { new Guid("080e4fad-b5b8-4c21-992d-e4f60b808f24"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a") },
                    { new Guid("c74efedd-b0b4-497d-9c89-e150bb100ca7"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a") },
                    { new Guid("d5c1666a-f204-4047-9b8e-1d0e62ab0060"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a") },
                    { new Guid("7b38ca77-b641-4753-adad-8e8322e4a71c"), new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc") },
                    { new Guid("b390ab0e-dcdb-46b1-a45d-b966053a827b"), new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc") },
                    { new Guid("6f4f42d1-66bc-4fdb-9642-816c88fd6d69"), new Guid("c0ff91b7-a308-451c-88a4-e3f46c596512") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("158af346-0694-450d-869e-abda2c2f463b"), new Guid("805ef16c-4227-491b-8526-91d9aed457b7"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1453), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("3b9dabc8-c893-4724-b12c-e37952cff8c5"), new Guid("664e8bcd-d648-4f22-9e5b-2beee17fb146"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1572), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("6be71336-e09e-4b4d-933d-aee1c6baf4a4"), new Guid("03e9534d-06ed-411d-8567-2f1e0889e322"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1679), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("76c2606e-3509-4247-b4b6-793f77f017d5"), new Guid("3ccdd8cc-49d1-4877-ac96-9c012c0d9fee"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1780), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("985c544b-97c6-4bfd-baa3-b4f63f22fd0e"), new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1522), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("996c0d04-0d43-49e6-8c44-830709c7024d"), new Guid("c0ff91b7-a308-451c-88a4-e3f46c596512"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1843), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("a26e0dad-01c4-4626-a3f6-3e8f22dbfce6"), new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1645), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("a958e659-51af-4b35-b3bc-36106cb54743"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1751), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("c224204a-f9c8-47d3-a9ba-96c16ca6b410"), new Guid("5f0be940-001f-4648-a217-20dc0879d819"), "John Doe", "This is a fantastic article!", new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1721), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("0882c451-ac04-4ff3-925c-f2dd6d9ef7dc"), new Guid("664e8bcd-d648-4f22-9e5b-2beee17fb146"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1575), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("1e23de0e-7d5e-4a0a-875b-7bccc72b350c"), new Guid("b30492c1-5d43-47f9-b5fd-d44e6e01347d"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1648), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("70d1f995-f9b1-4a55-8425-cd27d3306550"), new Guid("5f0be940-001f-4648-a217-20dc0879d819"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1723), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("88b0e9c4-00b0-4ac7-961d-6b59c2a3df25"), new Guid("c0ff91b7-a308-451c-88a4-e3f46c596512"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1846), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("92be83f3-8eb2-4f35-a9d8-71592e1d101b"), new Guid("805ef16c-4227-491b-8526-91d9aed457b7"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1469), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("93c2ce5e-8b7d-49d5-9521-85997a914a91"), new Guid("3ccdd8cc-49d1-4877-ac96-9c012c0d9fee"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1782), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("acaf94ec-0c24-442c-8ba3-95b81eb2637f"), new Guid("b85ff6b8-4353-40ca-a4e0-c5158f948c9a"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1755), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("d023d242-145a-4096-9985-22e30fc7ebaa"), new Guid("03e9534d-06ed-411d-8567-2f1e0889e322"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1682), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("dd3c0b32-4c2d-467d-85a3-ecea1be7427f"), new Guid("ba7c6096-c015-4e22-b82f-63b54adfb3cc"), new DateTime(2024, 7, 4, 5, 21, 14, 78, DateTimeKind.Utc).AddTicks(1526), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "IsActive", "OrientationStyle" },
                values: new object[,]
                {
                    { new Guid("01d0b613-ab11-4d8f-b4a4-2437424bba81"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4528), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", null, true, 0 },
                    { new Guid("04820b92-3e7a-4a68-bd23-9b1a679173f5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4684), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", null, true, 0 },
                    { new Guid("05a9e22b-1ad8-4c28-9fe8-685ab4ab7074"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5134), new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", null, true, 0 },
                    { new Guid("0711816a-5307-48b9-8192-bad72f321258"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4502), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", null, true, 0 },
                    { new Guid("0d8e89bd-fa0d-4e6d-845e-560a1c7a6d86"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5852), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", null, true, 0 },
                    { new Guid("10048ea3-1b39-44dc-99ca-ef9ba926c7a5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5976), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", null, true, 0 },
                    { new Guid("10a0feb2-2752-47a3-b10b-7730e107ca8c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4574), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", null, true, 0 },
                    { new Guid("127688bd-c652-4298-b94c-8af2c1854170"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4621), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", null, true, 0 },
                    { new Guid("130bba8b-1577-4bf9-a645-1636b7c5919a"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5984), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", null, true, 0 },
                    { new Guid("160fe10a-3355-45b0-9ba3-bb0d3ca65e0b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5766), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", null, true, 0 },
                    { new Guid("16411cd4-095a-4029-8868-3a481b5dc069"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5747), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", null, true, 0 },
                    { new Guid("196e7f4b-542f-4fc6-b73a-87220f2e1139"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4337), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", null, true, 0 },
                    { new Guid("1d7b6a40-74eb-401b-939a-c023d2ea47af"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4458), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", null, true, 0 },
                    { new Guid("20c0db00-227f-4a02-bdd2-fdfc503e404c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5881), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", null, true, 0 },
                    { new Guid("20eb585c-e77f-448d-8051-a03440226240"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5866), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", null, true, 0 },
                    { new Guid("21c4d643-7a96-4c04-b862-79c88445bbd5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4598), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", null, true, 0 },
                    { new Guid("22d20b88-2bc6-44cc-a268-22b620fe57af"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4498), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", null, true, 0 },
                    { new Guid("24e794df-3cf2-404c-872b-5eecd06c7b68"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5365), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", null, true, 0 },
                    { new Guid("2805a81d-f61f-4896-8672-dea75a02d55e"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(6050), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", null, true, 0 },
                    { new Guid("2822c716-173a-4a61-a04d-94558c2f2ad7"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4453), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", null, true, 0 },
                    { new Guid("2825d7a4-1a7b-4dce-bc0e-82fdeee9d9d8"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4696), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", null, true, 0 },
                    { new Guid("2ad36c9a-84b3-4b2a-802f-295a1f431551"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5858), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", null, true, 0 },
                    { new Guid("2c8b40bd-9483-4e45-a864-eb11adeab657"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5199), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", null, true, 0 },
                    { new Guid("2daaabb5-faa5-4a4f-8135-05fc9590d67e"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5456), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", null, true, 0 },
                    { new Guid("30b3671e-4343-4b52-8bfd-0fa4b2d62716"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5380), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", null, true, 0 },
                    { new Guid("33e7c3b8-077e-47d0-80d1-a31fa28e8005"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(6039), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", null, true, 0 },
                    { new Guid("34006cb5-0c0b-42ae-8861-ba081401f75c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5392), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", null, true, 0 },
                    { new Guid("346bbddb-92b0-440b-bc95-1d90a73b053d"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5485), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", null, true, 0 },
                    { new Guid("367043d3-cb97-494b-a0cc-85987ced622b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4290), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", null, true, 0 },
                    { new Guid("3b968121-bdb4-4a6b-ab5f-01aeae2167a3"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4533), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", null, true, 0 },
                    { new Guid("3dae2f74-7995-4649-90da-635a2eb0cbdc"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5993), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", null, true, 0 },
                    { new Guid("3fbc8cbc-5e9a-4e2b-9c26-18d7654bd702"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5207), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", null, true, 0 },
                    { new Guid("40d1ae53-7ab2-4118-b1f1-9ef4bb02932c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4998), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", null, true, 0 },
                    { new Guid("415e7923-b7b8-4649-8a72-f5c23820f5f2"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5971), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", null, true, 0 },
                    { new Guid("433556b6-2418-42c9-9987-b0e24b0f0870"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5755), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", null, true, 0 },
                    { new Guid("47824620-1bba-42bf-96e9-8f033cd79605"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5885), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", null, true, 0 },
                    { new Guid("4a22d652-ba6b-4d6a-ae7f-0cf65909f6a5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4582), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", null, true, 0 },
                    { new Guid("4b58f44d-7970-43ee-b583-0ce8081351fe"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5219), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", null, true, 0 },
                    { new Guid("4e432a08-d5f7-45bc-9aef-f3b28ec311a1"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4704), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", null, true, 0 },
                    { new Guid("50160210-9551-4d73-8b41-a318b90bc84c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4518), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", null, true, 0 },
                    { new Guid("50c180b4-e1ed-4004-a9fe-821c48faa193"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5782), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", null, true, 0 },
                    { new Guid("54bd3f7d-fa18-40c6-9362-b9176b8d568e"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5290), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", null, true, 0 },
                    { new Guid("59ceb868-13c3-42a0-9faf-b0811c1737ca"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5464), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", null, true, 0 },
                    { new Guid("5b1a2b5d-fb1f-4649-84c8-9fc6c76d1673"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5898), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", null, true, 0 },
                    { new Guid("5e61f8ee-77f1-4ac5-91b0-756b2a8346f5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5369), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", null, true, 0 },
                    { new Guid("607a427d-8256-460e-920d-366a0fd5d695"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4589), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", null, true, 0 },
                    { new Guid("64c4a912-d45c-462e-ad57-1e8439b4fa8d"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5384), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", null, true, 0 },
                    { new Guid("6761ba1e-463f-4c49-ade3-92d6881f0efb"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4539), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", null, true, 0 },
                    { new Guid("68bbaa63-1c5d-4974-b099-a5e269c37604"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5130), new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", null, true, 0 },
                    { new Guid("691c24f4-9e2f-4852-b14d-391ef3bd50c9"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5870), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", null, true, 0 },
                    { new Guid("69934ff8-89a0-484d-9a85-a3a2b6d39ddb"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5068), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", null, true, 0 },
                    { new Guid("6bc9b9f9-4f01-48d3-9810-ad718c3fb5f5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4712), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", null, true, 0 },
                    { new Guid("6c253d15-4c11-48ea-9a41-d2a0b4eef3da"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4344), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", null, true, 0 },
                    { new Guid("6c31eadf-23a1-41f3-a234-be0fda8f6bd3"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5619), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", null, true, 0 },
                    { new Guid("72466577-96c9-4774-8602-f18837dde331"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5343), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", null, true, 0 },
                    { new Guid("746f3e88-ef74-4cbe-89c0-e7af05db13b0"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5359), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", null, true, 0 },
                    { new Guid("7606d4bc-718b-4931-9688-e1eede4ba948"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5700), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", null, true, 0 },
                    { new Guid("7a049002-2fa5-40bc-8446-cb0dcdc2f0ed"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4700), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", null, true, 0 },
                    { new Guid("7b2e67d0-71de-4758-9793-de6a630b9c18"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4991), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", null, true, 0 },
                    { new Guid("7c5d6315-36eb-4b3c-adbd-e91fcbd0c4b4"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5194), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", null, true, 0 },
                    { new Guid("7e06ac7e-735d-41f4-b241-637b3c7508f6"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5124), new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", null, true, 0 },
                    { new Guid("7fc64261-3224-4a51-a1a2-bf34d1565722"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5057), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", null, true, 0 },
                    { new Guid("7ff1ff7c-c3d0-4d93-b361-24f8742ae855"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5604), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", null, true, 0 },
                    { new Guid("7ffd8593-ec93-4be3-8e2a-a4be1555f800"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5610), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", null, true, 0 },
                    { new Guid("801e126f-8998-4670-923c-7f3551080270"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5958), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", null, true, 0 },
                    { new Guid("80daf496-fbec-430c-8da7-e44134b429b8"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4724), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", null, true, 0 },
                    { new Guid("819ce9ab-9bca-4225-b3d7-5c56c2133751"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5950), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", null, true, 0 },
                    { new Guid("845d4c35-d7ac-43cc-90a8-42562aa70cd5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4328), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", null, true, 0 },
                    { new Guid("858da5ff-6217-4353-99cc-f387d740a05b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4708), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", null, true, 0 },
                    { new Guid("8d171970-f578-47bb-9ea1-7abcd6a1a23d"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4972), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", null, true, 0 },
                    { new Guid("8d67360b-dcd0-4ed6-b59e-ccee5e432e3b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4967), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", null, true, 0 },
                    { new Guid("91b1f480-ce17-4f9f-bb20-5fa705495f2a"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5964), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", null, true, 0 },
                    { new Guid("9331e2b0-e2eb-4db4-a013-de8430b3802e"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4262), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", null, true, 0 },
                    { new Guid("991eb80d-9222-411c-85b3-e2c49951b2e8"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4614), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", null, true, 0 },
                    { new Guid("9ddee5a0-13f5-4014-94b3-4ee8b55a6af0"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(6046), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", null, true, 0 },
                    { new Guid("9e12639c-f1d4-4bb1-876b-6043b9b48eea"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5294), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", null, true, 0 },
                    { new Guid("a14f30c4-ead9-413c-86e9-e253296a8966"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5791), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", null, true, 0 },
                    { new Guid("a3424d80-fcc4-48b8-8609-ee6735288500"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5203), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", null, true, 0 },
                    { new Guid("a4063806-30eb-49b7-a138-0eda4c59cd35"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5395), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", null, true, 0 },
                    { new Guid("a49600dc-5c95-42d6-9d9f-db9f4638acd9"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4466), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", null, true, 0 },
                    { new Guid("a557f5ab-dc91-497a-928e-ee21895e4ff6"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5473), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", null, true, 0 },
                    { new Guid("a5d2b3fe-3a1a-4eaa-8905-e611a35c58ab"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5795), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", null, true, 0 },
                    { new Guid("a810e67c-8147-4f33-a429-a1fb9ab7bceb"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5759), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", null, true, 0 },
                    { new Guid("aa426dd5-8269-47f6-9839-e29f9ce57a42"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5467), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", null, true, 0 },
                    { new Guid("ab2cc5e0-2cf4-4d6b-82b7-56a873402eb5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4443), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", null, true, 0 },
                    { new Guid("ab5ebbcc-837c-4843-8b5e-30e4a7e798f8"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5285), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", null, true, 0 },
                    { new Guid("abfaf0e7-b0df-491a-8aee-30776f84f93c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5452), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", null, true, 0 },
                    { new Guid("b02c1c9f-5bfc-4d4c-a79c-9a5b77e377b0"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5634), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", null, true, 0 },
                    { new Guid("b0ec1ac7-dd9d-45ab-bdfe-f851df8e7159"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5459), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", null, true, 0 },
                    { new Guid("b4891c73-d5ec-4331-8dcb-02e658a1a66e"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5693), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", null, true, 0 },
                    { new Guid("b4eabe6c-3271-427b-a45f-41cd2d28151b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5074), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", null, true, 0 },
                    { new Guid("b59d586d-4dfc-48dd-a6c5-8d7e5038b6df"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5763), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", null, true, 0 },
                    { new Guid("b605ee31-b475-410b-b29e-62c8774511f2"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5078), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", null, true, 0 },
                    { new Guid("b6c38247-8b11-47da-aca8-f20e305c504e"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5786), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", null, true, 0 },
                    { new Guid("b81e1ad4-5fac-443c-a924-da4ee691205b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5052), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", null, true, 0 },
                    { new Guid("bc18108e-47bc-4bc0-8ec5-5217ba9ee9a0"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4957), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", null, true, 0 },
                    { new Guid("bdee167c-59f1-4cc9-8134-68f0960e6be4"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5980), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", null, true, 0 },
                    { new Guid("be1afadb-84e5-4083-a15a-01ee5e7f49cb"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4626), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", null, true, 0 },
                    { new Guid("bed04bf8-322d-47a4-8511-ee3739fbec6f"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5085), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", null, true, 0 },
                    { new Guid("bf387910-ffeb-40da-b385-9df5ddeec606"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4435), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", null, true, 0 },
                    { new Guid("c11cc0ae-4881-42a4-bc99-1115623a41a9"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5147), new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", null, true, 0 },
                    { new Guid("c2165fdf-7fb0-41f8-98d1-9b8b8760dc19"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5968), new Guid("9b703338-f149-4e59-aeaa-7184b80d9a2f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", null, true, 0 },
                    { new Guid("c378775b-4981-4495-91fc-324e1d2770c4"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4524), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", null, true, 0 },
                    { new Guid("c3c52b4e-9003-48d5-b90d-c64f9d1f90be"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5625), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", null, true, 0 },
                    { new Guid("ca069ae3-790c-449c-b60b-066e910a9014"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5349), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", null, true, 0 },
                    { new Guid("cb368070-f056-4565-8c5f-9fde38b53165"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5139), new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", null, true, 0 },
                    { new Guid("cd11462e-b614-4d12-81a6-5b443667228c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5355), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", null, true, 0 },
                    { new Guid("cd1fb367-3356-4316-a146-65fdbd495de6"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5442), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", null, true, 0 },
                    { new Guid("cd267f70-5edd-4178-922a-e4f05a21cf33"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4634), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", null, true, 0 },
                    { new Guid("cddcf9d5-5282-417e-840b-1feef6d989f2"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5889), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", null, true, 0 },
                    { new Guid("ced155ec-69af-4265-bb21-061593e0638c"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5773), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", null, true, 0 },
                    { new Guid("d104c0b1-45d8-4e87-aa7f-c46d4d6490c8"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4579), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", null, true, 0 },
                    { new Guid("d36a000d-b80f-4ed4-bc4b-449b92c19899"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5862), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", null, true, 0 },
                    { new Guid("d49f3ffe-d4cc-49e3-8333-5abd54b15b32"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4514), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", null, true, 0 },
                    { new Guid("d4bb3683-717d-4f6c-b19c-a1c88743571a"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5778), new Guid("d1e3d9f8-e543-492c-b93e-fd536b9715b2"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", null, true, 0 },
                    { new Guid("d839a66d-584e-412a-9642-e10cd511c663"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5630), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", null, true, 0 },
                    { new Guid("da3ac7b4-74ca-4a47-9411-02c10d7d3842"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5893), new Guid("36f482d4-5b0b-4324-81d5-2b37159fdf9f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", null, true, 0 },
                    { new Guid("dcc5187b-1543-40cc-8641-612476ef2eae"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4333), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", null, true, 0 },
                    { new Guid("dce35d52-a8c8-41c5-b5ac-be309327a895"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5595), new Guid("1508035a-a1f7-4b41-accf-111d6b801a6a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", null, true, 0 },
                    { new Guid("dcfe44ec-0073-4ce0-b681-ad0d585581b3"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5064), new Guid("57b8b003-273c-4971-a093-46fa932cf91f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", null, true, 0 },
                    { new Guid("e0091979-ed4c-49e0-b920-24f53573f462"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5223), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", null, true, 0 },
                    { new Guid("e104365a-a41a-443f-9962-47eb9c1e42c7"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4593), new Guid("f9c5971b-7520-481f-83a0-28e5c13c1eb9"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", null, true, 0 },
                    { new Guid("e318bd78-4794-486d-a303-a5fe22634c42"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5210), new Guid("6e6d3fe1-6534-4cfb-8b2f-798b684b5eff"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", null, true, 0 },
                    { new Guid("e3a9e7c3-67e8-41a5-b847-2501e520887d"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4691), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", null, true, 0 },
                    { new Guid("e3bf04ac-f378-49e5-93a4-bbc28e947e33"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4286), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", null, true, 0 },
                    { new Guid("e50d8d0d-b92d-4de1-8cdb-7ef78a8de567"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4976), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", null, true, 0 },
                    { new Guid("e5ea67c9-833d-491e-9111-087d3a7f4e4b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5449), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", null, true, 0 },
                    { new Guid("e67dead8-4024-4dfd-a9b4-794b06cb799a"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4717), new Guid("380511be-d719-420b-9c63-6cbf898653cb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", null, true, 0 },
                    { new Guid("e6c9803b-01cb-4b94-bc29-766e34b007c5"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4984), new Guid("0ac1049f-7791-41cb-8ed2-d02a30589a5a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", null, true, 0 },
                    { new Guid("e9eacc70-1814-4f35-84f0-4e00dff2583b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5388), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", null, true, 0 },
                    { new Guid("eaade404-2443-4d25-9f50-cbc4b56fad8b"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5376), new Guid("2ad82691-2ac5-4e8d-ae0a-e941a5980b10"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", null, true, 0 },
                    { new Guid("eeba5976-4232-4b09-87c4-fce77ef5d2c0"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4296), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", null, true, 0 },
                    { new Guid("f3549633-25cf-4d5e-bac3-a22a9334f815"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4351), new Guid("d0ffd6b6-1a57-4747-b112-698287d08b36"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", null, true, 0 },
                    { new Guid("f8a0db30-9d99-45a5-8041-7b0bfb8aef24"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5477), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", null, true, 0 },
                    { new Guid("fa50a818-8e97-4f54-964e-1a122d3857c3"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(4461), new Guid("68950c87-0a42-4d16-864c-79c903eb70dc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", null, true, 0 },
                    { new Guid("fcaca8fd-2110-4acb-a89d-14cd455d16fb"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5143), new Guid("95215e43-3acb-48b8-9319-8d88c928fa7f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", null, true, 0 },
                    { new Guid("fd626a40-d4d4-40f5-a6ca-77594d85d2a9"), new DateTime(2024, 7, 4, 5, 21, 14, 79, DateTimeKind.Utc).AddTicks(5482), new Guid("27c0b779-d59c-4b7d-ac3a-e15a3c39f35c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", null, true, 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a8fdfac0-1ead-4468-b586-13e363b7fe2e"), new Guid("378d9979-c9b3-45f4-8211-69ae9b9d1934") },
                    { new Guid("bad3a2d2-496d-4ceb-a1b3-fbc2e2be6223"), new Guid("8960a695-c03d-432d-96b0-c8681dceed4d") }
                });
        }
    }
}
