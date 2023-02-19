using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeYourself.Migrations
{
    public partial class Iuuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clients_physiques_BuildTypeId",
                table: "clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_physiques",
                table: "physiques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clients",
                table: "clients");

            migrationBuilder.DropIndex(
                name: "IX_clients_BuildTypeId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "BuildTypeId",
                table: "clients");

            migrationBuilder.RenameTable(
                name: "physiques",
                newName: "Physiques");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "PhysiqueId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Physiques",
                table: "Physiques",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PhysiqueId",
                table: "Clients",
                column: "PhysiqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Physiques_PhysiqueId",
                table: "Clients",
                column: "PhysiqueId",
                principalTable: "Physiques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Physiques_PhysiqueId",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Physiques",
                table: "Physiques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_PhysiqueId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PhysiqueId",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Physiques",
                newName: "physiques");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "clients");

            migrationBuilder.AddColumn<int>(
                name: "BuildTypeId",
                table: "clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_physiques",
                table: "physiques",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clients",
                table: "clients",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_clients_BuildTypeId",
                table: "clients",
                column: "BuildTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_clients_physiques_BuildTypeId",
                table: "clients",
                column: "BuildTypeId",
                principalTable: "physiques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
