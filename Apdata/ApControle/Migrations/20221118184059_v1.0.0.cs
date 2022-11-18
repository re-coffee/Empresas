using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApControle.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracao",
                columns: table => new
                {
                    Parametro = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracao", x => x.Parametro);
                });

            migrationBuilder.CreateTable(
                name: "Controle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Database = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortaServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chamado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destinatarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TamanhoBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimoLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instancia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutenticaWindows = table.Column<bool>(type: "bit", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisparosEmail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdControle = table.Column<int>(type: "int", nullable: false),
                    TextoEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destinatarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisparosEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisparosEmail_Controle_IdControle",
                        column: x => x.IdControle,
                        principalTable: "Controle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DisparosEmail_IdControle",
                table: "DisparosEmail",
                column: "IdControle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracao");

            migrationBuilder.DropTable(
                name: "DisparosEmail");

            migrationBuilder.DropTable(
                name: "Servidor");

            migrationBuilder.DropTable(
                name: "Controle");
        }
    }
}
