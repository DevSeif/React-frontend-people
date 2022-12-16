using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkUppgift.Migrations
{
    public partial class Addedbirthdateandadmincheckbox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22dfe03b-d653-4d75-9cdc-08a2fafcc9b6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96d7ae48-f9f3-4eea-84be-25d17d446829", "a89f9ba8-e68a-4eba-a8a9-f98831e83af5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96d7ae48-f9f3-4eea-84be-25d17d446829");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a89f9ba8-e68a-4eba-a8a9-f98831e83af5");

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CheckAdmin",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09e7bc73-36a6-4787-a11b-bad9c3b931b0", "6b8c16b5-3a10-4b7b-b541-cadc5be09930", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffcc3a6b-4f94-4d76-8a29-59a09d1e7e50", "158333e5-72c1-41e1-8369-346ea740fe7f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "CheckAdmin", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0093be2c-cc92-4c6d-b49d-20750c2911b7", 0, "2000-01-01", false, "6ac700c5-872b-4517-a6bf-0d1871fd370d", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEE2gpNiI6AhVFgYfN01givXnQ5WyFQOxZiA/s1zRMzbjdFvvTpx46D6jOKq6PUV5Jw==", null, false, "fa3387e4-b5a3-4b8a-b031-4ad7b334f488", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffcc3a6b-4f94-4d76-8a29-59a09d1e7e50", "0093be2c-cc92-4c6d-b49d-20750c2911b7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e7bc73-36a6-4787-a11b-bad9c3b931b0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffcc3a6b-4f94-4d76-8a29-59a09d1e7e50", "0093be2c-cc92-4c6d-b49d-20750c2911b7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffcc3a6b-4f94-4d76-8a29-59a09d1e7e50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093be2c-cc92-4c6d-b49d-20750c2911b7");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CheckAdmin",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22dfe03b-d653-4d75-9cdc-08a2fafcc9b6", "64204c5a-5c34-4985-a8a7-8841d3176bbf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96d7ae48-f9f3-4eea-84be-25d17d446829", "1e6dc361-b263-42e6-95f7-eca4e850a295", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a89f9ba8-e68a-4eba-a8a9-f98831e83af5", 0, "86c6de9d-b0cf-4738-8853-756c7faabd4f", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEPG4Gu3H9/6CUGrxVS6tUN0+bJBT3FiZreHlhnrSmT5hHV5qe5Rn+MnIDNBUj7JrqA==", null, false, "647d736e-e1e7-4aed-839b-7227a31f98db", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "96d7ae48-f9f3-4eea-84be-25d17d446829", "a89f9ba8-e68a-4eba-a8a9-f98831e83af5" });
        }
    }
}
