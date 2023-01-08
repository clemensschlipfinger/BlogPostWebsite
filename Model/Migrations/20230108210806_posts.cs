using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POSTS_BT",
                columns: table => new
                {
                    POST_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BODY = table.Column<string>(type: "MEDIUMTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LAST_EDITED_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AUTHOR_ID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTS_BT", x => x.POST_ID);
                    table.ForeignKey(
                        name: "FK_POSTS_BT_AspNetUsers_AUTHOR_ID",
                        column: x => x.AUTHOR_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BLOGPOSTS",
                columns: table => new
                {
                    POST_ID = table.Column<int>(type: "int", nullable: false),
                    TITLE = table.Column<string>(type: "varchar(225)", maxLength: 225, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IS_PUBLISHED = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLOGPOSTS", x => x.POST_ID);
                    table.ForeignKey(
                        name: "FK_BLOGPOSTS_POSTS_BT_POST_ID",
                        column: x => x.POST_ID,
                        principalTable: "POSTS_BT",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMMENTS",
                columns: table => new
                {
                    POST_ID = table.Column<int>(type: "int", nullable: false),
                    PARENT_POST_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMMENTS", x => x.POST_ID);
                    table.ForeignKey(
                        name: "FK_COMMENTS_POSTS_BT_PARENT_POST_ID",
                        column: x => x.PARENT_POST_ID,
                        principalTable: "POSTS_BT",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMMENTS_POSTS_BT_POST_ID",
                        column: x => x.POST_ID,
                        principalTable: "POSTS_BT",
                        principalColumn: "POST_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_PARENT_POST_ID",
                table: "COMMENTS",
                column: "PARENT_POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POSTS_BT_AUTHOR_ID",
                table: "POSTS_BT",
                column: "AUTHOR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BLOGPOSTS");

            migrationBuilder.DropTable(
                name: "COMMENTS");

            migrationBuilder.DropTable(
                name: "POSTS_BT");
        }
    }
}
