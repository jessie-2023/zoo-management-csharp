using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataRandomBirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6428), new DateTime(2020, 3, 7, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6410), new DateTime(2023, 2, 4, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6409), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6376), new DateTime(2020, 8, 9, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6375) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6263), new DateTime(2017, 9, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6246), new DateTime(2021, 2, 25, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6244) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6108), new DateTime(2019, 4, 25, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6107), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6091), new DateTime(2021, 6, 27, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6089), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6073), new DateTime(2023, 9, 18, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6071), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6055), new DateTime(2016, 9, 22, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6054), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(6037), new DateTime(2021, 6, 3, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(6035) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 3, 28, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5985) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5952), new DateTime(2018, 12, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5951), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 4, 4, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5900), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5883), new DateTime(2020, 11, 9, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5881) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 2, 19, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5788), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5723), new DateTime(2018, 6, 8, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5722), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5566), new DateTime(2018, 1, 14, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5564), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5549), new DateTime(2021, 2, 16, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5548), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5532), new DateTime(2017, 11, 18, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5515), new DateTime(2016, 5, 28, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5513), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5497), new DateTime(2019, 4, 5, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5496), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5382), new DateTime(2022, 10, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5381) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5332), new DateTime(2020, 9, 21, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5330), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5295), new DateTime(2021, 9, 16, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5291), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5119), new DateTime(2016, 2, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5117), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5101), new DateTime(2017, 3, 29, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(5082), new DateTime(2022, 5, 18, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(5081), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4818), new DateTime(2018, 4, 26, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4801), new DateTime(2021, 5, 12, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4800), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4753), new DateTime(2017, 6, 5, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4752) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4704), new DateTime(2017, 8, 23, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4688), new DateTime(2020, 11, 1, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4687), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4481), new DateTime(2020, 6, 19, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4480), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4449), new DateTime(2022, 2, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4447) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4415), new DateTime(2019, 3, 23, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4413), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4398), new DateTime(2018, 2, 5, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4397) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4349), new DateTime(2018, 11, 12, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4347), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4317), new DateTime(2019, 11, 19, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4316), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4300), new DateTime(2022, 6, 6, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4284), new DateTime(2017, 2, 12, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4282), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4250), new DateTime(2019, 9, 27, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4248), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4231), new DateTime(2019, 11, 18, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4229), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4214), new DateTime(2022, 2, 22, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4212) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 2, 17, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4099), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(4060), new DateTime(2022, 5, 12, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(4059) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3991), new DateTime(2021, 6, 4, 14, 35, 1, 272, DateTimeKind.Utc).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3974), new DateTime(2022, 12, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3973), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3958), new DateTime(2021, 2, 11, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3956), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3921), new DateTime(2018, 1, 2, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3919), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3899), new DateTime(2019, 11, 3, 15, 35, 1, 272, DateTimeKind.Utc).AddTicks(3875) });

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
                keyValue: -4,
                column: "Classification",
                value: 0);

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7306), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7305), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7288), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7256), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7241), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7224), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7223), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7208), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7174), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7144), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7110), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7093), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7078), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7077), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7061), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7060), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7044), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7028), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7027), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7009), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6935), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6872), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6871), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6855), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6854), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6821), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6804), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6772), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6771), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6755), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6754), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6717), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6702), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6685), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6670), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6669), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6654), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6653), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6638), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6618), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6509), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6464), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6462), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6448), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6446), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6415), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6414), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6399), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6398), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6382), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6381), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6366), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6349), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6309), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6278), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6263), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6262), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6247), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6246), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6231), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6213), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6198), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6181), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6166), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6147), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6106), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6077), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6045), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6028), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6012), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5995), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5994), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5979), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5978), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5961), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5927), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5926), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5873), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5871), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5857), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5841), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5825), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5824), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5807), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5792), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5698), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5663), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5648), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5632), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5630), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5614), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5598), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5596), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5579), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5548), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5531), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5530), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5515), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5514), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5466), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5465), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5449), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5448), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5432), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5415), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5399), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5397), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5382), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5381), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5362), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5346), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5344), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5310) });

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
                keyValue: -7,
                column: "Classification",
                value: 0);

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
