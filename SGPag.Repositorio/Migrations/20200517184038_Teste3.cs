using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGPag.Repositorio.Migrations
{
    public partial class Teste3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Areas");

            migrationBuilder.RenameColumn(
                name: "Sgpag_ant",
                table: "Contrato",
                newName: "SgpagAnt");

            migrationBuilder.RenameColumn(
                name: "Controle_aditivos",
                table: "Contrato",
                newName: "ControleAditivos");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Assinatura",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "SgpagAnt",
                table: "Contrato",
                newName: "Sgpag_ant");

            migrationBuilder.RenameColumn(
                name: "ControleAditivos",
                table: "Contrato",
                newName: "Controle_aditivos");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuarios",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Usuarios",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Fornecedores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Fornecedores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Estados",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Estados",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Empresas",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Empresas",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Assinatura",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Contrato",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contrato",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Areas",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Areas",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
