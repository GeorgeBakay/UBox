using Microsoft.EntityFrameworkCore.Migrations;

namespace UBox.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowArrays_UserDetailInfos_UserDetailInfoId",
                table: "FollowArrays");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowArrays_UserDetailInfos_UserDetailInfoId1",
                table: "FollowArrays");

            migrationBuilder.DropIndex(
                name: "IX_FollowArrays_UserDetailInfoId",
                table: "FollowArrays");

            migrationBuilder.DropIndex(
                name: "IX_FollowArrays_UserDetailInfoId1",
                table: "FollowArrays");

            migrationBuilder.DropColumn(
                name: "UserDetailInfoId",
                table: "FollowArrays");

            migrationBuilder.DropColumn(
                name: "UserDetailInfoId1",
                table: "FollowArrays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserDetailInfoId",
                table: "FollowArrays",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDetailInfoId1",
                table: "FollowArrays",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FollowArrays_UserDetailInfoId",
                table: "FollowArrays",
                column: "UserDetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowArrays_UserDetailInfoId1",
                table: "FollowArrays",
                column: "UserDetailInfoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FollowArrays_UserDetailInfos_UserDetailInfoId",
                table: "FollowArrays",
                column: "UserDetailInfoId",
                principalTable: "UserDetailInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowArrays_UserDetailInfos_UserDetailInfoId1",
                table: "FollowArrays",
                column: "UserDetailInfoId1",
                principalTable: "UserDetailInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
