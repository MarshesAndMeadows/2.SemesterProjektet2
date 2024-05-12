using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddedForekeyProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Clients_ClientID",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Cases",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_ClientID",
                table: "Cases",
                newName: "IX_Cases_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Clients_ClientId",
                table: "Cases",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Clients_ClientId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Cases",
                newName: "ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_ClientId",
                table: "Cases",
                newName: "IX_Cases_ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Clients_ClientID",
                table: "Cases",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
