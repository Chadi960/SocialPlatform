using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class PostAndCommentFKchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Persons_PersonId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Persons_PersonId",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Post",
                newName: "PersonFK");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonId",
                table: "Post",
                newName: "IX_Post_PersonFK");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Comment",
                newName: "PostFK");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Comment",
                newName: "PersonFK");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                newName: "IX_Comment_PostFK");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PersonId",
                table: "Comment",
                newName: "IX_Comment_PersonFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Persons_PersonFK",
                table: "Comment",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostFK",
                table: "Comment",
                column: "PostFK",
                principalTable: "Post",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Persons_PersonFK",
                table: "Post",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Persons_PersonFK",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostFK",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Persons_PersonFK",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "PersonFK",
                table: "Post",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonFK",
                table: "Post",
                newName: "IX_Post_PersonId");

            migrationBuilder.RenameColumn(
                name: "PostFK",
                table: "Comment",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "PersonFK",
                table: "Comment",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostFK",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PersonFK",
                table: "Comment",
                newName: "IX_Comment_PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Persons_PersonId",
                table: "Comment",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Persons_PersonId",
                table: "Post",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
