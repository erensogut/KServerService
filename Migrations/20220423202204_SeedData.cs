using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KServerService.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileHash",
                table: "Files",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "cc621b68-b0a8-4515-ba29-345718a96155", "admin@kserver.com", false, false, null, null, "MYUSER", "AQAAAAEAACcQAAAAEO/iYNokV+Rp451j472bA3WTkKI/6YOjD01B3uCz7hXKDu73fpN48+fnoUQnUXaI6w==", null, false, "581b7895-3b8c-4f24-a1c4-0cc1d237eaae", false, "firstUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.AlterColumn<string>(
                name: "FileHash",
                table: "Files",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
