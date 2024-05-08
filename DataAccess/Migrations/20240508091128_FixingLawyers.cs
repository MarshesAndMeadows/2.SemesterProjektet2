using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FixingLawyers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawers_LawyerEmployeeId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Lawers_LawyerEmployeeId",
                table: "Educations");

            migrationBuilder.RenameColumn(
                name: "LawyerEmployeeId",
                table: "Educations",
                newName: "lawyerEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_LawyerEmployeeId",
                table: "Educations",
                newName: "IX_Educations_lawyerEmployeeId");

            migrationBuilder.RenameColumn(
                name: "LawyerEmployeeId",
                table: "AppliedServices",
                newName: "lawyerEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedServices_LawyerEmployeeId",
                table: "AppliedServices",
                newName: "IX_AppliedServices_lawyerEmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "lawyerEmployeeId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "lawyerEmployeeId",
                table: "AppliedServices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Lawers_lawyerEmployeeId",
                table: "AppliedServices",
                column: "lawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Lawers_lawyerEmployeeId",
                table: "Educations",
                column: "lawyerEmployeeId",
                principalTable: "Lawers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawers_lawyerEmployeeId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Lawers_lawyerEmployeeId",
                table: "Educations");

            migrationBuilder.RenameColumn(
                name: "lawyerEmployeeId",
                table: "Educations",
                newName: "LawyerEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_lawyerEmployeeId",
                table: "Educations",
                newName: "IX_Educations_LawyerEmployeeId");

            migrationBuilder.RenameColumn(
                name: "lawyerEmployeeId",
                table: "AppliedServices",
                newName: "LawyerEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedServices_lawyerEmployeeId",
                table: "AppliedServices",
                newName: "IX_AppliedServices_LawyerEmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "LawyerEmployeeId",
                table: "Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LawyerEmployeeId",
                table: "AppliedServices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
