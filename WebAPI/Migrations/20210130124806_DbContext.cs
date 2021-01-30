using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class DbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonFK",
                table: "Posts",
                newName: "IX_Posts_PersonFK");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostFK",
                table: "Comments",
                newName: "IX_Comments_PostFK");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PersonFK",
                table: "Comments",
                newName: "IX_Comments_PersonFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "PostID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Persons_PersonFK",
                table: "Comments",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostFK",
                table: "Comments",
                column: "PostFK",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Persons_PersonFK",
                table: "Posts",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Persons_PersonFK",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostFK",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Persons_PersonFK",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_PersonFK",
                table: "Post",
                newName: "IX_Post_PersonFK");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostFK",
                table: "Comment",
                newName: "IX_Comment_PostFK");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PersonFK",
                table: "Comment",
                newName: "IX_Comment_PersonFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "PostID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Persons_PersonFK",
                table: "Comment",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostFK",
                table: "Comment",
                column: "PostFK",
                principalTable: "Post",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Persons_PersonFK",
                table: "Post",
                column: "PersonFK",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
