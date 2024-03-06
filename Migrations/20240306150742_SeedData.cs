using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Animals",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfAquisition",
                table: "Animals",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1997, 10, 15, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1997, 10, 15, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Classification", "Name" },
                values: new object[,]
                {
                    { -11, 1, "species_11" },
                    { -10, 1, "species_10" },
                    { -9, 5, "species_9" },
                    { -8, 2, "species_8" },
                    { -7, 0, "species_7" },
                    { -6, 2, "species_6" },
                    { -5, 4, "species_5" },
                    { -4, 2, "species_4" },
                    { -3, 3, "species_3" },
                    { -2, 5, "species_2" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "DateOfAquisition", "DateOfBirth", "Name", "Sex", "SpeciesId" },
                values: new object[,]
                {
                    { -119, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7322), "animal_119", 0, -11 },
                    { -118, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7306), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7305), "animal_118", 0, -11 },
                    { -117, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7288), "animal_117", 0, -11 },
                    { -116, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7273), "animal_116", 1, -11 },
                    { -115, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7256), "animal_115", 1, -11 },
                    { -114, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7241), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7240), "animal_114", 1, -11 },
                    { -113, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7224), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7223), "animal_113", 1, -11 },
                    { -112, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7208), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7206), "animal_112", 0, -11 },
                    { -111, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7190), "animal_111", 1, -11 },
                    { -110, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7174), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7172), "animal_110", 0, -11 },
                    { -109, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7144), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7142), "animal_109", 0, -10 },
                    { -108, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7126), "animal_108", 1, -10 },
                    { -107, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7110), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7109), "animal_107", 0, -10 },
                    { -106, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7093), "animal_106", 0, -10 },
                    { -105, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7078), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7077), "animal_105", 0, -10 },
                    { -104, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7061), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7060), "animal_104", 1, -10 },
                    { -103, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7044), "animal_103", 1, -10 },
                    { -102, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7028), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7027), "animal_102", 0, -10 },
                    { -101, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(7009), "animal_101", 1, -10 },
                    { -100, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6935), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6933), "animal_100", 1, -10 },
                    { -99, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6902), "animal_99", 0, -9 },
                    { -98, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6887), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6886), "animal_98", 1, -9 },
                    { -97, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6872), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6871), "animal_97", 0, -9 },
                    { -96, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6855), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6854), "animal_96", 1, -9 },
                    { -95, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6838), "animal_95", 0, -9 },
                    { -94, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6821), "animal_94", 0, -9 },
                    { -93, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6804), "animal_93", 1, -9 },
                    { -92, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6788), "animal_92", 0, -9 },
                    { -91, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6772), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6771), "animal_91", 0, -9 },
                    { -90, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6755), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6754), "animal_90", 0, -9 },
                    { -89, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6717), "animal_89", 0, -8 },
                    { -88, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6702), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6701), "animal_88", 0, -8 },
                    { -87, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6685), "animal_87", 0, -8 },
                    { -86, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6670), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6669), "animal_86", 0, -8 },
                    { -85, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6654), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6653), "animal_85", 1, -8 },
                    { -84, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6638), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6636), "animal_84", 1, -8 },
                    { -83, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6618), "animal_83", 0, -8 },
                    { -82, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6525), "animal_82", 0, -8 },
                    { -81, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6509), "animal_81", 1, -8 },
                    { -80, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6492), "animal_80", 0, -8 },
                    { -79, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6464), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6462), "animal_79", 1, -7 },
                    { -78, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6448), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6446), "animal_78", 1, -7 },
                    { -77, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6430), "animal_77", 1, -7 },
                    { -76, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6415), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6414), "animal_76", 1, -7 },
                    { -75, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6399), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6398), "animal_75", 0, -7 },
                    { -74, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6382), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6381), "animal_74", 1, -7 },
                    { -73, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6366), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6365), "animal_73", 0, -7 },
                    { -72, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6349), "animal_72", 1, -7 },
                    { -71, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6326), "animal_71", 0, -7 },
                    { -70, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6309), "animal_70", 0, -7 },
                    { -69, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6278), "animal_69", 1, -6 },
                    { -68, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6263), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6262), "animal_68", 1, -6 },
                    { -67, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6247), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6246), "animal_67", 1, -6 },
                    { -66, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6231), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6230), "animal_66", 0, -6 },
                    { -65, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6213), "animal_65", 0, -6 },
                    { -64, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6198), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6197), "animal_64", 0, -6 },
                    { -63, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6181), "animal_63", 0, -6 },
                    { -62, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6166), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6164), "animal_62", 1, -6 },
                    { -61, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6147), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6146), "animal_61", 0, -6 },
                    { -60, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6106), "animal_60", 0, -6 },
                    { -59, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6077), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6076), "animal_59", 1, -5 },
                    { -58, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6059), "animal_58", 1, -5 },
                    { -57, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6045), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6043), "animal_57", 0, -5 },
                    { -56, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6028), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6026), "animal_56", 1, -5 },
                    { -55, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6012), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(6010), "animal_55", 1, -5 },
                    { -54, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5995), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5994), "animal_54", 0, -5 },
                    { -53, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5979), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5978), "animal_53", 1, -5 },
                    { -52, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5961), "animal_52", 1, -5 },
                    { -51, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5944), "animal_51", 0, -5 },
                    { -50, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5927), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5926), "animal_50", 0, -5 },
                    { -49, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5888), "animal_49", 1, -4 },
                    { -48, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5873), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5871), "animal_48", 0, -4 },
                    { -47, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5857), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5856), "animal_47", 0, -4 },
                    { -46, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5841), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5840), "animal_46", 1, -4 },
                    { -45, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5825), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5824), "animal_45", 0, -4 },
                    { -44, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5807), "animal_44", 0, -4 },
                    { -43, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5792), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5790), "animal_43", 1, -4 },
                    { -42, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5774), "animal_42", 0, -4 },
                    { -41, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5756), "animal_41", 0, -4 },
                    { -40, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5698), "animal_40", 1, -4 },
                    { -39, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5663), "animal_39", 0, -3 },
                    { -38, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5648), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5646), "animal_38", 0, -3 },
                    { -37, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5632), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5630), "animal_37", 0, -3 },
                    { -36, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5614), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5613), "animal_36", 1, -3 },
                    { -35, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5598), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5596), "animal_35", 0, -3 },
                    { -34, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5579), "animal_34", 0, -3 },
                    { -33, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5563), "animal_33", 0, -3 },
                    { -32, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5548), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5547), "animal_32", 0, -3 },
                    { -31, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5531), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5530), "animal_31", 1, -3 },
                    { -30, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5515), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5514), "animal_30", 1, -3 },
                    { -29, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5481), "animal_29", 1, -2 },
                    { -28, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5466), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5465), "animal_28", 1, -2 },
                    { -27, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5449), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5448), "animal_27", 0, -2 },
                    { -26, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5432), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5431), "animal_26", 1, -2 },
                    { -25, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5415), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5414), "animal_25", 0, -2 },
                    { -24, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5399), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5397), "animal_24", 0, -2 },
                    { -23, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5382), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5381), "animal_23", 1, -2 },
                    { -22, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5362), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5361), "animal_22", 0, -2 },
                    { -21, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5346), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5344), "animal_21", 0, -2 },
                    { -20, new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 6, 15, 7, 42, 126, DateTimeKind.Utc).AddTicks(5310), "animal_20", 1, -2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "Animals",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfAquisition",
                table: "Animals",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateOnly(2000, 1, 1), new DateOnly(1997, 10, 16) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateOfAquisition", "DateOfBirth" },
                values: new object[] { new DateOnly(2000, 1, 1), new DateOnly(1997, 10, 16) });
        }
    }
}
