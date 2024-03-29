using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGAS.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGENDA",
                columns: table => new
                {
                    AGDA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AGDA_DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AGDA_DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AGDA_ID_UNIDADEVENDA = table.Column<int>(type: "int", nullable: true),
                    AGDA_PRESENCA = table.Column<int>(type: "int", nullable: false),
                    AGDA_ID_MOTIVO = table.Column<int>(type: "int", nullable: false),
                    AGDA_OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGDA", x => x.AGDA_ID);
                });

            migrationBuilder.CreateTable(
                name: "AGENDAMENTO",
                columns: table => new
                {
                    AGMT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AGMT_DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AGMT_DATA_FINAL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AGMT_DIA_INTEIRO = table.Column<bool>(type: "bit", nullable: false),
                    AGMT_VISITA_EM_CASA = table.Column<bool>(type: "bit", nullable: false),
                    AGMT_STATUS = table.Column<int>(type: "int", nullable: false),
                    AGMT_ID_RESP_SERVICO = table.Column<int>(type: "int", nullable: false),
                    AGMT_ID_ATENDENTE = table.Column<int>(type: "int", nullable: false),
                    AGMT_ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    AGMT_ID_UNIDADEVENDA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGMT", x => x.AGMT_ID);
                });

            migrationBuilder.CreateTable(
                name: "CARGO",
                columns: table => new
                {
                    CARG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARG_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CARG_ATIVO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARG", x => x.CARG_ID);
                });

            migrationBuilder.CreateTable(
                name: "CARGO_FUNCIONARIO",
                columns: table => new
                {
                    CGFN_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CGFN_ID_FUNCIONARIO = table.Column<int>(type: "int", nullable: false),
                    CGFN_ID_CARGO = table.Column<int>(type: "int", nullable: false),
                    CGFN_DATA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CGFN_DATA_FIM = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CGFN", x => x.CGFN_ID);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    CATE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATE_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATE", x => x.CATE_ID);
                });

            migrationBuilder.CreateTable(
                name: "CEP",
                columns: table => new
                {
                    CEP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP_NUMERO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_LOGRADOURO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_COMPLEMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    CEP_LOCALIDADE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_POSSUI_CADASTRO = table.Column<bool>(type: "bit", nullable: false),
                    CEP_BAIRRO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP_IBGE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CEP", x => x.CEP_ID);
                });

            migrationBuilder.CreateTable(
                name: "CIDADE",
                columns: table => new
                {
                    CIDA_ID = table.Column<int>(type: "int", nullable: false),
                    CIDA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIDA_ID_MICROREGIAO = table.Column<int>(type: "int", nullable: false),
                    CIDA_ID_ESTADO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    CLIE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLIE_ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    CLIE_CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLIE_RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLIE_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLIE_DATA_NASCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIE", x => x.CLIE_ID);
                });

            migrationBuilder.CreateTable(
                name: "EMPRESA",
                columns: table => new
                {
                    EMPR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPR_ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    EMPR_CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPR_NOME_FANTASIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPR_RAZAO_SOCIAL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPR", x => x.EMPR_ID);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO",
                columns: table => new
                {
                    ENDE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENDE_LOGRADOURO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDE_NUMERO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDE_BAIRRO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDE_COMPLEMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDE_CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDE_ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ENDE_ID_PESSOA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDE", x => x.ENDE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ESTADO",
                columns: table => new
                {
                    EST_ID = table.Column<int>(type: "int", nullable: false),
                    EST_SIGLA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EST_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EST_ID_REGIAO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FORNECEDOR",
                columns: table => new
                {
                    FORN_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORN_ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    FORN_CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FORN_NOME_FANTASIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FORN_RAZAO_SOCIAL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORN", x => x.FORN_ID);
                });

            migrationBuilder.CreateTable(
                name: "FUNCAO",
                columns: table => new
                {
                    FUNC_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUNC_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FUNC_NORMALIZED_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FUNC_CONCURRENCY_TEMP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNC", x => x.FUNC_ID);
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIO",
                columns: table => new
                {
                    FNCR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FNCR_ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    FNCR_CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FNCR_RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FNCR_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FNCR_DATA_NASCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FNCR", x => x.FNCR_ID);
                });

            migrationBuilder.CreateTable(
                name: "HISTORICO_EVENTO",
                columns: table => new
                {
                    HSTE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HSTE_CODIGO = table.Column<int>(type: "int", nullable: false),
                    HSTE_NOMETABELA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSTE_COD_USUARIO = table.Column<int>(type: "int", nullable: false),
                    HSTE_DT_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HSTE_PK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSTE_DADOS_ANTIGOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSTE_DADOS_NOVOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSTE_TP_OPERACAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSTE", x => x.HSTE_ID);
                });

            migrationBuilder.CreateTable(
                name: "ITEM_VENDA",
                columns: table => new
                {
                    ITVD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITVD_ID_PRODUTO = table.Column<int>(type: "int", nullable: false),
                    ITVD_QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    ITVD_VALOR_UNITARIO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ITVD_VALOR_TOTAL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ITVD_DESCONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ITVD_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ITVD_DATA_ATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ITVD_ID_VENDA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITVD", x => x.ITVD_ID);
                });

            migrationBuilder.CreateTable(
                name: "MESO_REGIAO",
                columns: table => new
                {
                    MSRG_ID = table.Column<int>(type: "int", nullable: false),
                    MSRG_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSRG_ID_ESTADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MICRO_REGIAO",
                columns: table => new
                {
                    MCRG_ID = table.Column<int>(type: "int", nullable: false),
                    MCRG_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MCRG_ID_MESO_REGIAO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MOTIVO",
                columns: table => new
                {
                    MOTI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MOTI_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOTI", x => x.MOTI_ID);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    PESS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PESS_ESTRANGEIRO = table.Column<bool>(type: "bit", nullable: false),
                    PESS_OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PESS_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PESS_DATA_ALTERACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PESS_TELEFONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PESS_CELULAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PESS_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PESS_ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESS", x => x.PESS_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROD_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROD_DATA_ATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROD_PRECO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PROD_ATIVO = table.Column<bool>(type: "bit", nullable: true),
                    PROD_ID_CATEGORIA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROD", x => x.PROD_ID);
                });

            migrationBuilder.CreateTable(
                name: "REGIAO",
                columns: table => new
                {
                    REGI_ID = table.Column<int>(type: "int", nullable: false),
                    REGI_SIGLA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGI_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERVICO",
                columns: table => new
                {
                    SERV_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERV_ID_AGENDAMENTO = table.Column<int>(type: "int", nullable: false),
                    SERV_ID_RESPONSAVEL = table.Column<int>(type: "int", nullable: false),
                    SERV_COD_SERVICO = table.Column<int>(type: "int", nullable: false),
                    SERV_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SERV_ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    SERV_QTD_PARCELAS = table.Column<int>(type: "int", nullable: false),
                    SERV_VL_TOTAL = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV", x => x.SERV_ID);
                });

            migrationBuilder.CreateTable(
                name: "UNIDADE_VENDA",
                columns: table => new
                {
                    UNVD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UNVD_ID_EMPRESA = table.Column<int>(type: "int", nullable: false),
                    UNVD_ID_PESSOA = table.Column<int>(type: "int", nullable: false),
                    UNVD_CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVD_NOME_FANTASIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVD_RAZAO_SOCIAL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNVD", x => x.UNVD_ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    USUA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUA_GENERO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_DATA_NASCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUA_NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_DATA_CRIACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUA_DATA_ALTERACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUA_USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_NORMALIZED_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_NORMALIZED_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_EMAIL_CONFIRMED = table.Column<bool>(type: "bit", nullable: false),
                    USUA_PASSWORD_HASH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_SECURITY_TEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_CONCURRENCY_TEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_PHONUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUA_PHONENUMBER_CONFIRMED = table.Column<bool>(type: "bit", nullable: false),
                    USUA_TWOFACTOR_ENABELD = table.Column<bool>(type: "bit", nullable: false),
                    USUA_LOCKOUT_END = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    USUA_LOCKOUT_ENABLED = table.Column<bool>(type: "bit", nullable: false),
                    USUA_ACCESS_FAILED_COUNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUA", x => x.USUA_ID);
                });

            migrationBuilder.CreateTable(
                name: "VENDA",
                columns: table => new
                {
                    VEND_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VEND_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VEND_DESCONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VEND_ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    VEND_ID_FUNCIONARIO = table.Column<int>(type: "int", nullable: true),
                    VEND_ID_UNIDADE_VENDA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEND", x => x.VEND_ID);
                });

            migrationBuilder.CreateTable(
                name: "FUNCAO_USUARIO",
                columns: table => new
                {
                    FNUS_ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    FNUS_ID_FUNCAO = table.Column<int>(type: "int", nullable: false),
                    FUNC_DT_INICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FUNC_DT_FIM = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FNUS", x => new { x.FNUS_ID_FUNCAO, x.FNUS_ID_USUARIO });
                    table.ForeignKey(
                        name: "FK_FUNCAO_USUARIO_USUARIO_FNUS_ID_USUARIO",
                        column: x => x.FNUS_ID_USUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "USUA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FUNCAO_USUARIO_FNUS_ID_USUARIO",
                table: "FUNCAO_USUARIO",
                column: "FNUS_ID_USUARIO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGENDA");

            migrationBuilder.DropTable(
                name: "AGENDAMENTO");

            migrationBuilder.DropTable(
                name: "CARGO");

            migrationBuilder.DropTable(
                name: "CARGO_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "CATEGORIA");

            migrationBuilder.DropTable(
                name: "CEP");

            migrationBuilder.DropTable(
                name: "CIDADE");

            migrationBuilder.DropTable(
                name: "CLIENTE");

            migrationBuilder.DropTable(
                name: "EMPRESA");

            migrationBuilder.DropTable(
                name: "ENDERECO");

            migrationBuilder.DropTable(
                name: "ESTADO");

            migrationBuilder.DropTable(
                name: "FORNECEDOR");

            migrationBuilder.DropTable(
                name: "FUNCAO");

            migrationBuilder.DropTable(
                name: "FUNCAO_USUARIO");

            migrationBuilder.DropTable(
                name: "FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "HISTORICO_EVENTO");

            migrationBuilder.DropTable(
                name: "ITEM_VENDA");

            migrationBuilder.DropTable(
                name: "MESO_REGIAO");

            migrationBuilder.DropTable(
                name: "MICRO_REGIAO");

            migrationBuilder.DropTable(
                name: "MOTIVO");

            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "REGIAO");

            migrationBuilder.DropTable(
                name: "SERVICO");

            migrationBuilder.DropTable(
                name: "UNIDADE_VENDA");

            migrationBuilder.DropTable(
                name: "VENDA");

            migrationBuilder.DropTable(
                name: "USUARIO");
        }
    }
}
