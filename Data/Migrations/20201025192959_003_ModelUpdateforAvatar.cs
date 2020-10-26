using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CFClientList.Data.Migrations
{
    public partial class _003_ModelUpdateforAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Avatar",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Contacts");
        }
    }
}
