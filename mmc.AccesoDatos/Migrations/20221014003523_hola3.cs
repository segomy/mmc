using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace mmc.AccesoDatos.Migrations
{
    public partial class hola3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_IdModelo",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_Modelos_IdSerie",
                table: "Serie");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_IdModelo",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "IdModelo",
                table: "Modelos");

            migrationBuilder.RenameColumn(
                name: "IdSerie",
                table: "Serie",
                newName: "SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Serie_IdSerie",
                table: "Serie",
                newName: "IX_Serie_SerieId");

            migrationBuilder.RenameColumn(
                name: "IdSerie",
                table: "Modelos",
                newName: "SerieId");

            migrationBuilder.RenameColumn(
                name: "IdModelo",
                table: "Marcas",
                newName: "ModeloId");

            migrationBuilder.AlterColumn<int>(
                name: "ModeloId",
                table: "Modelos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_ModeloId",
                table: "Modelos",
                column: "ModeloId",
                principalTable: "Marcas",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_Modelos_SerieId",
                table: "Serie",
                column: "SerieId",
                principalTable: "Modelos",
                principalColumn: "ModeloId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_ModeloId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_Modelos_SerieId",
                table: "Serie");

            migrationBuilder.RenameColumn(
                name: "SerieId",
                table: "Serie",
                newName: "IdSerie");

            migrationBuilder.RenameIndex(
                name: "IX_Serie_SerieId",
                table: "Serie",
                newName: "IX_Serie_IdSerie");

            migrationBuilder.RenameColumn(
                name: "SerieId",
                table: "Modelos",
                newName: "IdSerie");

            migrationBuilder.RenameColumn(
                name: "ModeloId",
                table: "Marcas",
                newName: "IdModelo");

            migrationBuilder.AlterColumn<int>(
                name: "ModeloId",
                table: "Modelos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdModelo",
                table: "Modelos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_IdModelo",
                table: "Modelos",
                column: "IdModelo");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_IdModelo",
                table: "Modelos",
                column: "IdModelo",
                principalTable: "Marcas",
                principalColumn: "MarcaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_Modelos_IdSerie",
                table: "Serie",
                column: "IdSerie",
                principalTable: "Modelos",
                principalColumn: "ModeloId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
