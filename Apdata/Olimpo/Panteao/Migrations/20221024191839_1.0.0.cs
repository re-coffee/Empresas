using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panteao.Migrations
{
    public partial class _100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "adm");

            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Regedit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ini = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cfg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametro",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servidor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria = table.Column<int>(type: "int", nullable: true),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servidor_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Role_IdRole",
                        column: x => x.IdRole,
                        principalSchema: "adm",
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Relatorio",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: true),
                    View = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relatorio_Role_IdRole",
                        column: x => x.IdRole,
                        principalSchema: "adm",
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Role_IdRole",
                        column: x => x.IdRole,
                        principalSchema: "adm",
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdContrato = table.Column<int>(type: "int", nullable: true),
                    IdServidorBanco = table.Column<int>(type: "int", nullable: true),
                    NomeInstancia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Contrato_IdContrato",
                        column: x => x.IdContrato,
                        principalTable: "Contrato",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cliente_Servidor_IdServidorBanco",
                        column: x => x.IdServidorBanco,
                        principalTable: "Servidor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                schema: "adm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: true),
                    IdMenu = table.Column<int>(type: "int", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMenu_Menu_IdMenu",
                        column: x => x.IdMenu,
                        principalSchema: "adm",
                        principalTable: "Menu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoleMenu_Role_IdRole",
                        column: x => x.IdRole,
                        principalSchema: "adm",
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: true),
                    IdServidor = table.Column<int>(type: "int", nullable: true),
                    IdServidorBanco = table.Column<int>(type: "int", nullable: true),
                    IdArquivo = table.Column<int>(type: "int", nullable: true),
                    IdTipoServico = table.Column<int>(type: "int", nullable: true),
                    Caminho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porta = table.Column<int>(type: "int", nullable: true),
                    Build = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstanciaBanco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servico_Arquivo_IdArquivo",
                        column: x => x.IdArquivo,
                        principalTable: "Arquivo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Servico_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Servico_Servidor_IdServidor",
                        column: x => x.IdServidor,
                        principalTable: "Servidor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Servico_Servidor_IdServidorBanco",
                        column: x => x.IdServidorBanco,
                        principalTable: "Servidor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Servico_TipoServico_IdTipoServico",
                        column: x => x.IdTipoServico,
                        principalTable: "TipoServico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdContrato",
                table: "Cliente",
                column: "IdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdServidorBanco",
                table: "Cliente",
                column: "IdServidorBanco");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_IdRole",
                schema: "adm",
                table: "Menu",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Relatorio_IdRole",
                schema: "adm",
                table: "Relatorio",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_IdMenu",
                schema: "adm",
                table: "RoleMenu",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_IdRole",
                schema: "adm",
                table: "RoleMenu",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdArquivo",
                table: "Servico",
                column: "IdArquivo");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdCliente_IdServidor_Porta",
                table: "Servico",
                columns: new[] { "IdCliente", "IdServidor", "Porta" },
                unique: true,
                filter: "[IdCliente] IS NOT NULL AND [IdServidor] IS NOT NULL AND [Porta] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdServidor",
                table: "Servico",
                column: "IdServidor");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdServidorBanco",
                table: "Servico",
                column: "IdServidorBanco");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdTipoServico",
                table: "Servico",
                column: "IdTipoServico");

            migrationBuilder.CreateIndex(
                name: "IX_Servidor_IdCategoria",
                table: "Servidor",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRole",
                schema: "adm",
                table: "Usuario",
                column: "IdRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parametro",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Relatorio",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "RoleMenu",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Arquivo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "TipoServico");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "adm");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Servidor");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
