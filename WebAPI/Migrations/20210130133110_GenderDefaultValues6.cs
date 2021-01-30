using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class GenderDefaultValues6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Persons_PersonFK",
                table: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Genders_PersonFK",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "PersonFK",
                table: "Genders");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Gender",
                table: "Persons",
                column: "Gender");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Genders_Gender",
                table: "Persons",
                column: "Gender",
                principalTable: "Genders",
                principalColumn: "GendersID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Genders_Gender",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_Gender",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonFK",
                table: "Genders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Genders_PersonFK",
                table: "Genders",
                column: "PersonFK",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Persons_PersonFK",
                table: "Genders",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
