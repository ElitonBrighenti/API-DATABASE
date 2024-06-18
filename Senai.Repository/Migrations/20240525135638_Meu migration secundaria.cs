using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Senai.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Meumigrationsecundaria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Aluno",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Aluno");
        }
    }
}
