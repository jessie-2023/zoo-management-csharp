using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnclosureConstructorRevert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 2, 19, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5321), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5280), new DateTime(2016, 3, 16, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5279) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5239), new DateTime(2016, 10, 29, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(5237), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5218), new DateTime(2016, 12, 28, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(5216), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4907), new DateTime(2022, 1, 20, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4905), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4851), new DateTime(2022, 10, 5, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4850), -6 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4771), new DateTime(2020, 1, 24, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4769), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4751), new DateTime(2019, 1, 2, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4750), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4731), new DateTime(2018, 12, 21, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4729), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4689), new DateTime(2017, 8, 31, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4686), -5, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4314), new DateTime(2018, 8, 15, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4312) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4278), new DateTime(2021, 12, 18, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4277), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4260), new DateTime(2019, 7, 6, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4259), -3, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4224), new DateTime(2023, 11, 19, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4222), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4206), new DateTime(2020, 9, 28, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4204), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4168), new DateTime(2016, 10, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4167), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4133), new DateTime(2017, 4, 2, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4132), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4097), new DateTime(2023, 12, 1, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4096), -6, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4079), new DateTime(2019, 5, 7, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4077), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4061), new DateTime(2016, 7, 29, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4059), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4042), new DateTime(2024, 3, 11, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4041), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4024), new DateTime(2016, 9, 10, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4023), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(4001), new DateTime(2016, 7, 18, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3977), new DateTime(2021, 7, 14, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3974), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 2, 24, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3888), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 12, 9, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3837), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 8, 20, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3820), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3783), new DateTime(2017, 3, 10, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3782), -4, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3692), new DateTime(2017, 1, 25, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3690), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3660), new DateTime(2019, 8, 16, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3658), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3623), new DateTime(2016, 5, 5, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3622), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3605), new DateTime(2016, 8, 9, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3587), new DateTime(2022, 2, 3, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3586), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3569), new DateTime(2017, 2, 27, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3551), new DateTime(2016, 6, 9, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3549), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3532), new DateTime(2022, 4, 28, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3531), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3514), new DateTime(2018, 10, 31, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3513), -6, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3495), new DateTime(2021, 1, 10, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3488), -5, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3394), new DateTime(2021, 5, 13, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3392), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3376), new DateTime(2020, 12, 7, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3358), new DateTime(2022, 7, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3356), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3304), new DateTime(2023, 2, 21, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3302), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3286), new DateTime(2018, 7, 15, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3284), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 2, 2, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3266), -5, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3247), new DateTime(2019, 4, 6, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3245), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3211), new DateTime(2019, 6, 13, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3209), -6, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3175), new DateTime(2018, 5, 11, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3174), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3140), new DateTime(2019, 12, 16, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3139), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3085), new DateTime(2022, 2, 15, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3084), -5 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(3046), new DateTime(2016, 10, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(3043), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2934), new DateTime(2016, 8, 2, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2932), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2916), new DateTime(2018, 11, 17, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2914), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2897), new DateTime(2019, 10, 1, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2877), new DateTime(2017, 10, 1, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2875), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2858), new DateTime(2017, 4, 17, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2857), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2841), new DateTime(2018, 5, 7, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2839), -5 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2822), new DateTime(2018, 6, 24, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2821), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2803), new DateTime(2021, 8, 26, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2801), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2767), new DateTime(2019, 12, 25, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2749), new DateTime(2019, 10, 10, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2748), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2731), new DateTime(2017, 2, 17, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2729), 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2693), new DateTime(2020, 7, 7, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2691), -4, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2674), new DateTime(2017, 6, 27, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2673), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2635), new DateTime(2018, 2, 20, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2633) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 17, 57, 204, DateTimeKind.Utc).AddTicks(2586), new DateTime(2018, 10, 13, 6, 17, 57, 204, DateTimeKind.Utc).AddTicks(2567), -1, 1 });

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
                keyValue: -2,
                column: "Classification",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2655), new DateTime(2019, 2, 22, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2654), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2637), new DateTime(2019, 4, 29, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2636) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 5, 18, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2526), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2457), new DateTime(2017, 6, 14, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2456), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2419), new DateTime(2019, 10, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2418), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2400), new DateTime(2022, 8, 5, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2399), -1, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2346), new DateTime(2019, 10, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2345), -1, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2212), new DateTime(2024, 1, 10, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2211) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2176), new DateTime(2022, 11, 19, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2175), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2157), new DateTime(2019, 4, 13, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2156), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2139), new DateTime(2016, 1, 9, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 1, 18, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2120), -1, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2104), new DateTime(2018, 12, 5, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2103), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(2015), new DateTime(2017, 3, 27, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(2013), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1997), new DateTime(2020, 8, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1995), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1979), new DateTime(2023, 5, 29, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1977), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 8, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1959), -3, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1943), new DateTime(2023, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1942), -2, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1905), new DateTime(2022, 9, 17, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1886), new DateTime(2020, 11, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1884), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1795), new DateTime(2020, 6, 10, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1794), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1777), new DateTime(2017, 6, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1776), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1759), new DateTime(2016, 10, 28, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1758), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1722), new DateTime(2019, 8, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1721), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1705), new DateTime(2017, 3, 1, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1703), -1, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1687), new DateTime(2023, 8, 28, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1686), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1670), new DateTime(2019, 5, 10, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1668), -2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 12, 16, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1650), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1632), new DateTime(2020, 5, 3, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1631), -4, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1580), new DateTime(2016, 4, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1579), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1561), new DateTime(2015, 12, 30, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1560), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1543), new DateTime(2016, 1, 1, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1542) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1507), new DateTime(2021, 2, 24, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1505) });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1470), new DateTime(2016, 9, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1469), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1452), new DateTime(2018, 12, 31, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1450), -2, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1432), new DateTime(2016, 10, 20, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1430), -2, 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1354), new DateTime(2022, 10, 18, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1353), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1317), new DateTime(2021, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1299), new DateTime(2021, 10, 29, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1297), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1281), new DateTime(2022, 11, 22, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1279), -6, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1244), new DateTime(2019, 3, 16, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1243), -6 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1155), new DateTime(2021, 2, 5, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1154), -2, 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1118), new DateTime(2022, 2, 25, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1117), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1100), new DateTime(2019, 2, 15, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1099), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1082), new DateTime(2022, 4, 19, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(1081), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1065), new DateTime(2020, 3, 16, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1063), -2, 1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 2, 23, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(1009), -3 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(991), new DateTime(2019, 9, 25, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(989), -6 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(913), new DateTime(2022, 1, 4, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(912), -2 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(877), new DateTime(2018, 9, 5, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(876), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(860), new DateTime(2022, 11, 14, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(858), -4 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(841), new DateTime(2017, 3, 7, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(822), new DateTime(2017, 6, 15, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(821), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(804), new DateTime(2018, 1, 17, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(802), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(786), new DateTime(2016, 11, 26, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(785), -1 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(748), new DateTime(2019, 6, 12, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(746), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(713), new DateTime(2022, 6, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(696), new DateTime(2020, 7, 1, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(694), 0 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(676), new DateTime(2016, 8, 17, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(675), 0 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId", "Sex" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(637), new DateTime(2020, 4, 21, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(636), -5, 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateOfAquisition", "DateOfBirth", "EnclosureId" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(619), new DateTime(2017, 3, 1, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(618), -4 });

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
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 31, 21, 389, DateTimeKind.Utc).AddTicks(579), new DateTime(2018, 5, 18, 21, 31, 21, 389, DateTimeKind.Utc).AddTicks(577) });

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
                value: 3);

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
                keyValue: -6,
                column: "Classification",
                value: 0);

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
                keyValue: -2,
                column: "Classification",
                value: 1);
        }
    }
}
