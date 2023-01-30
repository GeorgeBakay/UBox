using Microsoft.EntityFrameworkCore.Migrations;

namespace UBox.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailInfos_AvatarImages_avatarId",
                table: "UserDetailInfos");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailInfos_avatarId",
                table: "UserDetailInfos");

            migrationBuilder.CreateIndex(
                name: "IX_AvatarImages_UserId",
                table: "AvatarImages",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AvatarImages_UserDetailInfos_UserId",
                table: "AvatarImages",
                column: "UserId",
                principalTable: "UserDetailInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvatarImages_UserDetailInfos_UserId",
                table: "AvatarImages");

            migrationBuilder.DropIndex(
                name: "IX_AvatarImages_UserId",
                table: "AvatarImages");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailInfos_avatarId",
                table: "UserDetailInfos",
                column: "avatarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailInfos_AvatarImages_avatarId",
                table: "UserDetailInfos",
                column: "avatarId",
                principalTable: "AvatarImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
