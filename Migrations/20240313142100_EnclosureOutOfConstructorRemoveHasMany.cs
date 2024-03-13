using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureOutOfConstructorRemoveHasMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5801), new DateTime(2017, 10, 7, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5800), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5783), new DateTime(2017, 5, 5, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5782), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5766), new DateTime(2022, 1, 12, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5749), new DateTime(2018, 2, 7, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5748), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5732), new DateTime(2016, 5, 14, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5730), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5714), new DateTime(2016, 2, 14, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5712), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5697), new DateTime(2023, 8, 20, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5695), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5679), new DateTime(2021, 10, 7, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5662), new DateTime(2023, 2, 28, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5661), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5644), new DateTime(2019, 1, 23, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5642), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5570), new DateTime(2018, 9, 2, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5568), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5553), new DateTime(2022, 12, 8, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5551), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5535), new DateTime(2022, 8, 18, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5534), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5518), new DateTime(2016, 11, 2, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5516), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5500), new DateTime(2021, 12, 29, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5499), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5482), new DateTime(2016, 1, 27, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5481), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5465), new DateTime(2016, 8, 11, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5447), new DateTime(2018, 7, 30, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5446), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5429), new DateTime(2022, 6, 24, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5428), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5411), new DateTime(2021, 9, 11, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5409), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5379), new DateTime(2016, 12, 26, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5377), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5361), new DateTime(2022, 11, 8, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5360), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5343), new DateTime(2017, 11, 19, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5342), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5326), new DateTime(2020, 11, 14, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5324), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5309), new DateTime(2020, 7, 1, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5307), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5291), new DateTime(2018, 9, 4, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5290), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5274), new DateTime(2016, 7, 30, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5272), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5256), new DateTime(2019, 10, 8, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5255), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5238), new DateTime(2022, 10, 26, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5236), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5219), new DateTime(2022, 12, 29, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5218), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5182), new DateTime(2020, 4, 18, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5181), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5122), new DateTime(2016, 5, 14, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5121), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5105), new DateTime(2017, 2, 19, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5103), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5087), new DateTime(2023, 11, 28, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5086), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5070), new DateTime(2021, 4, 10, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5068), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5052), new DateTime(2019, 7, 8, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(5051), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5034), new DateTime(2021, 1, 21, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5032), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5015), new DateTime(2016, 12, 15, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(5013), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4997), new DateTime(2017, 4, 5, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4996), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 3, 3, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4978), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4949), new DateTime(2022, 12, 24, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4948), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4932), new DateTime(2019, 8, 4, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4931), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4914), new DateTime(2019, 6, 23, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4913), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4897), new DateTime(2020, 2, 8, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4896), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4880), new DateTime(2022, 2, 2, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4879), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4863), new DateTime(2017, 1, 19, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4862), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 10, 29, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4842), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4826), new DateTime(2023, 2, 27, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4825), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4808), new DateTime(2021, 10, 16, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4806), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4789), new DateTime(2021, 5, 20, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4787), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4715), new DateTime(2023, 11, 18, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4713), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4697), new DateTime(2020, 11, 12, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4696), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4679), new DateTime(2020, 7, 27, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4662), new DateTime(2023, 1, 17, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4661), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4645), new DateTime(2020, 6, 23, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4627), new DateTime(2023, 5, 12, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4626), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4610), new DateTime(2020, 4, 2, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4609), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4592), new DateTime(2023, 2, 6, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4591), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4574), new DateTime(2022, 7, 11, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4573), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4556), new DateTime(2019, 8, 4, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4554), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4524), new DateTime(2023, 2, 23, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4522), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4506), new DateTime(2019, 3, 25, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4505), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4484), new DateTime(2019, 10, 26, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4466), new DateTime(2018, 8, 29, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4465), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4448), new DateTime(2018, 2, 24, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4447), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4431), new DateTime(2020, 1, 30, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4429), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4413), new DateTime(2021, 7, 13, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4411), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4396), new DateTime(2021, 4, 30, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4394), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4378), new DateTime(2018, 6, 26, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4377), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4358), new DateTime(2016, 2, 1, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4356), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4265), new DateTime(2023, 2, 1, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4264), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4247), new DateTime(2023, 8, 16, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4246), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4230), new DateTime(2017, 9, 7, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4229), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4213), new DateTime(2023, 8, 22, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4211), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4195), new DateTime(2024, 2, 6, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4194), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4178), new DateTime(2021, 2, 9, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4176), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4160), new DateTime(2022, 11, 24, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4159), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4143), new DateTime(2018, 11, 16, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4141), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4125), new DateTime(2020, 1, 30, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4124), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4108), new DateTime(2020, 2, 16, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4106), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4077), new DateTime(2021, 9, 30, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4075), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4060), new DateTime(2020, 3, 22, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4059), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4043), new DateTime(2023, 9, 6, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(4041), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4025), new DateTime(2023, 1, 26, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4024), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4003), new DateTime(2024, 1, 17, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(4002), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3979), new DateTime(2022, 12, 22, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3978), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3962), new DateTime(2020, 12, 24, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3960), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3944), new DateTime(2018, 2, 24, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3943), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3927), new DateTime(2022, 6, 18, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3909), new DateTime(2016, 9, 17, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3874), new DateTime(2019, 10, 2, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3873), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3802), new DateTime(2021, 6, 4, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3800), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3785), new DateTime(2017, 10, 30, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3783), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3766), new DateTime(2018, 2, 24, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3764), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3748), new DateTime(2022, 11, 26, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3747), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3732), new DateTime(2017, 1, 1, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3730), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3714), new DateTime(2023, 5, 18, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3713), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3695), new DateTime(2020, 3, 26, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3694), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3678), new DateTime(2016, 6, 27, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3676), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 20, 59, 760, DateTimeKind.Utc).AddTicks(3653), new DateTime(2020, 5, 24, 13, 20, 59, 760, DateTimeKind.Utc).AddTicks(3643), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -10,
                column: "Classification",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -9,
                column: "Classification",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -8,
                column: "Classification",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -7,
                column: "Classification",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -6,
                column: "Classification",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4,
                column: "Classification",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2167), new DateTime(2022, 9, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2166), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2150), new DateTime(2017, 2, 22, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2149), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2132), new DateTime(2021, 4, 22, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2113), new DateTime(2019, 12, 3, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2111), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2034), new DateTime(2021, 5, 22, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2033), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2016), new DateTime(2017, 8, 6, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2015), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1999), new DateTime(2017, 10, 28, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1997), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1981), new DateTime(2023, 11, 12, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1964), new DateTime(2023, 9, 18, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1962), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1946), new DateTime(2017, 8, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1944), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1913), new DateTime(2021, 7, 17, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1912), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1895), new DateTime(2020, 5, 9, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1894), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1878), new DateTime(2016, 4, 9, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1877), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1860), new DateTime(2019, 9, 29, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1859), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1843), new DateTime(2019, 2, 6, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1842), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1826), new DateTime(2023, 12, 4, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1825), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1809), new DateTime(2017, 12, 18, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1791), new DateTime(2018, 12, 23, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1790), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1774), new DateTime(2021, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1772), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1756), new DateTime(2019, 6, 29, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1754), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1715), new DateTime(2020, 7, 10, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1713), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1696), new DateTime(2020, 5, 18, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1695), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1679), new DateTime(2020, 1, 24, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1678), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1660), new DateTime(2022, 9, 12, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1659), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1641), new DateTime(2017, 7, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1638), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1539), new DateTime(2022, 10, 17, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1537), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1519), new DateTime(2018, 10, 29, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1518), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1501), new DateTime(2019, 4, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1500), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1484), new DateTime(2018, 10, 21, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1483), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1466), new DateTime(2023, 11, 9, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1465), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1432), new DateTime(2019, 6, 26, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1431), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1414), new DateTime(2021, 2, 2, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1413), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1396), new DateTime(2017, 8, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1392), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1183), new DateTime(2023, 12, 8, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1182), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1165), new DateTime(2022, 6, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1163), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1146), new DateTime(2018, 5, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1144), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1125), new DateTime(2019, 10, 9, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1123), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(960), new DateTime(2021, 5, 4, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(959), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(939), new DateTime(2020, 6, 19, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(938), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(920), new DateTime(2018, 8, 12, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(918), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(880), new DateTime(2020, 4, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(879), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(860), new DateTime(2017, 1, 29, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(858), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(753), new DateTime(2021, 3, 26, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(751), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(734), new DateTime(2017, 3, 22, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(732), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(714), new DateTime(2019, 7, 16, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(712), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(695), new DateTime(2022, 2, 8, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(693), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(675), new DateTime(2022, 1, 20, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(674), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(655), new DateTime(2023, 8, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(654), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(635), new DateTime(2018, 4, 15, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(634), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(614), new DateTime(2016, 5, 28, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(613), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(576), new DateTime(2016, 8, 26, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(575), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(557), new DateTime(2019, 1, 9, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(556), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(538), new DateTime(2021, 2, 7, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(518), new DateTime(2021, 12, 2, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(517), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(280), new DateTime(2023, 5, 18, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(261), new DateTime(2021, 7, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(260), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(241), new DateTime(2020, 8, 25, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(239), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(221), new DateTime(2021, 11, 11, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(219), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(201), new DateTime(2018, 7, 13, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(200), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(182), new DateTime(2018, 6, 17, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(180), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(136), new DateTime(2020, 7, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(133), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9913), new DateTime(2019, 2, 24, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9912), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9896), new DateTime(2017, 5, 21, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9875), new DateTime(2023, 1, 5, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9873), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9807), new DateTime(2022, 9, 21, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9806), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9789), new DateTime(2018, 5, 10, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9787), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9770), new DateTime(2017, 9, 2, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9769), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9751), new DateTime(2017, 4, 22, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9750), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9731), new DateTime(2020, 12, 26, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9730), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9568), new DateTime(2019, 8, 27, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9567), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 5, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9529), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9511), new DateTime(2017, 3, 31, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9510), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9492), new DateTime(2022, 7, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9491), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9472), new DateTime(2019, 10, 13, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9471), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9453), new DateTime(2022, 10, 5, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9451), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9433), new DateTime(2019, 11, 11, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9432), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9413), new DateTime(2018, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9412), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9394), new DateTime(2021, 3, 6, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9393), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 6, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9373), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9354), new DateTime(2016, 10, 17, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9353), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9317), new DateTime(2019, 3, 19, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9316), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9150), new DateTime(2022, 9, 4, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9148), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9129), new DateTime(2018, 8, 15, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9128), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9104), new DateTime(2023, 3, 29, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9102), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8811), new DateTime(2021, 3, 8, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8810), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8789), new DateTime(2019, 4, 13, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8787), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8768), new DateTime(2023, 8, 18, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8766), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8571), new DateTime(2023, 8, 14, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8569), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8550), new DateTime(2022, 4, 8, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8528), new DateTime(2021, 6, 9, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8478), new DateTime(2020, 10, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8476), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8457), new DateTime(2022, 2, 8, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8455), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8436), new DateTime(2019, 5, 30, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8434), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8404), new DateTime(2019, 5, 31, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8398), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8288), new DateTime(2018, 9, 19, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8278), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7971), new DateTime(2020, 6, 24, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(7955), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7738), new DateTime(2023, 5, 25, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(7736), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7712), new DateTime(2021, 11, 8, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7711), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7694), new DateTime(2022, 11, 20, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7692), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7640), new DateTime(2016, 10, 21, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(7624), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -10,
                column: "Classification",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -9,
                column: "Classification",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -8,
                column: "Classification",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -7,
                column: "Classification",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -6,
                column: "Classification",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4,
                column: "Classification",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 3);
        }
    }
}
