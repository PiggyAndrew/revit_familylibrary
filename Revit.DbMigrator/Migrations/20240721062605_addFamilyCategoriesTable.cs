using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addFamilyCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "R_Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9372), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9374), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5659), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "52f5d987-42b5-4d37-859b-c715864ac01a", new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5725), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9399), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 7, 21, 14, 26, 4, 725, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "acc7266a-e36b-43da-b3df-a8814ecc56a2", new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 7, 21, 14, 26, 4, 724, DateTimeKind.Local).AddTicks(5747), "AQAAAAEAACcQAAAAECqc2tfq43Ohqu1ODalb9MeCbuFzgEffhIwIA2y647n1geHXQc6O5uFoQQyPkPEeJA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "R_Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2796), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9249), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9250), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "5d64e515-28cd-42ac-9110-b32e607e18c7", new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2828), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2834), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2835), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 7, 18, 21, 41, 42, 945, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "e4bf5078-5c2b-43d9-8473-b2c819f4aa68", new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 7, 18, 21, 41, 42, 943, DateTimeKind.Local).AddTicks(9330), "AQAAAAEAACcQAAAAEMdQmgOtcqAjShZsJHxJDFIkQkEe7YSZUnRpNOUUnCOlBulfxZ3lMRNfAwChO29mww==" });
        }
    }
}
