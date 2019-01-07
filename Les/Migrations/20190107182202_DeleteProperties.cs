using Microsoft.EntityFrameworkCore.Migrations;

namespace Les.Migrations
{
    public partial class DeleteProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Test2",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Test2",
                table: "Customer",
                nullable: true);
        }
    }
}
