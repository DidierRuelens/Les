using Microsoft.EntityFrameworkCore.Migrations;

namespace Les.Migrations
{
    public partial class newPropertyInCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test2",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test2",
                table: "Customer");
        }
    }
}
