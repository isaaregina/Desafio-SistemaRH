using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaRH.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TarefaID",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "DepartamentoID",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "FuncionarioID",
                table: "Empresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<int>>(
                name: "TarefaID",
                table: "Funcionario",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "DepartamentoID",
                table: "Empresa",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "FuncionarioID",
                table: "Empresa",
                type: "integer[]",
                nullable: false);
        }
    }
}
