using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNET_RPG.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 18, 70, 153, 235, 35, 32, 62, 8, 233, 245, 251, 16, 40, 190, 243, 246, 53, 184, 254, 253, 213, 63, 129, 36, 199, 93, 98, 228, 144, 48, 107, 114, 69, 207, 10, 169, 92, 42, 220, 127, 34, 42, 162, 86, 59, 107, 139, 181, 145, 246, 56, 112, 32, 11, 145, 208, 114, 211, 28, 122, 146, 53, 235, 245 }, new byte[] { 209, 113, 171, 204, 151, 240, 239, 18, 41, 208, 129, 74, 27, 197, 151, 184, 103, 210, 18, 194, 0, 186, 162, 31, 51, 109, 1, 230, 151, 16, 57, 45, 39, 95, 217, 46, 123, 126, 147, 154, 112, 125, 12, 170, 247, 143, 245, 11, 112, 107, 86, 54, 150, 223, 229, 44, 245, 49, 104, 85, 211, 250, 159, 181, 171, 87, 226, 111, 204, 180, 221, 244, 189, 189, 179, 195, 29, 1, 40, 54, 70, 28, 36, 181, 29, 203, 138, 251, 240, 238, 227, 3, 238, 75, 82, 250, 218, 155, 221, 199, 39, 155, 232, 206, 113, 27, 200, 252, 26, 25, 213, 161, 146, 169, 104, 7, 193, 61, 32, 175, 84, 15, 77, 14, 234, 46, 173, 119 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 18, 70, 153, 235, 35, 32, 62, 8, 233, 245, 251, 16, 40, 190, 243, 246, 53, 184, 254, 253, 213, 63, 129, 36, 199, 93, 98, 228, 144, 48, 107, 114, 69, 207, 10, 169, 92, 42, 220, 127, 34, 42, 162, 86, 59, 107, 139, 181, 145, 246, 56, 112, 32, 11, 145, 208, 114, 211, 28, 122, 146, 53, 235, 245 }, new byte[] { 209, 113, 171, 204, 151, 240, 239, 18, 41, 208, 129, 74, 27, 197, 151, 184, 103, 210, 18, 194, 0, 186, 162, 31, 51, 109, 1, 230, 151, 16, 57, 45, 39, 95, 217, 46, 123, 126, 147, 154, 112, 125, 12, 170, 247, 143, 245, 11, 112, 107, 86, 54, 150, 223, 229, 44, 245, 49, 104, 85, 211, 250, 159, 181, 171, 87, 226, 111, 204, 180, 221, 244, 189, 189, 179, 195, 29, 1, 40, 54, 70, 28, 36, 181, 29, 203, 138, 251, 240, 238, 227, 3, 238, 75, 82, 250, 218, 155, 221, 199, 39, 155, 232, 206, 113, 27, 200, 252, 26, 25, 213, 161, 146, 169, 104, 7, 193, 61, 32, 175, 84, 15, 77, 14, 234, 46, 173, 119 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 0, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 1, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
