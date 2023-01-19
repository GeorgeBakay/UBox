using Microsoft.EntityFrameworkCore.Migrations;

namespace UBox.Migrations
{
    public partial class ini10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Posts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AvatarImages",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AvatarImages",
                newName: "id");
        }
    }
}
