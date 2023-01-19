using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBox.Migrations
{
    public partial class ini7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldMaxLength: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateCreate",
                table: "Users",
                type: "varchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
