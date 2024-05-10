using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class TPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Employees_LawyerEmployeeId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Employees_LawyerEmployeeId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "Lawers",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawers", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Lawers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Lawers_LawyerEmployeeId",
                table: "AppliedServices",
                column: "LawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Lawers_LawyerEmployeeId",
                table: "Educations",
                column: "LawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawers_LawyerEmployeeId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Lawers_LawyerEmployeeId",
                table: "Educations");

            migrationBuilder.DropTable(
                name: "Lawers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Employees_LawyerEmployeeId",
                table: "AppliedServices",
                column: "LawyerEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Employees_LawyerEmployeeId",
                table: "Educations",
                column: "LawyerEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
