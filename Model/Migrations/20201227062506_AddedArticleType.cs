using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class AddedArticleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Types_TypeId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TypeId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "TypeNavigationId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArticleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTypes", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleTypes_TypeNavigationId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleTypes");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TypeNavigationId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TypeNavigationId",
                table: "Articles");

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TypeId",
                table: "Articles",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Types_TypeId",
                table: "Articles",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
