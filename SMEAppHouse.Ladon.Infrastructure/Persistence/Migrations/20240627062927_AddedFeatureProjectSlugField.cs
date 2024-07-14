using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedFeatureProjectSlugField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("4250653e-44c2-48d8-b44a-3327d4d95378"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("add71cf8-48cc-4ae1-aa21-15bf04bf905c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("034c6fc4-b784-4b50-a210-8252d9ae7b04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("08024c3b-55a7-4ff6-8724-39bddb07e3fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("140b623e-e14a-4d8d-9ec0-9a00e936494e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("25bb04ba-2936-41e5-a87e-52fe7000b802"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("29879c76-a526-48b2-a7bb-70bc9ab8ed2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("2be22577-1742-4274-856d-9c71b6d80b3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("363a67a6-054c-4662-aea4-92ff1aa19352"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("39ef228f-3df3-4299-9ba3-651cf9689148"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4925d86e-41e1-46e5-bc60-f13e49442c8e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("60185ef7-d8bc-49d7-9da3-0d1e51f0a4c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("67b9fd42-3288-4831-ac83-b019c8a8aba2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6c7c847a-1866-4e0e-9e5e-fd396ab4f471"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("6ddf1db5-1ea1-40fd-b655-7410f65e0020"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("77623a31-b80b-410d-b1e1-b225495f8b6a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7cd068de-0a33-44ab-843a-9c063a3502b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7df66f29-356c-4423-8714-64ef89c9c602"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7ed387f4-9a8a-4072-97ce-4f0dc7669bee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("9380b341-9558-4705-b796-f41bbaa0a98e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("982d56ec-4420-4b0c-bc26-dfc7e1bcb88f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a73d3db0-fef3-4d4c-825f-bd55e2433389"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("a86287f9-9c7c-40c2-bbce-ef68cc2eee7a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ac058418-f303-4fc2-9c00-5390a0c36da2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("acde4273-4e17-4586-beeb-0255596dbc5d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("b436e1d1-529e-4c66-8ec1-fbb7eafcfd03"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("bfbcc35b-693a-41ff-beea-f21b8738a892"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c3e2412e-3c48-4649-bc57-710fffe21ac4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c7ffcc3a-35e1-485f-8aa1-fa37956db325"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cb387514-e284-4f94-8131-ff5c51972f6e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("ceb01a13-7020-476b-8a91-d7ad56281055"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e7127571-3151-4e03-aa5a-182ee9fa0863"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f1e3fa21-b6a2-41e3-858d-ec7d5597a61c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fc168850-f3c2-4b3b-8a17-eecee92ea220"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fefaf0b8-8001-494d-af07-60510b14c5bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("49a6ae66-0216-4083-b0e8-c1ce173b5a50"), new Guid("3a49b439-f8cc-40ce-819d-e80919b99294") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new Guid("3a49b439-f8cc-40ce-819d-e80919b99294") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("fa0adb48-5bf4-4e86-b262-8c8ec16317fc"), new Guid("825dedb8-ff61-43b1-a747-eeda76999bb2") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("394924c2-f934-40fa-b16f-756de86d6adb"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("fa0adb48-5bf4-4e86-b262-8c8ec16317fc"), new Guid("a533ed61-e3dd-493d-bfa7-7ed56dc32c21") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("c50adbc7-70f2-4091-96e7-1252e8409708") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new Guid("c50adbc7-70f2-4091-96e7-1252e8409708") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("3665eb02-e76c-40b2-bd42-8a749097506a"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("197bf818-3286-4447-aaee-3957dcc2d2b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("2587c111-02e2-4913-b26b-c165c21e88e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("54a944fc-7195-460a-acef-be56ab792ab9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("75e36dc6-5e31-4489-8d39-8542c07cc8ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("b01a3287-4674-4564-ac1c-ae0cb54ecb8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("ce3cb97a-1c63-4bda-976d-c62661e92c7a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("e6ce12b7-8087-4c87-903a-0e5a9457e37b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("ef30446c-47c8-461e-8b35-1e5b76cd36a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("fa249ca4-2ba0-46c8-9b6b-545ce3c8b946"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("0f642929-8edc-43e0-bd60-c49225c16969"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("132fbee6-b78b-4fcc-a9f9-ac5b6af1f381"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("1910cf77-8d35-49e4-93f7-aae2b543f66a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("39ff4cea-78b2-4ff0-a33d-9233d28d2779"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("4087b976-fef0-429c-8c29-b55bad871fbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("a656afd3-b379-4091-b2bc-0dbe9d3c58a9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("ce553acf-3b7c-4734-9f3f-373c32360a39"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("dcf1e9f6-0d85-4ecf-a318-77a7ca1cf02b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("e8da0ee1-326a-42ae-b00f-433e1c3691b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01a1d43f-607b-443f-a7c2-407de94aad9c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a0bff99-3bfc-43ca-8a71-00b44df30d53"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("296c5883-68c8-485c-8dd3-c16e54baf5bf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f7a07d01-dd3a-4dc5-9779-bd9eaede016c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("2e99efa9-2b3e-45f1-9e21-97c82dcb536b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("84ab7ce6-64f2-484a-8a52-b34092ecfd25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("8857ad68-4f2b-4255-b5ca-98048a87a41d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("b0d893c5-6d31-499e-8dfd-1e5a1efed667"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("043155ca-ab69-493c-8e28-d94086522df7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("081d76e0-04c7-4745-9367-e24de0ca087a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("08402369-44b9-4fbb-a773-eac8ffb724db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0afdadb9-2ead-4e58-b69d-7ac763fe2abe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0d55638e-7f76-4d23-a23c-2e82660f193e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0dc2eb9d-bf4c-46d2-ac68-34df51485241"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1039d2ed-b2e8-4b11-af19-7fcf8c76a90c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("110a2d16-806c-4951-acea-748632f5c7bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("13d735fb-13af-4671-b4fe-98701395249e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("15b0e66a-2d6f-4e84-883d-b8e5d04d6211"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("16139106-db69-4793-abb8-d032b0c78d93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("17587f4b-da00-4669-b522-4829094dac54"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("17f66b14-6188-4d99-9a2a-3e8173d13ac0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1ae4d391-9e1e-4678-82d0-6a99af0cb294"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1edcd3c3-6b61-48b5-9d0b-077ca651b2db"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1fd1087a-41af-4423-b476-b367523c5a2b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2012db7e-dbe8-42c1-93f8-bb5a8a84a780"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("20ea3481-4fa7-42fd-b1ef-3786d2fd368d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("21093ec4-02be-4073-8458-cabee8ee65d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("250c5124-9e9a-46b2-8e73-8ec8d106c21f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("25adaf22-6112-4ef1-9e1c-38cba35aff1f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("269d8574-f724-4597-adf1-40205b6f960e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("296b3a6f-3eb2-442c-b4c1-9c14e61a4308"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2a4d2bdd-e955-4ab1-8a3f-64a97a7db112"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2e71d666-2200-4094-9983-4e363a4e4f10"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2fb428a2-7579-4103-8d50-5936abed2eb8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("320ed206-f3e7-4821-b567-b2b4ec406974"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("35b87131-db7c-452b-bfe2-db7d71f640ed"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3720f57e-e318-42d6-ab04-9d9a40de5296"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3d92c5ca-0b13-428e-98e2-ae036bb87405"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3e5bd12f-4433-4eb2-a486-61d055afd923"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3f77f1dd-b695-4f09-8dfe-48a353085534"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("400bd88a-ba7e-45eb-b481-ca95f0537021"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4029a8a1-4c40-4446-8035-501e049a31cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4116701f-ef6c-43bc-80fd-e815754789ef"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("43222bd4-ed05-4e7a-8130-34878cc7922a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4a7497ee-676b-4699-96e1-6b18d5d0f177"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4d38f18e-d99f-4914-8118-9fbb4e1353ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("501a5cb3-af40-485d-8d41-4df0e72970c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("51e6e78b-4aa1-4b0d-8e27-9f9151bf394b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("52c0387a-c7b6-4c74-86ee-308519b845d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("52f52093-4e75-4238-ab6b-079226193582"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("55a117a2-238d-4dda-992b-b8f18f1cba05"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("55fa059f-be9c-4727-86f0-ac67349787c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("58ec79b1-e9e2-4acc-96ca-b5ebf190a4bb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("59510a83-b191-48b8-936e-7ff65155291a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5da1735d-f5c3-4c9f-bf68-81e68e23a8f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5e7a10d7-b665-4b34-8aae-96dd5a65666a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6494ef8d-0479-4356-98dd-8605cc68d362"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6dae1269-0ab8-4c11-bd00-5b0c658279e8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7088178e-d696-405f-9eba-2b6927c6bcad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("73299cca-02ca-43f6-a672-be3bdfbc5f89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("74ee3618-ae6f-4bf4-b8b3-b412973ed730"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("75df84b7-0609-4ba5-974b-3a9335ed087e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("791840a1-30a7-47e9-9aec-44d6f2e14ede"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("796221ea-1ddd-4ded-bbdc-e818b7ce108e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7a220b2b-ecf2-494c-aa73-7e75bdb2f9c4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7a82ce34-d94c-43b1-bac5-d54a32ef91f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7e76f4e0-1212-41c3-8ade-74630a136504"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7e9c589d-fb2c-4a47-8ede-0da8729fb42e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8245384e-4496-48bc-ba89-f5a4daeb64f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("83097543-5d6f-4499-a3a2-36016b63c03d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("86f1ee4f-16b7-448c-a09f-4caf267d650e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("88553a51-be44-4d22-b763-4471ace0cf6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8891e1b6-01e0-4d48-bae9-386cfce29896"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("88c70609-f9e1-4a82-85e9-885971c8e0b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("89684539-fbef-4dbd-b920-80196ea23d91"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8b2a8c41-41e4-45a6-8111-41c6b4dad004"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8dba1947-ce58-4233-b3c4-79ec16119d8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8e7b9674-591c-4bd1-843d-8674617fc0bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("90400f33-018c-46cd-969f-67f3703452c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("91cfa605-b78e-4790-baea-790769d2b14a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("94c705cb-328a-441d-ba0b-52aeacedd442"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("969c24d1-a1ec-441a-afcb-29ffc2bda482"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("97a6e279-c5ff-4a0b-93db-5e05b0539deb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9afaabf9-b11e-4ded-aa45-9bafe9e4183e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9b8c28c4-9355-4af5-9ddc-6240c670504d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9cae1b67-8dc9-47d6-ae02-dbe1b15fa4e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a049071d-bbd9-4f4b-90c6-4a92196854de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a1f0f306-787e-493f-bfc4-243e411f94ea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a3e17d0f-de13-452f-8c78-9b9e572e4c96"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a56bd851-1f7a-4da5-b9e3-61426c134f02"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a6fffa96-61c2-4937-847f-5f2a0e4a279c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a7593e85-9ad1-4836-8522-2ad950a7182a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a81f303e-3c0c-4a04-a55a-f9ea29c80148"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a821755d-36e0-4263-83b9-9ad9edc0fc60"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a87dac70-5b41-41a8-9516-4798dc332e4c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a8c60ae8-ab42-40d4-b39c-23c753c1f350"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a9129695-36be-4442-ae22-39dc72e6a95e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a920cea7-26a3-493a-ba5b-4d6cfc65383a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("aa896afb-ba4d-4037-a5e9-52d410ddfcd5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("aad0fe86-b3a6-4f36-a8db-28eb828e2dea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b0587960-e496-4f3f-bfc2-330f927f654c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b072434a-7167-4173-af07-28b4fd646262"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b09cdba8-dc04-4440-b229-8a00dc55794c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b491fd60-057a-43bf-90ba-38ab6c15ef68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b4df98d4-5582-4fd1-b237-c517a6b0c342"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b70f23b5-6e53-4e9a-8e93-5160868800b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b8760c63-992e-4bc0-984d-9ea9139aea24"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ba405fa6-bfe7-4e84-8c0d-e1f656c17c2f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bd62150c-445f-4a7b-8793-544231dee628"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bdefe961-2cf2-4c76-ade3-e45c341972b5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bfc7f1b1-3243-4e0b-8c79-0babf934cc46"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bfe2d579-53f1-4dbe-8158-4e51a38fe708"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c3d04a42-0d7c-4b72-9999-926b17eaedf8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c40ef275-4fa9-4489-9c87-f6498cda643f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c4c97fde-e036-4f96-bb83-2e07599fc20a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c54218bc-2e81-47fc-a6a4-da37c6b11719"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c54a58d1-da70-4d76-8198-907bd6cf8bd8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c55cfefb-ba6d-4b21-a1ff-39d4f9cb32ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c732824a-d9e7-4724-b366-ff32934452da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c8770673-08ab-41ed-9a92-cc70f96da61c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ca3b26c9-b8c8-4989-ad9f-d940f6c9e40b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ca950772-58f1-471d-a722-70c8b09c342e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cb08543e-9c06-46b0-85ec-2c5f6a15d353"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cc27a4c5-20f3-4bcf-a505-7e88b8ec457f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ce89a1f2-54f3-44af-963b-d527a0bde406"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d0039465-e230-4540-ba1f-4cca54bcd0b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d06bcd8b-884a-4df2-8a40-6a3e95c9ac18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d46287e9-f028-4319-ab0f-2465d0f46262"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d4a09583-b07d-4550-8f78-eda85e3bdd5d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d4ce02f3-2565-4774-8bf5-4eee1a92c442"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d7338d37-c99c-4c8c-ac1b-43292efefda3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d85dd78c-ef36-4878-81c8-e3b9daf022e4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ddab159a-82de-480e-9edf-3f10d904a336"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("de1991d8-0f02-405c-a185-c2d194135aaf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e09f130c-92b0-4ee0-b15f-d4fb74a966a7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e487abb9-e93b-4a14-8097-e2c3410c5ae5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e5832f96-cfb9-41f4-b01f-1909bbf2cabe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e9d230d0-71d4-4b6f-9cf1-4f3feb66a3cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ec77afa1-2cb1-4454-b5b2-9523ea6ddfdb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("edee50db-f91d-4aed-85eb-518c307648d4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("efe8b0cf-c91a-49f9-b871-5e48408b7755"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f29c97c6-269b-4a92-a1d4-f7d4bd652dcf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f497fce7-e64a-49b9-89eb-8dc04c4ff0f3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fa974670-50e9-4f07-85f8-1eea80fc51d5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fb2c81a2-4cc8-4f3e-b68d-6927d2556bd1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fdf99486-827f-4999-82c4-5eb4be0660af"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ff91b936-2f22-4a01-84a3-90a79252ca8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("026aa3e1-e9b6-488e-8728-3f46c02b222c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("0f46416e-309e-44c8-9ece-fc752742ff6b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1bbf6759-9655-440d-a5d1-7d252f40c643"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("1f9c61b1-0407-4b5e-ae39-a1abc7782f21"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("37679344-ab1a-4a2b-80d3-e73dfe00c0c3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("3e80ebfa-bdf8-4b3f-82c9-a2e26ad2801b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("42b05cac-373c-491a-874d-03ebb92afba7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("440ef974-adb8-41dd-8129-3a8e0f080180"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("44848744-fa12-4ec1-8a61-fdedb0aa7c6a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("624d15f0-1d66-4eb1-9855-89e5dd47fdb8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("78dfdd80-f8f1-47fa-8488-6b99fc5991ac"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("87b20cdb-87d1-4306-bed2-d038a09717be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c210737d-1115-463a-856d-4c63fda1af74"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c417e46b-aa5b-4d1f-85fb-7cd4cc8112ff"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c791d970-5181-46e6-a3ec-e0bf348675c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d812814e-212d-4de2-8bde-24220b5d3615"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f14978d2-9f6f-43e1-8f16-4d9fbd131047"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f202274d-a92d-47f8-94c5-85e9bea75b97"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f303aa7b-33d0-4b75-be11-a1531e1adefa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f43dff18-0686-4cdf-ac30-a0b2f283bc70"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f4c33f64-d0a2-4464-b488-654467188474"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f61214c0-0d1c-4179-ba35-cec2f3b37673"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5134c0a2-eb7f-4876-93a9-50a9ce3a0fe2"), new Guid("9f1c3055-d4e8-419c-921b-9cc46f346952") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("393c86c1-e0fc-4635-833a-feefd300f78d"), new Guid("c23a1a42-e73e-4ff5-ac85-50a9b7f54274") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3665eb02-e76c-40b2-bd42-8a749097506a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("394924c2-f934-40fa-b16f-756de86d6adb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("49a6ae66-0216-4083-b0e8-c1ce173b5a50"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("fa0adb48-5bf4-4e86-b262-8c8ec16317fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("30f8e945-ef5b-4316-91ba-7cac29399f93"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("3a49b439-f8cc-40ce-819d-e80919b99294"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("825dedb8-ff61-43b1-a747-eeda76999bb2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("a160b727-85c4-4e04-a1a7-61aa79d2a674"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("a533ed61-e3dd-493d-bfa7-7ed56dc32c21"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("c50adbc7-70f2-4091-96e7-1252e8409708"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("393c86c1-e0fc-4635-833a-feefd300f78d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5134c0a2-eb7f-4876-93a9-50a9ce3a0fe2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("568baa32-e39b-4a89-8471-e9e756c01623"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("6612ef93-a38d-42c8-9674-f1683062af46"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("6f1523d9-53bf-488c-b50e-b4e87fab4ef6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("a71bed94-1cd4-4014-b9ed-8bc9c8d2e6c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f1c3055-d4e8-419c-921b-9cc46f346952"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c23a1a42-e73e-4ff5-ac85-50a9b7f54274"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 951, DateTimeKind.Local).AddTicks(6634),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 226, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 965, DateTimeKind.Local).AddTicks(9275),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 244, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 966, DateTimeKind.Local).AddTicks(8683),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 245, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 967, DateTimeKind.Local).AddTicks(3025),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 245, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 967, DateTimeKind.Local).AddTicks(5582),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 246, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 952, DateTimeKind.Local).AddTicks(4642),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 227, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 967, DateTimeKind.Local).AddTicks(9069),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 246, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                schema: "dbo",
                table: "FeatureProjects",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 968, DateTimeKind.Local).AddTicks(3423),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 247, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 953, DateTimeKind.Local).AddTicks(3945),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 228, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 953, DateTimeKind.Local).AddTicks(6631),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 229, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 965, DateTimeKind.Local).AddTicks(2539),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 243, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 964, DateTimeKind.Local).AddTicks(2186),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 242, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 964, DateTimeKind.Local).AddTicks(4683),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 242, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 963, DateTimeKind.Local).AddTicks(9240),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 241, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 952, DateTimeKind.Local).AddTicks(7067),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 228, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("05885278-c779-47b8-b9a5-73755db3a1f2"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4130), true, "Environmental Impact" },
                    { new Guid("0935d9e4-86dd-4e1c-b6bc-b2017ed7c86b"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4167), true, "Real Estate Development" },
                    { new Guid("0c0da86e-1d1f-49e4-b1f2-4aec15f71351"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4088), true, "Case Studies and Success Stories" },
                    { new Guid("1a7c1846-9d3f-454b-8d18-369ca0376472"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4085), true, "Building Codes and Standards" },
                    { new Guid("1b835cfc-d2f5-4444-b478-555f0c16b325"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4120), true, "Design and Architecture" },
                    { new Guid("245cc3b6-f720-484b-be1b-f299246806df"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4160), true, "Project Showcase" },
                    { new Guid("27d17dc1-fd2b-4bd8-b14c-5d639ea43f5e"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4180), true, "Training and Certification" },
                    { new Guid("303c59b1-7f4e-46ae-834d-1f76cd01e085"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4147), true, "Innovation and Future Trends" },
                    { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4145), true, "Industry News" },
                    { new Guid("35cc5906-3bc7-47c2-aed8-ee40fe6d94ec"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4105), true, "Construction Careers" },
                    { new Guid("43683e72-3681-40ff-a6dd-d211c53d4790"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4132), true, "Equipment Maintenance" },
                    { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4102), true, "Company Updates" },
                    { new Guid("46629a73-12d8-4d41-90d5-e6bb368f5c42"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4136), true, "Health and Wellness in Construction" },
                    { new Guid("483fd723-01fa-4809-8aac-8a504fe4a0f0"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4154), true, "Legal and Insurance" },
                    { new Guid("4d5081a4-224b-4267-8c1d-40ef507fb582"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4140), true, "Home Improvement and DIY" },
                    { new Guid("55502af7-b4b5-4e36-a04e-95a3a796cf55"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4094), true, "Community and Culture" },
                    { new Guid("599e8a83-1b71-4992-944e-beb5f8cdaf33"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4175), true, "Sustainability and Green Building" },
                    { new Guid("652ffd25-63f0-4b58-8117-4c7fae53e7cb"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4110), true, "Construction Finance" },
                    { new Guid("74a6436d-301b-4023-b3b6-d375582538eb"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4173), true, "Supply Chain and Logistics" },
                    { new Guid("773cbe69-b026-4a0b-8dc3-8122c410c11b"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4116), true, "Cost Estimation and Budgeting" },
                    { new Guid("786a15c9-d309-4004-bc16-f215bcf7dd6d"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4150), true, "Innovation Awards and Recognitions" },
                    { new Guid("79719abf-8402-4f7a-8d62-1fdcb3173942"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4126), true, "Disaster Preparedness and Recovery" },
                    { new Guid("7a70277c-1faf-42ee-97a2-2844da375365"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4184), true, "Urban Planning and Development" },
                    { new Guid("7c57ca91-7c29-4ead-9e50-3b45cf1ce35b"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4152), true, "Landscaping and Outdoor Design" },
                    { new Guid("abfd87ca-43fb-4b52-9c42-5f191ddcf24e"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4114), true, "Construction Techniques" },
                    { new Guid("bd0fcf32-78c4-4b48-ae01-0bd82372781e"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4156), true, "Materials and Equipment" },
                    { new Guid("c02ad6d6-a60d-411e-8d70-b9e7c08bf637"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4178), true, "Technology in Construction" },
                    { new Guid("c0498ab3-31aa-4b43-91e6-a2e8bae5a4b9"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4158), true, "Modular and Prefabricated Construction" },
                    { new Guid("c4170f3a-10b2-4d7e-a01e-a417c955e60b"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4186), true, "Weather and Seasonal Tips" },
                    { new Guid("c8ee8bb2-34f9-403c-9f30-5f102b2819b7"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4112), true, "Construction Management" },
                    { new Guid("cd5fa647-7559-4b3f-8b40-23cc2577f3b4"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4092), true, "Client Resources" },
                    { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4090), true, "Client Education" },
                    { new Guid("d42ba6f8-e922-46e7-a935-d5683ea64d64"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4051), true, "Accessibility in Construction" },
                    { new Guid("dcde0ea9-d453-488c-b45b-6bf1fdd485a6"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4118), true, "Customer Stories and Interviews" },
                    { new Guid("e3afe3e6-3ea0-4a72-b2f8-696e682a1ca0"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4171), true, "Smart Home Technology" },
                    { new Guid("e9666ace-6ba9-4d70-80af-9ec81a5638fe"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4138), true, "Historic Preservation" },
                    { new Guid("f400876d-fd4c-4ed9-a142-2d346bf1bea2"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4165), true, "Property Management" },
                    { new Guid("f48e126f-9328-4495-a7b8-ff628f2e0850"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4128), true, "Energy Efficiency" },
                    { new Guid("f849a51f-dce2-4e67-9bbd-ebbabd322b57"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4169), true, "Safety and Compliance" },
                    { new Guid("f954664a-614a-4ab2-a622-7dacdfd2057e"), new DateTime(2024, 6, 27, 6, 29, 25, 968, DateTimeKind.Utc).AddTicks(4134), true, "Green Building Materials" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("069c4934-601b-4e78-b8b2-c07af9172255"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2365), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 },
                    { new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2558), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2182), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2259), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("84f7debf-7649-45aa-8ec7-17130ef142d8"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2292), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("9133695c-dfae-474a-b418-1ac79a871132"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2592), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("a81a8261-19a9-4024-8d03-42728ef3c71a"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2620), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(1660), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("e9968afe-f952-47ab-88d6-72c95cb909ae"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2222), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("703810a5-fc2a-45dd-81e3-ead6604c4392"), null, "Visitor", "VISITOR" },
                    { new Guid("a4fb4a83-1700-442d-bf88-addcfcd63ae7"), null, "Moderator", "MODERATOR" },
                    { new Guid("bd55c8a0-9ef9-4551-859a-85a98b377ccb"), null, "Editor", "EDITOR" },
                    { new Guid("c4a8a6ab-e620-441b-bd7d-1d51ac606466"), null, "Client", "CLIENT" },
                    { new Guid("f1c93611-32e1-4bf5-9f57-9c0a666c6070"), null, "Admin", "ADMIN" },
                    { new Guid("fe44812c-d5cc-4a0c-a6c1-950a28f979c6"), null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("0915a20e-e746-4a82-86ea-6a8c42241da9"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(3604), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("12928d2d-9970-4fb0-9e58-04c7ed1e382d"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(3620), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("7746def8-b048-43f2-8535-942660e0ea0e"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(3617), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null },
                    { new Guid("bb233703-f3f3-4565-b00c-8061d3fce185"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(3614), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "HideTitle", "ImageCDNUrl", "IsActive", "Location", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5351), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "lds-chapel-retaining-wall-construction", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4852), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "san-pedro-laguna-lds-chapel", "San Pedro Laguna LDS Chapel" },
                    { new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4527), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "muntinlupa-lds-chapel-elevator-project", "Muntinlupa LDS Chapel Elevator Project" },
                    { new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5491), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "talavera-chapel-general-repair-works", "Talavera Chapel General Repair Works" },
                    { new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), null, new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3681), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "lds-church-improvements", "LDS Church Improvements" },
                    { new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), null, new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3861), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "um-library-fire-protection-pbax-paging-systems-project", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), null, new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3442), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", true, "Philippines", "company-workforce", "Company Workforce" },
                    { new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4721), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", true, "Davao City", "verdon-park-condominium", "Verdon Park Condominium" },
                    { new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), null, new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(2288), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "ladon-construction-service-davao-city-headquarter-office", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4422), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "mang-inasal", "Mang Inasal" },
                    { new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4037), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "carmen-lds-chapel-general-repainting-electrical-works", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5161), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "general-milling-station", "General Milling Station" },
                    { new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), null, new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4273), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", true, "Sasa. Davao City, Philippines", "sasa-lds-chapel-general-repainting-retiling-works", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4998), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "aringay-lds-chapel-retiling-and-repainting-works", "Aringay LDS Chapel Retiling and Repainting Works" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("00e14998-1a53-4833-90a5-2205d18e9e54"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6486), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("033882f9-1179-4ab4-b6ea-39ef858a62f9"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6443), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("03667715-e064-493f-a20b-413b22873ceb"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6464), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("19aa01cb-659b-4505-a169-4a52e7ecead8"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6449), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("27a8254e-82f4-406d-98cb-b9bae39a5d41"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6466), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("2db78e5d-0acf-4eff-9043-4d069cf5575c"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6439), true, null, "How can I get a quote for my project?", null },
                    { new Guid("4660d22f-ba41-41bf-9faa-96c215e815fd"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6441), true, true, "How do you handle project timelines?", null },
                    { new Guid("6147cab2-3a63-4fbf-b848-8d5414960c39"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6461), true, null, "How do I pay for my project?", null },
                    { new Guid("622d84e9-6060-4d9a-9751-6b124ce09502"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6476), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("6f2ea6aa-20a8-4caa-abf8-ffcc94589b68"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6478), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("7478c0ec-6af5-4929-979e-33c360ebe6ca"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6453), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("79b9c835-55ea-4202-8f8b-a5db8fde0d3e"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6472), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("7b31e5ef-c1a0-431d-a49a-2d4260dc9bf6"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6483), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("8424d242-9bce-4c6a-8c90-3577921d8a6e"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6447), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("9d7e3816-6500-4658-b202-84683e327c15"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6488), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("c97f3f8b-4e9c-45c2-9d12-c1da5f7ed5fb"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6445), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("c9b77094-62f5-4f00-a335-d1293d154799"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6451), true, null, "Do you offer financing options?", null },
                    { new Guid("cf42cd48-86d3-47fe-abf9-f2997f1a133f"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6424), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("d3e09194-0e68-4da3-af56-c06b6e4969f6"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6428), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("d58e1e9d-5c9d-49fa-a1b8-4eeacbcc7558"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6485), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("d7ff628b-67ec-4057-a3c0-5c82ef7801f1"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6470), true, true, "Are you licensed and insured?", null },
                    { new Guid("f2113ce0-efd7-4026-87fa-e364f959161b"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6474), true, null, "What if I need to make changes to the project after it has started?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("628f2d66-4137-4f49-ae14-bf41b994ba92"), null, null, new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6280), "Charles", 0, new Guid("7c559818-b7e0-4779-8ac7-2e199fcf0079"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("b4ac3df3-a94d-4ca3-adad-fa77244a05c0"), null, null, new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6233), "James", 0, new Guid("9dee3908-b748-48a1-bcbc-66f864d19db6"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7c559818-b7e0-4779-8ac7-2e199fcf0079"), 0, "46a1a1f5-afcd-4fd9-b797-71676a2ece9a", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEMPA4yAYq+UyboUy/h8NLrURHMkB2IHmsswp27Bb5aKyfmW4JbHHP3sEimb+w7XTyg==", "+639951225449", false, "f917817f-c4e1-ebcf-75fe-f54d5ea87623_20240627062925968", false, "ladonconst@gmail.com" },
                    { new Guid("9dee3908-b748-48a1-bcbc-66f864d19db6"), 0, "1a94f70e-7a56-4470-931d-3dc2e7ca0710", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHSWeQxay0O2zhJruqImZ8NEgNPxuP7yNCKJ5gTcHVVsyqq3kx4SD7UjVqKFrXsLzw==", "+639672814641", false, "f917817f-c4e1-ebcf-75fe-f54d5ea87623_20240627062925968", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("76a8a744-06cf-48b7-bd22-5ea0addf39e1"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6376), true, "8000", "Davao del Sur", new Guid("b4ac3df3-a94d-4ca3-adad-fa77244a05c0") },
                    { new Guid("9b916bf3-c37b-4588-9a0d-b804d55f3682"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 27, 6, 29, 26, 103, DateTimeKind.Utc).AddTicks(6381), true, "8000", "Davao del Sur", new Guid("628f2d66-4137-4f49-ae14-bf41b994ba92") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") },
                    { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") },
                    { new Guid("c8ee8bb2-34f9-403c-9f30-5f102b2819b7"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") },
                    { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") },
                    { new Guid("245cc3b6-f720-484b-be1b-f299246806df"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3") },
                    { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3") },
                    { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3") },
                    { new Guid("27d17dc1-fd2b-4bd8-b14c-5d639ea43f5e"), new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582") },
                    { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582") },
                    { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591") },
                    { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591") },
                    { new Guid("599e8a83-1b71-4992-944e-beb5f8cdaf33"), new Guid("9133695c-dfae-474a-b418-1ac79a871132") },
                    { new Guid("599e8a83-1b71-4992-944e-beb5f8cdaf33"), new Guid("a81a8261-19a9-4024-8d03-42728ef3c71a") },
                    { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52") },
                    { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("04221c2e-4c07-46d0-a7b5-198b3a992a47"), new Guid("e9968afe-f952-47ab-88d6-72c95cb909ae"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2253), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("117fc0ed-ac9d-4215-b6a3-dac11c5e613d"), new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2284), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("2b212423-6767-486b-b784-135515aa28a2"), new Guid("9133695c-dfae-474a-b418-1ac79a871132"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2614), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("387f7afe-4743-4485-9b1e-70d0aa4643a4"), new Guid("a81a8261-19a9-4024-8d03-42728ef3c71a"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2640), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("79723846-71b1-4aae-8ea8-f987f8925959"), new Guid("84f7debf-7649-45aa-8ec7-17130ef142d8"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2357), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("84b03af4-def8-4c25-9e72-45c6dff3f248"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2552), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("9ffc8306-97e7-4cd0-8695-aa88d0fe904f"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2584), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("cc0f3667-8a00-4e98-9ecd-d7fe4aaff0b4"), new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2214), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("f03cec9e-2ae0-43fd-9a22-fa435d498bc7"), new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2150), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("04937b2d-17fb-4d03-9a6d-c0da68f02868"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2554), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true },
                    { new Guid("36ee116c-2b4d-427d-9725-1f697600ba38"), new Guid("e9968afe-f952-47ab-88d6-72c95cb909ae"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2255), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("376e31e6-78e5-43c6-82fd-bfdbca67c4fe"), new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2168), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("3dc8be24-d95b-4440-ad3b-67937f1f4577"), new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2218), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("7909145c-cde1-4b12-9ae9-86d0ca087526"), new Guid("84f7debf-7649-45aa-8ec7-17130ef142d8"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2360), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("9bc31669-32c9-4260-ae12-1b18d7503e89"), new Guid("9133695c-dfae-474a-b418-1ac79a871132"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2616), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("9c895779-905a-4c15-97f3-6f502c472e63"), new Guid("a81a8261-19a9-4024-8d03-42728ef3c71a"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2643), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("a7e80f77-39d2-42fd-861c-11604e16128f"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2589), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("cb5ac247-9c78-497f-9ea5-6b34d44e302f"), new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591"), new DateTime(2024, 6, 27, 6, 29, 26, 107, DateTimeKind.Utc).AddTicks(2286), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "IsActive" },
                values: new object[,]
                {
                    { new Guid("003ffede-3503-41ad-98fd-86a583999d5a"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4409), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", "", true },
                    { new Guid("00771ae8-3a41-4276-b2a4-b202b839264f"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4822), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", "", true },
                    { new Guid("02127c67-0479-4a65-8be0-ceef7eda49a3"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4516), new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", "", true },
                    { new Guid("03623f2b-0955-46e3-a360-aca10f8d1520"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4976), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", "", true },
                    { new Guid("05103379-f261-4f0c-999b-d9e27376f863"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3669), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", "", true },
                    { new Guid("06110a1e-da35-41b1-814a-302f80706c7d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4515), new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", "", true },
                    { new Guid("076e88a1-9772-4c8e-bc84-aa9bbad10e2c"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5616), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", "", true },
                    { new Guid("0b6883c2-d72d-46be-96dd-37fe22b55e3b"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3431), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", "", true },
                    { new Guid("0b6a8b53-de70-4158-84f8-e750c82e8387"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3663), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", "", true },
                    { new Guid("0c5f9d8b-a4cc-48fc-af3a-b5623c307ae7"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3853), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", "", true },
                    { new Guid("0cd20a65-6132-4ed5-8b70-0dd09138c276"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3834), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", "", true },
                    { new Guid("1020b38d-81bb-4aff-b658-50949a9d587e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4993), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", "", true },
                    { new Guid("12058563-15fa-45f3-8f3b-29a82d06093f"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5275), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", "", true },
                    { new Guid("13320d04-1b14-45b4-9887-00375b70031e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3974), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", "", true },
                    { new Guid("1346f197-9fd2-4feb-b73a-167d09d91659"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3665), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", "", true },
                    { new Guid("136e30c4-3658-48ee-8890-e82fcc1a23e2"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4845), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", "", true },
                    { new Guid("143f527b-dce1-4b2d-93bb-9d5d681b65ee"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3430), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", "", true },
                    { new Guid("168d7869-7ce3-47df-9a00-e93930080e3b"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3838), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", "", true },
                    { new Guid("181e260f-4675-4bdb-965b-ae6e82880cf9"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4418), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", "", true },
                    { new Guid("1b89719b-7d8d-46b8-b7a8-dc25274a4fc3"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3678), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", "", true },
                    { new Guid("1c059d56-655a-4237-a5dd-619c62b7e014"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5631), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", "", true },
                    { new Guid("1cccdfed-78bf-430d-822e-144c49a888e1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4417), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", "", true },
                    { new Guid("1dd7aeb3-5912-4847-9417-0c7c1be29df4"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5261), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", "", true },
                    { new Guid("1eb437e8-8332-4334-86b8-7541f3646613"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4267), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", "", true },
                    { new Guid("245d0529-fced-4ca9-a336-ee190474c9ca"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5472), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", "", true },
                    { new Guid("275b5d65-c1b5-49e3-8b95-d8dc2174aca1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3847), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", "", true },
                    { new Guid("27df0c48-5aab-476e-8291-f165e14cbf41"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4407), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", "", true },
                    { new Guid("2881a12a-80d5-4018-b8ba-624c78da106a"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4837), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", "", true },
                    { new Guid("28d83e47-df22-40c2-b780-d74ba67955a5"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4703), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", "", true },
                    { new Guid("2992ff71-6e25-432e-9af3-60b2cd86880d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3976), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", "", true },
                    { new Guid("2b5a8721-9752-4f17-bf15-cde31e346d39"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5263), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", "", true },
                    { new Guid("2cdfc9a0-376e-4bac-b60e-7d29cafe389b"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4406), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", "", true },
                    { new Guid("31bfc1fe-97ae-4ce3-b29c-59a9a3c11f7c"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3676), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", "", true },
                    { new Guid("32123824-fcb4-4085-a867-1961f04c8783"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3666), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", "", true },
                    { new Guid("33e8f81f-4c30-4df4-9eff-bb59e3fc6a94"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4715), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", "", true },
                    { new Guid("354e6f83-6a8d-4f58-bd8e-9f400448f409"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5625), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", "", true },
                    { new Guid("3672bddc-351f-4d57-90a5-fed46b7d1029"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4718), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", "", true },
                    { new Guid("3868831b-a6f2-4739-8e76-1acd49c74fdc"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5158), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", "", true },
                    { new Guid("3a48b489-38ad-49cc-ac60-4c967ae9ae2a"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4973), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", "", true },
                    { new Guid("3a5e5ae8-ee62-4e03-88b8-2ff5919e30c1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4518), new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", "", true },
                    { new Guid("3a8643d4-58a7-43f2-9f77-4ee75b451269"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4253), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", "", true },
                    { new Guid("3b706679-20ed-4132-9b68-d4315c8a034a"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5155), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", "", true },
                    { new Guid("3d8880da-495b-42fe-bd9d-f5c5fe8c39fc"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3405), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", "", true },
                    { new Guid("426166c3-a631-472c-8b68-f96118b9b032"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4706), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", "", true },
                    { new Guid("445a7266-1227-4777-b5f0-30a4a5af73b9"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5630), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", "", true },
                    { new Guid("4aa8d5c9-c9b6-4491-8e0a-a7170003cb96"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4259), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", "", true },
                    { new Guid("4ab84fd2-0e09-4d63-a120-39d05ac53b4e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3600), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", "", true },
                    { new Guid("4bb20c26-6940-45d8-a96c-80ff0a9a5074"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4834), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", "", true },
                    { new Guid("4c2109e7-0f63-4f12-a91d-8fef9221230d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3607), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", "", true },
                    { new Guid("54c68cb7-75af-4613-8fc5-13f3b0c111f1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5264), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", "", true },
                    { new Guid("5664aaa7-dac8-40fa-9b8e-35513b02f1b8"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4510), new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", "", true },
                    { new Guid("5a07b571-023a-44af-adc6-ffd6513be77b"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4842), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", "", true },
                    { new Guid("5c968f68-fc0b-48c9-a955-073e914e08c7"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4843), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", "", true },
                    { new Guid("5de6d47b-b652-4891-be3f-96bd84c4d439"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3971), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", "", true },
                    { new Guid("5f0fc3b2-ceb4-4baa-a560-8d2710468f7d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3977), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", "", true },
                    { new Guid("5ffcc0d7-5fe5-4036-a857-b52c9a4394d1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3848), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", "", true },
                    { new Guid("6204816c-d750-4ee6-a1d2-8f1d3da0cf4b"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3668), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", "", true },
                    { new Guid("652f95f7-9c27-49f4-b220-0eac4f4bd60c"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4716), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", "", true },
                    { new Guid("6edc15e9-041e-466c-97cc-7d3db6c1fab6"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5628), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", "", true },
                    { new Guid("6f54faea-6210-49b4-8de1-99af2c1ebd9e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4261), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", "", true },
                    { new Guid("6fcec479-f519-410f-b7fc-1f6875e26ed9"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3988), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", "", true },
                    { new Guid("6ff1e668-387f-4605-b8cc-0aec80792028"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4981), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", "", true },
                    { new Guid("70a296dc-48fb-4059-805a-eb4528174ee1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3851), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", "", true },
                    { new Guid("70e8fdf5-44dc-4615-bb6f-7949b298f823"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3675), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", "", true },
                    { new Guid("76afab01-0927-4086-be71-423453bc849e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4849), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", "", true },
                    { new Guid("78f32465-41d3-41e2-aa33-2d35163d60ae"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5277), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", "", true },
                    { new Guid("7b7417d8-2fb1-4cc0-8929-1731902cb762"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4989), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", "", true },
                    { new Guid("7d6d36ac-146b-49d8-8ddb-ef70a2cfc3be"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3850), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", "", true },
                    { new Guid("7fbb23eb-0400-4a7f-bdb4-bdc4bc9fb438"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5627), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", "", true },
                    { new Guid("80a63316-f99b-420a-9496-346b156c1f44"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3980), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", "", true },
                    { new Guid("85e87c6d-0380-4ba1-915c-ee0ab402b86e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3854), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", "", true },
                    { new Guid("86d0f192-5a4c-4e80-8950-f9db4bb9266f"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5635), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", "", true },
                    { new Guid("873c1db0-d4c8-47c8-bd16-832b6ee3d451"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3839), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", "", true },
                    { new Guid("87671b76-bc52-4655-8ed8-75d462670263"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4994), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", "", true },
                    { new Guid("8added2b-9486-4518-8258-ec3832046d04"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4990), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", "", true },
                    { new Guid("8dd51b46-e098-4b6e-aed6-2e456365e907"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5640), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", "", true },
                    { new Guid("90f56c45-ccf2-4503-8fc6-754d9daffba1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4978), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", "", true },
                    { new Guid("93b7f050-e490-47d2-93c2-4034498fe581"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4701), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", "", true },
                    { new Guid("9467b09d-e680-42e3-98c3-c57b1d0aa152"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4513), new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", "", true },
                    { new Guid("95857f57-3614-4bc5-bef5-15b4d132d8ab"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3846), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", "", true },
                    { new Guid("980b2a3f-d642-4240-bfd4-6bf3f2b5c617"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5156), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", "", true },
                    { new Guid("9b496287-ab5b-4ce3-b6e1-9b40f16e1dbd"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4269), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", "", true },
                    { new Guid("9be6c8ee-4ead-443f-966b-0701b602f8eb"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4840), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", "", true },
                    { new Guid("9d79c6d1-9e15-4ff7-88f0-764ce7d6bd78"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5347), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", "", true },
                    { new Guid("9db3a8ea-9f31-4ab8-ad99-7f5e19db2056"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5151), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", "", true },
                    { new Guid("9e66dc8c-a895-470d-a93d-a6f3ae0c9e19"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3416), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", "", true },
                    { new Guid("9f5887ec-9e5d-42fc-baa4-0dbfc7cb8d7d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4838), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", "", true },
                    { new Guid("a0286fc0-b4a2-4ccd-9f69-2e7c2d88f093"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3434), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", "", true },
                    { new Guid("a79a1b89-218e-426f-bae4-2e6ba435cb43"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5483), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", "", true },
                    { new Guid("a818cac7-768e-4f40-b49c-c9770a16ef10"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3673), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", "", true },
                    { new Guid("a85aced3-7434-4cb2-b823-538ea1cce136"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5139), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", "", true },
                    { new Guid("a95f0298-d940-4bbe-84be-0218b2a5a845"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5638), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", "", true },
                    { new Guid("afa5480e-07a0-4eeb-8041-a74901770889"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5153), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", "", true },
                    { new Guid("b02baecc-1b19-4504-aac3-8a79ee9c4703"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4992), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", "", true },
                    { new Guid("b1e31f3b-fe20-4c39-94c3-5479fe2aadd0"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5633), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", "", true },
                    { new Guid("b4997dc2-0bc0-4299-a61b-36cbb06ac316"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4827), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", "", true },
                    { new Guid("b49d7ce4-4dd0-486c-87e8-403df415f82f"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5257), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", "", true },
                    { new Guid("b4ddd56e-e1e4-417e-bc48-8585011cc4ca"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3418), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", "", true },
                    { new Guid("b948bfe5-4093-4e0e-9972-098943865e08"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3660), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", "", true },
                    { new Guid("bac77158-f7ed-46e6-b22a-2ecccf140b0a"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5152), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", "", true },
                    { new Guid("bb005d22-6bdd-449e-9d32-e47e276da184"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5474), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", "", true },
                    { new Guid("bf1ebd72-5095-4989-a7d1-d6c5b2215bcd"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5481), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", "", true },
                    { new Guid("c17f9607-fb84-4be1-a453-ba0a5cdce1dd"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3981), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", "", true },
                    { new Guid("c59ddf5d-0ce4-46bc-96ad-cf712ac241a2"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4714), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", "", true },
                    { new Guid("c6dadfae-1ec6-4b50-bcaa-85531cdcfb7c"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5486), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", "", true },
                    { new Guid("c795de72-22fa-4e3d-8263-2c9534317fc1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4411), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", "", true },
                    { new Guid("ca953656-22f8-48ca-b05c-8d8e1280f92d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3856), new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_12.png", "", true },
                    { new Guid("cd0bd053-c9b7-4003-8605-042a1ed16dba"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5266), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", "", true },
                    { new Guid("cd900db6-cfae-43d2-b8e2-1ff5f3c693c6"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5149), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", "", true },
                    { new Guid("ce97f751-4179-4588-ad6b-4c9f00bed4e1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4698), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", "", true },
                    { new Guid("cebc1a96-1662-450e-b98e-f10147f15f44"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3415), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", "", true },
                    { new Guid("d300f751-3e70-43cb-bd16-acee283de624"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5624), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", "", true },
                    { new Guid("d30149a7-9c9a-4cad-99f5-b6893ba9551d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5269), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", "", true },
                    { new Guid("d35e97ad-5d6d-4565-ace7-c54bc5ff687b"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3433), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", "", true },
                    { new Guid("d40f9b50-947d-4b84-b704-9b053ff99c62"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5471), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", "", true },
                    { new Guid("d8b57e36-ba4d-4d5b-b10e-cce63013e025"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4256), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", "", true },
                    { new Guid("dc1dea63-3d57-41b2-9d69-2fe140926e00"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3662), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", "", true },
                    { new Guid("df48e082-a62f-4b06-b34a-28b0aa0e056e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3596), new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", "", true },
                    { new Guid("e1871c1d-d1f9-4bca-b8f0-657c4f6e4e7c"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5260), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", "", true },
                    { new Guid("e3231215-4b13-4a57-a46f-972e1ba88844"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5488), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", "", true },
                    { new Guid("e6670871-1cc7-432c-bc9c-51b240d743b3"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4403), new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", "", true },
                    { new Guid("e6e0014b-bc48-4895-a3c1-db5f726603da"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3989), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", "", true },
                    { new Guid("e71496be-fd66-4b7e-92ac-60caaf026ce1"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4825), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", "", true },
                    { new Guid("e7b0cfb2-69e6-498b-aa1c-1c696327c981"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4835), new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", "", true },
                    { new Guid("e8e45a16-b627-4e8d-8003-8fe24a018d9a"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4704), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", "", true },
                    { new Guid("ece91d4d-c6c8-4b46-9567-34c71732b819"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5484), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", "", true },
                    { new Guid("ef50a8f5-6082-4591-90ce-76a7a0e44594"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3436), new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", "", true },
                    { new Guid("f0c60d80-f4bc-402a-b6fc-c591baeeb1de"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4258), new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", "", true },
                    { new Guid("f222fb33-37c1-4067-a262-8ed2de4d3114"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4707), new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", "", true },
                    { new Guid("f2f34bf2-3ce2-4dfd-9f49-49e70b40f9e9"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4982), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", "", true },
                    { new Guid("f3a7ea0a-0527-4e3e-9797-87fcc30b6192"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5641), new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", "", true },
                    { new Guid("f83469ef-da7c-44c9-8336-4ff145c38fa4"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(3978), new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", "", true },
                    { new Guid("f83b35a7-3027-4aa0-81af-a5dd6a3c646f"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4979), new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", "", true },
                    { new Guid("f9580595-c14f-4e7e-a49a-4a3dbb58772e"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(4524), new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", "", true },
                    { new Guid("fad0a9aa-3756-484f-a6ef-3d3daddd9c3d"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5467), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", "", true },
                    { new Guid("fc6476c3-9bbd-4952-bd85-69b14e41f002"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5267), new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", "", true },
                    { new Guid("fe0f7f2d-a2b0-4622-a42a-b6e8b1549833"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5143), new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", "", true },
                    { new Guid("ff6302d2-074b-4312-a115-bba2a10566e6"), new DateTime(2024, 6, 27, 6, 29, 26, 108, DateTimeKind.Utc).AddTicks(5480), new Guid("01da6872-2903-451b-990b-1083b2bf87cf"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", "", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fe44812c-d5cc-4a0c-a6c1-950a28f979c6"), new Guid("7c559818-b7e0-4779-8ac7-2e199fcf0079") },
                    { new Guid("f1c93611-32e1-4bf5-9f57-9c0a666c6070"), new Guid("9dee3908-b748-48a1-bcbc-66f864d19db6") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("76a8a744-06cf-48b7-bd22-5ea0addf39e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("9b916bf3-c37b-4588-9a0d-b804d55f3682"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("05885278-c779-47b8-b9a5-73755db3a1f2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0935d9e4-86dd-4e1c-b6bc-b2017ed7c86b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("0c0da86e-1d1f-49e4-b1f2-4aec15f71351"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1a7c1846-9d3f-454b-8d18-369ca0376472"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("1b835cfc-d2f5-4444-b478-555f0c16b325"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("303c59b1-7f4e-46ae-834d-1f76cd01e085"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("35cc5906-3bc7-47c2-aed8-ee40fe6d94ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("43683e72-3681-40ff-a6dd-d211c53d4790"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("46629a73-12d8-4d41-90d5-e6bb368f5c42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("483fd723-01fa-4809-8aac-8a504fe4a0f0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("4d5081a4-224b-4267-8c1d-40ef507fb582"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("55502af7-b4b5-4e36-a04e-95a3a796cf55"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("652ffd25-63f0-4b58-8117-4c7fae53e7cb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("74a6436d-301b-4023-b3b6-d375582538eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("773cbe69-b026-4a0b-8dc3-8122c410c11b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("786a15c9-d309-4004-bc16-f215bcf7dd6d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("79719abf-8402-4f7a-8d62-1fdcb3173942"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7a70277c-1faf-42ee-97a2-2844da375365"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("7c57ca91-7c29-4ead-9e50-3b45cf1ce35b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("abfd87ca-43fb-4b52-9c42-5f191ddcf24e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("bd0fcf32-78c4-4b48-ae01-0bd82372781e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c02ad6d6-a60d-411e-8d70-b9e7c08bf637"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c0498ab3-31aa-4b43-91e6-a2e8bae5a4b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c4170f3a-10b2-4d7e-a01e-a417c955e60b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("cd5fa647-7559-4b3f-8b40-23cc2577f3b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d42ba6f8-e922-46e7-a935-d5683ea64d64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("dcde0ea9-d453-488c-b45b-6bf1fdd485a6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e3afe3e6-3ea0-4a72-b2f8-696e682a1ca0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("e9666ace-6ba9-4d70-80af-9ec81a5638fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f400876d-fd4c-4ed9-a142-2d346bf1bea2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f48e126f-9328-4495-a7b8-ff628f2e0850"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f849a51f-dce2-4e67-9bbd-ebbabd322b57"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("f954664a-614a-4ab2-a622-7dacdfd2057e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("c8ee8bb2-34f9-403c-9f30-5f102b2819b7"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new Guid("069c4934-601b-4e78-b8b2-c07af9172255") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("245cc3b6-f720-484b-be1b-f299246806df"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("27d17dc1-fd2b-4bd8-b14c-5d639ea43f5e"), new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"), new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("599e8a83-1b71-4992-944e-beb5f8cdaf33"), new Guid("9133695c-dfae-474a-b418-1ac79a871132") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("599e8a83-1b71-4992-944e-beb5f8cdaf33"), new Guid("a81a8261-19a9-4024-8d03-42728ef3c71a") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"), new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                keyColumns: new[] { "ArticleCategoryId", "ArticleId" },
                keyValues: new object[] { new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"), new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("04221c2e-4c07-46d0-a7b5-198b3a992a47"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("117fc0ed-ac9d-4215-b6a3-dac11c5e613d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("2b212423-6767-486b-b784-135515aa28a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("387f7afe-4743-4485-9b1e-70d0aa4643a4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("79723846-71b1-4aae-8ea8-f987f8925959"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("84b03af4-def8-4c25-9e72-45c6dff3f248"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("9ffc8306-97e7-4cd0-8695-aa88d0fe904f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("cc0f3667-8a00-4e98-9ecd-d7fe4aaff0b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleComments",
                keyColumn: "ArticleCommentId",
                keyValue: new Guid("f03cec9e-2ae0-43fd-9a22-fa435d498bc7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("04937b2d-17fb-4d03-9a6d-c0da68f02868"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("36ee116c-2b4d-427d-9725-1f697600ba38"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("376e31e6-78e5-43c6-82fd-bfdbca67c4fe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("3dc8be24-d95b-4440-ad3b-67937f1f4577"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("7909145c-cde1-4b12-9ae9-86d0ca087526"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("9bc31669-32c9-4260-ae12-1b18d7503e89"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("9c895779-905a-4c15-97f3-6f502c472e63"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("a7e80f77-39d2-42fd-861c-11604e16128f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleImages",
                keyColumn: "ArticleImageId",
                keyValue: new Guid("cb5ac247-9c78-497f-9ea5-6b34d44e302f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("703810a5-fc2a-45dd-81e3-ead6604c4392"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a4fb4a83-1700-442d-bf88-addcfcd63ae7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd55c8a0-9ef9-4551-859a-85a98b377ccb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c4a8a6ab-e620-441b-bd7d-1d51ac606466"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("0915a20e-e746-4a82-86ea-6a8c42241da9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("12928d2d-9970-4fb0-9e58-04c7ed1e382d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("7746def8-b048-43f2-8535-942660e0ea0e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ClientTestimonies",
                keyColumn: "ClientTestimonyId",
                keyValue: new Guid("bb233703-f3f3-4565-b00c-8061d3fce185"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("003ffede-3503-41ad-98fd-86a583999d5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("00771ae8-3a41-4276-b2a4-b202b839264f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("02127c67-0479-4a65-8be0-ceef7eda49a3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("03623f2b-0955-46e3-a360-aca10f8d1520"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("05103379-f261-4f0c-999b-d9e27376f863"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("06110a1e-da35-41b1-814a-302f80706c7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("076e88a1-9772-4c8e-bc84-aa9bbad10e2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0b6883c2-d72d-46be-96dd-37fe22b55e3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0b6a8b53-de70-4158-84f8-e750c82e8387"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0c5f9d8b-a4cc-48fc-af3a-b5623c307ae7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("0cd20a65-6132-4ed5-8b70-0dd09138c276"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1020b38d-81bb-4aff-b658-50949a9d587e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("12058563-15fa-45f3-8f3b-29a82d06093f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("13320d04-1b14-45b4-9887-00375b70031e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1346f197-9fd2-4feb-b73a-167d09d91659"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("136e30c4-3658-48ee-8890-e82fcc1a23e2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("143f527b-dce1-4b2d-93bb-9d5d681b65ee"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("168d7869-7ce3-47df-9a00-e93930080e3b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("181e260f-4675-4bdb-965b-ae6e82880cf9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1b89719b-7d8d-46b8-b7a8-dc25274a4fc3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1c059d56-655a-4237-a5dd-619c62b7e014"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1cccdfed-78bf-430d-822e-144c49a888e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1dd7aeb3-5912-4847-9417-0c7c1be29df4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("1eb437e8-8332-4334-86b8-7541f3646613"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("245d0529-fced-4ca9-a336-ee190474c9ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("275b5d65-c1b5-49e3-8b95-d8dc2174aca1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("27df0c48-5aab-476e-8291-f165e14cbf41"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2881a12a-80d5-4018-b8ba-624c78da106a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("28d83e47-df22-40c2-b780-d74ba67955a5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2992ff71-6e25-432e-9af3-60b2cd86880d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2b5a8721-9752-4f17-bf15-cde31e346d39"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("2cdfc9a0-376e-4bac-b60e-7d29cafe389b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("31bfc1fe-97ae-4ce3-b29c-59a9a3c11f7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("32123824-fcb4-4085-a867-1961f04c8783"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("33e8f81f-4c30-4df4-9eff-bb59e3fc6a94"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("354e6f83-6a8d-4f58-bd8e-9f400448f409"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3672bddc-351f-4d57-90a5-fed46b7d1029"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3868831b-a6f2-4739-8e76-1acd49c74fdc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3a48b489-38ad-49cc-ac60-4c967ae9ae2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3a5e5ae8-ee62-4e03-88b8-2ff5919e30c1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3a8643d4-58a7-43f2-9f77-4ee75b451269"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3b706679-20ed-4132-9b68-d4315c8a034a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("3d8880da-495b-42fe-bd9d-f5c5fe8c39fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("426166c3-a631-472c-8b68-f96118b9b032"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("445a7266-1227-4777-b5f0-30a4a5af73b9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4aa8d5c9-c9b6-4491-8e0a-a7170003cb96"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4ab84fd2-0e09-4d63-a120-39d05ac53b4e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4bb20c26-6940-45d8-a96c-80ff0a9a5074"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("4c2109e7-0f63-4f12-a91d-8fef9221230d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("54c68cb7-75af-4613-8fc5-13f3b0c111f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5664aaa7-dac8-40fa-9b8e-35513b02f1b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5a07b571-023a-44af-adc6-ffd6513be77b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5c968f68-fc0b-48c9-a955-073e914e08c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5de6d47b-b652-4891-be3f-96bd84c4d439"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5f0fc3b2-ceb4-4baa-a560-8d2710468f7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("5ffcc0d7-5fe5-4036-a857-b52c9a4394d1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6204816c-d750-4ee6-a1d2-8f1d3da0cf4b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("652f95f7-9c27-49f4-b220-0eac4f4bd60c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6edc15e9-041e-466c-97cc-7d3db6c1fab6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6f54faea-6210-49b4-8de1-99af2c1ebd9e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6fcec479-f519-410f-b7fc-1f6875e26ed9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("6ff1e668-387f-4605-b8cc-0aec80792028"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("70a296dc-48fb-4059-805a-eb4528174ee1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("70e8fdf5-44dc-4615-bb6f-7949b298f823"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("76afab01-0927-4086-be71-423453bc849e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("78f32465-41d3-41e2-aa33-2d35163d60ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7b7417d8-2fb1-4cc0-8929-1731902cb762"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7d6d36ac-146b-49d8-8ddb-ef70a2cfc3be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("7fbb23eb-0400-4a7f-bdb4-bdc4bc9fb438"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("80a63316-f99b-420a-9496-346b156c1f44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("85e87c6d-0380-4ba1-915c-ee0ab402b86e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("86d0f192-5a4c-4e80-8950-f9db4bb9266f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("873c1db0-d4c8-47c8-bd16-832b6ee3d451"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("87671b76-bc52-4655-8ed8-75d462670263"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8added2b-9486-4518-8258-ec3832046d04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("8dd51b46-e098-4b6e-aed6-2e456365e907"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("90f56c45-ccf2-4503-8fc6-754d9daffba1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("93b7f050-e490-47d2-93c2-4034498fe581"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9467b09d-e680-42e3-98c3-c57b1d0aa152"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("95857f57-3614-4bc5-bef5-15b4d132d8ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("980b2a3f-d642-4240-bfd4-6bf3f2b5c617"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9b496287-ab5b-4ce3-b6e1-9b40f16e1dbd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9be6c8ee-4ead-443f-966b-0701b602f8eb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9d79c6d1-9e15-4ff7-88f0-764ce7d6bd78"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9db3a8ea-9f31-4ab8-ad99-7f5e19db2056"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9e66dc8c-a895-470d-a93d-a6f3ae0c9e19"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("9f5887ec-9e5d-42fc-baa4-0dbfc7cb8d7d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a0286fc0-b4a2-4ccd-9f69-2e7c2d88f093"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a79a1b89-218e-426f-bae4-2e6ba435cb43"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a818cac7-768e-4f40-b49c-c9770a16ef10"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a85aced3-7434-4cb2-b823-538ea1cce136"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("a95f0298-d940-4bbe-84be-0218b2a5a845"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("afa5480e-07a0-4eeb-8041-a74901770889"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b02baecc-1b19-4504-aac3-8a79ee9c4703"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b1e31f3b-fe20-4c39-94c3-5479fe2aadd0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b4997dc2-0bc0-4299-a61b-36cbb06ac316"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b49d7ce4-4dd0-486c-87e8-403df415f82f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b4ddd56e-e1e4-417e-bc48-8585011cc4ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("b948bfe5-4093-4e0e-9972-098943865e08"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bac77158-f7ed-46e6-b22a-2ecccf140b0a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bb005d22-6bdd-449e-9d32-e47e276da184"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("bf1ebd72-5095-4989-a7d1-d6c5b2215bcd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c17f9607-fb84-4be1-a453-ba0a5cdce1dd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c59ddf5d-0ce4-46bc-96ad-cf712ac241a2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c6dadfae-1ec6-4b50-bcaa-85531cdcfb7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("c795de72-22fa-4e3d-8263-2c9534317fc1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ca953656-22f8-48ca-b05c-8d8e1280f92d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd0bd053-c9b7-4003-8605-042a1ed16dba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cd900db6-cfae-43d2-b8e2-1ff5f3c693c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ce97f751-4179-4588-ad6b-4c9f00bed4e1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("cebc1a96-1662-450e-b98e-f10147f15f44"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d300f751-3e70-43cb-bd16-acee283de624"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d30149a7-9c9a-4cad-99f5-b6893ba9551d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d35e97ad-5d6d-4565-ace7-c54bc5ff687b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d40f9b50-947d-4b84-b704-9b053ff99c62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("d8b57e36-ba4d-4d5b-b10e-cce63013e025"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("dc1dea63-3d57-41b2-9d69-2fe140926e00"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("df48e082-a62f-4b06-b34a-28b0aa0e056e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e1871c1d-d1f9-4bca-b8f0-657c4f6e4e7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e3231215-4b13-4a57-a46f-972e1ba88844"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e6670871-1cc7-432c-bc9c-51b240d743b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e6e0014b-bc48-4895-a3c1-db5f726603da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e71496be-fd66-4b7e-92ac-60caaf026ce1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e7b0cfb2-69e6-498b-aa1c-1c696327c981"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("e8e45a16-b627-4e8d-8003-8fe24a018d9a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ece91d4d-c6c8-4b46-9567-34c71732b819"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ef50a8f5-6082-4591-90ce-76a7a0e44594"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f0c60d80-f4bc-402a-b6fc-c591baeeb1de"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f222fb33-37c1-4067-a262-8ed2de4d3114"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f2f34bf2-3ce2-4dfd-9f49-49e70b40f9e9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f3a7ea0a-0527-4e3e-9797-87fcc30b6192"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f83469ef-da7c-44c9-8336-4ff145c38fa4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f83b35a7-3027-4aa0-81af-a5dd6a3c646f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("f9580595-c14f-4e7e-a49a-4a3dbb58772e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fad0a9aa-3756-484f-a6ef-3d3daddd9c3d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fc6476c3-9bbd-4952-bd85-69b14e41f002"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("fe0f7f2d-a2b0-4622-a42a-b6e8b1549833"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjectImages",
                keyColumn: "FeatureProjectImageId",
                keyValue: new Guid("ff6302d2-074b-4312-a115-bba2a10566e6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("00e14998-1a53-4833-90a5-2205d18e9e54"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("033882f9-1179-4ab4-b6ea-39ef858a62f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("03667715-e064-493f-a20b-413b22873ceb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("19aa01cb-659b-4505-a169-4a52e7ecead8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("27a8254e-82f4-406d-98cb-b9bae39a5d41"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("2db78e5d-0acf-4eff-9043-4d069cf5575c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("4660d22f-ba41-41bf-9faa-96c215e815fd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6147cab2-3a63-4fbf-b848-8d5414960c39"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("622d84e9-6060-4d9a-9751-6b124ce09502"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("6f2ea6aa-20a8-4caa-abf8-ffcc94589b68"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7478c0ec-6af5-4929-979e-33c360ebe6ca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("79b9c835-55ea-4202-8f8b-a5db8fde0d3e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("7b31e5ef-c1a0-431d-a49a-2d4260dc9bf6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("8424d242-9bce-4c6a-8c90-3577921d8a6e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("9d7e3816-6500-4658-b202-84683e327c15"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c97f3f8b-4e9c-45c2-9d12-c1da5f7ed5fb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("c9b77094-62f5-4f00-a335-d1293d154799"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("cf42cd48-86d3-47fe-abf9-f2997f1a133f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d3e09194-0e68-4da3-af56-c06b6e4969f6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d58e1e9d-5c9d-49fa-a1b8-4eeacbcc7558"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("d7ff628b-67ec-4057-a3c0-5c82ef7801f1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "QuestionAnswers",
                keyColumn: "QuestionAnswerId",
                keyValue: new Guid("f2113ce0-efd7-4026-87fa-e364f959161b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fe44812c-d5cc-4a0c-a6c1-950a28f979c6"), new Guid("7c559818-b7e0-4779-8ac7-2e199fcf0079") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f1c93611-32e1-4bf5-9f57-9c0a666c6070"), new Guid("9dee3908-b748-48a1-bcbc-66f864d19db6") });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("245cc3b6-f720-484b-be1b-f299246806df"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("27d17dc1-fd2b-4bd8-b14c-5d639ea43f5e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("3148cac8-d7a6-4037-b39a-20f5af456356"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("443ddcd6-6bf1-466e-ace7-20d6ed20b777"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("599e8a83-1b71-4992-944e-beb5f8cdaf33"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("c8ee8bb2-34f9-403c-9f30-5f102b2819b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ArticleCategories",
                keyColumn: "ArticleCategoryId",
                keyValue: new Guid("d0193181-8fa9-4c57-9f05-26031abcbd8b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("069c4934-601b-4e78-b8b2-c07af9172255"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("49d9a575-6eeb-4480-95b5-6c5500e0bdb3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("5e7edecd-a173-4b78-b3d0-598808f8e582"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("5f2ff16e-e2fd-4410-8913-a7f76f035591"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("84f7debf-7649-45aa-8ec7-17130ef142d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("9133695c-dfae-474a-b418-1ac79a871132"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("a81a8261-19a9-4024-8d03-42728ef3c71a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("cc529c8d-77f3-4bb4-9f47-f615676c9d52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: new Guid("e9968afe-f952-47ab-88d6-72c95cb909ae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f1c93611-32e1-4bf5-9f57-9c0a666c6070"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe44812c-d5cc-4a0c-a6c1-950a28f979c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("01da6872-2903-451b-990b-1083b2bf87cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("0690b14c-52a6-4e71-a65b-7ece3405f658"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("1a27d09a-f757-4825-b926-40dff37bd6b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("3805e82a-d6f1-44ac-abe1-91a193e9c855"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("3bf871f0-8cd5-4685-9c6e-1813bcf18fa3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("57095158-a49f-47a0-ac5c-a30f8ec34b9d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("667de924-7d63-4a3a-8e12-941defd8b0b4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("6f473f73-9cd2-4f24-a77e-1ac69c3547c6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("9983bcb6-129a-46e6-85bb-25ace9836b6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("b25a1e6d-8a14-44ea-b26a-8d83b53b4501"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("b8f79fbf-af5e-4970-9748-dd3ff285b31e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("c828e086-c508-47c1-ae7f-938dc63a8653"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("e4eb7fdb-9586-4b11-8b46-a07f03eaf910"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeatureProjects",
                keyColumn: "FeatureProjectId",
                keyValue: new Guid("eecd91f2-8079-429c-8a27-ce01c3caa4b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("628f2d66-4137-4f49-ae14-bf41b994ba92"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserProfiles",
                keyColumn: "UserProfileId",
                keyValue: new Guid("b4ac3df3-a94d-4ca3-adad-fa77244a05c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c559818-b7e0-4779-8ac7-2e199fcf0079"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9dee3908-b748-48a1-bcbc-66f864d19db6"));

            migrationBuilder.DropColumn(
                name: "Slug",
                schema: "dbo",
                table: "FeatureProjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 226, DateTimeKind.Local).AddTicks(8098),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 951, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 244, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 965, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 245, DateTimeKind.Local).AddTicks(4688),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 966, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 245, DateTimeKind.Local).AddTicks(9546),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 967, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 246, DateTimeKind.Local).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 967, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 227, DateTimeKind.Local).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 952, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 246, DateTimeKind.Local).AddTicks(6120),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 967, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 247, DateTimeKind.Local).AddTicks(201),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 968, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 228, DateTimeKind.Local).AddTicks(9800),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 953, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 229, DateTimeKind.Local).AddTicks(3145),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 953, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 243, DateTimeKind.Local).AddTicks(5913),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 965, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 242, DateTimeKind.Local).AddTicks(2648),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 964, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 242, DateTimeKind.Local).AddTicks(5606),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 964, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 241, DateTimeKind.Local).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 963, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 26, 23, 28, 12, 228, DateTimeKind.Local).AddTicks(1742),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 14, 29, 25, 952, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategories",
                columns: new[] { "ArticleCategoryId", "_dateModified", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("034c6fc4-b784-4b50-a210-8252d9ae7b04"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(795), true, "Building Codes and Standards" },
                    { new Guid("08024c3b-55a7-4ff6-8724-39bddb07e3fd"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(881), true, "Cost Estimation and Budgeting" },
                    { new Guid("140b623e-e14a-4d8d-9ec0-9a00e936494e"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(804), true, "Community and Culture" },
                    { new Guid("25bb04ba-2936-41e5-a87e-52fe7000b802"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(927), true, "Real Estate Development" },
                    { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(807), true, "Company Updates" },
                    { new Guid("29879c76-a526-48b2-a7bb-70bc9ab8ed2a"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(862), true, "Construction Careers" },
                    { new Guid("2be22577-1742-4274-856d-9c71b6d80b3f"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(913), true, "Innovation Awards and Recognitions" },
                    { new Guid("363a67a6-054c-4662-aea4-92ff1aa19352"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(936), true, "Supply Chain and Logistics" },
                    { new Guid("3665eb02-e76c-40b2-bd42-8a749097506a"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(877), true, "Construction Management" },
                    { new Guid("394924c2-f934-40fa-b16f-756de86d6adb"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(923), true, "Project Showcase" },
                    { new Guid("39ef228f-3df3-4299-9ba3-651cf9689148"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(915), true, "Landscaping and Outdoor Design" },
                    { new Guid("4925d86e-41e1-46e5-bc60-f13e49442c8e"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(940), true, "Technology in Construction" },
                    { new Guid("49a6ae66-0216-4083-b0e8-c1ce173b5a50"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(942), true, "Training and Certification" },
                    { new Guid("60185ef7-d8bc-49d7-9da3-0d1e51f0a4c4"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(903), true, "Historic Preservation" },
                    { new Guid("67b9fd42-3288-4831-ac83-b019c8a8aba2"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(901), true, "Health and Wellness in Construction" },
                    { new Guid("6c7c847a-1866-4e0e-9e5e-fd396ab4f471"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(889), true, "Energy Efficiency" },
                    { new Guid("6ddf1db5-1ea1-40fd-b655-7410f65e0020"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(874), true, "Construction Finance" },
                    { new Guid("77623a31-b80b-410d-b1e1-b225495f8b6a"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(921), true, "Modular and Prefabricated Construction" },
                    { new Guid("7cd068de-0a33-44ab-843a-9c063a3502b7"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(798), true, "Case Studies and Success Stories" },
                    { new Guid("7df66f29-356c-4423-8714-64ef89c9c602"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(802), true, "Client Resources" },
                    { new Guid("7ed387f4-9a8a-4072-97ce-4f0dc7669bee"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(932), true, "Safety and Compliance" },
                    { new Guid("9380b341-9558-4705-b796-f41bbaa0a98e"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(909), true, "Innovation and Future Trends" },
                    { new Guid("982d56ec-4420-4b0c-bc26-dfc7e1bcb88f"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(934), true, "Smart Home Technology" },
                    { new Guid("a73d3db0-fef3-4d4c-825f-bd55e2433389"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(919), true, "Materials and Equipment" },
                    { new Guid("a86287f9-9c7c-40c2-bbce-ef68cc2eee7a"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(899), true, "Green Building Materials" },
                    { new Guid("ac058418-f303-4fc2-9c00-5390a0c36da2"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(917), true, "Legal and Insurance" },
                    { new Guid("acde4273-4e17-4586-beeb-0255596dbc5d"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(944), true, "Urban Planning and Development" },
                    { new Guid("b436e1d1-529e-4c66-8ec1-fbb7eafcfd03"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(752), true, "Accessibility in Construction" },
                    { new Guid("bfbcc35b-693a-41ff-beea-f21b8738a892"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(887), true, "Disaster Preparedness and Recovery" },
                    { new Guid("c3e2412e-3c48-4649-bc57-710fffe21ac4"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(946), true, "Weather and Seasonal Tips" },
                    { new Guid("c7ffcc3a-35e1-485f-8aa1-fa37956db325"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(883), true, "Customer Stories and Interviews" },
                    { new Guid("cb387514-e284-4f94-8131-ff5c51972f6e"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(897), true, "Equipment Maintenance" },
                    { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(800), true, "Client Education" },
                    { new Guid("ceb01a13-7020-476b-8a91-d7ad56281055"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(879), true, "Construction Techniques" },
                    { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(907), true, "Industry News" },
                    { new Guid("e7127571-3151-4e03-aa5a-182ee9fa0863"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(905), true, "Home Improvement and DIY" },
                    { new Guid("f1e3fa21-b6a2-41e3-858d-ec7d5597a61c"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(925), true, "Property Management" },
                    { new Guid("fa0adb48-5bf4-4e86-b262-8c8ec16317fc"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(938), true, "Sustainability and Green Building" },
                    { new Guid("fc168850-f3c2-4b3b-8a17-eecee92ea220"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(895), true, "Environmental Impact" },
                    { new Guid("fefaf0b8-8001-494d-af07-60510b14c5bf"), new DateTime(2024, 6, 26, 15, 28, 12, 247, DateTimeKind.Utc).AddTicks(885), true, "Design and Architecture" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleOverview", "ArticleStatus", "ArticleType", "AuthorAvatarImageCDNUrl", "AuthorName", "AuthorUserProfileId", "CanonicalUrl", "Content", "ContentSourceMDCDNUrl", "ContentSourceMDFileName", "_dateModified", "Hearts", "IsActive", "IsFeatured", "LastModified", "Likes", "MetaDescription", "MetaKeywords", "PublishedDate", "QuestionAnswerId", "Slug", "Tags", "Title", "Views" },
                values: new object[,]
                {
                    { new Guid("30f8e945-ef5b-4316-91ba-7cac29399f93"), "In a strategic move, Ladon Construction Services emphasizes small residence house improvement projects for sustainability. This enhances community ties and aligns with environmental goals. Charles Reyes notes, \"These projects deliver personalized solutions, promote energy efficiency, and integrate green materials.\" By expanding into smaller projects, Ladon aims to diversify while committing to sustainable practices, fostering innovation in local communities.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", null, null, "lcs-expands-focus-small-house-projects.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(411), 0, true, false, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services expands its focus on small residence house improvement projects to promote sustainable growth and community engagement.", "[\"sustainable construction\",\"community engagement\",\"small residence projects\",\"environmental responsibility\"]", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-expands-focus-on-small-residence-house-improvement-projects-for-sustainable-growth", "[\"Sustainability\",\"Green Building\",\"Community Engagement\"]", "Ladon Construction Services Expands Focus on Small Residence House Improvement Projects for Sustainable Growth", 0 },
                    { new Guid("3a49b439-f8cc-40ce-819d-e80919b99294"), "\n		In the construction industry, hiring certified and well-trained skilled workers versus self-claimed experienced builders significantly impacts project success. Certification signifies proficiency and adherence to industry standards, providing numerous benefits in training, safety, and professionalism. This article explores the reasons for opting for certified skilled construction workers, highlighting their advantages and the risks of unverified experience.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/certified-vs-self-claimed-experienced-builders-why-certification-matters", null, null, "certified-vs-self-claimed-experienced-builders-why-certification-matters.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(196), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Choosing certified skilled construction workers ensures higher quality, enhanced safety, and long-term cost savings compared to self-claimed experienced builders.", "[\"certified construction workers\",\"skilled labor\",\"construction safety\",\"construction certification\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "certified-vs-self-claimed-experienced-builders-why-certification-matters", "[\"Construction\",\"Skilled Workers\",\"Certification\",\"Safety\"]", "Certified vs. Self-Claimed Experienced Builders: Why Certification Matters", 0 },
                    { new Guid("825dedb8-ff61-43b1-a747-eeda76999bb2"), "\n		In the realm of construction services, the focus often leans towards large-scale projects. However, at Ladon Construction Services, we recognize the sustainability and value in catering to small residence house improvement projects. These projects contribute to economic viability, community engagement, and environmental responsibility, offering flexibility, enhanced client relationships, and opportunities for skill development. Discover how our approach fosters sustainability beyond environmental impact and strengthens our commitment to excellence and community enrichment.\n	", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/small-residential-projects-sustainable-for-ladon-construction", null, null, "lcs-Small-Residence-Projects-Sustainability.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(693), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Catering to small residence house improvement projects: exploring sustainability, community engagement, and economic viability in construction services.", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "small-residential-projects-sustainable-for-ladon-construction", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "Small Residential Projects: Sustainable for Ladon Construction", 0 },
                    { new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a"), "Ladon Construction Services has been awarded a significant contract to construct a state-of-the-art office complex in downtown, marking a major milestone for the company under the leadership of Mr. Charlemagne Reyes. The project promises to be a testament to the company's commitment to innovation and sustainability, with construction set to commence in August 2024.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-secures-major-contract-downtown-office-complex", null, null, "lcs-Secures-Major-Contract.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(628), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ladon Construction Services, led by Mr. Charlemagne Reyes, secures a PHP10M contract to build a 20-story office tower downtown, marking a significant achievement", "[\"construction contract\",\"downtown office complex\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-secures-major-contract-downtown-office-complex", "[\"Construction\",\"Contracts\",\"Office Complex\",\"Downtown Development\"]", "Ladon Construction Services Secures Major Contract for New Downtown Office Complex", 0 },
                    { new Guid("a160b727-85c4-4e04-a1a7-61aa79d2a674"), "\n		In today's construction industry, innovative materials like recycled concrete and bamboo are reshaping sustainable building practices. Learn about their benefits, applications, and environmental impact.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/innovative-materials-in-construction-from-recycled-concrete-to-bamboo", null, null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(276), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Exploring the use of recycled concrete and bamboo as innovative materials in sustainable construction.", "[\"recycled concrete\",\"bamboo construction\",\"sustainable building materials\",\"environmentally friendly materials\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "innovative-materials-in-construction-from-recycled-concrete-to-bamboo", "[\"Sustainability\",\"Recycled Concrete\",\"Bamboo\",\"Construction Materials\"]", "Innovative Materials in Construction: From Recycled Concrete to Bamboo", 0 },
                    { new Guid("a533ed61-e3dd-493d-bfa7-7ed56dc32c21"), "The construction industry plays a vital role in sustainability, impacting the environment throughout a building's lifecycle. Sustainable practices like energy efficiency, water conservation, and waste reduction offer benefits such as cost savings and healthier spaces. Innovations like green roofs and smart technology drive progress. Ladon Construction Services leads in sustainability, surpassing standards and collaborating for a greener future.", 3, 1, "", "Charles Reyes", null, "https://ladonco.ph/blog/sustainable-solutions-building-a-greener-tomorrow", null, null, "lcs-sustainable-solutions.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(740), 0, true, false, new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Leading sustainable construction to minimize environmental impact for a brighter future", "[\"sustainability\",\"green construction\",\"environmental impact\",\"sustainable solutions\"]", new DateTime(2024, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "sustainable-solutions-building-a-greener-tomorrow", "[\"Sustainability\",\"Green Building\",\"Environmental Impact\"]", "SUSTAINABLE SOLUTIONS: BUILDING A GREENER TOMORROW", 0 },
                    { new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f"), "\n		At Ladon Construction Services, we invite you to bring your dream projects to life. Learn about our comprehensive services, experienced team, and commitment to excellence.\n	", 3, 1, "", "Charles Reyes", null, "https://example.com/blog/build-your-dreams-with-ladon-construction-services", null, null, "build-your-dreams-with-ladon-construction-services.md", new DateTime(2024, 6, 26, 15, 28, 12, 444, DateTimeKind.Utc).AddTicks(9609), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Discover Ladon Construction Services and how we exceed expectations in residential and commercial construction, renovation, landscaping, and more.", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "build-your-dreams-with-ladon-construction-services", "[\"Mindanao\",\"Davao City\",\"Trusted Construction Company\"]", "Build Your Dreams with Ladon Construction Services", 0 },
                    { new Guid("c50adbc7-70f2-4091-96e7-1252e8409708"), "\n		LADON Construction Services, headquartered in Davao City, has won the public bidding for the fit-out works of Northpoint Camella. Established in 2021, the company's rapid growth underscores their commitment to excellence and sustainable building practices.\n	", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/news/ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", null, null, "lcs--wins-public-bid-for-northpoint-camella-fit-out-in-davao-city.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(345), 0, true, false, new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "LADON Construction Services secures significant milestone with Northpoint Camella fit-out project in Davao City.", "[\"LADON Construction Services\",\"Northpoint Camella\",\"fit-out project\",\"Davao City construction\"]", new DateTime(2024, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-wins-public-bid-for-northpoint-camella-fit-out-in-davao-city", "[\"Construction Industry\",\"Public Bidding\",\"Fit-out Works\",\"Davao City\"]", "LADON Construction Services Wins Public Bid for Northpoint Camella Fit-out in Davao City", 0 },
                    { new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c"), "Ladon Construction Services, founded in 2021, is a leading construction company dedicated to delivering exceptional services under the leadership of Mr. Charlemagne Reyes. With a team of experienced professionals, they prioritize meticulous attention to detail and superior customer service.", 3, 0, "", "Charles Reyes", null, "https://ladonco.ph/blog/ladon-construction-services-new-leader-industry-charlemagne-reyes", null, null, "lcs-New-Industry-Leader.md", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(470), 0, true, false, new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, "Founded in 2021, Ladon Construction Services quickly became a leader in the construction industry under Mr. Charlemagne Reyes' guidance", "[\"construction industry\",\"leadership\",\"Charlemagne Reyes\",\"Ladon Construction Services\"]", new DateTime(2024, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "ladon-construction-services-new-leader-industry-charlemagne-reyes", "[\"Construction\",\"Leadership\",\"Industry News\"]", "Ladon Construction Services: A New Leader in the Construction Industry Under Mr. Charlemagne Reyes", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("01a1d43f-607b-443f-a7c2-407de94aad9c"), null, "Visitor", "VISITOR" },
                    { new Guid("1a0bff99-3bfc-43ca-8a71-00b44df30d53"), null, "Client", "CLIENT" },
                    { new Guid("296c5883-68c8-485c-8dd3-c16e54baf5bf"), null, "Moderator", "MODERATOR" },
                    { new Guid("393c86c1-e0fc-4635-833a-feefd300f78d"), null, "Admin", "ADMIN" },
                    { new Guid("5134c0a2-eb7f-4876-93a9-50a9ce3a0fe2"), null, "Manager", "MANAGER" },
                    { new Guid("f7a07d01-dd3a-4dc5-9779-bd9eaede016c"), null, "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientTestimonies",
                columns: new[] { "ClientTestimonyId", "ClientBusinessName", "ClientName", "ClientProfession", "ClientThumnailUrl", "_dateModified", "IsActive", "ProjectImageUrl", "Remarks", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("2e99efa9-2b3e-45f1-9e21-97c82dcb536b"), "RDN Shipping", "Mr. Donnie Tefasco", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/download.jpg", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(1569), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/eyJidWNrZXQiOiJwcmQtbGlmdWxsY29ubmVjdC1iYWNrZW5kLWIyYi1pbWFnZXMiLCJrZXkiOiJwcm9wZXJ0aWVzL2VlNTgwMTNhLTU4NGMtNGE5My05N2U4LTU4NjEzNDIwYWMzMS8zOTE5ZjVmYS1hM2U3LTRlMTAtODE4OS03MGQ0NjMwNWY4NTkuanBnIiwiYnJhbmQiOiJET1RQUk9QRVJUWSIsImVkaXRzIjp7InJlc2l6ZSI6eyJ3aWR0aCI6MTE3MCwiaGVpZ2h0Ijo3ODAsImZpdCI6ImNvdmVyIn19fQ==", "Working with Ladon Construction Services for our shipping depot warehouse in Taguig was a game-changer. Their meticulous planning and seamless execution exceeded our expectations. From structural engineering to interior fit-outs, every detail was handled with precision. Their team's expertise and dedication ensured our project was completed on time and within budget. We highly recommend Ladon for any construction project, big or small—they truly bring dreams to life!", null },
                    { new Guid("84ab7ce6-64f2-484a-8a52-b34092ecfd25"), "AgriVents (Rizal)", "Mr. Thomas Bernardino", "Businessman", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_72.jpg", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(1578), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/shed-insulation-poultry.jpg", "Propesyonal, mabibilis at masisipag ang mga tao ni Charles! Sulit sa cost ng contract napagkasunduan namin. Napakinabangan ko kaagad pinapagawa kong poultry facility.", null },
                    { new Guid("8857ad68-4f2b-4255-b5ca-98048a87a41d"), "La Cordia Centre Mall", "Mr. Arnold Dominguez", "VP Operations", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_73.jpg", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(1587), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/Untitled-2021-01-23T180416.134.jpg?updatedAt=1718613750156", "We are immensely grateful to LADON Construction Services for their invaluable expertise in completing the fit-out works for our small town commercial mall. Their team exhibited exceptional professionalism and attention to detail throughout the project. Despite the challenges we faced, they ensured timely delivery without compromising on quality. LADON's commitment to excellence and client satisfaction truly sets them apart. We highly recommend their services and look forward to partnering with them again in the future.", null },
                    { new Guid("b0d893c5-6d31-499e-8dfd-1e5a1efed667"), "Rice Sprout Orchids", "Mr. & Mrs. Rominadores", "Business Proprietor", "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Client-Profiles/2024%20LCS_ladon_71.jpg", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(1583), true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Testimonies-Images/358969675.jpg_k=36a69f0e8594a860d13c9e529ef60256a1ab5428780c13a09526aa10da3e534b&o=&hp=1?updatedAt=1718613620130", "Engaging Ladon Construction Services for our construction needs was a worthwhile decision! Despite their busy schedule, they maintained excellent professionalism by keeping us updated on our projects, even while we were overseas. They consistently surpassed our expectations and delivered outstanding results.", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjects",
                columns: new[] { "FeatureProjectId", "CompletionDate", "_dateModified", "Description", "HideTitle", "ImageCDNUrl", "IsActive", "Location", "Title" },
                values: new object[,]
                {
                    { new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8422), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-2.png", true, "Davao City", "Verdon Park Condominium" },
                    { new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), null, new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(5750), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", true, "Davao City, Philippines", "LADON Construction Service - Davao City Headquarter Office" },
                    { new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), null, new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6754), "Caters to multiple types of construction jobs like New Constructions, Restorations, Renovations, Fit-outs, among others. Please see the service section of this site showcasing our offered services.", null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-1.png", true, "Philippines", "Company Workforce" },
                    { new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), null, new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7142), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", true, "Philippines", "LDS Church Improvements" },
                    { new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8584), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", true, "San Pedro, Laguna", "San Pedro Laguna LDS Chapel" },
                    { new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8154), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", true, "Lingayen, Pangasinan, Philippines", "Mang Inasal" },
                    { new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), null, new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7557), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", true, "Davao City, Philippines", "UM Library Fire Protection & PBAX Paging Systems Project" },
                    { new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7744), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", true, "Barangay Carmen Panabo. Davao del Norte, Philippines", "Carmen LDS Chapel General Repainting & Electrical Works" },
                    { new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9533), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", true, "Guimba, Nueva Ecija", "LDS Chapel Retaining Wall Construction" },
                    { new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9261), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", true, "Cainta, Rizal", "General Milling Station" },
                    { new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8820), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", true, "Aringay, La Union", "Aringay LDS Chapel Retiling and Repainting Works" },
                    { new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), null, new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8057), null, true, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", true, "Sasa. Davao City, Philippines", "Sasa LDS Chapel General Repainting & Retiling Works" },
                    { new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9667), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", true, "Talavera, Nueva Ecija", "Talavera Chapel General Repair Works" },
                    { new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8296), null, null, "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", true, "Muntinlupa, Metro Manila, Philippines", "Muntinlupa LDS Chapel Elevator Project" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "QuestionAnswers",
                columns: new[] { "QuestionAnswerId", "AnswerText", "_dateModified", "IsActive", "IsImportant", "Question", "RelatedArticleId" },
                values: new object[,]
                {
                    { new Guid("026aa3e1-e9b6-488e-8728-3f46c02b222c"), "Project costs are determined based on the scope of work, materials, labor, and any specific client requirements. We provide detailed estimates to ensure transparency.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7104), true, null, "How do you determine the cost of a construction project?", null },
                    { new Guid("0f46416e-309e-44c8-9ece-fc752742ff6b"), "Important considerations include your budget, desired timeline, the scope of the project, and any specific requirements or preferences you may have.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7097), true, true, "What should I consider before starting a construction project?", null },
                    { new Guid("1bbf6759-9655-440d-a5d1-7d252f40c643"), "We work closely with our clients to establish realistic timelines and ensure that all milestones are met.Our project management team oversees every phase to keep things on track.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7090), true, true, "How do you handle project timelines?", null },
                    { new Guid("1f9c61b1-0407-4b5e-ae39-a1abc7782f21"), "No, our estimates are transparent and all - inclusive.We believe in honesty and integrity in all our dealings.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7113), true, true, "Are there any hidden fees in your estimates?", null },
                    { new Guid("37679344-ab1a-4a2b-80d3-e73dfe00c0c3"), "Yes, we offer flexible financing options to help make your construction project more affordable.Please contact us for more details.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7107), true, null, "Do you offer financing options?", null },
                    { new Guid("3e80ebfa-bdf8-4b3f-82c9-a2e26ad2801b"), "We use high - quality materials and employ skilled craftsmen.Our project managers oversee all work to ensure it meets our stringent quality standards.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7129), true, true, "How do you ensure the quality of your construction work?", null },
                    { new Guid("42b05cac-373c-491a-874d-03ebb92afba7"), "Ladon Construction Services offers a wide range of construction services, including residential and commercial building, renovation, remodeling, and custom design-build projects. For more of the services offered, please scroll above to check out the Services we are offerring.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7068), true, true, "What services does Ladon Construction Services offer?", null },
                    { new Guid("440ef974-adb8-41dd-8129-3a8e0f080180"), "Changes can be made, but they may affect the timeline and budget. We will work with you to accommodate any changes as smoothly as possible.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7151), true, null, "What if I need to make changes to the project after it has started?", null },
                    { new Guid("44848744-fa12-4ec1-8a61-fdedb0aa7c6a"), "Self-claimed experienced builders may lack formal training and education, leading to potential safety hazards and lower quality workmanship on construction projects.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7170), true, null, "What are the risks of hiring self-claimed experienced builders?", null },
                    { new Guid("624d15f0-1d66-4eb1-9855-89e5dd47fdb8"), "Yes, we offer comprehensive design-build services, which means we can assist you from the initial design concept through to the final construction.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7094), true, null, "Can you help with the design phase of my project?", null },
                    { new Guid("78dfdd80-f8f1-47fa-8488-6b99fc5991ac"), "Yes, we provide a warranty for all our construction projects to ensure your satisfaction and peace of mind.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7100), true, true, "Do you provide a warranty for your work?", null },
                    { new Guid("87b20cdb-87d1-4306-bed2-d038a09717be"), "We accept various forms of payment, including bank transfers, credit cards, and financing options. Payment schedules are outlined in our contracts.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7125), true, null, "How do I pay for my project?", null },
                    { new Guid("c210737d-1115-463a-856d-4c63fda1af74"), "We provide regular updates through meetings, emails, and our project management portal, ensuring you are always informed about the progress.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7148), true, null, "How will I be updated on the progress of my project?", null },
                    { new Guid("c417e46b-aa5b-4d1f-85fb-7cd4cc8112ff"), "Certified skilled workers often complete projects more efficiently and with higher quality, reducing the need for costly rework or corrections in the long run.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7173), true, null, "How can certified skilled workers contribute to long-term cost savings?", null },
                    { new Guid("c791d970-5181-46e6-a3ec-e0bf348675c1"), "Certification in the construction industry signifies that an individual has met certain standards of proficiency and competence, ensuring quality work and adherence to industry regulations.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7167), true, null, "Why is certification important in the construction industry?", null },
                    { new Guid("d812814e-212d-4de2-8bde-24220b5d3615"), "Yes, clients are welcome to visit the construction site. Please coordinate with your project manager to ensure safety and scheduling.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7161), true, null, "Can I visit the construction site during the project?", null },
                    { new Guid("f14978d2-9f6f-43e1-8f16-4d9fbd131047"), "You will be assigned a dedicated project manager who will be your main point of contact throughout the duration of your project.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7153), true, true, "Who will be my point of contact during the project?", null },
                    { new Guid("f202274d-a92d-47f8-94c5-85e9bea75b97"), "Upon completion, we conduct a thorough walkthrough with you to ensure everything is to your satisfaction.We also provide a comprehensive handover package, including all necessary documentation.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7164), true, null, "How do you handle project completion and handover?", null },
                    { new Guid("f303aa7b-33d0-4b75-be11-a1531e1adefa"), "Ladon Construction Services has been proudly serving clients for over 15 years, delivering high-quality construction and renovation projects.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7083), true, true, "How long has Ladon Construction Services been in business?", null },
                    { new Guid("f43dff18-0686-4cdf-ac30-a0b2f283bc70"), "Safety is a top priority for us.We follow all industry safety standards and regulations, and our team is trained in best safety practices.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7133), true, null, "What safety measures do you take on construction sites?", null },
                    { new Guid("f4c33f64-d0a2-4464-b488-654467188474"), "Yes, Ladon Construction Services is fully licensed and insured to operate in the construction industry.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7144), true, true, "Are you licensed and insured?", null },
                    { new Guid("f61214c0-0d1c-4179-ba35-cec2f3b37673"), "You can request a quote by filling out the form on our 'Request a Quote' page, or by contacting us directly via email or phone.", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7087), true, null, "How can I get a quote for my project?", null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserProfiles",
                columns: new[] { "UserProfileId", "BusinessInstitutionName", "ClientCode", "_dateModified", "FirstName", "Gender", "IdentityUserId", "IsActive", "LastName", "MobilePhoneNo", "ProfileImageUrl", "Salutation", "ThumbnailUrl" },
                values: new object[,]
                {
                    { new Guid("6f1523d9-53bf-488c-b50e-b4e87fab4ef6"), null, null, new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(6789), "Charles", 0, new Guid("9f1c3055-d4e8-419c-921b-9cc46f346952"), true, "Reyes", "+639951225449", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817701/LADON_Team_01_evs4u3.jpg_355_434_-_Google_Chrome_240504181359_ymc3lv.png" },
                    { new Guid("a71bed94-1cd4-4014-b9ed-8bc9c8d2e6c1"), null, null, new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(6739), "James", 0, new Guid("c23a1a42-e73e-4ff5-ac85-50a9b7f54274"), true, "Mangubat", "+639672814641", null, null, "https://res.cloudinary.com/dkgz8tnno/image/upload/v1714817540/Picture_of_me_1.bmp_mx2ysp.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9f1c3055-d4e8-419c-921b-9cc46f346952"), 0, "9bd98dc3-8281-4772-b742-3e07c9efcd24", "ladonconst@gmail.com", true, false, null, "LADONCONST@GMAIL.COM", "LADONCONST@GMAIL.COM", "AQAAAAIAAYagAAAAEOfOmUlt9JZebayesxzgem/vWottzGq5koipVPbSWNzcuokW9fa8+B/4CMGbZanQIg==", "+639951225449", false, "1343d16c-db92-bef8-f34b-278f3c543242_20240626152812247", false, "ladonconst@gmail.com" },
                    { new Guid("c23a1a42-e73e-4ff5-ac85-50a9b7f54274"), 0, "cec8afb1-6221-4032-a041-c75f1bd2502f", "jc.mangubat@hotmail.com", true, false, null, "JC.MANGUBAT@HOTMAIL.COM", "JC.MANGUBAT@HOTMAIL.COM", "AQAAAAIAAYagAAAAELakSWqBeYhmEd/Xr4J8KMQM6GMt8T3eODXB2n4v8LudkYo+dskbKEx8YcXoyMSq3A==", "+639672814641", false, "1343d16c-db92-bef8-f34b-278f3c543242_20240626152812247", false, "jc.mangubat@hotmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Addresses",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "AddressType", "City", "Country", "_dateModified", "IsActive", "PostalCode", "Region", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("4250653e-44c2-48d8-b44a-3327d4d95378"), "Lot20 Blk10 Park Villas 1", "Ellenita Heights, Catalunan Grande", 2, "Davao", "Philippines", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(6990), true, "8000", "Davao del Sur", new Guid("a71bed94-1cd4-4014-b9ed-8bc9c8d2e6c1") },
                    { new Guid("add71cf8-48cc-4ae1-aa21-15bf04bf905c"), "", "Tierra Nueva Tacunan, Tugbok", 2, "Davao", "Philippines", new DateTime(2024, 6, 26, 15, 28, 12, 440, DateTimeKind.Utc).AddTicks(7000), true, "8000", "Davao del Sur", new Guid("6f1523d9-53bf-488c-b50e-b4e87fab4ef6") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleCategoryAssociation",
                columns: new[] { "ArticleCategoryId", "ArticleId" },
                values: new object[,]
                {
                    { new Guid("49a6ae66-0216-4083-b0e8-c1ce173b5a50"), new Guid("3a49b439-f8cc-40ce-819d-e80919b99294") },
                    { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new Guid("3a49b439-f8cc-40ce-819d-e80919b99294") },
                    { new Guid("fa0adb48-5bf4-4e86-b262-8c8ec16317fc"), new Guid("825dedb8-ff61-43b1-a747-eeda76999bb2") },
                    { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a") },
                    { new Guid("394924c2-f934-40fa-b16f-756de86d6adb"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a") },
                    { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a") },
                    { new Guid("fa0adb48-5bf4-4e86-b262-8c8ec16317fc"), new Guid("a533ed61-e3dd-493d-bfa7-7ed56dc32c21") },
                    { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f") },
                    { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f") },
                    { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("c50adbc7-70f2-4091-96e7-1252e8409708") },
                    { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new Guid("c50adbc7-70f2-4091-96e7-1252e8409708") },
                    { new Guid("28a5d83b-b64f-46fe-8e0a-1c8efdd886cb"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") },
                    { new Guid("3665eb02-e76c-40b2-bd42-8a749097506a"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") },
                    { new Guid("cd643e3a-5cde-4b58-aaf0-461f570c55c9"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") },
                    { new Guid("d6e263e9-0d2e-4270-80a8-d7219e754dad"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleComments",
                columns: new[] { "ArticleCommentId", "ArticleId", "AuthorName", "CommentText", "_dateModified", "Dislikes", "Email", "IsActive", "Likes", "ParentArticleCommentId", "UserProfileId" },
                values: new object[,]
                {
                    { new Guid("197bf818-3286-4447-aaee-3957dcc2d2b9"), new Guid("30f8e945-ef5b-4316-91ba-7cac29399f93"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(458), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("2587c111-02e2-4913-b26b-c165c21e88e2"), new Guid("c50adbc7-70f2-4091-96e7-1252e8409708"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(396), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("54a944fc-7195-460a-acef-be56ab792ab9"), new Guid("825dedb8-ff61-43b1-a747-eeda76999bb2"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(730), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("75e36dc6-5e31-4489-8d39-8542c07cc8ef"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(681), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("b01a3287-4674-4564-ac1c-ae0cb54ecb8d"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(611), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("ce3cb97a-1c63-4bda-976d-c62661e92c7a"), new Guid("a533ed61-e3dd-493d-bfa7-7ed56dc32c21"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(783), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("e6ce12b7-8087-4c87-903a-0e5a9457e37b"), new Guid("3a49b439-f8cc-40ce-819d-e80919b99294"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(263), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("ef30446c-47c8-461e-8b35-1e5b76cd36a5"), new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(138), null, "commenter@gmail.com", true, null, null, null },
                    { new Guid("fa249ca4-2ba0-46c8-9b6b-545ce3c8b946"), new Guid("a160b727-85c4-4e04-a1a7-61aa79d2a674"), "John Doe", "This is a fantastic article!", new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(333), null, "commenter@gmail.com", true, null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ArticleImages",
                columns: new[] { "ArticleImageId", "ArticleId", "_dateModified", "ImageCDNUrl", "IsActive" },
                values: new object[,]
                {
                    { new Guid("0f642929-8edc-43e0-bd60-c49225c16969"), new Guid("a533ed61-e3dd-493d-bfa7-7ed56dc32c21"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(789), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("132fbee6-b78b-4fcc-a9f9-ac5b6af1f381"), new Guid("3a49b439-f8cc-40ce-819d-e80919b99294"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(268), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/construction-worker-is-tying-the-structural-steel-2023-02-09-00-32-24-utc.jpg", true },
                    { new Guid("1910cf77-8d35-49e4-93f7-aae2b543f66a"), new Guid("a160b727-85c4-4e04-a1a7-61aa79d2a674"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(338), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/Eco-Friendly-Building-Materials-15-1024x683.webp?updatedAt=1718460175427", true },
                    { new Guid("39ff4cea-78b2-4ff0-a33d-9233d28d2779"), new Guid("30f8e945-ef5b-4316-91ba-7cac29399f93"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(462), "https://res.cloudinary.com/dkgz8tnno/image/upload/v1713973964/BG-Slider-Conservatories_ppeljm.jpg", true },
                    { new Guid("4087b976-fef0-429c-8c29-b55bad871fbd"), new Guid("825dedb8-ff61-43b1-a747-eeda76999bb2"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(734), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/illumina-estates.jpg", true },
                    { new Guid("a656afd3-b379-4091-b2bc-0dbe9d3c58a9"), new Guid("b452927e-52cf-48c2-9c35-b8751f30a47f"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(169), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_25.png", true },
                    { new Guid("ce553acf-3b7c-4734-9f3f-373c32360a39"), new Guid("c50adbc7-70f2-4091-96e7-1252e8409708"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(405), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Article-Images/northpoint-camella-davao?updatedAt=1718457478612", true },
                    { new Guid("dcf1e9f6-0d85-4ecf-a318-77a7ca1cf02b"), new Guid("89ec82a2-b31c-4bd9-b806-59c7192d6e8a"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(685), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_08.png?updatedAt=1718209420276", true },
                    { new Guid("e8da0ee1-326a-42ae-b00f-433e1c3691b3"), new Guid("cf2c72dd-16b8-4732-b8d2-109393150a6c"), new DateTime(2024, 6, 26, 15, 28, 12, 445, DateTimeKind.Utc).AddTicks(616), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Originals/2024%20LCS_ladon_aboutUs.png?updatedAt=1718209432040", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeatureProjectImages",
                columns: new[] { "FeatureProjectImageId", "_dateModified", "FeatureProjectId", "ImageCDNUrl", "ImageCaption", "IsActive" },
                values: new object[,]
                {
                    { new Guid("043155ca-ab69-493c-8e28-d94086522df7"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7084), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_35.png", "", true },
                    { new Guid("081d76e0-04c7-4745-9367-e24de0ca087a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9508), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-1.png", "", true },
                    { new Guid("08402369-44b9-4fbb-a773-eac8ffb724db"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8285), new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-5.png", "", true },
                    { new Guid("0afdadb9-2ead-4e58-b69d-7ac763fe2abe"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7121), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon_srvc_18.jpg", "", true },
                    { new Guid("0d55638e-7f76-4d23-a23c-2e82660f193e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7729), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-6.png", "", true },
                    { new Guid("0dc2eb9d-bf4c-46d2-ac68-34df51485241"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7492), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-9.png", "", true },
                    { new Guid("1039d2ed-b2e8-4b11-af19-7fcf8c76a90c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7105), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_59.png", "", true },
                    { new Guid("110a2d16-806c-4951-acea-748632f5c7bd"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8047), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-4.png", "", true },
                    { new Guid("13d735fb-13af-4671-b4fe-98701395249e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7470), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-6.png", "", true },
                    { new Guid("15b0e66a-2d6f-4e84-883d-b8e5d04d6211"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6693), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-6.png", "", true },
                    { new Guid("16139106-db69-4793-abb8-d032b0c78d93"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7473), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-8.png", "", true },
                    { new Guid("17587f4b-da00-4669-b522-4829094dac54"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7129), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/portfolio-2.jpg", "", true },
                    { new Guid("17f66b14-6188-4d99-9a2a-3e8173d13ac0"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8564), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-11.png", "", true },
                    { new Guid("1ae4d391-9e1e-4678-82d0-6a99af0cb294"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7514), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-1.png", "", true },
                    { new Guid("1edcd3c3-6b61-48b5-9d0b-077ca651b2db"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7738), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-2.png", "", true },
                    { new Guid("1fd1087a-41af-4423-b476-b367523c5a2b"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9516), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-9.png", "", true },
                    { new Guid("2012db7e-dbe8-42c1-93f8-bb5a8a84a780"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9244), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-6.png", "", true },
                    { new Guid("20ea3481-4fa7-42fd-b1ef-3786d2fd368d"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6714), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-4.png", "", true },
                    { new Guid("21093ec4-02be-4073-8458-cabee8ee65d5"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8288), new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-3.png", "", true },
                    { new Guid("250c5124-9e9a-46b2-8e73-8ec8d106c21f"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7123), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-3.png", "", true },
                    { new Guid("25adaf22-6112-4ef1-9e1c-38cba35aff1f"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8049), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-3.png", "", true },
                    { new Guid("269d8574-f724-4597-adf1-40205b6f960e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9650), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-9.png", "", true },
                    { new Guid("296b3a6f-3eb2-442c-b4c1-9c14e61a4308"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8043), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-7.png", "", true },
                    { new Guid("2a4d2bdd-e955-4ab1-8a3f-64a97a7db112"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9236), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-7.png", "", true },
                    { new Guid("2e71d666-2200-4094-9983-4e363a4e4f10"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7110), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_41.png", "", true },
                    { new Guid("2fb428a2-7579-4103-8d50-5936abed2eb8"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8416), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-7.png", "", true },
                    { new Guid("320ed206-f3e7-4821-b567-b2b4ec406974"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9251), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-1.png", "", true },
                    { new Guid("35b87131-db7c-452b-bfe2-db7d71f640ed"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8140), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-7.jpg", "", true },
                    { new Guid("3720f57e-e318-42d6-ab04-9d9a40de5296"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6718), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-3.png", "", true },
                    { new Guid("3d92c5ca-0b13-428e-98e2-ae036bb87405"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8805), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-9.png", "", true },
                    { new Guid("3e5bd12f-4433-4eb2-a486-61d055afd923"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7740), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-4.png", "", true },
                    { new Guid("3f77f1dd-b695-4f09-8dfe-48a353085534"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8403), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-4.png", "", true },
                    { new Guid("400bd88a-ba7e-45eb-b481-ca95f0537021"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8579), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-10.png", "", true },
                    { new Guid("4029a8a1-4c40-4446-8035-501e049a31cb"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8786), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-3.png", "", true },
                    { new Guid("4116701f-ef6c-43bc-80fd-e815754789ef"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7108), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_44.png", "", true },
                    { new Guid("43222bd4-ed05-4e7a-8130-34878cc7922a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7537), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_29.png", "", true },
                    { new Guid("4a7497ee-676b-4699-96e1-6b18d5d0f177"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8783), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-8.png", "", true },
                    { new Guid("4d38f18e-d99f-4914-8118-9fbb4e1353ff"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9656), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-3.png", "", true },
                    { new Guid("501a5cb3-af40-485d-8d41-4df0e72970c3"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8417), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-6.png", "", true },
                    { new Guid("51e6e78b-4aa1-4b0d-8e27-9f9151bf394b"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7100), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-1.png", "", true },
                    { new Guid("52c0387a-c7b6-4c74-86ee-308519b845d0"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8810), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-4.png", "", true },
                    { new Guid("52f52093-4e75-4238-ab6b-079226193582"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9518), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-3.png", "", true },
                    { new Guid("55a117a2-238d-4dda-992b-b8f18f1cba05"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8141), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-8.jpg", "", true },
                    { new Guid("55fa059f-be9c-4727-86f0-ac67349787c6"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8038), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-2.png", "", true },
                    { new Guid("58ec79b1-e9e2-4acc-96ca-b5ebf190a4bb"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9830), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-5.png", "", true },
                    { new Guid("59510a83-b191-48b8-936e-7ff65155291a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8041), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-5.png", "", true },
                    { new Guid("5da1735d-f5c3-4c9f-bf68-81e68e23a8f0"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9213), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-5.png", "", true },
                    { new Guid("5e7a10d7-b665-4b34-8aae-96dd5a65666a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8802), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-5.png", "", true },
                    { new Guid("6494ef8d-0479-4356-98dd-8605cc68d362"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8799), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-6.png", "", true },
                    { new Guid("6dae1269-0ab8-4c11-bd00-5b0c658279e8"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7719), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-fire-1.png", "", true },
                    { new Guid("7088178e-d696-405f-9eba-2b6927c6bcad"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8143), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-2.png", "", true },
                    { new Guid("73299cca-02ca-43f6-a672-be3bdfbc5f89"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8145), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-3.png", "", true },
                    { new Guid("74ee3618-ae6f-4bf4-b8b3-b412973ed730"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9227), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-3.png", "", true },
                    { new Guid("75df84b7-0609-4ba5-974b-3a9335ed087e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9649), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-7.png", "", true },
                    { new Guid("791840a1-30a7-47e9-9aec-44d6f2e14ede"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9247), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-0.png", "", true },
                    { new Guid("796221ea-1ddd-4ded-bbdc-e818b7ce108e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7113), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_36.png", "", true },
                    { new Guid("7a220b2b-ecf2-494c-aa73-7e75bdb2f9c4"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8136), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-5.png", "", true },
                    { new Guid("7a82ce34-d94c-43b1-bac5-d54a32ef91f0"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7507), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-3.png", "", true },
                    { new Guid("7e76f4e0-1212-41c3-8ade-74630a136504"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9820), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-10.png", "", true },
                    { new Guid("7e9c589d-fb2c-4a47-8ede-0da8729fb42e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9658), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-4.png", "", true },
                    { new Guid("8245384e-4496-48bc-ba89-f5a4daeb64f0"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9529), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-7.png", "", true },
                    { new Guid("83097543-5d6f-4499-a3a2-36016b63c03d"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7090), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_40.png", "", true },
                    { new Guid("86f1ee4f-16b7-448c-a09f-4caf267d650e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6672), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-5.png", "", true },
                    { new Guid("88553a51-be44-4d22-b763-4471ace0cf6b"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8283), new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-4.png", "", true },
                    { new Guid("8891e1b6-01e0-4d48-bae9-386cfce29896"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7126), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-4.png", "", true },
                    { new Guid("88c70609-f9e1-4a82-85e9-885971c8e0b9"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8419), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-9.png", "", true },
                    { new Guid("89684539-fbef-4dbd-b920-80196ea23d91"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9514), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-6.png", "", true },
                    { new Guid("8b2a8c41-41e4-45a6-8111-41c6b4dad004"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9818), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-12.png", "", true },
                    { new Guid("8dba1947-ce58-4233-b3c4-79ec16119d8c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8149), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-4.png", "", true },
                    { new Guid("8e7b9674-591c-4bd1-843d-8674617fc0bd"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8292), new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-6.png", "", true },
                    { new Guid("90400f33-018c-46cd-969f-67f3703452c8"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9526), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-5.png", "", true },
                    { new Guid("91cfa605-b78e-4790-baea-790769d2b14a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9240), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-8.png", "", true },
                    { new Guid("94c705cb-328a-441d-ba0b-52aeacedd442"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8407), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-3.png", "", true },
                    { new Guid("969c24d1-a1ec-441a-afcb-29ffc2bda482"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7728), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-7.png", "", true },
                    { new Guid("97a6e279-c5ff-4a0b-93db-5e05b0539deb"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7950), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-1.png", "", true },
                    { new Guid("9afaabf9-b11e-4ded-aa45-9bafe9e4183e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7485), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-2.png", "", true },
                    { new Guid("9b8c28c4-9355-4af5-9ddc-6240c670504d"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9647), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-8.png", "", true },
                    { new Guid("9cae1b67-8dc9-47d6-ae02-dbe1b15fa4e9"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8560), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-6.png", "", true },
                    { new Guid("a049071d-bbd9-4f4b-90c6-4a92196854de"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8571), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-15.png", "", true },
                    { new Guid("a1f0f306-787e-493f-bfc4-243e411f94ea"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8766), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-2.jpg", "", true },
                    { new Guid("a3e17d0f-de13-452f-8c78-9b9e572e4c96"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7500), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-4.png", "", true },
                    { new Guid("a56bd851-1f7a-4da5-b9e3-61426c134f02"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9527), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-10.png", "", true },
                    { new Guid("a6fffa96-61c2-4937-847f-5f2a0e4a279c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7097), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/ladon-wkfrc-2.png", "", true },
                    { new Guid("a7593e85-9ad1-4836-8522-2ad950a7182a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9817), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-6.png", "", true },
                    { new Guid("a81f303e-3c0c-4a04-a55a-f9ea29c80148"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8568), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-5.png", "", true },
                    { new Guid("a821755d-36e0-4263-83b9-9ad9edc0fc60"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9659), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-6.png", "", true },
                    { new Guid("a87dac70-5b41-41a8-9516-4798dc332e4c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9519), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-4.png", "", true },
                    { new Guid("a8c60ae8-ab42-40d4-b39c-23c753c1f350"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8792), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-7.png", "", true },
                    { new Guid("a9129695-36be-4442-ae22-39dc72e6a95e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8789), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-10.png", "", true },
                    { new Guid("a920cea7-26a3-493a-ba5b-4d6cfc65383a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9821), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-11.png", "", true },
                    { new Guid("aa896afb-ba4d-4037-a5e9-52d410ddfcd5"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7116), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_58.png", "", true },
                    { new Guid("aad0fe86-b3a6-4f36-a8db-28eb828e2dea"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9654), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-5.png", "", true },
                    { new Guid("b0587960-e496-4f3f-bfc2-330f927f654c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8401), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-1.png", "", true },
                    { new Guid("b072434a-7167-4173-af07-28b4fd646262"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6982), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_aboutUs.png", "", true },
                    { new Guid("b09cdba8-dc04-4440-b229-8a00dc55794c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6690), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-1.png", "", true },
                    { new Guid("b491fd60-057a-43bf-90ba-38ab6c15ef68"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9513), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-8.png", "", true },
                    { new Guid("b4df98d4-5582-4fd1-b237-c517a6b0c342"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8572), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-13.png", "", true },
                    { new Guid("b70f23b5-6e53-4e9a-8e93-5160868800b0"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9812), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-1.png", "", true },
                    { new Guid("b8760c63-992e-4bc0-984d-9ea9139aea24"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6696), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-7.png", "", true },
                    { new Guid("ba405fa6-bfe7-4e84-8c0d-e1f656c17c2f"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8808), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-11.png", "", true },
                    { new Guid("bd62150c-445f-4a7b-8793-544231dee628"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6721), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-office-1.png", "", true },
                    { new Guid("bdefe961-2cf2-4c76-ade3-e45c341972b5"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6699), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-gov-certs.png", "", true },
                    { new Guid("bfc7f1b1-3243-4e0b-8c79-0babf934cc46"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9815), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-3.png", "", true },
                    { new Guid("bfe2d579-53f1-4dbe-8158-4e51a38fe708"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8405), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-2.png", "", true },
                    { new Guid("c3d04a42-0d7c-4b72-9999-926b17eaedf8"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9827), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-4.png", "", true },
                    { new Guid("c40ef275-4fa9-4489-9c87-f6498cda643f"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7726), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-1.png", "", true },
                    { new Guid("c4c97fde-e036-4f96-bb83-2e07599fc20a"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8780), new Guid("6612ef93-a38d-42c8-9674-f1683062af46"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-laguna/ladon-ldslaguna-1.jpg", "", true },
                    { new Guid("c54218bc-2e81-47fc-a6a4-da37c6b11719"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8555), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-4.png", "", true },
                    { new Guid("c54a58d1-da70-4d76-8198-907bd6cf8bd8"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8150), new Guid("e4eb825c-e93d-45ab-8c32-e8cc9084b1c0"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-sasa/ladon-sasa-6.jpg", "", true },
                    { new Guid("c55cfefb-ba6d-4b21-a1ff-39d4f9cb32ba"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8558), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-12.png", "", true },
                    { new Guid("c732824a-d9e7-4724-b366-ff32934452da"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7103), new Guid("372f7859-e9b7-4ccb-a520-bcba3656796e"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-workforce/2024%20LCS_ladon_39.png", "", true },
                    { new Guid("c8770673-08ab-41ed-9a92-cc70f96da61c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9644), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-2.png", "", true },
                    { new Guid("ca3b26c9-b8c8-4989-ad9f-d940f6c9e40b"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8569), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-14.png", "", true },
                    { new Guid("ca950772-58f1-471d-a722-70c8b09c342e"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7462), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-7.png", "", true },
                    { new Guid("cb08543e-9c06-46b0-85ec-2c5f6a15d353"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9661), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-1.png", "", true },
                    { new Guid("cc27a4c5-20f3-4bcf-a505-7e88b8ec457f"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8281), new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-1.png", "", true },
                    { new Guid("ce89a1f2-54f3-44af-963b-d527a0bde406"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9806), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-2.png", "", true },
                    { new Guid("d0039465-e230-4540-ba1f-4cca54bcd0b1"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8410), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/2024%20LCS_ladon_17.png", "", true },
                    { new Guid("d06bcd8b-884a-4df2-8a40-6a3e95c9ac18"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7731), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-3.png", "", true },
                    { new Guid("d46287e9-f028-4319-ab0f-2465d0f46262"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9252), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-2.png", "", true },
                    { new Guid("d4a09583-b07d-4550-8f78-eda85e3bdd5d"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9813), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-9.png", "", true },
                    { new Guid("d4ce02f3-2565-4774-8bf5-4eee1a92c442"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8040), new Guid("8e273190-ac7b-4b07-aaf4-9a666e6fb16a"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-carmen/ladon-carmen-6.jpg", "", true },
                    { new Guid("d7338d37-c99c-4c8c-ac1b-43292efefda3"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8414), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-8.png", "", true },
                    { new Guid("d85dd78c-ef36-4878-81c8-e3b9daf022e4"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8287), new Guid("6674068c-dce7-4c72-808b-25f0f8baa55b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-inasal-lingayen/ladon-inasal-lingayen-2.png", "", true },
                    { new Guid("ddab159a-82de-480e-9edf-3f10d904a336"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9828), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-7.png", "", true },
                    { new Guid("de1991d8-0f02-405c-a185-c2d194135aaf"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7724), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-pbax-1.png", "", true },
                    { new Guid("e09f130c-92b0-4ee0-b15f-d4fb74a966a7"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9823), new Guid("f82a7337-3ccd-4530-a217-aad23c1a597b"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-lds-talavera/ladon-lds-talavera-8.png", "", true },
                    { new Guid("e487abb9-e93b-4a14-8097-e2c3410c5ae5"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8566), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-1.png", "", true },
                    { new Guid("e5832f96-cfb9-41f4-b01f-1909bbf2cabe"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8574), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-7.png", "", true },
                    { new Guid("e9d230d0-71d4-4b6f-9cf1-4f3feb66a3cd"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8408), new Guid("f8bf4367-00a2-482d-92de-d9793ea94eb8"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds-muntinlupa-lift/ladon-ldslift-5.png", "", true },
                    { new Guid("ec77afa1-2cb1-4454-b5b2-9523ea6ddfdb"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9521), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-11.png", "", true },
                    { new Guid("edee50db-f91d-4aed-85eb-518c307648d4"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9663), new Guid("a6402afc-af71-4728-a0d5-553f857e97fb"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-guimba-nueva-ecija-retaining-wall/ladon-guimba-10.png", "", true },
                    { new Guid("efe8b0cf-c91a-49f9-b871-5e48408b7755"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9242), new Guid("e2611328-1a8f-4f2e-a1cc-1322432057bd"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-aringay/ladon-aringay-4.png", "", true },
                    { new Guid("f29c97c6-269b-4a92-a1d4-f7d4bd652dcf"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(6724), new Guid("20ca30e8-3cfb-4201-b9e1-0e251878540f"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-hq/ladon-hq-10.png", "", true },
                    { new Guid("f497fce7-e64a-49b9-89eb-8dc04c4ff0f3"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7534), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/ladon-church-5.png", "", true },
                    { new Guid("fa974670-50e9-4f07-85f8-1eea80fc51d5"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(8576), new Guid("195907d7-ad92-401d-9ab0-8592c14db3b1"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-verdon/ladon-verdon-8.png", "", true },
                    { new Guid("fb2c81a2-4cc8-4f3e-b68d-6927d2556bd1"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7540), new Guid("568baa32-e39b-4a89-8471-e9e756c01623"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-lds--church/2024%20LCS_ladon_12.png", "", true },
                    { new Guid("fdf99486-827f-4999-82c4-5eb4be0660af"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(9511), new Guid("cb811838-c59f-4ac3-84e5-4f44e6446489"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/lds-gen-milling/ladon-gen-milling-2.png", "", true },
                    { new Guid("ff91b936-2f22-4a01-84a3-90a79252ca8c"), new DateTime(2024, 6, 26, 15, 28, 12, 446, DateTimeKind.Utc).AddTicks(7733), new Guid("706d9a14-022e-4af3-a128-a2c6fa348f47"), "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Feature-Projects/ladon-umlibrary-fire-protection-pbax-paging-systems-project/ladon-umlib-5.png", "", true }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5134c0a2-eb7f-4876-93a9-50a9ce3a0fe2"), new Guid("9f1c3055-d4e8-419c-921b-9cc46f346952") },
                    { new Guid("393c86c1-e0fc-4635-833a-feefd300f78d"), new Guid("c23a1a42-e73e-4ff5-ac85-50a9b7f54274") }
                });
        }
    }
}
