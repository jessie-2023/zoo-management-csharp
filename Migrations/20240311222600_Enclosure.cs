using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class Enclosure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnclosureId",
                table: "Animals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Enclosures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enclosures", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1159), new DateTime(2024, 1, 30, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1157), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1141), new DateTime(2020, 12, 23, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1140), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1126), new DateTime(2022, 11, 10, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1124), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1076), new DateTime(2018, 2, 15, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1075), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1042), new DateTime(2020, 2, 6, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1041), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1025), new DateTime(2018, 11, 21, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1024), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 5, 16, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(1007), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(977), new DateTime(2021, 2, 18, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(975), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(961), new DateTime(2018, 7, 27, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(959), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(943), new DateTime(2020, 4, 27, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(942), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(927), new DateTime(2023, 8, 29, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(925), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(910), new DateTime(2017, 7, 8, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(909), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(893), new DateTime(2018, 4, 7, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(892), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(525), new DateTime(2018, 11, 5, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(524), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(506), new DateTime(2020, 10, 10, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(504), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(466), new DateTime(2019, 12, 27, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(464), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(427), new DateTime(2022, 7, 30, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(426), -2, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(387), new DateTime(2021, 5, 23, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(385), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(329), new DateTime(2022, 5, 2, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(327), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(309), new DateTime(2016, 11, 4, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(307), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(269), new DateTime(2018, 7, 20, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(267), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(249), new DateTime(2016, 10, 19, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(248), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(227), new DateTime(2019, 10, 9, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(225), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(100), new DateTime(2019, 6, 3, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(99), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(80), new DateTime(2020, 5, 21, 21, 25, 59, 667, DateTimeKind.Utc).AddTicks(79), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(60), new DateTime(2019, 1, 27, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(59), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 667, DateTimeKind.Utc).AddTicks(2), new DateTime(2016, 5, 19, 21, 25, 59, 667, DateTimeKind.Utc), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9982), new DateTime(2022, 4, 15, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9981), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9962), new DateTime(2016, 4, 15, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9961), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9942), new DateTime(2016, 1, 15, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9941), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9842), new DateTime(2019, 3, 29, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9840), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 2, 6, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9781), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9731), new DateTime(2021, 4, 18, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9729), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9666), new DateTime(2016, 6, 14, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9664), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9646), new DateTime(2022, 12, 12, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9644), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9607), new DateTime(2018, 11, 25, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9605), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9528), new DateTime(2018, 12, 5, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9526), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9449), new DateTime(2022, 9, 2, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9447), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9427), new DateTime(2023, 5, 11, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9425), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 8, 26, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9387), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9370), new DateTime(2017, 8, 17, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9368), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9345), new DateTime(2020, 8, 9, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9344), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9286), new DateTime(2023, 8, 9, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(9285), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9266), new DateTime(2023, 11, 24, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(9264), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8975), new DateTime(2017, 1, 8, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8974), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8957), new DateTime(2020, 6, 7, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8955), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8925), new DateTime(2023, 10, 25, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8924), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8750), new DateTime(2016, 7, 4, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8748), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8729), new DateTime(2020, 4, 17, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8728), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8668), new DateTime(2019, 9, 29, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8666), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8648), new DateTime(2023, 11, 10, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8647), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8629), new DateTime(2019, 2, 4, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8627), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8608), new DateTime(2018, 2, 8, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8606), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8569), new DateTime(2018, 10, 14, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8567), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8529), new DateTime(2021, 10, 8, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8527), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8486), new DateTime(2016, 1, 15, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8485), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8466), new DateTime(2019, 10, 25, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8465), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8445), new DateTime(2023, 9, 4, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8444), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8419), new DateTime(2021, 9, 23, 21, 25, 59, 666, DateTimeKind.Utc).AddTicks(8417), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8334), new DateTime(2021, 3, 8, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8333), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8308), new DateTime(2020, 3, 7, 22, 25, 59, 666, DateTimeKind.Utc).AddTicks(8296), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -2,
                column: "EnclosureId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -1,
                column: "EnclosureId",
                value: -1);

            migrationBuilder.InsertData(
                table: "Enclosures",
                columns: new[] { "Id", "Capacity", "Type" },
                values: new object[,]
                {
                    { -6, 1000, 5 },
                    { -5, 10, 4 },
                    { -4, 6, 3 },
                    { -3, 40, 2 },
                    { -2, 50, 1 },
                    { -1, 10, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -9,
                column: "Classification",
                value: 1);

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
                value: 0);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -5,
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

            migrationBuilder.CreateIndex(
                name: "IX_Animals_EnclosureId",
                table: "Animals",
                column: "EnclosureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Enclosures_EnclosureId",
                table: "Animals",
                column: "EnclosureId",
                principalTable: "Enclosures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Enclosures_EnclosureId",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "Enclosures");

            migrationBuilder.DropIndex(
                name: "IX_Animals_EnclosureId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EnclosureId",
                table: "Animals");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6428), new DateTime(2020, 3, 7, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6427), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6410), new DateTime(2023, 2, 4, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6393), new DateTime(2017, 11, 20, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6392), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6376), new DateTime(2020, 8, 9, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6375), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6359), new DateTime(2022, 9, 30, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6358), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6340), new DateTime(2023, 8, 21, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6281), new DateTime(2023, 11, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6279), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6263), new DateTime(2017, 9, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6262), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6246), new DateTime(2021, 2, 25, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6244), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6228), new DateTime(2021, 1, 20, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6193), new DateTime(2016, 5, 12, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6176), new DateTime(2022, 4, 5, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6158), new DateTime(2019, 5, 28, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6141), new DateTime(2019, 2, 8, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6140), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6125), new DateTime(2019, 1, 22, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6124), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6108), new DateTime(2019, 4, 25, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6091), new DateTime(2021, 6, 27, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6073), new DateTime(2023, 9, 18, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6055), new DateTime(2016, 9, 22, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6037), new DateTime(2021, 6, 3, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6035), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6003), new DateTime(2019, 7, 1, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 3, 28, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5985), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5969), new DateTime(2017, 4, 18, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5968), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5952), new DateTime(2018, 12, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5935), new DateTime(2017, 8, 28, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5919), new DateTime(2019, 7, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5917), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 4, 4, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5883), new DateTime(2020, 11, 9, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5881), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5806), new DateTime(2022, 8, 8, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5805), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 2, 19, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5757), new DateTime(2023, 5, 19, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5755), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 11, 11, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5723), new DateTime(2018, 6, 8, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5706), new DateTime(2022, 10, 2, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5704), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5688), new DateTime(2021, 12, 31, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5687), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5671), new DateTime(2015, 12, 28, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5654), new DateTime(2022, 8, 3, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5653), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5634), new DateTime(2021, 6, 1, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 7, 2, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5616), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5600), new DateTime(2021, 11, 10, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5566), new DateTime(2018, 1, 14, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5549), new DateTime(2021, 2, 16, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5532), new DateTime(2017, 11, 18, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5531), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5515), new DateTime(2016, 5, 28, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5497), new DateTime(2019, 4, 5, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5479), new DateTime(2021, 5, 24, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5477), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5382), new DateTime(2022, 10, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5381), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5366), new DateTime(2023, 12, 13, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5364), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5349), new DateTime(2017, 7, 17, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5332), new DateTime(2020, 9, 21, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5295), new DateTime(2021, 9, 16, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5138), new DateTime(2020, 3, 11, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5136), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5119), new DateTime(2016, 2, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5101), new DateTime(2017, 3, 29, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5100), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5082), new DateTime(2022, 5, 18, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5065), new DateTime(2022, 4, 29, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5045), new DateTime(2019, 9, 5, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5044), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4835), new DateTime(2016, 6, 1, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4818), new DateTime(2018, 4, 26, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4817), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4801), new DateTime(2021, 5, 12, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4770), new DateTime(2018, 7, 24, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4753), new DateTime(2017, 6, 5, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4752), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4737), new DateTime(2023, 12, 30, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4720), new DateTime(2021, 8, 9, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4704), new DateTime(2017, 8, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4702), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4688), new DateTime(2020, 11, 1, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4657), new DateTime(2021, 1, 28, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4655), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4620), new DateTime(2016, 11, 1, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4619), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4551), new DateTime(2017, 9, 20, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4532), new DateTime(2018, 9, 15, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4530), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4499), new DateTime(2019, 9, 20, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4481), new DateTime(2020, 6, 19, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4464), new DateTime(2023, 7, 14, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4449), new DateTime(2022, 2, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4447), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4431), new DateTime(2020, 8, 9, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4430), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4415), new DateTime(2019, 3, 23, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4398), new DateTime(2018, 2, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4397), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4382), new DateTime(2021, 9, 19, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4366), new DateTime(2018, 12, 20, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4349), new DateTime(2018, 11, 12, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4317), new DateTime(2019, 11, 19, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4300), new DateTime(2022, 6, 6, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4299), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4284), new DateTime(2017, 2, 12, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4267), new DateTime(2017, 1, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4250), new DateTime(2019, 9, 27, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4231), new DateTime(2019, 11, 18, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4214), new DateTime(2022, 2, 22, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4212), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4138), new DateTime(2023, 3, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4117), new DateTime(2023, 11, 30, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4116), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 2, 17, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4060), new DateTime(2022, 5, 12, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4059), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4044), new DateTime(2017, 11, 1, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4043), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4027), new DateTime(2019, 1, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4026), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4009), new DateTime(2017, 10, 10, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3991), new DateTime(2021, 6, 4, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(3989), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3974), new DateTime(2022, 12, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3958), new DateTime(2021, 2, 11, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3938), new DateTime(2021, 2, 19, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3921), new DateTime(2018, 1, 2, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3899), new DateTime(2019, 11, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -9,
                column: "Classification",
                value: 4);

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
                value: 4);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2,
                column: "Classification",
                value: 1);
        }
    }
}
