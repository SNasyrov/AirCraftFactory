using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirCraftFactory.Migrations
{
    public partial class AddFieldAuthorizationCodeForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorizationCode",
                table: "User",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorizationCode",
                table: "User");
        }
    }
}
