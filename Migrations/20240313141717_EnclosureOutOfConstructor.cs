using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureOutOfConstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2167), new DateTime(2022, 9, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2166), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2150), new DateTime(2017, 2, 22, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2149), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2132), new DateTime(2021, 4, 22, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2131), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(2034), new DateTime(2021, 5, 22, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(2033) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1999), new DateTime(2017, 10, 28, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1997), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1981), new DateTime(2023, 11, 12, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1980), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1946), new DateTime(2017, 8, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1944), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1860), new DateTime(2019, 9, 29, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1859), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1843), new DateTime(2019, 2, 6, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1842), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1809), new DateTime(2017, 12, 18, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1807), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1774), new DateTime(2021, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1772), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1756), new DateTime(2019, 6, 29, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1715), new DateTime(2020, 7, 10, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1713), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1696), new DateTime(2020, 5, 18, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1695), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1679), new DateTime(2020, 1, 24, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1678), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1660), new DateTime(2022, 9, 12, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1659), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1641), new DateTime(2017, 7, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1638), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1539), new DateTime(2022, 10, 17, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1537), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1501), new DateTime(2019, 4, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1500), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1484), new DateTime(2018, 10, 21, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1483), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1466), new DateTime(2023, 11, 9, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1432), new DateTime(2019, 6, 26, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1431), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1414), new DateTime(2021, 2, 2, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1413), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1396), new DateTime(2017, 8, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1392), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1146), new DateTime(2018, 5, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1144), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(1125), new DateTime(2019, 10, 9, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(1123), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(960), new DateTime(2021, 5, 4, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(959), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(939), new DateTime(2020, 6, 19, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(938), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(920), new DateTime(2018, 8, 12, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(918), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(880), new DateTime(2020, 4, 2, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(879), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(860), new DateTime(2017, 1, 29, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(858), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(734), new DateTime(2017, 3, 22, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(732), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(714), new DateTime(2019, 7, 16, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(712), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(635), new DateTime(2018, 4, 15, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(634), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(614), new DateTime(2016, 5, 28, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(613), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(576), new DateTime(2016, 8, 26, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(575) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(538), new DateTime(2021, 2, 7, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(536), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(518), new DateTime(2021, 12, 2, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(517), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(280), new DateTime(2023, 5, 18, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(279), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(261), new DateTime(2021, 7, 23, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(260), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(241), new DateTime(2020, 8, 25, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(239), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 350, DateTimeKind.Utc).AddTicks(182), new DateTime(2018, 6, 17, 13, 17, 17, 350, DateTimeKind.Utc).AddTicks(180) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9913), new DateTime(2019, 2, 24, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9912), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9896), new DateTime(2017, 5, 21, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9894), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9875), new DateTime(2023, 1, 5, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9873), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9789), new DateTime(2018, 5, 10, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9787), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9770), new DateTime(2017, 9, 2, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9769), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9731), new DateTime(2020, 12, 26, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9730), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 5, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9529), -4, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9492), new DateTime(2022, 7, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9491) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9453), new DateTime(2022, 10, 5, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9451), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9433), new DateTime(2019, 11, 11, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9432), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9413), new DateTime(2018, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9412), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9394), new DateTime(2021, 3, 6, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 6, 16, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9373), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9354), new DateTime(2016, 10, 17, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9353), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9317), new DateTime(2019, 3, 19, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9316), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(9150), new DateTime(2022, 9, 4, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(9148), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8811), new DateTime(2021, 3, 8, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8789), new DateTime(2019, 4, 13, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8787), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8768), new DateTime(2023, 8, 18, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8766), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8571), new DateTime(2023, 8, 14, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8569), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8550), new DateTime(2022, 4, 8, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8548), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8528), new DateTime(2021, 6, 9, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8527), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8457), new DateTime(2022, 2, 8, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8436), new DateTime(2019, 5, 30, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8434), -4, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(8288), new DateTime(2018, 9, 19, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(8278), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7971), new DateTime(2020, 6, 24, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(7955), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7738), new DateTime(2023, 5, 25, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(7736), -5, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 17, 17, 349, DateTimeKind.Utc).AddTicks(7640), new DateTime(2016, 10, 21, 13, 17, 17, 349, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -6,
                column: "Capacity",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -4,
                column: "Capacity",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -3,
                column: "Capacity",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -2,
                column: "Capacity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11,
                column: "Classification",
                value: 1);

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
                keyValue: -5,
                column: "Classification",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3,
                column: "Classification",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9427), new DateTime(2023, 8, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9426), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9410), new DateTime(2017, 3, 30, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9408), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9334), new DateTime(2021, 4, 6, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9333), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9317), new DateTime(2019, 12, 4, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9316), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9300), new DateTime(2016, 1, 12, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9283), new DateTime(2022, 4, 16, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9282), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9266), new DateTime(2022, 1, 31, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9265), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9249), new DateTime(2023, 2, 11, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9247), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9231), new DateTime(2022, 10, 18, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9230), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9213), new DateTime(2018, 5, 4, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9212), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9182), new DateTime(2017, 11, 10, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9181), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9165), new DateTime(2022, 2, 18, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9164), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9147), new DateTime(2019, 1, 19, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9146), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9129), new DateTime(2023, 2, 7, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9128), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9112), new DateTime(2019, 4, 21, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9111), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9095), new DateTime(2016, 12, 27, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9094), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9078), new DateTime(2024, 1, 15, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9077), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9060), new DateTime(2020, 2, 15, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9059), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9042), new DateTime(2020, 4, 19, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9041), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9024), new DateTime(2021, 3, 2, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8992), new DateTime(2023, 3, 12, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8991), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8975), new DateTime(2016, 1, 2, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8974), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8957), new DateTime(2021, 9, 2, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8955), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8934), new DateTime(2019, 9, 26, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8932), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8845), new DateTime(2023, 12, 3, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8844), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8828), new DateTime(2020, 11, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8827), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8811), new DateTime(2022, 4, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8809), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8792), new DateTime(2018, 4, 11, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8791), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8775), new DateTime(2018, 9, 21, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8773), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8756), new DateTime(2020, 1, 24, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8719), new DateTime(2020, 11, 5, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8718), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8697), new DateTime(2017, 5, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8696), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8675), new DateTime(2021, 10, 31, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8674), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8658), new DateTime(2020, 4, 9, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8656), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8641), new DateTime(2018, 7, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8639), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8623), new DateTime(2017, 4, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8622), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8605), new DateTime(2016, 5, 30, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8604), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8585), new DateTime(2019, 3, 7, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8584), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8567), new DateTime(2020, 6, 4, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8565), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8549), new DateTime(2019, 10, 27, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8548), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8514), new DateTime(2022, 5, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8513), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8433), new DateTime(2018, 4, 30, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8432), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8416), new DateTime(2019, 5, 8, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8414), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8398), new DateTime(2017, 12, 29, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8397), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8380), new DateTime(2023, 3, 14, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8378), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8361), new DateTime(2022, 5, 17, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8360), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8344), new DateTime(2020, 12, 11, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8342), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8326), new DateTime(2021, 4, 10, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8325), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8308), new DateTime(2018, 7, 5, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8307), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8291), new DateTime(2020, 3, 29, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8289), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8258), new DateTime(2021, 11, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8240), new DateTime(2022, 6, 29, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8239), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8222), new DateTime(2016, 1, 25, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8220), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8204), new DateTime(2019, 8, 12, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8203), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8187), new DateTime(2020, 6, 1, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8186), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8170), new DateTime(2021, 6, 26, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8168), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8152), new DateTime(2017, 1, 21, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8151), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8134), new DateTime(2020, 7, 12, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8133), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8117), new DateTime(2018, 1, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8115), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8098), new DateTime(2018, 9, 8, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8066), new DateTime(2016, 4, 3, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8065), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8048), new DateTime(2022, 12, 19, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8047), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8029), new DateTime(2019, 7, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8028), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7971), new DateTime(2022, 8, 10, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7970), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7954), new DateTime(2016, 11, 20, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7953), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7934), new DateTime(2020, 9, 7, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7933), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7912), new DateTime(2018, 7, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7911), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7895), new DateTime(2023, 12, 11, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7894), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7877), new DateTime(2020, 6, 10, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7876), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7857), new DateTime(2018, 6, 21, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7855), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7814), new DateTime(2019, 4, 6, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7813), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7797), new DateTime(2018, 8, 1, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7796), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7779), new DateTime(2018, 10, 4, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7761), new DateTime(2022, 1, 15, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7760), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7743), new DateTime(2016, 3, 24, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7742), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7726), new DateTime(2023, 8, 24, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7724), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7708), new DateTime(2019, 12, 21, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7707), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7691), new DateTime(2017, 11, 16, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7673), new DateTime(2017, 3, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7672), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7655), new DateTime(2018, 9, 8, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7653), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7623), new DateTime(2022, 1, 31, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7622), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7605), new DateTime(2022, 10, 5, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7604), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7585), new DateTime(2018, 3, 6, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7583), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7521), new DateTime(2017, 9, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7520), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7503), new DateTime(2016, 6, 5, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7483), new DateTime(2023, 3, 16, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7482), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7465), new DateTime(2019, 4, 23, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7464), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7447), new DateTime(2021, 6, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7446), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7428), new DateTime(2023, 5, 17, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7427), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7410), new DateTime(2018, 12, 23, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7409), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7377), new DateTime(2019, 10, 2, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7375), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7358), new DateTime(2020, 10, 11, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7340), new DateTime(2019, 5, 26, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7339), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7321), new DateTime(2021, 1, 20, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7319), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7303), new DateTime(2016, 12, 15, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7301), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7283), new DateTime(2017, 1, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7282), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7265), new DateTime(2023, 5, 26, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7263), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7244), new DateTime(2016, 1, 14, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7243), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 1, 14, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7224), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7199), new DateTime(2017, 6, 14, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -6,
                column: "Capacity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -4,
                column: "Capacity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -3,
                column: "Capacity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Enclosures",
                keyColumn: "Id",
                keyValue: -2,
                column: "Capacity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11,
                column: "Classification",
                value: 0);

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
                value: 0);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -6,
                column: "Classification",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -5,
                column: "Classification",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3,
                column: "Classification",
                value: 0);
        }
    }
}
