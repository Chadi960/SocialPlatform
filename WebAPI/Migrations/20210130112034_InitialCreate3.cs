using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressPerson_Addresses_AddressesAddressId",
                table: "AddressPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressPerson_Persons_PersonsPersonId",
                table: "AddressPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_Persons_PersonId",
                table: "ContactInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Persons_PersonId",
                table: "Genders");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressPerson_Addresses_AddressesAddressId",
                table: "AddressPerson",
                column: "AddressesAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressPerson_Persons_PersonsPersonId",
                table: "AddressPerson",
                column: "PersonsPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_Persons_PersonId",
                table: "ContactInfos",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Persons_PersonId",
                table: "Genders",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressPerson_Addresses_AddressesAddressId",
                table: "AddressPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressPerson_Persons_PersonsPersonId",
                table: "AddressPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_Persons_PersonId",
                table: "ContactInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Persons_PersonId",
                table: "Genders");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressPerson_Addresses_AddressesAddressId",
                table: "AddressPerson",
                column: "AddressesAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressPerson_Persons_PersonsPersonId",
                table: "AddressPerson",
                column: "PersonsPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_Persons_PersonId",
                table: "ContactInfos",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Persons_PersonId",
                table: "Genders",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Persons_PersonId",
                table: "Posts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
