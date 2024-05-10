using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class spellchecknowpls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawyers_lawyerId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLawyer_Lawyers_lawyerId",
                table: "EducationLawyer");

            migrationBuilder.RenameColumn(
                name: "lawyerId",
                table: "EducationLawyer",
                newName: "LawyerId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationLawyer_lawyerId",
                table: "EducationLawyer",
                newName: "IX_EducationLawyer_LawyerId");

            migrationBuilder.RenameColumn(
                name: "lawyerId",
                table: "AppliedServices",
                newName: "LawyerId");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedServices_lawyerId",
                table: "AppliedServices",
                newName: "IX_AppliedServices_LawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Lawyers_LawyerId",
                table: "AppliedServices",
                column: "LawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLawyer_Lawyers_LawyerId",
                table: "EducationLawyer",
                column: "LawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppliedServices_Lawyers_LawyerId",
                table: "AppliedServices");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLawyer_Lawyers_LawyerId",
                table: "EducationLawyer");

            migrationBuilder.RenameColumn(
                name: "LawyerId",
                table: "EducationLawyer",
                newName: "lawyerId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationLawyer_LawyerId",
                table: "EducationLawyer",
                newName: "IX_EducationLawyer_lawyerId");

            migrationBuilder.RenameColumn(
                name: "LawyerId",
                table: "AppliedServices",
                newName: "lawyerId");

            migrationBuilder.RenameIndex(
                name: "IX_AppliedServices_LawyerId",
                table: "AppliedServices",
                newName: "IX_AppliedServices_lawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppliedServices_Lawyers_lawyerId",
                table: "AppliedServices",
                column: "lawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLawyer_Lawyers_lawyerId",
                table: "EducationLawyer",
                column: "lawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
