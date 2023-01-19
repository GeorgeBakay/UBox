using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBox.Migrations
{
    public partial class ini8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserFollowersId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserFollowersId1",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostFilePath = table.Column<string>(nullable: false),
                    FileType = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFollowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFollowers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserFollowersId",
                table: "Users",
                column: "UserFollowersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserFollowersId1",
                table: "Users",
                column: "UserFollowersId1");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowers_UserId",
                table: "UserFollowers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserFollowers_UserFollowersId",
                table: "Users",
                column: "UserFollowersId",
                principalTable: "UserFollowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserFollowers_UserFollowersId1",
                table: "Users",
                column: "UserFollowersId1",
                principalTable: "UserFollowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserFollowers_UserFollowersId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserFollowers_UserFollowersId1",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "UserFollowers");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserFollowersId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserFollowersId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserFollowersId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserFollowersId1",
                table: "Users");
        }
    }
}
