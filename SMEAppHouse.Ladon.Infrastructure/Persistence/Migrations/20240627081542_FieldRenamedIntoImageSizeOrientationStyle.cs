using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FieldRenamedIntoImageSizeOrientationStyle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("3560d4d6-ef7f-4046-91b0-794a70bdbc70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("b158592b-9c99-4e03-98b2-32f7a6bc8588"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0e1e6dfd-f787-41ef-aaea-4f22e7b0594c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1c966c4d-c962-418e-8dae-a17fe86dd3e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1fea9467-e399-43ab-a14a-fbbc8b3cd6b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("201f04ee-38ee-4546-a139-f7c7b7e1f9dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("20979edd-617e-4746-89b6-af45d047d762"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2b369e5c-532d-4846-843f-01694ad6a4fa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2cf0c6c4-5fab-4cb5-9022-7a7befe9330d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2e1777c0-58e9-47e7-96c7-03b8749ef27f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3676c269-38fa-47cb-9689-b7c31cab7808"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3f3841e2-4f07-44b6-8c00-12e3db24e0f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3f5a4bd8-b28c-4a90-86ba-c6039c0f0213"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("50ea569d-399d-4d3b-b315-96a4d89e96e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("58021906-d1fd-480a-89b9-923d7992d73d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("63fbc4d4-fbc7-41b4-881b-fa0a91dec86e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("78582bed-cd29-4bf0-862b-fe5e00749465"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("78c33ede-0a8c-4248-b804-9425227996c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("8ae45cc2-0ce7-4e06-b8d4-bc49a8985b38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("93aaefc7-5f66-4c5b-90c2-f29fd969360b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("954c7d99-2539-4392-9224-a3ced6dcde25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9e2ae14a-3dd2-4cf4-8b75-5ee88e21650f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a2f236d1-a952-4608-a547-5090707cb47a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a343f305-311e-4190-adcd-272ce738481e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b36b9100-2b80-4286-ad9a-b809c8ce5739"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ba416fef-d81f-4e42-a6d1-58036971a0be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("bfed5488-e364-4d55-a0b7-7601a8978ddf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c9bb9bd9-bb8c-4c86-b097-880ac8fa6370"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e2326455-ec0c-40ae-bb07-1f9825b3ca82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e3005287-2e9c-4d38-aa97-382d7e2b20dc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ea10a757-2d2c-469b-9cc7-28b549b9ebcc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f1467209-5c98-48ab-9c31-71cf19e630db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f17feb3b-f83e-4bd1-9d9a-241a0050eae0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f6359a5b-092a-497a-9d2d-dd2a5f1e7297"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f8e87146-a16d-41cd-bbee-af7b9fb2c41b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("9bb5ec1e-c0cc-44f8-bea7-9454354f7c58"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("a6206261-9fbf-47b8-ad34-5365826cc4f3"), new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b74ccd70-17fc-49b2-94f8-378ea0be884b"), new Guid("6b1041d1-6f0f-4fe0-9334-230fa16383e5") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("632202ce-94bc-4c48-b10b-16bff5bd5d47"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("b74ccd70-17fc-49b2-94f8-378ea0be884b"), new Guid("ebec092b-9128-488f-8100-a16e56d47984") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("2a8265e5-fc59-46b6-9aac-3f70aef60dc6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("2f2ed88a-a616-421f-a044-053a50d2c89e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("30771d67-ea44-4b25-9e3e-3ef2c51beef1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("81a03ad3-9b95-4de3-8611-a5efa809a703"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("9c5e266e-ce8f-4b7b-bf31-ebc73071c845"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("a97f6714-a250-4bf2-8647-74b3a60e197c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("e12190f2-6532-4d3c-b9b3-9697d1293639"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("e8f9aa6c-6cb6-4496-86fd-1700d932118d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("ea623a50-f56f-4bc7-b01d-f93c38bd14c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("0c0eb405-631a-4fca-8f21-c9b8e5ae5e8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("22cf4579-a252-4a11-a18f-dcc0a365e6ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("33377b33-b6d4-4bcb-bdf4-e4f87670a1a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("5080ef99-710d-4b93-bf95-a37bc58d33db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("6784c92c-bd6b-48d7-968b-87de2cd41d33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("9bb30c7d-0360-4166-b71c-dedf1d4add0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("dabd6d62-9a99-4abd-9f57-f162e4d9dd9f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ea4cb576-8f2c-465d-b1e5-d6ca49eb26b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("f54d908b-0c85-4e4f-a2af-648a71f42158"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2705317d-2984-46ca-9ae4-79f31c9d1cd9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8fe4a665-ca7a-4998-b8ce-942d9cfdc5ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("93e636bc-2e96-4590-89aa-6d20b3fb7cea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dcfc7db7-3401-4281-8031-d445a4b70903"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("060360d9-1b3d-4d84-9506-02437495ceb1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("250fe48d-190a-4350-9b2f-76fb5dad414d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("3339bc44-09ca-426e-9bcc-5493deb5a0ee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("3e19222a-f5e8-4652-aaf6-ae9fb0bc2cef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("03d7887b-6c1b-47e3-9ba8-7dcee1c02a9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("054cc03a-7674-46db-8680-9cfbd312d009"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0a437b76-255d-4655-8315-98ee8396ca41"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0ac80690-a1b7-495f-b301-86bf5676b1bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0b555508-d97f-4928-8877-3e3cca571134"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0ca7cc18-7a26-4e1f-9205-daa4efe38b1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0efd8f5e-a836-41b5-a185-0b5a75bd5158"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0feeb8d1-876f-43ff-89d7-22ab290e2d22"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("100ee11e-955f-4150-ac43-4a2445767f62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("10fcd499-0453-42dd-8097-3895afadd51e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("12adf7a8-f650-4950-a7cc-73d9b503dd64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("134a6894-ab9c-446f-9710-7aea047f4ddf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("15a50b7c-2803-49bc-a001-16e9cb9b00de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("18cea1c0-fef9-419f-9d0b-64b6e5bc8f5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1922ccd4-0a2f-471e-815a-a74d401edd06"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1b3e4e26-b780-4546-a460-583658493a88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("20a30df1-0d8c-4936-808e-d3572e0f54a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2167d412-1570-4e41-b117-f4c15762ce9b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("235f3344-ec36-4c39-8e49-c61ed1d16b88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("244e7db1-e342-4bf3-b33d-e7b921159356"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("275f7694-ea9e-4d3f-869c-eea0fc01cc51"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("27f9bb9d-2e45-41ac-9747-54aad10447f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2ba463c8-aba4-4e7c-9752-9b402ceb331f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2da75489-de91-4abe-bb1e-cd91a77cd3ce"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2e537166-070b-4266-beb4-37de79ab16c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2eb5bdc9-33a6-470e-9ce3-18a610a62ffc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2f3e5885-bae5-423f-b6fa-bae80e2cd049"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3005ae5d-0531-4c27-a981-5a7bb38f4f1e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("309c4c5e-3f5c-4ea6-8876-b5116d343926"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("329e9e02-4fba-4df0-9042-84a9f2a6fd48"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("37cb74d3-4233-4aab-abcd-ea50d4668cba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("392061db-ccfd-40b4-9c0a-93a73fc69ba3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3b2e4f19-2dbd-41e3-8163-dc1d60a044bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("42dcaa7b-4350-4057-b52d-f9d3b5d50702"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("43030ce0-2f5d-47a0-9f1b-fdb521b1f039"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4a41eb24-c079-4670-ae81-a106a3673f28"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4aa3cc97-fca1-4865-90e2-da1ca41feb31"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4b93af01-0d12-4da6-9542-2813f259f3b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("51503157-6ea7-45ff-a6b1-f2e03ab0de4e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("52babae9-27b5-44f1-92cd-a073afd9b039"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("54d74296-d963-4170-be61-db6402420cff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("57238b52-7757-4736-901a-09b79bdb2c6d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("58beffca-fb75-4de4-8107-b9a038fb0ae7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5904852a-5d03-469b-8677-ecd091d7905c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5dbd7f69-db98-494f-a472-fc6c15cab8c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5fa96f7d-7aff-46eb-b6d1-1a9ef442484d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("618b5a51-3df6-4d05-b492-f472eb476de7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("63cca341-a4f4-430b-8405-25765b77c63c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("66f09492-da2c-4fda-af1c-7cafac6b9a0f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6a7a4f0e-c8be-4ebb-a00d-8d52bd870040"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6b92c356-c46a-416c-b93d-336396a3aa52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6d82c366-e824-482b-8b12-f772f0ab54c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6e87bfb9-121d-44f2-9d99-ad77a05e557a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6fac17db-8e6b-4edb-b0d0-5aec01cae1a8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6fe0314e-ebce-4bc7-b74f-523a544b1484"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("727d2ced-0879-40ea-80fa-69e62bccc3c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("76002d63-9db9-427c-b2d1-5adc4242c735"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7ae1716a-6143-4f5d-9109-f677f822ee21"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7c66e150-abfb-4071-9c7a-4b7ec8c53953"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8040da5f-1813-48dc-a43a-32d0bf9abec4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8110cc9b-450f-4976-aa92-d18b64d23c1d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("81534b45-d8ee-4ab0-a544-72cb78f2987d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("818b3198-79cd-40e1-b9b5-d393a771b9b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("846ff450-f913-4454-8fec-e4631743d8f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("84a71adb-779a-442a-b289-f1096f19e2a0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("84d7ebcb-0552-4baf-a6ea-083f74db80b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("86396396-bd53-4c49-9ce1-9fee702b1647"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("87447f00-27bf-4141-81bf-77f845cc139d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8ceabfed-7b3b-4150-a184-6dce27c8e45e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8cf577a7-ac74-402b-8b7a-62328829793b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("93f371da-94c9-4df2-895a-7a54116553b2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("95d4e5af-d310-4db2-ab38-5e682c82721a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("96da0ace-ecc2-4904-a118-c426b4c20520"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("97cef64f-c29c-4cff-bb85-9b96c1e0e8f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9a2ed219-3745-4bdb-9a73-87ac2bd98155"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9a8cfdb5-6684-405e-9801-6f9134a69536"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9f395442-cc22-457e-9b65-1f3ff25045d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9fe3b888-3f2e-40b0-a773-982e19d7b75e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a1737b44-e91a-4fc2-87a2-14e69ee8278b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a1c1d6a2-9d7e-4d29-8bce-c4db2150c2ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a6fdc177-8258-4f77-aa95-473e255bd811"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ab2631ca-b525-4a08-b86a-bd38b1f8e936"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ab596e5e-eb61-406f-9558-6419f0c016f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ac02e3a6-cba2-48a6-adcf-252cf97730af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ac1d64e1-816f-468a-bfbb-06f7fc0c3ff8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ac467980-6d11-4e0a-a7d4-8689a14a494e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ace0e900-9d9c-40c6-b26e-6b6456cfb6f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ad727091-5f10-47d6-a988-388a3c99447e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b802532b-ce7a-48b5-9149-893d1e67f3aa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b96f4ff8-9131-437a-b935-6bb261baf516"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ba3a344a-9af5-46f9-b47b-e5cb6cacc8b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bd3b713b-888b-425c-8f40-a8bf896978b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c3896f57-4f16-4407-8875-f357330c0393"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c57f2e2f-9952-4dd6-840a-a4119419ef62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c60efa05-448a-4d6e-a5c0-1808dc6d817d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c6c2451c-57aa-46c3-a2b1-d914604522bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c7aa99e9-fa5b-44ce-a5bd-bcc1d4d4eb04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ca6029a6-eb91-4b26-82da-9c018f6320e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cad90dae-3090-48b3-9505-9d49e53955fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cb561ace-f4d5-4e1c-bd63-0d8dc1877e55"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cc428fef-496e-4143-a4f9-f4429e97ebfc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cfa3ffc0-a553-4c95-ac82-e241eef18797"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d2ff48ef-87e9-44cb-82cb-cea3d2915649"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d31366cb-8dfc-4eba-b919-cbade12892f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d3bac11c-46e1-4e78-9288-776644e4be7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d3fac900-f3a1-471f-8dc7-5509fa12a8d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d463b8cf-41b5-4c82-aa6a-cc0507762511"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d5f31ac1-dec6-4915-bfe6-9dd9ac8ba0bc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d71dc348-0b69-44f9-9eef-ea28c769a461"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("db31668b-ea09-4b54-a452-edf05c721254"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dc54d563-4f2a-42bf-8c42-4ed587714a4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dcf41f62-6887-4e8f-91d1-a24b2be4bb9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("de9c4a34-1e08-4736-9352-ff447a8cc53e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("df317195-af45-4499-ad7a-299b044bdb3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("df88423e-835d-4a15-9bc9-9e8f83264991"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dfdbae41-836d-403d-82e9-155bd5dc3e6d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dfeafa79-76c2-4ce4-969b-3bd48f96196b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e13c2b76-a0c3-4692-8cfb-cfa56d2c44df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e1473c14-365a-447f-867c-bbe93fc9cb64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e2641c42-cddd-4412-8b67-ce2ed7a57bc9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e4ced15b-bd97-41fc-86a5-fe85c345f6f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e5672e8c-358b-4030-ae64-2fbd75f93805"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e7f3242d-bbeb-4919-a5bd-34659063062f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e8d01028-7b47-4014-876f-22280add408c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ee69b728-fdf3-4172-9bee-1beb87d86b18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ee78b892-c96a-4b8a-8c32-00c0b1849651"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ef00acb2-6839-4272-bff6-85043cf198ee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ef5ae7b7-7c3b-429e-9fb4-71f7d2e03640"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f0f47ecf-74a2-48b7-a374-2f5230659507"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f3817c2b-9f98-4ba5-9242-f41c2f0e9cdc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f3ae6401-60d9-4dd0-b1c8-ed6c8e925526"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f4f732e7-e070-43a5-9b89-ee97f9261c20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f5ad7f27-688e-429b-ab13-ec01d59852b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f6f672d8-cda4-4a93-a076-a3d016d83781"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f9615136-c184-4257-839c-8dea5cfe7792"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fdac08c3-19f0-4f53-82a1-185b7c8d0db4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fdd396ed-00cc-4c44-b2db-9609076d0396"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ffead9a4-d1a2-4592-8506-0dff2898aa28"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("18cf057a-56c8-429b-8356-1c2b0fad8409"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1a9cf901-b081-45ec-9b70-5faea2b04206"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1e7be39c-2fc4-47ec-9756-84e9e3baf248"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("21c635d1-07c4-477e-916f-aa97294f9862"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("288b2b41-ed0e-465a-8023-88675a010485"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("31a97636-8b6a-4191-bb1e-40077d17ed9e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("33c281aa-e6c3-40e1-ac59-6229c85c019d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3ec5ee60-8bfd-417b-ae1c-0847458ef560"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("40366a40-8b69-4cbc-9be5-af5d52b86b4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("40abe4db-b600-4264-acd3-66600046b347"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("442983bd-1269-40bb-a875-432c68eadd93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7394dbd5-88ee-4601-b539-536a6b75da87"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("83724d0b-f275-4d90-96f0-eda74ff6049b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("91ff53ab-851b-4725-8255-16ccd25f12c5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("92f696f4-7d0c-454f-8b5b-a152fc3b3a8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("ad402f2d-e1a1-4637-a7ba-d00f45266b9f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("b96468ff-ef92-4f00-9fb9-786bd39c9014"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c5e2b1b6-5447-4739-9a22-9c2cd2bbc69b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d446f4e2-dd45-4102-a0b0-11ec361c53d7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d797e714-f357-40c4-aac7-49dde012471c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("fbf94d7e-e090-4c55-99d5-21fc18844493"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("fe6c05d5-d194-47d9-b4c9-a793a37f080d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a7fd166a-9a19-40c8-8886-fb401443f805"), new Guid("27c2b14e-2caa-4e08-861e-50f51551aab6") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("46e37686-4fa3-45d9-a09c-f20376db27b1"), new Guid("4dcb7a98-16c8-4a45-9dfc-d6f5ac98f1fd") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("632202ce-94bc-4c48-b10b-16bff5bd5d47"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9bb5ec1e-c0cc-44f8-bea7-9454354f7c58"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a6206261-9fbf-47b8-ad34-5365826cc4f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b74ccd70-17fc-49b2-94f8-378ea0be884b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("25457844-1e7c-418c-9460-2dd084011e12"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("6b1041d1-6f0f-4fe0-9334-230fa16383e5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("cafd8f86-7dd2-4a8f-8f2d-5dd6b28eb835"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("ebec092b-9128-488f-8100-a16e56d47984"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("46e37686-4fa3-45d9-a09c-f20376db27b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a7fd166a-9a19-40c8-8886-fb401443f805"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("13aac922-24f3-4441-b549-e6144ca641e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("49342842-d14f-413d-ad0c-ef64bc517189"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("33d7f075-1a13-4942-b9c1-a899efc7f29f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("913e150a-9588-4a7f-8b1d-138a0757673d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27c2b14e-2caa-4e08-861e-50f51551aab6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dcb7a98-16c8-4a45-9dfc-d6f5ac98f1fd"));

            migrationBuilder.RenameColumn(
                name: "ImageSizeStyle",
                schema: "dbo",
                table: "FeatureProjectImages",
                newName: "ImageSizeOrientationStyle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 265, DateTimeKind.Local).AddTicks(6187),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 448, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(6429),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 461, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(3500),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 461, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(6942),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 462, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(8916),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 462, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 449, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(1508),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 462, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 463, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(9747),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 450, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 267, DateTimeKind.Local).AddTicks(2111),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 450, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(83),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 460, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 459, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(2902),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 459, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 275, DateTimeKind.Local).AddTicks(8572),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 459, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 449, DateTimeKind.Local).AddTicks(5636));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ImageSizeOrientationStyle",
                schema: "dbo",
                table: "FeatureProjectImages",
                newName: "ImageSizeStyle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 448, DateTimeKind.Local).AddTicks(7619),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 265, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 461, DateTimeKind.Local).AddTicks(454),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 461, DateTimeKind.Local).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 462, DateTimeKind.Local).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 462, DateTimeKind.Local).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 278, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 449, DateTimeKind.Local).AddTicks(3560),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 462, DateTimeKind.Local).AddTicks(8668),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 463, DateTimeKind.Local).AddTicks(2472),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 279, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 450, DateTimeKind.Local).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 450, DateTimeKind.Local).AddTicks(3732),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 267, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 460, DateTimeKind.Local).AddTicks(4794),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 277, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 459, DateTimeKind.Local).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 459, DateTimeKind.Local).AddTicks(8292),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 276, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 459, DateTimeKind.Local).AddTicks(1793),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 275, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 16, 11, 13, 449, DateTimeKind.Local).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 16, 15, 41, 266, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("0e1e6dfd-f787-41ef-aaea-4f22e7b0594c"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3078), true, "Construction Techniques" },
                    { new Guid("1c966c4d-c962-418e-8dae-a17fe86dd3e0"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3092), true, "Environmental Impact" },
                    { new Guid("1fea9467-e399-43ab-a14a-fbbc8b3cd6b8"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(2996), true, "Building Codes and Standards" },
                    { new Guid("201f04ee-38ee-4546-a139-f7c7b7e1f9dc"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3126), true, "Property Management" },
                    { new Guid("20979edd-617e-4746-89b6-af45d047d762"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3137), true, "Technology in Construction" },
                    { new Guid("2b369e5c-532d-4846-843f-01694ad6a4fa"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3091), true, "Energy Efficiency" },
                    { new Guid("2cf0c6c4-5fab-4cb5-9022-7a7befe9330d"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3115), true, "Legal and Insurance" },
                    { new Guid("2e1777c0-58e9-47e7-96c7-03b8749ef27f"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3095), true, "Equipment Maintenance" },
                    { new Guid("3676c269-38fa-47cb-9689-b7c31cab7808"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3060), true, "Client Resources" },
                    { new Guid("3f3841e2-4f07-44b6-8c00-12e3db24e0f9"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3146), true, "Weather and Seasonal Tips" },
                    { new Guid("3f5a4bd8-b28c-4a90-86ba-c6039c0f0213"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3071), true, "Construction Careers" },
                    { new Guid("50ea569d-399d-4d3b-b315-96a4d89e96e4"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3074), true, "Construction Finance" },
                    { new Guid("58021906-d1fd-480a-89b9-923d7992d73d"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3144), true, "Urban Planning and Development" },
                    { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3070), true, "Company Updates" },
                    { new Guid("632202ce-94bc-4c48-b10b-16bff5bd5d47"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3123), true, "Project Showcase" },
                    { new Guid("63fbc4d4-fbc7-41b4-881b-fa0a91dec86e"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3067), true, "Community and Culture" },
                    { new Guid("78582bed-cd29-4bf0-862b-fe5e00749465"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3119), true, "Modular and Prefabricated Construction" },
                    { new Guid("78c33ede-0a8c-4248-b804-9425227996c4"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3097), true, "Green Building Materials" },
                    { new Guid("8ae45cc2-0ce7-4e06-b8d4-bc49a8985b38"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3130), true, "Safety and Compliance" },
                    { new Guid("93aaefc7-5f66-4c5b-90c2-f29fd969360b"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3105), true, "Home Improvement and DIY" },
                    { new Guid("954c7d99-2539-4392-9224-a3ced6dcde25"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3113), true, "Landscaping and Outdoor Design" },
                    { new Guid("9bb5ec1e-c0cc-44f8-bea7-9454354f7c58"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3076), true, "Construction Management" },
                    { new Guid("9e2ae14a-3dd2-4cf4-8b75-5ee88e21650f"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3132), true, "Smart Home Technology" },
                    { new Guid("a2f236d1-a952-4608-a547-5090707cb47a"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3111), true, "Innovation Awards and Recognitions" },
                    { new Guid("a343f305-311e-4190-adcd-272ce738481e"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3099), true, "Health and Wellness in Construction" },
                    { new Guid("a6206261-9fbf-47b8-ad34-5365826cc4f3"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3142), true, "Training and Certification" },
                    { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3107), true, "Industry News" },
                    { new Guid("b36b9100-2b80-4286-ad9a-b809c8ce5739"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3087), true, "Design and Architecture" },
                    { new Guid("b74ccd70-17fc-49b2-94f8-378ea0be884b"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3135), true, "Sustainability and Green Building" },
                    { new Guid("ba416fef-d81f-4e42-a6d1-58036971a0be"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3128), true, "Real Estate Development" },
                    { new Guid("bfed5488-e364-4d55-a0b7-7601a8978ddf"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(2964), true, "Accessibility in Construction" },
                    { new Guid("c9bb9bd9-bb8c-4c86-b097-880ac8fa6370"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3109), true, "Innovation and Future Trends" },
                    { new Guid("e2326455-ec0c-40ae-bb07-1f9825b3ca82"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3080), true, "Cost Estimation and Budgeting" },
                    { new Guid("e3005287-2e9c-4d38-aa97-382d7e2b20dc"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3056), true, "Case Studies and Success Stories" },
                    { new Guid("ea10a757-2d2c-469b-9cc7-28b549b9ebcc"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3082), true, "Customer Stories and Interviews" },
                    { new Guid("f1467209-5c98-48ab-9c31-71cf19e630db"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3117), true, "Materials and Equipment" },
                    { new Guid("f17feb3b-f83e-4bd1-9d9a-241a0050eae0"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3133), true, "Supply Chain and Logistics" },
                    { new Guid("f6359a5b-092a-497a-9d2d-dd2a5f1e7297"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3089), true, "Disaster Preparedness and Recovery" },
                    { new Guid("f8e87146-a16d-41cd-bbee-af7b9fb2c41b"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3101), true, "Historic Preservation" },
                    { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new DateTime(2024, 6, 27, 8, 11, 13, 463, DateTimeKind.Utc).AddTicks(3058), true, "Client Education" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("25457844-1e7c-418c-9460-2dd084011e12"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6214), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6329), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6165), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("6b1041d1-6f0f-4fe0-9334-230fa16383e5"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6451), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(5837), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6383), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6246), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("cafd8f86-7dd2-4a8f-8f2d-5dd6b28eb835"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6283), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("ebec092b-9128-488f-8100-a16e56d47984"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6416), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2705317d-2984-46ca-9ae4-79f31c9d1cd9"), null, "Editor", "EDITOR" },
                    { new Guid("46e37686-4fa3-45d9-a09c-f20376db27b1"), null, "Manager", "MANAGER" },
                    { new Guid("8fe4a665-ca7a-4998-b8ce-942d9cfdc5ae"), null, "Visitor", "VISITOR" },
                    { new Guid("93e636bc-2e96-4590-89aa-6d20b3fb7cea"), null, "Moderator", "MODERATOR" },
                    { new Guid("a7fd166a-9a19-40c8-8886-fb401443f805"), null, "Admin", "ADMIN" },
                    { new Guid("dcfc7db7-3401-4281-8031-d445a4b70903"), null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("060360d9-1b3d-4d84-9506-02437495ceb1"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(7213), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("250fe48d-190a-4350-9b2f-76fb5dad414d"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(7198), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("3339bc44-09ca-426e-9bcc-5493deb5a0ee"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(7205), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("3e19222a-f5e8-4652-aaf6-ae9fb0bc2cef"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(7210), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "HideTitle", "ImageCDNUrl", "IsActive", "Location", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), null, new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6694), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", true, "Sasa. Davao City, Philippines", "sasa-lds-chapel-general-repainting-retiling-works", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6954), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", true, "Davao City", "verdon-park-condominium", "Verdon Park Condominium" },
                    { new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7630), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "talavera-chapel-general-repair-works", "Talavera Chapel General Repair Works" },
                    { new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6509), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "carmen-lds-chapel-general-repainting-electrical-works", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), null, new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6303), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "lds-church-improvements", "LDS Church Improvements" },
                    { new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6777), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "mang-inasal", "Mang Inasal" },
                    { new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), null, new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6132), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", true, "Philippines", "company-workforce", "Company Workforce" },
                    { new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7526), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "lds-chapel-retaining-wall-construction", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), null, new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(5555), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "ladon-construction-service-davao-city-headquarter-office", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), null, new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6409), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "um-library-fire-protection-pbax-paging-systems-project", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7266), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "aringay-lds-chapel-retiling-and-repainting-works", "Aringay LDS Chapel Retiling and Repainting Works" },
                    { new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7423), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "general-milling-station", "General Milling Station" },
                    { new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6851), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "muntinlupa-lds-chapel-elevator-project", "Muntinlupa LDS Chapel Elevator Project" },
                    { new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7057), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "san-pedro-laguna-lds-chapel", "San Pedro Laguna LDS Chapel" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("18cf057a-56c8-429b-8356-1c2b0fad8409"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5724), true, null, "Do you offer financing options?", null },
                    { new Guid("1a9cf901-b081-45ec-9b70-5faea2b04206"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5721), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("1e7be39c-2fc4-47ec-9756-84e9e3baf248"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5749), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("21c635d1-07c4-477e-916f-aa97294f9862"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5760), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("288b2b41-ed0e-465a-8023-88675a010485"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5745), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("31a97636-8b6a-4191-bb1e-40077d17ed9e"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5732), true, null, "How do I pay for my project?", null },
                    { new Guid("33c281aa-e6c3-40e1-ac59-6229c85c019d"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5704), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("3ec5ee60-8bfd-417b-ae1c-0847458ef560"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5750), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("40366a40-8b69-4cbc-9be5-af5d52b86b4b"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5699), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("40abe4db-b600-4264-acd3-66600046b347"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5710), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("442983bd-1269-40bb-a875-432c68eadd93"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5734), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("7394dbd5-88ee-4601-b539-536a6b75da87"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5725), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("83724d0b-f275-4d90-96f0-eda74ff6049b"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5754), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("91ff53ab-851b-4725-8255-16ccd25f12c5"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5719), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("92f696f4-7d0c-454f-8b5b-a152fc3b3a8b"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5752), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("ad402f2d-e1a1-4637-a7ba-d00f45266b9f"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5708), true, true, "How do you handle project timelines?", null },
                    { new Guid("b96468ff-ef92-4f00-9fb9-786bd39c9014"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5717), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("c5e2b1b6-5447-4739-9a22-9c2cd2bbc69b"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5736), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("d446f4e2-dd45-4102-a0b0-11ec361c53d7"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5743), true, true, "Are you licensed and insured?", null },
                    { new Guid("d797e714-f357-40c4-aac7-49dde012471c"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5747), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("fbf94d7e-e090-4c55-99d5-21fc18844493"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5706), true, null, "How can I get a quote for my project?", null },
                    { new Guid("fe6c05d5-d194-47d9-b4c9-a793a37f080d"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5756), true, null, "What are the risks of hiring self-claimed experienced builders?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("33d7f075-1a13-4942-b9c1-a899efc7f29f"), null, null, new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(3826), "James", 0, new Guid("27c2b14e-2caa-4e08-861e-50f51551aab6"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" },
                    { new Guid("913e150a-9588-4a7f-8b1d-138a0757673d"), null, null, new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(4033), "Charles", 0, new Guid("4dcb7a98-16c8-4a45-9dfc-d6f5ac98f1fd"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("27c2b14e-2caa-4e08-861e-50f51551aab6"), 0, "e7f9ad31-0374-46f3-b21a-9aec1f0f6f45", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN0IooSx4INUs76SmoenFZLYEVtjw/R+BvgAyq0OK8+qu24n+Izfij43oNjlivLZnA==", "+639672814641", false, "9548aa88-eca4-df93-284a-460f1227f0c0_20240627081113463", false, "jc.mangubat@hotmail.com" },
                    { new Guid("4dcb7a98-16c8-4a45-9dfc-d6f5ac98f1fd"), 0, "6a334e60-ad35-4e50-a71d-45fb04c958c7", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEFODSKnv35RcsfalBMeT74erAxenHzii/a439XlB78INa/q7HEWV6xgDXr15sSEQOw==", "+639951225449", false, "9548aa88-eca4-df93-284a-460f1227f0c0_20240627081113463", false, "ladonconst@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("3560d4d6-ef7f-4046-91b0-794a70bdbc70"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5610), true, "8000", "Davao del Sur", new Guid("913e150a-9588-4a7f-8b1d-138a0757673d") },
                    { new Guid("b158592b-9c99-4e03-98b2-32f7a6bc8588"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 8, 11, 13, 597, DateTimeKind.Utc).AddTicks(5591), true, "8000", "Davao del Sur", new Guid("33d7f075-1a13-4942-b9c1-a899efc7f29f") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") },
                    { new Guid("9bb5ec1e-c0cc-44f8-bea7-9454354f7c58"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") },
                    { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") },
                    { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b") },
                    { new Guid("a6206261-9fbf-47b8-ad34-5365826cc4f3"), new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4") },
                    { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4") },
                    { new Guid("b74ccd70-17fc-49b2-94f8-378ea0be884b"), new Guid("6b1041d1-6f0f-4fe0-9334-230fa16383e5") },
                    { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a") },
                    { new Guid("f96209bd-2fe5-4c18-bc33-953c647d5e19"), new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a") },
                    { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26") },
                    { new Guid("632202ce-94bc-4c48-b10b-16bff5bd5d47"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26") },
                    { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26") },
                    { new Guid("5ab38a9c-3e2f-444f-9bec-c7e275a32902"), new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3") },
                    { new Guid("b084d8bf-d290-4f61-bea2-405cfb3f97ed"), new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3") },
                    { new Guid("b74ccd70-17fc-49b2-94f8-378ea0be884b"), new Guid("ebec092b-9128-488f-8100-a16e56d47984") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2a8265e5-fc59-46b6-9aac-3f70aef60dc6"), new Guid("cafd8f86-7dd2-4a8f-8f2d-5dd6b28eb835"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6311), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("2f2ed88a-a616-421f-a044-053a50d2c89e"), new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6274), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("30771d67-ea44-4b25-9e3e-3ef2c51beef1"), new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6201), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("81a03ad3-9b95-4de3-8611-a5efa809a703"), new Guid("25457844-1e7c-418c-9460-2dd084011e12"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6240), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("9c5e266e-ce8f-4b7b-bf31-ebc73071c845"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6410), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("a97f6714-a250-4bf2-8647-74b3a60e197c"), new Guid("ebec092b-9128-488f-8100-a16e56d47984"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6444), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("e12190f2-6532-4d3c-b9b3-9697d1293639"), new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6134), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("e8f9aa6c-6cb6-4496-86fd-1700d932118d"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6373), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("ea623a50-f56f-4bc7-b01d-f93c38bd14c3"), new Guid("6b1041d1-6f0f-4fe0-9334-230fa16383e5"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6477), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("0c0eb405-631a-4fca-8f21-c9b8e5ae5e8c"), new Guid("7336a54a-fa7c-42d3-827d-ec8257bf7f26"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6412), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("22cf4579-a252-4a11-a18f-dcc0a365e6ca"), new Guid("39bd0a15-f9b5-464d-87ea-f1fc4054da2b"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6376), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("33377b33-b6d4-4bcb-bdf4-e4f87670a1a6"), new Guid("cafd8f86-7dd2-4a8f-8f2d-5dd6b28eb835"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6318), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("5080ef99-710d-4b93-bf95-a37bc58d33db"), new Guid("ebec092b-9128-488f-8100-a16e56d47984"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6447), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("6784c92c-bd6b-48d7-968b-87de2cd41d33"), new Guid("6b6a74d1-0241-408c-b95d-68225d88a63a"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6144), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("9bb30c7d-0360-4166-b71c-dedf1d4add0e"), new Guid("6b1041d1-6f0f-4fe0-9334-230fa16383e5"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6480), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("dabd6d62-9a99-4abd-9f57-f162e4d9dd9f"), new Guid("4afa89b0-53e2-4689-8151-6a7f925be9f4"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6209), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("ea4cb576-8f2c-465d-b1e5-d6ca49eb26b8"), new Guid("9b6c9906-9c85-465e-8565-db61b1d9fdd3"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6279), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("f54d908b-0c85-4e4f-a2af-648a71f42158"), new Guid("25457844-1e7c-418c-9460-2dd084011e12"), new DateTime(2024, 6, 27, 8, 11, 13, 607, DateTimeKind.Utc).AddTicks(6242), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "ImageSizeStyle", "IsActive" },
                values: new object[,]
                {
                    { new Guid("03d7887b-6c1b-47e3-9ba8-7dcee1c02a9a"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7024), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", null, null, true },
                    { new Guid("054cc03a-7674-46db-8680-9cfbd312d009"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7032), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", null, null, true },
                    { new Guid("0a437b76-255d-4655-8315-98ee8396ca41"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6492), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", null, null, true },
                    { new Guid("0ac80690-a1b7-495f-b301-86bf5676b1bb"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7259), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", null, null, true },
                    { new Guid("0b555508-d97f-4928-8877-3e3cca571134"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7700), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", null, null, true },
                    { new Guid("0ca7cc18-7a26-4e1f-9205-daa4efe38b1d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7403), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", null, null, true },
                    { new Guid("0efd8f5e-a836-41b5-a185-0b5a75bd5158"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6292), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", null, null, true },
                    { new Guid("0feeb8d1-876f-43ff-89d7-22ab290e2d22"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6460), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", null, null, true },
                    { new Guid("100ee11e-955f-4150-ac43-4a2445767f62"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6208), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", null, null, true },
                    { new Guid("10fcd499-0453-42dd-8097-3895afadd51e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6239), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", null, null, true },
                    { new Guid("12adf7a8-f650-4950-a7cc-73d9b503dd64"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6391), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", null, null, true },
                    { new Guid("134a6894-ab9c-446f-9710-7aea047f4ddf"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7049), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", null, null, true },
                    { new Guid("15a50b7c-2803-49bc-a001-16e9cb9b00de"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6180), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", null, null, true },
                    { new Guid("18cea1c0-fef9-419f-9d0b-64b6e5bc8f5e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6345), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", null, null, true },
                    { new Guid("1922ccd4-0a2f-471e-815a-a74d401edd06"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7584), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", null, null, true },
                    { new Guid("1b3e4e26-b780-4546-a460-583658493a88"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6923), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", null, null, true },
                    { new Guid("20a30df1-0d8c-4936-808e-d3572e0f54a3"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6665), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", null, null, true },
                    { new Guid("2167d412-1570-4e41-b117-f4c15762ce9b"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6385), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", null, null, true },
                    { new Guid("235f3344-ec36-4c39-8e49-c61ed1d16b88"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7478), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", null, null, true },
                    { new Guid("244e7db1-e342-4bf3-b33d-e7b921159356"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7028), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", null, null, true },
                    { new Guid("275f7694-ea9e-4d3f-869c-eea0fc01cc51"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7044), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", null, null, true },
                    { new Guid("27f9bb9d-2e45-41ac-9747-54aad10447f0"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6480), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", null, null, true },
                    { new Guid("2ba463c8-aba4-4e7c-9752-9b402ceb331f"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6403), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_12.png", null, null, true },
                    { new Guid("2da75489-de91-4abe-bb1e-cd91a77cd3ce"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7696), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", null, null, true },
                    { new Guid("2e537166-070b-4266-beb4-37de79ab16c7"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7215), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", null, null, true },
                    { new Guid("2eb5bdc9-33a6-470e-9ce3-18a610a62ffc"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6687), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", null, null, true },
                    { new Guid("2f3e5885-bae5-423f-b6fa-bae80e2cd049"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7741), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", null, null, true },
                    { new Guid("3005ae5d-0531-4c27-a981-5a7bb38f4f1e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7229), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", null, null, true },
                    { new Guid("309c4c5e-3f5c-4ea6-8876-b5116d343926"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7384), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", null, null, true },
                    { new Guid("329e9e02-4fba-4df0-9042-84a9f2a6fd48"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6814), new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", null, null, true },
                    { new Guid("37cb74d3-4233-4aab-abcd-ea50d4668cba"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6761), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", null, null, true },
                    { new Guid("392061db-ccfd-40b4-9c0a-93a73fc69ba3"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6749), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", null, null, true },
                    { new Guid("3b2e4f19-2dbd-41e3-8163-dc1d60a044bc"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7595), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", null, null, true },
                    { new Guid("42dcaa7b-4350-4057-b52d-f9d3b5d50702"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7731), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", null, null, true },
                    { new Guid("43030ce0-2f5d-47a0-9f1b-fdb521b1f039"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6910), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", null, null, true },
                    { new Guid("4a41eb24-c079-4670-ae81-a106a3673f28"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6363), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", null, null, true },
                    { new Guid("4aa3cc97-fca1-4865-90e2-da1ca41feb31"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6247), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", null, null, true },
                    { new Guid("4b93af01-0d12-4da6-9542-2813f259f3b2"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6771), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", null, null, true },
                    { new Guid("51503157-6ea7-45ff-a6b1-f2e03ab0de4e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7399), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", null, null, true },
                    { new Guid("52babae9-27b5-44f1-92cd-a073afd9b039"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6918), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", null, null, true },
                    { new Guid("54d74296-d963-4170-be61-db6402420cff"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6375), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", null, null, true },
                    { new Guid("57238b52-7757-4736-901a-09b79bdb2c6d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6660), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", null, null, true },
                    { new Guid("58beffca-fb75-4de4-8107-b9a038fb0ae7"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6296), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", null, null, true },
                    { new Guid("5904852a-5d03-469b-8677-ecd091d7905c"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6466), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", null, null, true },
                    { new Guid("5dbd7f69-db98-494f-a472-fc6c15cab8c3"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6502), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", null, null, true },
                    { new Guid("5fa96f7d-7aff-46eb-b6d1-1a9ef442484d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7483), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", null, null, true },
                    { new Guid("618b5a51-3df6-4d05-b492-f472eb476de7"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7726), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", null, null, true },
                    { new Guid("63cca341-a4f4-430b-8405-25765b77c63c"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7578), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", null, null, true },
                    { new Guid("66f09492-da2c-4fda-af1c-7cafac6b9a0f"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6217), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", null, null, true },
                    { new Guid("6a7a4f0e-c8be-4ebb-a00d-8d52bd870040"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7613), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", null, null, true },
                    { new Guid("6b92c356-c46a-416c-b93d-336396a3aa52"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7473), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", null, null, true },
                    { new Guid("6d82c366-e824-482b-8b12-f772f0ab54c5"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6890), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", null, null, true },
                    { new Guid("6e87bfb9-121d-44f2-9d99-ad77a05e557a"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6106), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", null, null, true },
                    { new Guid("6fac17db-8e6b-4edb-b0d0-5aec01cae1a8"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7497), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", null, null, true },
                    { new Guid("6fe0314e-ebce-4bc7-b74f-523a544b1484"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6083), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", null, null, true },
                    { new Guid("727d2ced-0879-40ea-80fa-69e62bccc3c9"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6824), new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", null, null, true },
                    { new Guid("76002d63-9db9-427c-b2d1-5adc4242c735"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7237), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", null, null, true },
                    { new Guid("7ae1716a-6143-4f5d-9109-f677f822ee21"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6110), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", null, null, true },
                    { new Guid("7c66e150-abfb-4071-9c7a-4b7ec8c53953"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7362), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", null, null, true },
                    { new Guid("8040da5f-1813-48dc-a43a-32d0bf9abec4"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6222), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", null, null, true },
                    { new Guid("8110cc9b-450f-4976-aa92-d18b64d23c1d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6193), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", null, null, true },
                    { new Guid("81534b45-d8ee-4ab0-a544-72cb78f2987d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6833), new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", null, null, true },
                    { new Guid("818b3198-79cd-40e1-b9b5-d393a771b9b9"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7246), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", null, null, true },
                    { new Guid("846ff450-f913-4454-8fec-e4631743d8f4"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6078), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", null, null, true },
                    { new Guid("84a71adb-779a-442a-b289-f1096f19e2a0"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7514), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", null, null, true },
                    { new Guid("84d7ebcb-0552-4baf-a6ea-083f74db80b0"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6276), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", null, null, true },
                    { new Guid("86396396-bd53-4c49-9ce1-9fee702b1647"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7605), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", null, null, true },
                    { new Guid("87447f00-27bf-4141-81bf-77f845cc139d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7719), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", null, null, true },
                    { new Guid("8ceabfed-7b3b-4150-a184-6dce27c8e45e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6213), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", null, null, true },
                    { new Guid("8cf577a7-ac74-402b-8b7a-62328829793b"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6766), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", null, null, true },
                    { new Guid("93f371da-94c9-4df2-895a-7a54116553b2"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6281), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", null, null, true },
                    { new Guid("95d4e5af-d310-4db2-ab38-5e682c82721a"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6676), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", null, null, true },
                    { new Guid("96da0ace-ecc2-4904-a118-c426b4c20520"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7394), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", null, null, true },
                    { new Guid("97cef64f-c29c-4cff-bb85-9b96c1e0e8f4"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6235), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", null, null, true },
                    { new Guid("9a2ed219-3745-4bdb-9a73-87ac2bd98155"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7380), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", null, null, true },
                    { new Guid("9a8cfdb5-6684-405e-9801-6f9134a69536"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6754), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", null, null, true },
                    { new Guid("9f395442-cc22-457e-9b65-1f3ff25045d8"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6931), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", null, null, true },
                    { new Guid("9fe3b888-3f2e-40b0-a773-982e19d7b75e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7588), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", null, null, true },
                    { new Guid("a1737b44-e91a-4fc2-87a2-14e69ee8278b"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6497), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", null, null, true },
                    { new Guid("a1c1d6a2-9d7e-4d29-8bce-c4db2150c2ae"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7014), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", null, null, true },
                    { new Guid("a6fdc177-8258-4f77-aa95-473e255bd811"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7493), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", null, null, true },
                    { new Guid("ab2631ca-b525-4a08-b86a-bd38b1f8e936"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6370), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", null, null, true },
                    { new Guid("ab596e5e-eb61-406f-9558-6419f0c016f4"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6897), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", null, null, true },
                    { new Guid("ac02e3a6-cba2-48a6-adcf-252cf97730af"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7010), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", null, null, true },
                    { new Guid("ac1d64e1-816f-468a-bfbb-06f7fc0c3ff8"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7705), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", null, null, true },
                    { new Guid("ac467980-6d11-4e0a-a7d4-8689a14a494e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7519), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", null, null, true },
                    { new Guid("ace0e900-9d9c-40c6-b26e-6b6456cfb6f6"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6745), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", null, null, true },
                    { new Guid("ad727091-5f10-47d6-a988-388a3c99447e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7691), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", null, null, true },
                    { new Guid("b802532b-ce7a-48b5-9149-893d1e67f3aa"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6060), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", null, null, true },
                    { new Guid("b96f4ff8-9131-437a-b935-6bb261baf516"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6936), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", null, null, true },
                    { new Guid("ba3a344a-9af5-46f9-b47b-e5cb6cacc8b5"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7746), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", null, null, true },
                    { new Guid("bd3b713b-888b-425c-8f40-a8bf896978b6"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6115), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", null, null, true },
                    { new Guid("c3896f57-4f16-4407-8875-f357330c0393"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7020), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", null, null, true },
                    { new Guid("c57f2e2f-9952-4dd6-840a-a4119419ef62"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7221), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", null, null, true },
                    { new Guid("c60efa05-448a-4d6e-a5c0-1808dc6d817d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7466), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", null, null, true },
                    { new Guid("c6c2451c-57aa-46c3-a2b1-d914604522bb"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6738), new Guid("13aac922-24f3-4441-b549-e6144ca641e0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", null, null, true },
                    { new Guid("c7aa99e9-fa5b-44ce-a5bd-bcc1d4d4eb04"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7388), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", null, null, true },
                    { new Guid("ca6029a6-eb91-4b26-82da-9c018f6320e0"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7710), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", null, null, true },
                    { new Guid("cad90dae-3090-48b3-9505-9d49e53955fd"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7038), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", null, null, true },
                    { new Guid("cb561ace-f4d5-4e1c-bd63-0d8dc1877e55"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7505), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", null, null, true },
                    { new Guid("cc428fef-496e-4143-a4f9-f4429e97ebfc"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6820), new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", null, null, true },
                    { new Guid("cfa3ffc0-a553-4c95-ac82-e241eef18797"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6670), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", null, null, true },
                    { new Guid("d2ff48ef-87e9-44cb-82cb-cea3d2915649"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7006), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", null, null, true },
                    { new Guid("d31366cb-8dfc-4eba-b919-cbade12892f9"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7509), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", null, null, true },
                    { new Guid("d3bac11c-46e1-4e78-9288-776644e4be7d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7623), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", null, null, true },
                    { new Guid("d3fac900-f3a1-471f-8dc7-5509fa12a8d8"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6396), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", null, null, true },
                    { new Guid("d463b8cf-41b5-4c82-aa6a-cc0507762511"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7225), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", null, null, true },
                    { new Guid("d5f31ac1-dec6-4915-bfe6-9dd9ac8ba0bc"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6100), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", null, null, true },
                    { new Guid("d71dc348-0b69-44f9-9eef-ea28c769a461"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7094), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", null, null, true },
                    { new Guid("db31668b-ea09-4b54-a452-edf05c721254"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7618), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", null, null, true },
                    { new Guid("dc54d563-4f2a-42bf-8c42-4ed587714a4a"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6352), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", null, null, true },
                    { new Guid("dcf41f62-6887-4e8f-91d1-a24b2be4bb9a"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7255), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", null, null, true },
                    { new Guid("de9c4a34-1e08-4736-9352-ff447a8cc53e"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6845), new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", null, null, true },
                    { new Guid("df317195-af45-4499-ad7a-299b044bdb3d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6927), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", null, null, true },
                    { new Guid("df88423e-835d-4a15-9bc9-9e8f83264991"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6992), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", null, null, true },
                    { new Guid("dfdbae41-836d-403d-82e9-155bd5dc3e6d"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6471), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", null, null, true },
                    { new Guid("dfeafa79-76c2-4ce4-969b-3bd48f96196b"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7609), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", null, null, true },
                    { new Guid("e13c2b76-a0c3-4692-8cfb-cfa56d2c44df"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7715), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", null, null, true },
                    { new Guid("e1473c14-365a-447f-867c-bbe93fc9cb64"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7487), new Guid("bb18b27a-e17e-4791-8ed9-2ce3ab19eaa7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", null, null, true },
                    { new Guid("e2641c42-cddd-4412-8b67-ce2ed7a57bc9"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6338), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", null, null, true },
                    { new Guid("e4ced15b-bd97-41fc-86a5-fe85c345f6f9"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6839), new Guid("6c46fa4a-e961-4efb-a03b-a5af07d2fc76"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", null, null, true },
                    { new Guid("e5672e8c-358b-4030-ae64-2fbd75f93805"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7600), new Guid("9800dae0-7955-44a6-b1d1-a01a86a649af"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", null, null, true },
                    { new Guid("e7f3242d-bbeb-4919-a5bd-34659063062f"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6485), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", null, null, true },
                    { new Guid("e8d01028-7b47-4014-876f-22280add408c"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6357), new Guid("49342842-d14f-413d-ad0c-ef64bc517189"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", null, null, true },
                    { new Guid("ee69b728-fdf3-4172-9bee-1beb87d86b18"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7242), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", null, null, true },
                    { new Guid("ee78b892-c96a-4b8a-8c32-00c0b1849651"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6476), new Guid("a740c7b4-be1f-48a3-91e1-74d6e7731ba4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", null, null, true },
                    { new Guid("ef00acb2-6839-4272-bff6-85043cf198ee"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6999), new Guid("171e5dd6-0c3e-4a45-8025-16be74d52940"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", null, null, true },
                    { new Guid("ef5ae7b7-7c3b-429e-9fb4-71f7d2e03640"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6902), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", null, null, true },
                    { new Guid("f0f47ecf-74a2-48b7-a374-2f5230659507"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6906), new Guid("dbfbaa0a-cc97-4919-a3c4-f811d3c0632e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", null, null, true },
                    { new Guid("f3817c2b-9f98-4ba5-9242-f41c2f0e9cdc"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6652), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", null, null, true },
                    { new Guid("f3ae6401-60d9-4dd0-b1c8-ed6c8e925526"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7684), new Guid("46ab51e9-7d5a-43e4-81dc-a2e8a5998aae"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", null, null, true },
                    { new Guid("f4f732e7-e070-43a5-9b89-ee97f9261c20"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6095), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", null, null, true },
                    { new Guid("f5ad7f27-688e-429b-ab13-ec01d59852b3"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7374), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", null, null, true },
                    { new Guid("f6f672d8-cda4-4a93-a076-a3d016d83781"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7413), new Guid("aadced05-b8b1-4220-becc-eef3b04228fc"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", null, null, true },
                    { new Guid("f9615136-c184-4257-839c-8dea5cfe7792"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(7250), new Guid("eea60bf9-4d82-461f-87ba-21f06f4bc93c"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", null, null, true },
                    { new Guid("fdac08c3-19f0-4f53-82a1-185b7c8d0db4"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6229), new Guid("83b8fa34-2f6b-4691-9397-1122a8e2d6b8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", null, null, true },
                    { new Guid("fdd396ed-00cc-4c44-b2db-9609076d0396"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6682), new Guid("473aca8d-3e63-4388-b2c9-798d39d9cd99"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", null, null, true },
                    { new Guid("ffead9a4-d1a2-4592-8506-0dff2898aa28"), new DateTime(2024, 6, 27, 8, 11, 13, 608, DateTimeKind.Utc).AddTicks(6119), new Guid("a14dbd5a-3ebc-4e48-ad75-632f659bbb82"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", null, null, true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a7fd166a-9a19-40c8-8886-fb401443f805"), new Guid("27c2b14e-2caa-4e08-861e-50f51551aab6") },
                    { new Guid("46e37686-4fa3-45d9-a09c-f20376db27b1"), new Guid("4dcb7a98-16c8-4a45-9dfc-d6f5ac98f1fd") }
                });
        }
    }
}
