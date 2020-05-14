using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGPag.Repositorio.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AreaCurto = table.Column<string>(maxLength: 50, nullable: false),
                    AreaLongo = table.Column<string>(maxLength: 50, nullable: false),
                    AreaAtivo = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmpresaCurto = table.Column<string>(maxLength: 50, nullable: false),
                    EmpresaLongo = table.Column<string>(maxLength: 50, nullable: false),
                    EmpresaAtivo = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UF = table.Column<string>(maxLength: 5, nullable: false),
                    NomeEstado = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    User = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeSap = table.Column<string>(nullable: true),
                    NomeCnpj = table.Column<string>(nullable: true),
                    Identidade = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TipoPessoa = table.Column<string>(nullable: true),
                    CpfCnpj = table.Column<string>(nullable: true),
                    CodSap = table.Column<int>(nullable: false),
                    InscMunicipal = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    EstadoId = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Terouraria = table.Column<string>(nullable: true),
                    Ativo = table.Column<string>(nullable: true),
                    NomeSocio1 = table.Column<string>(nullable: true),
                    TelefoneSocio1 = table.Column<string>(nullable: true),
                    EmailSocio1 = table.Column<string>(nullable: true),
                    NomeSocio2 = table.Column<string>(nullable: true),
                    TelefoneSocio2 = table.Column<string>(nullable: true),
                    EmailSocio2 = table.Column<string>(nullable: true),
                    NomeFinanceiro1 = table.Column<string>(nullable: true),
                    TelefoneFinanceiro1 = table.Column<string>(nullable: true),
                    EmailFinanceiro1 = table.Column<string>(nullable: true),
                    NomeFinanceiro2 = table.Column<string>(nullable: true),
                    TelefoneFinanceiro2 = table.Column<string>(nullable: true),
                    EmailFinanceiro2 = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_EstadoId",
                table: "Fornecedores",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_UsuarioId",
                table: "Fornecedores",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
