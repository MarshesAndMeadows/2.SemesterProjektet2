using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class MoreChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Employees_LawyerId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_LawyerId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "LawyerId",
                table: "Cases");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_EmployeeId",
                table: "Cases",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Employees_EmployeeId",
                table: "Cases",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Employees_EmployeeId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_EmployeeId",
                table: "Cases");

            migrationBuilder.AddColumn<int>(
                name: "LawyerId",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cases_LawyerId",
                table: "Cases",
                column: "LawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Employees_LawyerId",
                table: "Cases",
                column: "LawyerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
