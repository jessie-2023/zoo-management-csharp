using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureRelationBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9427), new DateTime(2023, 8, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9426), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9334), new DateTime(2021, 4, 6, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9317), new DateTime(2019, 12, 4, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9316), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9300), new DateTime(2016, 1, 12, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9299), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9283), new DateTime(2022, 4, 16, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9282), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9266), new DateTime(2022, 1, 31, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9265), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9249), new DateTime(2023, 2, 11, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9231), new DateTime(2022, 10, 18, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(9230), -6, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9165), new DateTime(2022, 2, 18, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9164) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9129), new DateTime(2023, 2, 7, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9128), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9095), new DateTime(2016, 12, 27, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9094), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9024), new DateTime(2021, 3, 2, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(9023), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8992), new DateTime(2023, 3, 12, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8991), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8975), new DateTime(2016, 1, 2, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8974), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8957), new DateTime(2021, 9, 2, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8955), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8934), new DateTime(2019, 9, 26, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8932), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8828), new DateTime(2020, 11, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8811), new DateTime(2022, 4, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8809), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8792), new DateTime(2018, 4, 11, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8791), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8775), new DateTime(2018, 9, 21, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8773), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8756), new DateTime(2020, 1, 24, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8755), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8719), new DateTime(2020, 11, 5, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8718), -2, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8675), new DateTime(2021, 10, 31, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8658), new DateTime(2020, 4, 9, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8656), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8641), new DateTime(2018, 7, 25, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8639), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8623), new DateTime(2017, 4, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8622), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8605), new DateTime(2016, 5, 30, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8604), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8585), new DateTime(2019, 3, 7, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8584), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8567), new DateTime(2020, 6, 4, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8565), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8433), new DateTime(2018, 4, 30, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8432), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8416), new DateTime(2019, 5, 8, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8414), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8398), new DateTime(2017, 12, 29, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8397), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8380), new DateTime(2023, 3, 14, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8378), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8361), new DateTime(2022, 5, 17, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8360), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8326), new DateTime(2021, 4, 10, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8325), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8308), new DateTime(2018, 7, 5, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8307), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8291), new DateTime(2020, 3, 29, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8289), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8258), new DateTime(2021, 11, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8257), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8240), new DateTime(2022, 6, 29, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8239), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8222), new DateTime(2016, 1, 25, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8204), new DateTime(2019, 8, 12, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8203), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8187), new DateTime(2020, 6, 1, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8186), -6, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8134), new DateTime(2020, 7, 12, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8133), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8117), new DateTime(2018, 1, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8115), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8098), new DateTime(2018, 9, 8, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8097), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8066), new DateTime(2016, 4, 3, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(8065), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8048), new DateTime(2022, 12, 19, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(8047), -4, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7954), new DateTime(2016, 11, 20, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7934), new DateTime(2020, 9, 7, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7933), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7912), new DateTime(2018, 7, 13, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7911), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7877), new DateTime(2020, 6, 10, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7876), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7857), new DateTime(2018, 6, 21, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7855), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7797), new DateTime(2018, 8, 1, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7796), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7779), new DateTime(2018, 10, 4, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7777), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7743), new DateTime(2016, 3, 24, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7742), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7726), new DateTime(2023, 8, 24, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7724), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7708), new DateTime(2019, 12, 21, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7707), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7691), new DateTime(2017, 11, 16, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7689), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7673), new DateTime(2017, 3, 1, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7672), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7655), new DateTime(2018, 9, 8, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7653), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7623), new DateTime(2022, 1, 31, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7622), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7585), new DateTime(2018, 3, 6, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7583), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7503), new DateTime(2016, 6, 5, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7501), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7483), new DateTime(2023, 3, 16, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7482), -3, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7428), new DateTime(2023, 5, 17, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7427), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7410), new DateTime(2018, 12, 23, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7409), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7358), new DateTime(2020, 10, 11, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7357), -5, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7283), new DateTime(2017, 1, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7282), -6, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 1, 14, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7224), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 14, 5, 1, 330, DateTimeKind.Utc).AddTicks(7199), new DateTime(2017, 6, 14, 13, 5, 1, 330, DateTimeKind.Utc).AddTicks(7186) });

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
                keyValue: -5,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4385), new DateTime(2023, 5, 13, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4383), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4366), new DateTime(2021, 7, 31, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4364), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4347), new DateTime(2017, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4329), new DateTime(2016, 1, 1, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4327), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4311), new DateTime(2020, 4, 11, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4310), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4292), new DateTime(2018, 11, 22, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4291), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4274), new DateTime(2018, 5, 30, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4272), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4252), new DateTime(2020, 11, 18, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4186), new DateTime(2020, 8, 5, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4184), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3991), new DateTime(2018, 5, 17, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3989), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3956), new DateTime(2021, 10, 9, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3954), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3937), new DateTime(2016, 8, 16, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3917), new DateTime(2018, 6, 3, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3915), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3716), new DateTime(2020, 8, 11, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3714), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3694), new DateTime(2016, 9, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3693), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3671), new DateTime(2021, 1, 20, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3669), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3649), new DateTime(2017, 12, 14, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3648), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3628), new DateTime(2022, 8, 16, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3626), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3607), new DateTime(2021, 1, 28, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3605), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3585), new DateTime(2016, 1, 8, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3583), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3547), new DateTime(2021, 1, 30, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3545), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3525), new DateTime(2021, 6, 26, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3524), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3504), new DateTime(2017, 8, 26, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3502), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3482), new DateTime(2021, 4, 27, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3480), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3461), new DateTime(2018, 8, 16, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3459), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3439), new DateTime(2023, 4, 10, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3418), new DateTime(2020, 6, 25, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3416), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3396), new DateTime(2023, 4, 23, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3394), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 1, 26, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3371), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3304), new DateTime(2020, 10, 5, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3302), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3261), new DateTime(2020, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3259), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3240), new DateTime(2017, 4, 29, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3238), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3219), new DateTime(2023, 6, 23, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3198), new DateTime(2019, 2, 25, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3196), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3176), new DateTime(2020, 4, 27, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3174), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3155), new DateTime(2018, 9, 10, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3153), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 9, 20, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3131), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3110), new DateTime(2017, 4, 21, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3108), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3089), new DateTime(2020, 5, 22, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3087), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3067), new DateTime(2016, 2, 10, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3065), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2804), new DateTime(2019, 1, 4, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2802), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2786), new DateTime(2021, 5, 29, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2784), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2767), new DateTime(2017, 1, 25, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2766), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2749), new DateTime(2020, 8, 10, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2747), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2547), new DateTime(2019, 10, 20, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2546), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2527), new DateTime(2020, 5, 29, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2525), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2506), new DateTime(2018, 3, 29, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2504), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2438), new DateTime(2022, 1, 5, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2436), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2418), new DateTime(2021, 12, 20, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2416), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2397), new DateTime(2022, 4, 15, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2395), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2361), new DateTime(2024, 1, 7, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2359), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2340), new DateTime(2021, 2, 20, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2338), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 12, 6, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2299), new DateTime(2019, 3, 2, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2297), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2279), new DateTime(2017, 4, 6, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2277), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2259), new DateTime(2020, 6, 15, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2257), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2238), new DateTime(2023, 3, 27, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2236), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2217), new DateTime(2018, 11, 2, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2215), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2197), new DateTime(2018, 7, 13, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2195), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2176), new DateTime(2016, 4, 20, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2174), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2139), new DateTime(2017, 4, 19, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2137), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1939), new DateTime(2021, 11, 14, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1937), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1921), new DateTime(2020, 10, 28, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1919), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1902), new DateTime(2017, 5, 1, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1901), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1884), new DateTime(2020, 12, 29, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1865), new DateTime(2019, 5, 13, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1863), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1846), new DateTime(2022, 11, 7, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1844), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1826), new DateTime(2020, 8, 19, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1825), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1805), new DateTime(2020, 12, 22, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1804), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1736), new DateTime(2021, 10, 27, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1734), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1694), new DateTime(2021, 2, 6, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1692), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1674), new DateTime(2016, 1, 15, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1672), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1655), new DateTime(2018, 2, 19, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1653), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1636), new DateTime(2023, 9, 12, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1634), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1616), new DateTime(2020, 2, 11, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1615), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1598), new DateTime(2017, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1596), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1579), new DateTime(2022, 9, 2, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1577), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1560), new DateTime(2021, 2, 23, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1559), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1542), new DateTime(2017, 9, 14, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1540), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1523), new DateTime(2016, 1, 6, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1521), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1488), new DateTime(2016, 7, 16, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1487), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1469), new DateTime(2023, 10, 16, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1468), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1451), new DateTime(2016, 11, 27, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1449), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1432), new DateTime(2016, 2, 27, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1430), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1413), new DateTime(2019, 6, 6, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1411), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1393), new DateTime(2017, 2, 9, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1391), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1374), new DateTime(2022, 11, 30, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1372), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1353), new DateTime(2017, 9, 23, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1351), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1282), new DateTime(2018, 7, 31, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1281), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1263), new DateTime(2016, 8, 31, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1261), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1227), new DateTime(2018, 5, 22, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1226), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1208), new DateTime(2016, 5, 10, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1206), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1188), new DateTime(2023, 1, 28, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1187), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1168), new DateTime(2023, 8, 3, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1167), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1149), new DateTime(2020, 3, 12, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1148), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1131), new DateTime(2019, 2, 19, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1129), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1106), new DateTime(2023, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1105), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1083), new DateTime(2017, 6, 20, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1081), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1063), new DateTime(2018, 4, 18, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1061), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1036), new DateTime(2023, 9, 11, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -10,
                column: "Classification",
                value: 3);

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
                value: 4);

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
                value: 1);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 5);
        }
    }
}
