using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FeatureProjectImageFieldRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ImageSizeOrientationStyle",
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
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 824, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 905, DateTimeKind.Local).AddTicks(8196),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 839, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 906, DateTimeKind.Local).AddTicks(9140),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 840, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(4335),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(7031),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(1176),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(7554),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 842, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(1671),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(4764),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(437),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(4764),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(4468),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(3221));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "ImageSizeOrientationStyle");

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "UserProfiles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 824, DateTimeKind.Local).AddTicks(1514),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 890, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Subscribers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 839, DateTimeKind.Local).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 905, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequests",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 840, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 906, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuoteRequestAttachments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(1873),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "QuestionAnswers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(4598),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 907, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Messages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(296),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjects",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 841, DateTimeKind.Local).AddTicks(8378),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "FeatureProjectImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 842, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 908, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ClientTestimonies",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(1554),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Articles",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 826, DateTimeKind.Local).AddTicks(4904),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 892, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleMetrics",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleImages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(7642),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleComments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 838, DateTimeKind.Local).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 904, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "ArticleCategories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 837, DateTimeKind.Local).AddTicks(4491),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 903, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "_dateCreated",
                schema: "dbo",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 23, 2, 43, 825, DateTimeKind.Local).AddTicks(3221),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2024, 7, 4, 13, 21, 13, 891, DateTimeKind.Local).AddTicks(4468));

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
    }
}
