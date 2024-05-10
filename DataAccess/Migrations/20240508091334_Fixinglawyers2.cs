using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Fixinglawyers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Lawers_lawyerEmployeeId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_lawyerEmployeeId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "lawyerEmployeeId",
                table: "Educations");

            migrationBuilder.CreateTable(
                name: "EducationLawyer",
                columns: table => new
                {
                    EducationsEducationId = table.Column<int>(type: "int", nullable: false),
                    lawyerEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLawyer", x => new { x.EducationsEducationId, x.lawyerEmployeeId });
                    table.ForeignKey(
                        name: "FK_EducationLawyer_Educations_EducationsEducationId",
                        column: x => x.EducationsEducationId,
                        principalTable: "Educations",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationLawyer_Lawers_lawyerEmployeeId",
                        column: x => x.lawyerEmployeeId,
                        principalTable: "Lawers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationLawyer_lawyerEmployeeId",
                table: "EducationLawyer",
                column: "lawyerEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationLawyer");

            migrationBuilder.AddColumn<int>(
                name: "lawyerEmployeeId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_lawyerEmployeeId",
                table: "Educations",
                column: "lawyerEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Lawers_lawyerEmployeeId",
                table: "Educations",
                column: "lawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
