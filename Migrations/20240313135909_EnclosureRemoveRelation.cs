using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureRemoveRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4347), new DateTime(2017, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4345), -6, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4311), new DateTime(2020, 4, 11, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4310), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4292), new DateTime(2018, 11, 22, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4274), new DateTime(2018, 5, 30, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4272), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4252), new DateTime(2020, 11, 18, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4250), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(4186), new DateTime(2020, 8, 5, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(4184), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3956), new DateTime(2021, 10, 9, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3954), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3937), new DateTime(2016, 8, 16, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3935), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3917), new DateTime(2018, 6, 3, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3915), -6, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3694), new DateTime(2016, 9, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3693), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3671), new DateTime(2021, 1, 20, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3669), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3649), new DateTime(2017, 12, 14, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3648), -2, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3607), new DateTime(2021, 1, 28, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3605), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3585), new DateTime(2016, 1, 8, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3583), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3547), new DateTime(2021, 1, 30, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3545), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3482), new DateTime(2021, 4, 27, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3480), -5, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3439), new DateTime(2023, 4, 10, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3437), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3418), new DateTime(2020, 6, 25, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3416), -4, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3396), new DateTime(2023, 4, 23, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3394), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 1, 26, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3371), -6 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3261), new DateTime(2020, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3259), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3219), new DateTime(2023, 6, 23, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3217), -4, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3089), new DateTime(2020, 5, 22, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(3087), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3067), new DateTime(2016, 2, 10, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(3065), -6 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2786), new DateTime(2021, 5, 29, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2784), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2767), new DateTime(2017, 1, 25, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2766), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2749), new DateTime(2020, 8, 10, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2747), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2547), new DateTime(2019, 10, 20, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2546), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2527), new DateTime(2020, 5, 29, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2525), -3, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2438), new DateTime(2022, 1, 5, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2436), -6 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2397), new DateTime(2022, 4, 15, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2395), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 12, 6, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2318), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2299), new DateTime(2019, 3, 2, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2297), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2259), new DateTime(2020, 6, 15, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2257) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2217), new DateTime(2018, 11, 2, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2197), new DateTime(2018, 7, 13, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2195), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2176), new DateTime(2016, 4, 20, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2174), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(2139), new DateTime(2017, 4, 19, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(2137), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1939), new DateTime(2021, 11, 14, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1937), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1921), new DateTime(2020, 10, 28, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1919), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1884), new DateTime(2020, 12, 29, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1882), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1846), new DateTime(2022, 11, 7, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1844), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1826), new DateTime(2020, 8, 19, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1825), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1805), new DateTime(2020, 12, 22, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1804), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1736), new DateTime(2021, 10, 27, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1734), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1655), new DateTime(2018, 2, 19, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1636), new DateTime(2023, 9, 12, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1634), -5, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1560), new DateTime(2021, 2, 23, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1559), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1542), new DateTime(2017, 9, 14, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1540), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1523), new DateTime(2016, 1, 6, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1521), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1432), new DateTime(2016, 2, 27, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1430), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1413), new DateTime(2019, 6, 6, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1411), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1393), new DateTime(2017, 2, 9, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1391), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1374), new DateTime(2022, 11, 30, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1372), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1282), new DateTime(2018, 7, 31, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1263), new DateTime(2016, 8, 31, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1261), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1168), new DateTime(2023, 8, 3, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1167), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1149), new DateTime(2020, 3, 12, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1148), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1131), new DateTime(2019, 2, 19, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1129), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1106), new DateTime(2023, 4, 8, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1105), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1063), new DateTime(2018, 4, 18, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1061), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 13, 59, 9, 112, DateTimeKind.Utc).AddTicks(1036), new DateTime(2023, 9, 11, 12, 59, 9, 112, DateTimeKind.Utc).AddTicks(1019), -3 });

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
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9323), new DateTime(2022, 9, 14, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9322), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9306), new DateTime(2023, 5, 15, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9305), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9272), new DateTime(2023, 4, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9271), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9220), new DateTime(2020, 9, 5, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9218), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9167), new DateTime(2016, 12, 18, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9166), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9115), new DateTime(2021, 4, 28, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9114), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9097), new DateTime(2022, 4, 2, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9096), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9062), new DateTime(2019, 11, 1, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9060), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9044), new DateTime(2018, 4, 26, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9043), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(9026), new DateTime(2020, 7, 13, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(9025), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8892), new DateTime(2023, 12, 23, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8891), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8804), new DateTime(2020, 8, 5, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8803), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8786), new DateTime(2020, 8, 23, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8785), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8769), new DateTime(2023, 3, 16, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8768), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8752), new DateTime(2023, 10, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8751), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8735), new DateTime(2017, 7, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8734), -3 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8665), new DateTime(2021, 8, 4, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8664), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8647), new DateTime(2018, 9, 2, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8646), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8630), new DateTime(2016, 8, 18, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8629), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8596), new DateTime(2022, 3, 14, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8595), -5, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8558), new DateTime(2016, 6, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8557), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8515), new DateTime(2020, 7, 23, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8513), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8497), new DateTime(2016, 12, 30, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8496), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8480), new DateTime(2018, 10, 8, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8478), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8447), new DateTime(2018, 3, 23, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8446), -5, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8379), new DateTime(2017, 8, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8377), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8361), new DateTime(2020, 9, 10, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8360), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8344), new DateTime(2021, 8, 13, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8343), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8327), new DateTime(2018, 10, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8326), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8292), new DateTime(2016, 10, 26, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8290), -6, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8241), new DateTime(2018, 3, 28, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8240), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8223), new DateTime(2017, 5, 22, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8222), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8205), new DateTime(2019, 4, 16, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8204), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8188), new DateTime(2016, 2, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8186), -3, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8170), new DateTime(2017, 8, 30, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 9, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8151), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 2, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8130) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 9, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8056), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(8002), new DateTime(2017, 6, 30, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(8000), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7984), new DateTime(2020, 6, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7983), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7967), new DateTime(2023, 12, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7966), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7950), new DateTime(2017, 12, 26, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7949), -1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7933), new DateTime(2019, 9, 29, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7931), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7915), new DateTime(2017, 11, 6, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7914), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7898), new DateTime(2018, 12, 30, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7897), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7880), new DateTime(2020, 4, 18, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7879), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7826), new DateTime(2021, 7, 21, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7824), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7809), new DateTime(2022, 2, 20, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7807), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7791), new DateTime(2017, 10, 25, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7774), new DateTime(2019, 1, 11, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7773), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7739), new DateTime(2019, 12, 31, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7737), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7721), new DateTime(2019, 1, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7720), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7700), new DateTime(2016, 1, 11, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7699), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7638), new DateTime(2021, 9, 12, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7632), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 9, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7581), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7565), new DateTime(2022, 12, 10, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7564), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7548), new DateTime(2019, 6, 11, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7546), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7530), new DateTime(2017, 1, 17, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7529), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7512), new DateTime(2018, 9, 2, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7511), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7493), new DateTime(2018, 6, 12, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7491), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7440), new DateTime(2020, 2, 5, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7439) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7387), new DateTime(2021, 2, 5, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7386), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7352), new DateTime(2021, 3, 2, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7351), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7334), new DateTime(2021, 12, 3, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7332), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7316), new DateTime(2021, 12, 18, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7315), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7299), new DateTime(2022, 11, 8, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7297), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7279), new DateTime(2019, 4, 24, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7278), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 26, 36, 994, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 9, 20, 11, 26, 36, 994, DateTimeKind.Utc).AddTicks(7148), -6 });

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
                value: 5);

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
                keyValue: -2,
                column: "Classification",
                value: 3);
        }
    }
}
