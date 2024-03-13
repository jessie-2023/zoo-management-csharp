using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(685), new DateTime(2021, 11, 10, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(684), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(665), new DateTime(2017, 9, 19, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(664), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(645), new DateTime(2016, 12, 17, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(643), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(625), new DateTime(2023, 4, 26, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(623), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(606), new DateTime(2022, 3, 16, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(604), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(584), new DateTime(2020, 7, 19, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(564), new DateTime(2016, 4, 2, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(563), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(545), new DateTime(2022, 10, 30, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(543), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(525), new DateTime(2023, 1, 16, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(524), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(505), new DateTime(2018, 3, 7, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(503), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(465), new DateTime(2016, 4, 20, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(463), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(398), new DateTime(2016, 11, 3, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(396), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(378), new DateTime(2020, 11, 14, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(376), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(358), new DateTime(2018, 11, 21, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(356), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(333), new DateTime(2022, 1, 2, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(331), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(310), new DateTime(2019, 3, 11, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(308), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(290), new DateTime(2022, 12, 29, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(288), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(271), new DateTime(2022, 7, 30, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(269), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(250), new DateTime(2016, 8, 19, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(249), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(230), new DateTime(2018, 11, 9, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(228), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(192), new DateTime(2021, 6, 15, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(190), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(171), new DateTime(2023, 3, 12, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(170), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(151), new DateTime(2022, 4, 21, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(150), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(131), new DateTime(2023, 11, 10, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(129), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(111), new DateTime(2019, 1, 27, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(109), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(90), new DateTime(2016, 6, 10, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(89), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(69), new DateTime(2016, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(67), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(49), new DateTime(2020, 5, 26, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(47), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 11, 6, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(26), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(5), new DateTime(2018, 3, 14, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(4), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 2, 21, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9962), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9942), new DateTime(2020, 8, 11, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9940), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 2, 22, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9872), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9853), new DateTime(2019, 12, 9, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9851), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9833), new DateTime(2023, 12, 30, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9831), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9813), new DateTime(2018, 11, 26, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9811), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9792), new DateTime(2017, 2, 20, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9791), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9769), new DateTime(2017, 3, 14, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9768), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9749), new DateTime(2017, 8, 11, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9747), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9728), new DateTime(2022, 8, 30, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9727), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9692), new DateTime(2023, 1, 1, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9690), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9672), new DateTime(2022, 4, 15, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9670), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9651), new DateTime(2018, 12, 1, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9649), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9630), new DateTime(2021, 5, 20, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9629), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 4, 22, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9608), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9590), new DateTime(2020, 2, 4, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9588), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9570), new DateTime(2021, 11, 17, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9568), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9550), new DateTime(2016, 10, 4, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9548), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9529), new DateTime(2022, 10, 16, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9528), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9508), new DateTime(2019, 12, 7, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9506), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9464), new DateTime(2018, 5, 18, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9462), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9312), new DateTime(2020, 6, 21, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9310), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9291), new DateTime(2021, 5, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9290), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9270), new DateTime(2017, 1, 1, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9269), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9250), new DateTime(2016, 3, 16, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9248), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9230), new DateTime(2019, 5, 19, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9228), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 12, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9208), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9189), new DateTime(2019, 1, 22, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9187), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9168), new DateTime(2022, 10, 17, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9167), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9147), new DateTime(2022, 1, 6, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9146), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9109), new DateTime(2016, 3, 23, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9108), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9089), new DateTime(2017, 5, 8, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9088), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9069), new DateTime(2022, 6, 13, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9067), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9048), new DateTime(2022, 6, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9046), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8878), new DateTime(2022, 10, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8876), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8857), new DateTime(2019, 8, 4, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8856), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8836), new DateTime(2023, 1, 4, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8834), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8815), new DateTime(2022, 2, 7, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8637), new DateTime(2018, 9, 23, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8636), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8615), new DateTime(2020, 5, 1, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8613), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8509), new DateTime(2022, 5, 12, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8508), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8489), new DateTime(2022, 4, 13, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8488), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8469), new DateTime(2020, 2, 24, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8467), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8448), new DateTime(2016, 4, 24, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8447), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8428), new DateTime(2021, 9, 6, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8426), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8408), new DateTime(2023, 1, 16, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8406), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8388), new DateTime(2019, 1, 11, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8386), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8368), new DateTime(2017, 7, 19, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8366), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8348), new DateTime(2016, 6, 23, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8346), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8327), new DateTime(2021, 5, 24, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8326), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8290), new DateTime(2019, 6, 17, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8289), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8270), new DateTime(2022, 5, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8268), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8250), new DateTime(2019, 12, 6, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8248), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8230), new DateTime(2020, 2, 14, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8228), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8209), new DateTime(2021, 6, 12, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8207), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8186), new DateTime(2021, 10, 8, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8185), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 6, 15, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8165), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8148), new DateTime(2021, 2, 28, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8146), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8127), new DateTime(2019, 5, 25, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8126), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8108), new DateTime(2018, 4, 8, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8106), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8069), new DateTime(2021, 3, 14, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8067), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7982), new DateTime(2017, 12, 12, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7960), new DateTime(2016, 8, 6, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7959), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7939), new DateTime(2018, 9, 7, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7937), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7919), new DateTime(2021, 7, 14, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7917), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7898), new DateTime(2019, 11, 7, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7896), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7876), new DateTime(2017, 4, 24, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7874), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7848), new DateTime(2021, 6, 6, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7847), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7827), new DateTime(2019, 6, 21, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7795), new DateTime(2021, 7, 29, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7778), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -10,
                column: "Classification",
                value: 2);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -7,
                column: "Classification",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -6,
                column: "Classification",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -5,
                column: "Classification",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4,
                column: "Classification",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3,
                column: "Classification",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(126), new DateTime(2021, 11, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(124), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(105), new DateTime(2020, 10, 12, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(104), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(85), new DateTime(2021, 10, 9, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(83), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(65), new DateTime(2020, 9, 18, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(64), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(45), new DateTime(2020, 5, 10, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(43), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(24), new DateTime(2022, 3, 4, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(4), new DateTime(2020, 10, 19, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(3), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9984), new DateTime(2020, 9, 22, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9982), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9964), new DateTime(2022, 11, 22, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9962), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9943), new DateTime(2016, 1, 23, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9941), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9905), new DateTime(2022, 12, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9904), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9885), new DateTime(2022, 10, 10, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9884), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9865), new DateTime(2022, 2, 2, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9863), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9776), new DateTime(2019, 10, 23, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9775), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9755), new DateTime(2022, 8, 24, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9754), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9735), new DateTime(2019, 10, 4, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9734), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9714), new DateTime(2022, 2, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9713), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9694), new DateTime(2016, 9, 28, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9692), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9674), new DateTime(2015, 12, 27, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9673), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9654), new DateTime(2020, 8, 13, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9652), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9611), new DateTime(2017, 6, 15, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9610), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9591), new DateTime(2017, 2, 14, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9590), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9571), new DateTime(2022, 5, 14, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9569), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 10, 10, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9550), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9531), new DateTime(2016, 3, 5, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9530), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9511), new DateTime(2024, 2, 1, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9510), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9491), new DateTime(2019, 6, 8, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9489), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9471), new DateTime(2020, 12, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9470), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9451), new DateTime(2019, 7, 20, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9450), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9430), new DateTime(2019, 9, 20, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9428), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9385), new DateTime(2023, 1, 17, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9384), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9365), new DateTime(2018, 6, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9363), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 9, 12, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9343), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9324), new DateTime(2022, 3, 13, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9322), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9146), new DateTime(2023, 10, 18, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9144), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9125), new DateTime(2017, 6, 16, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9124), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9105), new DateTime(2022, 10, 15, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9103), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9080), new DateTime(2020, 10, 6, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9078), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9059), new DateTime(2023, 7, 9, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9057), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9037), new DateTime(2019, 6, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9035), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8989), new DateTime(2016, 10, 8, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8988), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8968), new DateTime(2017, 3, 15, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8967), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8948), new DateTime(2022, 10, 9, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8947), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8926), new DateTime(2016, 8, 30, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8924), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8888), new DateTime(2017, 5, 26, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8878), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8783), new DateTime(2020, 5, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8781), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8735), new DateTime(2022, 11, 14, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8732), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8658), new DateTime(2018, 5, 21, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8648), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8597), new DateTime(2021, 12, 13, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8594), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8570), new DateTime(2019, 4, 24, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8568), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8532), new DateTime(2016, 1, 13, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8530), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8511), new DateTime(2018, 6, 28, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8510), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8489), new DateTime(2018, 3, 23, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8487), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8421), new DateTime(2022, 10, 8, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8420), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8400), new DateTime(2018, 6, 29, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8399), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8380), new DateTime(2018, 11, 25, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8379), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8360), new DateTime(2018, 4, 26, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8359), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8340), new DateTime(2019, 9, 15, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8339), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8320), new DateTime(2017, 1, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8319), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8299), new DateTime(2022, 4, 24, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8298), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8257), new DateTime(2023, 12, 14, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8256), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8237), new DateTime(2019, 3, 24, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8236), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8218), new DateTime(2023, 1, 17, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8216), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8197), new DateTime(2021, 9, 25, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8195), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8176), new DateTime(2021, 12, 11, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8175), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8156), new DateTime(2020, 4, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8155), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8136), new DateTime(2018, 12, 2, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8134), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8115), new DateTime(2022, 5, 26, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8093), new DateTime(2020, 8, 16, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8092), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8070), new DateTime(2024, 1, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8068), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8032), new DateTime(2021, 12, 7, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8030), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8011), new DateTime(2020, 3, 2, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8010), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7989), new DateTime(2023, 7, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7988), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7915), new DateTime(2019, 9, 20, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7913), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7895), new DateTime(2019, 10, 14, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7893), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7874), new DateTime(2016, 4, 25, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7873), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7853), new DateTime(2018, 7, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7852), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7833), new DateTime(2020, 7, 21, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7832), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7814), new DateTime(2022, 3, 24, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7813), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7793), new DateTime(2023, 10, 22, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7791), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7755), new DateTime(2019, 3, 30, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7753), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7734), new DateTime(2018, 4, 23, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7733), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7714), new DateTime(2020, 6, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7712), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7694), new DateTime(2021, 5, 5, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7692), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 5, 14, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7671), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7649), new DateTime(2020, 9, 13, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7647), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7629), new DateTime(2016, 3, 9, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7627), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7461), new DateTime(2021, 10, 31, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7459), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7441), new DateTime(2016, 8, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7439), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7420), new DateTime(2017, 10, 21, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7418), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7375), new DateTime(2023, 5, 7, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7373), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7355), new DateTime(2021, 9, 28, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 1, 5, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7333), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7251), new DateTime(2021, 11, 11, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7250), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7231), new DateTime(2018, 4, 16, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7230), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7212), new DateTime(2021, 7, 9, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7210), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7192), new DateTime(2023, 12, 19, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7190), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7167), new DateTime(2022, 7, 4, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7166), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7143), new DateTime(2019, 12, 1, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7065), new DateTime(2016, 8, 30, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7039), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -10,
                column: "Classification",
                value: 0);

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
                value: 2);

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
                keyValue: -5,
                column: "Classification",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4,
                column: "Classification",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3,
                column: "Classification",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 4);
        }
    }
}
