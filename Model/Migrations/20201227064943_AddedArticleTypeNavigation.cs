using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class AddedArticleTypeNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleTypes_TypeNavigationId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TypeNavigationId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TypeNavigationId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Articles",
                newName: "ArticleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleTypeId",
                table: "Articles",
                column: "ArticleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleTypes_ArticleTypeId",
                table: "Articles",
                column: "ArticleTypeId",
                principalTable: "ArticleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleTypes_ArticleTypeId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleTypeId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ArticleTypeId",
                table: "Articles",
                newName: "TypeId");

            migrationBuilder.AddColumn<int>(
                name: "TypeNavigationId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TypeNavigationId",
                table: "Articles",
                column: "TypeNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleTypes_TypeNavigationId",
                table: "Articles",
                column: "TypeNavigationId",
                principalTable: "ArticleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
