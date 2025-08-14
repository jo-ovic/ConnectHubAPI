using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class migra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_respostas_padroes_Usuario_UsuarioId",
                table: "respostas_padroes");

            migrationBuilder.DropIndex(
                name: "IX_respostas_padroes_UsuarioId",
                table: "respostas_padroes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "respostas_padroes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "respostas_padroes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_respostas_padroes_UsuarioId",
                table: "respostas_padroes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_respostas_padroes_Usuario_UsuarioId",
                table: "respostas_padroes",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId");
        }
    }
}
