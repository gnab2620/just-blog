using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FA.JustBlog.Web.Data.Migrations
{
    public partial class RemoveTagVMAndCateVM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_GetLastestPostVM_GetLastestPostVMId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "CategoryVM");

            migrationBuilder.DropTable(
                name: "GetLastestPostVM");

            migrationBuilder.DropTable(
                name: "TagVM");

            migrationBuilder.DropIndex(
                name: "IX_Tags_GetLastestPostVMId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "GetLastestPostVMId",
                table: "Tags");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GetLastestPostVMId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GetLastestPostVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PostOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RateCount = table.Column<int>(type: "int", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetLastestPostVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetLastestPostVM_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GetLastestPostVM_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagVM", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_GetLastestPostVMId",
                table: "Tags",
                column: "GetLastestPostVMId");

            migrationBuilder.CreateIndex(
                name: "IX_GetLastestPostVM_CategoryId",
                table: "GetLastestPostVM",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GetLastestPostVM_UserId",
                table: "GetLastestPostVM",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_GetLastestPostVM_GetLastestPostVMId",
                table: "Tags",
                column: "GetLastestPostVMId",
                principalTable: "GetLastestPostVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
