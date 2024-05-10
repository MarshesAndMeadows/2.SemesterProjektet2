using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class spellcheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicePreformed",
                table: "AppliedServices",
                newName: "ServicePerformed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicePerformed",
                table: "AppliedServices",
                newName: "ServicePreformed");
        }
    }
}
