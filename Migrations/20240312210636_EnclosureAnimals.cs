using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureAnimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(126), new DateTime(2021, 11, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(124), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(85), new DateTime(2021, 10, 9, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(83), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(45), new DateTime(2020, 5, 10, 20, 6, 35, 845, DateTimeKind.Utc).AddTicks(43), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(24), new DateTime(2022, 3, 4, 21, 6, 35, 845, DateTimeKind.Utc).AddTicks(23), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9943), new DateTime(2016, 1, 23, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9905), new DateTime(2022, 12, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9904), -6, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9776), new DateTime(2019, 10, 23, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9775), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9735), new DateTime(2019, 10, 4, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9734), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9654), new DateTime(2020, 8, 13, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9652), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9571), new DateTime(2022, 5, 14, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9569), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 10, 10, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9550), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9511), new DateTime(2024, 2, 1, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9491), new DateTime(2019, 6, 8, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9471), new DateTime(2020, 12, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9451), new DateTime(2019, 7, 20, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9450), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9430), new DateTime(2019, 9, 20, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9428), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9385), new DateTime(2023, 1, 17, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9384), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9345), new DateTime(2019, 9, 12, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9343), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9324), new DateTime(2022, 3, 13, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9322) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9105), new DateTime(2022, 10, 15, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9103), -4, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(9037), new DateTime(2019, 6, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8989), new DateTime(2016, 10, 8, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8988), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8968), new DateTime(2017, 3, 15, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8967), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8948), new DateTime(2022, 10, 9, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8947), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8926), new DateTime(2016, 8, 30, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8924), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8888), new DateTime(2017, 5, 26, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8783), new DateTime(2020, 5, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8781), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8735), new DateTime(2022, 11, 14, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8732), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8570), new DateTime(2019, 4, 24, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8568), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8532), new DateTime(2016, 1, 13, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8530), -3, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8489), new DateTime(2018, 3, 23, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8487), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8421), new DateTime(2022, 10, 8, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8420), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8400), new DateTime(2018, 6, 29, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8399), -6, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8340), new DateTime(2019, 9, 15, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8339) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8299), new DateTime(2022, 4, 24, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8298), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8237), new DateTime(2019, 3, 24, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8236), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8218), new DateTime(2023, 1, 17, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8216), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8176), new DateTime(2021, 12, 11, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8175), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8156), new DateTime(2020, 4, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8155), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8115), new DateTime(2022, 5, 26, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8114), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8093), new DateTime(2020, 8, 16, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(8092), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8070), new DateTime(2024, 1, 26, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8068), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8032), new DateTime(2021, 12, 7, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8030), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8011), new DateTime(2020, 3, 2, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(8010), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7989), new DateTime(2023, 7, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7988), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7895), new DateTime(2019, 10, 14, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7893), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7874), new DateTime(2016, 4, 25, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7873), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7853), new DateTime(2018, 7, 2, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7852), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7833), new DateTime(2020, 7, 21, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7832) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7714), new DateTime(2020, 6, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7712), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 5, 14, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7671), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7629), new DateTime(2016, 3, 9, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7627) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7441), new DateTime(2016, 8, 11, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7439), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7420), new DateTime(2017, 10, 21, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7418), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7355), new DateTime(2021, 9, 28, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7353), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 1, 5, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7333), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7251), new DateTime(2021, 11, 11, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7250), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7231), new DateTime(2018, 4, 16, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7230), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7212), new DateTime(2021, 7, 9, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7210), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7192), new DateTime(2023, 12, 19, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7190), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7167), new DateTime(2022, 7, 4, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7166), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7143), new DateTime(2019, 12, 1, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7141), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 21, 6, 35, 844, DateTimeKind.Utc).AddTicks(7065), new DateTime(2016, 8, 30, 20, 6, 35, 844, DateTimeKind.Utc).AddTicks(7039), -6 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 2, 19, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5321), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5301), new DateTime(2022, 5, 6, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(5300), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5280), new DateTime(2016, 3, 16, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5279), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 2, 10, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5258), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5239), new DateTime(2016, 10, 29, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(5237), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5218), new DateTime(2016, 12, 28, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5216), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5196), new DateTime(2018, 1, 17, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5195), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 1, 7, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4953), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4928), new DateTime(2016, 11, 4, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4927), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4907), new DateTime(2022, 1, 20, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4871), new DateTime(2022, 10, 19, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4869), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4851), new DateTime(2022, 10, 5, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4850), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4831), new DateTime(2019, 6, 29, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4829), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4811), new DateTime(2022, 3, 1, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4809), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4790), new DateTime(2019, 10, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4789), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4771), new DateTime(2020, 1, 24, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4769), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4751), new DateTime(2019, 1, 2, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4750), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4731), new DateTime(2018, 12, 21, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4729), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4711), new DateTime(2018, 3, 11, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4709), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4689), new DateTime(2017, 8, 31, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4686), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4332), new DateTime(2022, 9, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4331), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4314), new DateTime(2018, 8, 15, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4312), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4296), new DateTime(2019, 6, 9, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4295), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4278), new DateTime(2021, 12, 18, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4277), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4260), new DateTime(2019, 7, 6, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4259), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4242), new DateTime(2020, 2, 15, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4224), new DateTime(2023, 11, 19, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4206), new DateTime(2020, 9, 28, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4188), new DateTime(2017, 1, 27, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4186), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4168), new DateTime(2016, 10, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4167), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4133), new DateTime(2017, 4, 2, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4132), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4115), new DateTime(2017, 9, 12, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4114), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4097), new DateTime(2023, 12, 1, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4096), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4079), new DateTime(2019, 5, 7, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4061), new DateTime(2016, 7, 29, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4059), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4042), new DateTime(2024, 3, 11, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4041), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4024), new DateTime(2016, 9, 10, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4023), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4001), new DateTime(2016, 7, 18, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4000), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3977), new DateTime(2021, 7, 14, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3974), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 2, 24, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3857), new DateTime(2022, 11, 13, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3856), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 12, 9, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3837), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 8, 20, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3820), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3802), new DateTime(2017, 9, 28, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3801), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3783), new DateTime(2017, 3, 10, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3764), new DateTime(2016, 8, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3763), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3746), new DateTime(2017, 8, 19, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3745), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3728), new DateTime(2023, 5, 24, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3726), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3710), new DateTime(2022, 4, 17, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3709), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3692), new DateTime(2017, 1, 25, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3690), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3660), new DateTime(2019, 8, 16, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3658), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3641), new DateTime(2018, 6, 15, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3640), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3623), new DateTime(2016, 5, 5, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3622), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3605), new DateTime(2016, 8, 9, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3604), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3587), new DateTime(2022, 2, 3, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3586), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3569), new DateTime(2017, 2, 27, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3568), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3551), new DateTime(2016, 6, 9, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3549), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3532), new DateTime(2022, 4, 28, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3514), new DateTime(2018, 10, 31, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3513), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3495), new DateTime(2021, 1, 10, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3488), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3412), new DateTime(2018, 6, 3, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3410), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3394), new DateTime(2021, 5, 13, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3392), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3376), new DateTime(2020, 12, 7, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3375), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3358), new DateTime(2022, 7, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3356), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3340), new DateTime(2017, 10, 19, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3338), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3322), new DateTime(2023, 6, 22, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3320), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 2, 21, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3302), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3286), new DateTime(2018, 7, 15, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3284), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 2, 2, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3266), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3247), new DateTime(2019, 4, 6, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3245), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3211), new DateTime(2019, 6, 13, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3209), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3193), new DateTime(2020, 5, 12, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3192), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3175), new DateTime(2018, 5, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3174), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3158), new DateTime(2018, 10, 4, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3156), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3140), new DateTime(2019, 12, 16, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3139), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3122), new DateTime(2023, 2, 1, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3121), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3103), new DateTime(2022, 9, 20, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3102), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3085), new DateTime(2022, 2, 15, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3066), new DateTime(2019, 11, 10, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3065), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3046), new DateTime(2016, 10, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3043), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2970), new DateTime(2021, 5, 12, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2968), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2952), new DateTime(2018, 2, 16, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2950), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2934), new DateTime(2016, 8, 2, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2932), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2916), new DateTime(2018, 11, 17, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2914), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2897), new DateTime(2019, 10, 1, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2896), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2877), new DateTime(2017, 10, 1, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2875), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2858), new DateTime(2017, 4, 17, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2841), new DateTime(2018, 5, 7, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2839), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2822), new DateTime(2018, 6, 24, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2821), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2803), new DateTime(2021, 8, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2801), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2767), new DateTime(2019, 12, 25, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2766), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2749), new DateTime(2019, 10, 10, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2748), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2731), new DateTime(2017, 2, 17, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2729), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2711), new DateTime(2022, 7, 25, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2709), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2693), new DateTime(2020, 7, 7, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2691), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2674), new DateTime(2017, 6, 27, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2673), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2655), new DateTime(2021, 10, 18, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2654), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2635), new DateTime(2018, 2, 20, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2633), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2614), new DateTime(2016, 6, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2613), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2586), new DateTime(2018, 10, 13, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2567), -1 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11,
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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -7,
                column: "Classification",
                value: 1);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4,
                column: "Classification",
                value: 1);

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
                value: 0);
        }
    }
}
