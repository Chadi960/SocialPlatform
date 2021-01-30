using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class GenderDefaultValues5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Genders",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "F",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldDefaultValue: "F");

            migrationBuilder.AddColumn<int>(
                name: "GendersID",
                table: "Genders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "GendersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "GendersID",
                table: "Genders");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Genders",
                type: "char(1)",
                nullable: false,
                defaultValue: "F",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldDefaultValue: "F");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Gender");
        }
    }
}
