using Microsoft.EntityFrameworkCore.Migrations;

namespace StrattonOakmontServices.Migrations
{
    public partial class security : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyIMG",
                table: "Securities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyIMG",
                table: "Securities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
