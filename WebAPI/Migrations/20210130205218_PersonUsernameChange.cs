using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class PersonUsernameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Persons",
                newName: "Username");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Persons",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Genders",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "U",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldDefaultValue: "F");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Username_Password",
                table: "Persons",
                columns: new[] { "Username", "Password" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Persons_Username_Password",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Persons",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Genders",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "F",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldDefaultValue: "U");
        }
    }
}
