using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class RelationCircle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2673), new DateTime(2020, 6, 4, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2672), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2655), new DateTime(2019, 2, 22, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2637), new DateTime(2019, 4, 29, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2636), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2619), new DateTime(2016, 2, 10, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2618), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2600), new DateTime(2018, 1, 18, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2599), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2582), new DateTime(2020, 2, 24, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2580), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2564), new DateTime(2016, 7, 7, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2562), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2545), new DateTime(2020, 11, 19, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2544), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 5, 18, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2526), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2509), new DateTime(2019, 4, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2507), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2475), new DateTime(2019, 8, 8, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2474), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2457), new DateTime(2017, 6, 14, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2456), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2438), new DateTime(2019, 4, 11, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2437), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2419), new DateTime(2019, 10, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2418), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2400), new DateTime(2022, 8, 5, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2399), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2382), new DateTime(2020, 6, 30, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2381), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2364), new DateTime(2017, 3, 14, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2363), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2346), new DateTime(2019, 10, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2345), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2327), new DateTime(2024, 1, 23, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2325), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2307), new DateTime(2017, 4, 12, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2305), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2229), new DateTime(2018, 3, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2228), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2212), new DateTime(2024, 1, 10, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2211), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2194), new DateTime(2019, 6, 22, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2193), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2176), new DateTime(2022, 11, 19, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2157), new DateTime(2019, 4, 13, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2156), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2139), new DateTime(2016, 1, 9, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2138), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 1, 18, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2120), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2104), new DateTime(2018, 12, 5, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2103), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2086), new DateTime(2022, 5, 3, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2084), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2068), new DateTime(2016, 11, 28, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2066), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2033), new DateTime(2018, 10, 10, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2032), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2015), new DateTime(2017, 3, 27, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1997), new DateTime(2020, 8, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1995), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1979), new DateTime(2023, 5, 29, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1977), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 8, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1959), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1943), new DateTime(2023, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1925), new DateTime(2016, 4, 19, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1923), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1905), new DateTime(2022, 9, 17, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1904), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1886), new DateTime(2020, 11, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1884), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1828), new DateTime(2021, 2, 21, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1826), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1795), new DateTime(2020, 6, 10, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1794), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1777), new DateTime(2017, 6, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1776), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1759), new DateTime(2016, 10, 28, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1758), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1741), new DateTime(2022, 11, 2, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1739), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1722), new DateTime(2019, 8, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1721), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1705), new DateTime(2017, 3, 1, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1703), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1687), new DateTime(2023, 8, 28, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1686), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1670), new DateTime(2019, 5, 10, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1668), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 12, 16, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1632), new DateTime(2020, 5, 3, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1631), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1599), new DateTime(2020, 5, 31, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1597), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1580), new DateTime(2016, 4, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1579), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1561), new DateTime(2015, 12, 30, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1560), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1543), new DateTime(2016, 1, 1, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1542), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1525), new DateTime(2016, 10, 14, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1524), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1507), new DateTime(2021, 2, 24, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1505), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1489), new DateTime(2018, 5, 22, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1487), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1470), new DateTime(2016, 9, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1469), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1452), new DateTime(2018, 12, 31, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1432), new DateTime(2016, 10, 20, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1430), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1354), new DateTime(2022, 10, 18, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1353), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1336), new DateTime(2021, 10, 30, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1335), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1317), new DateTime(2021, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1316), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1299), new DateTime(2021, 10, 29, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1297), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1281), new DateTime(2022, 11, 22, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1279), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1263), new DateTime(2018, 9, 28, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1261), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1244), new DateTime(2019, 3, 16, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1243), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1227), new DateTime(2022, 7, 10, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1226), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1209), new DateTime(2023, 12, 25, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1207), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1188), new DateTime(2021, 4, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1187), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1155), new DateTime(2021, 2, 5, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1154), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1137), new DateTime(2022, 1, 6, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1136), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1118), new DateTime(2022, 2, 25, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1117), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1100), new DateTime(2019, 2, 15, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1099), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1082), new DateTime(2022, 4, 19, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1081), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1065), new DateTime(2020, 3, 16, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1047), new DateTime(2020, 3, 20, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1045), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1029), new DateTime(2020, 8, 5, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1028), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 2, 23, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1009), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(991), new DateTime(2019, 9, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(989), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(913), new DateTime(2022, 1, 4, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(895), new DateTime(2016, 8, 28, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(894), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(877), new DateTime(2018, 9, 5, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(876), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(860), new DateTime(2022, 11, 14, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(858), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(841), new DateTime(2017, 3, 7, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(840), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(822), new DateTime(2017, 6, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(821), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(804), new DateTime(2018, 1, 17, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(802), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(786), new DateTime(2016, 11, 26, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(785), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(767), new DateTime(2021, 8, 1, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(766), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(748), new DateTime(2019, 6, 12, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(713), new DateTime(2022, 6, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(712), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(696), new DateTime(2020, 7, 1, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(694), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(676), new DateTime(2016, 8, 17, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(675), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(656), new DateTime(2018, 1, 6, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(655), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(637), new DateTime(2020, 4, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(636), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(619), new DateTime(2017, 3, 1, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(618), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(601), new DateTime(2016, 2, 13, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(599), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(579), new DateTime(2018, 5, 18, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(577), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(560), new DateTime(2020, 10, 11, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(558), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(530), new DateTime(2020, 5, 19, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(513), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11,
                column: "Classification",
                value: 3);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -8,
                column: "Classification",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -7,
                column: "Classification",
                value: 3);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3,
                column: "Classification",
                value: 5);

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
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1159), new DateTime(2024, 1, 30, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1157), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1141), new DateTime(2020, 12, 23, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1126), new DateTime(2022, 11, 10, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1124), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1109), new DateTime(2021, 3, 6, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1108), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1093), new DateTime(2018, 10, 17, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(1092), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1076), new DateTime(2018, 2, 15, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1075), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1059), new DateTime(2020, 12, 27, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1058), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1042), new DateTime(2020, 2, 6, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1041), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1025), new DateTime(2018, 11, 21, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1024), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 5, 16, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(1007), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(977), new DateTime(2021, 2, 18, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(975), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(961), new DateTime(2018, 7, 27, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(959), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(943), new DateTime(2020, 4, 27, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(942), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(927), new DateTime(2023, 8, 29, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(925), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(910), new DateTime(2017, 7, 8, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(909), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(893), new DateTime(2018, 4, 7, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(892), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(876), new DateTime(2017, 7, 15, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(875), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(858), new DateTime(2016, 4, 22, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(856), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(836), new DateTime(2020, 3, 10, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(833), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(603), new DateTime(2020, 2, 16, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(601), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(565), new DateTime(2019, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(563), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(545), new DateTime(2017, 9, 1, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(543), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(525), new DateTime(2018, 11, 5, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(524), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(506), new DateTime(2020, 10, 10, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(486), new DateTime(2017, 10, 2, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(485), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(466), new DateTime(2019, 12, 27, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(464), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(446), new DateTime(2018, 2, 27, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(445), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(427), new DateTime(2022, 7, 30, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(426), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(407), new DateTime(2016, 11, 18, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(406), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(387), new DateTime(2021, 5, 23, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(385), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(349), new DateTime(2021, 2, 21, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(348), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(329), new DateTime(2022, 5, 2, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(309), new DateTime(2016, 11, 4, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(307), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(289), new DateTime(2017, 9, 4, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(287), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(269), new DateTime(2018, 7, 20, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(267), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(249), new DateTime(2016, 10, 19, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(227), new DateTime(2019, 10, 9, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(225), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(176), new DateTime(2016, 12, 6, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(174), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(157), new DateTime(2023, 10, 19, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(155), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(137), new DateTime(2017, 10, 21, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(135), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(100), new DateTime(2019, 6, 3, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(99), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(80), new DateTime(2020, 5, 21, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(79), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(60), new DateTime(2019, 1, 27, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(59), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(41), new DateTime(2020, 1, 20, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(40), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(21), new DateTime(2021, 5, 8, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(20), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(2), new DateTime(2016, 5, 19, 21, 25, 59, 667, DateTimeKind.Utc), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9982), new DateTime(2022, 4, 15, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9981), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9962), new DateTime(2016, 4, 15, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9961), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9942), new DateTime(2016, 1, 15, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9923), new DateTime(2022, 11, 15, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9915), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9881), new DateTime(2021, 11, 30, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9880), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9862), new DateTime(2021, 9, 2, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9860), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9842), new DateTime(2019, 3, 29, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9840), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9821), new DateTime(2022, 11, 12, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9820), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9802), new DateTime(2022, 8, 29, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9800), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 2, 6, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9781), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9760), new DateTime(2017, 12, 23, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9758), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9731), new DateTime(2021, 4, 18, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9729), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9666), new DateTime(2016, 6, 14, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9646), new DateTime(2022, 12, 12, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9644), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9607), new DateTime(2018, 11, 25, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9605), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9586), new DateTime(2016, 4, 7, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9585), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9567), new DateTime(2016, 9, 4, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9565), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9548), new DateTime(2023, 2, 14, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9546), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9528), new DateTime(2018, 12, 5, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9526), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9508), new DateTime(2021, 8, 4, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9507), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9488), new DateTime(2018, 8, 13, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9487), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9469), new DateTime(2022, 12, 21, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9468), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9449), new DateTime(2022, 9, 2, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9447), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9427), new DateTime(2023, 5, 11, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9425), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 8, 26, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9387), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9370), new DateTime(2017, 8, 17, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9368), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9345), new DateTime(2020, 8, 9, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9344), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9326), new DateTime(2019, 2, 27, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9325), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9306), new DateTime(2016, 1, 16, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9305), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9286), new DateTime(2023, 8, 9, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9266), new DateTime(2023, 11, 24, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9264), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9242), new DateTime(2016, 11, 29, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9240), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8975), new DateTime(2017, 1, 8, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8974), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8957), new DateTime(2020, 6, 7, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8955), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8925), new DateTime(2023, 10, 25, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8769), new DateTime(2020, 4, 9, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8767), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8750), new DateTime(2016, 7, 4, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8748), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8729), new DateTime(2020, 4, 17, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8728), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8709), new DateTime(2022, 8, 1, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8707), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8687), new DateTime(2018, 5, 26, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8686), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8668), new DateTime(2019, 9, 29, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8666), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8648), new DateTime(2023, 11, 10, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8647), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8629), new DateTime(2019, 2, 4, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8627), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8608), new DateTime(2018, 2, 8, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8569), new DateTime(2018, 10, 14, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8567), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 2, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8548), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8529), new DateTime(2021, 10, 8, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8527), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8507), new DateTime(2023, 5, 10, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8505), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8486), new DateTime(2016, 1, 15, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8485), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8466), new DateTime(2019, 10, 25, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8465), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8445), new DateTime(2023, 9, 4, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8444), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8419), new DateTime(2021, 9, 23, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8417), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8334), new DateTime(2021, 3, 8, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8333), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8308), new DateTime(2020, 3, 7, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8296), -2, 1 });

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
                keyValue: -5,
                column: "Classification",
                value: 1);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 3);
        }
    }
}
