using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CensoErgonomico.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PiorHrExtra = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PiorJornadaNormal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PiorFinalDia = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PiorAtivDomestica = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MelhorNoite = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MelhorFimSemana = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MelhorRevezamento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MelhorFerias = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Medicamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LocaisDores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PescoçoE = table.Column<int>(type: "int", nullable: false),
                    PescoçoD = table.Column<int>(type: "int", nullable: false),
                    CostasSuperiorE = table.Column<int>(type: "int", nullable: false),
                    CostasSuperiorD = table.Column<int>(type: "int", nullable: false),
                    CostasInferiorE = table.Column<int>(type: "int", nullable: false),
                    CostasInferiorD = table.Column<int>(type: "int", nullable: false),
                    OmbroE = table.Column<int>(type: "int", nullable: false),
                    OmbroD = table.Column<int>(type: "int", nullable: false),
                    BraçoE = table.Column<int>(type: "int", nullable: false),
                    BraçoD = table.Column<int>(type: "int", nullable: false),
                    CotoveloE = table.Column<int>(type: "int", nullable: false),
                    CotoveloD = table.Column<int>(type: "int", nullable: false),
                    AntebracoE = table.Column<int>(type: "int", nullable: false),
                    AntebracoD = table.Column<int>(type: "int", nullable: false),
                    PunhoE = table.Column<int>(type: "int", nullable: false),
                    PunhoD = table.Column<int>(type: "int", nullable: false),
                    MaoE = table.Column<int>(type: "int", nullable: false),
                    MaoD = table.Column<int>(type: "int", nullable: false),
                    QuadrilE = table.Column<int>(type: "int", nullable: false),
                    QuadrilD = table.Column<int>(type: "int", nullable: false),
                    CoxaE = table.Column<int>(type: "int", nullable: false),
                    CoxaD = table.Column<int>(type: "int", nullable: false),
                    JoelhoE = table.Column<int>(type: "int", nullable: false),
                    JoelhoD = table.Column<int>(type: "int", nullable: false),
                    PernaE = table.Column<int>(type: "int", nullable: false),
                    PernaD = table.Column<int>(type: "int", nullable: false),
                    TornozeloE = table.Column<int>(type: "int", nullable: false),
                    TornozeloD = table.Column<int>(type: "int", nullable: false),
                    PeE = table.Column<int>(type: "int", nullable: false),
                    PeD = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaisDores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sintomas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Dor = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Cansaco = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Estalos = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Choques = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Dolorimento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Formigamento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReducaoForca = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LimitacaoMovimento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TempoQueixa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sintomas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IMC",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Altura = table.Column<double>(type: "double", nullable: false),
                    Peso = table.Column<double>(type: "double", nullable: false),
                    PessoaId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IMC_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Funcao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SetorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcao_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Cadastro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Turno = table.Column<int>(type: "int", nullable: false),
                    InicioFuncao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SetorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FuncaoId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PessoaId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Funcao_FuncaoId",
                        column: x => x.FuncaoId,
                        principalTable: "Funcao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CensoErgonomico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ColaboradorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IMCId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Fumante = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PraticaExercicio = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SenteDor = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ConsideracaoMotivoDor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SugestaoMelhoria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcoesId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LocaisDoresId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SintomasId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CensoErgonomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CensoErgonomico_Acoes_AcoesId",
                        column: x => x.AcoesId,
                        principalTable: "Acoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CensoErgonomico_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CensoErgonomico_IMC_IMCId",
                        column: x => x.IMCId,
                        principalTable: "IMC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CensoErgonomico_LocaisDores_LocaisDoresId",
                        column: x => x.LocaisDoresId,
                        principalTable: "LocaisDores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CensoErgonomico_Sintomas_SintomasId",
                        column: x => x.SintomasId,
                        principalTable: "Sintomas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Acoes",
                columns: new[] { "Id", "Medicamento", "MelhorFerias", "MelhorFimSemana", "MelhorNoite", "MelhorRevezamento", "PiorAtivDomestica", "PiorFinalDia", "PiorHrExtra", "PiorJornadaNormal" },
                values: new object[] { new Guid("d5ed9484-4ce9-4e7f-abae-cec0c218359d"), 0, false, true, false, false, false, true, false, false });

            migrationBuilder.InsertData(
                table: "LocaisDores",
                columns: new[] { "Id", "AntebracoD", "AntebracoE", "BraçoD", "BraçoE", "CostasInferiorD", "CostasInferiorE", "CostasSuperiorD", "CostasSuperiorE", "CotoveloD", "CotoveloE", "CoxaD", "CoxaE", "JoelhoD", "JoelhoE", "MaoD", "MaoE", "OmbroD", "OmbroE", "PeD", "PeE", "PernaD", "PernaE", "PescoçoD", "PescoçoE", "PunhoD", "PunhoE", "QuadrilD", "QuadrilE", "TornozeloD", "TornozeloE" },
                values: new object[] { new Guid("a3d717bd-08f5-432f-a9d1-be3caf22d81c"), 0, 0, 0, 0, 2, 2, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CPF", "DataNascimento", "Nome", "Sexo" },
                values: new object[] { new Guid("6aa98b55-4643-4633-875a-61aad9537a9b"), "12345678902", new DateTime(2001, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "José da Cunha", 1 });

            migrationBuilder.InsertData(
                table: "Setor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e8edcc59-2de1-40e7-a715-21f292af0bba"), "BENEFICIAMENTO" });

            migrationBuilder.InsertData(
                table: "Sintomas",
                columns: new[] { "Id", "Cansaco", "Choques", "Dolorimento", "Dor", "Estalos", "Formigamento", "LimitacaoMovimento", "ReducaoForca", "TempoQueixa" },
                values: new object[] { new Guid("75fba823-86df-41b7-87e0-4bdc449c2035"), true, false, false, true, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Funcao",
                columns: new[] { "Id", "Nome", "SetorId" },
                values: new object[] { new Guid("b4ca99c4-61ac-4448-854a-5dd086300891"), "BENEFICIAMENTO", new Guid("e8edcc59-2de1-40e7-a715-21f292af0bba") });

            migrationBuilder.InsertData(
                table: "IMC",
                columns: new[] { "Id", "Altura", "Peso", "PessoaId" },
                values: new object[] { new Guid("211fc742-9b1b-4fdc-90d3-33355ff0ef55"), 1.78, 84.0, new Guid("6aa98b55-4643-4633-875a-61aad9537a9b") });

            migrationBuilder.InsertData(
                table: "Colaborador",
                columns: new[] { "Id", "Cadastro", "FuncaoId", "InicioFuncao", "PessoaId", "SetorId", "Turno" },
                values: new object[] { new Guid("db8dbd21-be0c-47ae-a98a-7b79101b8293"), "24644", new Guid("b4ca99c4-61ac-4448-854a-5dd086300891"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6aa98b55-4643-4633-875a-61aad9537a9b"), new Guid("e8edcc59-2de1-40e7-a715-21f292af0bba"), 2 });

            migrationBuilder.InsertData(
                table: "CensoErgonomico",
                columns: new[] { "Id", "AcoesId", "ColaboradorId", "ConsideracaoMotivoDor", "DataCadastro", "Fumante", "IMCId", "LocaisDoresId", "PraticaExercicio", "SenteDor", "SintomasId", "SugestaoMelhoria" },
                values: new object[] { new Guid("5db9b8a5-2765-493b-b94b-ef90e9b283e5"), new Guid("d5ed9484-4ce9-4e7f-abae-cec0c218359d"), new Guid("db8dbd21-be0c-47ae-a98a-7b79101b8293"), "MANUSEAR QUÍMICOS", new DateTime(2023, 4, 12, 20, 9, 51, 488, DateTimeKind.Local).AddTicks(5306), false, new Guid("211fc742-9b1b-4fdc-90d3-33355ff0ef55"), new Guid("a3d717bd-08f5-432f-a9d1-be3caf22d81c"), true, true, new Guid("75fba823-86df-41b7-87e0-4bdc449c2035"), "TROCAR DE BRAÇOS, ALIVIA A DOR DO COTOVELO" });

            migrationBuilder.CreateIndex(
                name: "IX_CensoErgonomico_AcoesId",
                table: "CensoErgonomico",
                column: "AcoesId");

            migrationBuilder.CreateIndex(
                name: "IX_CensoErgonomico_ColaboradorId",
                table: "CensoErgonomico",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_CensoErgonomico_IMCId",
                table: "CensoErgonomico",
                column: "IMCId");

            migrationBuilder.CreateIndex(
                name: "IX_CensoErgonomico_LocaisDoresId",
                table: "CensoErgonomico",
                column: "LocaisDoresId");

            migrationBuilder.CreateIndex(
                name: "IX_CensoErgonomico_SintomasId",
                table: "CensoErgonomico",
                column: "SintomasId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_FuncaoId",
                table: "Colaborador",
                column: "FuncaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_PessoaId",
                table: "Colaborador",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_SetorId",
                table: "Colaborador",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcao_SetorId",
                table: "Funcao",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_IMC_PessoaId",
                table: "IMC",
                column: "PessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CensoErgonomico");

            migrationBuilder.DropTable(
                name: "Acoes");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "IMC");

            migrationBuilder.DropTable(
                name: "LocaisDores");

            migrationBuilder.DropTable(
                name: "Sintomas");

            migrationBuilder.DropTable(
                name: "Funcao");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Setor");
        }
    }
}
