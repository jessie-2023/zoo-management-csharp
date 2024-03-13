using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureAlmost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9323), new DateTime(2022, 9, 14, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9322), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9306), new DateTime(2023, 5, 15, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9305), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9289), new DateTime(2016, 9, 5, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9288), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9272), new DateTime(2023, 4, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9271), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9254), new DateTime(2016, 1, 25, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9253), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9236), new DateTime(2022, 4, 1, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9220), new DateTime(2020, 9, 5, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9218), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9202), new DateTime(2020, 9, 13, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9201), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9185), new DateTime(2022, 5, 20, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9183), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9167), new DateTime(2016, 12, 18, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9166), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9132), new DateTime(2016, 3, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9131), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9115), new DateTime(2021, 4, 28, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9114), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9097), new DateTime(2022, 4, 2, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9096), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9079), new DateTime(2018, 3, 5, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9078), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9062), new DateTime(2019, 11, 1, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9060), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9044), new DateTime(2018, 4, 26, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9043), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9026), new DateTime(2020, 7, 13, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9025), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9009), new DateTime(2020, 9, 20, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9008), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8987), new DateTime(2022, 10, 6, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8985), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8892), new DateTime(2023, 12, 23, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8855), new DateTime(2021, 10, 26, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8853), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8838), new DateTime(2023, 7, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8837), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8821), new DateTime(2022, 12, 1, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8820), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8804), new DateTime(2020, 8, 5, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8786), new DateTime(2020, 8, 23, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8785), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8769), new DateTime(2023, 3, 16, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8768), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8752), new DateTime(2023, 10, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8751), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8735), new DateTime(2017, 7, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8734), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8718), new DateTime(2021, 3, 5, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8716), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8699), new DateTime(2022, 11, 29, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8698), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8665), new DateTime(2021, 8, 4, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8664), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8647), new DateTime(2018, 9, 2, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8646), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8630), new DateTime(2016, 8, 18, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8629), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8612), new DateTime(2020, 8, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8611), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8596), new DateTime(2022, 3, 14, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8595), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8578), new DateTime(2023, 3, 20, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8577), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8558), new DateTime(2016, 6, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8515), new DateTime(2020, 7, 23, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8513), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8497), new DateTime(2016, 12, 30, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8496), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8480), new DateTime(2018, 10, 8, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8447), new DateTime(2018, 3, 23, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8446), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8430), new DateTime(2018, 7, 26, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8429), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8413), new DateTime(2020, 5, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8412), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8396), new DateTime(2022, 9, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8395), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8379), new DateTime(2017, 8, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8377), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8361), new DateTime(2020, 9, 10, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8360), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8344), new DateTime(2021, 8, 13, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8343), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8327), new DateTime(2018, 10, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8326), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8310), new DateTime(2021, 7, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8309), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8292), new DateTime(2016, 10, 26, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8290), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8258), new DateTime(2019, 2, 27, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8257), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8241), new DateTime(2018, 3, 28, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8240), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8223), new DateTime(2017, 5, 22, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8222), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8205), new DateTime(2019, 4, 16, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8204), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8188), new DateTime(2016, 2, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8186), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8170), new DateTime(2017, 8, 30, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8169), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 9, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8151), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 2, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8130), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8075), new DateTime(2021, 8, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8073), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 9, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8019), new DateTime(2019, 1, 15, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8018), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8002), new DateTime(2017, 6, 30, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8000), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7984), new DateTime(2020, 6, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7983), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7967), new DateTime(2023, 12, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7966), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7950), new DateTime(2017, 12, 26, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7933), new DateTime(2019, 9, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7915), new DateTime(2017, 11, 6, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7914), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7898), new DateTime(2018, 12, 30, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7897), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7880), new DateTime(2020, 4, 18, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7879), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7861), new DateTime(2018, 2, 3, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7859), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7826), new DateTime(2021, 7, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7824), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7809), new DateTime(2022, 2, 20, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7807), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7791), new DateTime(2017, 10, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7790), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7774), new DateTime(2019, 1, 11, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7773), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7757), new DateTime(2021, 10, 9, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7755), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7739), new DateTime(2019, 12, 31, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7737), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7721), new DateTime(2019, 1, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7720), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7700), new DateTime(2016, 1, 11, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7699), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7638), new DateTime(2021, 9, 12, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7632), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7615), new DateTime(2023, 11, 17, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7614), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 9, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7581), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7565), new DateTime(2022, 12, 10, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7564), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7548), new DateTime(2019, 6, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7546), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7530), new DateTime(2017, 1, 17, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7529), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7512), new DateTime(2018, 9, 2, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7511), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7493), new DateTime(2018, 6, 12, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7491), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7475), new DateTime(2020, 7, 30, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7474), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7458), new DateTime(2018, 3, 22, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7457), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7440), new DateTime(2020, 2, 5, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7439), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7423), new DateTime(2021, 4, 9, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7421), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7387), new DateTime(2021, 2, 5, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7386), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7370), new DateTime(2021, 12, 31, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7369), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7352), new DateTime(2021, 3, 2, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7351), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 12, 3, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7332), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7316), new DateTime(2021, 12, 18, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7299), new DateTime(2022, 11, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7297), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7279), new DateTime(2019, 4, 24, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7278), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7256), new DateTime(2021, 7, 27, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7255), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7191), new DateTime(2021, 5, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7190), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 9, 20, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7148), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11,
                column: "Classification",
                value: 3);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4,
                column: "Classification",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3,
                column: "Classification",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(685), new DateTime(2021, 11, 10, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(684), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(665), new DateTime(2017, 9, 19, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(664), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(564), new DateTime(2016, 4, 2, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(563), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(505), new DateTime(2018, 3, 7, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(503), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(378), new DateTime(2020, 11, 14, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(376), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(358), new DateTime(2018, 11, 21, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(356), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(333), new DateTime(2022, 1, 2, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(331), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(310), new DateTime(2019, 3, 11, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(308), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(290), new DateTime(2022, 12, 29, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(288), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(271), new DateTime(2022, 7, 30, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(269), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(230), new DateTime(2018, 11, 9, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(192), new DateTime(2021, 6, 15, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(190), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(151), new DateTime(2022, 4, 21, 9, 42, 49, 917, DateTimeKind.Utc).AddTicks(150), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(131), new DateTime(2023, 11, 10, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(111), new DateTime(2019, 1, 27, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(109), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(69), new DateTime(2016, 3, 13, 10, 42, 49, 917, DateTimeKind.Utc).AddTicks(67), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 2, 21, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9962), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9942), new DateTime(2020, 8, 11, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9940), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 2, 22, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9872), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9853), new DateTime(2019, 12, 9, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9851), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9792), new DateTime(2017, 2, 20, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9791) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9728), new DateTime(2022, 8, 30, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9692), new DateTime(2023, 1, 1, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9690), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9672), new DateTime(2022, 4, 15, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9670), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9651), new DateTime(2018, 12, 1, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9649), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9630), new DateTime(2021, 5, 20, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9629), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9570), new DateTime(2021, 11, 17, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9568), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9550), new DateTime(2016, 10, 4, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9548), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9529), new DateTime(2022, 10, 16, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9528), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9508), new DateTime(2019, 12, 7, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9506), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9464), new DateTime(2018, 5, 18, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9462), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9312), new DateTime(2020, 6, 21, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9310), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9291), new DateTime(2021, 5, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9290), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 3, 12, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9208), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9147), new DateTime(2022, 1, 6, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9109), new DateTime(2016, 3, 23, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9108), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9089), new DateTime(2017, 5, 8, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9088), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(9048), new DateTime(2022, 6, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(9046), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8878), new DateTime(2022, 10, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8857), new DateTime(2019, 8, 4, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8856) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8815), new DateTime(2022, 2, 7, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8814), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8637), new DateTime(2018, 9, 23, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8636), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8615), new DateTime(2020, 5, 1, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8613), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8509), new DateTime(2022, 5, 12, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8508), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8489), new DateTime(2022, 4, 13, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8488), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8469), new DateTime(2020, 2, 24, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8467), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8448), new DateTime(2016, 4, 24, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8447), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8408), new DateTime(2023, 1, 16, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8406), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8388), new DateTime(2019, 1, 11, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8386), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8327), new DateTime(2021, 5, 24, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8326), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8290), new DateTime(2019, 6, 17, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8289), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8270), new DateTime(2022, 5, 10, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8268), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8250), new DateTime(2019, 12, 6, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8248), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 6, 15, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(8165), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8148), new DateTime(2021, 2, 28, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(8146), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7982), new DateTime(2017, 12, 12, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7981), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7960), new DateTime(2016, 8, 6, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7959), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7919), new DateTime(2021, 7, 14, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7898), new DateTime(2019, 11, 7, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7896), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7876), new DateTime(2017, 4, 24, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7874), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7827), new DateTime(2019, 6, 21, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7825), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 42, 49, 916, DateTimeKind.Utc).AddTicks(7795), new DateTime(2021, 7, 29, 9, 42, 49, 916, DateTimeKind.Utc).AddTicks(7778), -1, 0 });

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
    }
}
