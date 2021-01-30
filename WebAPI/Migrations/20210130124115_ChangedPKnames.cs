using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class ChangedPKnames : Migration
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

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Post",
                newName: "PostID");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Persons",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Genders",
                newName: "PersonFK");

            migrationBuilder.RenameIndex(
                name: "IX_Genders_PersonId",
                table: "Genders",
                newName: "IX_Genders_PersonFK");

            migrationBuilder.RenameColumn(
                name: "ContactInfoId",
                table: "ContactInfos",
                newName: "ContactInfoID");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "ContactInfos",
                newName: "PersonFK");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInfos_PersonId",
                table: "ContactInfos",
                newName: "IX_ContactInfos_PersonFK");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comment",
                newName: "CommentID");

            migrationBuilder.RenameColumn(
                name: "PersonsPersonId",
                table: "AddressPerson",
                newName: "PersonsPersonID");

            migrationBuilder.RenameColumn(
                name: "AddressesAddressId",
                table: "AddressPerson",
                newName: "AddressesAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_AddressPerson_PersonsPersonId",
                table: "AddressPerson",
                newName: "IX_AddressPerson_PersonsPersonID");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Addresses",
                newName: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressPerson_Addresses_AddressesAddressID",
                table: "AddressPerson",
                column: "AddressesAddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressPerson_Persons_PersonsPersonID",
                table: "AddressPerson",
                column: "PersonsPersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_Persons_PersonFK",
                table: "ContactInfos",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Persons_PersonFK",
                table: "Genders",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressPerson_Addresses_AddressesAddressID",
                table: "AddressPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressPerson_Persons_PersonsPersonID",
                table: "AddressPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_Persons_PersonFK",
                table: "ContactInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Persons_PersonFK",
                table: "Genders");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Post",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Persons",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "PersonFK",
                table: "Genders",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Genders_PersonFK",
                table: "Genders",
                newName: "IX_Genders_PersonId");

            migrationBuilder.RenameColumn(
                name: "ContactInfoID",
                table: "ContactInfos",
                newName: "ContactInfoId");

            migrationBuilder.RenameColumn(
                name: "PersonFK",
                table: "ContactInfos",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInfos_PersonFK",
                table: "ContactInfos",
                newName: "IX_ContactInfos_PersonId");

            migrationBuilder.RenameColumn(
                name: "CommentID",
                table: "Comment",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "PersonsPersonID",
                table: "AddressPerson",
                newName: "PersonsPersonId");

            migrationBuilder.RenameColumn(
                name: "AddressesAddressID",
                table: "AddressPerson",
                newName: "AddressesAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_AddressPerson_PersonsPersonID",
                table: "AddressPerson",
                newName: "IX_AddressPerson_PersonsPersonId");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Addresses",
                newName: "AddressId");

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
        }
    }
}
