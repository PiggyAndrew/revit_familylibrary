using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class modifyForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_R_FamilyCategory_R_Category_FamilyId",
                table: "R_FamilyCategory");

            migrationBuilder.UpdateData(
                table: "R_Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7517), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2390), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2392), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2394), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7647), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7649), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7653), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime" },
                values: new object[] { "310fddc5-f261-4ace-b76a-a2fce1dc40a5", new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2471), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2472), new DateTime(2024, 7, 21, 14, 41, 1, 4, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "d60a624e-c1af-4f87-9187-5b290bbbef70", new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 7, 21, 14, 41, 1, 2, DateTimeKind.Local).AddTicks(7734), "AQAAAAEAACcQAAAAEHEpbtuh42U34pkd0hJYTwKDpzvcjepHA05TcJ1zMpcNXghBze3vCBO5ukv1J1zNNQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_R_FamilyCategory_CategoryId",
                table: "R_FamilyCategory",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_R_FamilyCategory_R_Category_CategoryId",
                table: "R_FamilyCategory",
                column: "CategoryId",
                principalTable: "R_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_R_FamilyCategory_R_Category_CategoryId",
                table: "R_FamilyCategory");

            migrationBuilder.DropIndex(
                name: "IX_R_FamilyCategory_CategoryId",
                table: "R_FamilyCategory");

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

            migrationBuilder.AddForeignKey(
                name: "FK_R_FamilyCategory_R_Category_FamilyId",
                table: "R_FamilyCategory",
                column: "FamilyId",
                principalTable: "R_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
