using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SorteioHab.Domain.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_participantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    Cpf = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: true),
                    Dt_nascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Renda = table.Column<decimal>(type: "decimal", nullable: false),
                    Cota = table.Column<short>(nullable: false),
                    Cid = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_participantes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_participantes");
        }
    }
}
