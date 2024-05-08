using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class ChangedIdNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawers_lawyerEmployeeId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLawyer_Educations_EducationsEducationId",
                table: "EducationLawyer");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLawyer_Lawers_lawyerEmployeeId",
                table: "EducationLawyer");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawers_Employees_EmployeeId",
                table: "Lawers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lawers",
                table: "Lawers");

            migrationBuilder.RenameTable(
                name: "Lawers",
                newName: "Lawyers");

            migrationBuilder.RenameColumn(
                name: "UnitTypeId",
                table: "UnitTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Services",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EducationId",
                table: "Educations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "lawyerEmployeeId",
                table: "EducationLawyer",
                newName: "lawyerId");

            migrationBuilder.RenameColumn(
                name: "EducationsEducationId",
                table: "EducationLawyer",
                newName: "EducationsId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationLawyer_lawyerEmployeeId",
                table: "EducationLawyer",
                newName: "IX_EducationLawyer_lawyerId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "Cases",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "lawyerEmployeeId",
                table: "AppliedServices",
                newName: "lawyerId");

            migrationBuilder.RenameColumn(
                name: "AppliedServiceId",
                table: "AppliedServices",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedServices_lawyerEmployeeId",
                table: "AppliedServices",
                newName: "IX_AppliedServices_lawyerId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Lawyers",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lawyers",
                table: "Lawyers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Lawyers_lawyerId",
                table: "AppliedServices",
                column: "lawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLawyer_Educations_EducationsId",
                table: "EducationLawyer",
                column: "EducationsId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLawyer_Lawyers_lawyerId",
                table: "EducationLawyer",
                column: "lawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_Employees_Id",
                table: "Lawyers",
                column: "Id",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawyers_lawyerId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLawyer_Educations_EducationsId",
                table: "EducationLawyer");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLawyer_Lawyers_lawyerId",
                table: "EducationLawyer");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_Employees_Id",
                table: "Lawyers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lawyers",
                table: "Lawyers");

            migrationBuilder.RenameTable(
                name: "Lawyers",
                newName: "Lawers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UnitTypes",
                newName: "UnitTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Services",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Educations",
                newName: "EducationId");

            migrationBuilder.RenameColumn(
                name: "lawyerId",
                table: "EducationLawyer",
                newName: "lawyerEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EducationsId",
                table: "EducationLawyer",
                newName: "EducationsEducationId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationLawyer_lawyerId",
                table: "EducationLawyer",
                newName: "IX_EducationLawyer_lawyerEmployeeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cases",
                newName: "CaseId");

            migrationBuilder.RenameColumn(
                name: "lawyerId",
                table: "AppliedServices",
                newName: "lawyerEmployeeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AppliedServices",
                newName: "AppliedServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedServices_lawyerId",
                table: "AppliedServices",
                newName: "IX_AppliedServices_lawyerEmployeeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lawers",
                newName: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lawers",
                table: "Lawers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Lawers_lawyerEmployeeId",
                table: "AppliedServices",
                column: "lawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLawyer_Educations_EducationsEducationId",
                table: "EducationLawyer",
                column: "EducationsEducationId",
                principalTable: "Educations",
                principalColumn: "EducationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLawyer_Lawers_lawyerEmployeeId",
                table: "EducationLawyer",
                column: "lawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lawers_Employees_EmployeeId",
                table: "Lawers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
