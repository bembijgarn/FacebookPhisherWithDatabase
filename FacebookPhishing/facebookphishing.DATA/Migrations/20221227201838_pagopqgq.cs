using Microsoft.EntityFrameworkCore.Migrations;

namespace facebookphishing.DATA.Migrations
{
    public partial class pagopqgq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "Name");
        }
    }
}
